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

namespace eShopWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadInitialData();
        }

        private void catalogTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            catalogItemBindingSource.Filter= string.Format("{0}", catalogTypeComboBox.SelectedValue);
            
        }

        private void catalogItemDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadInitialData()
        {
            CatalogServiceMock mock = new CatalogServiceMock();
            IEnumerable<CatalogItem> items = mock.GetCatalogItems();
            IList<CatalogItem> itemsList = items.ToList();
            
            //Load Image Column
            DataGridViewImageColumn imgcol = new DataGridViewImageColumn();
            catalogItemDataGridView.Columns.Insert(0, imgcol);
            
            for (int i = 0; i < itemsList.Count; i++)
            {
                catalogItemDataGridView.Rows.Add();
                Image img = Image.FromFile("C:/IgniteDemo/eShopModernizingWCFWinForms/eShopWinForms/eShopWinForms/Assets/Images/Catalog/" + itemsList[i].PictureFileName);
                Image thumb = img.GetThumbnailImage(192, 108, null, IntPtr.Zero);
                catalogItemDataGridView[0, i].Value = thumb;

                //Load ListBoxData
                //listBox1.DataSource = itemsList[i].Id;
                listBox1.DataSource = itemsList;
            }
            
            //Load other data
            //catalogItemDataGridView.AutoGenerateColumns = false;
            //catalogItemDataGridView.DataSource = itemsList;
            
            //Load ComboBoxData
            //catalogTypeComboBox.Items[0] = "All";
            catalogTypeComboBox.DataSource = mock.GetCatalogTypes();
            catalogBrandComboBox.DataSource = mock.GetCatalogBrands();

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

       
    }

}