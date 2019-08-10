using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data;
using System.Data.SqlClient;
using Inventory_System.core;
using System.Security.Cryptography;
using System.Globalization;

namespace Inventory_System.core
{
    class view
    {
        public dbGc db = new dbGc();
        GcDelivery delivery = new GcDelivery();
        public string folderMain = AppDomain.CurrentDomain.BaseDirectory + "reports\\";
        public void chkNum(TextBox txtBox,KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != '.';
        }

        public void renderListView(ListView lv,string[] columns,StringBuilder colDb=null,string tableName=null)
        {            
            int i = 1;
            int a = 0;
            int c = 0;
            lv.View = View.Details;

            if ( colDb == null )
            {
                colDb = new StringBuilder();
                colDb.Append("gc_item_name," +
                    "gc_item_code," +
                    "gc_item_qty," +
                    "gc_item_desc," +
                    "gc_item_um," +
                    "gc_item_type," +
                    "gc_item_supp," +
                    "gc_item_brand," +
                    "gc_item_cost," +
                    "gc_item_srp," +
                    "gc_date_added");
            }

            string[] colinDb = colDb.ToString().Split(',');

            DataTable dt = db.GCSelectFromDb(tableName,null,null);            

            foreach ( string columnName in columns )
            {
                lv.Columns.Add(columnName);
            }

            foreach (string column in columns)
            {
                if (c == 0 || c == 1)
                {
                    lv.Columns[c].Width = 70;
                }
                else
                {
                    lv.Columns[c].Width = 100;
                }
                c++;
            }
                       
            foreach ( DataRow row in dt.Rows )
            {
                lv.Items.Add(row[colinDb[0]].ToString());
                foreach ( string colName in colinDb )
                {
                    if ( colinDb[0] != colName )
                    {
                        lv.Items[a].SubItems.Add(row[colName].ToString());
                    }
                }
                i++;
                a++;
            }

        }

        public string Random(string chars, int length = 8)
        {
            var randomString = new StringBuilder();
            var random = new Random();

            for (int i = 0; i < length; i++)
                randomString.Append(chars[random.Next(chars.Length)]);
            return "GC-"+ randomString.ToString();
        }  
    }
}
