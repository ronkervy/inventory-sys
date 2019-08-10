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
    public partial class Delivery : Form
    {
        dbGc db = new dbGc();
        view view = new view();
        GcDelivery delivery = new GcDelivery();
        DeliveryInfo deliveryInfoPage = new DeliveryInfo();
        GcTransaction transaction = new GcTransaction();
        notification notification;

        public string itemName, itemSupp, itemBrand;
        public int qty, orderTerms,currInventory;
        public float itemPrice;
        DateTime dtDelivery;

        public Delivery()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void Delivery_Load(object sender, EventArgs e)
        {            
            DataTable dt = db.GCSelectFromDb("delivery",null,null,"ORDER BY id DESC");
            dgDelivery.DataSource = dt;

            StringBuilder param = new StringBuilder();
            param.Append("DISTINCT gc_item_name");

            DataTable dtRes = db.GCSelectFromDb("inventory",param,null);
            foreach (DataRow row in dtRes.Rows)
            {
                txtItemName.Items.Add(row[0].ToString());
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            StringBuilder whereSearch = new StringBuilder();
            if (chkItemName.CheckState == CheckState.Checked)
            {
                whereSearch.Append("gc_item_name LIKE '%"+txtSearch.Text+"%'");
            }else if (chkItemCode.CheckState == CheckState.Checked)
            {
                whereSearch.Append("gc_item_code LIKE '%" + txtSearch.Text + "%'");
            }
            else
            {
                whereSearch.Append("gc_item_name LIKE '%" + txtSearch.Text + "%'");
            }
            DataTable dtSearchRes = db.GCSelectFromDb("delivery",null,whereSearch,"ORDER bY id DESC");
            dgDelivery.DataSource = null;
            dgDelivery.DataSource = dtSearchRes;
        }

        private void txtItemPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            view.chkNum(txtItemPrice,e);
        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            view.chkNum(txtQty, e);
        }

        private void txtOrderTerms_KeyPress(object sender, KeyPressEventArgs e)
        {
            view.chkNum(txtOrderTerms, e);
        }

        private void btnAddDeliver_Click(object sender, EventArgs e)
        {
            try
            {
                if ( txtItemName.Text != "" )
                {
                    StringBuilder param = new StringBuilder();
                    StringBuilder values = new StringBuilder();
                    param.Append(
                        "gc_item_name," +
                        "gc_item_supp," +
                        "gc_item_brand," +
                        "gc_item_status," +
                        "gc_order_terms," +
                        "gc_delivery_date," +
                        "gc_item_cost," +
                        "gc_total_price," +
                        "gc_item_qty"
                    );

                    values.Append(
                        txtItemName.Text + "," +
                        cmbSupp.Text + "," +
                        txtBrand.Text + "," +
                        "not delivered" + "," +
                        int.Parse(txtOrderTerms.Text) + "," +
                        dtDeliveryDate.Value.ToShortDateString() + "," +
                        float.Parse(txtItemPrice.Text) + "," +
                        int.Parse(txtQty.Text) * float.Parse(txtItemPrice.Text) + "," +
                        int.Parse(txtQty.Text)
                    );
                    delivery.saveDelivery(param, values);
                    dgDelivery.DataSource = null;
                    DataTable dt = db.GCSelectFromDb("delivery", null, null);
                    dgDelivery.DataSource = dt;

                    notification = new notification("Delivery of items is saved.", notification.AlertType.success);
                    notification.ShowDialog();

                }
                else
                {
                    notification = new notification("Error. Check fields before saving.", notification.AlertType.error);
                    notification.ShowDialog();
                }
            }
            catch (Exception a)
            {
                notification = new notification("Error. Check fields before saving.", notification.AlertType.error);
                notification.ShowDialog();
            }

        }

        private void txtItemName_TextChanged(object sender, EventArgs e)
        {
            cmbSupp.Text = "";
            cmbSupp.Items.Clear();
            StringBuilder whereItemName = new StringBuilder();
            StringBuilder paramSupp = new StringBuilder();

            paramSupp.Append("DISTINCT gc_item_supp");
            whereItemName.Append("gc_item_name='"+txtItemName.Text+"'");

            DataTable dt = db.GCSelectFromDb("products", paramSupp, whereItemName);
            foreach (DataRow row in dt.Rows)
            {
                cmbSupp.Items.Add(row[0].ToString());
            }
        }

        private void cmbSupp_TextChanged(object sender, EventArgs e)
        {
            txtBrand.Text = "";
            txtBrand.Items.Clear();
            StringBuilder whereItemNameBrand = new StringBuilder();
            StringBuilder paramBrand = new StringBuilder();

            paramBrand.Append("gc_item_brand");
            whereItemNameBrand.Append("gc_item_name='" + txtItemName.Text + "' AND gc_item_supp='"+cmbSupp.Text+"'");

            DataTable dt = db.GCSelectFromDb("products", paramBrand, whereItemNameBrand);
            foreach (DataRow row in dt.Rows)
            {
                txtBrand.Items.Add(row[0].ToString());
            }
        }

        private void dgDelivery_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach ( DataGridViewRow row in dgDelivery.Rows )
            {
                row.Cells[6].Style.ForeColor = Color.White;
                if ( row.Cells[0].Value != null )
                {
                    if ( row.Cells[6].Value.ToString() == "Delivered" )
                    {
                        row.Cells[6].Style.BackColor = Color.SeaGreen;                        
                    }
                    else
                    {
                        row.Cells[6].Style.BackColor = Color.Maroon;
                    }
                }
            }
        }

        private void dgDelivery_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (e.ColumnIndex == 0)
            {
                try
                {
                    StringBuilder whereItem = new StringBuilder();

                    whereItem.Append(
                        "gc_item_name='" + senderGrid.Rows[e.RowIndex].Cells[1].Value.ToString() + "' " +
                        "AND gc_item_supp='" + senderGrid.Rows[e.RowIndex].Cells[3].Value.ToString() + "' " +
                        "AND gc_item_brand='" + senderGrid.Rows[e.RowIndex].Cells[4].Value.ToString() + "'"
                    );

                    int resItem = db.searchData("products", null, whereItem);

                    if ( resItem == 1 )
                    {
                        StringBuilder paramItemSelected = new StringBuilder();
                        StringBuilder whereItemSelected = new StringBuilder();

                        paramItemSelected.Append(
                            "gc_item_name," +
                            "gc_item_code," +
                            "gc_item_um," +
                            "gc_item_desc," +
                            "gc_item_supp," +
                            "gc_item_brand," +
                            "gc_item_cost," +
                            "gc_item_srp," +
                            "gc_item_type," +
                            "gc_item_status"
                        );

                        whereItemSelected.Append(
                            "gc_item_name='" + senderGrid.Rows[e.RowIndex].Cells[1].Value.ToString() + "' " +
                            "AND gc_item_supp='" + senderGrid.Rows[e.RowIndex].Cells[3].Value.ToString() + "' " +
                            "AND gc_item_brand='" + senderGrid.Rows[e.RowIndex].Cells[4].Value.ToString() + "'"
                        );

                        DataTable dt = db.GCSelectFromDb("products", paramItemSelected, whereItemSelected);
                        
                        foreach (DataRow row in dt.Rows)
                        {
                            deliveryInfoPage.txtItemName.Text = row[0].ToString();
                            deliveryInfoPage.txtItemCode.Text = row[1].ToString();
                            deliveryInfoPage.txtUm.Text = row[2].ToString();
                            deliveryInfoPage.txtDesc.Text = row[3].ToString();
                            deliveryInfoPage.cmbSupp.Text = row[4].ToString();
                            deliveryInfoPage.txtBrand.Text = row[5].ToString();
                            deliveryInfoPage.txtCost.Text = row[6].ToString();
                            deliveryInfoPage.txtSrp.Text = row[7].ToString();
                            deliveryInfoPage.cmbItemType.Text = row[8].ToString();
                            deliveryInfoPage.cmbItemStatus.Text = row[9].ToString();
                            deliveryInfoPage.orderTerms = int.Parse(senderGrid.Rows[e.RowIndex].Cells[7].Value.ToString());
                            deliveryInfoPage.dtDeliveryDate.Value = DateTime.Parse(senderGrid.Rows[e.RowIndex].Cells[8].Value.ToString());

                            deliveryInfoPage.itemName = row[0].ToString();
                            deliveryInfoPage.itemSupp = row[4].ToString();
                            deliveryInfoPage.itemBrand = row[5].ToString();
                        }
                        deliveryInfoPage.txtQty.Text = senderGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
                        deliveryInfoPage.btnMove.Click += BtnMove_Click;
                        deliveryInfoPage.btnDelete.Click += BtnDelete_Click;
                        deliveryInfoPage.btnSave.Click += BtnSave_Click;

                        deliveryInfoPage.ShowDialog();
                    }
                    else
                    {
                        deliveryInfoPage.txtItemName.Text = senderGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                        deliveryInfoPage.txtQty.Text = senderGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
                        deliveryInfoPage.cmbSupp.Text = senderGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
                        deliveryInfoPage.txtBrand.Text = senderGrid.Rows[e.RowIndex].Cells[4].Value.ToString();
                        deliveryInfoPage.txtCost.Text = senderGrid.Rows[e.RowIndex].Cells[5].Value.ToString();
                        deliveryInfoPage.cmbItemStatus.Text = senderGrid.Rows[e.RowIndex].Cells[6].Value.ToString();
                        deliveryInfoPage.orderTerms = int.Parse(senderGrid.Rows[e.RowIndex].Cells[7].Value.ToString());
                        deliveryInfoPage.dtDeliveryDate.Value = DateTime.Parse(senderGrid.Rows[e.RowIndex].Cells[8].Value.ToString());
                        deliveryInfoPage.txtItemCode.Text = senderGrid.Rows[e.RowIndex].Cells[9].Value.ToString();
                        deliveryInfoPage.cmbItemType.Text = senderGrid.Rows[e.RowIndex].Cells[10].Value.ToString();
                        deliveryInfoPage.txtSrp.Text = senderGrid.Rows[e.RowIndex].Cells[11].Value.ToString();
                        deliveryInfoPage.txtDesc.Text = senderGrid.Rows[e.RowIndex].Cells[12].Value.ToString();
                        deliveryInfoPage.txtUm.Text = senderGrid.Rows[e.RowIndex].Cells[13].Value.ToString();

                        deliveryInfoPage.itemName = senderGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                        deliveryInfoPage.itemSupp = senderGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
                        deliveryInfoPage.itemBrand = senderGrid.Rows[e.RowIndex].Cells[4].Value.ToString();

                        deliveryInfoPage.btnMove.Click += BtnMove_Click;
                        deliveryInfoPage.btnDelete.Click += BtnDelete_Click;
                        deliveryInfoPage.btnSave.Click += BtnSave_Click;

                        deliveryInfoPage.ShowDialog();
                    }
                }
                catch (Exception a)
                {
                    return;
                }
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            StringBuilder param = new StringBuilder();
            StringBuilder values = new StringBuilder();
            StringBuilder where = new StringBuilder();

            param.Append(
                "gc_item_name," +
                "gc_item_supp," +
                "gc_item_brand," +
                "gc_item_status," +
                "gc_delivery_date," +
                "gc_item_cost," +
                "gc_item_srp," +
                "gc_item_qty," +
                "gc_item_code," +
                "gc_item_type," +
                "gc_item_desc," +
                "gc_item_um"
            );

            values.Append(
                deliveryInfoPage.txtItemName.Text + "," +
                deliveryInfoPage.cmbSupp.Text + "," +
                deliveryInfoPage.txtBrand.Text + "," +
                deliveryInfoPage.cmbItemStatus.Text + "," +
                deliveryInfoPage.dtDeliveryDate.Value + "," +
                float.Parse(deliveryInfoPage.txtCost.Text) + "," +
                float.Parse(deliveryInfoPage.txtSrp.Text) + "," +
                int.Parse(deliveryInfoPage.txtQty.Text) + "," +
                deliveryInfoPage.txtItemCode.Text + "," +
                deliveryInfoPage.cmbItemType.Text + "," +
                deliveryInfoPage.txtDesc.Text + "," +
                deliveryInfoPage.txtUm.Text
            );

            where.Append("gc_item_name='"+ deliveryInfoPage.itemName + "'");
            //where.Append("gc_item_brand='"+deliveryInfoPage.itemBrand+"'");
            //where.Append("gc_item_supp='"+deliveryInfoPage.itemSupp+"'");

            db.GCUpdateDb("delivery",param,values,where);

            DataTable dt = db.GCSelectFromDb("delivery", null, null);
            dgDelivery.DataSource = null;
            dgDelivery.DataSource = dt;

            notification = new notification("Changes has been saved.", notification.AlertType.success);
            notification.ShowDialog();

            deliveryInfoPage.Close();

            deliveryInfoPage.btnSave.Click -= BtnSave_Click;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            StringBuilder where = new StringBuilder();
            StringBuilder value = new StringBuilder();

            DialogResult dialog = MessageBox.Show("Are you sure you want to delete this item?", "Delete Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if ( dialog == DialogResult.Yes )
            {
                where.Append("gc_item_name,gc_item_brand,gc_item_supp");
                value.Append(
                    deliveryInfoPage.itemName + "," + 
                    deliveryInfoPage.itemBrand + "," + 
                    deliveryInfoPage.itemSupp
                );

                db.GCDeleteFromDb("delivery", value, where);

                DataTable dt = db.GCSelectFromDb("delivery", null, null);
                dgDelivery.DataSource = null;
                dgDelivery.DataSource = dt;

                string randID = view.Random("ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789", 5);
                StringBuilder valuesTransDel = new StringBuilder();

                valuesTransDel.Append(
                    "delivery,"+
                    "delivered,"+
                    int.Parse(deliveryInfoPage.txtQty.Text) +","+
                    int.Parse(deliveryInfoPage.txtQty.Text) + "," +
                    DateTime.Now.ToString("MM/dd/yyyy") + "," +
                    randID + DateTime.Now.Millisecond.ToString() + "," +
                    deliveryInfoPage.txtItemCode.Text + "," +
                    "none" + "," +
                    "none" + "," +
                    deliveryInfoPage.txtUm.Text + "," +
                    deliveryInfoPage.txtDesc.Text + "," +
                    deliveryInfoPage.txtItemName.Text + "," +
                    float.Parse(deliveryInfoPage.txtQty.Text) * float.Parse(deliveryInfoPage.txtCost.Text) + "," +
                    float.Parse(deliveryInfoPage.txtCost.Text) + "," +
                    float.Parse(deliveryInfoPage.txtSrp.Text) + "," +
                    0 + "," +
                    0
                );

                transaction.insertToTrans(valuesTransDel);
                deliveryInfoPage.btnDelete.Click -= BtnDelete_Click;
            }
            deliveryInfoPage.btnDelete.Click -= BtnDelete_Click;
            deliveryInfoPage.Close();
        }

        private void BtnMove_Click(object sender, EventArgs e)
        {
            StringBuilder param = new StringBuilder();
            StringBuilder values = new StringBuilder();
            StringBuilder whereSave = new StringBuilder();
            StringBuilder whereSearch = new StringBuilder();

            StringBuilder paramInv = new StringBuilder();
            StringBuilder whereInv = new StringBuilder();

            StringBuilder valuesUpdate = new StringBuilder();
            StringBuilder paramUpdate = new StringBuilder();
            StringBuilder whereUpdate = new StringBuilder();

            StringBuilder whereDelivUpdateStat = new StringBuilder();
            StringBuilder paramDelivUpdateStat = new StringBuilder();
            StringBuilder valuesDelivUpdateStat = new StringBuilder();

            //StringBuilder whereDelete = new StringBuilder();
            //StringBuilder valueDelete = new StringBuilder();

            DialogResult dialogMove = MessageBox.Show("Are you sure you want to move item to inventory?", "Move Item to inventory", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogMove == DialogResult.Yes && deliveryInfoPage.txtItemCode.Text != "")
            {
                whereSave.Append("gc_item_code='" + deliveryInfoPage.txtItemCode.Text + "'");
                int invRes = db.searchData("inventory", null, whereSave);
                if ( invRes >= 1 )
                {
                    try
                    {
                        paramInv.Append("gc_item_qty");
                        whereInv.Append("gc_item_name='"+ deliveryInfoPage.itemName + "'");
                        whereInv.Append(" AND gc_item_supp='"+ deliveryInfoPage.itemSupp + "'");
                        whereInv.Append(" AND gc_item_brand='"+ deliveryInfoPage.itemBrand + "'");

                        DataTable dt = db.GCSelectFromDb("inventory", paramInv, whereInv);
                        foreach (DataRow row in dt.Rows)
                        {
                            currInventory = int.Parse(row[0].ToString());
                        }

                        paramUpdate.Append("gc_item_qty");
                        valuesUpdate.Append(currInventory + int.Parse(deliveryInfoPage.txtQty.Text));

                        whereUpdate.Append("gc_item_name='" + deliveryInfoPage.itemName + "'");
                        whereUpdate.Append(" AND gc_item_brand='" + deliveryInfoPage.itemBrand + "'");
                        whereUpdate.Append(" AND gc_item_supp='" + deliveryInfoPage.itemSupp + "'");

                        whereDelivUpdateStat.Append("gc_item_name='" + deliveryInfoPage.itemName + "'");
                        whereDelivUpdateStat.Append(" AND gc_item_supp='" + deliveryInfoPage.itemSupp + "'");
                        whereDelivUpdateStat.Append(" AND gc_item_brand='" + deliveryInfoPage.itemBrand + "'");
                        paramDelivUpdateStat.Append("gc_item_status");
                        valuesDelivUpdateStat.Append("Delivered");
                        //whereDelete.Append("gc_item_name,gc_item_brand,gc_item_supp");
                        //valueDelete.Append(deliveryInfoPage.itemName + "," + deliveryInfoPage.itemBrand + "," + deliveryInfoPage.itemSupp);

                        db.GCUpdateDb("delivery",paramDelivUpdateStat,valuesDelivUpdateStat,whereDelivUpdateStat);
                        db.GCUpdateDb("inventory", paramUpdate, valuesUpdate, whereUpdate);
                        //db.GCDeleteFromDb("delivery", valueDelete, whereDelete);

                        string randID = view.Random("ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789", 5);
                        StringBuilder valuesTransMove = new StringBuilder();

                        valuesTransMove.Append(
                            "inventory," +
                            "in," +
                            int.Parse(deliveryInfoPage.txtQty.Text) + "," +
                            int.Parse(deliveryInfoPage.txtQty.Text) + "," +
                            DateTime.Now.ToShortDateString() + "," +
                            randID + DateTime.Now.Millisecond.ToString() + "," +
                            deliveryInfoPage.txtItemCode.Text + "," +
                            "none" + "," +
                            "none" + "," +
                            deliveryInfoPage.txtUm.Text + "," +
                            deliveryInfoPage.txtDesc.Text + "," +
                            deliveryInfoPage.txtItemName.Text + "," +
                            float.Parse(deliveryInfoPage.txtQty.Text) * float.Parse(deliveryInfoPage.txtCost.Text) + "," +
                            float.Parse(deliveryInfoPage.txtCost.Text) + "," +
                            float.Parse(deliveryInfoPage.txtSrp.Text) + "," +
                            0 + "," +
                            0 + "," +
                            0
                        );

                        transaction.insertToTrans(valuesTransMove);

                        foreach (Control ctrl in deliveryInfoPage.Controls)
                        {
                            if (ctrl.GetType() == typeof(TextBox))
                            {
                                ctrl.Text = "";
                            }
                        }

                        DataTable dtDelivery = db.GCSelectFromDb("delivery", null, null);
                        dgDelivery.DataSource = null;
                        dgDelivery.DataSource = dtDelivery;
                    }
                    catch (Exception a)
                    {
                        MessageBox.Show(a.Message);
                    }
                }
                else
                {
                    try
                    {
                        //StringBuilder whereDeleteDelivery = new StringBuilder();
                        //StringBuilder valueDeleteDelivery = new StringBuilder();
                        StringBuilder whereDelivUpdate = new StringBuilder();
                        StringBuilder paramDelivUpdate = new StringBuilder();
                        StringBuilder valuesDelivUpdate = new StringBuilder();

                        StringBuilder paramSave = new StringBuilder();
                        StringBuilder valueSave = new StringBuilder();

                        paramSave.Append(
                            "gc_item_name," +
                            "gc_item_supp," +
                            "gc_item_brand," +
                            "gc_item_status," +
                            "gc_item_cost," +
                            "gc_item_srp," +
                            "gc_item_qty," +
                            "gc_item_code," +
                            "gc_item_type," +
                            "gc_item_desc," +
                            "gc_item_um"
                        );

                        valueSave.Append(
                            deliveryInfoPage.txtItemName.Text + "," +
                            deliveryInfoPage.cmbSupp.Text + "," +
                            deliveryInfoPage.txtBrand.Text + "," +
                            deliveryInfoPage.cmbItemStatus.Text + "," +
                            float.Parse(deliveryInfoPage.txtCost.Text) + "," +
                            float.Parse(deliveryInfoPage.txtSrp.Text) + "," +
                            int.Parse(deliveryInfoPage.txtQty.Text) + "," +
                            deliveryInfoPage.txtItemCode.Text + "," +
                            deliveryInfoPage.cmbItemType.Text + "," +
                            deliveryInfoPage.txtDesc.Text + "," +
                            deliveryInfoPage.txtUm.Text
                        );

                        db.GCInsertToDb("inventory", paramSave, valueSave);


                        string randIDDel = view.Random("ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789", 5);
                        StringBuilder valuesTransMoveDel = new StringBuilder();

                        valuesTransMoveDel.Append(
                            "delivery," +
                            "moved to inventory," +
                            int.Parse(deliveryInfoPage.txtQty.Text) + "," +
                            int.Parse(deliveryInfoPage.txtQty.Text) + "," +
                            DateTime.Now.ToShortDateString() + "," +
                            randIDDel + DateTime.Now.Millisecond.ToString() + "," +
                            deliveryInfoPage.txtItemCode.Text + "," +
                            "none" + "," +
                            "none" + "," +
                            deliveryInfoPage.txtUm.Text + "," +
                            deliveryInfoPage.txtDesc.Text + "," +
                            deliveryInfoPage.txtItemName.Text + "," +
                            float.Parse(deliveryInfoPage.txtQty.Text) * float.Parse(deliveryInfoPage.txtCost.Text) + "," +
                            float.Parse(deliveryInfoPage.txtCost.Text) + "," +
                            float.Parse(deliveryInfoPage.txtSrp.Text) + "," +
                            0 + "," +
                            0 + "," +
                            0
                        );

                        string randID = view.Random("ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789", 5);
                        StringBuilder valuesTransMove = new StringBuilder();

                        valuesTransMove.Append(
                            "inventory," +
                            "in," +
                            int.Parse(deliveryInfoPage.txtQty.Text) + "," +
                            int.Parse(deliveryInfoPage.txtQty.Text) + "," +
                            DateTime.Now.ToShortDateString() + "," +
                            randID + DateTime.Now.Millisecond.ToString() + "," +
                            deliveryInfoPage.txtItemCode.Text + "," +
                            "none" + "," +
                            "none" + "," +
                            deliveryInfoPage.txtUm.Text + "," +
                            deliveryInfoPage.txtDesc.Text + "," +
                            deliveryInfoPage.txtItemName.Text + "," +
                            float.Parse(deliveryInfoPage.txtQty.Text) * float.Parse(deliveryInfoPage.txtCost.Text) + "," +
                            float.Parse(deliveryInfoPage.txtCost.Text) + "," +
                            float.Parse(deliveryInfoPage.txtSrp.Text) + "," +
                            0 + "," +
                            0 + "," +
                            0
                        );

                        transaction.insertToTrans(valuesTransMove);
                        transaction.insertToTrans(valuesTransMoveDel);

                        foreach (Control ctrl in deliveryInfoPage.Controls)
                        {
                            if (ctrl.GetType() == typeof(TextBox))
                            {
                                ctrl.Text = "";
                            }
                        }

                        whereDelivUpdateStat.Append("gc_item_name='" + deliveryInfoPage.itemName + "'");
                        whereDelivUpdateStat.Append(" AND gc_item_supp='" + deliveryInfoPage.itemSupp + "'");
                        whereDelivUpdateStat.Append(" AND gc_item_brand='" + deliveryInfoPage.itemBrand + "'");
                        paramDelivUpdateStat.Append("gc_item_status");
                        valuesDelivUpdateStat.Append("Delivered");

                        db.GCUpdateDb("delivery", paramDelivUpdateStat, valuesDelivUpdateStat, whereDelivUpdateStat);

                        //whereDeleteDelivery.Append("gc_item_name,gc_item_supp,gc_item_brand");
                        /*valueDeleteDelivery.Append(
                            deliveryInfoPage.itemName + "," +
                            deliveryInfoPage.itemSupp + "," +
                            deliveryInfoPage.itemBrand
                        );*/

                        //db.GCDeleteFromDb("delivery", valueDeleteDelivery, whereDeleteDelivery);

                        DataTable dtDelivery = db.GCSelectFromDb("delivery", null, null);
                        dgDelivery.DataSource = null;
                        dgDelivery.DataSource = dtDelivery;
                    }
                    catch (Exception a)
                    {
                        MessageBox.Show(a.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please check if all fields have value. Before moving to inventory please put an Item code.", "Some fields are not valid.", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

            deliveryInfoPage.btnMove.Click -= BtnMove_Click;
            deliveryInfoPage.Close();
        }
    }
}
