using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Linq.Expressions;
using eShopWinForms.eShopServiceReference;
using System.Net.Http;
using eShopWinForms.Controllers;

namespace eShopWinForms
{
    public partial class CatalogView : Form, ICatalogView
    {
        public CatalogView()
        {
            InitializeComponent();
        }

        private CatalogController _controller;
        public event ViewHandler<ICatalogView> filterChanged;
        public event SearchStockHandler<ICatalogView> searchStockButtonClicked;
        public event AvailabilityHandler<ICatalogView> availabilityButtonClicked;
        
        public void SetController(CatalogController controller)
        {
            _controller = controller;
        }

        public void ClearGrid()
        {
            catalogItemDataGridView.Rows.Clear();
            catalogItemDataGridView.Refresh();
        }

        public void SetCatalogItems(IEnumerable<CatalogItem> items, double discountVal)
        {
            //Get bound CatalogItem data
            var itemProperties = (from prop in typeof(CatalogItem).GetProperties(BindingFlags.Public | BindingFlags.Instance)
                                  let parameter = Expression.Parameter(typeof(CatalogItem), "obj")
                                  let property = Expression.Property(parameter, prop)
                                  let lambda = Expression.Lambda<Func<CatalogItem, object>>(Expression.Convert(property, typeof(object)), parameter).Compile()
                                  select
                                  new
                                  {
                                      Getter = lambda,
                                      Name = prop.Name
                                  }).ToArray();

            //Create image column
            DataGridViewImageColumn imgcol = new DataGridViewImageColumn();
            catalogItemDataGridView.Columns.Clear();
            catalogItemDataGridView.Columns.Insert(0, imgcol);

            // Add columns to datagrid
            foreach (var property in itemProperties)
            {
                string name = property.Name;
                catalogItemDataGridView.Columns.Add(name.ToString(), name);
            }

            // Load data into columns
            foreach (var catalogitem in items)
            {
                Image thumb = null;
                DataGridViewRow row = new DataGridViewRow();
                foreach (var property in itemProperties)
                {
                    DataGridViewCell newCell;
                    string name = property.Name;
                    object value = property.Getter(catalogitem);

                    if (name.Equals("Picturefilename"))
                    {
                        //We can change this to relative path dont worry
                        string imagename = Environment.CurrentDirectory + "\\..\\..\\Assets\\Images\\Catalog\\" + value;
                        Image img = Image.FromFile(imagename);
                        thumb = img.GetThumbnailImage(384, 216, null, IntPtr.Zero);
                        //catalogItemDataGridView.Rows.Insert(0, thumb, 1);

                        newCell = new DataGridViewImageCell();
                        newCell.Value = thumb;
                    }
                    else if (name.Equals("Price"))
                    {
                        double price = double.Parse(value.ToString());
                        double discountPrice = price * (1 - discountVal);
                        newCell = new DataGridViewTextBoxCell();
                        newCell.Value = "$" + discountPrice.ToString("F");
                    }
                    else
                    {
                        newCell = new DataGridViewTextBoxCell();
                        newCell.Value =  value;
                    }

                    row.Cells.Add(newCell);
                }

                catalogItemDataGridView.Rows.Add(row);
            }

            catalogItemDataGridView.Columns[""].Visible = false;
            catalogItemDataGridView.Columns["Id"].Visible = false;
            catalogItemDataGridView.Columns["Picturefilename"].Visible = false;
            catalogItemDataGridView.Columns["CatalogBrandId"].Visible = false;
            catalogItemDataGridView.Columns["CatalogTypeId"].Visible = false;
            catalogItemDataGridView.Columns["CatalogBrand"].Visible = false;
            catalogItemDataGridView.Columns["CatalogType"].Visible = false;
            catalogItemDataGridView.Columns["ExtensionData"].Visible = false;
            catalogItemDataGridView.Columns["Name"].DisplayIndex = 1;
            catalogItemDataGridView.Columns["Description"].DisplayIndex = 2;
            catalogItemDataGridView.Columns["Price"].DisplayIndex = 3;
            catalogItemDataGridView.Columns["Name"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            catalogItemDataGridView.Columns["Description"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            catalogItemDataGridView.Columns["Price"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            catalogItemDataGridView.Columns["Price"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            catalogItemDataGridView.AllowUserToAddRows = false;
        }


        public void SetDiscountBanner(String text)
        {
            discountBanner.Text = text;
        }

        public void SetTypeFilter(Dictionary<int, string> typeFilters)
        {
            catalogTypeComboBox.DataSource = new BindingSource(typeFilters, null);
            catalogTypeComboBox.DisplayMember = "Value";
            catalogTypeComboBox.ValueMember = "Key";
        }

        public void SetBrandFilter(Dictionary<int, string> brandFilter)
        {
            catalogBrandComboBox.DataSource = new BindingSource(brandFilter, null);
            catalogBrandComboBox.DisplayMember = "Value";
            catalogBrandComboBox.ValueMember = "Key";
        }

        private void catalogBrandComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int brandId = 0;
            int typeId = 0;

            if (catalogBrandComboBox.SelectedItem != null)
                brandId = ((KeyValuePair<int, string>)catalogBrandComboBox.SelectedItem).Key;

            if (catalogTypeComboBox.SelectedItem != null)
                typeId = ((KeyValuePair<int, string>)catalogTypeComboBox.SelectedItem).Key;

            filterChanged.Invoke(this, new FilterEventArgs(typeId, brandId));
        }

        private void catalogTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int brandId = 0;
            int typeId = 0;

            if (catalogBrandComboBox.SelectedItem != null)
                brandId = ((KeyValuePair<int, string>)catalogBrandComboBox.SelectedItem).Key;

            if (catalogTypeComboBox.SelectedItem != null)
                typeId = ((KeyValuePair<int, string>)catalogTypeComboBox.SelectedItem).Key;

            filterChanged.Invoke(this, new FilterEventArgs(typeId, brandId));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] separator = new string[] { " - " };
            string[] results = listBox1.SelectedItem.ToString().Split(separator, StringSplitOptions.None);

            DateTime date = monthCalendar1.SelectionRange.Start.Date;
            int id = int.Parse(results[0]);

            SearchStockEventArgs ex = new SearchStockEventArgs(id, date);
            searchStockButtonClicked.Invoke(this, ex);

            ListViewItem lvi = new ListViewItem(date.ToShortDateString());
            lvi.SubItems.Add(id.ToString());
            listView1.Items.Add(lvi);
        }

        private void addAvailabilityButton_Click(object sender, EventArgs e)
        {
            if (productIdInput.SelectedItem == null || String.IsNullOrEmpty(quantityInput.Text) || String.IsNullOrEmpty(arrivalDateInput.Text))
                return;

            int id = (int)productIdInput.SelectedItem;
            int quantity = int.Parse(quantityInput.Text);
            DateTime shipDate = Convert.ToDateTime(arrivalDateInput.Text);

            AvailabilityEventArgs args = new AvailabilityEventArgs(id, quantity, shipDate);
            availabilityButtonClicked.Invoke(this, args);
        }

        public void ShowStockAvailability(int availability)
        {
            //lvi.SubItems.Add(availability.ToString());
            listView1.Columns[0].Width = -1;
            listView1.Columns[1].Width = -2;
            listView1.Columns[2].Width = -2;
        }

        public void NotifyAvailabilityUpdated()
        {
            MessageBox.Show("Shipment has been added to the database.");

            productIdInput.ResetText();
            quantityInput.Clear();
            arrivalDateInput.Clear();
        }
    }
}
