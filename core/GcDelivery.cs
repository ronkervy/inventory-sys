using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory_System.core;
using System.Data;

namespace Inventory_System.core
{
    class GcDelivery : dbGc
    {
        private string tblDelivery = "delivery";
        public string[] arr;
        public string[] selectDelivery(StringBuilder param,StringBuilder where)
        {
            int i = 0;
            DataTable dt = this.GCSelectFromDb(tblDelivery,param,where);
            foreach ( DataRow row in dt.Rows )
            {
                arr[i] = row[i].ToString();
                i++;
            }
            return arr;
        }

        public void saveDelivery(StringBuilder param,StringBuilder values)
        {
            this.GCInsertToDb(tblDelivery,param,values);
        }


        public void updateDelivery(StringBuilder param,StringBuilder values,StringBuilder where)
        {
            this.GCUpdateDb(tblDelivery,param,values,where);
        }

        public int deliveryData(StringBuilder param,StringBuilder where)
        {
            return this.searchData(tblDelivery,param,where);
        }

        public void deleteDelivery(StringBuilder value,StringBuilder where)
        {
            this.GCDeleteFromDb(tblDelivery,value,where);
        }

    }
}
