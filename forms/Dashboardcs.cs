using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventory_System.core;
using Inventory_System.forms;

namespace Inventory_System.forms
{
    public partial class Dashboardcs : Form
    {
        dbGc db = new dbGc();
        LowOnStockDashboard lowstockPage = new LowOnStockDashboard();
        inventoryList inventoryPage;
        DeliveryStatusDashboard deliveryStatPage = new DeliveryStatusDashboard();
        LowInventoryDashboard lowInventoryPage = new LowInventoryDashboard();
        DateTime delTerms;
        public Dashboardcs()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void Dashboardcs_Load(object sender, EventArgs e)
        {
            StringBuilder where = new StringBuilder();
            StringBuilder param = new StringBuilder();

            where.Append("gc_item_qty < 10");
            int resStock = db.searchData("stock",null,where);
            if ( resStock < 10 )
            {
                lblStockLow.Text = "0" + resStock.ToString();
            }else
            {
                lblStockLow.Text = resStock.ToString();
            }
            

            int resInv = db.searchData("inventory",null,null);
            if (resInv < 10)
            {
                lblInvTotal.Text = "0" + resInv.ToString();
            }
            else
            {
                lblInvTotal.Text = resInv.ToString();
            }

            int resDelivery = db.searchData("delivery",null,null);
            if (resInv < 10)
            {
                lblDelivery.Text = "0" + resDelivery.ToString();
            }
            else
            {
                lblDelivery.Text = resDelivery.ToString();
            }

        }

        private void btnLowStock_Click(object sender, EventArgs e)
        {
            lowstockPage.ShowDialog();
        }

        private void btnInventoryPage_Click(object sender, EventArgs e)
        {
            lowInventoryPage.ShowDialog();
        }

        private void btnDeliveryItems_Click(object sender, EventArgs e)
        {
            deliveryStatPage.ShowDialog();
        }
    }
}
