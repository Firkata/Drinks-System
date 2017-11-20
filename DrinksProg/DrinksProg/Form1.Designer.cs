namespace DrinksProg
{
    partial class Form1
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
            this.tabPanel = new System.Windows.Forms.TabControl();
            this.tabDrinks = new System.Windows.Forms.TabPage();
            this.tabExtras = new System.Windows.Forms.TabPage();
            this.listProducts = new System.Windows.Forms.ListBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.txtPay = new System.Windows.Forms.TextBox();
            this.lblAmountToPay = new System.Windows.Forms.Label();
            this.lblAmountGiven = new System.Windows.Forms.Label();
            this.txtGiven = new System.Windows.Forms.TextBox();
            this.lblChange = new System.Windows.Forms.Label();
            this.txtChange = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drinksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bulgarianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPanel
            // 
            this.tabPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tabPanel.Controls.Add(this.tabDrinks);
            this.tabPanel.Controls.Add(this.tabExtras);
            this.tabPanel.Location = new System.Drawing.Point(12, 31);
            this.tabPanel.Name = "tabPanel";
            this.tabPanel.SelectedIndex = 0;
            this.tabPanel.Size = new System.Drawing.Size(462, 446);
            this.tabPanel.TabIndex = 1;
            // 
            // tabDrinks
            // 
            this.tabDrinks.AutoScroll = true;
            this.tabDrinks.Location = new System.Drawing.Point(4, 22);
            this.tabDrinks.Name = "tabDrinks";
            this.tabDrinks.Size = new System.Drawing.Size(454, 420);
            this.tabDrinks.TabIndex = 0;
            this.tabDrinks.Text = "Drinks";
            this.tabDrinks.UseVisualStyleBackColor = true;
            // 
            // tabExtras
            // 
            this.tabExtras.Location = new System.Drawing.Point(4, 22);
            this.tabExtras.Name = "tabExtras";
            this.tabExtras.Size = new System.Drawing.Size(454, 420);
            this.tabExtras.TabIndex = 1;
            this.tabExtras.Text = "Extras";
            this.tabExtras.UseVisualStyleBackColor = true;
            // 
            // listProducts
            // 
            this.listProducts.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.listProducts.FormattingEnabled = true;
            this.listProducts.HorizontalScrollbar = true;
            this.listProducts.Location = new System.Drawing.Point(476, 44);
            this.listProducts.Name = "listProducts";
            this.listProducts.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listProducts.Size = new System.Drawing.Size(310, 433);
            this.listProducts.TabIndex = 2;
            this.listProducts.SelectedIndexChanged += new System.EventHandler(this.listProducts_SelectedIndexChanged);
            this.listProducts.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.FormatListItem);
            this.listProducts.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MousePress);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(656, 492);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(134, 50);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(543, 492);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(107, 50);
            this.btnPay.TabIndex = 4;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // txtPay
            // 
            this.txtPay.Location = new System.Drawing.Point(99, 508);
            this.txtPay.Name = "txtPay";
            this.txtPay.ReadOnly = true;
            this.txtPay.Size = new System.Drawing.Size(100, 20);
            this.txtPay.TabIndex = 5;
            // 
            // lblAmountToPay
            // 
            this.lblAmountToPay.AutoSize = true;
            this.lblAmountToPay.Location = new System.Drawing.Point(9, 511);
            this.lblAmountToPay.Name = "lblAmountToPay";
            this.lblAmountToPay.Size = new System.Drawing.Size(80, 13);
            this.lblAmountToPay.TabIndex = 6;
            this.lblAmountToPay.Text = "Amount To Pay";
            // 
            // lblAmountGiven
            // 
            this.lblAmountGiven.AutoSize = true;
            this.lblAmountGiven.Location = new System.Drawing.Point(205, 511);
            this.lblAmountGiven.Name = "lblAmountGiven";
            this.lblAmountGiven.Size = new System.Drawing.Size(74, 13);
            this.lblAmountGiven.TabIndex = 7;
            this.lblAmountGiven.Text = "Amount Given";
            // 
            // txtGiven
            // 
            this.txtGiven.Location = new System.Drawing.Point(285, 508);
            this.txtGiven.Name = "txtGiven";
            this.txtGiven.Size = new System.Drawing.Size(100, 20);
            this.txtGiven.TabIndex = 8;
            this.txtGiven.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiven_KeyPress);
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Location = new System.Drawing.Point(391, 511);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(44, 13);
            this.lblChange.TabIndex = 9;
            this.lblChange.Text = "Change";
            // 
            // txtChange
            // 
            this.txtChange.Location = new System.Drawing.Point(441, 508);
            this.txtChange.Name = "txtChange";
            this.txtChange.ReadOnly = true;
            this.txtChange.Size = new System.Drawing.Size(96, 20);
            this.txtChange.TabIndex = 10;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(803, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem,
            this.newCustomerToolStripMenuItem,
            this.addProductToolStripMenuItem});
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.dataToolStripMenuItem.Text = "Data";
            // 
            // newCustomerToolStripMenuItem
            // 
            this.newCustomerToolStripMenuItem.Name = "newCustomerToolStripMenuItem";
            this.newCustomerToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.newCustomerToolStripMenuItem.Text = "New Customer";
            this.newCustomerToolStripMenuItem.Click += new System.EventHandler(this.newCustomerToolStripMenuItem_Click);
            // 
            // addProductToolStripMenuItem
            // 
            this.addProductToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drinksToolStripMenuItem,
            this.extraToolStripMenuItem});
            this.addProductToolStripMenuItem.Name = "addProductToolStripMenuItem";
            this.addProductToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.addProductToolStripMenuItem.Text = "Add Product";
            // 
            // drinksToolStripMenuItem
            // 
            this.drinksToolStripMenuItem.Name = "drinksToolStripMenuItem";
            this.drinksToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.drinksToolStripMenuItem.Text = "Drink";
            this.drinksToolStripMenuItem.Click += new System.EventHandler(this.drinksToolStripMenuItem_Click);
            // 
            // extraToolStripMenuItem
            // 
            this.extraToolStripMenuItem.Name = "extraToolStripMenuItem";
            this.extraToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.extraToolStripMenuItem.Text = "Extra";
            this.extraToolStripMenuItem.Click += new System.EventHandler(this.extraToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.languageToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem,
            this.bulgarianToolStripMenuItem});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            this.languageToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.languageToolStripMenuItem.Text = "Language";
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.englishToolStripMenuItem.Text = "English";
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // bulgarianToolStripMenuItem
            // 
            this.bulgarianToolStripMenuItem.Name = "bulgarianToolStripMenuItem";
            this.bulgarianToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.bulgarianToolStripMenuItem.Text = "Bulgarian";
            this.bulgarianToolStripMenuItem.Click += new System.EventHandler(this.bulgarianToolStripMenuItem_Click);
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.openFileToolStripMenuItem.Text = "Open File...";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 549);
            this.Controls.Add(this.txtChange);
            this.Controls.Add(this.lblChange);
            this.Controls.Add(this.txtGiven);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.lblAmountGiven);
            this.Controls.Add(this.lblAmountToPay);
            this.Controls.Add(this.txtPay);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.listProducts);
            this.Controls.Add(this.tabPanel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Coffee Shop";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_FormLoad);
            this.tabPanel.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabPanel;
        private System.Windows.Forms.ListBox listProducts;
        private System.Windows.Forms.TabPage tabDrinks;
        private System.Windows.Forms.TabPage tabExtras;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.TextBox txtPay;
        private System.Windows.Forms.Label lblAmountToPay;
        private System.Windows.Forms.Label lblAmountGiven;
        private System.Windows.Forms.TextBox txtGiven;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.TextBox txtChange;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bulgarianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drinksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;

    }
}

