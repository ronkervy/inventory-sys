namespace Inventory_System.forms
{
    partial class InventoryQty
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAddQty = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAddQty
            // 
            this.btnAddQty.Activecolor = System.Drawing.Color.MidnightBlue;
            this.btnAddQty.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAddQty.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddQty.BorderRadius = 0;
            this.btnAddQty.ButtonText = "&Add";
            this.btnAddQty.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddQty.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddQty.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddQty.Iconimage = null;
            this.btnAddQty.Iconimage_right = null;
            this.btnAddQty.Iconimage_right_Selected = null;
            this.btnAddQty.Iconimage_Selected = null;
            this.btnAddQty.IconMarginLeft = 0;
            this.btnAddQty.IconMarginRight = 0;
            this.btnAddQty.IconRightVisible = true;
            this.btnAddQty.IconRightZoom = 0D;
            this.btnAddQty.IconVisible = true;
            this.btnAddQty.IconZoom = 40D;
            this.btnAddQty.IsTab = false;
            this.btnAddQty.Location = new System.Drawing.Point(108, 72);
            this.btnAddQty.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddQty.Name = "btnAddQty";
            this.btnAddQty.Normalcolor = System.Drawing.Color.CornflowerBlue;
            this.btnAddQty.OnHovercolor = System.Drawing.Color.MidnightBlue;
            this.btnAddQty.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddQty.selected = false;
            this.btnAddQty.Size = new System.Drawing.Size(186, 42);
            this.btnAddQty.TabIndex = 25;
            this.btnAddQty.Text = "&Add";
            this.btnAddQty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddQty.Textcolor = System.Drawing.Color.White;
            this.btnAddQty.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtQty
            // 
            this.txtQty.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQty.Location = new System.Drawing.Point(12, 12);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(391, 43);
            this.txtQty.TabIndex = 24;
            this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // InventoryQty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 127);
            this.Controls.Add(this.btnAddQty);
            this.Controls.Add(this.txtQty);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "InventoryQty";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Quantity";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Bunifu.Framework.UI.BunifuFlatButton btnAddQty;
        public System.Windows.Forms.TextBox txtQty;
    }
}