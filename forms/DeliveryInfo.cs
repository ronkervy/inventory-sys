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
    public partial class DeliveryInfo : Form
    {

        public string itemName, itemSupp, itemBrand;
        public int qty, orderTerms;

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        public float itemPrice;
        DateTime dtDelivery;
        public DeliveryInfo()
        {
            InitializeComponent();
        }
    }
}
