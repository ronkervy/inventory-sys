namespace Inventory_System.forms
{
    partial class DeliveryStatusDashboard
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
            this.dgDelivery = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.deliveryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gcDataSet = new Inventory_System.gcDataSet();
            this.deliveryTableAdapter = new Inventory_System.gcDataSetTableAdapters.deliveryTableAdapter();
            this.gcitemsuppDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcitemnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDaysLeft = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcordertermsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcdeliverydateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgDelivery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgDelivery
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgDelivery.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgDelivery.AutoGenerateColumns = false;
            this.dgDelivery.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgDelivery.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgDelivery.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgDelivery.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgDelivery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDelivery.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gcitemsuppDataGridViewTextBoxColumn,
            this.gcitemnameDataGridViewTextBoxColumn,
            this.txtDaysLeft,
            this.gcordertermsDataGridViewTextBoxColumn,
            this.gcdeliverydateDataGridViewTextBoxColumn});
            this.dgDelivery.DataSource = this.deliveryBindingSource;
            this.dgDelivery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgDelivery.DoubleBuffered = true;
            this.dgDelivery.EnableHeadersVisualStyles = false;
            this.dgDelivery.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(94)))));
            this.dgDelivery.HeaderForeColor = System.Drawing.Color.White;
            this.dgDelivery.Location = new System.Drawing.Point(0, 0);
            this.dgDelivery.Name = "dgDelivery";
            this.dgDelivery.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgDelivery.RowTemplate.Height = 24;
            this.dgDelivery.Size = new System.Drawing.Size(889, 473);
            this.dgDelivery.TabIndex = 2;
            this.dgDelivery.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgDelivery_DataBindingComplete);
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
            // gcitemsuppDataGridViewTextBoxColumn
            // 
            this.gcitemsuppDataGridViewTextBoxColumn.DataPropertyName = "gc_item_supp";
            this.gcitemsuppDataGridViewTextBoxColumn.HeaderText = "Supplier";
            this.gcitemsuppDataGridViewTextBoxColumn.Name = "gcitemsuppDataGridViewTextBoxColumn";
            // 
            // gcitemnameDataGridViewTextBoxColumn
            // 
            this.gcitemnameDataGridViewTextBoxColumn.DataPropertyName = "gc_item_name";
            this.gcitemnameDataGridViewTextBoxColumn.HeaderText = "Item Name";
            this.gcitemnameDataGridViewTextBoxColumn.Name = "gcitemnameDataGridViewTextBoxColumn";
            this.gcitemnameDataGridViewTextBoxColumn.Width = 130;
            // 
            // txtDaysLeft
            // 
            this.txtDaysLeft.HeaderText = "Days Left";
            this.txtDaysLeft.Name = "txtDaysLeft";
            this.txtDaysLeft.Width = 140;
            // 
            // gcordertermsDataGridViewTextBoxColumn
            // 
            this.gcordertermsDataGridViewTextBoxColumn.DataPropertyName = "gc_order_terms";
            this.gcordertermsDataGridViewTextBoxColumn.HeaderText = "Terms(Days)";
            this.gcordertermsDataGridViewTextBoxColumn.Name = "gcordertermsDataGridViewTextBoxColumn";
            this.gcordertermsDataGridViewTextBoxColumn.Width = 140;
            // 
            // gcdeliverydateDataGridViewTextBoxColumn
            // 
            this.gcdeliverydateDataGridViewTextBoxColumn.DataPropertyName = "gc_delivery_date";
            this.gcdeliverydateDataGridViewTextBoxColumn.HeaderText = "Delivery Date";
            this.gcdeliverydateDataGridViewTextBoxColumn.Name = "gcdeliverydateDataGridViewTextBoxColumn";
            this.gcdeliverydateDataGridViewTextBoxColumn.Width = 140;
            // 
            // DeliveryStatusDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 473);
            this.Controls.Add(this.dgDelivery);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DeliveryStatusDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeliveryStatusDashboard";
            this.Load += new System.EventHandler(this.DeliveryStatusDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDelivery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid dgDelivery;
        private gcDataSet gcDataSet;
        private System.Windows.Forms.BindingSource deliveryBindingSource;
        private gcDataSetTableAdapters.deliveryTableAdapter deliveryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcitemsuppDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcitemnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtDaysLeft;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcordertermsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcdeliverydateDataGridViewTextBoxColumn;
    }
}