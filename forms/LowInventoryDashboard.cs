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
    public partial class LowInventoryDashboard : Form
    {
        dbGc db = new dbGc();
        public LowInventoryDashboard()
        {
            InitializeComponent();
        }

        private void LowInventoryDashboard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gcDataSet.inventory' table. You can move, or remove it, as needed.
            this.inventoryTableAdapter.Fill(this.gcDataSet.inventory);
            StringBuilder whereLow = new StringBuilder();
            whereLow.Append("gc_item_qty < 10");
            DataTable dt = db.GCSelectFromDb("inventory", null, whereLow);
            dgInventory.DataSource = null;
            dgInventory.DataSource = dt;
        }
    }
}
