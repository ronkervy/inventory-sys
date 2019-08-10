namespace Inventory_System.forms
{
    partial class stockList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgStock = new System.Windows.Forms.DataGridView();
            this.gcitemnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcitemcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcitemqtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcitemdescDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcitemsuppDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcitembrandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcitemumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcitemcostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcitemsrpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcdateaddedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcitemtypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewButtonColumn();
            this.action = new System.Windows.Forms.DataGridViewButtonColumn();
            this.stockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gcDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gcDataSet = new Inventory_System.gcDataSet();
            this.stockTableAdapter = new Inventory_System.gcDataSetTableAdapters.stockTableAdapter();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbFilterName = new System.Windows.Forms.ComboBox();
            this.txtSearchbox = new System.Windows.Forms.TextBox();
            this.btnSearchInv = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgStock
            // 
            this.dgStock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgStock.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gcitemnameDataGridViewTextBoxColumn,
            this.gcitemcodeDataGridViewTextBoxColumn,
            this.gcitemqtyDataGridViewTextBoxColumn,
            this.gcitemdescDataGridViewTextBoxColumn,
            this.gcitemsuppDataGridViewTextBoxColumn,
            this.gcitembrandDataGridViewTextBoxColumn,
            this.gcitemumDataGridViewTextBoxColumn,
            this.gcitemcostDataGridViewTextBoxColumn,
            this.gcitemsrpDataGridViewTextBoxColumn,
            this.gcdateaddedDataGridViewTextBoxColumn,
            this.gcitemtypeDataGridViewTextBoxColumn,
            this.Status,
            this.action});
            this.dgStock.DataSource = this.stockBindingSource;
            this.dgStock.EnableHeadersVisualStyles = false;
            this.dgStock.Location = new System.Drawing.Point(0, 105);
            this.dgStock.Name = "dgStock";
            this.dgStock.RowTemplate.Height = 24;
            this.dgStock.Size = new System.Drawing.Size(1161, 356);
            this.dgStock.TabIndex = 0;
            this.dgStock.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgStock_CellContentClick);
            this.dgStock.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgStock_DataBindingComplete);
            // 
            // gcitemnameDataGridViewTextBoxColumn
            // 
            this.gcitemnameDataGridViewTextBoxColumn.DataPropertyName = "gc_item_name";
            this.gcitemnameDataGridViewTextBoxColumn.HeaderText = "Item Name";
            this.gcitemnameDataGridViewTextBoxColumn.Name = "gcitemnameDataGridViewTextBoxColumn";
            // 
            // gcitemcodeDataGridViewTextBoxColumn
            // 
            this.gcitemcodeDataGridViewTextBoxColumn.DataPropertyName = "gc_item_code";
            this.gcitemcodeDataGridViewTextBoxColumn.HeaderText = "Code";
            this.gcitemcodeDataGridViewTextBoxColumn.Name = "gcitemcodeDataGridViewTextBoxColumn";
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
            this.gcdateaddedDataGridViewTextBoxColumn.HeaderText = "Date Added";
            this.gcdateaddedDataGridViewTextBoxColumn.Name = "gcdateaddedDataGridViewTextBoxColumn";
            // 
            // gcitemtypeDataGridViewTextBoxColumn
            // 
            this.gcitemtypeDataGridViewTextBoxColumn.DataPropertyName = "gc_item_type";
            this.gcitemtypeDataGridViewTextBoxColumn.HeaderText = "Item Type";
            this.gcitemtypeDataGridViewTextBoxColumn.Name = "gcitemtypeDataGridViewTextBoxColumn";
            // 
            // Status
            // 
            this.Status.HeaderText = "";
            this.Status.Name = "Status";
            this.Status.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Status.Text = "Remove";
            this.Status.UseColumnTextForButtonValue = true;
            // 
            // action
            // 
            this.action.HeaderText = "Action";
            this.action.Name = "action";
            this.action.Text = "Add to Stock";
            this.action.UseColumnTextForButtonValue = true;
            this.action.Width = 90;
            // 
            // stockBindingSource
            // 
            this.stockBindingSource.DataMember = "stock";
            this.stockBindingSource.DataSource = this.gcDataSetBindingSource;
            // 
            // gcDataSetBindingSource
            // 
            this.gcDataSetBindingSource.DataSource = this.gcDataSet;
            this.gcDataSetBindingSource.Position = 0;
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Gray;
            this.label9.Location = new System.Drawing.Point(9, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 17);
            this.label9.TabIndex = 36;
            this.label9.Text = "Search By ";
            // 
            // cmbFilterName
            // 
            this.cmbFilterName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFilterName.FormattingEnabled = true;
            this.cmbFilterName.Items.AddRange(new object[] {
            "Item Name",
            "Item Brand",
            "Item Code"});
            this.cmbFilterName.Location = new System.Drawing.Point(12, 37);
            this.cmbFilterName.Name = "cmbFilterName";
            this.cmbFilterName.Size = new System.Drawing.Size(281, 39);
            this.cmbFilterName.TabIndex = 35;
            this.cmbFilterName.TextChanged += new System.EventHandler(this.cmbFilterName_TextChanged);
            // 
            // txtSearchbox
            // 
            this.txtSearchbox.Enabled = false;
            this.txtSearchbox.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchbox.Location = new System.Drawing.Point(332, 35);
            this.txtSearchbox.Name = "txtSearchbox";
            this.txtSearchbox.Size = new System.Drawing.Size(361, 43);
            this.txtSearchbox.TabIndex = 34;
            this.txtSearchbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSearchInv
            // 
            this.btnSearchInv.Activecolor = System.Drawing.Color.MidnightBlue;
            this.btnSearchInv.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSearchInv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchInv.BorderRadius = 0;
            this.btnSearchInv.ButtonText = "Search Items";
            this.btnSearchInv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchInv.DisabledColor = System.Drawing.Color.Gray;
            this.btnSearchInv.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSearchInv.Iconimage = null;
            this.btnSearchInv.Iconimage_right = null;
            this.btnSearchInv.Iconimage_right_Selected = null;
            this.btnSearchInv.Iconimage_Selected = null;
            this.btnSearchInv.IconMarginLeft = 0;
            this.btnSearchInv.IconMarginRight = 0;
            this.btnSearchInv.IconRightVisible = true;
            this.btnSearchInv.IconRightZoom = 0D;
            this.btnSearchInv.IconVisible = true;
            this.btnSearchInv.IconZoom = 40D;
            this.btnSearchInv.IsTab = false;
            this.btnSearchInv.Location = new System.Drawing.Point(729, 36);
            this.btnSearchInv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearchInv.Name = "btnSearchInv";
            this.btnSearchInv.Normalcolor = System.Drawing.Color.CornflowerBlue;
            this.btnSearchInv.OnHovercolor = System.Drawing.Color.MidnightBlue;
            this.btnSearchInv.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSearchInv.selected = false;
            this.btnSearchInv.Size = new System.Drawing.Size(226, 43);
            this.btnSearchInv.TabIndex = 33;
            this.btnSearchInv.Text = "Search Items";
            this.btnSearchInv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSearchInv.Textcolor = System.Drawing.Color.White;
            this.btnSearchInv.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(329, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 17);
            this.label6.TabIndex = 32;
            this.label6.Text = "Search Items";
            // 
            // stockList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1161, 461);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbFilterName);
            this.Controls.Add(this.txtSearchbox);
            this.Controls.Add(this.btnSearchInv);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgStock);
            this.Name = "stockList";
            this.Text = "List of current Stock";
            this.Load += new System.EventHandler(this.stockList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgStock;
        private System.Windows.Forms.BindingSource gcDataSetBindingSource;
        private gcDataSet gcDataSet;
        private System.Windows.Forms.BindingSource stockBindingSource;
        private gcDataSetTableAdapters.stockTableAdapter stockTableAdapter;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbFilterName;
        public System.Windows.Forms.TextBox txtSearchbox;
        public Bunifu.Framework.UI.BunifuFlatButton btnSearchInv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcitemnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcitemcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcitemqtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcitemdescDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcitemsuppDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcitembrandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcitemumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcitemcostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcitemsrpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcdateaddedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcitemtypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Status;
        private System.Windows.Forms.DataGridViewButtonColumn action;
    }
}