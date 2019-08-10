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
    public partial class salesQty : Form
    {
        view view = new view();
        public salesQty()
        {
            InitializeComponent();
        }
        private void btnAddQty_Click(object sender, EventArgs e)
        {

        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            view.chkNum(txtQty,e);
        }
    }
}
