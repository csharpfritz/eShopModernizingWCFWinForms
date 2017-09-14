using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eShopWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            eShopServiceLibrary.CatalogServiceMock mock = new eShopServiceLibrary.CatalogServiceMock();
            catalogItemDataGridView.DataSource = mock.GetCatalogItems();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void catalogItemDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void catalogItemDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void filterByComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void catalogTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            catalogTypeBindingSource.Filter = string.Format("{0}", catalogTypeComboBox.SelectedValue);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}