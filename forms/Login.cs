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

namespace Inventory_System
{
    public partial class LoginForm : Form
    {
        dbGc db = new dbGc();
        Inventory_Main main;
        notification notification;
        public LoginForm()
        {
            InitializeComponent();
            this.Visible = false;
            
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            loginTrans.ShowAsyc(this);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            StringBuilder where = new StringBuilder();
            where.Append("username='"+txtUsername.text+"' AND password='"+txtPassword.text+"'");
            int resLog = db.searchData("users",null,where);

            if ( resLog >= 1)
            {
                main = new Inventory_Main();
                main.Show();
                notification notification = new notification("Welcome Admin!", notification.AlertType.info);
                notification.ShowDialog();
            }
            else
            {

            }

        }
    }
}
