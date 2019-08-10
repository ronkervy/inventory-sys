using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using Inventory_System.core;

namespace Inventory_System.forms
{
    public partial class receipt : Form
    {
        ReportDocument cryrpt = new ReportDocument();
        dbGc db = new dbGc();
        public string custName,transID;
        view view = new view();
        public receipt()
        {
            InitializeComponent();
        }

        private void receipt_Load(object sender, EventArgs e)
        {
            StringBuilder where = new StringBuilder();
            if ( transID != "" )
            {
                where.Append("gc_unique_id='" + transID + "'");
            }            
            DataTable dt = db.GCSelectFromDb("transact", null, where);
            cryrpt.Load(@""+view.folderMain + "receipt.rpt");
            cryrpt.SetDataSource(dt);
            rptReceipt.ReportSource = cryrpt;
        }
    }
}
