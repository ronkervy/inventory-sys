using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory_System.core;

namespace Inventory_System.core
{
    class GcTransaction : dbGc
    {
        private string tblName = "transact";
        view view = new view();

        public void insertToTrans(StringBuilder values)
        {
            StringBuilder param = new StringBuilder();
            param.Append(
                "gc_from_tbl," +
                "gc_action_name," +
                "gc_item_qty," +
                "gc_curr_qty," +
                "gc_trans_date," +
                "gc_unique_id," +
                "gc_item_code," +
                "gc_customer_name," +
                "gc_customer_add," +
                "gc_um," +
                "gc_item_desc," +
                "gc_item_name," +
                "gc_total_price," +
                "gc_item_cost," +
                "gc_item_srp,"+
                "gc_cust_cash,"+
                "gc_cust_change,"+
                "gc_cost_total"
            );
            this.GCInsertToDb(tblName,param,values);
        }        
    }
}
