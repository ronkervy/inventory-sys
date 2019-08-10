namespace Inventory_System.forms
{
    partial class LowOnStockDashboard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgLowStock = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.gcDataSet = new Inventory_System.gcDataSet();
            this.gcDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockTableAdapter = new Inventory_System.gcDataSetTableAdapters.stockTableAdapter();
            this.gcitemcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcitemnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcitemqtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcitemsuppDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcitembrandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgLowStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgLowStock
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgLowStock.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgLowStock.AutoGenerateColumns = false;
            this.dgLowStock.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgLowStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgLowStock.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgLowStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgLowStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLowStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gcitemcodeDataGridViewTextBoxColumn,
            this.gcitemnameDataGridViewTextBoxColumn,
            this.gcitemqtyDataGridViewTextBoxColumn,
            this.gcitemsuppDataGridViewTextBoxColumn,
            this.gcitembrandDataGridViewTextBoxColumn});
            this.dgLowStock.DataSource = this.stockBindingSource;
            this.dgLowStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgLowStock.DoubleBuffered = true;
            this.dgLowStock.EnableHeadersVisualStyles = false;
            this.dgLowStock.HeaderBgColor = System.Drawing.Color.Maroon;
            this.dgLowStock.HeaderForeColor = System.Drawing.Color.White;
            this.dgLowStock.Location = new System.Drawing.Point(0, 0);
            this.dgLowStock.Name = "dgLowStock";
            this.dgLowStock.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgLowStock.RowTemplate.Height = 24;
            this.dgLowStock.Size = new System.Drawing.Size(800, 450);
            this.dgLowStock.TabIndex = 0;
            // 
            // gcDataSet
            // 
            this.gcDataSet.DataSetName = "gcDataSet";
            this.gcDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gcDataSetBindingSource
            // 
            this.gcDataSetBindingSource.DataSource = this.gcDataSet;
            this.gcDataSetBindingSource.Position = 0;
            // 
            // stockBindingSource
            // 
            this.stockBindingSource.DataMember = "stock";
            this.stockBindingSource.DataSource = this.gcDataSetBindingSource;
            // 
            // stockTableAdapter
            // 
            this.stockTableAdapter.ClearBeforeFill = true;
            // 
            // gcitemcodeDataGridViewTextBoxColumn
            // 
            this.gcitemcodeDataGridViewTextBoxColumn.DataPropertyName = "gc_item_code";
            this.gcitemcodeDataGridViewTextBoxColumn.HeaderText = "Item Code";
            this.gcitemcodeDataGridViewTextBoxColumn.Name = "gcitemcodeDataGridViewTextBoxColumn";
            this.gcitemcodeDataGridViewTextBoxColumn.Width = 130;
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
            // LowOnStockDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgLowStock);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LowOnStockDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Low on stock items";
            this.Load += new System.EventHandler(this.LowOnStockDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgLowStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid dgLowStock;
        private System.Windows.Forms.BindingSource gcDataSetBindingSource;
        private gcDataSet gcDataSet;
        private System.Windows.Forms.BindingSource stockBindingSource;
        private gcDataSetTableAdapters.stockTableAdapter stockTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcitemcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcitemnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcitemqtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcitemsuppDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcitembrandDataGridViewTextBoxColumn;
    }
}