using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using Inventory_System.core;

namespace Inventory_System.forms
{
    public partial class DeliveryStatusDashboard : Form
    {
        DateTime fromDate,toDate;
        dbGc db = new dbGc();
        public DeliveryStatusDashboard()
        {
            InitializeComponent();
        }

        private void DeliveryStatusDashboard_Load(object sender, EventArgs e)
        {            
            DataTable dt = db.GCSelectFromDb("delivery",null,null,"ORDER BY id DESC");
            dgDelivery.DataSource = dt;
        }

        private void dgDelivery_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {            
            foreach ( DataGridViewRow row in dgDelivery.Rows )
            {
                if ( row.Cells[0].Value != null )
                {
                    row.Cells[2].Style.ForeColor = Color.White;
                    row.Cells[2].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    fromDate = Convert.ToDateTime(row.Cells[4].Value.ToString());
                    toDate = Convert.ToDateTime(row.Cells[4].Value.ToString()).AddDays(int.Parse(row.Cells[3].Value.ToString()));

                    if ( ((toDate.Day - DateTime.Today.Day) - 1) <= 3 )
                    {
                        row.Cells[2].Style.BackColor = Color.Maroon;
                        row.Cells[2].Value = (toDate.Day - DateTime.Today.Day) - 1;
                    }
                    else if (((toDate.Day - DateTime.Today.Day) - 1) <= 0)
                    {
                        row.Cells[2].Value = 0;
                    }
                    else
                    {
                        row.Cells[2].Style.BackColor = Color.SeaGreen;
                        row.Cells[2].Value = (toDate.Day - DateTime.Today.Day) - 1;
                    }                                                          
                }
            }
        }
    }
}
