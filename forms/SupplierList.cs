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
    public partial class SupplierList : Form
    {
        dbGc db = new dbGc();
        notification notification;
        EditSupplier editSuppPage = new EditSupplier();
        public SupplierList()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void SupplierList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gcDataSet.suppliers' table. You can move, or remove it, as needed.
            this.suppliersTableAdapter.Fill(this.gcDataSet.suppliers);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if ( txtSuppName.Text != "" && txtContact.Text != "" )
            {
                StringBuilder whereSearch = new StringBuilder();
                whereSearch.Append("gc_supp_name LIKE '"+txtSuppName.Text+"'");
                int resSupp = db.searchData("suppliers",null,whereSearch);

                if ( resSupp >= 1 )
                {
                    notification = new notification("Supplier already existing.", notification.AlertType.error);
                    notification.ShowDialog();
                }
                else
                {
                    StringBuilder param = new StringBuilder();
                    StringBuilder values = new StringBuilder();

                    param.Append(
                        "gc_supp_name," +
                        "gc_supp_add," +
                        "gc_contact," +
                        "gc_email," +
                        "gc_other_info"
                    );

                    values.Append(
                        txtSuppName.Text + "," +
                        txtAddress.Text + "," +
                        txtContact.Text + "," +
                        txtEmail.Text + "," +
                        txtOtherInfo.Text
                    );

                    db.GCInsertToDb("suppliers",param,values);

                    DataTable dt = db.GCSelectFromDb("suppliers", null, null);
                    dgSuppliers.DataSource = null;
                    dgSuppliers.DataSource = dt;

                    notification = new notification("Supplier saved to the database.", notification.AlertType.success);
                    notification.ShowDialog();

                }

            }
        }

        private void dgSuppliers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView senderGrid = (DataGridView)sender;
            if (e.ColumnIndex == 5)
            {
                editSuppPage.txtSuppName.Text = senderGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                editSuppPage.txtAddress.Text = senderGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                editSuppPage.txtContact.Text = senderGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
                editSuppPage.txtEmail.Text = senderGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
                editSuppPage.txtOtherInfo.Text = senderGrid.Rows[e.RowIndex].Cells[4].Value.ToString();

                editSuppPage.suppName = senderGrid.Rows[e.RowIndex].Cells[0].Value.ToString();

                editSuppPage.btnUpdate.Click += BtnUpdate_Click;

                editSuppPage.ShowDialog();
            }else if (e.ColumnIndex == 6)
            {
                StringBuilder whereDelSupp = new StringBuilder();
                StringBuilder valuesDelSupp = new StringBuilder();
                DialogResult delRes = MessageBox.Show("Are you sure you want to delete this supplier?", "Delete Supplier?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (delRes == DialogResult.Yes)
                {
                    whereDelSupp.Append("gc_supp_name");
                    valuesDelSupp.Append(senderGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
                    db.GCDeleteFromDb("suppliers", valuesDelSupp, whereDelSupp);

                    notification = new notification("Supplier has been deleted.", notification.AlertType.success);
                    notification.ShowDialog();
                    DataTable dt = db.GCSelectFromDb("suppliers", null, null);
                    dgSuppliers.DataSource = null;
                    dgSuppliers.DataSource = dt;
                }
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            DataTable dt = db.GCSelectFromDb("suppliers",null,null);
            dgSuppliers.DataSource = null;
            dgSuppliers.DataSource = dt;
            editSuppPage.btnUpdate.Click -= BtnUpdate_Click;
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
    }
}
