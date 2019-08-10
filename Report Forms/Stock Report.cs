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

namespace Inventory_System.Report_Forms
{
    public partial class Stock_Report : Form
    {
        ReportDocument cryrpt = new ReportDocument();
        dbGc db = new dbGc();
        view view = new view();
        public Stock_Report()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            StringBuilder where = new StringBuilder();

            where.Append("gc_from_tbl='stock'");

            DataTable dt = db.GCSelectFromDb("transact", null, where);
            cryrpt.Load(@""+view.folderMain+"stock.rpt");
            cryrpt.SetDataSource(dt);
            stockRpt.ReportSource = cryrpt;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            StringBuilder whereSearch = new StringBuilder();
            whereSearch.Append("gc_from_tbl='stock' OR gc_from_tbl='Sales'");

            if (cmbFilter.Text != "" && cmbFilter.Text == "IN")
            {
                whereSearch.Append(" AND gc_action_name='in'");
            }
            else if (cmbFilter.Text != "" && cmbFilter.Text == "OUT")
            {
                whereSearch.Append(" AND gc_action_name='out'");
            }
            else
            {
                whereSearch.Append(" AND gc_action_name='in'");
            }

            whereSearch.Append(" AND gc_trans_date >='" + dtPickerFrom.Text + "' AND gc_trans_date <='" + dtPickerTo.Text + "'");

            DataTable dt = db.GCSelectFromDb("transact", null, whereSearch);
            cryrpt.Load(@"" + view.folderMain + "stock.rpt");
            cryrpt.SetDataSource(dt);
            stockRpt.ReportSource = cryrpt;
        }
    }
}
