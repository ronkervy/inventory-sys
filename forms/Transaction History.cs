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
    public partial class Transaction_History : Form
    {
        dbGc db = new dbGc();
        Transaction transPage = new Transaction();
        GcTransaction transaction = new GcTransaction();
        notification notification;
        view view = new view();
        delQty delQtyPage = new delQty();
        receipt receiptPage = new receipt();

        public string itemName, itemCode, itemUm, itemDesc, transID;
        public int itemQty,currStockQty,addedQty,currStock;
        public float itemPrice, totalPrice, itemCost;
        public string[] items = new string[8];
        public Transaction_History()
        {
            InitializeComponent();
        }

        private void Transaction_History_Load(object sender, EventArgs e)
        {
            StringBuilder where = new StringBuilder();
            StringBuilder param = new StringBuilder();
            param.Append("DISTINCT gc_unique_id,gc_customer_name,gc_customer_add,gc_trans_date,gc_cust_cash,gc_cust_change");
            where.Append("gc_from_tbl='sales'");            
            DataTable dt = db.GCSelectFromDb("transact", param, where);
            dgTransHistory.DataSource = dt;
        }

        private void btnSearchHist_Click(object sender, EventArgs e)
        {
            StringBuilder whereSearch = new StringBuilder();
            whereSearch.Append("gc_from_tbl='Sales'");
            if ( cmbFilterName.Text != "" )
            {
                if ( cmbFilterName.Text == "ID" )
                {
                    whereSearch.Append(" AND gc_unique_id LIKE '%"+txtSearchbox.Text+ "%' AND gc_trans_date >='"+dtTransDateFrom.Value.ToShortDateString()+ "' AND gc_trans_date <='"+dtTransDateTo.Value.ToShortDateString()+"'");
                }else if ( cmbFilterName.Text == "Customer Name" )
                {
                    whereSearch.Append(" AND gc_customer_name LIKE '%"+txtSearchbox.Text+ "%' AND gc_trans_date >='" + dtTransDateFrom.Value.ToShortDateString() + "' AND gc_trans_date <='" + dtTransDateTo.Value.ToShortDateString() + "'");
                }
                else
                {
                    whereSearch.Append(" AND gc_trans_date >='" + dtTransDateFrom.Value.ToShortDateString() + "' AND gc_trans_date <='" + dtTransDateTo.Value.ToShortDateString() + "'");
                }
                DataTable dt = db.GCSelectFromDb("transact",null,whereSearch,"ORDER BY id DESC");
                dgTransHistory.DataSource = null;
                dgTransHistory.DataSource = dt;
            }
        }

        private void cmbFilterName_TextChanged(object sender, EventArgs e)
        {
            if ( cmbFilterName.Text != "" )
            {
                txtSearchbox.Enabled = true;
            }
        }

        private void dgTransHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView senderGrid = (DataGridView)sender;
            if (e.ColumnIndex == 7)
            {
                StringBuilder where = new StringBuilder();
                StringBuilder param = new StringBuilder();

                param.Append(
                    "gc_item_name," +
                    "gc_item_code," +
                    "gc_item_qty," +
                    "gc_item_srp," +
                    "gc_item_cost," +
                    "gc_um," +
                    "gc_item_desc," +
                    "gc_curr_qty," +
                    "gc_cust_cash," +
                    "gc_cust_change," +
                    "gc_customer_name," +
                    "gc_customer_add," +
                    "gc_unique_id"
                );

                where.Append(
                    "gc_unique_id='" + senderGrid.Rows[e.RowIndex].Cells[0].Value.ToString() + "' " +
                    "AND gc_customer_name='" + senderGrid.Rows[e.RowIndex].Cells[1].Value.ToString() + "'"
                );

                DataTable dt = db.GCSelectFromDb("transact", param, where);
                transPage.lvCart.Items.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    items[0] = row[0].ToString();
                    items[1] = row[1].ToString();
                    items[2] = row[2].ToString();
                    items[3] = row[3].ToString();
                    items[4] = row[4].ToString();
                    items[5] = row[5].ToString();
                    items[6] = row[6].ToString();
                    items[7] = row[7].ToString();
                    transPage.txtCustomerName.Text = row[10].ToString();
                    transPage.txtAddress.Text = row[11].ToString();
                    transPage.txtCash.Text = row[8].ToString();
                    transID = row[12].ToString();
                    ListViewItem lvi = new ListViewItem(items);
                    transPage.lvCart.Items.Add(lvi);
                }
                //transPage.lblTotal.Text = row[12].ToString();

                transPage.btnSaveTrans.Text = "Update Transaction";
                transPage.SaveMode = false;

                totalPrice = 0;

                foreach (ListViewItem lviTotal in transPage.lvCart.Items)
                {
                    totalPrice += float.Parse(lviTotal.SubItems[3].Text) * float.Parse(lviTotal.SubItems[2].Text);
                }

                transPage.lblTotal.Text = totalPrice.ToString();

                transPage.btnSaveTrans.Click += BtnSaveTrans_Click;

                transPage.ShowDialog();
            } else if (e.ColumnIndex == 8) {
                receiptPage.transID = senderGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                receiptPage.ShowDialog();
            }
            else if (e.ColumnIndex == 9)
            {
                DialogResult delTransHist = MessageBox.Show("Are you sure you want to delete this purchase history?", "Delete purchased History?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (delTransHist == DialogResult.Yes)
                {
                    StringBuilder whereDelHist = new StringBuilder();
                    StringBuilder valuesDelHist = new StringBuilder();
                    StringBuilder whereHist = new StringBuilder();
                    StringBuilder paramHist = new StringBuilder();

                    paramHist.Append("DISTINCT gc_unique_id,gc_customer_name,gc_customer_add,gc_trans_date,gc_cust_cash,gc_cust_change");
                    whereHist.Append("gc_from_tbl='sales'");

                    whereDelHist.Append("gc_unique_id,gc_customer_name");
                    valuesDelHist.Append(
                        senderGrid.Rows[e.RowIndex].Cells[0].Value.ToString() + "," +
                        senderGrid.Rows[e.RowIndex].Cells[1].Value.ToString()
                    );
                    db.GCDeleteFromDb("transact", valuesDelHist, whereDelHist);

                    dgTransHistory.DataSource = null;
                    DataTable dtDelHist = db.GCSelectFromDb("transact", paramHist, whereHist);
                    dgTransHistory.DataSource = dtDelHist;

                    notification = new notification("Purchased history deleted", notification.AlertType.error);
                    notification.ShowDialog();
                }
            }
        }

        private void BtnSaveTrans_Click(object sender, EventArgs e)
        {
            if ( float.Parse( transPage.lblTotal.Text ) > float.Parse(transPage.txtCash.Text) )
            {
                notification = new notification("Cash is not enough to make transaction.", notification.AlertType.error);
                notification.ShowDialog();
                return;
            }

            StringBuilder whereTransUpdate = new StringBuilder();
            StringBuilder paramTransUpdate = new StringBuilder();            
            StringBuilder valuesTransUpdate = new StringBuilder();       

            foreach ( ListViewItem lvi in transPage.lvCart.Items )
            {                
                StringBuilder whereRes = new StringBuilder();
                StringBuilder whereDel = new StringBuilder();

                whereRes.Append("gc_item_code='" + lvi.SubItems[1].Text + "' AND gc_unique_id='" + transID + "'");
                int result = db.searchData("transact", null, whereRes);
                if (result == 0)
                {
                    StringBuilder values = new StringBuilder();

                    StringBuilder paramUpdate = new StringBuilder();
                    StringBuilder valuesUpdate = new StringBuilder();
                    StringBuilder whereUpdate = new StringBuilder();

                    values.Append(
                        "Sales," +
                        "out," +
                        lvi.SubItems[2].Text + "," +
                        itemQty + "," +
                        DateTime.Now.ToString("MM/dd/yyyy") + "," +
                        transID + "," +
                        lvi.SubItems[1].Text + "," +
                        transPage.txtCustomerName.Text + "," +
                        transPage.txtAddress.Text + "," +
                        lvi.SubItems[5].Text + "," +
                        lvi.SubItems[6].Text + "," +
                        lvi.Text + "," +
                        float.Parse(lvi.SubItems[3].Text) * float.Parse(lvi.SubItems[2].Text) + "," +
                        float.Parse(lvi.SubItems[4].Text) + "," +
                        float.Parse(lvi.SubItems[3].Text) + "," +
                        float.Parse(transPage.txtCash.Text) + "," +
                        (float.Parse(transPage.txtCash.Text) - totalPrice) + "," +
                        float.Parse(lvi.SubItems[4].Text) * float.Parse(lvi.SubItems[2].Text)
                    );

                    paramUpdate.Append("gc_item_qty");
                    valuesUpdate.Append(int.Parse(lvi.SubItems[7].Text) - int.Parse(lvi.SubItems[2].Text));
                    whereUpdate.Append("gc_item_code='" + lvi.SubItems[1].Text + "'");

                    db.GCUpdateDb("stock", paramUpdate, valuesUpdate, whereUpdate);
                    transaction.insertToTrans(values);
                }
                
                whereDel.Append("gc_unique_id='" + transID + "'");
                DataTable dt = db.GCSelectFromDb("transact", null, whereDel);
                foreach (DataRow row in dt.Rows)
                {                
                    var resItem = transPage.lvCart.FindItemWithText(row[7].ToString(), true, 0);
                    if (resItem == null)
                    {
                        StringBuilder whereDelItem = new StringBuilder();
                        StringBuilder valueDelItem = new StringBuilder();

                        StringBuilder paramStockUpdate = new StringBuilder();
                        StringBuilder valuesStockUpdate = new StringBuilder();
                        StringBuilder whereStockUpdate = new StringBuilder();

                        StringBuilder paramStock = new StringBuilder();
                        StringBuilder whereStock = new StringBuilder();

                        paramStock.Append("gc_item_qty");
                        whereStock.Append("gc_item_code='"+row[7].ToString()+"'");
                        DataTable dtQty = db.GCSelectFromDb("stock",paramStock,whereStock);

                        foreach ( DataRow dtQtyRow in dtQty.Rows )
                        {
                            currStockQty = int.Parse(dtQtyRow[0].ToString());
                        }

                        whereDelItem.Append("gc_item_code,gc_unique_id");
                        valueDelItem.Append(row[7].ToString() + "," + row[6].ToString());
                        db.GCDeleteFromDb("transact", valueDelItem, whereDelItem);

                        paramStockUpdate.Append("gc_item_qty");
                        whereStockUpdate.Append("gc_item_code='"+row[7].ToString()+"'");
                        valuesStockUpdate.Append(currStockQty + int.Parse(row[3].ToString()));
                        db.GCUpdateDb("stock",paramStockUpdate,valuesStockUpdate,whereStockUpdate);
                        
                        DataTable dtStock = db.GCSelectFromDb("stock", null, null);
                        transPage.dgStock.DataSource = null;
                        transPage.dgStock.DataSource = dtStock;

                    }
                    else if (resItem != null)
                    {
                        StringBuilder wheretSelStock = new StringBuilder();
                        StringBuilder paramSelStock = new StringBuilder();

                        paramSelStock.Append("gc_item_qty");
                        wheretSelStock.Append("gc_item_code='" + lvi.SubItems[1].Text + "' AND gc_unique_id='"+transID+"'");
                        DataTable dtSelectStock = db.GCSelectFromDb("transact", paramSelStock, wheretSelStock);

                        foreach ( DataRow rowQty in dtSelectStock.Rows )
                        {
                            StringBuilder paramUpdateStock = new StringBuilder();
                            StringBuilder whereUpdateStock = new StringBuilder();
                            StringBuilder valuesUpdateStock = new StringBuilder();

                            StringBuilder whereSelItem = new StringBuilder();
                            StringBuilder paramSelItem = new StringBuilder();

                            paramSelItem.Append("gc_item_qty");
                            whereSelItem.Append("gc_item_code='"+lvi.SubItems[1].Text+"'");

                            DataTable dtSelItem = db.GCSelectFromDb("stock",paramSelItem,whereSelItem);

                            foreach ( DataRow rowSelItem in dtSelItem.Rows )
                            {
                                currStock = int.Parse(rowSelItem[0].ToString());
                            }

                            paramUpdateStock.Append("gc_item_qty");
                            whereUpdateStock.Append("gc_item_code='" + lvi.SubItems[1].Text + "'");

                            if ( int.Parse(rowQty[0].ToString()) < int.Parse(lvi.SubItems[2].Text)  )
                            {
                                addedQty = int.Parse(lvi.SubItems[2].Text) - int.Parse(rowQty[0].ToString());
                                valuesUpdateStock.Append(currStock - addedQty);
                                db.GCUpdateDb("stock", paramUpdateStock, valuesUpdateStock, whereUpdateStock);
                            }
                            else if (int.Parse(rowQty[0].ToString()) > int.Parse(lvi.SubItems[2].Text))
                            {
                                addedQty = int.Parse(rowQty[0].ToString()) - int.Parse(lvi.SubItems[2].Text);
                                valuesUpdateStock.Append(currStock + addedQty);
                                db.GCUpdateDb("stock", paramUpdateStock, valuesUpdateStock, whereUpdateStock);
                            }                            
                            
                        }

                        whereTransUpdate.Append(
                            "gc_from_tbl='sales' " +
                            "AND gc_unique_id='" + transID + "' " +
                            "AND gc_item_code='" + lvi.SubItems[1].Text + "'"
                        );

                        paramTransUpdate.Append(
                            "gc_item_qty," +
                            "gc_total_price," +
                            "gc_item_cost," +
                            "gc_cust_cash," +
                            "gc_cust_change," +
                            "gc_trans_date," +
                            "gc_cost_total"
                        );

                        valuesTransUpdate.Append(
                            lvi.SubItems[2].Text + "," +
                            (float.Parse(lvi.SubItems[3].Text) * float.Parse(lvi.SubItems[2].Text)) + "," +
                            float.Parse(lvi.SubItems[4].Text) + "," +
                            float.Parse(transPage.txtCash.Text) + "," +
                            (float.Parse(transPage.txtCash.Text) - float.Parse(transPage.lblTotal.Text)) + "," +
                            DateTime.Now.ToString("MM/dd/yyyy") + "," +
                            float.Parse(lvi.SubItems[2].Text) * float.Parse(lvi.SubItems[4].Text)
                        );

                        try
                        {
                            transaction.GCUpdateDb("transact", paramTransUpdate, valuesTransUpdate, whereTransUpdate);
                            DataTable dtStock = db.GCSelectFromDb("stock", null, null);
                            transPage.dgStock.DataSource = null;
                            transPage.dgStock.DataSource = dtStock;
                            notification = new notification("Transaction has been updated.", notification.AlertType.success);
                            notification.Show();
                        }
                        catch (Exception a)
                        {
                            notification = new notification("Transaction error. Please check fields.", notification.AlertType.error);
                            MessageBox.Show(a.Message);
                            notification.Show();
                        }
                    }
                }
            }
            transPage.dgStock.DataSource = null;
            DataTable dtTransHist = db.GCSelectFromDb("stock", null, null);
            transPage.dgStock.DataSource = dtTransHist;
            transPage.btnSaveTrans.Click -= BtnSaveTrans_Click;
        }
    }
}
