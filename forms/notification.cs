using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_System.forms
{
    public partial class notification : Form
    {
        public string message;
        public int topPosition;
        public int interval = 0;
        public double intOp = 0;
        public notification(string message,AlertType type)
        {
            InitializeComponent();
            switch (type)
            {
                case AlertType.success:
                    this.BackColor = Color.SeaGreen;
                    break;
                case AlertType.info:
                    this.BackColor = Color.DodgerBlue;
                    break;
                case AlertType.warning:
                    this.BackColor = Color.FromArgb(255,128,0);
                    break;
                case AlertType.error:
                    this.BackColor = Color.Crimson;
                    break;
            }
            lblMessage.Text = message;
            if (lblMessage.Text.Length > 14)
            {
                lblMessage.Font = new Font("Segoe UI",10,FontStyle.Regular);
            }
        }

        private void notification_Load(object sender, EventArgs e)
        {
            topPosition = 40;
            this.Top = -1 * (this.Height);
            this.Left = Screen.PrimaryScreen.Bounds.Width - this.Width - 10;
            showAnim.Start();
            timeOut.Start();
        }

        public enum AlertType
        {
            success,info,warning,error
        }

        private void timeOut_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showAnim_Tick(object sender, EventArgs e)
        {                        
            if (this.Top < topPosition)
            {
                this.Top += interval;
                this.Opacity += intOp;
                intOp += 0.04;
                interval += 2;                
            }
            else
            {
                showAnim.Stop();
            }
        }
    }
}
