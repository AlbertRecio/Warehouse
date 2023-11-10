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
    public partial class Warehouse : Form
    {
        public Warehouse()
        {
            InitializeComponent();
        }

        private void Warehouse_Load(object sender, EventArgs e)
        {
            
            Actioncontrol("Load");
            LoadDataBinding();

            //DataTable DtBinding = new warehouseBusinessLayer().RightsWarehouse(LoginForm.ID);
            //if (!Convert.ToBoolean(DtBinding.Rows[0]["NEW"].ToString())) {
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
        bool isnew = false;
        private void Actioncontrol(String action)
        {
            if (action == "New")
            {
                txtWarehouseNo.Clear();
                txtDescription.Clear();
                txtRemarks.Clear();
                txtDescription.ReadOnly = false;
                txtRemarks.ReadOnly = false;
                tsbSave.Enabled = true;
                tsbNew.Enabled = false;
                tsbEdit.Enabled = false;
                tsbRevert.Enabled = true;
                isnew = true;
                bindingNavigator1.Enabled = false;
                tsbPrint.Enabled = false;
                tsbDelete.Enabled = false;
                tsbFind.Enabled = false;
            }
            else if (action == "Save")
            {
                txtDescription.ReadOnly = true;
                txtRemarks.ReadOnly = true;
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
                warehouseID.Visible = false;
                txtWarehouseNo.ReadOnly = true;
                txtDescription.ReadOnly = true;
                txtRemarks.ReadOnly = true;
                txtWarehouseNo.ReadOnly = true;
                tsbSave.Enabled = false;
                tsbRevert.Enabled = false;
            }
            else if (action == "Revert")
            {
                txtDescription.ReadOnly = true;
                txtRemarks.ReadOnly = true;
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
            DataTable DtBinding = new warehouseBusinessLayer().SelectAll();
            bs.DataSource = DtBinding;
            bindingNavigator1.BindingSource = bs;
            bs.Position = DtBinding.Rows.Count;
            //bindposition(UserID.Text);
            warehouseID.DataBindings.Clear();
            warehouseID.DataBindings.Add(new Binding("Text", bs, "warehouseID", true));
        }


        private void WarehouseID_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(warehouseID.Text))
            {
                DataTable dt = new warehouseBusinessLayer().SelectDataFromWarehouseID(Guid.Parse(warehouseID.Text));
                foreach (DataRow row in dt.Rows)
                {
                    //textbox output
                    txtWarehouseNo.Text = row["Code"].ToString();
                    txtDescription.Text = row["description"].ToString();
                    txtRemarks.Text = row["remarks"].ToString();
                    ckbActive.Checked = Convert.ToBoolean(row["isActive"].ToString());
                }
            }
        }
        DataTable rightsware = new warehouseBusinessLayer().RightsWarehouse(LoginForm.ID);
        private void tsbNew_Click_1(object sender, EventArgs e)
        {
            if (!Convert.ToBoolean(rightsware.Rows[0]["NEW"].ToString()))
            {
                MessageBox.Show("Access Denied!", "Warehouse", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Actioncontrol("New");
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

            if (msg != "")
            {
                MessageBox.Show(msg);
                return;
            }

            //combobox insert new datatable
            DataTable dt = new DataTable();
            dt.Columns.Add("warehouseID");
            dt.Columns.Add("description");
            dt.Columns.Add("remarks");
            dt.Columns.Add("isActive");
            dt.Columns.Add("Action");
            dt.Rows.Add();
            Guid _ID = isnew ? Guid.NewGuid() : new Guid(warehouseID.Text);
            dt.Rows[0]["warehouseID"] = _ID;
            dt.Rows[0]["description"] = txtDescription.Text;
            dt.Rows[0]["remarks"] = txtRemarks.Text;
            dt.Rows[0]["isActive"] = ckbActive.Checked;
            dt.Rows[0]["Action"] = isnew ? "New" : "Edit";

            if (!new warehouseBusinessLayer().checkIfExistWarehouse(_ID, txtDescription.Text, isnew ? "New" : "Edit"))
            {
                //INSERT BULKDATA textbox
                DataTable ID = new InsertBulkData_Management().InserBulk(dt, "InsertOrUpdateWarehouse", "@dt");
                WarehouseID_TextChanged(null, null);
                LoadDataBinding();
                Actioncontrol("Save");
                string b = _ID.ToString();
                //update kasama bs
                int itemFound = bs.Find("warehouseID", b);
                bs.Position = itemFound;
            }
            else
            {
                MessageBox.Show("Description is already Exist!");
            }
        }

        private void tsbEdit_Click_1(object sender, EventArgs e)
        {
            if (!Convert.ToBoolean(rightsware.Rows[0]["EDIT"].ToString()))
            {
                MessageBox.Show("Access Denied!", "Warehouse", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                Actioncontrol("Edit");
            }
                
        }

        private void tsbRevert_Click_1(object sender, EventArgs e)
        {
            WarehouseID_TextChanged(null, null);
            LoadDataBinding();
            Actioncontrol("Revert");
        }

        private void tsbFind_Click_1(object sender, EventArgs e)
        {
            if (!Convert.ToBoolean(rightsware.Rows[0]["FIND"].ToString()))
            {
                MessageBox.Show("Access Denied!", "Warehouse", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FindWarehouse a = new FindWarehouse();
                a.ShowDialog();
                //get data galing sa datagrid sa ibang form
                if (a.ID != null)
                {
                    string b = a.ID;
                    warehouseID.Text = b;
                    //update kasama bs
                    int itemFound = bs.Find("warehouseID", b);
                    bs.Position = itemFound;
                }
            }
        }

        private void tsbPrint_Click_1(object sender, EventArgs e)
        {
            if (!Convert.ToBoolean(rightsware.Rows[0]["PRINT"].ToString()))
            {
                MessageBox.Show("Access Denied!", "Warehouse", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CRWarehouse asd = new CRWarehouse();
                DataTable dt = new warehouseBusinessLayer().printWarehouse();
                DataSet ds = new DataSet();
                dt.TableName = "tblWarehouse";
                ds.Tables.Add(dt);
                rptViewer rp = new rptViewer();
                rp.ds = ds;
                rp.CR = asd;
                rp.ShowDialog();
            }
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            if (!Convert.ToBoolean(rightsware.Rows[0]["DELETE"].ToString()))
            {
                MessageBox.Show("Access Denied!", "Warehouse", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Guid _ID = new Guid(warehouseID.Text);
                DialogResult dialogResult = MessageBox.Show("Are you sure want to delete this Warehouse?", "Delete Warehouse", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (!new warehouseBusinessLayer().checkIfUsedWarehouse(_ID))
                    {
                        new warehouseBusinessLayer().DeleteWarehouse(_ID);
                        WarehouseID_TextChanged(null, null);
                        LoadDataBinding();
                    }
                    else
                    {
                        MessageBox.Show("Warehouse is already Used!");
                    }
                }
            }
        }
    }
}
