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
    public partial class inventoryList : Form
    {
        public string strSearch,itemName,itemCode,itemDesc,itemSupp,itemBrand,itemUm,itemType,dateTime;
        public int qty,currStock,currInventory;
        float itemCost, itemSrp;



        dbGc db = new dbGc();
        InventoryQty invQtyPage = new InventoryQty();
        notification notification;
        view view = new view();
        Inventory_Info inventoryInfoPage = new Inventory_Info();
        public inventoryList()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void inventoryList_Load(object sender, EventArgs e)
        {            
            // TODO: This line of code loads data into the 'gcDataSet.inventory' table. You can move, or remove it, as needed.            
            DataTable dt = db.GCSelectFromDb("inventory",null,null,"ORDER BY id DESC");
            dgStock.DataSource = dt;            
        }

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

                if ( cmbFilterName.Text == "Item Name" )
                {
                    strSearch += "gc_item_name='" + txtSearchbox.Text + "%'";
                }
                else if (cmbFilterName.Text == "Item Code")
                {
                    strSearch += "gc_item_code='" + txtSearchbox.Text + "%'";
                }
                else if (cmbFilterName.Text == "Item Brand")
                {
                    strSearch += "gc_item_brand='" + txtSearchbox.Text + "%'";
                }
            }
        }
        private void btnSearchInv_Click(object sender, EventArgs e)
        {
            StringBuilder where = new StringBuilder();

            if (cmbFilterName.Text == "Item Name")
            {
                where.Append("gc_item_name LIKE '%" + txtSearchbox.Text + "%'");
            }
            else if (cmbFilterName.Text == "Item Code")
            {
                where.Append("gc_item_code LIKE '%" + txtSearchbox.Text + "%'");
            }
            else if (cmbFilterName.Text == "Item Brand")
            {
                where.Append("gc_item_brand LIKE '%" + txtSearchbox.Text + "%'");
            }
            else
            {
                where.Append("gc_item_name LIKE '%" + txtSearchbox.Text + "%'");
            }

            DataTable dt = db.GCSelectFromDb("inventory", null, where,"ORDER BY id DESC");
            dgStock.DataSource = null;
            dgStock.DataSource = dt;
        }
        private void dgStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {            
            var senderGrid = (DataGridView)sender;
            if (e.ColumnIndex == 11)
            {
                try
                {
                    itemName = senderGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                    itemCode = senderGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                    qty = (int)senderGrid.Rows[e.RowIndex].Cells[2].Value;
                    itemDesc = senderGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
                    itemSupp = senderGrid.Rows[e.RowIndex].Cells[4].Value.ToString();
                    itemBrand = senderGrid.Rows[e.RowIndex].Cells[5].Value.ToString();
                    itemUm = senderGrid.Rows[e.RowIndex].Cells[6].Value.ToString();
                    itemCost = float.Parse(senderGrid.Rows[e.RowIndex].Cells[7].Value.ToString());
                    itemSrp = float.Parse(senderGrid.Rows[e.RowIndex].Cells[8].Value.ToString());
                    itemType = senderGrid.Rows[e.RowIndex].Cells[10].Value.ToString();

                    invQtyPage.btnAddQty.Click += BtnAddQty_Click;
                    invQtyPage.ShowDialog();
                }
                catch (Exception a)
                {
                    MessageBox.Show("Invalid Item, cannot add : " + a.Message, "Invalid Item", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    invQtyPage.btnAddQty.Click -= BtnAddQty_Click;
                }
            }else if (e.ColumnIndex == 12)
            {
                inventoryInfoPage.itemName = senderGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                inventoryInfoPage.itemCode = senderGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                inventoryInfoPage.itemSupp = senderGrid.Rows[e.RowIndex].Cells[4].Value.ToString();
                inventoryInfoPage.itemBrand = senderGrid.Rows[e.RowIndex].Cells[5].Value.ToString();

                inventoryInfoPage.txtItemPrice.Text = senderGrid.Rows[e.RowIndex].Cells[8].Value.ToString();
                inventoryInfoPage.txtQty.Text = senderGrid.Rows[e.RowIndex].Cells[2].Value.ToString();

                inventoryInfoPage.btnSave.Click += BtnSave_Click;

                inventoryInfoPage.ShowDialog();
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            DataTable dtSave = db.GCSelectFromDb("inventory", null, null,"ORDER BY id DESC");
            dgStock.DataSource = null;            
            dgStock.DataSource = dtSave;
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
            inventoryInfoPage.btnSave.Click -= BtnSave_Click;
            notification = new notification("Product has been updated.", notification.AlertType.success);
            notification.ShowDialog();
            inventoryInfoPage.Close();
        }

        private void BtnAddQty_Click(object sender, EventArgs e)
        {            
            try
            {                
                StringBuilder paramInv = new StringBuilder();
                StringBuilder whereInv = new StringBuilder();
                StringBuilder whereSearch = new StringBuilder();

                whereSearch.Append("gc_item_code='" + itemCode + "'");
                int resItemCode = db.searchData("stock", null, whereSearch);

                paramInv.Append("gc_item_qty");
                whereInv.Append("gc_item_code='" + itemCode + "'");

                DataTable dtInv = db.GCSelectFromDb("inventory", paramInv, whereInv);
                foreach (DataRow rowInv in dtInv.Rows)
                {
                    currInventory = int.Parse(rowInv[0].ToString());
                }

                if (currInventory >= int.Parse(invQtyPage.txtQty.Text))
                {
                    StringBuilder param = new StringBuilder();
                    StringBuilder where = new StringBuilder();

                    param.Append("gc_item_qty");
                    where.Append("gc_item_code='" + itemCode + "'");

                    DataTable dt = db.GCSelectFromDb("stock", param, where);
                    foreach (DataRow row in dt.Rows)
                    {
                        currStock = int.Parse(row[0].ToString());
                    }

                    if (resItemCode == 1)
                    {
                        StringBuilder paramUpdate = new StringBuilder();
                        StringBuilder valuesUpdate = new StringBuilder();
                        StringBuilder whereUpdate = new StringBuilder();

                        whereUpdate.Append("gc_item_code='" + itemCode + "'");
                        paramUpdate.Append("gc_item_qty");
                        valuesUpdate.Append(currStock + int.Parse(invQtyPage.txtQty.Text));
                        db.GCUpdateDb("stock", paramUpdate, valuesUpdate, whereUpdate);
                        notification = new notification("Stock has been updated",notification.AlertType.success);
                        notification.ShowDialog();
                        invQtyPage.btnAddQty.Click -= BtnAddQty_Click;
                    }
                    else
                    {
                        StringBuilder paramInsert = new StringBuilder();
                        StringBuilder valuesInsert = new StringBuilder();

                        paramInsert.Append(
                            "gc_item_name," +
                            "gc_item_qty," +
                            "gc_item_desc," +
                            "gc_item_supp," +
                            "gc_item_brand," +
                            "gc_item_um," +
                            "gc_item_cost," +
                            "gc_item_srp," +
                            "gc_date_added," +
                            "gc_item_code," +
                            "gc_item_type"
                        );

                        valuesInsert.Append(
                            itemName + "," +
                            int.Parse(invQtyPage.txtQty.Text) + "," +
                            itemDesc + "," +
                            itemSupp + "," +
                            itemBrand + "," +
                            itemUm + "," +
                            itemCost + "," +
                            itemSrp + "," +
                            DateTime.Today.ToString("MM/dd/yyyy") + "," +
                            itemCode + "," +
                            itemType
                        );
                        db.GCInsertToDb("stock", paramInsert, valuesInsert);                        
                        notification = new notification("Item has been added to stock!", notification.AlertType.success);
                        notification.ShowDialog();
                        invQtyPage.btnAddQty.Click -= BtnAddQty_Click;
                    }

                    updateTrans("stock", itemCode, "in", int.Parse(invQtyPage.txtQty.Text), currStock, itemName);

                    StringBuilder paramUpdateInv = new StringBuilder();
                    StringBuilder valuesUpdteInv = new StringBuilder();
                    StringBuilder whereUpdateInv = new StringBuilder();

                    whereUpdateInv.Append("gc_item_code='" + itemCode + "'");
                    paramUpdateInv.Append("gc_item_qty");

                    valuesUpdteInv.Append(currInventory - int.Parse(invQtyPage.txtQty.Text));
                    db.GCUpdateDb("inventory", paramUpdateInv, valuesUpdteInv, whereUpdateInv);
                    updateTrans("inventory", itemCode, "out", int.Parse(invQtyPage.txtQty.Text), currInventory, itemName);


                    dgStock.DataSource = null;

                    DataTable dtRefresh = db.GCSelectFromDb("inventory", null, null, "ORDER BY id DESC");
                    dgStock.DataSource = dtRefresh;
                    invQtyPage.btnAddQty.Click -= BtnAddQty_Click;
                }
                else
                {
                    MessageBox.Show("Not enough item on inventory", "Inventory Dont have enought Item", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                    invQtyPage.btnAddQty.Click -= BtnAddQty_Click;
                }
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
                invQtyPage.btnAddQty.Click -= BtnAddQty_Click;
            }     
            
            invQtyPage.btnAddQty.Click -= BtnAddQty_Click;
            dgStock.Refresh();
            invQtyPage.Close();
        }

        public void updateTrans(string tblname,string itemCode,string actionName,int itemQty, int currQty,string itmName)
        {
            string randID = view.Random("ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789", 5);
            StringBuilder param = new StringBuilder();
            StringBuilder values = new StringBuilder();
            param.Append("gc_from_tbl,gc_action_name,gc_item_qty,gc_curr_qty,gc_trans_date,gc_unique_id,gc_item_code,gc_item_name,gc_total_price");
            values.Append(
                tblname+","+
                actionName + "," +
                itemQty + "," +
                currQty + "," +
                DateTime.Today.ToString("MM/dd/yyyy") + "," +
                randID + "," +
                itemCode + "," +
                itmName + "," +
                itemSrp * itemQty
            );
            db.GCInsertToDb("transact",param,values);
        }
    }
}
