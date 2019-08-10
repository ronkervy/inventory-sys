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
    public partial class ProductList : Form
    {
        dbGc db = new dbGc();
        notification notification;
        editItem editItemPage = new editItem();
        view view = new view();
        Inventory_Main main;
        
        public ProductList()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void ProductList_Load(object sender, EventArgs e)
        {
            StringBuilder paramSupp = new StringBuilder();
            StringBuilder paramType = new StringBuilder();
            StringBuilder paramBrand = new StringBuilder();

            DataTable dt = db.GCSelectFromDb("products",null,null,"ORDER BY id DESC");
            dgProducts.DataSource = dt;
            cmbSupp.Items.Clear();
            cmbItemType.Items.Clear();

            paramSupp.Append("DISTINCT gc_supp_name");
            paramType.Append("DISTINCT gc_item_type");
            paramBrand.Append("DISTINCT gc_item_brand");
            DataTable dtSupp = db.GCSelectFromDb("suppliers",paramSupp,null);
            DataTable dtType = db.GCSelectFromDb("products",paramType,null);
            DataTable dtBrand = db.GCSelectFromDb("products",paramBrand,null);

            foreach ( DataRow typeRow in dtType.Rows )
            {
                cmbItemType.Items.Add(typeRow[0].ToString());
            }

            foreach ( DataRow row in dtSupp.Rows )
            {
                cmbSupp.Items.Add(row[0].ToString());
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            StringBuilder whereSearch = new  StringBuilder();
            StringBuilder whereSearchInv = new StringBuilder();
            StringBuilder whereSearchStock = new StringBuilder();
            main = new Inventory_Main();
            whereSearch.Append("gc_item_code='"+txtItemCode.Text+"'");
            whereSearchInv.Append("gc_item_code='" + txtItemCode.Text + "'");
            whereSearchStock.Append("gc_item_code='" + txtItemCode.Text + "'");
            int resInv = db.searchData("inventory", null, whereSearchInv);
            int resStock = db.searchData("stock", null, whereSearchStock);
            int resProd = db.searchData("products",null,whereSearch);

            if (resProd >= 1 || resInv >= 1 || resStock >= 1)
            {
                notification = new notification("Item Code is already existing.",notification.AlertType.error);
                notification.ShowDialog();
            }
            else if( txtItemName.Text != "" && txtItemCode.Text != "" )
            {
                try
                {
                    StringBuilder param = new StringBuilder();
                    StringBuilder paramInv = new StringBuilder();
                    StringBuilder values = new StringBuilder();
                    StringBuilder valuesInv = new StringBuilder();
                    StringBuilder whereInvSearch = new StringBuilder();

                    StringBuilder paramStock = new StringBuilder();
                    StringBuilder valuesStock = new StringBuilder();

                    param.Append(
                        "gc_item_name," +
                        "gc_item_code," +
                        "gc_item_brand," +
                        "gc_item_type," +
                        "gc_item_supp," +
                        "gc_item_um," +
                        "gc_item_cost," +
                        "gc_item_srp," +
                        "gc_item_desc," +
                        "gc_item_status"
                    );

                    values.Append(
                        txtItemName.Text + "," +
                        txtItemCode.Text + "," +
                        txtBrand.Text + "," +
                        cmbItemType.Text + "," +
                        cmbSupp.Text + "," +
                        txtUm.Text + "," +
                        float.Parse(txtCost.Text) + "," +
                        float.Parse(txtSrp.Text) + "," +
                        txtDesc.Text + "," +
                        cmbStatus.Text
                    );

                    paramInv.Append(
                        "gc_item_name," +
                        "gc_item_code," +
                        "gc_item_brand," +
                        "gc_item_type," +
                        "gc_item_supp," +
                        "gc_item_um," +
                        "gc_item_cost," +
                        "gc_item_srp," +
                        "gc_item_desc," +
                        "gc_item_status,"+
                        "gc_item_qty"
                    );

                    valuesInv.Append(
                        txtItemName.Text + "," +
                        txtItemCode.Text + "," +
                        txtBrand.Text + "," +
                        cmbItemType.Text + "," +
                        cmbSupp.Text + "," +
                        txtUm.Text + "," +
                        float.Parse(txtCost.Text) + "," +
                        float.Parse(txtSrp.Text) + "," +
                        txtDesc.Text + "," +
                        "registered," +
                        int.Parse(txtInvQty.Text)
                    );

                    whereInvSearch.Append("gc_item_code='" + txtItemCode.Text + "'");
                    int invSearch = db.searchData("inventory",null,whereInvSearch);
                    if (invSearch <= 0 )
                    {
                        db.GCInsertToDb("inventory", paramInv, valuesInv);
                    }

                    paramStock.Append(
                        "gc_item_name," +
                        "gc_item_code," +
                        "gc_item_brand," +
                        "gc_item_type," +
                        "gc_item_supp," +
                        "gc_item_um," +
                        "gc_item_cost," +
                        "gc_item_srp," +
                        "gc_item_desc," +
                        "gc_item_status," +
                        "gc_item_qty"
                    );

                    valuesStock.Append(
                        txtItemName.Text + "," +
                        txtItemCode.Text + "," +
                        txtBrand.Text + "," +
                        cmbItemType.Text + "," +
                        cmbSupp.Text + "," +
                        txtUm.Text + "," +
                        float.Parse(txtCost.Text) + "," +
                        float.Parse(txtSrp.Text) + "," +
                        txtDesc.Text + "," +
                        "registered," +
                        int.Parse(txtStockQty.Text)
                    );

                    db.GCInsertToDb("stock",paramStock,valuesStock);
                    db.GCInsertToDb("products", param, values);

                    DataTable dt = db.GCSelectFromDb("products", null, null,"ORDER BY id DESC");
                    dgProducts.DataSource = null;
                    dgProducts.DataSource = dt;



                    notification = new notification("Product saved to the database", notification.AlertType.success);
                    notification.ShowDialog();
                }
                catch (Exception a)
                {
                    notification = new notification("Please check the values on the fields. : ", notification.AlertType.error);
                    notification.ShowDialog();
                }
            }
            else
            {
                notification = new notification("Please check the values on the fields.", notification.AlertType.error);
                notification.ShowDialog();
            }
        }

        private void dgProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView senderGrid = (DataGridView)sender;
            if ( e.ColumnIndex == 10 )
            {
                editItemPage.itemCode = senderGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                editItemPage.txtItemName.Text = senderGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                editItemPage.txtItemCode.Text = senderGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                editItemPage.txtUm.Text = senderGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
                editItemPage.txtDesc.Text = senderGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
                editItemPage.cmbSupp.Text = senderGrid.Rows[e.RowIndex].Cells[4].Value.ToString();
                editItemPage.txtBrand.Text = senderGrid.Rows[e.RowIndex].Cells[5].Value.ToString();
                editItemPage.txtCost.Text = senderGrid.Rows[e.RowIndex].Cells[6].Value.ToString();
                editItemPage.txtSrp.Text = senderGrid.Rows[e.RowIndex].Cells[7].Value.ToString();
                editItemPage.cmbItemType.Text = senderGrid.Rows[e.RowIndex].Cells[8].Value.ToString();

                editItemPage.btnSave.Click += BtnSave_Click;

                editItemPage.ShowDialog();
            }
            else if(e.ColumnIndex == 11)
            {
                StringBuilder whereDelProd = new StringBuilder();
                StringBuilder valuesDelProd = new StringBuilder();

                StringBuilder whereDelInv = new StringBuilder();
                StringBuilder valuesDelInv = new StringBuilder();

                DialogResult delRes = MessageBox.Show("Are you sure you want to delete this Product?", "Delete Product?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (delRes == DialogResult.Yes)
                {
                    whereDelProd.Append("gc_item_code");
                    valuesDelProd.Append(senderGrid.Rows[e.RowIndex].Cells[1].Value.ToString());

                    whereDelInv.Append("gc_item_code");
                    valuesDelInv.Append(senderGrid.Rows[e.RowIndex].Cells[1].Value.ToString());

                    db.GCDeleteFromDb("inventory",valuesDelInv,whereDelInv);
                    db.GCDeleteFromDb("products", valuesDelProd, whereDelProd);

                    notification = new notification("Product has been deleted.", notification.AlertType.success);
                    notification.ShowDialog();
                    DataTable dt = db.GCSelectFromDb("products", null, null,"ORDER BY id DESC");
                    dgProducts.DataSource = null;
                    dgProducts.DataSource = dt;
                }
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            DataTable dt = db.GCSelectFromDb("products", null, null, "ORDER BY ID DESC");
            dgProducts.DataSource = null;
            dgProducts.DataSource = dt;
            editItemPage.btnSave.Click -= BtnSave_Click;
        }

        private void txtCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            view.chkNum(txtCost,e);
        }

        private void txtSrp_KeyPress(object sender, KeyPressEventArgs e)
        {
            view.chkNum(txtSrp,e);
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            StringBuilder whereSearch = new StringBuilder();
            whereSearch.Append("gc_item_name LIKE '%"+txtSearch.Text+"%' OR gc_item_code LIKE '%"+ txtSearch.Text + "%'");
            DataTable dt = db.GCSelectFromDb("products",null,whereSearch,"ORDER BY id DESC");
            dgProducts.DataSource = null;
            dgProducts.DataSource = dt;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if ( checkBox1.Checked == true )
            {
                txtInvQty.Enabled = true;
                txtStockQty.Enabled = true;
            }
            else
            {
                txtInvQty.Enabled = false;
                txtStockQty.Enabled = false;
            }
        }

        private void txtInvQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            view.chkNum(txtInvQty,e);
        }

        private void txtStockQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            view.chkNum(txtStockQty,e);
        }
    }
}
