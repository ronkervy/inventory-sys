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
using System.Resources;
using System.Media;

namespace Inventory_System.forms
{
    public partial class Transaction : Form
    {
        dbGc db = new dbGc();
        salesQty salesQtyPage = new salesQty();
        delQty delQtyPage = new delQty();
        GcTransaction transaction = new GcTransaction();
        receipt receiptPage = new receipt();
        view view = new view();
        notification notification;
        public bool SaveMode = true;

        public string itemName, itemCode,itemUm,itemDesc;
        public int itemQty;
        public float itemPrice,totalPrice,itemCost;        

        public Transaction()
        {
            InitializeComponent();
            DataTable dt = db.GCSelectFromDb("stock",null,null);
            dgStock.DataSource = dt;
            lvCart.Columns.Add("Item Name");
            lvCart.Columns.Add("Item Code");
            lvCart.Columns.Add("Quantity");
            lvCart.Columns.Add("Price");
            lvCart.Columns.Add("Cost");
            lvCart.Columns.Add("U/M");
            lvCart.Columns.Add("Description");
            lvCart.Columns.Add("Current Quantity");

            lvCart.Columns[0].Width = 120;
            lvCart.Columns[1].Width = 120;
            lvCart.Columns[2].Width = 70;
            lvCart.Columns[3].Width = 70;
            lvCart.Columns[4].Width = 70;

            lvCart.Columns[6].Width = 120;
            lvCart.Columns[7].Width = 90;
        }

        private void Transaction_Load(object sender, EventArgs e)
        {
            DataTable dt = db.GCSelectFromDb("stock",null,null,"ORDER BY gc_item_code");
            dgStock.DataSource = dt;
        }

        private void dgStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView senderGrid = (DataGridView)sender;
            if (e.ColumnIndex == 0)
            {
                itemName = senderGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                itemQty = int.Parse(senderGrid.Rows[e.RowIndex].Cells[2].Value.ToString());
                itemDesc = senderGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
                itemUm = senderGrid.Rows[e.RowIndex].Cells[6].Value.ToString();
                itemCost = float.Parse(senderGrid.Rows[e.RowIndex].Cells[7].Value.ToString());
                itemPrice = float.Parse(senderGrid.Rows[e.RowIndex].Cells[8].Value.ToString());

                itemCode = senderGrid.Rows[e.RowIndex].Cells[10].Value.ToString();
                salesQtyPage.btnAddQty.Click += BtnAddQty_Click;
                salesQtyPage.ShowDialog();
            }
        }

