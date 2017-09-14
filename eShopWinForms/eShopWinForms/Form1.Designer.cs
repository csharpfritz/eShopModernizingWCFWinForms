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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.catalogItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.catalogBrandBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.catalogTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.catalogBrandBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.catalogItemBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.onReorderDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.maxStockThresholdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.restockThresholdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availableStockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MainCatalog = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.catalogItemDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxAvailable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxBrand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxPicture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.typeFilter = new System.Windows.Forms.Label();
            this.catalogTypeComboBox = new System.Windows.Forms.ComboBox();
            this.catalogBrandComboBox = new System.Windows.Forms.ComboBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            idLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.catalogItemBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogBrandBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogBrandBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogItemBindingSource1)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.MainCatalog.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.catalogItemDataGridView)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // catalogItemBindingSource
            // 
            this.catalogItemBindingSource.DataSource = typeof(eShopServiceLibrary.CatalogItem);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tabControl, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.688073F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94.31193F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(907, 1090);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::eShopWinForms.Properties.Resources.brand;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(213, 50);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // catalogBrandBindingSource
            // 
            this.catalogBrandBindingSource.DataSource = typeof(eShopServiceLibrary.CatalogBrand);
            // 
            // catalogTypeBindingSource
            // 
            this.catalogTypeBindingSource.DataSource = typeof(eShopServiceLibrary.CatalogType);
            // 
            // catalogBrandBindingSource1
            // 
            this.catalogBrandBindingSource1.DataSource = typeof(eShopServiceLibrary.CatalogBrand);
            // 
            // catalogItemBindingSource1
            // 
            this.catalogItemBindingSource1.DataSource = typeof(eShopServiceLibrary.CatalogItem);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.tableLayoutPanel4);
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(885, 976);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Inventory";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(idLabel, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.button1, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.idTextBox, 1, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(178, 128);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(478, 134);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.catalogItemBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(242, 3);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 31);
            this.idTextBox.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(242, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(230, 60);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(3, 0);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(35, 25);
            idLabel.TabIndex = 0;
            idLabel.Text = "Id:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.availableStockDataGridViewTextBoxColumn,
            this.restockThresholdDataGridViewTextBoxColumn,
            this.maxStockThresholdDataGridViewTextBoxColumn,
            this.onReorderDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.catalogItemBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 407);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(879, 517);
            this.dataGridView1.TabIndex = 4;
            // 
            // onReorderDataGridViewCheckBoxColumn
            // 
            this.onReorderDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.onReorderDataGridViewCheckBoxColumn.DataPropertyName = "OnReorder";
            this.onReorderDataGridViewCheckBoxColumn.HeaderText = "OnReorder";
            this.onReorderDataGridViewCheckBoxColumn.Name = "onReorderDataGridViewCheckBoxColumn";
            this.onReorderDataGridViewCheckBoxColumn.Width = 123;
            // 
            // maxStockThresholdDataGridViewTextBoxColumn
            // 
            this.maxStockThresholdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.maxStockThresholdDataGridViewTextBoxColumn.DataPropertyName = "MaxStockThreshold";
            this.maxStockThresholdDataGridViewTextBoxColumn.HeaderText = "MaxStockThreshold";
            this.maxStockThresholdDataGridViewTextBoxColumn.Name = "maxStockThresholdDataGridViewTextBoxColumn";
            this.maxStockThresholdDataGridViewTextBoxColumn.Width = 248;
            // 
            // restockThresholdDataGridViewTextBoxColumn
            // 
            this.restockThresholdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.restockThresholdDataGridViewTextBoxColumn.DataPropertyName = "RestockThreshold";
            this.restockThresholdDataGridViewTextBoxColumn.HeaderText = "RestockThreshold";
            this.restockThresholdDataGridViewTextBoxColumn.Name = "restockThresholdDataGridViewTextBoxColumn";
            this.restockThresholdDataGridViewTextBoxColumn.Width = 231;
            // 
            // availableStockDataGridViewTextBoxColumn
            // 
            this.availableStockDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.availableStockDataGridViewTextBoxColumn.DataPropertyName = "AvailableStock";
            this.availableStockDataGridViewTextBoxColumn.HeaderText = "AvailableStock";
            this.availableStockDataGridViewTextBoxColumn.Name = "availableStockDataGridViewTextBoxColumn";
            this.availableStockDataGridViewTextBoxColumn.Width = 199;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 113;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 74;
            // 
            // MainCatalog
            // 
            this.MainCatalog.Controls.Add(this.tableLayoutPanel2);
            this.MainCatalog.Location = new System.Drawing.Point(8, 39);
            this.MainCatalog.Name = "MainCatalog";
            this.MainCatalog.Padding = new System.Windows.Forms.Padding(3);
            this.MainCatalog.Size = new System.Drawing.Size(885, 976);
            this.MainCatalog.TabIndex = 0;
            this.MainCatalog.Text = "Main Catalog ";
            this.MainCatalog.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.catalogItemDataGridView, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(20, 27);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.866953F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.13305F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(865, 840);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // catalogItemDataGridView
            // 
            this.catalogItemDataGridView.AutoGenerateColumns = false;
            this.catalogItemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.catalogItemDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxPicture,
            this.dataGridViewTextBoxName,
            this.dataGridViewTextBoxDescription,
            this.dataGridViewTextBoxPrice,
            this.dataGridViewTextBoxType,
            this.dataGridViewTextBoxBrand,
            this.dataGridViewTextBoxAvailable});
            this.catalogItemDataGridView.DataSource = this.catalogItemBindingSource;
            this.catalogItemDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.catalogItemDataGridView.Location = new System.Drawing.Point(3, 60);
            this.catalogItemDataGridView.Name = "catalogItemDataGridView";
            this.catalogItemDataGridView.RowTemplate.Height = 33;
            this.catalogItemDataGridView.Size = new System.Drawing.Size(859, 777);
            this.catalogItemDataGridView.TabIndex = 1;
            this.catalogItemDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.catalogItemDataGridView_CellContentClick_1);
            // 
            // dataGridViewTextBoxAvailable
            // 
            this.dataGridViewTextBoxAvailable.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxAvailable.DataPropertyName = "AvailableStock";
            this.dataGridViewTextBoxAvailable.HeaderText = "Availablility";
            this.dataGridViewTextBoxAvailable.Name = "dataGridViewTextBoxAvailable";
            this.dataGridViewTextBoxAvailable.Width = 165;
            // 
            // dataGridViewTextBoxBrand
            // 
            this.dataGridViewTextBoxBrand.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxBrand.DataPropertyName = "CatalogBrand";
            this.dataGridViewTextBoxBrand.HeaderText = "Brand";
            this.dataGridViewTextBoxBrand.Name = "dataGridViewTextBoxBrand";
            this.dataGridViewTextBoxBrand.Width = 114;
            // 
            // dataGridViewTextBoxType
            // 
            this.dataGridViewTextBoxType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxType.DataPropertyName = "CatalogType";
            this.dataGridViewTextBoxType.HeaderText = "Type";
            this.dataGridViewTextBoxType.Name = "dataGridViewTextBoxType";
            this.dataGridViewTextBoxType.Width = 105;
            // 
            // dataGridViewTextBoxPrice
            // 
            this.dataGridViewTextBoxPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxPrice.DataPropertyName = "Price";
            this.dataGridViewTextBoxPrice.HeaderText = "Price";
            this.dataGridViewTextBoxPrice.Name = "dataGridViewTextBoxPrice";
            this.dataGridViewTextBoxPrice.Width = 106;
            // 
            // dataGridViewTextBoxDescription
            // 
            this.dataGridViewTextBoxDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxDescription.DataPropertyName = "Description";
            this.dataGridViewTextBoxDescription.HeaderText = "Description";
            this.dataGridViewTextBoxDescription.Name = "dataGridViewTextBoxDescription";
            this.dataGridViewTextBoxDescription.Width = 165;
            // 
            // dataGridViewTextBoxName
            // 
            this.dataGridViewTextBoxName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxName.DataPropertyName = "Name";
            this.dataGridViewTextBoxName.HeaderText = "Name";
            this.dataGridViewTextBoxName.Name = "dataGridViewTextBoxName";
            this.dataGridViewTextBoxName.Width = 113;
            // 
            // dataGridViewTextBoxPicture
            // 
            this.dataGridViewTextBoxPicture.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxPicture.DataPropertyName = "PictureUri";
            this.dataGridViewTextBoxPicture.HeaderText = "";
            this.dataGridViewTextBoxPicture.Name = "dataGridViewTextBoxPicture";
            this.dataGridViewTextBoxPicture.Width = 37;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoScroll = true;
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.8125F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.1875F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 87F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 137F));
            this.tableLayoutPanel3.Controls.Add(this.catalogBrandComboBox, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.catalogTypeComboBox, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.typeFilter, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label1, 2, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(629, 51);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(407, 0);
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
            // catalogTypeComboBox
            // 
            this.catalogTypeComboBox.DataSource = this.catalogTypeBindingSource;
            this.catalogTypeComboBox.DisplayMember = "Type";
            this.catalogTypeComboBox.FormattingEnabled = true;
            this.catalogTypeComboBox.Location = new System.Drawing.Point(135, 3);
            this.catalogTypeComboBox.Name = "catalogTypeComboBox";
            this.catalogTypeComboBox.Size = new System.Drawing.Size(266, 33);
            this.catalogTypeComboBox.TabIndex = 2;
            this.catalogTypeComboBox.ValueMember = "Id";
            this.catalogTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.catalogTypeComboBox_SelectedIndexChanged);
            // 
            // catalogBrandComboBox
            // 
            this.catalogBrandComboBox.DataSource = this.catalogBrandBindingSource1;
            this.catalogBrandComboBox.DisplayMember = "Brand";
            this.catalogBrandComboBox.FormattingEnabled = true;
            this.catalogBrandComboBox.Location = new System.Drawing.Point(494, 3);
            this.catalogBrandComboBox.Name = "catalogBrandComboBox";
            this.catalogBrandComboBox.Size = new System.Drawing.Size(132, 33);
            this.catalogBrandComboBox.TabIndex = 3;
            this.catalogBrandComboBox.ValueMember = "Brand";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.MainCatalog);
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Location = new System.Drawing.Point(3, 64);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(901, 1023);
            this.tabControl.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 1114);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "eShop WinForms";
            ((System.ComponentModel.ISupportInitialize)(this.catalogItemBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogBrandBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogBrandBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogItemBindingSource1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.MainCatalog.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.catalogItemDataGridView)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource catalogItemBindingSource;
        private System.Windows.Forms.BindingSource catalogBrandBindingSource;
        private System.Windows.Forms.BindingSource catalogBrandBindingSource1;
        private System.Windows.Forms.BindingSource catalogTypeBindingSource;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage MainCatalog;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ComboBox catalogBrandComboBox;
        private System.Windows.Forms.ComboBox catalogTypeComboBox;
        private System.Windows.Forms.Label typeFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView catalogItemDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxPicture;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxBrand;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxAvailable;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn availableStockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn restockThresholdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxStockThresholdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn onReorderDataGridViewCheckBoxColumn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.BindingSource catalogItemBindingSource1;
    }
}

