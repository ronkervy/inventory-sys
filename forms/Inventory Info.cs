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
    public partial class Inventory_Info : Form
    {
        dbGc db = new dbGc();
        view view = new view();
        notification notification;

        public string itemCode, itemName, itemSupp, itemBrand;
        public Inventory_Info()
        {
            InitializeComponent();
        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            view.chkNum(txtQty,e);
        }

        private void txtItemPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            view.chkNum(txtItemPrice,e);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            inventoryList invPage = new inventoryList();
            StringBuilder where = new StringBuilder();
            StringBuilder param = new StringBuilder();
            StringBuilder values = new StringBuilder();

            param.Append("gc_item_qty,gc_item_srp");
            where.Append("gc_item_name='"+itemName+"' AND gc_item_code='"+itemCode+"'");
            values.Append(
                int.Parse(txtQty.Text) + "," +
                float.Parse(txtItemPrice.Text)
            );

            db.GCUpdateDb("inventory", param, values, where);
        }
    }
}
