using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using Inventory_System.core;
using Microsoft.Win32;


namespace Inventory_System.core
{
    class dbGc
    {
        private StringBuilder gcQuery;
        private GcConnect connection;
        private DataSet ds;
        private SqlDataAdapter da;
        private SqlCommand cmd;
        private string[] columnNames;
        view view;

        public DataTable GCSelectFromDb(string tblName = null, StringBuilder param=null,StringBuilder where=null,string misc=null)
        {            
            this.connection = new GcConnect();
            this.gcQuery = new StringBuilder("SELECT ");

            if ( param == null)
            {
                this.gcQuery.Append("* FROM " + tblName);
            }
            else
            {
                this.gcQuery.Append(param + " FROM " + tblName);
            }

            if (where != null)
            {
                this.gcQuery.Append(" WHERE " + where);
            }

            if ( misc != null || misc != "" )
            {
                this.gcQuery.Append(" " + misc);
            }

            //MessageBox.Show(this.gcQuery.ToString());           

            using (this.da = new SqlDataAdapter(this.gcQuery.ToString(), this.connection.ConDb()))
            using (this.ds = new DataSet())
            {
                this.da.Fill(this.ds);
                this.connection.ConDb().Close();
                return this.ds.Tables[0];                
            }
        }

        public void GCInsertToDb(string tblname = null,StringBuilder param = null,StringBuilder values=null)
        {
            this.connection = new GcConnect();
            string[] arrParam = param.ToString().Split(',');
            string[] arrVal = values.ToString().Split(',');
            int i = 0;

            this.gcQuery = new StringBuilder("INSERT INTO " + tblname);

            if ( values == null )
            {
                MessageBox.Show("No value to insert into database.");
            }
            else
            {
                this.gcQuery.Append(" ("+ param + ") VALUES (");

                foreach ( string strParam in arrParam )
                {
                    if ( i+1 == arrParam.Length )
                    {
                        this.gcQuery.Append("@param" + i + ")");
                    }
                    else
                    {
                        this.gcQuery.Append("@param" + i + ",");
                    }
                    i++;
                }                
            }

            //MessageBox.Show(this.gcQuery.ToString());    

            using (this.cmd = new SqlCommand(this.gcQuery.ToString(), this.connection.ConDb()))
            {
                int a = 0;
                foreach (string arrParVal in arrVal)
                {
                    this.cmd.Parameters.AddWithValue("@param" + a, arrVal[a].ToString());
                    a++;
                }
                if (this.cmd.ExecuteNonQuery() == 1)
                {
                    param.Clear();
                    values.Clear();
                }
                else
                {
                    MessageBox.Show("Failed to save item on the database.");
                }                
                this.connection.ConDb().Close();
            }
        }
        
        public void GCUpdateDb(string tblname = null, StringBuilder param = null,StringBuilder values=null,StringBuilder where=null)
        {
            this.connection = new GcConnect();
            this.gcQuery = new StringBuilder("UPDATE " + tblname + " SET ");
            string[] paramNew = param.ToString().Split(',');
            string[] valuesNew = values.ToString().Split(',');
            int i = 0;

            if (param == null || values == null)
            {
                MessageBox.Show("Cannot update the database, no parameter found.");
            }

            foreach (string paramKeyVal in paramNew)
            {
                if (i+1 == paramNew.Length)
                {
                    this.gcQuery.Append(paramKeyVal + "=@" + paramKeyVal);
                }
                else
                {
                    this.gcQuery.Append(paramKeyVal + "=@"+paramKeyVal+", ");
                }
                i++;
            }
            
            if ( where != null )
            {
                this.gcQuery.Append(" WHERE "+ where);
            }

           //MessageBox.Show(this.gcQuery.ToString());

            using (this.cmd = new SqlCommand(this.gcQuery.ToString(),this.connection.ConDb()))
            {
                int a = 0;
                foreach ( string paramKeyVal in paramNew )
                {
                    this.cmd.Parameters.AddWithValue("@"+paramKeyVal,valuesNew[a].ToString());
                    a++;
                }
                if (this.cmd.ExecuteNonQuery() == 1)
                {
                    param.Clear();
                    values.Clear();
                    where.Clear();
                }
                else
                {
                    MessageBox.Show("There was an error updating the data, please try again.");
                }
                this.connection.ConDb().Close();
            }           
        }

        public void GCDeleteFromDb(string tblname=null,StringBuilder value=null,StringBuilder where=null)
        {
            this.connection = new GcConnect();
            this.gcQuery = new StringBuilder("DELETE FROM " + tblname);
            string[] strWhere = where.ToString().Split(',');
            string[] strVal = value.ToString().Split(',');
            this.gcQuery.Append(" WHERE ");

            if ( where == null || value == null )
            {
                MessageBox.Show("PLEASE SELECT ITEM TO BE DELETED.");
            }
            else
            {                
                int w = 0;
                foreach (string wh in strWhere)
                {
                    if ( w+1 != strWhere.Count() )
                    {
                        this.gcQuery.Append(wh + "=@" + wh + " AND ");
                    }
                    else
                    {
                        this.gcQuery.Append(wh + "=@" + wh);
                    }
                    w++;
                }
            }

            //MessageBox.Show(this.gcQuery.ToString());

            using ( this.cmd=new SqlCommand(this.gcQuery.ToString(),this.connection.ConDb()) )
            {
                int d = 0;
                foreach (string wr in strWhere)
                {
                    this.cmd.Parameters.AddWithValue("@"+wr,strVal[d]);
                    d++;
                }
                if (this.cmd.ExecuteNonQuery() == 1 )
                {
                    where.Clear();
                    value.Clear();
                }
                else
                {
                    MessageBox.Show("Item not found and cannot be deleted.");
                }
                this.connection.ConDb().Close();
            }                
        }

