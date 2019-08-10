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
    public partial class UsersList : Form
    {
        dbGc db = new dbGc();
        string uname, pword, eadd, contact, otherInfo, fullName;
        EditUser editPage = new EditUser();
        notification notification;

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in panel1.Controls)
            {
                if ( ctrl.GetType() == typeof(TextBox) || ctrl.GetType() == typeof(RichTextBox) )
                {
                    ctrl.Text = "";
                }
            }
        }

        public UsersList()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void UsersList_Load(object sender, EventArgs e)
        {
            DataTable dt = db.GCSelectFromDb("users", null, null);
            dgUsers.DataSource = dt;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            StringBuilder where = new StringBuilder();
            where.Append("username='"+txtUsername.Text+"' AND password='"+txtPassword.Text+"'");
            int resUser = db.searchData("users",null,where);
            if (resUser >= 1)
            {
                notification notification = new notification("Username or password already existing.",notification.AlertType.error);
                notification.ShowDialog();
            }
            else if( txtUsername.Text != "" && txtPassword.Text != "" && txtFullName.Text != "" )
            {
                StringBuilder param = new StringBuilder();
                StringBuilder values = new StringBuilder();

                param.Append(
                    "username,"+    
                    "password,"+
                    "email,"+
                    "contact,"+
                    "other_info,"+
                    "full_name"
                );

                values.Append(
                    txtUsername.Text + "," +
                    txtPassword.Text + "," +
                    txtEmail.Text + "," +
                    txtContact.Text + "," +
                    txtOtherInfo.Text + "," +
                    txtFullName.Text
                );

                db.GCInsertToDb("users", param, values);
                notification notification = new notification("User has been saved to the database.", notification.AlertType.success);
                notification.Show();

                DataTable dt = db.GCSelectFromDb("users",null,null);
                dgUsers.DataSource = null;
                dgUsers.DataSource = dt;
            }
            else
            {
                notification notification = new notification("Check the fields before saving.", notification.AlertType.error);
                notification.Show();
            }
        }

        private void dgUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView senderGrid = (DataGridView)sender;
            if ( e.ColumnIndex == 6 )
            {                
                editPage.txtFullName.Text = senderGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                editPage.txtUsername.Text = senderGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                editPage.txtPass.Text = senderGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
                editPage.txtEmail.Text = senderGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
                editPage.txtContact.Text = senderGrid.Rows[e.RowIndex].Cells[4].Value.ToString();
                editPage.txtOtherInfo.Text = senderGrid.Rows[e.RowIndex].Cells[5].Value.ToString();

                editPage.lblFullName.Text = senderGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                editPage.lblUserName.Text = senderGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                editPage.lblEmail.Text = senderGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
                editPage.lblContact.Text = senderGrid.Rows[e.RowIndex].Cells[4].Value.ToString();

                uname = senderGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                pword = senderGrid.Rows[e.RowIndex].Cells[2].Value.ToString();

                editPage.btnUpdate.Click += BtnUpdate_Click;

                editPage.ShowDialog();
            }else if (e.ColumnIndex == 7)
            {
                uname = senderGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                pword = senderGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
                StringBuilder whereDel = new StringBuilder();
                StringBuilder valDel = new StringBuilder();

                whereDel.Append("username,password");
                valDel.Append(uname+","+pword);

                DialogResult delRes = MessageBox.Show("Are you sure you want to delete this record?", "Delete record?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if ( delRes == DialogResult.Yes )
                {
                    db.GCDeleteFromDb("users",valDel,whereDel);

                    DataTable dt = db.GCSelectFromDb("users", null, null);
                    dgUsers.DataSource = null;
                    dgUsers.DataSource = dt;

                    editPage.btnUpdate.Click -= BtnUpdate_Click;

                    notification = new notification("Successfully updated deleted Record.", notification.AlertType.success);
                    notification.ShowDialog();
                }
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            StringBuilder param = new StringBuilder();
            StringBuilder values = new StringBuilder();
            StringBuilder where = new StringBuilder();

            param.Append("username,password,email,contact,other_info,full_name");
            values.Append(
                editPage.txtUsername.Text + "," +
                editPage.txtPass.Text + "," +
                editPage.txtEmail.Text + "," +
                editPage.txtContact.Text + "," +
                editPage.txtOtherInfo.Text + "," +
                editPage.txtFullName.Text
            );

            where.Append("username='"+uname+"' AND password='"+pword+"'");

            if ( editPage.txtFullName.Text != "" && editPage.txtUsername.Text != "" && editPage.txtPass.Text != "" )
            {
                db.GCUpdateDb("users",param,values,where);

                DataTable dt = db.GCSelectFromDb("users", null, null);
                dgUsers.DataSource = null;
                dgUsers.DataSource = dt;

                editPage.btnUpdate.Click -= BtnUpdate_Click;

                notification = new notification("Successfully updated fields.", notification.AlertType.success);
                notification.ShowDialog();
            }
            else
            {
                editPage.btnUpdate.Click -= BtnUpdate_Click;
                notification = new notification("Error updating. Please check fields.", notification.AlertType.error);
                notification.ShowDialog();
            }            
            
            editPage.Close();
        }
    }
}
