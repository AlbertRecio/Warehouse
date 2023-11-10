namespace Warehouse
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.masterFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.warehouseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryTransactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockAdjustmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockTransferToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.passwordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePassswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stringBuilderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masterFilesToolStripMenuItem,
            this.inventoryTransactionToolStripMenuItem,
            this.userToolStripMenuItem,
            this.modulesToolStripMenuItem,
            this.passwordToolStripMenuItem,
            this.stringBuilderToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // masterFilesToolStripMenuItem
            // 
            this.masterFilesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoryToolStripMenuItem,
            this.categoryToolStripMenuItem1,
            this.warehouseToolStripMenuItem});
            this.masterFilesToolStripMenuItem.Name = "masterFilesToolStripMenuItem";
            this.masterFilesToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.masterFilesToolStripMenuItem.Text = "Master Files";
            this.masterFilesToolStripMenuItem.Click += new System.EventHandler(this.MasterFilesToolStripMenuItem_Click);
            // 
            // categoryToolStripMenuItem
            // 
            this.categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
            this.categoryToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.categoryToolStripMenuItem.Text = "Items";
            this.categoryToolStripMenuItem.Click += new System.EventHandler(this.CategoryToolStripMenuItem_Click);
            // 
            // categoryToolStripMenuItem1
            // 
            this.categoryToolStripMenuItem1.Name = "categoryToolStripMenuItem1";
            this.categoryToolStripMenuItem1.Size = new System.Drawing.Size(133, 22);
            this.categoryToolStripMenuItem1.Text = "Category";
            this.categoryToolStripMenuItem1.Click += new System.EventHandler(this.CategoryToolStripMenuItem1_Click);
            // 
            // warehouseToolStripMenuItem
            // 
            this.warehouseToolStripMenuItem.Name = "warehouseToolStripMenuItem";
            this.warehouseToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.warehouseToolStripMenuItem.Text = "Warehouse";
            this.warehouseToolStripMenuItem.Click += new System.EventHandler(this.WarehouseToolStripMenuItem_Click);
            // 
            // inventoryTransactionToolStripMenuItem
            // 
            this.inventoryTransactionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stockInToolStripMenuItem,
            this.stockOutToolStripMenuItem,
            this.stockAdjustmentToolStripMenuItem,
            this.stockTransferToolStripMenuItem});
            this.inventoryTransactionToolStripMenuItem.Name = "inventoryTransactionToolStripMenuItem";
            this.inventoryTransactionToolStripMenuItem.Size = new System.Drawing.Size(132, 20);
            this.inventoryTransactionToolStripMenuItem.Text = "Inventory Transaction";
            // 
            // stockInToolStripMenuItem
            // 
            this.stockInToolStripMenuItem.Name = "stockInToolStripMenuItem";
            this.stockInToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.stockInToolStripMenuItem.Text = "Stock In";
            this.stockInToolStripMenuItem.Click += new System.EventHandler(this.StockInToolStripMenuItem_Click);
            // 
            // stockOutToolStripMenuItem
            // 
            this.stockOutToolStripMenuItem.Name = "stockOutToolStripMenuItem";
            this.stockOutToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.stockOutToolStripMenuItem.Text = "Stock Out";
            this.stockOutToolStripMenuItem.Click += new System.EventHandler(this.StockOutToolStripMenuItem_Click);
            // 
            // stockAdjustmentToolStripMenuItem
            // 
            this.stockAdjustmentToolStripMenuItem.Name = "stockAdjustmentToolStripMenuItem";
            this.stockAdjustmentToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.stockAdjustmentToolStripMenuItem.Text = "Stock Adjustment";
            this.stockAdjustmentToolStripMenuItem.Click += new System.EventHandler(this.stockAdjustmentToolStripMenuItem_Click);
            // 
            // stockTransferToolStripMenuItem
            // 
            this.stockTransferToolStripMenuItem.Name = "stockTransferToolStripMenuItem";
            this.stockTransferToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.stockTransferToolStripMenuItem.Text = "Stock Transfer";
            this.stockTransferToolStripMenuItem.Click += new System.EventHandler(this.stockTransferToolStripMenuItem_Click);
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUserToolStripMenuItem});
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.userToolStripMenuItem.Text = "User";
            // 
            // addUserToolStripMenuItem
            // 
            this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            this.addUserToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.addUserToolStripMenuItem.Text = "Add User";
            this.addUserToolStripMenuItem.Click += new System.EventHandler(this.addUserToolStripMenuItem_Click);
            // 
            // modulesToolStripMenuItem
            // 
            this.modulesToolStripMenuItem.Name = "modulesToolStripMenuItem";
            this.modulesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.modulesToolStripMenuItem.Text = "Modules";
            this.modulesToolStripMenuItem.Click += new System.EventHandler(this.modulesToolStripMenuItem_Click);
            // 
            // passwordToolStripMenuItem
            // 
            this.passwordToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changePassswordToolStripMenuItem,
            this.accountToolStripMenuItem});
            this.passwordToolStripMenuItem.Name = "passwordToolStripMenuItem";
            this.passwordToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.passwordToolStripMenuItem.Text = "Password";
            // 
            // changePassswordToolStripMenuItem
            // 
            this.changePassswordToolStripMenuItem.Name = "changePassswordToolStripMenuItem";
            this.changePassswordToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.changePassswordToolStripMenuItem.Text = "Change Passsword";
            this.changePassswordToolStripMenuItem.Click += new System.EventHandler(this.changePassswordToolStripMenuItem_Click);
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.accountToolStripMenuItem.Text = "Account";
            this.accountToolStripMenuItem.Click += new System.EventHandler(this.accountToolStripMenuItem_Click);
            // 
            // stringBuilderToolStripMenuItem
            // 
            this.stringBuilderToolStripMenuItem.Name = "stringBuilderToolStripMenuItem";
            this.stringBuilderToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.stringBuilderToolStripMenuItem.Text = "Logout";
            this.stringBuilderToolStripMenuItem.Click += new System.EventHandler(this.stringBuilderToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem masterFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoryToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem warehouseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryTransactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockAdjustmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockTransferToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modulesToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem passwordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePassswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stringBuilderToolStripMenuItem;
    }
}