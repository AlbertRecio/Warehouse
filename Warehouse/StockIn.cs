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
    public partial class StockIn : Form
    {
        bool isnew = false;
        bool isedit = false;
        public StockIn()
        {
            InitializeComponent();
        }
        DataTable rightsSIn = new warehouseBusinessLayer().RightsStockIn(LoginForm.ID);
        private void StockIn_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;

            forcbx();

            Actioncontrol("Load");
            LoadDataBinding();
            StockInID_TextChanged(null, null);
            totalReceived();
            
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
        private void totalReceived()
        {
            double sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                sum += Convert.ToDouble(dataGridView1.Rows[i].Cells["Received"].Value);
            }
            txtTotal.Text = sum.ToString("N2");
        }
        private void forcbx()
        {
            DataTable dt = new warehouseBusinessLayer().SelectDataFromWar();
            cbxWarehouse.ValueMember = "warehouseID";
            cbxWarehouse.DisplayMember = "description";
            cbxWarehouse.DataSource = dt;
        }
        private void Actioncontrol(String action)
        {
            if (action == "New")
            {
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
                tsbVerify.Enabled = false;
                btnFind.Enabled = true;
                tsbFind.Enabled = false;
                tsbVerify.Enabled = true;
                ckbVerify.Checked = false;
                readonlyDatacol();
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
                isedit = false;

                bindingNavigator1.Enabled = true;
                tsbVerify.Enabled = true;
                btnFind.Enabled = false;
                tsbFind.Enabled = true;
                tsbVerify.Enabled = false;
                ckbVerify.Checked = false;
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
                tsbVerify.Enabled = false;
                btnFind.Enabled = true;
                tsbFind.Enabled = false;
                tsbVerify.Enabled = true;
                readonlyDatacol();
            }
            else if (action == "Load")
            {
                Verified();
                StockInID.Visible = false;
                isedit = false;
                dataGridView1.ReadOnly = true;
                cbxWarehouse.Enabled = false;
                txtRemarks.ReadOnly = true;
                txtRefNo.ReadOnly = true;
                tsbSave.Enabled = false;
                tsbRevert.Enabled = false;
                btnFind.Enabled = false;
                txtTotal.ReadOnly = true;
                tsbVerify.Enabled = false;
                if (dataGridView1.Rows != null)
                {
                    cbxWarehouse.Enabled = false;
                }
                ckbVerify.AutoCheck = false;

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
                tsbVerify.Enabled = true;
                btnFind.Enabled = false;
                tsbFind.Enabled = true;
                tsbVerify.Enabled = false;
            }
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
        BindingSource bs;
        private void LoadDataBinding()
        {
            bs = new BindingSource();
            DataTable DtBinding = new warehouseBusinessLayer().SelectAllReceive();
            bs.DataSource = DtBinding;
            bindingNavigator1.BindingSource = bs;
            bs.Position = DtBinding.Rows.Count;

            //bindposition(UserID.Text);
            StockInID.DataBindings.Clear();
            StockInID.DataBindings.Add(new Binding("Text", bs, "receivingID", true));
            
        }
        private void StockInID_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(StockInID.Text))
            {
                DataTable dt = new warehouseBusinessLayer().SelectDataFromStockID(Guid.Parse(StockInID.Text));
                foreach (DataRow row in dt.Rows)
                {
                    //textbox output
                    txtRefNo.Text = row["reference"].ToString();
                    txtRemarks.Text = row["remarks"].ToString();
                    cbxWarehouse.SelectedValue = Guid.Parse(row["warehouseID"].ToString());
                    lblDate.Text = row["Date"].ToString();
                    ckbVerify.Checked = Convert.ToBoolean(row["isVerified"].ToString());
                    lblDateVerified.Text = row["dateVerified"].ToString();
                    lblTransact.Text = row["transact"].ToString();
                    //txtRefNo.Text = row["ReferenceNo"].ToString();
                }
                datagrid();
            }
            totalReceived();
            Verified();
        }
        private void datagrid()
        {
            DataTable data = new warehouseBusinessLayer().ReceiveDtl(Guid.Parse(StockInID.Text));

            int count = 0;
            dataGridView1.Rows.Clear();
            foreach (DataRow item in data.Rows)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[count].Cells[Description.Index].Value = item["description"];
                dataGridView1.Rows[count].Cells[OnHand.Index].Value = item["onHand"];
                dataGridView1.Rows[count].Cells[Received.Index].Value = item["received"];
                dataGridView1.Rows[count].Cells[masterID.Index].Value = item["masterID"];
                count++;
            }
            //dataGridView1.DataSource = data;
            //this.dataGridView1.Columns["onHand"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            //this.dataGridView1.Columns["Received"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        DataTable getdatafromgridview(Guid receiveno)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("RecevingDTL_ID");
            dt.Columns.Add("receivingID");
            dt.Columns.Add("masterID");
            dt.Columns.Add("onhand");
            dt.Columns.Add("received");
            dt.Columns.Add("Action");
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                if (item.Cells["masterID"].Value != null)
                {
                    DataRow dr = dt.NewRow();

                    dr["RecevingDTL_ID"] = Guid.NewGuid();
                    dr["receivingID"] = receiveno;
                    dr["masterID"] = Guid.Parse(item.Cells["masterID"].Value.ToString());
                    dr["onhand"] = decimal.Parse(item.Cells["onhand"].Value.ToString());
                    dr["received"] = decimal.Parse(item.Cells["received"].Value.ToString());
                    dr["Action"] = isnew ? "New" : "Edit";
                    dt.Rows.Add(dr);
                }
            }
            return dt;


        }
        private void TxtFind_Click(object sender, EventArgs e)
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
                DataTable dt = new warehouseBusinessLayer().stockin(vars, Guid.Parse(cbxWarehouse.SelectedValue.ToString()));

                if (!checkifexist(vars))
                { 
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[counter].Cells["masterID"].Value = dt.Rows[0]["masterID"].ToString();
                    dataGridView1.Rows[counter].Cells["description"].Value = dt.Rows[0]["description"].ToString();
                    dataGridView1.Rows[counter].Cells["Onhand"].Value = dt.Rows[0]["OnHand"].ToString();
                    dataGridView1.Rows[counter].Cells["Received"].Value = Convert.ToDecimal("0").ToString("N2");
                    counter++;
                }
                else
                {
                    MessageBox.Show("Item is already exist in table.");
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

        bool checkifexist(Guid mastID)
        {
            bool temp = false;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["masterID"].Value != null)
                {
                    if (CompareValidator.myGuid(row.Cells["masterID"].Value.ToString()) == mastID)
                    {
                        temp = true;
                        break;
                    }
                }
                //More code here
            }
            return temp;
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
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
                            cbxWarehouse.Enabled = true;
                        }
                    }
                }
            }
            totalReceived();
        }

        private void tsbNew_Click_1(object sender, EventArgs e)
        {
            if (!Convert.ToBoolean(rightsSIn.Rows[0]["NEW"].ToString()))
            {
                MessageBox.Show("Access Denied!", "Stock In", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                cbxWarehouse.Text = "Select Warehouse";
                Actioncontrol("New");
            }

        }

        private void tsbSave_Click_1(object sender, EventArgs e)
        {
            dataGridView1.EndEdit();

            if (cbxWarehouse.Text == "Select Warehouse")
            {
                MessageBox.Show("Please Select Warehouse\n");
                return;
            }

            DataTable dt = new DataTable();
            dt.Columns.Add("receivingID");
            dt.Columns.Add("warehouseID");
            dt.Columns.Add("date");
            //dt.Columns.Add("reference");
            dt.Columns.Add("Remarks");
            dt.Columns.Add("isVerified");
            dt.Columns.Add("dateVerified");
            dt.Columns.Add("trasnsact");
            dt.Columns.Add("Action");
            dt.Rows.Add();

            Guid receiveno = isnew ? Guid.NewGuid() : CompareValidator.myGuid(StockInID.Text);

            dt.Rows[0]["receivingID"] = receiveno;
            dt.Rows[0]["warehouseID"] = Guid.Parse(cbxWarehouse.SelectedValue.ToString());
            dt.Rows[0]["date"] = DateTime.Now;
            dt.Rows[0]["Remarks"] = txtRemarks.Text;
            dt.Rows[0]["isVerified"] = ckbVerify.Checked;
            dt.Rows[0]["dateVerified"] = lblDateVerified.Text;
            dt.Rows[0]["trasnsact"] = LoginForm.Name;
            dt.Rows[0]["Action"] = isnew ? "New" : "Edit";

            new InsertBulkData_Management().InserBulk(dt, "InsertOrUpdateStock", "@dt");

            DataTable DTL_DATA = getdatafromgridview(receiveno);

            new InsertBulkData_Management().InserBulkWithParam(DTL_DATA, receiveno, "InsertOrUpdateStockDtl", "@dt", "@id");

            Actioncontrol("Save");
            LoadDataBinding();
            StockInID_TextChanged(null, null);
            totalReceived();
        }

        private void tsbEdit_Click_1(object sender, EventArgs e)
        {
            if (!Convert.ToBoolean(rightsSIn.Rows[0]["EDIT"].ToString()))
            {
                MessageBox.Show("Access Denied!", "Stock In", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Actioncontrol("Edit");
            }
        }
        private void readonlyDatacol() {
            int n = Convert.ToInt32(dataGridView1.Rows.Count.ToString());
            for (int i = 0; i < n; i++)
            {
                dataGridView1.Rows[i].Cells[0].ReadOnly = true;
                dataGridView1.Rows[i].Cells[1].ReadOnly = true;
            }
        }
        private void tsbRevert_Click_1(object sender, EventArgs e)
        {
            Actioncontrol("Revert");
            forcbx();
            StockInID_TextChanged(null, null);
            LoadDataBinding();
            totalReceived();
        }

        private void tsbFind_Click_1(object sender, EventArgs e)
        {
            if (!Convert.ToBoolean(rightsSIn.Rows[0]["FIND"].ToString()))
            {
                MessageBox.Show("Access Denied!", "Stock In", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FindStockIn a = new FindStockIn();
                a.ShowDialog();

                //get data galing sa datagrid sa ibang form
                if (a.ID != null)
                {
                    string b = a.ID;
                    StockInID.Text = b;
                    //update kasama bs
                    int itemFound = bs.Find("receivingID", b);
                    bs.Position = itemFound;
                    cbxWarehouse.Enabled = false;
                }
                totalReceived();
            }
        }

        private void cbxWarehouse_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dg = sender as DataGridView;
            string tb = null;
            int col = dg.CurrentCell.ColumnIndex;
            tb = dg.CurrentRow.Cells[col].Value.ToString();
            int n;
            bool isNumeric = int.TryParse(tb, out n);

            if (isNumeric) {
                if (e.ColumnIndex == 2) {
                    if (e.RowIndex >= 0) {
                        totalReceived();
                    }
                }
                dg.CurrentRow.Cells[col].Value = Convert.ToDecimal(tb).ToString("N2");
            }
            else
            {
                MessageBox.Show("Enter a Number!");
                dg.CurrentRow.Cells[col].Value = 0.00;
            }
            

        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

            if (e.ColumnIndex == 4)
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

        private void tsbPrint_Click_1(object sender, EventArgs e)
        {
            if (!Convert.ToBoolean(rightsSIn.Rows[0]["PRINT"].ToString()))
            {
                MessageBox.Show("Access Denied!", "Stock In", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CRStockIn asd = new CRStockIn();
                DataTable dt = new warehouseBusinessLayer().printStockIn();
                DataSet ds = new DataSet();
                dt.TableName = "tblReceiving";
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

        private void toolStripSeparator6_Click(object sender, EventArgs e)
        {

        }
    }
}
