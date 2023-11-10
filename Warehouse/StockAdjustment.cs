using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Warehouse_BusinessLayer;

namespace Warehouse
{ 
    public partial class StockAdjustment : Form
    {
        bool isnew = false;
        bool isedit = false;

        public StockAdjustment()
        {
            InitializeComponent();
        }
        DataTable rightsSAdj = new warehouseBusinessLayer().RightsStockAdjustment(LoginForm.ID);
        private void StockAdjustment_Load(object sender, EventArgs e)
        {
            //para d na magload yung ibang columns
            dataGridView1.AutoGenerateColumns = false;

            //para sa combobox
            DataTable dt = new warehouseBusinessLayer().SelectDataFromWar();
            cbxWarehouse.ValueMember = "warehouseID";
            cbxWarehouse.DisplayMember = "description";
            cbxWarehouse.DataSource = dt;

            Actioncontrol("Load");
            LoadDataBinding();
            StockAdjustmentID_TextChanged(null, null);
            totalReleased(); 
            
            
            //if (!Convert.ToBoolean(DtBinding.Rows[0]["NEW"].ToString()))
            //{
            //    tsbNew.Enabled = false;
            //}
            //if (!Convert.ToBoolean(DtBinding.Rows[0]["EDIT"].ToString()))
            //{
            //    tsbEdit.Enabled = false;
            //}
            //if (!Convert.ToBoolean(DtBinding.Rows[0]["FIND"].ToString()))
            //{
            //    tsbFind.Enabled = false;
            //}
            //if (!Convert.ToBoolean(DtBinding.Rows[0]["PRINT"].ToString()))
            //{
            //    tsbPrint.Enabled = false;
            //}

        }
        private void totalReleased()
        {
            double sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                sum += Convert.ToDouble(dataGridView1.Rows[i].Cells["value"].Value);
            }
            txtTotal.Text = sum.ToString("N2");
        }
        private void Actioncontrol(String action)
        {
            if (action == "New")
            {
                txtReason.Clear();
                isedit = true;
                txtRefNo.Clear();
                txtRemarks.Clear();
                txtTotal.Clear();
                lblDate.Text = DateTime.Now.ToString();
                dataGridView1.Rows.Clear();
                dataGridView1.ReadOnly = false;
                txtRemarks.ReadOnly = false;
                cbxWarehouse.Enabled = true;
                tsbSave.Enabled = true;
                tsbNew.Enabled = false;
                tsbEdit.Enabled = false;
                tsbRevert.Enabled = true;
                isnew = true;
                bindingNavigator1.Enabled = false;
                tsbPrint.Enabled = false;
                btnAdd.Enabled = true;
                txtReason.ReadOnly = false;
                ckbVerify.Checked = false;
                readonlyDatacol();
                tsbVerify.Enabled = true;
                lblDateVerified.Text = "Not Yet Verified";
            }
            else if (action == "Save")
            {
                isedit = false;
                txtRemarks.ReadOnly = true;
                cbxWarehouse.Enabled = false;
                dataGridView1.ReadOnly = true;
                tsbSave.Enabled = false;
                tsbNew.Enabled = true;
                tsbEdit.Enabled = true;
                tsbRevert.Enabled = false;
                isnew = false;
                bindingNavigator1.Enabled = true;
                tsbPrint.Enabled = true;
                btnAdd.Enabled = false;
                txtReason.ReadOnly = true;
                tsbVerify.Enabled = false;
            }
            else if (action == "Edit")
            {
                isedit = true;
                dataGridView1.ReadOnly = false;
                txtRemarks.ReadOnly = false;
                if (dataGridView1.Rows.Count == 0)
                {
                    cbxWarehouse.Enabled = true;
                }
                else
                {
                    cbxWarehouse.Enabled = false;
                }
                tsbSave.Enabled = true;
                tsbNew.Enabled = false;
                tsbEdit.Enabled = false;
                tsbRevert.Enabled = true;
                isnew = false;
                bindingNavigator1.Enabled = false;
                tsbPrint.Enabled = false;
                btnAdd.Enabled = true;
                txtReason.ReadOnly = false;
                ckbVerify.Checked = false;
                tsbVerify.Enabled = true;
                readonlyDatacol();
            }
            else if (action == "Load")
            {
                isedit = false;
                dataGridView1.ReadOnly = true;
                cbxWarehouse.Enabled = false;
                txtRemarks.ReadOnly = true;
                txtRefNo.ReadOnly = true;
                tsbSave.Enabled = false;
                tsbRevert.Enabled = false;
                btnAdd.Enabled = false;
                StockAdjustmentID.Visible = false;
                txtTotal.ReadOnly = true;
                txtReason.ReadOnly = true;
                ckbVerify.AutoCheck = false;
                tsbVerify.Enabled = false;
                Verified();
            }
            else if (action == "Revert")
            {
                isedit = false;
                dataGridView1.ReadOnly = true;
                cbxWarehouse.Enabled = false;
                txtRemarks.ReadOnly = true;
                tsbSave.Enabled = false;
                tsbNew.Enabled = true;
                tsbEdit.Enabled = true;
                tsbRevert.Enabled = false;
                isnew = false;
                bindingNavigator1.Enabled = true;
                tsbPrint.Enabled = true;
                btnAdd.Enabled = false;
                txtReason.ReadOnly = true;
                tsbVerify.Enabled = false;
            }
        }
        //binding source
        BindingSource bs;
        private void LoadDataBinding()
        {
            bs = new BindingSource();
            DataTable DtBinding = new warehouseBusinessLayer().SelectAllAdjustment();
            bs.DataSource = DtBinding;
            bindingNavigator1.BindingSource = bs;
            bs.Position = DtBinding.Rows.Count;
            //bindposition(UserID.Text);
            StockAdjustmentID.DataBindings.Clear();
            StockAdjustmentID.DataBindings.Add(new Binding("Text", bs, "adjustmentID", true));

        }
        private void Verified()
        {
            if (ckbVerify.Checked)
            {
                tsbEdit.Enabled = false;
            }
            else
            {
                tsbEdit.Enabled = true;
            }
        }
        private void readonlyDatacol()
        {
            int n = Convert.ToInt32(dataGridView1.Rows.Count.ToString());
            for (int i = 0; i < n; i++)
            {
                dataGridView1.Rows[i].Cells[1].ReadOnly = true;
                dataGridView1.Rows[i].Cells[2].ReadOnly = true;
            }
        }

