using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventory_System.Report_Forms;
using System.Diagnostics;
using Inventory_System.core;
using Microsoft.Win32;

namespace Inventory_System.forms
{
    public partial class Inventory_Main : Form
    {
        bool close = true;
        stockList stockListPage = new stockList();
        
        Stock_Report stockRptPage = new Stock_Report();
        Inventory_Report inventoryRptPage = new Inventory_Report();

        inventoryList inventoryPage = new inventoryList();
        Dashboardcs mainDashboard = new Dashboardcs();
        Transaction transactionPage = new Transaction();
        SupplierList supplierPage = new SupplierList();
        ProductList prodPage = new ProductList();
        SalesDashboard salesDashPage = new SalesDashboard();
        UsersList userPage = new UsersList();
        Delivery deliverDashboard = new Delivery();
        FormCollection frm = Application.OpenForms;
        
        public Inventory_Main()
        {
            InitializeComponent();
            this.Visible = false;
            if (mainDashboard.IsDisposed == true)
            {
                mainDashboard = new Dashboardcs();
            }
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            mainDashboard.MdiParent = this;
            mainDashboard.Show();
            //MessageBox.Show(Application.StartupPath.ToString() + "\\reports\\receipt.rpt");
            //MessageBox.Show(System.IO.Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName));
        }

        private void Inventory_Main_FormClosing(object sender, FormClosingEventArgs e)
        {            
            if ( close )
            {
                DialogResult dialogres = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogres == DialogResult.Yes)
                {
                    close = false;
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (close)
            {
                DialogResult dialogres = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogres == DialogResult.Yes)
                {
                    close = false;
                    Application.Exit();
                }
                else
                {
                    return;
                }
            }
        }

        private void sTOCKREPORTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form fm in this.MdiChildren)
            {
                fm.Close();
            }
            if (stockRptPage.IsDisposed == true)
            {
                stockRptPage = new Stock_Report();
            }

            stockRptPage.MdiParent = this;
            stockRptPage.Show();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            foreach ( Form fm in this.MdiChildren )
            {
                fm.Close();
            }
            //salesPage.ShowDialog();
            if (salesDashPage.IsDisposed == true)
            {
                salesDashPage = new SalesDashboard();
            }

            salesDashPage.MdiParent = this;
            salesDashPage.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            foreach (Form fm in this.MdiChildren)
            {
                fm.Close();
            }
            if (mainDashboard.IsDisposed == true)
            {
                mainDashboard = new Dashboardcs();
            }

            mainDashboard.MdiParent = this;
            mainDashboard.Show();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            foreach (Form fm in this.MdiChildren)
            {
                fm.Close();
            }
            if (inventoryPage.IsDisposed == true)
            {
                inventoryPage = new inventoryList();
            }

            inventoryPage.MdiParent = this;
            inventoryPage.Show();
        }

        private void btnStockPage_Click(object sender, EventArgs e)
        {
            foreach (Form fm in this.MdiChildren)
            {
                fm.Close();
            }
            if (stockListPage.IsDisposed == true)
            {
                stockListPage = new stockList();
            }

            stockListPage.MdiParent = this;
            stockListPage.Show();
        }

        private void btnDeliverPage_Click(object sender, EventArgs e)
        {
            foreach (Form fm in this.MdiChildren)
            {
                fm.Close();
            }
            if (deliverDashboard.IsDisposed == true)
            {
                deliverDashboard = new Delivery();
            }

            deliverDashboard.MdiParent = this;
            deliverDashboard.Show();
        }

        private void iNVENTORYREPORTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form fm in this.MdiChildren)
            {
                fm.Close();
            }
            if (inventoryRptPage.IsDisposed == true)
            {
                inventoryRptPage = new Inventory_Report();
            }

            inventoryRptPage.MdiParent = this;
            inventoryRptPage.Show();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            foreach (Form fm in this.MdiChildren)
            {
                fm.Close();
            }
            if (userPage.IsDisposed == true)
            {
                userPage = new UsersList();
            }

            userPage.MdiParent = this;
            userPage.Show();
        }

        private void tRANSACTIONSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form fm in this.MdiChildren)
            {
                fm.Close();
            }
            if (prodPage.IsDisposed == true)
            {
                prodPage = new ProductList();
            }

            prodPage.MdiParent = this;
            prodPage.Show();
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            foreach (Form fm in this.MdiChildren)
            {
                fm.Close();
            }
            if (supplierPage.IsDisposed == true)
            {
                supplierPage = new SupplierList();
            }

            supplierPage.MdiParent = this;
            supplierPage.Show();
        }

        private void Inventory_Main_Load(object sender, EventArgs e)
        {
            footerLastCode.ForeColor = Color.DarkBlue;
            
            dbGc db = new dbGc();
            StringBuilder param = new StringBuilder();
            param.Append("gc_item_code");
            DataTable dt = db.GCSelectFromDb("products", param, null, " ORDER BY id ASC");
            foreach (DataRow row in dt.Rows)
            {
                footerLastCode.Text = "Last item ID : " + row[0].ToString();                
            }

            prodPage.btnSave.Click += BtnSave_Click;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            footerLastCode.Text = "Last item ID : " + prodPage.txtItemCode.Text;
        }

        private void restoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openBackup = new OpenFileDialog();
            openBackup.Filter = "bak files (*.bak)|*.bak|All files (*.*)|*.*";
            openBackup.DefaultExt = "bak";
            openBackup.RestoreDirectory = true;
            openBackup.InitialDirectory = @"C:\";
            openBackup.ShowDialog();
            MessageBox.Show(openBackup.FileName);
        }

        private void backupDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDb = new SaveFileDialog();
            string path = Registry.GetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Shell Folders", "{374DE290-123F-4565-9164-39C4925E467B}", String.Empty).ToString();
            dbGc db = new dbGc();
            try
            {
                saveDb.Filter = "bak files (*.bak)|*.bak|All files (*.*)|*.*";
                saveDb.InitialDirectory = path;
                saveDb.RestoreDirectory = true;
                saveDb.DefaultExt = "bak";
                if (saveDb.ShowDialog() == DialogResult.OK)
                {
                    db.backupDb(saveDb.FileName);
                    notification notification = new notification("Database backup completed.", notification.AlertType.success);
                    notification.ShowDialog();
                }
            }
            catch (Exception a)
            {
                notification notification = new notification("Database backup error.", notification.AlertType.error);
                notification.ShowDialog();
                return;
            }
        }
    }
}
