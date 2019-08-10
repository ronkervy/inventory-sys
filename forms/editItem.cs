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
    public partial class editItem : Form
    {
        public string itemCode;
        dbGc db = new dbGc();
        view view = new view();
        notification notification;
        public editItem()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            StringBuilder whereItemCode = new StringBuilder();

            StringBuilder whereUpdate = new StringBuilder();
            StringBuilder paramUpdate = new StringBuilder();
            StringBuilder valuesUpdate = new StringBuilder();

            StringBuilder whereInvUpdate = new StringBuilder();
            StringBuilder paramInvUpdate = new StringBuilder();
            StringBuilder valuesInvUpdate = new StringBuilder();

            StringBuilder whereStockUpdate = new StringBuilder();
            StringBuilder paramStockUpdate = new StringBuilder();
            StringBuilder valuesStockUpdate = new StringBuilder();

            if ( itemCode != "" && itemCode != txtItemCode.Text )
            {
                whereItemCode.Append("gc_item_code='" + txtItemCode.Text + "'");
                int resItemCode = db.searchData("products",null,whereItemCode);
                if ( resItemCode == 1 )
                {
                    notification = new notification("Item Code already Existing", notification.AlertType.error);
                    notification.ShowDialog();
                }
                else
                {
                    paramInvUpdate.Append(
                        "gc_item_name," +
                        "gc_item_code," +
                        "gc_item_um," +
                        "gc_item_desc," +
                        "gc_item_supp," +
                        "gc_item_brand," +
                        "gc_item_cost," +
                        "gc_item_srp," +
                        "gc_item_type"
                    );

                    valuesInvUpdate.Append(
                        txtItemName.Text + "," +
                        txtItemCode.Text + "," +
                        txtUm.Text + "," +
                        txtDesc.Text + "," +
                        cmbSupp.Text + "," +
                        txtBrand.Text + "," +
                        float.Parse(txtCost.Text) + "," +
                        float.Parse(txtSrp.Text) + "," +
                        cmbItemType.Text
                    );

                    paramStockUpdate.Append(
                        "gc_item_name," +
                        "gc_item_code," +
                        "gc_item_um," +
                        "gc_item_desc," +
                        "gc_item_supp," +
                        "gc_item_brand," +
                        "gc_item_cost," +
                        "gc_item_srp," +
                        "gc_item_type"
                    );

                    valuesStockUpdate.Append(
                        txtItemName.Text + "," +
                        txtItemCode.Text + "," +
                        txtUm.Text + "," +
                        txtDesc.Text + "," +
                        cmbSupp.Text + "," +
                        txtBrand.Text + "," +
                        float.Parse(txtCost.Text) + "," +
                        float.Parse(txtSrp.Text) + "," +
                        cmbItemType.Text
                    );

                    paramUpdate.Append(
                        "gc_item_name," +
                        "gc_item_code," +
                        "gc_item_um," +
                        "gc_item_desc," +
                        "gc_item_supp," +
                        "gc_item_brand," +
                        "gc_item_cost," +
                        "gc_item_srp," +
                        "gc_item_type," +
                        "gc_item_status"
                    );

                    valuesUpdate.Append(
                        txtItemName.Text + "," +
                        txtItemCode.Text + "," +
                        txtUm.Text + "," +
                        txtDesc.Text + "," +
                        cmbSupp.Text + "," +
                        txtBrand.Text + "," +
                        float.Parse(txtCost.Text) + "," +
                        float.Parse(txtSrp.Text) + "," +
                        cmbItemType.Text + "," +
                        "in-active"
                    );

                    whereInvUpdate.Append("gc_item_code='" + itemCode + "'");
                    whereStockUpdate.Append("gc_item_code='" + itemCode + "'");
                    whereUpdate.Append("gc_item_code='"+itemCode+"'");

                    db.GCUpdateDb("stock",paramStockUpdate,valuesStockUpdate,whereStockUpdate);
                    db.GCUpdateDb("inventory",paramInvUpdate,valuesInvUpdate,whereInvUpdate);
                    db.GCUpdateDb("products",paramUpdate, valuesUpdate,whereUpdate);                   

                    notification = new notification("Product information updated.", notification.AlertType.success);
                    notification.ShowDialog();
                }
            }
            else if( itemCode != "" && txtItemName.Text != "" )
            {
                paramInvUpdate.Append(
                    "gc_item_name," +
                    "gc_item_code," +
                    "gc_item_um," +
                    "gc_item_desc," +
                    "gc_item_supp," +
                    "gc_item_brand," +
                    "gc_item_cost," +
                    "gc_item_srp," +
                    "gc_item_type"
                );

                valuesInvUpdate.Append(
                    txtItemName.Text + "," +
                    txtItemCode.Text + "," +
                    txtUm.Text + "," +
                    txtDesc.Text + "," +
                    cmbSupp.Text + "," +
                    txtBrand.Text + "," +
                    float.Parse(txtCost.Text) + "," +
                    float.Parse(txtSrp.Text) + "," +
                    cmbItemType.Text
                );

                paramStockUpdate.Append(
                    "gc_item_name," +
                    "gc_item_code," +
                    "gc_item_um," +
                    "gc_item_desc," +
                    "gc_item_supp," +
                    "gc_item_brand," +
                    "gc_item_cost," +
                    "gc_item_srp," +
                    "gc_item_type"
                );

                valuesStockUpdate.Append(
                    txtItemName.Text + "," +
                    txtItemCode.Text + "," +
                    txtUm.Text + "," +
                    txtDesc.Text + "," +
                    cmbSupp.Text + "," +
                    txtBrand.Text + "," +
                    float.Parse(txtCost.Text) + "," +
                    float.Parse(txtSrp.Text) + "," +
                    cmbItemType.Text
                );

                paramUpdate.Append(
                    "gc_item_name," +
                    "gc_item_code," +
                    "gc_item_um," +
                    "gc_item_desc," +
                    "gc_item_supp," +
                    "gc_item_brand," +
                    "gc_item_cost," +
                    "gc_item_srp," +
                    "gc_item_type," +
                    "gc_item_status"
                );

                valuesUpdate.Append(
                    txtItemName.Text + "," +
                    txtItemCode.Text + "," +
                    txtUm.Text + "," +
                    txtDesc.Text + "," +
                    cmbSupp.Text + "," +
                    txtBrand.Text + "," +
                    float.Parse(txtCost.Text) + "," +
                    float.Parse(txtSrp.Text) + "," +
                    cmbItemType.Text + "," +
                    "in-active"
                );

                whereInvUpdate.Append("gc_item_code='" + itemCode + "'");
                whereStockUpdate.Append("gc_item_code='" + itemCode + "'");
                whereUpdate.Append("gc_item_code='" + itemCode + "'");

                db.GCUpdateDb("stock", paramStockUpdate, valuesStockUpdate, whereStockUpdate);
                db.GCUpdateDb("inventory", paramInvUpdate, valuesInvUpdate, whereInvUpdate);
                db.GCUpdateDb("products", paramUpdate, valuesUpdate, whereUpdate);

                notification = new notification("Product information updated.", notification.AlertType.success);
                notification.ShowDialog();
            }
            else
            {
                notification = new notification("Error. Please check fields before saving.", notification.AlertType.error);
                notification.ShowDialog();
            }
        }

        private void editItem_Load(object sender, EventArgs e)
        {
            StringBuilder paramSupp = new StringBuilder();
            cmbSupp.Items.Clear();
            paramSupp.Append("gc_supp_name");
            DataTable dtSupp = db.GCSelectFromDb("suppliers",paramSupp,null,"ORDER BY id DESC");
            foreach ( DataRow row in dtSupp.Rows )
            {
                cmbSupp.Items.Add(row[0].ToString());
            }
        }
    }
}
