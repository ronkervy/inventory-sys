namespace Inventory_System.forms
{
    partial class Transaction
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCash = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lvCart = new System.Windows.Forms.ListView();
            this.btnSaveTrans = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnClear = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chkBrand = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkSupplier = new System.Windows.Forms.CheckBox();
            this.chkItemName = new System.Windows.Forms.CheckBox();
            this.chkItemCode = new System.Windows.Forms.CheckBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dgStock = new System.Windows.Forms.DataGridView();
            this.addButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gcitemnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcitemqtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcitemdescDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcitemsuppDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcitembrandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcitemumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcitemcostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcitemsrpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcdateaddedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcitemcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcitemtypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcitemstatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gcDataSet = new Inventory_System.gcDataSet();
            this.stockTableAdapter = new Inventory_System.gcDataSetTableAdapters.stockTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtCash);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtCustomerName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lvCart);
            this.panel1.Controls.Add(this.btnSaveTrans);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(392, 577);
            this.panel1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(11, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 38;
            this.label6.Text = "ITEM LIST";
            // 
            // txtCash
            // 
            this.txtCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCash.Location = new System.Drawing.Point(102, 274);
            this.txtCash.Name = "txtCash";
            this.txtCash.Size = new System.Drawing.Size(273, 34);
            this.txtCash.TabIndex = 37;
            this.txtCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCash.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCash_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(14, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 25);
            this.label5.TabIndex = 36;
            this.label5.Text = "Cash : ";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.DimGray;
            this.lblTotal.Location = new System.Drawing.Point(168, 233);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(54, 25);
            this.lblTotal.TabIndex = 35;
            this.lblTotal.Text = "0.00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(14, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 25);
            this.label3.TabIndex = 34;
            this.label3.Text = "Total Price : ";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(17, 440);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(358, 34);
            this.txtAddress.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(14, 410);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 17);
            this.label2.TabIndex = 32;
            this.label2.Text = "Customer Address";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.Location = new System.Drawing.Point(17, 362);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(358, 34);
            this.txtCustomerName.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(14, 332);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "Customer Name";
            // 
            // lvCart
            // 
            this.lvCart.FullRowSelect = true;
            this.lvCart.GridLines = true;
            this.lvCart.Location = new System.Drawing.Point(14, 44);
            this.lvCart.Name = "lvCart";
            this.lvCart.Size = new System.Drawing.Size(361, 163);
            this.lvCart.TabIndex = 1;
            this.lvCart.UseCompatibleStateImageBehavior = false;
            this.lvCart.View = System.Windows.Forms.View.Details;
            this.lvCart.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvCart_KeyDown);
            this.lvCart.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lvCart_KeyPress);
            // 
            // btnSaveTrans
            // 
            this.btnSaveTrans.Activecolor = System.Drawing.Color.Lime;
            this.btnSaveTrans.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveTrans.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSaveTrans.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSaveTrans.BorderRadius = 0;
            this.btnSaveTrans.ButtonText = "&Save Transaction";
            this.btnSaveTrans.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveTrans.DisabledColor = System.Drawing.Color.Gray;
            this.btnSaveTrans.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSaveTrans.Iconimage = null;
            this.btnSaveTrans.Iconimage_right = null;
            this.btnSaveTrans.Iconimage_right_Selected = null;
            this.btnSaveTrans.Iconimage_Selected = null;
            this.btnSaveTrans.IconMarginLeft = 0;
            this.btnSaveTrans.IconMarginRight = 0;
            this.btnSaveTrans.IconRightVisible = true;
            this.btnSaveTrans.IconRightZoom = 0D;
            this.btnSaveTrans.IconVisible = true;
            this.btnSaveTrans.IconZoom = 40D;
            this.btnSaveTrans.IsTab = false;
            this.btnSaveTrans.Location = new System.Drawing.Point(194, 498);
            this.btnSaveTrans.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSaveTrans.Name = "btnSaveTrans";
            this.btnSaveTrans.Normalcolor = System.Drawing.Color.SeaGreen;
            this.btnSaveTrans.OnHovercolor = System.Drawing.Color.Green;
            this.btnSaveTrans.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSaveTrans.selected = false;
            this.btnSaveTrans.Size = new System.Drawing.Size(181, 59);
            this.btnSaveTrans.TabIndex = 28;
            this.btnSaveTrans.Text = "&Save Transaction";
            this.btnSaveTrans.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSaveTrans.Textcolor = System.Drawing.Color.White;
            this.btnSaveTrans.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveTrans.Click += new System.EventHandler(this.btnSaveTrans_Click);
            // 
            // btnClear
            // 
            this.btnClear.Activecolor = System.Drawing.Color.Crimson;
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.BackColor = System.Drawing.Color.Crimson;
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClear.BorderRadius = 0;
            this.btnClear.ButtonText = "&Clear";
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.DisabledColor = System.Drawing.Color.Gray;
            this.btnClear.Iconcolor = System.Drawing.Color.Transparent;
            this.btnClear.Iconimage = null;
            this.btnClear.Iconimage_right = null;
            this.btnClear.Iconimage_right_Selected = null;
            this.btnClear.Iconimage_Selected = null;
            this.btnClear.IconMarginLeft = 0;
            this.btnClear.IconMarginRight = 0;
            this.btnClear.IconRightVisible = true;
            this.btnClear.IconRightZoom = 0D;
            this.btnClear.IconVisible = true;
            this.btnClear.IconZoom = 40D;
            this.btnClear.IsTab = false;
            this.btnClear.Location = new System.Drawing.Point(17, 498);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Normalcolor = System.Drawing.Color.Crimson;
            this.btnClear.OnHovercolor = System.Drawing.Color.PaleVioletRed;
            this.btnClear.OnHoverTextColor = System.Drawing.Color.White;
            this.btnClear.selected = false;
            this.btnClear.Size = new System.Drawing.Size(152, 59);
            this.btnClear.TabIndex = 29;
            this.btnClear.Text = "&Clear";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClear.Textcolor = System.Drawing.Color.White;
            this.btnClear.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.chkBrand);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.chkSupplier);
            this.panel2.Controls.Add(this.chkItemName);
            this.panel2.Controls.Add(this.chkItemCode);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.dgStock);
            this.panel2.Location = new System.Drawing.Point(424, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(911, 577);
            this.panel2.TabIndex = 1;
            // 
            // chkBrand
            // 
            this.chkBrand.AutoSize = true;
            this.chkBrand.ForeColor = System.Drawing.Color.DimGray;
            this.chkBrand.Location = new System.Drawing.Point(376, 19);
            this.chkBrand.Name = "chkBrand";
            this.chkBrand.Size = new System.Drawing.Size(68, 21);
            this.chkBrand.TabIndex = 40;
            this.chkBrand.Text = "Brand";
            this.chkBrand.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(24, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 39;
            this.label4.Text = "Filters : ";
            // 
            // chkSupplier
            // 
            this.chkSupplier.AutoSize = true;
            this.chkSupplier.ForeColor = System.Drawing.Color.DimGray;
            this.chkSupplier.Location = new System.Drawing.Point(288, 19);
            this.chkSupplier.Name = "chkSupplier";
            this.chkSupplier.Size = new System.Drawing.Size(82, 21);
            this.chkSupplier.TabIndex = 35;
            this.chkSupplier.Text = "Supplier";
            this.chkSupplier.UseVisualStyleBackColor = true;
            // 
            // chkItemName
            // 
            this.chkItemName.AutoSize = true;
            this.chkItemName.ForeColor = System.Drawing.Color.DimGray;
            this.chkItemName.Location = new System.Drawing.Point(185, 19);
            this.chkItemName.Name = "chkItemName";
            this.chkItemName.Size = new System.Drawing.Size(97, 21);
            this.chkItemName.TabIndex = 34;
            this.chkItemName.Text = "Item Name";
            this.chkItemName.UseVisualStyleBackColor = true;
            // 
            // chkItemCode
            // 
            this.chkItemCode.AutoSize = true;
            this.chkItemCode.ForeColor = System.Drawing.Color.DimGray;
            this.chkItemCode.Location = new System.Drawing.Point(86, 18);
            this.chkItemCode.Name = "chkItemCode";
            this.chkItemCode.Size = new System.Drawing.Size(93, 21);
            this.chkItemCode.TabIndex = 33;
            this.chkItemCode.Text = "Item Code";
            this.chkItemCode.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(25, 44);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(689, 47);
            this.txtSearch.TabIndex = 32;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // btnSearch
            // 
            this.btnSearch.Activecolor = System.Drawing.Color.MidnightBlue;
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.BorderRadius = 0;
            this.btnSearch.ButtonText = "&Search";
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
            this.btnSearch.Location = new System.Drawing.Point(721, 46);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Normalcolor = System.Drawing.Color.CornflowerBlue;
            this.btnSearch.OnHovercolor = System.Drawing.Color.MidnightBlue;
            this.btnSearch.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSearch.selected = false;
            this.btnSearch.Size = new System.Drawing.Size(165, 44);
            this.btnSearch.TabIndex = 31;
            this.btnSearch.Text = "&Search";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSearch.Textcolor = System.Drawing.Color.White;
            this.btnSearch.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgStock
            // 
            this.dgStock.AutoGenerateColumns = false;
            this.dgStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.addButton,
            this.gcitemnameDataGridViewTextBoxColumn,
            this.gcitemqtyDataGridViewTextBoxColumn,
            this.gcitemdescDataGridViewTextBoxColumn,
            this.gcitemsuppDataGridViewTextBoxColumn,
            this.gcitembrandDataGridViewTextBoxColumn,
            this.gcitemumDataGridViewTextBoxColumn,
            this.gcitemcostDataGridViewTextBoxColumn,
            this.gcitemsrpDataGridViewTextBoxColumn,
            this.gcdateaddedDataGridViewTextBoxColumn,
            this.gcitemcodeDataGridViewTextBoxColumn,
            this.gcitemtypeDataGridViewTextBoxColumn,
            this.gcitemstatusDataGridViewTextBoxColumn});
            this.dgStock.DataSource = this.stockBindingSource;
            this.dgStock.Location = new System.Drawing.Point(25, 110);
            this.dgStock.Name = "dgStock";
            this.dgStock.RowTemplate.Height = 24;
            this.dgStock.Size = new System.Drawing.Size(861, 447);
            this.dgStock.TabIndex = 0;
            this.dgStock.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgStock_CellContentClick);
            // 
            // addButton
            // 
            this.addButton.HeaderText = "";
            this.addButton.Name = "addButton";
            this.addButton.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.addButton.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.addButton.Text = "Add";
            this.addButton.UseColumnTextForButtonValue = true;
            this.addButton.Width = 130;
            // 
            // gcitemnameDataGridViewTextBoxColumn
            // 
            this.gcitemnameDataGridViewTextBoxColumn.DataPropertyName = "gc_item_name";
            this.gcitemnameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.gcitemnameDataGridViewTextBoxColumn.Name = "gcitemnameDataGridViewTextBoxColumn";
            // 
            // gcitemqtyDataGridViewTextBoxColumn
            // 
            this.gcitemqtyDataGridViewTextBoxColumn.DataPropertyName = "gc_item_qty";
            this.gcitemqtyDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.gcitemqtyDataGridViewTextBoxColumn.Name = "gcitemqtyDataGridViewTextBoxColumn";
            // 
            // gcitemdescDataGridViewTextBoxColumn
            // 
            this.gcitemdescDataGridViewTextBoxColumn.DataPropertyName = "gc_item_desc";
            this.gcitemdescDataGridViewTextBoxColumn.HeaderText = "Description";
            this.gcitemdescDataGridViewTextBoxColumn.Name = "gcitemdescDataGridViewTextBoxColumn";
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
            // gcitemumDataGridViewTextBoxColumn
            // 
            this.gcitemumDataGridViewTextBoxColumn.DataPropertyName = "gc_item_um";
            this.gcitemumDataGridViewTextBoxColumn.HeaderText = "U/M";
            this.gcitemumDataGridViewTextBoxColumn.Name = "gcitemumDataGridViewTextBoxColumn";
            // 
            // gcitemcostDataGridViewTextBoxColumn
            // 
            this.gcitemcostDataGridViewTextBoxColumn.DataPropertyName = "gc_item_cost";
            this.gcitemcostDataGridViewTextBoxColumn.HeaderText = "Cost";
            this.gcitemcostDataGridViewTextBoxColumn.Name = "gcitemcostDataGridViewTextBoxColumn";
            this.gcitemcostDataGridViewTextBoxColumn.Visible = false;
            // 
            // gcitemsrpDataGridViewTextBoxColumn
            // 
            this.gcitemsrpDataGridViewTextBoxColumn.DataPropertyName = "gc_item_srp";
            this.gcitemsrpDataGridViewTextBoxColumn.HeaderText = "Selling Price";
            this.gcitemsrpDataGridViewTextBoxColumn.Name = "gcitemsrpDataGridViewTextBoxColumn";
            // 
            // gcdateaddedDataGridViewTextBoxColumn
            // 
            this.gcdateaddedDataGridViewTextBoxColumn.DataPropertyName = "gc_date_added";
            this.gcdateaddedDataGridViewTextBoxColumn.HeaderText = "gc_date_added";
            this.gcdateaddedDataGridViewTextBoxColumn.Name = "gcdateaddedDataGridViewTextBoxColumn";
            this.gcdateaddedDataGridViewTextBoxColumn.Visible = false;
            // 
            // gcitemcodeDataGridViewTextBoxColumn
            // 
            this.gcitemcodeDataGridViewTextBoxColumn.DataPropertyName = "gc_item_code";
            this.gcitemcodeDataGridViewTextBoxColumn.HeaderText = "Item Code";
            this.gcitemcodeDataGridViewTextBoxColumn.Name = "gcitemcodeDataGridViewTextBoxColumn";
            // 
            // gcitemtypeDataGridViewTextBoxColumn
            // 
            this.gcitemtypeDataGridViewTextBoxColumn.DataPropertyName = "gc_item_type";
            this.gcitemtypeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.gcitemtypeDataGridViewTextBoxColumn.Name = "gcitemtypeDataGridViewTextBoxColumn";
            // 
            // gcitemstatusDataGridViewTextBoxColumn
            // 
            this.gcitemstatusDataGridViewTextBoxColumn.DataPropertyName = "gc_item_status";
            this.gcitemstatusDataGridViewTextBoxColumn.HeaderText = "gc_item_status";
            this.gcitemstatusDataGridViewTextBoxColumn.Name = "gcitemstatusDataGridViewTextBoxColumn";
            this.gcitemstatusDataGridViewTextBoxColumn.Visible = false;
            // 
            // stockBindingSource
            // 
            this.stockBindingSource.DataMember = "stock";
            this.stockBindingSource.DataSource = this.gcDataSet;
            // 
            // gcDataSet
            // 
            this.gcDataSet.DataSetName = "gcDataSet";
            this.gcDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stockTableAdapter
            // 
            this.stockTableAdapter.ClearBeforeFill = true;
            // 
            // Transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1347, 601);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Transaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transaction";
            this.Load += new System.EventHandler(this.Transaction_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        public Bunifu.Framework.UI.BunifuFlatButton btnClear;
        public Bunifu.Framework.UI.BunifuFlatButton btnSaveTrans;
        public Bunifu.Framework.UI.BunifuFlatButton btnSearch;
        public System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtCash;
        private System.Windows.Forms.Label label5;
        private gcDataSet gcDataSet;
        private System.Windows.Forms.BindingSource stockBindingSource;
        private gcDataSetTableAdapters.stockTableAdapter stockTableAdapter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewButtonColumn addButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcitemnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcitemqtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcitemdescDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcitemsuppDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcitembrandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcitemumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcitemcostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcitemsrpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcdateaddedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcitemcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcitemtypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcitemstatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.CheckBox chkSupplier;
        private System.Windows.Forms.CheckBox chkItemName;
        private System.Windows.Forms.CheckBox chkItemCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkBrand;
        public System.Windows.Forms.ListView lvCart;
        public System.Windows.Forms.Label lblTotal;
        public System.Windows.Forms.DataGridView dgStock;
    }
}