        private void txtCash_KeyPress(object sender, KeyPressEventArgs e)
        {
            view.chkNum(txtCash,e);
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                StringBuilder whereSearch = new StringBuilder();

                if ( chkItemCode.Checked == true )
                {
                    whereSearch.Append("gc_item_code LIKE '%"+txtSearch.Text+"%'");
                }else if ( chkItemName.Checked == true )
                {
                    whereSearch.Append("gc_item_name LIKE '%" + txtSearch.Text + "%'");
                }else if ( chkBrand.Checked == true)
                {
                    whereSearch.Append("gc_item_brand LIKE '%" + txtSearch.Text + "%'");
                }else if ( chkSupplier.Checked == true)
                {
                    whereSearch.Append("gc_item_supp LIKE '%" + txtSearch.Text + "%'");
                }
                else
                {
                    whereSearch.Append("gc_item_supp LIKE '%" + txtSearch.Text + "%' OR gc_item_name LIKE '%" + txtSearch.Text + "%' OR gc_item_name LIKE '%" + txtSearch.Text + "%' OR gc_item_brand LIKE '%" + txtSearch.Text + "%'");
                }

                DataTable dt = db.GCSelectFromDb("stock",null,whereSearch);
                dgStock.DataSource = null;
                dgStock.DataSource = dt;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            StringBuilder whereSearch = new StringBuilder();

            if (chkItemCode.Checked == true)
            {
                whereSearch.Append("gc_item_code LIKE '%" + txtSearch.Text + "%'");
            }
            else if (chkItemName.Checked == true)
            {
                whereSearch.Append("gc_item_name LIKE '%" + txtSearch.Text + "%'");
            }
            else if (chkBrand.Checked == true)
            {
                whereSearch.Append("gc_item_brand LIKE '%" + txtSearch.Text + "%'");
            }
            else if (chkSupplier.Checked == true)
            {
                whereSearch.Append("gc_item_supp LIKE '%" + txtSearch.Text + "%'");
            }
            else
            {
                whereSearch.Append("gc_item_supp LIKE '%" + txtSearch.Text + "%' OR gc_item_name LIKE '%" + txtSearch.Text + "%' OR gc_item_name LIKE '%" + txtSearch.Text + "%' OR gc_item_brand LIKE '%" + txtSearch.Text + "%'");
            }

            DataTable dt = db.GCSelectFromDb("stock", null, whereSearch);
            dgStock.DataSource = null;
            dgStock.DataSource = dt;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in panel1.Controls)
            {
                if (ctrl.GetType() == typeof(TextBox) || ctrl.GetType() == typeof(RichTextBox))
                {
                    ctrl.Text = "";
                }
            }
        }

        private void lvCart_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ( e.KeyChar == Convert.ToChar(Keys.Delete) )
            {
                delQtyPage.btnDelQty.Click += BtnDelQty_Click;
                delQtyPage.ShowDialog();
            }
        }

        private void BtnDelQty_Click(object sender, EventArgs e)
        {
            if (int.Parse(lvCart.SelectedItems[0].SubItems[2].Text) >= int.Parse(delQtyPage.txtQty.Text) )
            {
                if (lvCart.Items.Count > 0)
                {                    
                    var resItem = lvCart.FindItemWithText(lvCart.SelectedItems[0].SubItems[1].Text, true, 0,false);
                    if (resItem != null && resItem.SubItems[1].Text == lvCart.SelectedItems[0].SubItems[1].Text)
                    {
                        int resTotal = int.Parse(resItem.SubItems[2].Text) - int.Parse(delQtyPage.txtQty.Text);
                        resItem.SubItems[2].Text = resTotal.ToString();
                        if (int.Parse(lvCart.SelectedItems[0].SubItems[2].Text) <= 0)
                        {
                            lvCart.SelectedItems[0].Remove();
                        }
                    }
                    else if( (int.Parse(lvCart.SelectedItems[0].SubItems[2].Text) - int.Parse(delQtyPage.txtQty.Text)) != 0 )
                    {
                        int resTotal = int.Parse(resItem.SubItems[2].Text) - int.Parse(delQtyPage.txtQty.Text);
                        resItem.SubItems[2].Text = resTotal.ToString();
                    }else
                    {
                        lvCart.SelectedItems[0].Remove();
                    }
                }
                else
                {
                    lvCart.SelectedItems[0].Remove();
                }

                totalPrice = 0;
                foreach (ListViewItem lvi in lvCart.Items)
                {                   
                    totalPrice += float.Parse(lvi.SubItems[2].Text) * float.Parse(lvi.SubItems[3].Text);
                }

                lblTotal.Text = totalPrice.ToString();
                delQtyPage.btnDelQty.Click -= BtnDelQty_Click;
                delQtyPage.Close();
            }
            else
            {
                MessageBox.Show("Invalid Quantity, not enough item on stock.", "Not enough item on stock", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                delQtyPage.btnDelQty.Click -= BtnDelQty_Click;
                return;
            }
            delQtyPage.btnDelQty.Click -= BtnDelQty_Click;
        }

        private void lvCart_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                delQtyPage.btnDelQty.Click += BtnDelQty_Click;
                delQtyPage.ShowDialog();
            }
        }

        private void BtnAddQty_Click(object sender, EventArgs e)
        {
            if (salesQtyPage.txtQty.Text != "")
            {
                if (itemQty >= int.Parse(salesQtyPage.txtQty.Text))
                {
                    string[] items = {
                    itemName,
                    itemCode,
                    salesQtyPage.txtQty.Text,
                    itemPrice.ToString(),
                    itemCost.ToString(),
                    itemUm,
                    itemDesc,
                    itemQty.ToString()
                };

                    ListViewItem strValues = new ListViewItem(items);
                    if (lvCart.Items.Count > 0)
                    {
                        var resItem = lvCart.FindItemWithText(itemCode, true, 0,false);
                        if (resItem != null && resItem.SubItems[1].Text == itemCode)
                        {
                            int resTotal = int.Parse(resItem.SubItems[2].Text) + int.Parse(salesQtyPage.txtQty.Text);
                            resItem.SubItems[2].Text = resTotal.ToString();
                        }
                        else
                        {
                            lvCart.Items.Add(strValues);
                        }
                    }
                    else
                    {
                        lvCart.Items.Add(strValues);
                    }

                    totalPrice = 0;
                    foreach (ListViewItem lvi in lvCart.Items)
                    {
                        totalPrice += float.Parse(lvi.SubItems[2].Text) * float.Parse(lvi.SubItems[3].Text);
                    }

                    lblTotal.Text = totalPrice.ToString();
                    salesQtyPage.btnAddQty.Click -= BtnAddQty_Click;
                    salesQtyPage.Close();
                }
                else
                {
                    MessageBox.Show("Invalid Quantity, not enough item on stock.", "Not enough item on stock", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                    salesQtyPage.btnAddQty.Click -= BtnAddQty_Click;
                    return;
                }
            }
            else
            {
                notification notification = new notification("Cannot insert blank value!", notification.AlertType.error);
                notification.Show();
                salesQtyPage.btnAddQty.Click -= BtnAddQty_Click;
            }        
        }

        private void btnSaveTrans_Click(object sender, EventArgs e)
        {
            if ( SaveMode == true )
            {
                if (txtCustomerName.Text == "" && txtAddress.Text == "")
                {
                    notification = new notification("Error saving. Check fields before saving.", notification.AlertType.error);
                    notification.Show();
                    return;
                }

                string randID = view.Random("ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789", 5);
                foreach (ListViewItem lvi in lvCart.Items)
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
                        DateTime.Today + "," +
                        randID + "," +
                        lvi.SubItems[1].Text + "," +
                        txtCustomerName.Text + "," +
                        txtAddress.Text + "," +
                        lvi.SubItems[5].Text + "," +
                        lvi.SubItems[6].Text + "," +
                        lvi.Text + "," +
                        float.Parse(lvi.SubItems[3].Text) * float.Parse(lvi.SubItems[2].Text) + "," +
                        float.Parse(lvi.SubItems[4].Text) + "," +
                        float.Parse(lvi.SubItems[3].Text) + "," +
                        float.Parse(txtCash.Text) + "," +
                        (float.Parse(txtCash.Text) - totalPrice) + "," +
                        float.Parse(lvi.SubItems[4].Text) * float.Parse(lvi.SubItems[2].Text)
                    );

                    paramUpdate.Append("gc_item_qty");
                    valuesUpdate.Append(int.Parse(lvi.SubItems[7].Text) - int.Parse(lvi.SubItems[2].Text));
                    whereUpdate.Append("gc_item_code='" + lvi.SubItems[1].Text + "'");

                    db.GCUpdateDb("stock", paramUpdate, valuesUpdate, whereUpdate);
                    transaction.insertToTrans(values);
                }

                dgStock.DataSource = null;
                DataTable dt = db.GCSelectFromDb("stock", null, null);
                dgStock.DataSource = dt;

                foreach (Control ctrl in panel1.Controls)
                {
                    if (ctrl.GetType() == typeof(TextBox))
                    {
                        ctrl.Text = "";
                    }
                }
                lvCart.Items.Clear();
                DialogResult drPrint = MessageBox.Show("Do you want to print this transaction?", "Print this transaction?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (drPrint == DialogResult.Yes)
                {
                    receiptPage.transID = randID;
                    receiptPage.ShowDialog();
                }
                else
                {
                    notification = new notification("Transaction has been saved.", notification.AlertType.success);
                    notification.Show();
                }
            }
        }
    }
}
