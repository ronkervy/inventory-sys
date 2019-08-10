using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventory_System.forms;
using Inventory_System.core;

namespace Inventory_System.forms
{
    public partial class splash : Form
    {
        public int counter = 0;
        Inventory_Main main;
        LoginForm login;
        public splash()
        {
            InitializeComponent();
        }


        private void splash_Load(object sender, EventArgs e)
        {
            pBar.MaximumValue = 100;
            pBar.Value = 0;
            progressTimer.Start();
        }

        private void progressTimer_Tick(object sender, EventArgs e)
        {            
            if ( pBar.Value <= 99 )
            {
                pBar.Value = counter;
                lblPercent.Text = counter.ToString() + "%";
            }
            else
            {
                progressTimer.Stop();
                this.Hide();
                main = new Inventory_Main();
                main.Show();
                notification notification = new notification("Welcome Admin!", notification.AlertType.info);
                notification.ShowDialog();
            }
            counter++;
        }
    }
}
