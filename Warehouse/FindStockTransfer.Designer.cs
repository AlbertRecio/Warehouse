
namespace Warehouse
{
    partial class FindStockTransfer
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxFilter = new System.Windows.Forms.ComboBox();
            this.stockTransferID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Warehouse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(273, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 165;
            this.label2.Text = "Search :";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(336, 39);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(181, 20);
            this.txtSearch.TabIndex = 164;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stockTransferID,
            this.reference,
            this.Warehouse});
            this.dataGridView2.Location = new System.Drawing.Point(18, 67);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(499, 215);
            this.dataGridView2.TabIndex = 163;
            this.dataGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellDoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(273, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 162;
            this.label3.Text = "Filter :";
            // 
            // cbxFilter
            // 
            this.cbxFilter.FormattingEnabled = true;
            this.cbxFilter.Items.AddRange(new object[] {
            "Reference",
            "Warehouse"});
            this.cbxFilter.Location = new System.Drawing.Point(336, 12);
            this.cbxFilter.Name = "cbxFilter";
            this.cbxFilter.Size = new System.Drawing.Size(181, 21);
            this.cbxFilter.TabIndex = 161;
            this.cbxFilter.Text = "Reference";
            this.cbxFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxFilter_KeyPress);
            // 
            // stockTransferID
            // 
            this.stockTransferID.DataPropertyName = "stockTransferID";
            this.stockTransferID.HeaderText = "stockTransferID";
            this.stockTransferID.Name = "stockTransferID";
            this.stockTransferID.ReadOnly = true;
            this.stockTransferID.Visible = false;
            // 
            // reference
            // 
            this.reference.DataPropertyName = "reference";
            this.reference.HeaderText = "Reference No.";
            this.reference.Name = "reference";
            this.reference.ReadOnly = true;
            // 
            // Warehouse
            // 
            this.Warehouse.DataPropertyName = "warehouse";
            this.Warehouse.HeaderText = "Warehouse";
            this.Warehouse.Name = "Warehouse";
            this.Warehouse.ReadOnly = true;
            // 
            // FindStockTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 302);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxFilter);
            this.Name = "FindStockTransfer";
            this.Text = "FindStockTransfer";
            this.Load += new System.EventHandler(this.FindStockTransfer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxFilter;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockTransferID;
        private System.Windows.Forms.DataGridViewTextBoxColumn reference;
        private System.Windows.Forms.DataGridViewTextBoxColumn Warehouse;
    }
}