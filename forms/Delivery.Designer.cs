namespace Inventory_System.forms
{
    partial class Delivery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Delivery));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBrand = new System.Windows.Forms.ComboBox();
            this.txtItemName = new System.Windows.Forms.ComboBox();
            this.cmbSupp = new System.Windows.Forms.ComboBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtItemPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtOrderTerms = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddDeliver = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dtDeliveryDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgDelivery = new System.Windows.Forms.DataGridView();
            this.Information = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gcitemnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcitemqtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcitemsuppDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcitembrandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcitemcostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcitemstatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gc_order_terms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gc_delivery_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gc_item_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gc_item_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gc_item_srp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gc_item_desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gc_item_um = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gcDataSet1 = new Inventory_System.gcDataSet();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chkItemCode = new System.Windows.Forms.CheckBox();
            this.chkItemName = new System.Windows.Forms.CheckBox();
            this.btnSearch = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.deliveryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gcDataSet = new Inventory_System.gcDataSet();
            this.deliveryTableAdapter = new Inventory_System.gcDataSetTableAdapters.deliveryTableAdapter();
            this.inventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryTableAdapter = new Inventory_System.gcDataSetTableAdapters.inventoryTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDelivery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDataSet1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtBrand);
            this.panel1.Controls.Add(this.txtItemName);
            this.panel1.Controls.Add(this.cmbSupp);
            this.panel1.Controls.Add(this.txtQty);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtItemPrice);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtOrderTerms);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnAddDeliver);
            this.panel1.Controls.Add(this.dtDeliveryDate);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 139);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 695);
            this.panel1.TabIndex = 0;
            // 
            // txtBrand
            // 
            this.txtBrand.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrand.FormattingEnabled = true;
            this.txtBrand.Location = new System.Drawing.Point(16, 402);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(316, 39);
            this.txtBrand.TabIndex = 28;
            // 
            // txtItemName
            // 
            this.txtItemName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemName.FormattingEnabled = true;
            this.txtItemName.Location = new System.Drawing.Point(16, 256);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(316, 39);
            this.txtItemName.TabIndex = 27;
            this.txtItemName.TextChanged += new System.EventHandler(this.txtItemName_TextChanged);
            // 
            // cmbSupp
            // 
            this.cmbSupp.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSupp.FormattingEnabled = true;
            this.cmbSupp.Location = new System.Drawing.Point(17, 331);
            this.cmbSupp.Name = "cmbSupp";
            this.cmbSupp.Size = new System.Drawing.Size(316, 39);
            this.cmbSupp.TabIndex = 3;
            this.cmbSupp.TextChanged += new System.EventHandler(this.cmbSupp_TextChanged);
            // 
            // txtQty
            // 
            this.txtQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQty.Location = new System.Drawing.Point(172, 555);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(160, 34);
            this.txtQty.TabIndex = 26;
            this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQty_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(169, 531);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 17);
            this.label8.TabIndex = 25;
            this.label8.Text = "Quantity";
            // 
            // txtItemPrice
            // 
            this.txtItemPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemPrice.Location = new System.Drawing.Point(19, 555);
            this.txtItemPrice.Name = "txtItemPrice";
            this.txtItemPrice.Size = new System.Drawing.Size(121, 34);
            this.txtItemPrice.TabIndex = 24;
            this.txtItemPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtItemPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtItemPrice_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(16, 531);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 17);
            this.label7.TabIndex = 23;
            this.label7.Text = "Price per item";
            // 
            // txtOrderTerms
            // 
            this.txtOrderTerms.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderTerms.Location = new System.Drawing.Point(172, 480);
            this.txtOrderTerms.Name = "txtOrderTerms";
            this.txtOrderTerms.Size = new System.Drawing.Size(160, 34);
            this.txtOrderTerms.TabIndex = 22;
            this.txtOrderTerms.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtOrderTerms.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOrderTerms_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(169, 456);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Order Terms";
            // 
            // btnAddDeliver
            // 
            this.btnAddDeliver.Activecolor = System.Drawing.Color.MidnightBlue;
            this.btnAddDeliver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddDeliver.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAddDeliver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddDeliver.BorderRadius = 0;
            this.btnAddDeliver.ButtonText = "Save Delivery Date";
            this.btnAddDeliver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddDeliver.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddDeliver.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddDeliver.Iconimage = null;
            this.btnAddDeliver.Iconimage_right = null;
            this.btnAddDeliver.Iconimage_right_Selected = null;
            this.btnAddDeliver.Iconimage_Selected = null;
            this.btnAddDeliver.IconMarginLeft = 0;
            this.btnAddDeliver.IconMarginRight = 0;
            this.btnAddDeliver.IconRightVisible = true;
            this.btnAddDeliver.IconRightZoom = 0D;
            this.btnAddDeliver.IconVisible = true;
            this.btnAddDeliver.IconZoom = 40D;
            this.btnAddDeliver.IsTab = false;
            this.btnAddDeliver.Location = new System.Drawing.Point(17, 621);
            this.btnAddDeliver.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddDeliver.Name = "btnAddDeliver";
            this.btnAddDeliver.Normalcolor = System.Drawing.Color.CornflowerBlue;
            this.btnAddDeliver.OnHovercolor = System.Drawing.Color.MidnightBlue;
            this.btnAddDeliver.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddDeliver.selected = false;
            this.btnAddDeliver.Size = new System.Drawing.Size(315, 56);
            this.btnAddDeliver.TabIndex = 20;
            this.btnAddDeliver.Text = "Save Delivery Date";
            this.btnAddDeliver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddDeliver.Textcolor = System.Drawing.Color.White;
            this.btnAddDeliver.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDeliver.Click += new System.EventHandler(this.btnAddDeliver_Click);
            // 
            // dtDeliveryDate
            // 
            this.dtDeliveryDate.CustomFormat = "MM/dd/yyyy";
            this.dtDeliveryDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDeliveryDate.Location = new System.Drawing.Point(17, 488);
            this.dtDeliveryDate.Name = "dtDeliveryDate";
            this.dtDeliveryDate.Size = new System.Drawing.Size(123, 22);
            this.dtDeliveryDate.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(14, 456);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Delivery Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(14, 382);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Item Brand";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(14, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Item Supplier";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(14, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Item Name";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Location = new System.Drawing.Point(-1, 213);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(349, 12);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(31, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(273, 162);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dgDelivery
            // 
            this.dgDelivery.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgDelivery.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgDelivery.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgDelivery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDelivery.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Information,
            this.gcitemnameDataGridViewTextBoxColumn,
            this.gcitemqtyDataGridViewTextBoxColumn,
            this.gcitemsuppDataGridViewTextBoxColumn,
            this.gcitembrandDataGridViewTextBoxColumn,
            this.gcitemcostDataGridViewTextBoxColumn,
            this.gcitemstatusDataGridViewTextBoxColumn,
            this.gc_order_terms,
            this.gc_delivery_date,
            this.gc_item_code,
            this.gc_item_type,
            this.gc_item_srp,
            this.gc_item_desc,
            this.gc_item_um});
            this.dgDelivery.DataSource = this.deliveryBindingSource1;
            this.dgDelivery.EnableHeadersVisualStyles = false;
            this.dgDelivery.Location = new System.Drawing.Point(387, 13);
            this.dgDelivery.Name = "dgDelivery";
            this.dgDelivery.RowTemplate.Height = 24;
            this.dgDelivery.Size = new System.Drawing.Size(778, 747);
            this.dgDelivery.TabIndex = 1;
            this.dgDelivery.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDelivery_CellContentClick);
            this.dgDelivery.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgDelivery_DataBindingComplete);
            // 
            // Information
            // 
            this.Information.HeaderText = "Information";
            this.Information.Name = "Information";
            this.Information.Text = "View Info";
            this.Information.UseColumnTextForButtonValue = true;
            // 
            // gcitemnameDataGridViewTextBoxColumn
            // 
            this.gcitemnameDataGridViewTextBoxColumn.DataPropertyName = "gc_item_name";
            this.gcitemnameDataGridViewTextBoxColumn.HeaderText = "Item Name";
            this.gcitemnameDataGridViewTextBoxColumn.Name = "gcitemnameDataGridViewTextBoxColumn";
            this.gcitemnameDataGridViewTextBoxColumn.Width = 130;
            // 
            // gcitemqtyDataGridViewTextBoxColumn
            // 
            this.gcitemqtyDataGridViewTextBoxColumn.DataPropertyName = "gc_item_qty";
            this.gcitemqtyDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.gcitemqtyDataGridViewTextBoxColumn.Name = "gcitemqtyDataGridViewTextBoxColumn";
            // 
            // gcitemsuppDataGridViewTextBoxColumn
            // 
            this.gcitemsuppDataGridViewTextBoxColumn.DataPropertyName = "gc_item_supp";
            this.gcitemsuppDataGridViewTextBoxColumn.HeaderText = "Supplier";
            this.gcitemsuppDataGridViewTextBoxColumn.Name = "gcitemsuppDataGridViewTextBoxColumn";
            // 
            // gcitembrandDataGridViewTextBoxColumn
            // 
            this.gcitembrandDataGridViewTextBoxColumn.DataPropertyName = "gc_item_brand";
            this.gcitembrandDataGridViewTextBoxColumn.HeaderText = "Brand";
            this.gcitembrandDataGridViewTextBoxColumn.Name = "gcitembrandDataGridViewTextBoxColumn";
            // 
            // gcitemcostDataGridViewTextBoxColumn
            // 
            this.gcitemcostDataGridViewTextBoxColumn.DataPropertyName = "gc_item_cost";
            this.gcitemcostDataGridViewTextBoxColumn.HeaderText = "Cost";
            this.gcitemcostDataGridViewTextBoxColumn.Name = "gcitemcostDataGridViewTextBoxColumn";
            // 
            // gcitemstatusDataGridViewTextBoxColumn
            // 
            this.gcitemstatusDataGridViewTextBoxColumn.DataPropertyName = "gc_item_status";
            this.gcitemstatusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.gcitemstatusDataGridViewTextBoxColumn.Name = "gcitemstatusDataGridViewTextBoxColumn";
            // 
            // gc_order_terms
            // 
            this.gc_order_terms.DataPropertyName = "gc_order_terms";
            this.gc_order_terms.HeaderText = "Terms";
            this.gc_order_terms.Name = "gc_order_terms";
            // 
            // gc_delivery_date
            // 
            this.gc_delivery_date.DataPropertyName = "gc_delivery_date";
            this.gc_delivery_date.HeaderText = "Date of Delivery";
            this.gc_delivery_date.Name = "gc_delivery_date";
            this.gc_delivery_date.Width = 140;
            // 
            // gc_item_code
            // 
            this.gc_item_code.DataPropertyName = "gc_item_code";
            this.gc_item_code.HeaderText = "Item Code";
            this.gc_item_code.Name = "gc_item_code";
            // 
            // gc_item_type
            // 
            this.gc_item_type.DataPropertyName = "gc_item_type";
            this.gc_item_type.HeaderText = "Type";
            this.gc_item_type.Name = "gc_item_type";
            // 
            // gc_item_srp
            // 
            this.gc_item_srp.DataPropertyName = "gc_item_srp";
            this.gc_item_srp.HeaderText = "Selling Price";
            this.gc_item_srp.Name = "gc_item_srp";
            // 
            // gc_item_desc
            // 
            this.gc_item_desc.DataPropertyName = "gc_item_desc";
            this.gc_item_desc.HeaderText = "Description";
            this.gc_item_desc.Name = "gc_item_desc";
            // 
            // gc_item_um
            // 
            this.gc_item_um.DataPropertyName = "gc_item_um";
            this.gc_item_um.HeaderText = "U/M";
            this.gc_item_um.Name = "gc_item_um";
            // 
            // deliveryBindingSource1
            // 
            this.deliveryBindingSource1.DataMember = "delivery";
            this.deliveryBindingSource1.DataSource = this.gcDataSet1;
            // 
            // gcDataSet1
            // 
            this.gcDataSet1.DataSetName = "gcDataSet";
            this.gcDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.chkItemCode);
            this.panel3.Controls.Add(this.chkItemName);
            this.panel3.Controls.Add(this.btnSearch);
            this.panel3.Controls.Add(this.txtSearch);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(13, 13);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(349, 120);
            this.panel3.TabIndex = 2;
            // 
            // chkItemCode
            // 
            this.chkItemCode.AutoSize = true;
            this.chkItemCode.Location = new System.Drawing.Point(124, 80);
            this.chkItemCode.Name = "chkItemCode";
            this.chkItemCode.Size = new System.Drawing.Size(93, 21);
            this.chkItemCode.TabIndex = 23;
            this.chkItemCode.Text = "Item Code";
            this.chkItemCode.UseVisualStyleBackColor = true;
            // 
            // chkItemName
            // 
            this.chkItemName.AutoSize = true;
            this.chkItemName.Location = new System.Drawing.Point(16, 81);
            this.chkItemName.Name = "chkItemName";
            this.chkItemName.Size = new System.Drawing.Size(97, 21);
            this.chkItemName.TabIndex = 22;
            this.chkItemName.Text = "Item Name";
            this.chkItemName.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Activecolor = System.Drawing.Color.MidnightBlue;
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.BorderRadius = 0;
            this.btnSearch.ButtonText = "Search";
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.DisabledColor = System.Drawing.Color.Gray;
            this.btnSearch.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSearch.Iconimage = null;
            this.btnSearch.Iconimage_right = null;
            this.btnSearch.Iconimage_right_Selected = null;
            this.btnSearch.Iconimage_Selected = null;
            this.btnSearch.IconMarginLeft = 0;
            this.btnSearch.IconMarginRight = 0;
            this.btnSearch.IconRightVisible = true;
            this.btnSearch.IconRightZoom = 0D;
            this.btnSearch.IconVisible = true;
            this.btnSearch.IconZoom = 40D;
            this.btnSearch.IsTab = false;
            this.btnSearch.Location = new System.Drawing.Point(228, 32);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Normalcolor = System.Drawing.Color.CornflowerBlue;
            this.btnSearch.OnHovercolor = System.Drawing.Color.MidnightBlue;
            this.btnSearch.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSearch.selected = false;
            this.btnSearch.Size = new System.Drawing.Size(104, 34);
            this.btnSearch.TabIndex = 21;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSearch.Textcolor = System.Drawing.Color.White;
            this.btnSearch.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(17, 32);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(204, 34);
            this.txtSearch.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(14, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Search Item";
            // 
            // deliveryBindingSource
            // 
            this.deliveryBindingSource.DataMember = "delivery";
            this.deliveryBindingSource.DataSource = this.gcDataSet;
            // 
            // gcDataSet
            // 
            this.gcDataSet.DataSetName = "gcDataSet";
            this.gcDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // deliveryTableAdapter
            // 
            this.deliveryTableAdapter.ClearBeforeFill = true;
            // 
            // inventoryBindingSource
            // 
            this.inventoryBindingSource.DataMember = "inventory";
            this.inventoryBindingSource.DataSource = this.gcDataSet1;
            // 
            // inventoryTableAdapter
            // 
            this.inventoryTableAdapter.ClearBeforeFill = true;
            // 
            // Delivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1177, 860);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dgDelivery);
            this.Controls.Add(this.panel1);
            this.Name = "Delivery";
            this.Text = "Delivery";
            this.Load += new System.EventHandler(this.Delivery_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDelivery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDataSet1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtDeliveryDate;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddDeliver;
        private System.Windows.Forms.DataGridView dgDelivery;
        private gcDataSet gcDataSet;
        private System.Windows.Forms.BindingSource deliveryBindingSource;
        private gcDataSetTableAdapters.deliveryTableAdapter deliveryTableAdapter;
        private System.Windows.Forms.TextBox txtOrderTerms;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuFlatButton btnSearch;
        private System.Windows.Forms.CheckBox chkItemName;
        private System.Windows.Forms.CheckBox chkItemCode;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtItemPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbSupp;
        private gcDataSet gcDataSet1;
        private System.Windows.Forms.BindingSource inventoryBindingSource;
        private gcDataSetTableAdapters.inventoryTableAdapter inventoryTableAdapter;
        private System.Windows.Forms.BindingSource deliveryBindingSource1;
        private System.Windows.Forms.ComboBox txtItemName;
        private System.Windows.Forms.ComboBox txtBrand;
        private System.Windows.Forms.DataGridViewButtonColumn Information;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcitemnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcitemqtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcitemsuppDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcitembrandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcitemcostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcitemstatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gc_order_terms;
        private System.Windows.Forms.DataGridViewTextBoxColumn gc_delivery_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn gc_item_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn gc_item_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn gc_item_srp;
        private System.Windows.Forms.DataGridViewTextBoxColumn gc_item_desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn gc_item_um;
    }
}