
namespace Warehouse
{
    partial class StockAdjustment
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockAdjustment));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbRevert = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbFind = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbPrint = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbVerify = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxWarehouse = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRefNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.StockAdjustmentID = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.masterID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OnHand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddorMinus = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.ckbVerify = new System.Windows.Forms.CheckBox();
            this.lblDateVerified = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTransact = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNew,
            this.toolStripSeparator5,
            this.tsbSave,
            this.toolStripSeparator3,
            this.tsbEdit,
            this.toolStripSeparator1,
            this.tsbRevert,
            this.toolStripSeparator4,
            this.tsbFind,
            this.toolStripSeparator2,
            this.tsbPrint,
            this.toolStripSeparator6,
            this.tsbVerify});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(489, 56);
            this.toolStrip1.TabIndex = 193;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbNew
            // 
            this.tsbNew.AutoSize = false;
            this.tsbNew.Image = global::Warehouse.Properties.Resources.New;
            this.tsbNew.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNew.Name = "tsbNew";
            this.tsbNew.Size = new System.Drawing.Size(60, 50);
            this.tsbNew.Text = "New";
            this.tsbNew.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbNew.Click += new System.EventHandler(this.tsbNew_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 56);
            // 
            // tsbSave
            // 
            this.tsbSave.AutoSize = false;
            this.tsbSave.Image = global::Warehouse.Properties.Resources.save;
            this.tsbSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(60, 50);
            this.tsbSave.Text = "Save";
            this.tsbSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbSave.Click += new System.EventHandler(this.tsbSave_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 56);
            // 
            // tsbEdit
            // 
            this.tsbEdit.AutoSize = false;
            this.tsbEdit.Image = global::Warehouse.Properties.Resources.edit;
            this.tsbEdit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEdit.Name = "tsbEdit";
            this.tsbEdit.Size = new System.Drawing.Size(60, 50);
            this.tsbEdit.Text = "Edit";
            this.tsbEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbEdit.Click += new System.EventHandler(this.tsbEdit_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 56);
            // 
            // tsbRevert
            // 
            this.tsbRevert.AutoSize = false;
            this.tsbRevert.Image = global::Warehouse.Properties.Resources.revert;
            this.tsbRevert.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbRevert.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRevert.Name = "tsbRevert";
            this.tsbRevert.Size = new System.Drawing.Size(60, 50);
            this.tsbRevert.Text = "Revert";
            this.tsbRevert.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbRevert.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbRevert.Click += new System.EventHandler(this.tsbRevert_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 56);
            // 
            // tsbFind
            // 
            this.tsbFind.AutoSize = false;
            this.tsbFind.Image = global::Warehouse.Properties.Resources.Find;
            this.tsbFind.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbFind.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFind.Name = "tsbFind";
            this.tsbFind.Size = new System.Drawing.Size(60, 50);
            this.tsbFind.Text = "Find";
            this.tsbFind.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbFind.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbFind.Click += new System.EventHandler(this.tsbFind_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 56);
            // 
            // tsbPrint
            // 
            this.tsbPrint.AutoSize = false;
            this.tsbPrint.Image = global::Warehouse.Properties.Resources.print;
            this.tsbPrint.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPrint.Name = "tsbPrint";
            this.tsbPrint.Size = new System.Drawing.Size(60, 50);
            this.tsbPrint.Text = "Print";
            this.tsbPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbPrint.Click += new System.EventHandler(this.tsbPrint_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 56);
            // 
            // tsbVerify
            // 
            this.tsbVerify.AutoSize = false;
            this.tsbVerify.Image = global::Warehouse.Properties.Resources.verify;
            this.tsbVerify.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbVerify.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbVerify.Name = "tsbVerify";
            this.tsbVerify.Size = new System.Drawing.Size(60, 50);
            this.tsbVerify.Text = "Verify";
            this.tsbVerify.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbVerify.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbVerify.Click += new System.EventHandler(this.tsbVerify_Click);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.AutoSize = false;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.toolStripButton7,
            this.toolStripButton8});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 56);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(488, 22);
            this.bindingNavigator1.TabIndex = 192;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 19);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 19);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 19);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 22);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 22);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 19);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 19);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 22);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(23, 19);
            this.toolStripButton7.Text = "Refresh";
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Size = new System.Drawing.Size(23, 19);
            this.toolStripButton8.Text = "toolStripButton3";
            this.toolStripButton8.Visible = false;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(358, 106);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(65, 13);
            this.lblDate.TabIndex = 207;
            this.lblDate.Text = "01/01/1991";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.Control;
            this.btnAdd.Image = global::Warehouse.Properties.Resources.icons8_add_tag_30;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(12, 177);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 44);
            this.btnAdd.TabIndex = 206;
            this.btnAdd.Text = "Add Item";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(317, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 205;
            this.label4.Text = "Date :";
            // 
            // cbxWarehouse
            // 
            this.cbxWarehouse.FormattingEnabled = true;
            this.cbxWarehouse.Location = new System.Drawing.Point(118, 146);
            this.cbxWarehouse.Name = "cbxWarehouse";
            this.cbxWarehouse.Size = new System.Drawing.Size(183, 21);
            this.cbxWarehouse.TabIndex = 204;
            this.cbxWarehouse.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxWarehouse_KeyPress);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(28, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 18);
            this.label5.TabIndex = 203;
            this.label5.Text = "Reference No. :";
            // 
            // txtRefNo
            // 
            this.txtRefNo.Location = new System.Drawing.Point(118, 120);
            this.txtRefNo.Name = "txtRefNo";
            this.txtRefNo.Size = new System.Drawing.Size(80, 20);
            this.txtRefNo.TabIndex = 201;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 202;
            this.label3.Text = "Warehouse :";
            // 
            // StockAdjustmentID
            // 
            this.StockAdjustmentID.AutoSize = true;
            this.StockAdjustmentID.Location = new System.Drawing.Point(409, 137);
            this.StockAdjustmentID.Name = "StockAdjustmentID";
            this.StockAdjustmentID.Size = new System.Drawing.Size(0, 13);
            this.StockAdjustmentID.TabIndex = 200;
            this.StockAdjustmentID.TextChanged += new System.EventHandler(this.StockAdjustmentID_TextChanged);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(370, 426);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(108, 20);
            this.txtTotal.TabIndex = 212;
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(69, 430);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(217, 67);
            this.txtRemarks.TabIndex = 211;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(315, 431);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 210;
            this.label2.Text = "Total In :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 433);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 209;
            this.label1.Text = "Remarks :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masterID,
            this.Description,
            this.OnHand,
            this.AddorMinus,
            this.Value,
            this.Delete});
            this.dataGridView1.Location = new System.Drawing.Point(12, 227);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(466, 194);
            this.dataGridView1.TabIndex = 208;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridView1_CellPainting);
            // 
            // masterID
            // 
            this.masterID.DataPropertyName = "masterID";
            this.masterID.HeaderText = "masterID";
            this.masterID.Name = "masterID";
            this.masterID.Visible = false;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "description";
            this.Description.FillWeight = 99.61929F;
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // OnHand
            // 
            this.OnHand.DataPropertyName = "Onhand";
            this.OnHand.FillWeight = 99.61929F;
            this.OnHand.HeaderText = "OnHand";
            this.OnHand.Name = "OnHand";
            this.OnHand.ReadOnly = true;
            // 
            // AddorMinus
            // 
            this.AddorMinus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.AddorMinus.DataPropertyName = "adjustment";
            this.AddorMinus.FillWeight = 101.5228F;
            this.AddorMinus.HeaderText = "+/-";
            this.AddorMinus.Items.AddRange(new object[] {
            "+",
            "-"});
            this.AddorMinus.Name = "AddorMinus";
            this.AddorMinus.Width = 50;
            // 
            // Value
            // 
            this.Value.DataPropertyName = "value";
            this.Value.FillWeight = 99.61929F;
            this.Value.HeaderText = "Value";
            this.Value.Name = "Value";
            // 
            // Delete
            // 
            this.Delete.FillWeight = 99.61929F;
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(112, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 18);
            this.label6.TabIndex = 214;
            this.label6.Text = "Reason :";
            // 
            // txtReason
            // 
            this.txtReason.Location = new System.Drawing.Point(170, 201);
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(178, 20);
            this.txtReason.TabIndex = 213;
            // 
            // ckbVerify
            // 
            this.ckbVerify.AutoSize = true;
            this.ckbVerify.Location = new System.Drawing.Point(320, 145);
            this.ckbVerify.Name = "ckbVerify";
            this.ckbVerify.Size = new System.Drawing.Size(61, 17);
            this.ckbVerify.TabIndex = 215;
            this.ckbVerify.Text = "Verified";
            this.ckbVerify.UseVisualStyleBackColor = true;
            // 
            // lblDateVerified
            // 
            this.lblDateVerified.AutoSize = true;
            this.lblDateVerified.Location = new System.Drawing.Point(387, 164);
            this.lblDateVerified.Name = "lblDateVerified";
            this.lblDateVerified.Size = new System.Drawing.Size(0, 13);
            this.lblDateVerified.TabIndex = 223;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(387, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 222;
            this.label8.Text = "Date Verified";
            // 
            // lblTransact
            // 
            this.lblTransact.AutoSize = true;
            this.lblTransact.Location = new System.Drawing.Point(199, 177);
            this.lblTransact.Name = "lblTransact";
            this.lblTransact.Size = new System.Drawing.Size(0, 13);
            this.lblTransact.TabIndex = 228;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(112, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 227;
            this.label7.Text = "Transacted by :";
            // 
            // StockAdjustment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 506);
            this.Controls.Add(this.lblTransact);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblDateVerified);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ckbVerify);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtReason);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxWarehouse);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRefNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.StockAdjustmentID);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.bindingNavigator1);
            this.Name = "StockAdjustment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StockAdjustment";
            this.Load += new System.EventHandler(this.StockAdjustment_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbNew;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbRevert;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsbFind;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbPrint;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxWarehouse;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRefNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label StockAdjustmentID;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.DataGridViewTextBoxColumn masterID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn OnHand;
        private System.Windows.Forms.DataGridViewComboBoxColumn AddorMinus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton tsbVerify;
        private System.Windows.Forms.CheckBox ckbVerify;
        private System.Windows.Forms.Label lblDateVerified;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTransact;
        private System.Windows.Forms.Label label7;
    }
}