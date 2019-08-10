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
    public partial class EditSupplier : Form
    {
        dbGc db = new dbGc();
        notification notification;
        public string suppName;
        public EditSupplier()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if ( txtSuppName.Text != "" && txtContact.Text != "" )
            {
                StringBuilder param = new StringBuilder();
                StringBuilder values = new StringBuilder();
                StringBuilder where = new StringBuilder();

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

                where.Append("gc_supp_name='" + suppName + "'");
                db.GCUpdateDb("suppliers", param, values, where);
                notification = new notification("Supplier has been updated.", notification.AlertType.success);
                notification.ShowDialog();
                
            }
            else
            {
                notification = new notification("Error updating, Please check the fields.", notification.AlertType.success);
                notification.ShowDialog();
            }
        }
    }
}
