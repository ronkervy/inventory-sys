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
using CrystalDecisions.CrystalReports.Engine;

namespace Inventory_System.forms
{
    public partial class SalesDashboard : Form
    {
        dbGc db = new dbGc();
        public string resFilter;
        ReportDocument cryrpt = new ReportDocument();
        Transaction transactionPage = new Transaction();
        Transaction_History transHistory = new Transaction_History();
        receipt receiptPage = new receipt();
        view view = new view();
        public SalesDashboard()
        {
            InitializeComponent();
            StringBuilder where = new StringBuilder();

            where.Append("gc_from_tbl='sales'");

            DataTable dt = db.GCSelectFromDb("transact", null, where);
            cryrpt.Load(@""+view.folderMain+"sales.rpt");
            cryrpt.SetDataSource(dt);
            crySalesRept.ReportSource = cryrpt;
            this.WindowState = FormWindowState.Maximized;
        }

        private void cmbFilter_TextChanged(object sender, EventArgs e)
        {
            if (cmbFilter.Text != "")
            {
                StringBuilder param = new StringBuilder();

                cmbFilterName.Enabled = true;                

                if (cmbFilter.Text == "Item Name")
                {
                    cmbFilterName.Items.Clear();
                    param.Append("DISTINCT gc_item_name");
                }
                else if (cmbFilter.Text == "Item Code")
                {
                    cmbFilterName.Items.Clear();
                    param.Append("DISTINCT gc_item_code");
                }                

                DataTable dt = db.GCSelectFromDb("transact", param, null);
                foreach (DataRow row in dt.Rows)
                {
                    cmbFilterName.Items.Add(row[0].ToString());
                }
            }
        }

        private void btnViewTrans_Click(object sender, EventArgs e)
        {
            StringBuilder where = new StringBuilder();
            where.Append("gc_trans_date >= '"+dtPickerFrom.Text+ "' AND gc_trans_date <= '" + dtPickerTo.Text +"' AND gc_from_tbl='sales'");

            if ( cmbFilter.Text !="" && cmbFilter.Text == "Item Name" )
            {
                where.Append(" AND gc_item_name LIKE '%"+cmbFilterName.Text+"%'");
            }
            else if (cmbFilter.Text != "" && cmbFilter.Text == "Item Code")
            {
                where.Append(" AND gc_item_code LIKE '%"+cmbFilterName.Text+"%'");
            }
            else
            {
                where.Append(" AND gc_item_name LIKE '%" + cmbFilterName.Text + "%'");
            }

            DataTable dt = db.GCSelectFromDb("transact", null, where);
            cryrpt.Load(@"" + view.folderMain + "sales.rpt");
            cryrpt.SetDataSource(dt);
            crySalesRept.ReportSource = cryrpt;
        }        

        private void btnNew_Click(object sender, EventArgs e)
        {
            transactionPage.lvCart.Items.Clear();
            transactionPage.dgStock.DataSource = null;
            transactionPage.ShowDialog();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            transHistory.ShowDialog();
        }
    }
}
