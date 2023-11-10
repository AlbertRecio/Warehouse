using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Warehouse_BusinessLayer;

namespace Warehouse
{
    public partial class FrmMasterfile : Form
    {
        bool isnew = false;
        public FrmMasterfile()
        {
            InitializeComponent();
        }
        DataTable rightsMas = new warehouseBusinessLayer().RightsMasterFile(LoginForm.ID);
        private void Form1_Load(object sender, EventArgs e)
        {
            forcbx();

            Actioncontrol("Load");
            LoadDataBinding();
            MasterFileID_TextChanged(null, null);
            if (!string.IsNullOrEmpty(masterFileID.Text))
            {
                datagrid();
            }

            
            //if (!Convert.ToBoolean(DtBinding.Rows[0]["NEW"].ToString()))
            //{
            //    tsbNew.Enabled = false;
            //}
            //if (!Convert.ToBoolean(DtBinding.Rows[0]["EDIT"].ToString()))
            //{
            //    tsbEdit.Enabled = false;
            //}
            //if (!Convert.ToBoolean(DtBinding.Rows[0]["DELETE"].ToString()))
            //{
            //    tsbDelete.Enabled = false;
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
        private void forcbx()
        {
            DataTable dt = new warehouseBusinessLayer().SelectDataFromCat();
            cbxCategory.ValueMember = "categoryID";
            cbxCategory.DisplayMember = "description";
            cbxCategory.DataSource = dt;

        }
        private void Actioncontrol(String action)
        {
            if (action == "New")
            {
                txtWarehouseNo.Clear();
                txtDescription.Clear();
                txtRemarks.Clear();
                txtDescription.ReadOnly = false;
                txtRemarks.ReadOnly = false;
                cbxCategory.Enabled = true;
                ckbActive.Enabled = true;
                tsbSave.Enabled = true;
                tsbNew.Enabled = false;
                tsbEdit.Enabled = false;
                tsbRevert.Enabled = true;
                isnew = true;
                bindingNavigator1.Enabled = false;
                tsbPrint.Enabled = false;
                //datasource clear
                dataGridView1.DataSource = null;
                tsbDelete.Enabled = false;
                tsbFind.Enabled = false;
            }
            else if (action == "Save")
            {
                txtDescription.ReadOnly = true;
                txtRemarks.ReadOnly = true;
                cbxCategory.Enabled = false;
                ckbActive.Enabled = false;
                tsbSave.Enabled = false;
                tsbNew.Enabled = true;
                tsbEdit.Enabled = true;
                tsbRevert.Enabled = false;
                isnew = false;
                bindingNavigator1.Enabled = true;
                tsbPrint.Enabled = true;
                tsbDelete.Enabled = true;
                tsbFind.Enabled = true;
            }
            else if (action == "Edit")
            {
                txtDescription.ReadOnly = false;
                txtRemarks.ReadOnly = false;
                cbxCategory.Enabled = true;
                ckbActive.Enabled = true;
                tsbSave.Enabled = true;
                tsbNew.Enabled = false;
                tsbEdit.Enabled = false;
                tsbRevert.Enabled = true;
                isnew = false;
                bindingNavigator1.Enabled = false;
                tsbPrint.Enabled = false;
                tsbDelete.Enabled = false;
                tsbFind.Enabled = false;
            }
            else if (action == "Load")
            {
                txtWarehouseNo.ReadOnly = true;
                txtDescription.ReadOnly = true;
                txtRemarks.ReadOnly = true;
                cbxCategory.Enabled = false;
                ckbActive.Enabled = false;
                tsbSave.Enabled = false;
                tsbRevert.Enabled = false;
                masterFileID.Visible = false;
                dataGridView1.ReadOnly = true;
            }
            else if (action == "Revert")
            {
                txtDescription.ReadOnly = true;
                txtRemarks.ReadOnly = true;
                cbxCategory.Enabled = false;
                ckbActive.Enabled = false;
                tsbSave.Enabled = false;
                tsbNew.Enabled = true;
                tsbEdit.Enabled = true;
                tsbRevert.Enabled = false;
                isnew = false;
                bindingNavigator1.Enabled = true;
                tsbPrint.Enabled = true;
                tsbDelete.Enabled = true;
                tsbFind.Enabled = true;
            }
        }
        BindingSource bs;
        private void LoadDataBinding()
        {
            bs = new BindingSource();
            DataTable DtBinding = new warehouseBusinessLayer().SelectAllMaster();
            bs.DataSource = DtBinding;
            bindingNavigator1.BindingSource = bs;
            bs.Position = DtBinding.Rows.Count;
            //bindposition(UserID.Text);
            masterFileID.DataBindings.Clear();
            masterFileID.DataBindings.Add(new Binding("Text", bs, "masterID", true));
        }
        private void datagrid() {
            DataTable data = new warehouseBusinessLayer().Warehousemasterfile
            (Guid.Parse(masterFileID.Text), Guid.Parse(cbxCategory.SelectedValue.ToString()));
            dataGridView1.DataSource = data;
            this.dataGridView1.Columns["onHand"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void MasterFileID_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(masterFileID.Text))
            {
                DataTable dt = new warehouseBusinessLayer().SelectDataFromMasterID(Guid.Parse(masterFileID.Text));
                foreach (DataRow row in dt.Rows)
                {
                    //textbox output
                    txtWarehouseNo.Text = row["Code"].ToString();
                    txtDescription.Text = row["description"].ToString();
                    cbxCategory.SelectedValue = Guid.Parse(row["CategoryID"].ToString());
                    ckbActive.Checked = Convert.ToBoolean(row["isActive"].ToString());
                    txtRemarks.Text = row["Remarks"].ToString();
                }
                datagrid();
            }
        }

   
     

        private void cbxCategory_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }



