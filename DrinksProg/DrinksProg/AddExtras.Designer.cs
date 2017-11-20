namespace DrinksProg
{
    partial class AddExtras
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
            this.lblPriceExtra = new System.Windows.Forms.Label();
            this.lblNameExtra = new System.Windows.Forms.Label();
            this.txtNameExtra = new System.Windows.Forms.TextBox();
            this.txtPriceExtra = new System.Windows.Forms.TextBox();
            this.btnSaveExtra = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPriceExtra
            // 
            this.lblPriceExtra.AutoSize = true;
            this.lblPriceExtra.Location = new System.Drawing.Point(11, 41);
            this.lblPriceExtra.Name = "lblPriceExtra";
            this.lblPriceExtra.Size = new System.Drawing.Size(31, 13);
            this.lblPriceExtra.TabIndex = 12;
            this.lblPriceExtra.Text = "Price";
            // 
            // lblNameExtra
            // 
            this.lblNameExtra.AutoSize = true;
            this.lblNameExtra.Location = new System.Drawing.Point(11, 15);
            this.lblNameExtra.Name = "lblNameExtra";
            this.lblNameExtra.Size = new System.Drawing.Size(35, 13);
            this.lblNameExtra.TabIndex = 11;
            this.lblNameExtra.Text = "Name";
            // 
            // txtNameExtra
            // 
            this.txtNameExtra.Location = new System.Drawing.Point(101, 12);
            this.txtNameExtra.Name = "txtNameExtra";
            this.txtNameExtra.Size = new System.Drawing.Size(171, 20);
            this.txtNameExtra.TabIndex = 7;
            // 
            // txtPriceExtra
            // 
            this.txtPriceExtra.Location = new System.Drawing.Point(101, 38);
            this.txtPriceExtra.Name = "txtPriceExtra";
            this.txtPriceExtra.Size = new System.Drawing.Size(100, 20);
            this.txtPriceExtra.TabIndex = 8;
            // 
            // btnSaveExtra
            // 
            this.btnSaveExtra.Location = new System.Drawing.Point(101, 78);
            this.btnSaveExtra.Name = "btnSaveExtra";
            this.btnSaveExtra.Size = new System.Drawing.Size(75, 23);
            this.btnSaveExtra.TabIndex = 10;
            this.btnSaveExtra.Text = "Save";
            this.btnSaveExtra.UseVisualStyleBackColor = true;
            this.btnSaveExtra.Click += new System.EventHandler(this.btnSaveExtra_Click);
            // 
            // AddExtras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 115);
            this.Controls.Add(this.lblPriceExtra);
            this.Controls.Add(this.lblNameExtra);
            this.Controls.Add(this.txtNameExtra);
            this.Controls.Add(this.txtPriceExtra);
            this.Controls.Add(this.btnSaveExtra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddExtras";
            this.Text = "AddExtras";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPriceExtra;
        private System.Windows.Forms.Label lblNameExtra;
        private System.Windows.Forms.TextBox txtNameExtra;
        private System.Windows.Forms.TextBox txtPriceExtra;
        private System.Windows.Forms.Button btnSaveExtra;
    }
}