        private void StockAdjustmentID_TextChanged(object sender, EventArgs e)
        {
            //check nullorempty pag text lang
            if (!string.IsNullOrEmpty(StockAdjustmentID.Text))
            {
                //dalawa insert ng data isa para sa header isa para sa detail
                DataTable dt = new warehouseBusinessLayer().SelectDataFromStockAdjustmentID(Guid.Parse(StockAdjustmentID.Text));
                foreach (DataRow row in dt.Rows)
                {
                    //textbox output
                    txtRefNo.Text = row["reference"].ToString();
                    txtRemarks.Text = row["Remarks"].ToString();
                    cbxWarehouse.SelectedValue = Guid.Parse(row["warehouseID"].ToString());
                    lblDate.Text = row["Date"].ToString();
                    ckbVerify.Checked = Convert.ToBoolean(row["isVerified"].ToString());
                    lblDateVerified.Text = row["dateVerified"].ToString();
                    lblTransact.Text = row["transact"].ToString();
                    //txtRefNo.Text = row["ReferenceNo"].ToString();
                }
                datagrid();
            }
            totalReleased();
            Verified();
        }
        //for detail
        private void datagrid()
        {
            DataTable data = new warehouseBusinessLayer().SelectDataFromAdjustmentDtlID(Guid.Parse(StockAdjustmentID.Text));
            int count = 0;
            dataGridView1.Rows.Clear();
            foreach (DataRow item in data.Rows)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[count].Cells[masterID.Index].Value = item["masterID"];
                dataGridView1.Rows[count].Cells[Description.Index].Value = item["description"];
                dataGridView1.Rows[count].Cells[OnHand.Index].Value = item["onHand"];
                dataGridView1.Rows[count].Cells[AddorMinus.Index].Value = item["adjustment"];
                dataGridView1.Rows[count].Cells[Value.Index].Value = item["value"];
                count++;
            }
        }
        

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (isnew || isedit)
            {
                if (e.RowIndex != -1)
                {
                    if (e.ColumnIndex == dataGridView1.Columns["Delete"].Index)
                    {
                        dataGridView1.Rows.RemoveAt(e.RowIndex);
                        if (dataGridView1.Rows.Count == 0)
                        {
                            if (!isedit) 
                            {
                                cbxWarehouse.Enabled = true;
                            }
                        }
                    }
                }
            }
            totalReleased();
        }

        private void tsbNew_Click(object sender, EventArgs e)
        {
            if (!Convert.ToBoolean(rightsSAdj.Rows[0]["NEW"].ToString()))
            {
                MessageBox.Show("Access Denied!", "Stock Adjustment", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                cbxWarehouse.Text = "Select Warehouse";
                Actioncontrol("New");
            }
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            if (!Convert.ToBoolean(rightsSAdj.Rows[0]["EDIT"].ToString()))
            {
                MessageBox.Show("Access Denied!", "Stock Adjustment", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Actioncontrol("Edit");
            }
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            dataGridView1.EndEdit();

            string msg = "";
            //check if empty
            if (cbxWarehouse.Text == "Select Warehouse")
            {
                MessageBox.Show("Please Select Warehouse\n");
                return;
            }

            //new datatable
            DataTable dt = new DataTable();
            dt.Columns.Add("adjustmentID");
            dt.Columns.Add("warehouseID");
            dt.Columns.Add("date");
            //dt.Columns.Add("reference");
            dt.Columns.Add("Remarks");
            dt.Columns.Add("Reason");
            dt.Columns.Add("isVerified");
            dt.Columns.Add("dateVerified");
            dt.Columns.Add("transact");
            dt.Columns.Add("Action");

            dt.Rows.Add();
            //kuha data para insert sa datatable
            Guid adjustno = isnew ? Guid.NewGuid() : CompareValidator.myGuid(StockAdjustmentID.Text);
            //insert datatable
            dt.Rows[0]["adjustmentID"] = adjustno;
            dt.Rows[0]["warehouseID"] = Guid.Parse(cbxWarehouse.SelectedValue.ToString());
            dt.Rows[0]["date"] = DateTime.Now;
            dt.Rows[0]["Remarks"] = txtRemarks.Text;
            dt.Rows[0]["Reason"] = txtReason.Text;
            dt.Rows[0]["isVerified"] = ckbVerify.Checked;
            dt.Rows[0]["dateVerified"] = lblDateVerified.Text;
            dt.Rows[0]["transact"] = LoginForm.Name ;
            dt.Rows[0]["Action"] = isnew ? "New" : "Edit";

            new InsertBulkData_Management().InserBulk(dt, "InsertOrUpdateAdjustment", "@dt");

            DataTable DTL_DATA = getdatafromgridview(adjustno);


            new InsertBulkData_Management().InserBulkWithParam(DTL_DATA, adjustno, "InsertOrUpdateAdjustmentDtl", "@dt", "@id");

            Actioncontrol("Save");
            LoadDataBinding();
            StockAdjustmentID_TextChanged(null, null);
            totalReleased();
        }
        DataTable getdatafromgridview(Guid receiveno)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("AdjustmentDTL_ID");
            dt.Columns.Add("adjustmentID");
            dt.Columns.Add("masterID");
            dt.Columns.Add("onhand");
            dt.Columns.Add("adjustment");
            dt.Columns.Add("value");
            dt.Columns.Add("Action");
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                if (item.Cells["masterID"].Value != null)
                {
                    string x = item.Cells["masterID"].Value.ToString();
                    DataRow dr = dt.NewRow();
                    dr["AdjustmentDTL_ID"] = isnew ? Guid.NewGuid() : new Guid(StockAdjustmentID.Text);
                    dr["adjustmentID"] = receiveno;
                    dr["masterID"] = Guid.Parse(item.Cells["masterID"].Value.ToString());
                    dr["onhand"] = decimal.Parse(item.Cells["onhand"].Value.ToString());
                    dr["adjustment"] = item.Cells[AddorMinus.Index].Value.ToString();
                    dr["value"] = decimal.Parse(item.Cells["value"].Value.ToString());
                    dr["Action"] = isnew ? "New" : "Edit";
                    dt.Rows.Add(dr);


                }
            }
            return dt;
        }

        private void tsbRevert_Click(object sender, EventArgs e)
        {
            Actioncontrol("Revert");
            LoadDataBinding();
            StockAdjustmentID_TextChanged(null, null);
            totalReleased();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbxWarehouse.Text == "Select Warehouse")
            {
                string msg = "Please Select Warehouse\n";
                MessageBox.Show(msg);
                return;
            }

            FindItem a = new FindItem();
            a.warehouseid = Guid.Parse(cbxWarehouse.SelectedValue.ToString());
            a.ShowDialog();
            int counter = dataGridView1.RowCount;

            foreach (Guid vars in a.ID)
            {
                DataTable dt = new warehouseBusinessLayer().stockOut(vars, Guid.Parse(cbxWarehouse.SelectedValue.ToString()));
                if (!checkifexist(vars))
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[counter].Cells["masterID"].Value = dt.Rows[0]["masterID"].ToString();
                    dataGridView1.Rows[counter].Cells["Description"].Value = dt.Rows[0]["Description"].ToString();
                    dataGridView1.Rows[counter].Cells["Onhand"].Value = dt.Rows[0]["Onhand"].ToString();
                    dataGridView1.Rows[counter].Cells[AddorMinus.Index].Value = "+";
                    dataGridView1.Rows[counter].Cells["value"].Value = Convert.ToDecimal("0").ToString("N2");
                    counter++;
                }
            }
            readonlyDatacol();
            if (dataGridView1.Rows.Count == 0)
            {
                cbxWarehouse.Enabled = true;
            }
            else
            {
                cbxWarehouse.Enabled = false;
            }
        }
        bool checkifexist(Guid warehouseid)
        {
            bool temp = false;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["masterID"].Value != null)
                {
                    if (CompareValidator.myGuid(row.Cells["masterID"].Value.ToString()) == warehouseid)
                    {
                        temp = true;
                        break;
                    }
                }
                //More code here
            }
            return temp;
        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                if (e.RowIndex >= 0)
                {
                    e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                    var w = 17;
                    var h = 17;
                    var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                    var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;
                    e.Graphics.DrawImage(Properties.Resources.delete, new Rectangle(x, y, w, h));
                    e.Handled = true;
                }
            }
        }

        private void tsbFind_Click(object sender, EventArgs e)
        {
            if (!Convert.ToBoolean(rightsSAdj.Rows[0]["FIND"].ToString()))
            {
                MessageBox.Show("Access Denied!", "Stock Adjustment", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FindStockAdjustment a = new FindStockAdjustment();
                a.ShowDialog();
                //get data galing sa datagrid sa ibang form
                if (a.ID != null)
                {
                    string b = a.ID;
                    StockAdjustmentID.Text = b;
                    //update kasama bs
                    int itemFound = bs.Find("adjustmentID", b);
                    bs.Position = itemFound;
                }
                totalReleased();
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dg = sender as DataGridView;
            string tb = null;
            int col = dg.CurrentCell.ColumnIndex;
            string onhand = dg.CurrentRow.Cells[2].Value.ToString();
            tb = dg.CurrentRow.Cells[col].Value.ToString();
            string t = dg.CurrentRow.Cells[3].Value.ToString();
            string v = dg.CurrentRow.Cells[4].Value.ToString();
            int n;
            bool isNumeric = int.TryParse(tb, out n);
            if (e.ColumnIndex == 3) {
                dg.CurrentRow.Cells[4].Value = Convert.ToDecimal("0").ToString("N2");
                totalReleased();
            }
            if (col == 4)
            {
                if (t == "-")
                {

                    if (isNumeric)
                    {
                        if (e.ColumnIndex == 4)
                        {
                            if (e.RowIndex >= 0)
                            {
                                
                                if (Convert.ToDecimal(onhand) < Convert.ToDecimal(tb))
                                {
                                    dg.CurrentRow.Cells[col].Value = Convert.ToDecimal("0").ToString("N2");
                                    MessageBox.Show("Not Enough Supply!");
                                }
                                else
                                {
                                    dg.CurrentRow.Cells[col].Value = Convert.ToDecimal(tb).ToString("N2");
                                }
                                totalReleased();
                            }

                        }
                    }
                    else
                    {
                        MessageBox.Show("Enter a Number!");
                        dg.CurrentRow.Cells[col].Value = Convert.ToDecimal("0").ToString("N2");
                    }
                }
                else
                {
                    dg.CurrentRow.Cells[col].Value = Convert.ToDecimal(tb).ToString("N2");
                }
            }
        }

        private void cbxWarehouse_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void tsbPrint_Click(object sender, EventArgs e)
        {
            if (!Convert.ToBoolean(rightsSAdj.Rows[0]["PRINT"].ToString()))
            {
                MessageBox.Show("Access Denied!", "Stock Adjustment", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CRAdjustment asd = new CRAdjustment();
                DataTable dt = new warehouseBusinessLayer().printStockAdjustment();
                DataSet ds = new DataSet();
                dt.TableName = "tblAdjustment";
                ds.Tables.Add(dt);
                rptViewer rp = new rptViewer();
                rp.ds = ds;
                rp.CR = asd;
                rp.ShowDialog();
            }
        }

        private void tsbVerify_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to verify this?", "Verification", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                lblDateVerified.Text = DateTime.Now.ToString();
                ckbVerify.Checked = true;
            }
            else
            {
                lblDateVerified.Text = "Not Yet Verified";
                ckbVerify.Checked = false;
            }
        }
    }
}
