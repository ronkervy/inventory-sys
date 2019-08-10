namespace Inventory_System.forms
{
    partial class Inventory_Main
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
            BunifuAnimatorNS.Animation animation3 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventory_Main));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.rEPORTSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sTOCKREPORTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iNVENTORYREPORTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tRANSACTIONSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblFooterStat = new System.Windows.Forms.ToolStripStatusLabel();
            this.footerLastCode = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pageTrans = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnStockPage = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnInventory = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSales = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSuppliers = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDeliverPage = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnUsers = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnHome = new Bunifu.Framework.UI.BunifuFlatButton();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.backupDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.pageTrans.SetDecoration(this.menuStrip, BunifuAnimatorNS.DecorationType.None);
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rEPORTSToolStripMenuItem,
            this.tRANSACTIONSToolStripMenuItem,
            this.backupToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(278, 39);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(962, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // rEPORTSToolStripMenuItem
            // 
            this.rEPORTSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sTOCKREPORTToolStripMenuItem,
            this.iNVENTORYREPORTToolStripMenuItem});
            this.rEPORTSToolStripMenuItem.Image = global::Inventory_System.Properties.Resources.Edit_Property_50px;
            this.rEPORTSToolStripMenuItem.Name = "rEPORTSToolStripMenuItem";
            this.rEPORTSToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.rEPORTSToolStripMenuItem.Text = "REPORTS";
            // 
            // sTOCKREPORTToolStripMenuItem
            // 
            this.sTOCKREPORTToolStripMenuItem.Name = "sTOCKREPORTToolStripMenuItem";
            this.sTOCKREPORTToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.sTOCKREPORTToolStripMenuItem.Text = "STOCK REPORT";
            this.sTOCKREPORTToolStripMenuItem.Click += new System.EventHandler(this.sTOCKREPORTToolStripMenuItem_Click);
            // 
            // iNVENTORYREPORTToolStripMenuItem
            // 
            this.iNVENTORYREPORTToolStripMenuItem.Name = "iNVENTORYREPORTToolStripMenuItem";
            this.iNVENTORYREPORTToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.iNVENTORYREPORTToolStripMenuItem.Text = "INVENTORY REPORT";
            this.iNVENTORYREPORTToolStripMenuItem.Click += new System.EventHandler(this.iNVENTORYREPORTToolStripMenuItem_Click);
            // 
            // tRANSACTIONSToolStripMenuItem
            // 
            this.tRANSACTIONSToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("tRANSACTIONSToolStripMenuItem.Image")));
            this.tRANSACTIONSToolStripMenuItem.Name = "tRANSACTIONSToolStripMenuItem";
            this.tRANSACTIONSToolStripMenuItem.Size = new System.Drawing.Size(115, 24);
            this.tRANSACTIONSToolStripMenuItem.Text = "PRODUCTS";
            this.tRANSACTIONSToolStripMenuItem.Click += new System.EventHandler(this.tRANSACTIONSToolStripMenuItem_Click);
            // 
            // backupToolStripMenuItem
            // 
            this.backupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restoreToolStripMenuItem,
            this.backupDatabaseToolStripMenuItem});
            this.backupToolStripMenuItem.Name = "backupToolStripMenuItem";
            this.backupToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.backupToolStripMenuItem.Text = "Backup";
            // 
            // restoreToolStripMenuItem
            // 
            this.restoreToolStripMenuItem.Name = "restoreToolStripMenuItem";
            this.restoreToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.restoreToolStripMenuItem.Text = "Restore Database";
            this.restoreToolStripMenuItem.Click += new System.EventHandler(this.restoreToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.pageTrans.SetDecoration(this.statusStrip, BunifuAnimatorNS.DecorationType.None);
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblFooterStat,
            this.footerLastCode});
            this.statusStrip.Location = new System.Drawing.Point(0, 941);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(1240, 25);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // lblFooterStat
            // 
            this.lblFooterStat.Name = "lblFooterStat";
            this.lblFooterStat.Size = new System.Drawing.Size(101, 20);
            this.lblFooterStat.Text = "Status : Ready";
            // 
            // footerLastCode
            // 
            this.footerLastCode.Name = "footerLastCode";
            this.footerLastCode.Size = new System.Drawing.Size(192, 20);
            this.footerLastCode.Text = "Last Item Code Generated : ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(94)))));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pageTrans.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1203, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pageTrans
            // 
            this.pageTrans.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.pageTrans.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 0;
            animation3.Padding = new System.Windows.Forms.Padding(0);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 1F;
            this.pageTrans.DefaultAnimation = animation3;
            this.pageTrans.MaxAnimationTime = 1000;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.btnStockPage);
            this.panel1.Controls.Add(this.btnInventory);
            this.panel1.Controls.Add(this.btnSales);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSuppliers);
            this.panel1.Controls.Add(this.btnDeliverPage);
            this.panel1.Controls.Add(this.btnUsers);
            this.panel1.Controls.Add(this.btnHome);
            this.pageTrans.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 902);
            this.panel1.TabIndex = 6;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pageTrans.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(48, 26);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(182, 172);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // btnStockPage
            // 
            this.btnStockPage.Activecolor = System.Drawing.Color.MidnightBlue;
            this.btnStockPage.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnStockPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStockPage.BorderRadius = 0;
            this.btnStockPage.ButtonText = "Stock";
            this.btnStockPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pageTrans.SetDecoration(this.btnStockPage, BunifuAnimatorNS.DecorationType.None);
            this.btnStockPage.DisabledColor = System.Drawing.Color.Gray;
            this.btnStockPage.Iconcolor = System.Drawing.Color.Transparent;
            this.btnStockPage.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnStockPage.Iconimage")));
            this.btnStockPage.Iconimage_right = null;
            this.btnStockPage.Iconimage_right_Selected = null;
            this.btnStockPage.Iconimage_Selected = null;
            this.btnStockPage.IconMarginLeft = 0;
            this.btnStockPage.IconMarginRight = 0;
            this.btnStockPage.IconRightVisible = true;
            this.btnStockPage.IconRightZoom = 0D;
            this.btnStockPage.IconVisible = true;
            this.btnStockPage.IconZoom = 45D;
            this.btnStockPage.IsTab = false;
            this.btnStockPage.Location = new System.Drawing.Point(0, 646);
            this.btnStockPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStockPage.Name = "btnStockPage";
            this.btnStockPage.Normalcolor = System.Drawing.Color.CornflowerBlue;
            this.btnStockPage.OnHovercolor = System.Drawing.Color.MidnightBlue;
            this.btnStockPage.OnHoverTextColor = System.Drawing.Color.White;
            this.btnStockPage.selected = false;
            this.btnStockPage.Size = new System.Drawing.Size(278, 64);
            this.btnStockPage.TabIndex = 8;
            this.btnStockPage.Text = "Stock";
            this.btnStockPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnStockPage.Textcolor = System.Drawing.Color.White;
            this.btnStockPage.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockPage.Click += new System.EventHandler(this.btnStockPage_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.Activecolor = System.Drawing.Color.MidnightBlue;
            this.btnInventory.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnInventory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInventory.BorderRadius = 0;
            this.btnInventory.ButtonText = "Inventory";
            this.btnInventory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pageTrans.SetDecoration(this.btnInventory, BunifuAnimatorNS.DecorationType.None);
            this.btnInventory.DisabledColor = System.Drawing.Color.Gray;
            this.btnInventory.Iconcolor = System.Drawing.Color.Transparent;
            this.btnInventory.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnInventory.Iconimage")));
            this.btnInventory.Iconimage_right = null;
            this.btnInventory.Iconimage_right_Selected = null;
            this.btnInventory.Iconimage_Selected = null;
            this.btnInventory.IconMarginLeft = 0;
            this.btnInventory.IconMarginRight = 0;
            this.btnInventory.IconRightVisible = true;
            this.btnInventory.IconRightZoom = 0D;
            this.btnInventory.IconVisible = true;
            this.btnInventory.IconZoom = 45D;
            this.btnInventory.IsTab = false;
            this.btnInventory.Location = new System.Drawing.Point(0, 726);
            this.btnInventory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Normalcolor = System.Drawing.Color.CornflowerBlue;
            this.btnInventory.OnHovercolor = System.Drawing.Color.MidnightBlue;
            this.btnInventory.OnHoverTextColor = System.Drawing.Color.White;
            this.btnInventory.selected = false;
            this.btnInventory.Size = new System.Drawing.Size(278, 64);
            this.btnInventory.TabIndex = 7;
            this.btnInventory.Text = "Inventory";
            this.btnInventory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnInventory.Textcolor = System.Drawing.Color.White;
            this.btnInventory.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // btnSales
            // 
            this.btnSales.Activecolor = System.Drawing.Color.MidnightBlue;
            this.btnSales.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSales.BorderRadius = 0;
            this.btnSales.ButtonText = "Sales";
            this.btnSales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pageTrans.SetDecoration(this.btnSales, BunifuAnimatorNS.DecorationType.None);
            this.btnSales.DisabledColor = System.Drawing.Color.Gray;
            this.btnSales.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSales.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSales.Iconimage")));
            this.btnSales.Iconimage_right = null;
            this.btnSales.Iconimage_right_Selected = null;
            this.btnSales.Iconimage_Selected = null;
            this.btnSales.IconMarginLeft = 0;
            this.btnSales.IconMarginRight = 0;
            this.btnSales.IconRightVisible = true;
            this.btnSales.IconRightZoom = 0D;
            this.btnSales.IconVisible = true;
            this.btnSales.IconZoom = 45D;
            this.btnSales.IsTab = false;
            this.btnSales.Location = new System.Drawing.Point(0, 565);
            this.btnSales.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSales.Name = "btnSales";
            this.btnSales.Normalcolor = System.Drawing.Color.CornflowerBlue;
            this.btnSales.OnHovercolor = System.Drawing.Color.MidnightBlue;
            this.btnSales.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSales.selected = false;
            this.btnSales.Size = new System.Drawing.Size(278, 64);
            this.btnSales.TabIndex = 6;
            this.btnSales.Text = "Sales";
            this.btnSales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSales.Textcolor = System.Drawing.Color.White;
            this.btnSales.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.pageTrans.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(41, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Welcome Administrator";
            // 
            // btnSuppliers
            // 
            this.btnSuppliers.Activecolor = System.Drawing.Color.MidnightBlue;
            this.btnSuppliers.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSuppliers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSuppliers.BorderRadius = 0;
            this.btnSuppliers.ButtonText = "Suppliers";
            this.btnSuppliers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pageTrans.SetDecoration(this.btnSuppliers, BunifuAnimatorNS.DecorationType.None);
            this.btnSuppliers.DisabledColor = System.Drawing.Color.Gray;
            this.btnSuppliers.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSuppliers.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSuppliers.Iconimage")));
            this.btnSuppliers.Iconimage_right = null;
            this.btnSuppliers.Iconimage_right_Selected = null;
            this.btnSuppliers.Iconimage_Selected = null;
            this.btnSuppliers.IconMarginLeft = 0;
            this.btnSuppliers.IconMarginRight = 0;
            this.btnSuppliers.IconRightVisible = true;
            this.btnSuppliers.IconRightZoom = 0D;
            this.btnSuppliers.IconVisible = true;
            this.btnSuppliers.IconZoom = 45D;
            this.btnSuppliers.IsTab = false;
            this.btnSuppliers.Location = new System.Drawing.Point(0, 487);
            this.btnSuppliers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSuppliers.Name = "btnSuppliers";
            this.btnSuppliers.Normalcolor = System.Drawing.Color.CornflowerBlue;
            this.btnSuppliers.OnHovercolor = System.Drawing.Color.MidnightBlue;
            this.btnSuppliers.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSuppliers.selected = false;
            this.btnSuppliers.Size = new System.Drawing.Size(278, 60);
            this.btnSuppliers.TabIndex = 3;
            this.btnSuppliers.Text = "Suppliers";
            this.btnSuppliers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSuppliers.Textcolor = System.Drawing.Color.White;
            this.btnSuppliers.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuppliers.Click += new System.EventHandler(this.btnSuppliers_Click);
            // 
            // btnDeliverPage
            // 
            this.btnDeliverPage.Activecolor = System.Drawing.Color.MidnightBlue;
            this.btnDeliverPage.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnDeliverPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeliverPage.BorderRadius = 0;
            this.btnDeliverPage.ButtonText = "Deliveries";
            this.btnDeliverPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pageTrans.SetDecoration(this.btnDeliverPage, BunifuAnimatorNS.DecorationType.None);
            this.btnDeliverPage.DisabledColor = System.Drawing.Color.Gray;
            this.btnDeliverPage.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDeliverPage.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDeliverPage.Iconimage")));
            this.btnDeliverPage.Iconimage_right = null;
            this.btnDeliverPage.Iconimage_right_Selected = null;
            this.btnDeliverPage.Iconimage_Selected = null;
            this.btnDeliverPage.IconMarginLeft = 0;
            this.btnDeliverPage.IconMarginRight = 0;
            this.btnDeliverPage.IconRightVisible = true;
            this.btnDeliverPage.IconRightZoom = 0D;
            this.btnDeliverPage.IconVisible = true;
            this.btnDeliverPage.IconZoom = 45D;
            this.btnDeliverPage.IsTab = false;
            this.btnDeliverPage.Location = new System.Drawing.Point(0, 410);
            this.btnDeliverPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeliverPage.Name = "btnDeliverPage";
            this.btnDeliverPage.Normalcolor = System.Drawing.Color.CornflowerBlue;
            this.btnDeliverPage.OnHovercolor = System.Drawing.Color.MidnightBlue;
            this.btnDeliverPage.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDeliverPage.selected = false;
            this.btnDeliverPage.Size = new System.Drawing.Size(278, 60);
            this.btnDeliverPage.TabIndex = 2;
            this.btnDeliverPage.Text = "Deliveries";
            this.btnDeliverPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDeliverPage.Textcolor = System.Drawing.Color.White;
            this.btnDeliverPage.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeliverPage.Click += new System.EventHandler(this.btnDeliverPage_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.Activecolor = System.Drawing.Color.MidnightBlue;
            this.btnUsers.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnUsers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUsers.BorderRadius = 0;
            this.btnUsers.ButtonText = "Current Users";
            this.btnUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pageTrans.SetDecoration(this.btnUsers, BunifuAnimatorNS.DecorationType.None);
            this.btnUsers.DisabledColor = System.Drawing.Color.Gray;
            this.btnUsers.Iconcolor = System.Drawing.Color.Transparent;
            this.btnUsers.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnUsers.Iconimage")));
            this.btnUsers.Iconimage_right = null;
            this.btnUsers.Iconimage_right_Selected = null;
            this.btnUsers.Iconimage_Selected = null;
            this.btnUsers.IconMarginLeft = 0;
            this.btnUsers.IconMarginRight = 0;
            this.btnUsers.IconRightVisible = true;
            this.btnUsers.IconRightZoom = 0D;
            this.btnUsers.IconVisible = true;
            this.btnUsers.IconZoom = 45D;
            this.btnUsers.IsTab = false;
            this.btnUsers.Location = new System.Drawing.Point(0, 332);
            this.btnUsers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Normalcolor = System.Drawing.Color.CornflowerBlue;
            this.btnUsers.OnHovercolor = System.Drawing.Color.MidnightBlue;
            this.btnUsers.OnHoverTextColor = System.Drawing.Color.White;
            this.btnUsers.selected = false;
            this.btnUsers.Size = new System.Drawing.Size(278, 60);
            this.btnUsers.TabIndex = 1;
            this.btnUsers.Text = "Current Users";
            this.btnUsers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUsers.Textcolor = System.Drawing.Color.White;
            this.btnUsers.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnHome
            // 
            this.btnHome.Activecolor = System.Drawing.Color.MidnightBlue;
            this.btnHome.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome.BorderRadius = 0;
            this.btnHome.ButtonText = "Home";
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pageTrans.SetDecoration(this.btnHome, BunifuAnimatorNS.DecorationType.None);
            this.btnHome.DisabledColor = System.Drawing.Color.Gray;
            this.btnHome.Iconcolor = System.Drawing.Color.Transparent;
            this.btnHome.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnHome.Iconimage")));
            this.btnHome.Iconimage_right = null;
            this.btnHome.Iconimage_right_Selected = null;
            this.btnHome.Iconimage_Selected = null;
            this.btnHome.IconMarginLeft = 0;
            this.btnHome.IconMarginRight = 0;
            this.btnHome.IconRightVisible = true;
            this.btnHome.IconRightZoom = 0D;
            this.btnHome.IconVisible = true;
            this.btnHome.IconZoom = 45D;
            this.btnHome.IsTab = false;
            this.btnHome.Location = new System.Drawing.Point(0, 254);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHome.Name = "btnHome";
            this.btnHome.Normalcolor = System.Drawing.Color.CornflowerBlue;
            this.btnHome.OnHovercolor = System.Drawing.Color.MidnightBlue;
            this.btnHome.OnHoverTextColor = System.Drawing.Color.White;
            this.btnHome.selected = false;
            this.btnHome.Size = new System.Drawing.Size(278, 60);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnHome.Textcolor = System.Drawing.Color.White;
            this.btnHome.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(94)))));
            this.headerPanel.Controls.Add(this.pictureBox3);
            this.headerPanel.Controls.Add(this.label2);
            this.pageTrans.SetDecoration(this.headerPanel, BunifuAnimatorNS.DecorationType.None);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1240, 39);
            this.headerPanel.TabIndex = 8;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pageTrans.SetDecoration(this.pictureBox3, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(9, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(29, 28);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.pageTrans.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(46, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(322, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "GLORIOUS INVENTORY SYSTEM 1.0";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.headerPanel;
            this.bunifuDragControl1.Vertical = true;
            // 
            // backupDatabaseToolStripMenuItem
            // 
            this.backupDatabaseToolStripMenuItem.Name = "backupDatabaseToolStripMenuItem";
            this.backupDatabaseToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.backupDatabaseToolStripMenuItem.Text = "Backup Database";
            this.backupDatabaseToolStripMenuItem.Click += new System.EventHandler(this.backupDatabaseToolStripMenuItem_Click);
            // 
            // Inventory_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1240, 966);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.headerPanel);
            this.pageTrans.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Inventory_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home Page";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Inventory_Main_FormClosing);
            this.Load += new System.EventHandler(this.Inventory_Main_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblFooterStat;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem rEPORTSToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem sTOCKREPORTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iNVENTORYREPORTToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnHome;
        private Bunifu.Framework.UI.BunifuFlatButton btnSuppliers;
        private Bunifu.Framework.UI.BunifuFlatButton btnDeliverPage;
        private Bunifu.Framework.UI.BunifuFlatButton btnUsers;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuFlatButton btnSales;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuFlatButton btnInventory;
        private Bunifu.Framework.UI.BunifuFlatButton btnStockPage;
        private System.Windows.Forms.ToolStripMenuItem tRANSACTIONSToolStripMenuItem;
        public BunifuAnimatorNS.BunifuTransition pageTrans;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.ToolStripStatusLabel footerLastCode;
        private System.Windows.Forms.PictureBox pictureBox3;
        public System.Windows.Forms.Panel headerPanel;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.ToolStripMenuItem backupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backupDatabaseToolStripMenuItem;
    }
}



