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
using System.Globalization;

namespace Inventory_System.forms
{
    public partial class stockList : Form
    {
        dbGc db = new dbGc();
        notification notification;
        public string strSearch, itemName, itemCode, itemDesc, itemSupp, itemBrand, itemUm, itemType;
        public int qty, currStock, currInventory;

        private void dgStock_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dgStock.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    if (int.Parse(row.Cells[2].Value.ToString()) <= 5)
                    {
                        row.DefaultCellStyle.BackColor = Color.Maroon;
                        row.DefaultCellStyle.ForeColor = Color.White;
                    }
                }
            }
        }

        private void cmbFilterName_TextChanged(object sender, EventArgs e)
        {
            if ( cmbFilterName.Text != "" )
            {
                txtSearchbox.Enabled = true;
            }
        }

        float itemCost,itemSrp;
        stockQty stockAddPage = new stockQty();
        view view = new view();
        public stockList()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void stockList_Load(object sender, EventArgs e)
        {
           DataTable dt = db.GCSelectFromDb("stock",null,null,"ORDER BY id DESC");
           dgStock.DataSource = dt;            
        }

        private void dgStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (e.ColumnIndex == 12 )
            {
                try
                {
                    itemName = senderGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                    itemCode = senderGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                    qty = int.Parse(senderGrid.Rows[e.RowIndex].Cells[2].Value.ToString());
                    itemDesc = senderGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
                    itemSupp = senderGrid.Rows[e.RowIndex].Cells[4].Value.ToString();
                    itemBrand = senderGrid.Rows[e.RowIndex].Cells[5].Value.ToString();
                    itemUm = senderGrid.Rows[e.RowIndex].Cells[6].Value.ToString();
                    itemCost = float.Parse(senderGrid.Rows[e.RowIndex].Cells[7].Value.ToString());
                    itemSrp = float.Parse(senderGrid.Rows[e.RowIndex].Cells[8].Value.ToString());
                    itemType = senderGrid.Rows[e.RowIndex].Cells[10].Value.ToString();

                    stockAddPage.btnAddQty.Click += BtnAddQty_Click;
                    stockAddPage.ShowDialog();
                }
                catch(Exception a)
                {
                    MessageBox.Show(a.Message);
                }
            }
            else if (e.ColumnIndex == 11)
            {
                StringBuilder whereDel = new StringBuilder();
                StringBuilder valuesDel = new StringBuilder();

                StringBuilder paramInvUpdate = new StringBuilder();
                StringBuilder valuesInvUpdate = new StringBuilder();
                StringBuilder whereInvUpdate = new StringBuilder();

                StringBuilder paramInvAdd = new StringBuilder();
                StringBuilder whereInvAdd = new StringBuilder();

                DialogResult delRes = MessageBox.Show("Are you sure you want to delete this stock?", "Delete Supplier?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (delRes == DialogResult.Yes)
                {
                    paramInvAdd.Append("gc_item_qty");
                    whereInvAdd.Append("gc_item_code='" + senderGrid.Rows[e.RowIndex].Cells[1].Value.ToString() + "'");
                    DataTable dtInv = db.GCSelectFromDb("inventory", paramInvAdd, whereInvAdd);
                    foreach (DataRow row in dtInv.Rows)
                    {
                        currInventory = int.Parse(row[0].ToString());
                    }
                    whereDel.Append("gc_item_code");
                    valuesDel.Append(senderGrid.Rows[e.RowIndex].Cells[1].Value.ToString());
                    db.GCDeleteFromDb("stock",valuesDel,whereDel);

                    paramInvUpdate.Append("gc_item_qty");
                    valuesInvUpdate.Append(currInventory + int.Parse(senderGrid.Rows[e.RowIndex].Cells[2].Value.ToString()));
                    whereInvUpdate.Append("gc_item_code='"+ senderGrid.Rows[e.RowIndex].Cells[1].Value.ToString() + "'");
                    db.GCUpdateDb("inventory",paramInvUpdate,valuesInvUpdate,whereInvUpdate);

                    notification = new notification("Stock has been deleted.", notification.AlertType.success);
                    notification.ShowDialog();

                    dgStock.DataSource = null;
                    DataTable dtRemove = db.GCSelectFromDb("stock", null, null, "ORDER BY id DESC");
                    dgStock.DataSource = dtRemove;
                }
            }
        }

        private void BtnAddQty_Click(object sender, EventArgs e)
        {
            StringBuilder paramStock = new StringBuilder();
            StringBuilder whereStock = new StringBuilder();
            StringBuilder valuesStock = new StringBuilder();

            StringBuilder paramInv = new StringBuilder();
            StringBuilder whereInv = new StringBuilder();

            paramInv.Append("gc_item_qty");
            whereInv.Append("gc_item_code='" + itemCode + "'");
            DataTable dtInv = db.GCSelectFromDb("inventory", paramInv, whereInv);
            foreach (DataRow row in dtInv.Rows)
            {
                currInventory = int.Parse(row[0].ToString());
            }

            foreach (DataGridViewRow row in dgStock.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    if (int.Parse(row.Cells[2].Value.ToString()) <= 5)
                    {
                        row.DefaultCellStyle.BackColor = Color.Maroon;
                        row.DefaultCellStyle.ForeColor = Color.White;
                    }
                }
            }

            if ( currInventory >= int.Parse(stockAddPage.txtQty.Text) )
            {
                paramStock.Append("gc_item_qty");
                valuesStock.Append(qty + int.Parse(stockAddPage.txtQty.Text));
                whereStock.Append("gc_item_code='"+itemCode+"'");

                db.GCUpdateDb("stock",paramStock,valuesStock,whereStock);

                StringBuilder paramUpdateInv = new StringBuilder();
                StringBuilder valuesUpdateInv = new StringBuilder();
                StringBuilder whereUpdateInv = new StringBuilder();

                paramUpdateInv.Append("gc_item_qty");
                valuesUpdateInv.Append(currInventory - int.Parse(stockAddPage.txtQty.Text));
                whereUpdateInv.Append("gc_item_code='"+itemCode+"'");

                db.GCUpdateDb("inventory",paramUpdateInv,valuesUpdateInv,whereUpdateInv);

                updateTrans("stock", itemCode, "in", int.Parse(stockAddPage.txtQty.Text),qty,itemName);
                updateTrans("inventory", itemCode, "out", int.Parse(stockAddPage.txtQty.Text), currInventory,itemName);

                notification = new notification("Stock has been updated.", notification.AlertType.success);
                notification.ShowDialog();

                dgStock.DataSource = null;
                DataTable dt = db.GCSelectFromDb("stock", null, null,"ORDER BY id DESC");
                dgStock.DataSource = dt;
                stockAddPage.Close();
            }
            else
            {
                notification = new notification("Not enough item on inventory.", notification.AlertType.error);
                notification.ShowDialog();
            }

        }

        public void updateTrans(string tblname, string itemCode, string actionName, int itemQty, int currQty,string itmName)
        {
            string randID = view.Random("ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789", 5);
            StringBuilder param = new StringBuilder();
            StringBuilder values = new StringBuilder();
            param.Append("gc_from_tbl,gc_action_name,gc_item_qty,gc_curr_qty,gc_trans_date,gc_unique_id,gc_item_code,gc_item_name,gc_total_price");
            values.Append(
                tblname + "," +
                actionName + "," +
                itemQty + "," +
                currQty + "," +
                DateTime.ParseExact(DateTime.Now.ToShortDateString(), "MM/dd/yyyy", CultureInfo.InvariantCulture) + "," +
                randID + "," +
                itemCode + "," +
                itmName + "," +
                itemSrp * itemQty
            );
            db.GCInsertToDb("transact", param, values);
        }
        //DateTime.Now.Millisecond.ToString()
    }
}