        public int searchData(string tblname = null, StringBuilder param=null, StringBuilder where = null)
        {
            DataTable table =  this.GCSelectFromDb(tblname,param, where);
            int resultCount = table.Rows.Count;
            return resultCount;
        }
        
        public void getColumnNames(string tblName)
        {
            int i = 0;
            DataTable dt = this.GCSelectFromDb(tblName,null,null);
            foreach (DataColumn dc in dt.Columns)
            {
                columnNames[i] = dc.ColumnName;
                i++;
            }
        }

        public void backupDb(string path)
        {
            view = new view();
            //string path = Registry.GetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Shell Folders", "{374DE290-123F-4565-9164-39C4925E467B}", String.Empty).ToString();
            //string path = AppDomain.CurrentDomain.BaseDirectory + "Backups\\";
            this.connection = new GcConnect();
            IDbConnection connection = this.connection.ConDb();
            var dbName = connection.Database;
            this.gcQuery = new StringBuilder("BACKUP DATABASE [" + dbName + "] TO DISK='"+path+"'");            
            using (this.cmd = new SqlCommand(this.gcQuery.ToString(), this.connection.ConDb()))
            {
                this.cmd.ExecuteNonQuery();
                this.connection.ConDb().Close();
            }
        }

        public void restoreDb()
        {
            /*
             *         
        string sqlStmt2 = string.Format("ALTER DATABASE [" + dbName + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
        SqlCommand bu2 = new SqlCommand(sqlStmt2, con);
        bu2.ExecuteNonQuery();

        string sqlStmt3 = "USE MASTER RESTORE DATABASE [" + dbName + "] FROM DISK='" + path + "'WITH REPLACE;";
        SqlCommand bu3 = new SqlCommand(sqlStmt3, con);
        bu3.ExecuteNonQuery();

        string sqlStmt4 = string.Format("ALTER DATABASE [" + dbName + "] SET MULTI_USER");
        SqlCommand bu4 = new SqlCommand(sqlStmt4, con);
        bu4.ExecuteNonQuery();

        MessageBox.Show("database restoration done successefully");
        con.Close();
             */

        }

        public void restoreDb(string path)
        {
            this.setSingleUser();
            this.userMasterBackup(path);
            this.setMultiUser();
        }

        private void setSingleUser()
        {
            //string path = Registry.GetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Shell Folders", "{374DE290-123F-4565-9164-39C4925E467B}", String.Empty).ToString();
            //string path = AppDomain.CurrentDomain.BaseDirectory + "Backups\\";
            this.connection = new GcConnect();
            IDbConnection connection = this.connection.ConDb();
            var dbName = connection.Database;
            this.gcQuery = new StringBuilder("ALTER DATABASE [" + dbName + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
            using (this.cmd = new SqlCommand(this.gcQuery.ToString(), this.connection.ConDb()))
            {
                this.cmd.ExecuteNonQuery();
                this.connection.ConDb().Close();
            }
        }

        private void userMasterBackup(string path)
        {
            //string path = Registry.GetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Shell Folders", "{374DE290-123F-4565-9164-39C4925E467B}", String.Empty).ToString();
            //string path = AppDomain.CurrentDomain.BaseDirectory + "Backups\\";
            this.connection = new GcConnect();
            IDbConnection connection = this.connection.ConDb();
            var dbName = connection.Database;
            this.gcQuery = new StringBuilder("USE MASTER RESTORE DATABASE [" + dbName + "] FROM DISK='" + path + "'WITH REPLACE;");
            using (this.cmd = new SqlCommand(this.gcQuery.ToString(), this.connection.ConDb()))
            {
                this.cmd.ExecuteNonQuery();
                this.connection.ConDb().Close();
            }
        }

        private void setMultiUser()
        {
            //string path = Registry.GetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Shell Folders", "{374DE290-123F-4565-9164-39C4925E467B}", String.Empty).ToString();
            //string path = AppDomain.CurrentDomain.BaseDirectory + "Backups\\";
            this.connection = new GcConnect();
            IDbConnection connection = this.connection.ConDb();
            var dbName = connection.Database;
            this.gcQuery = new StringBuilder("ALTER DATABASE [" + dbName + "] SET MULTI_USER");
            using (this.cmd = new SqlCommand(this.gcQuery.ToString(), this.connection.ConDb()))
            {
                this.cmd.ExecuteNonQuery();
                this.connection.ConDb().Close();
            }
        }

    }
}
