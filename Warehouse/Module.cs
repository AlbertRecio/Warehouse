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
    public partial class Module : Form
    {
        public Module()
        {
            InitializeComponent();
        }

        private void Module_Load(object sender, EventArgs e)
        {
            moduleID_TextChanged(null, null);
            LoadDataBinding();
            Actioncontrol("Load");
        }
        bool isnew = false;
        private void Actioncontrol(String action)
        {
            if (action == "New")
            {
                txtModuleNo.Clear();
                txtName.Clear();

                txtName.ReadOnly = false;

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
                txtName.ReadOnly = true;
                
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
                txtName.ReadOnly = false;

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
                moduleID.Visible = false;
                txtModuleNo.ReadOnly = true;
                txtName.ReadOnly = true;

                tsbSave.Enabled = false;
                tsbRevert.Enabled = false;
            }
            else if (action == "Revert")
            {
                txtName.ReadOnly = true;
 
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
            DataTable DtBinding = new warehouseBusinessLayer().SelectAllModule();
            bs.DataSource = DtBinding;
            bindingNavigator1.BindingSource = bs;
            bs.Position = DtBinding.Rows.Count;
            //bindposition(UserID.Text);
            moduleID.DataBindings.Clear();
            moduleID.DataBindings.Add(new Binding("Text", bs, "moduleID", true));
        }
        private void tsbNew_Click(object sender, EventArgs e)
        {
            Actioncontrol("New");
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            //combobox insert new datatable
            DataTable dt = new DataTable();
            dt.Columns.Add("moduleID");
            dt.Columns.Add("ModuleName");
            dt.Columns.Add("Action");
            dt.Rows.Add();
            Guid _ID = isnew ? Guid.NewGuid() : new Guid(moduleID.Text);
            dt.Rows[0]["moduleID"] = _ID;
            dt.Rows[0]["ModuleName"] = txtName.Text;
            dt.Rows[0]["Action"] = isnew ? "New" : "Edit";

            if (!new warehouseBusinessLayer().checkIfExistModule(_ID, txtName.Text, isnew ? "New" : "Edit"))
            {
                //INSERT BULKDATA textbox
                DataTable ID = new InsertBulkData_Management().InserBulk(dt, "InsertOrUpdateModule", "@dt");
                moduleID_TextChanged(null, null);
                LoadDataBinding();
                
                string b = _ID.ToString();
                //update kasama bs
                int itemFound = bs.Find("moduleID", b);
                bs.Position = itemFound;
                Actioncontrol("Save");
            }
            else
            {
                MessageBox.Show("Module is already Exist!");
            }
            
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            Actioncontrol("Edit");
        }

        private void tsbRevert_Click(object sender, EventArgs e)
        {
            moduleID_TextChanged(null, null);
            LoadDataBinding();
            Actioncontrol("Revert");
        }

        private void moduleID_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(moduleID.Text))
            {
                DataTable dt = new warehouseBusinessLayer().SelectDataFromModuleID(Guid.Parse(moduleID.Text));
                foreach (DataRow row in dt.Rows)
                {
                    //textbox output
                    txtModuleNo.Text = row["Code"].ToString();
                    txtName.Text = row["ModuleName"].ToString();
                }
            }
        }

        private void tsbFind_Click(object sender, EventArgs e)
        {
            FindModule a = new FindModule();
            a.ShowDialog();
            //get data galing sa datagrid sa ibang form
            if (a.ID != null)
            {
                string b = a.ID;
                moduleID.Text = b;
                //update kasama bs
                int itemFound = bs.Find("moduleID", b);
                bs.Position = itemFound;
            }
        }
    }
}
