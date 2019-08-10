namespace Inventory_System.forms
{
    partial class Transaction_History
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
            this.dgTransHistory = new System.Windows.Forms.DataGridView();
            this.gcuniqueidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gccustomernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gccustomeraddDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gctransdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gctotalpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gccustcashDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gccustchangeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnPrint = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.transactBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gcDataSet = new Inventory_System.gcDataSet();
            this.transactTableAdapter = new Inventory_System.gcDataSetTableAdapters.transactTableAdapter();
            this.cmbFilterName = new System.Windows.Forms.ComboBox();
            this.txtSearchbox = new System.Windows.Forms.TextBox();
            this.btnSearchHist = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtTransDateFrom = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtTransDateTo = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgTransHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgTransHistory
            // 
            this.dgTransHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgTransHistory.AutoGenerateColumns = false;
            this.dgTransHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTransHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gcuniqueidDataGridViewTextBoxColumn,
            this.gccustomernameDataGridViewTextBoxColumn,
            this.gccustomeraddDataGridViewTextBoxColumn,
            this.gctransdateDataGridViewTextBoxColumn,
            this.gctotalpriceDataGridViewTextBoxColumn,
            this.gccustcashDataGridViewTextBoxColumn,
            this.gccustchangeDataGridViewTextBoxColumn,
            this.btnEdit,
            this.btnPrint,
            this.btnDelete});
            this.dgTransHistory.DataSource = this.transactBindingSource;
            this.dgTransHistory.Location = new System.Drawing.Point(0, 106);
            this.dgTransHistory.Name = "dgTransHistory";
            this.dgTransHistory.RowTemplate.Height = 24;
            this.dgTransHistory.Size = new System.Drawing.Size(1204, 647);
            this.dgTransHistory.TabIndex = 0;
            this.dgTransHistory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgTransHistory_CellContentClick);
            // 
            // gcuniqueidDataGridViewTextBoxColumn
            // 
            this.gcuniqueidDataGridViewTextBoxColumn.DataPropertyName = "gc_unique_id";
            this.gcuniqueidDataGridViewTextBoxColumn.HeaderText = "ID";
            this.gcuniqueidDataGridViewTextBoxColumn.Name = "gcuniqueidDataGridViewTextBoxColumn";
            // 
            // gccustomernameDataGridViewTextBoxColumn
            // 
            this.gccustomernameDataGridViewTextBoxColumn.DataPropertyName = "gc_customer_name";
            this.gccustomernameDataGridViewTextBoxColumn.HeaderText = "Customer Name";
            this.gccustomernameDataGridViewTextBoxColumn.Name = "gccustomernameDataGridViewTextBoxColumn";
            this.gccustomernameDataGridViewTextBoxColumn.Width = 140;
            // 
            // gccustomeraddDataGridViewTextBoxColumn
            // 
            this.gccustomeraddDataGridViewTextBoxColumn.DataPropertyName = "gc_customer_add";
            this.gccustomeraddDataGridViewTextBoxColumn.HeaderText = "Address";
            this.gccustomeraddDataGridViewTextBoxColumn.Name = "gccustomeraddDataGridViewTextBoxColumn";
            // 
            // gctransdateDataGridViewTextBoxColumn
            // 
            this.gctransdateDataGridViewTextBoxColumn.DataPropertyName = "gc_trans_date";
            this.gctransdateDataGridViewTextBoxColumn.HeaderText = "Transaction Date";
            this.gctransdateDataGridViewTextBoxColumn.Name = "gctransdateDataGridViewTextBoxColumn";
            this.gctransdateDataGridViewTextBoxColumn.Width = 160;
            // 
            // gctotalpriceDataGridViewTextBoxColumn
            // 
            this.gctotalpriceDataGridViewTextBoxColumn.DataPropertyName = "gc_total_price";
            this.gctotalpriceDataGridViewTextBoxColumn.HeaderText = "Total";
            this.gctotalpriceDataGridViewTextBoxColumn.Name = "gctotalpriceDataGridViewTextBoxColumn";
            this.gctotalpriceDataGridViewTextBoxColumn.Visible = false;
            // 
            // gccustcashDataGridViewTextBoxColumn
            // 
            this.gccustcashDataGridViewTextBoxColumn.DataPropertyName = "gc_cust_cash";
            this.gccustcashDataGridViewTextBoxColumn.HeaderText = "Customer Cash";
            this.gccustcashDataGridViewTextBoxColumn.Name = "gccustcashDataGridViewTextBoxColumn";
            this.gccustcashDataGridViewTextBoxColumn.Width = 140;
            // 
            // gccustchangeDataGridViewTextBoxColumn
            // 
            this.gccustchangeDataGridViewTextBoxColumn.DataPropertyName = "gc_cust_change";
            this.gccustchangeDataGridViewTextBoxColumn.HeaderText = "Change";
            this.gccustchangeDataGridViewTextBoxColumn.Name = "gccustchangeDataGridViewTextBoxColumn";
            // 
            // btnEdit
            // 
            this.btnEdit.HeaderText = "";
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseColumnTextForButtonValue = true;
            // 
            // btnPrint
            // 
            this.btnPrint.HeaderText = "";
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Text = "Print";
            this.btnPrint.UseColumnTextForButtonValue = true;
            // 
            // btnDelete
            // 
            this.btnDelete.HeaderText = "";
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseColumnTextForButtonValue = true;
            // 
            // transactBindingSource
            // 
            this.transactBindingSource.DataMember = "transact";
            this.transactBindingSource.DataSource = this.gcDataSet;
            // 
            // gcDataSet
            // 
            this.gcDataSet.DataSetName = "gcDataSet";
            this.gcDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transactTableAdapter
            // 
            this.transactTableAdapter.ClearBeforeFill = true;
            // 
            // cmbFilterName
            // 
            this.cmbFilterName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFilterName.FormattingEnabled = true;
            this.cmbFilterName.Items.AddRange(new object[] {
            "ID",
            "Customer Name"});
            this.cmbFilterName.Location = new System.Drawing.Point(13, 40);
            this.cmbFilterName.Name = "cmbFilterName";
            this.cmbFilterName.Size = new System.Drawing.Size(184, 39);
            this.cmbFilterName.TabIndex = 38;
            this.cmbFilterName.TextChanged += new System.EventHandler(this.cmbFilterName_TextChanged);
            // 
            // txtSearchbox
            // 
            this.txtSearchbox.Enabled = false;
            this.txtSearchbox.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchbox.Location = new System.Drawing.Point(209, 39);
            this.txtSearchbox.Name = "txtSearchbox";
            this.txtSearchbox.Size = new System.Drawing.Size(238, 43);
            this.txtSearchbox.TabIndex = 37;
            this.txtSearchbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSearchHist
            // 
            this.btnSearchHist.Activecolor = System.Drawing.Color.MidnightBlue;
            this.btnSearchHist.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSearchHist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchHist.BorderRadius = 0;
            this.btnSearchHist.ButtonText = "Search Items";
            this.btnSearchHist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchHist.DisabledColor = System.Drawing.Color.Gray;
            this.btnSearchHist.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSearchHist.Iconimage = null;
            this.btnSearchHist.Iconimage_right = null;
            this.btnSearchHist.Iconimage_right_Selected = null;
            this.btnSearchHist.Iconimage_Selected = null;
            this.btnSearchHist.IconMarginLeft = 0;
            this.btnSearchHist.IconMarginRight = 0;
            this.btnSearchHist.IconRightVisible = true;
            this.btnSearchHist.IconRightZoom = 0D;
            this.btnSearchHist.IconVisible = true;
            this.btnSearchHist.IconZoom = 40D;
            this.btnSearchHist.IsTab = false;
            this.btnSearchHist.Location = new System.Drawing.Point(848, 39);
            this.btnSearchHist.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearchHist.Name = "btnSearchHist";
            this.btnSearchHist.Normalcolor = System.Drawing.Color.CornflowerBlue;
            this.btnSearchHist.OnHovercolor = System.Drawing.Color.MidnightBlue;
            this.btnSearchHist.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSearchHist.selected = false;
            this.btnSearchHist.Size = new System.Drawing.Size(226, 43);
            this.btnSearchHist.TabIndex = 36;
            this.btnSearchHist.Text = "Search Items";
            this.btnSearchHist.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSearchHist.Textcolor = System.Drawing.Color.White;
            this.btnSearchHist.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchHist.Click += new System.EventHandler(this.btnSearchHist_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Gray;
            this.label9.Location = new System.Drawing.Point(12, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 17);
            this.label9.TabIndex = 40;
            this.label9.Text = "Search By ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(206, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 17);
            this.label6.TabIndex = 39;
            this.label6.Text = "Search Items";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(461, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 42;
            this.label1.Text = "Transaction From";
            // 
            // dtTransDateFrom
            // 
            this.dtTransDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTransDateFrom.Location = new System.Drawing.Point(464, 50);
            this.dtTransDateFrom.Name = "dtTransDateFrom";
            this.dtTransDateFrom.Size = new System.Drawing.Size(127, 22);
            this.dtTransDateFrom.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(617, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 17);
            this.label2.TabIndex = 44;
            this.label2.Text = "Transaction Upto";
            // 
            // dtTransDateTo
            // 
            this.dtTransDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTransDateTo.Location = new System.Drawing.Point(620, 50);
            this.dtTransDateTo.Name = "dtTransDateTo";
            this.dtTransDateTo.Size = new System.Drawing.Size(127, 22);
            this.dtTransDateTo.TabIndex = 45;
            // 
            // Transaction_History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1204, 753);
            this.Controls.Add(this.dtTransDateTo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtTransDateFrom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbFilterName);
            this.Controls.Add(this.txtSearchbox);
            this.Controls.Add(this.btnSearchHist);
            this.Controls.Add(this.dgTransHistory);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Transaction_History";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transaction History";
            this.Load += new System.EventHandler(this.Transaction_History_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgTransHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgTransHistory;
        private gcDataSet gcDataSet;
        private System.Windows.Forms.BindingSource transactBindingSource;
        private gcDataSetTableAdapters.transactTableAdapter transactTableAdapter;
        private System.Windows.Forms.ComboBox cmbFilterName;
        public System.Windows.Forms.TextBox txtSearchbox;
        public Bunifu.Framework.UI.BunifuFlatButton btnSearchHist;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtTransDateFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcuniqueidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gccustomernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gccustomeraddDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gctransdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gctotalpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gccustcashDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gccustchangeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn btnEdit;
        private System.Windows.Forms.DataGridViewButtonColumn btnPrint;
        private System.Windows.Forms.DataGridViewButtonColumn btnDelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtTransDateTo;
    }
}