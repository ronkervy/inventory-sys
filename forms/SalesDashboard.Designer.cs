namespace Inventory_System.forms
{
    partial class SalesDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesDashboard));
            this.imgListSales = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHistory = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnNew = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mainContent = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbFilterName = new System.Windows.Forms.ComboBox();
            this.btnViewTrans = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label8 = new System.Windows.Forms.Label();
            this.dtPickerTo = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dtPickerFrom = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.crySalesRept = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.mainContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgListSales
            // 
            this.imgListSales.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListSales.ImageStream")));
            this.imgListSales.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListSales.Images.SetKeyName(0, "Invoice_100px.png");
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnHistory);
            this.panel1.Controls.Add(this.btnNew);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1157, 130);
            this.panel1.TabIndex = 1;
            // 
            // btnHistory
            // 
            this.btnHistory.Activecolor = System.Drawing.Color.MidnightBlue;
            this.btnHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHistory.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnHistory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHistory.BorderRadius = 0;
            this.btnHistory.ButtonText = "Transaction History";
            this.btnHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHistory.DisabledColor = System.Drawing.Color.Gray;
            this.btnHistory.Iconcolor = System.Drawing.Color.Transparent;
            this.btnHistory.Iconimage = null;
            this.btnHistory.Iconimage_right = null;
            this.btnHistory.Iconimage_right_Selected = null;
            this.btnHistory.Iconimage_Selected = null;
            this.btnHistory.IconMarginLeft = 0;
            this.btnHistory.IconMarginRight = 0;
            this.btnHistory.IconRightVisible = true;
            this.btnHistory.IconRightZoom = 0D;
            this.btnHistory.IconVisible = true;
            this.btnHistory.IconZoom = 40D;
            this.btnHistory.IsTab = false;
            this.btnHistory.Location = new System.Drawing.Point(855, 32);
            this.btnHistory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Normalcolor = System.Drawing.Color.CornflowerBlue;
            this.btnHistory.OnHovercolor = System.Drawing.Color.MidnightBlue;
            this.btnHistory.OnHoverTextColor = System.Drawing.Color.White;
            this.btnHistory.selected = false;
            this.btnHistory.Size = new System.Drawing.Size(250, 58);
            this.btnHistory.TabIndex = 27;
            this.btnHistory.Text = "Transaction History";
            this.btnHistory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnHistory.Textcolor = System.Drawing.Color.White;
            this.btnHistory.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnNew
            // 
            this.btnNew.Activecolor = System.Drawing.Color.Lime;
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNew.BackColor = System.Drawing.Color.SeaGreen;
            this.btnNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNew.BorderRadius = 0;
            this.btnNew.ButtonText = "New";
            this.btnNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNew.DisabledColor = System.Drawing.Color.Gray;
            this.btnNew.Iconcolor = System.Drawing.Color.Transparent;
            this.btnNew.Iconimage = null;
            this.btnNew.Iconimage_right = null;
            this.btnNew.Iconimage_right_Selected = null;
            this.btnNew.Iconimage_Selected = null;
            this.btnNew.IconMarginLeft = 0;
            this.btnNew.IconMarginRight = 0;
            this.btnNew.IconRightVisible = true;
            this.btnNew.IconRightZoom = 0D;
            this.btnNew.IconVisible = true;
            this.btnNew.IconZoom = 30D;
            this.btnNew.IsTab = false;
            this.btnNew.Location = new System.Drawing.Point(728, 32);
            this.btnNew.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNew.Name = "btnNew";
            this.btnNew.Normalcolor = System.Drawing.Color.SeaGreen;
            this.btnNew.OnHovercolor = System.Drawing.Color.Green;
            this.btnNew.OnHoverTextColor = System.Drawing.Color.White;
            this.btnNew.selected = false;
            this.btnNew.Size = new System.Drawing.Size(119, 58);
            this.btnNew.TabIndex = 28;
            this.btnNew.Text = "New";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNew.Textcolor = System.Drawing.Color.White;
            this.btnNew.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(20, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(120, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "and Transactions";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(107, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 81);
            this.label4.TabIndex = 8;
            this.label4.Text = "Sales";
            // 
            // mainContent
            // 
            this.mainContent.Controls.Add(this.label9);
            this.mainContent.Controls.Add(this.cmbFilterName);
            this.mainContent.Controls.Add(this.btnViewTrans);
            this.mainContent.Controls.Add(this.label8);
            this.mainContent.Controls.Add(this.dtPickerTo);
            this.mainContent.Controls.Add(this.label7);
            this.mainContent.Controls.Add(this.dtPickerFrom);
            this.mainContent.Controls.Add(this.label6);
            this.mainContent.Controls.Add(this.cmbFilter);
            this.mainContent.Controls.Add(this.crySalesRept);
            this.mainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContent.Location = new System.Drawing.Point(0, 130);
            this.mainContent.Name = "mainContent";
            this.mainContent.Size = new System.Drawing.Size(1157, 465);
            this.mainContent.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Gray;
            this.label9.Location = new System.Drawing.Point(179, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 17);
            this.label9.TabIndex = 25;
            this.label9.Text = "Filter Name";
            // 
            // cmbFilterName
            // 
            this.cmbFilterName.Enabled = false;
            this.cmbFilterName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFilterName.FormattingEnabled = true;
            this.cmbFilterName.Location = new System.Drawing.Point(182, 29);
            this.cmbFilterName.Name = "cmbFilterName";
            this.cmbFilterName.Size = new System.Drawing.Size(281, 39);
            this.cmbFilterName.TabIndex = 24;
            // 
            // btnViewTrans
            // 
            this.btnViewTrans.Activecolor = System.Drawing.Color.MidnightBlue;
            this.btnViewTrans.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnViewTrans.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnViewTrans.BorderRadius = 0;
            this.btnViewTrans.ButtonText = "View Transaction";
            this.btnViewTrans.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewTrans.DisabledColor = System.Drawing.Color.Gray;
            this.btnViewTrans.Iconcolor = System.Drawing.Color.Transparent;
            this.btnViewTrans.Iconimage = null;
            this.btnViewTrans.Iconimage_right = null;
            this.btnViewTrans.Iconimage_right_Selected = null;
            this.btnViewTrans.Iconimage_Selected = null;
            this.btnViewTrans.IconMarginLeft = 0;
            this.btnViewTrans.IconMarginRight = 0;
            this.btnViewTrans.IconRightVisible = true;
            this.btnViewTrans.IconRightZoom = 0D;
            this.btnViewTrans.IconVisible = true;
            this.btnViewTrans.IconZoom = 40D;
            this.btnViewTrans.IsTab = false;
            this.btnViewTrans.Location = new System.Drawing.Point(804, 26);
            this.btnViewTrans.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnViewTrans.Name = "btnViewTrans";
            this.btnViewTrans.Normalcolor = System.Drawing.Color.CornflowerBlue;
            this.btnViewTrans.OnHovercolor = System.Drawing.Color.MidnightBlue;
            this.btnViewTrans.OnHoverTextColor = System.Drawing.Color.White;
            this.btnViewTrans.selected = false;
            this.btnViewTrans.Size = new System.Drawing.Size(226, 42);
            this.btnViewTrans.TabIndex = 23;
            this.btnViewTrans.Text = "View Transaction";
            this.btnViewTrans.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnViewTrans.Textcolor = System.Drawing.Color.White;
            this.btnViewTrans.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewTrans.Click += new System.EventHandler(this.btnViewTrans_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(619, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "To Date";
            // 
            // dtPickerTo
            // 
            this.dtPickerTo.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPickerTo.Location = new System.Drawing.Point(622, 37);
            this.dtPickerTo.Name = "dtPickerTo";
            this.dtPickerTo.Size = new System.Drawing.Size(114, 22);
            this.dtPickerTo.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(483, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "From Date";
            // 
            // dtPickerFrom
            // 
            this.dtPickerFrom.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPickerFrom.Location = new System.Drawing.Point(486, 37);
            this.dtPickerFrom.Name = "dtPickerFrom";
            this.dtPickerFrom.Size = new System.Drawing.Size(114, 22);
            this.dtPickerFrom.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(9, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Filter";
            // 
            // cmbFilter
            // 
            this.cmbFilter.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.Items.AddRange(new object[] {
            "Item Name",
            "Item Code"});
            this.cmbFilter.Location = new System.Drawing.Point(12, 29);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(150, 39);
            this.cmbFilter.TabIndex = 1;
            this.cmbFilter.TextChanged += new System.EventHandler(this.cmbFilter_TextChanged);
            // 
            // crySalesRept
            // 
            this.crySalesRept.ActiveViewIndex = -1;
            this.crySalesRept.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.crySalesRept.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crySalesRept.Cursor = System.Windows.Forms.Cursors.Default;
            this.crySalesRept.Location = new System.Drawing.Point(0, 86);
            this.crySalesRept.Name = "crySalesRept";
            this.crySalesRept.Size = new System.Drawing.Size(1157, 379);
            this.crySalesRept.TabIndex = 0;
            this.crySalesRept.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // SalesDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1157, 595);
            this.Controls.Add(this.mainContent);
            this.Controls.Add(this.panel1);
            this.Name = "SalesDashboard";
            this.Text = "Sales Dashboard";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.mainContent.ResumeLayout(false);
            this.mainContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imgListSales;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel mainContent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crySalesRept;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbFilter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtPickerTo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtPickerFrom;
        public Bunifu.Framework.UI.BunifuFlatButton btnViewTrans;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbFilterName;
        public Bunifu.Framework.UI.BunifuFlatButton btnHistory;
        public Bunifu.Framework.UI.BunifuFlatButton btnNew;
    }
}