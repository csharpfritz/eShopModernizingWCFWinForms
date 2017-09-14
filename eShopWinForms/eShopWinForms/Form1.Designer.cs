namespace eShopWinForms
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.catalogItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.MainCatalog = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.catalogBrandComboBox = new System.Windows.Forms.ComboBox();
            this.catalogBrandBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.catalogTypeComboBox = new System.Windows.Forms.ComboBox();
            this.catalogTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.typeFilter = new System.Windows.Forms.Label();
            this.catalogItemDataGridView = new System.Windows.Forms.DataGridView();
            this.PictureFileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxBrand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.catalogItemBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.idHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.availHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.catalogBrandBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.catalogItemBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.catalogItemBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl.SuspendLayout();
            this.MainCatalog.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.catalogBrandBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogItemDataGridView)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.catalogItemBindingSource2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogBrandBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogItemBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // catalogItemBindingSource
            // 
            this.catalogItemBindingSource.DataSource = typeof(eShopServiceLibrary.CatalogItem);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tabControl, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox2, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.43439F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.56561F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1024F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(907, 1293);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::eShopWinForms.Properties.Resources.brand;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(213, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.MainCatalog);
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Location = new System.Drawing.Point(3, 228);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(901, 991);
            this.tabControl.TabIndex = 0;
            // 
            // MainCatalog
            // 
            this.MainCatalog.Controls.Add(this.tableLayoutPanel2);
            this.MainCatalog.Location = new System.Drawing.Point(8, 39);
            this.MainCatalog.Name = "MainCatalog";
            this.MainCatalog.Padding = new System.Windows.Forms.Padding(3);
            this.MainCatalog.Size = new System.Drawing.Size(885, 944);
            this.MainCatalog.TabIndex = 0;
            this.MainCatalog.Text = "Main Catalog ";
            this.MainCatalog.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.catalogItemDataGridView, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.866953F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.13305F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(895, 942);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoScroll = true;
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.8125F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.1875F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 87F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 144F));
            this.tableLayoutPanel3.Controls.Add(this.catalogBrandComboBox, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.catalogTypeComboBox, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label1, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.typeFilter, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(629, 51);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // catalogBrandComboBox
            // 
            this.catalogBrandComboBox.DataSource = this.catalogBrandBindingSource1;
            this.catalogBrandComboBox.DisplayMember = "Brand";
            this.catalogBrandComboBox.FormattingEnabled = true;
            this.catalogBrandComboBox.Location = new System.Drawing.Point(487, 3);
            this.catalogBrandComboBox.Name = "catalogBrandComboBox";
            this.catalogBrandComboBox.Size = new System.Drawing.Size(132, 33);
            this.catalogBrandComboBox.TabIndex = 3;
            this.catalogBrandComboBox.ValueMember = "Brand";
            // 
            // catalogBrandBindingSource1
            // 
            this.catalogBrandBindingSource1.DataSource = typeof(eShopServiceLibrary.CatalogBrand);
            // 
            // catalogTypeComboBox
            // 
            this.catalogTypeComboBox.DataSource = this.catalogTypeBindingSource;
            this.catalogTypeComboBox.DisplayMember = "Type";
            this.catalogTypeComboBox.FormattingEnabled = true;
            this.catalogTypeComboBox.Location = new System.Drawing.Point(133, 3);
            this.catalogTypeComboBox.Name = "catalogTypeComboBox";
            this.catalogTypeComboBox.Size = new System.Drawing.Size(261, 33);
            this.catalogTypeComboBox.TabIndex = 2;
            this.catalogTypeComboBox.ValueMember = "Id";
            this.catalogTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.catalogTypeComboBox_SelectedIndexChanged);
            // 
            // catalogTypeBindingSource
            // 
            this.catalogTypeBindingSource.DataSource = typeof(eShopServiceLibrary.CatalogType);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(400, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Brand";
            // 
            // typeFilter
            // 
            this.typeFilter.AutoSize = true;
            this.typeFilter.Location = new System.Drawing.Point(3, 0);
            this.typeFilter.Name = "typeFilter";
            this.typeFilter.Size = new System.Drawing.Size(60, 25);
            this.typeFilter.TabIndex = 0;
            this.typeFilter.Text = "Type";
            // 
            // catalogItemDataGridView
            // 
            this.catalogItemDataGridView.AutoGenerateColumns = false;
            this.catalogItemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.catalogItemDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PictureFileName,
            this.dataGridViewTextBoxName,
            this.dataGridViewTextBoxDescription,
            this.dataGridViewTextBoxPrice,
            this.dataGridViewTextBoxType,
            this.dataGridViewTextBoxBrand});
            this.catalogItemDataGridView.DataSource = this.catalogItemBindingSource;
            this.catalogItemDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.catalogItemDataGridView.Location = new System.Drawing.Point(3, 67);
            this.catalogItemDataGridView.Name = "catalogItemDataGridView";
            this.catalogItemDataGridView.RowTemplate.Height = 33;
            this.catalogItemDataGridView.Size = new System.Drawing.Size(889, 872);
            this.catalogItemDataGridView.TabIndex = 1;
            this.catalogItemDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.catalogItemDataGridView_CellContentClick_1);
            // 
            // PictureFileName
            // 
            this.PictureFileName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.PictureFileName.DataPropertyName = "PictureFileName";
            this.PictureFileName.HeaderText = "";
            this.PictureFileName.Name = "PictureFileName";
            this.PictureFileName.Width = 37;
            // 
            // dataGridViewTextBoxName
            // 
            this.dataGridViewTextBoxName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxName.DataPropertyName = "Name";
            this.dataGridViewTextBoxName.HeaderText = "Name";
            this.dataGridViewTextBoxName.Name = "dataGridViewTextBoxName";
            this.dataGridViewTextBoxName.Width = 113;
            // 
            // dataGridViewTextBoxDescription
            // 
            this.dataGridViewTextBoxDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxDescription.DataPropertyName = "Description";
            this.dataGridViewTextBoxDescription.HeaderText = "Description";
            this.dataGridViewTextBoxDescription.Name = "dataGridViewTextBoxDescription";
            this.dataGridViewTextBoxDescription.Width = 165;
            // 
            // dataGridViewTextBoxPrice
            // 
            this.dataGridViewTextBoxPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxPrice.DataPropertyName = "Price";
            this.dataGridViewTextBoxPrice.HeaderText = "Price";
            this.dataGridViewTextBoxPrice.Name = "dataGridViewTextBoxPrice";
            this.dataGridViewTextBoxPrice.Width = 106;
            // 
            // dataGridViewTextBoxType
            // 
            this.dataGridViewTextBoxType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxType.DataPropertyName = "CatalogType";
            this.dataGridViewTextBoxType.HeaderText = "Type";
            this.dataGridViewTextBoxType.Name = "dataGridViewTextBoxType";
            this.dataGridViewTextBoxType.Width = 105;
            // 
            // dataGridViewTextBoxBrand
            // 
            this.dataGridViewTextBoxBrand.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxBrand.DataPropertyName = "CatalogBrand";
            this.dataGridViewTextBoxBrand.HeaderText = "Brand";
            this.dataGridViewTextBoxBrand.Name = "dataGridViewTextBoxBrand";
            this.dataGridViewTextBoxBrand.Width = 114;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.tableLayoutPanel4);
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(885, 917);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Inventory";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.monthCalendar1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.groupBox2, 1, 1);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 10);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.91904F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59.08096F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(840, 914);
            this.tableLayoutPanel4.TabIndex = 5;
            this.tableLayoutPanel4.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel4_Paint);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(9, 9);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(3, 377);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 532);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Id of product from list and click \"Search\" to find stock availability.";
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.catalogItemBindingSource2;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(12, 69);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(396, 304);
            this.listBox1.TabIndex = 5;
            // 
            // catalogItemBindingSource2
            // 
            this.catalogItemBindingSource2.DataSource = typeof(eShopServiceLibrary.CatalogItem);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(99, 397);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 89);
            this.button1.TabIndex = 7;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listView1);
            this.groupBox2.Location = new System.Drawing.Point(423, 377);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(414, 534);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Results";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idHeader,
            this.availHeader});
            this.listView1.Location = new System.Drawing.Point(15, 69);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(393, 304);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // idHeader
            // 
            this.idHeader.Text = "Id";
            this.idHeader.Width = 100;
            // 
            // availHeader
            // 
            this.availHeader.Text = "Availability";
            this.availHeader.Width = 200;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.Image = global::eShopWinForms.Properties.Resources.main_banner;
            this.pictureBox3.Location = new System.Drawing.Point(3, 58);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(901, 164);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::eShopWinForms.Properties.Resources.main_footer_text;
            this.pictureBox2.Location = new System.Drawing.Point(3, 1252);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(348, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // catalogBrandBindingSource
            // 
            this.catalogBrandBindingSource.DataSource = typeof(eShopServiceLibrary.CatalogBrand);
            // 
            // catalogItemBindingSource1
            // 
            this.catalogItemBindingSource1.DataSource = typeof(eShopServiceLibrary.CatalogItem);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(930, 1317);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "eShop WinForms";
            ((System.ComponentModel.ISupportInitialize)(this.catalogItemBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.MainCatalog.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.catalogBrandBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogItemDataGridView)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.catalogItemBindingSource2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogBrandBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogItemBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource catalogItemBindingSource;
        private System.Windows.Forms.BindingSource catalogBrandBindingSource;
        private System.Windows.Forms.BindingSource catalogBrandBindingSource1;
        private System.Windows.Forms.BindingSource catalogTypeBindingSource;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ComboBox catalogBrandComboBox;
        private System.Windows.Forms.ComboBox catalogTypeComboBox;
        private System.Windows.Forms.Label typeFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView catalogItemDataGridView;
        private System.Windows.Forms.BindingSource catalogItemBindingSource1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage MainCatalog;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.BindingSource catalogItemBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn PictureFileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxBrand;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader idHeader;
        private System.Windows.Forms.ColumnHeader availHeader;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

