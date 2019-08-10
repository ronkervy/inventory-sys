namespace Inventory_System.forms
{
    partial class delQty
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
            this.btnDelQty = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnDelQty
            // 
            this.btnDelQty.Activecolor = System.Drawing.Color.MidnightBlue;
            this.btnDelQty.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnDelQty.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelQty.BorderRadius = 0;
            this.btnDelQty.ButtonText = "&Remove";
            this.btnDelQty.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelQty.DisabledColor = System.Drawing.Color.Gray;
            this.btnDelQty.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDelQty.Iconimage = null;
            this.btnDelQty.Iconimage_right = null;
            this.btnDelQty.Iconimage_right_Selected = null;
            this.btnDelQty.Iconimage_Selected = null;
            this.btnDelQty.IconMarginLeft = 0;
            this.btnDelQty.IconMarginRight = 0;
            this.btnDelQty.IconRightVisible = true;
            this.btnDelQty.IconRightZoom = 0D;
            this.btnDelQty.IconVisible = true;
            this.btnDelQty.IconZoom = 40D;
            this.btnDelQty.IsTab = false;
            this.btnDelQty.Location = new System.Drawing.Point(108, 72);
            this.btnDelQty.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelQty.Name = "btnDelQty";
            this.btnDelQty.Normalcolor = System.Drawing.Color.CornflowerBlue;
            this.btnDelQty.OnHovercolor = System.Drawing.Color.MidnightBlue;
            this.btnDelQty.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDelQty.selected = false;
            this.btnDelQty.Size = new System.Drawing.Size(186, 42);
            this.btnDelQty.TabIndex = 25;
            this.btnDelQty.Text = "&Remove";
            this.btnDelQty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDelQty.Textcolor = System.Drawing.Color.White;
            this.btnDelQty.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelQty.Click += new System.EventHandler(this.btnDelQty_Click);
            // 
            // txtQty
            // 
            this.txtQty.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQty.Location = new System.Drawing.Point(12, 12);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(391, 43);
            this.txtQty.TabIndex = 24;
            this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQty_KeyPress);
            // 
            // delQty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 126);
            this.Controls.Add(this.btnDelQty);
            this.Controls.Add(this.txtQty);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "delQty";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete Quantity";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Bunifu.Framework.UI.BunifuFlatButton btnDelQty;
        public System.Windows.Forms.TextBox txtQty;
    }
}