namespace DrinksProg
{
    partial class AddDrinks
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
            this.lblPriceDrink = new System.Windows.Forms.Label();
            this.lblNameDrink = new System.Windows.Forms.Label();
            this.txtNameDrink = new System.Windows.Forms.TextBox();
            this.txtPriceDrink = new System.Windows.Forms.TextBox();
            this.btnSaveDrink = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPriceDrink
            // 
            this.lblPriceDrink.AutoSize = true;
            this.lblPriceDrink.Location = new System.Drawing.Point(11, 41);
            this.lblPriceDrink.Name = "lblPriceDrink";
            this.lblPriceDrink.Size = new System.Drawing.Size(31, 13);
            this.lblPriceDrink.TabIndex = 12;
            this.lblPriceDrink.Text = "Price";
            // 
            // lblNameDrink
            // 
            this.lblNameDrink.AutoSize = true;
            this.lblNameDrink.Location = new System.Drawing.Point(11, 15);
            this.lblNameDrink.Name = "lblNameDrink";
            this.lblNameDrink.Size = new System.Drawing.Size(35, 13);
            this.lblNameDrink.TabIndex = 11;
            this.lblNameDrink.Text = "Name";
            // 
            // txtNameDrink
            // 
            this.txtNameDrink.Location = new System.Drawing.Point(101, 12);
            this.txtNameDrink.Name = "txtNameDrink";
            this.txtNameDrink.Size = new System.Drawing.Size(171, 20);
            this.txtNameDrink.TabIndex = 7;
            // 
            // txtPriceDrink
            // 
            this.txtPriceDrink.Location = new System.Drawing.Point(101, 38);
            this.txtPriceDrink.Name = "txtPriceDrink";
            this.txtPriceDrink.Size = new System.Drawing.Size(100, 20);
            this.txtPriceDrink.TabIndex = 8;
            // 
            // btnSaveDrink
            // 
            this.btnSaveDrink.Location = new System.Drawing.Point(101, 79);
            this.btnSaveDrink.Name = "btnSaveDrink";
            this.btnSaveDrink.Size = new System.Drawing.Size(75, 23);
            this.btnSaveDrink.TabIndex = 10;
            this.btnSaveDrink.Text = "Save";
            this.btnSaveDrink.UseVisualStyleBackColor = true;
            this.btnSaveDrink.Click += new System.EventHandler(this.btnSaveDrink_Click);
            // 
            // AddDrinks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 113);
            this.Controls.Add(this.lblPriceDrink);
            this.Controls.Add(this.lblNameDrink);
            this.Controls.Add(this.txtNameDrink);
            this.Controls.Add(this.txtPriceDrink);
            this.Controls.Add(this.btnSaveDrink);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "AddDrinks";
            this.Text = "AddDrinks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPriceDrink;
        private System.Windows.Forms.Label lblNameDrink;
        private System.Windows.Forms.TextBox txtNameDrink;
        private System.Windows.Forms.TextBox txtPriceDrink;
        private System.Windows.Forms.Button btnSaveDrink;
    }
}