        private void tsbNew_Click_1(object sender, EventArgs e)
        {
            if (!Convert.ToBoolean(rightsMas.Rows[0]["NEW"].ToString()))
            {
                MessageBox.Show("Access Denied!", "Master File", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                cbxCategory.Text = "Select Category";
                Actioncontrol("New");
            }
        }

        private void tsbRevert_Click_1(object sender, EventArgs e)
        {
            forcbx();
            MasterFileID_TextChanged(null, null);
            LoadDataBinding();
            Actioncontrol("Revert");
        }

        private void tsbEdit_Click_1(object sender, EventArgs e)
        {
            if (!Convert.ToBoolean(rightsMas.Rows[0]["EDIT"].ToString()))
            {
                MessageBox.Show("Access Denied!", "Master File", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Actioncontrol("Edit");
            }
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            string msg = "";
            //check if empty
            if (txtDescription.Text == "")
            {
                msg += "Please Fill up Description\n";
            }
            if (cbxCategory.Text == "Select Category")
            {
                msg += "Please Select Category\n";
            }
            if (msg != "")
            {
                MessageBox.Show(msg);
                return;
            }

            //combobox insert new datatable
            DataTable dt = new DataTable();

            dt.Columns.Add("MasterFileID");
            dt.Columns.Add("Description");
            dt.Columns.Add("CatDescription");
            dt.Columns.Add("isActive");
            dt.Columns.Add("Remarks");
            dt.Columns.Add("Action");
            dt.Rows.Add();
            Guid _ID = isnew ? Guid.NewGuid() : new Guid(masterFileID.Text);
            dt.Rows[0]["MasterFileID"] = _ID;
            dt.Rows[0]["Description"] = txtDescription.Text;
            dt.Rows[0]["CatDescription"] = Guid.Parse(cbxCategory.SelectedValue.ToString());
            dt.Rows[0]["IsActive"] = ckbActive.Checked;
            dt.Rows[0]["Remarks"] = txtRemarks.Text;
            dt.Rows[0]["Action"] = isnew ? "New" : "Edit";
            if (!new warehouseBusinessLayer().checkIfExistMaster(_ID, txtDescription.Text, isnew ? "New" : "Edit"))
            {
                DataTable timeEventsID = new InsertBulkData_Management().InserBulk(dt, "InsertOrUpdateMaster", "@dt"); //INSERT BULKDATA

                Actioncontrol("Save");
                LoadDataBinding();
                MasterFileID_TextChanged(null, null);
                datagrid();
            }
            else
            {
                MessageBox.Show("Description is already Exist!");
            }
        }

        private void tsbFind_Click(object sender, EventArgs e)
        {
            if (!Convert.ToBoolean(rightsMas.Rows[0]["FIND"].ToString()))
            {
                MessageBox.Show("Access Denied!", "Master File", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FindMasterfile a = new FindMasterfile();
                a.ShowDialog();
                //get data galing sa datagrid sa ibang form
                if (a.ID != null)
                {
                    string b = a.ID;
                    masterFileID.Text = b;
                    //update kasama bs
                    int itemFound = bs.Find("masterID", b);
                    bs.Position = itemFound;
                    Actioncontrol("Find");
                }
            }
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            if (!Convert.ToBoolean(rightsMas.Rows[0]["DELETE"].ToString()))
            {
                MessageBox.Show("Access Denied!", "Master File", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Guid _ID = new Guid(masterFileID.Text);
                DialogResult dialogResult = MessageBox.Show("Are you sure want to delete this Warehouse?", "Delete Warehouse", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (!new warehouseBusinessLayer().checkIfUsedMasterfile(_ID))
                    {
                        new warehouseBusinessLayer().DeleteMasterfile(_ID);
                        MasterFileID_TextChanged(null, null);
                        LoadDataBinding();
                        MessageBox.Show("Item Successfully Deleted!");
                    }
                    else
                    {
                        MessageBox.Show("Item is already Used!");
                    }
                }
            }
        }

        private void tsbPrint_Click(object sender, EventArgs e)
        {
            if (!Convert.ToBoolean(rightsMas.Rows[0]["PRINT"].ToString()))
            {
                MessageBox.Show("Access Denied!", "Master File", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CRMasterfile asd = new CRMasterfile();
                DataTable dt = new warehouseBusinessLayer().printMasterfile();
                DataSet ds = new DataSet();
                dt.TableName = "tblMasterfile";
                ds.Tables.Add(dt);
                rptViewer rp = new rptViewer();
                rp.ds = ds;
                rp.CR = asd;
                rp.ShowDialog();
            }
        }
        public static DateTime DateStart { get; set; }
        public static DateTime DateEnd { get; set; }

        public static bool bol { get; set; }
        private void btnExport_Click(object sender, EventArgs e)
        {

                bol = false;
                PromptDate_MasterFile p = new PromptDate_MasterFile();
                p.ShowDialog();
                if (bol == true)
                    Export(Convert.ToDateTime(DateStart), Convert.ToDateTime(DateEnd));
        }
        public async void Export(DateTime DateStart, DateTime DateEnd)
        {
            //progressBar1.Style = ProgressBarStyle.Marquee;

            this.Enabled = false;
            Boolean closeme = await SampleFunction();
            this.Enabled = true;
            //new Thread(SampleFunction).Start();
        }
        DataTable dt; Stopwatch sw = new Stopwatch(); String countBranch = null;
        List<String> Success, Error; int CountSuccess, CountError; String Filenamess; bool success;
        async Task<bool> SampleFunction()
        {
            Boolean closeme = false;
            countBranch = null;

            //toolStripButton2.Enabled = false;


            dt = await new warehouseBusinessLayer().GetAllItemsByDATEforAPI(DateStart.Date, DateEnd.Date);

            if (dt.Rows.Count > 0)
            {

                List<API_Items> mList = new List<API_Items>();
                foreach (DataRow item in dt.Rows)
                {
                    API_Items i = new API_Items();
                    i.RowID = Guid.NewGuid();
                    mList.Add(i);

                }

                if (mList.Count > 0)
                {
                    success = await RequestAPI.InsertAPI<API_Items>(mList, "ItemsAPI/Update/");
                }
                if (success)
                {
                    MessageBox.Show("Export Success!");
                }
                else
                {
                    MessageBox.Show("Export Failed! \n" + RequestAPI.errorMSG);
                }

                closeme = true;

            }
            else
            {
                MessageBox.Show("No Data Found");

                CLEAR();

            }
            return closeme;
        }
        async void CLEAR()
        {
            await Task.Run(() => {
                //lblUpload.Visible = false;
                //statusStrip1.BackColor = Color.White;
                //progressBar1.Visible = false;
                //lbl1.Visible = false;
                //lbl2.Visible = false;
                //lbl3.Visible = false;
                //lbl4.Visible = false;
                //toolStripButton2.Enabled = true;
                ////  manualToolStrip.Enabled = true;
                //timer2.Enabled = false;
                //lblElapsed.Visible = false;

                Application.DoEvents();
            });

        }
    }
}
