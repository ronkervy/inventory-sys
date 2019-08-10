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

namespace Inventory_System.forms
{
    public partial class LowOnStockDashboard : Form
    {
        dbGc db = new dbGc();
        public LowOnStockDashboard()
        {
            InitializeComponent();
        }

        private void LowOnStockDashboard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gcDataSet.stock' table. You can move, or remove it, as needed.
            this.stockTableAdapter.Fill(this.gcDataSet.stock);
            StringBuilder whereLow = new StringBuilder();
            whereLow.Append("gc_item_qty < 10");
            DataTable dt = db.GCSelectFromDb("stock",null,whereLow);
            dgLowStock.DataSource = null;
            dgLowStock.DataSource = dt;
        }
    }
}
