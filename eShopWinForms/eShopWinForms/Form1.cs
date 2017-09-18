using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eShopServiceLibrary;
using System.Reflection;
using System.Linq.Expressions;

namespace eShopWinForms
{
    public partial class Form1 : Form
    {
        //Start service 
        //eShopServiceReference.ICatalogService service = new eShopServiceReference.CatalogServiceClient();
        CatalogServiceMock service = new CatalogServiceMock();

        public Form1()
        {
            InitializeComponent();

            //Load Initial Data
            LoadCatalogData(service);

            // Adjust Column Display
            AllFilter();

            LoadTypeComboBox(service);
            LoadBrandComboBox(service);

            LoadListBox(service);

        }


        private void catalogItemDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadCatalogData(CatalogServiceMock service)
        {
            IEnumerable<CatalogItem> items = service.GetCatalogItems();
            //IList<CatalogItem> itemsList = items.ToList();

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
            catalogItemDataGridView.Columns.Insert(0, imgcol);

            // Add columns to datagrid
            //int col_num = 0;
            foreach (var property in itemProperties)
            {
                string name = property.Name;
                catalogItemDataGridView.Columns.Add(name.ToString(), name);
                //col_num++;
            }

            
            // Load data into columns
            foreach (var catalogitem in items)
            {
                Image thumb = null;
                DataGridViewRow row = (DataGridViewRow)catalogItemDataGridView.Rows[0].Clone();
                int column = 1;
                foreach (var property in itemProperties)
                {
                    string name = property.Name;
                    object value = property.Getter(catalogitem);
                    row.Cells[column].Value = "" + value;

                    if (name.Equals("PictureFileName"))
                    {
                        //We can change this to relative path dont worry
                        string imagename = "C:\\git\\eShopModernizingWCFWinForms\\eShopWinForms\\eShopWinForms\\Assets\\Images\\Catalog\\" + value;
                        Image img = Image.FromFile(imagename);
                        thumb = img.GetThumbnailImage(192, 108, null, IntPtr.Zero);
                        //catalogItemDataGridView.Rows.Insert(0, thumb, 1);
                        row.Cells[0].Value = thumb;
                    }
                    //catalogItemDataGridView.Rows.Insert(0, thumb, 1);
                    column++;
                }
                catalogItemDataGridView.Rows.Add(row);

            }

        }

        private void LoadTypeComboBox(CatalogServiceMock service)
        {
            //Create IEnumerable List
            IEnumerable<CatalogType> types = service.GetCatalogTypes();

            //Get bound CatalogType data
            var typeProperties = (from prop in typeof(CatalogType).GetProperties(BindingFlags.Public | BindingFlags.Instance)
                                  let parameter = Expression.Parameter(typeof(CatalogType), "obj")
                                  let property = Expression.Property(parameter, prop)
                                  let lambda = Expression.Lambda<Func<CatalogType, object>>(Expression.Convert(property, typeof(object)), parameter).Compile()
                                  select
                                  new
                                  {
                                      Getter = lambda,
                                      Name = prop.Name
                                  }).ToArray();

            //Load Type ComboBoxData

            //Create "All" filter
            catalogTypeComboBox.Items.Add("All");
            catalogTypeComboBox.SelectedItem = "All";

            // Add rest of type filters
            foreach (var catalogtype in types)
            {
                foreach (var property in typeProperties)
                {
                    string name = property.Name;
                    object value = property.Getter(catalogtype);
                    if (name == "Id")
                    {
                        catalogTypeComboBox.Items.Add(value);
                    }

                }

            }
        }

        private void LoadBrandComboBox(CatalogServiceMock service)
        {

            IEnumerable<CatalogBrand> brands = service.GetCatalogBrands();


            //Get bound CatalogBrand data
            var brandProperties = (from prop in typeof(CatalogBrand).GetProperties(BindingFlags.Public | BindingFlags.Instance)
                                   let parameter = Expression.Parameter(typeof(CatalogBrand), "obj")
                                   let property = Expression.Property(parameter, prop)
                                   let lambda = Expression.Lambda<Func<CatalogBrand, object>>(Expression.Convert(property, typeof(object)), parameter).Compile()
                                   select
                                   new
                                   {
                                       Getter = lambda,
                                       Name = prop.Name
                                   }).ToArray();
            
            
            //Load Brand ComboBoxData

            //Create "All" filter
            catalogBrandComboBox.Items.Add("All");
            catalogBrandComboBox.SelectedItem = "All";

            // Add rest of type filters
            foreach (var catalogbrand in brands)
            {
                foreach (var property in brandProperties)
                {
                    string name = property.Name;
                    object value = property.Getter(catalogbrand);
                    if (name == "Id")
                    {
                        catalogBrandComboBox.Items.Add(value);
                    }

                }

            }
        }

        private void AllFilter()
        {
            catalogItemDataGridView.Columns["Id"].Visible = false;
            //catalogItemDataGridView.Columns["AvailableStock"].Visible = false;
            catalogItemDataGridView.Columns["PictureFileName"].Visible = false;
            catalogItemDataGridView.Columns["CatalogBrandId"].Visible = false;
            catalogItemDataGridView.Columns["CatalogTypeId"].Visible = false;
            catalogItemDataGridView.Columns["CatalogBrand"].Visible = false;
            catalogItemDataGridView.Columns["CatalogType"].Visible = false;
            catalogItemDataGridView.Columns["Name"].DisplayIndex = 1;
            catalogItemDataGridView.Columns["Description"].DisplayIndex = 2;
            catalogItemDataGridView.Columns["Price"].DisplayIndex = 3;

            for (int i = 0; i < catalogItemDataGridView.RowCount - 1; i++)
            {
                catalogItemDataGridView.Rows[i].Visible = true;
            }
        }

        private void TypeFilter()
        {
            var selectedTypeValue = catalogTypeComboBox.SelectedItem.ToString();
           
            for (int i = 0; i < catalogItemDataGridView.RowCount-1; i++)
            {
                var rowTypeValue = catalogItemDataGridView["CatalogTypeId", i].Value.ToString();
                
                if (selectedTypeValue == "All")
                {
                    AllFilter();
                }

                else if (rowTypeValue == selectedTypeValue)
                {
                    catalogItemDataGridView.Rows[i].Visible = true;
                }

                else
                {
                    catalogItemDataGridView.Rows[i].Visible = false;
                }
            }
            
        }

        private void BrandFilter()
        {
            var selectedBrandValue = catalogBrandComboBox.SelectedItem.ToString();

            for (int i = 0; i < catalogItemDataGridView.RowCount - 1; i++)
            {
                var rowBrandValue = catalogItemDataGridView["CatalogBrandId", i].Value.ToString();
                if (selectedBrandValue == "All" || selectedBrandValue == "")
                {
                    AllFilter();
                }
                else if (rowBrandValue == selectedBrandValue)
                {
                    catalogItemDataGridView.Rows[i].Visible = true;
                }
                else
                {
                    catalogItemDataGridView.Rows[i].Visible = false;
                }
            }

        }

        private void LoadListBox(CatalogServiceMock service)
        {
            IEnumerable<CatalogItem> items = service.GetCatalogItems();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = listBox1.SelectedItem.ToString();
            string fakeAvail = "test";
            ListViewItem lvi = new ListViewItem(id);
            lvi.SubItems.Add(fakeAvail);
            listView1.Items.Add(lvi);

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void catalogTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            TypeFilter();

        }

        private void catalogBrandComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            BrandFilter();
        }
    }

}
