using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Configuration;

namespace Inventory_System.core
{
    class GcConnect
    {
        private string connStr;
        private SqlConnection gcConn;

        public SqlConnection ConDb (){            
            try
            {
                this.connStr = ConfigurationManager.ConnectionStrings["Inventory_System.Properties.Settings.gcConnectionString"].ConnectionString;
                this.gcConn = new SqlConnection(this.connStr);
                this.gcConn.Open();
                return this.gcConn;
            }
            catch (Exception ex)
            {              
                MessageBox.Show(ex.Message);
                return null;
            }
        }
    }
}
