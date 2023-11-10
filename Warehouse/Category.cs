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
    public partial class Category : Form
    {
        public Category()
        {
            InitializeComponent();
        }
        DataTable rightscat = new warehouseBusinessLayer().RightsCategory(LoginForm.ID);
        private void Category_Load(object sender, EventArgs e)
        {
            Actioncontrol("Load");
            LoadDataBinding();

            
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
        bool isnew = false;
        private void Actioncontrol(String action)
        {
            if (action == "New")
            {
                txtCategoryNo.Clear();
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
                tsbFind.Enabled = false;
                tsbDelete.Enabled = false;
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
                tsbFind.Enabled = true;
                tsbDelete.Enabled = true;
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
                tsbFind.Enabled = false;
                tsbDelete.Enabled = false;
            }
            else if (action == "Load")
            {
                categoryID.Visible = false;
                txtDescription.ReadOnly = true;
                txtRemarks.ReadOnly = true;
                txtCategoryNo.ReadOnly = true;
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
                tsbFind.Enabled = true;
                tsbDelete.Enabled = true;
            }
        }
        BindingSource bs;
        private void LoadDataBinding()
        {
            bs = new BindingSource();
            DataTable DtBinding = new categoryBusinessLayer().SelectAll();
            bs.DataSource = DtBinding;
            bindingNavigator1.BindingSource = bs;
            bs.Position = DtBinding.Rows.Count;
            //bindposition(UserID.Text);
            categoryID.DataBindings.Clear();
            categoryID.DataBindings.Add(new Binding("Text", bs, "categoryID", true));
        }


        private void CategoryID_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(categoryID.Text))
            {

                DataTable dt = new categoryBusinessLayer().SelectDataFromCategoryID(Guid.Parse(categoryID.Text));
                foreach (DataRow row in dt.Rows)
                {
                    //textbox output
                    txtCategoryNo.Text = row["Code"].ToString();
                    txtDescription.Text = row["description"].ToString();
                    txtRemarks.Text = row["remarks"].ToString();

                }
            }
        }


        private void txtCategoryNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void tsbEdit_Click_1(object sender, EventArgs e)
        {
            if (!Convert.ToBoolean(rightscat.Rows[0]["EDIT"].ToString()))
            {
                MessageBox.Show("Access Denied!", "Category", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Actioncontrol("Edit");
            }
        }

        private void tsbNew_Click_1(object sender, EventArgs e)
        {
            if (!Convert.ToBoolean(rightscat.Rows[0]["NEW"].ToString()))
            {
                MessageBox.Show("Access Denied!", "Category", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Actioncontrol("New");
            }
            
        }

        private void tsbSave_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDescription.Text))
            {

                Guid _ID = isnew ? Guid.NewGuid() : new Guid(categoryID.Text);
                DataTable dt = new DataTable();
                dt.Columns.Add("categoryID");
                dt.Columns.Add("description");
                dt.Columns.Add("remarks");
                dt.Columns.Add("Action");
                dt.Rows.Add();
                dt.Rows[0]["categoryID"] = _ID;
                dt.Rows[0]["description"] = txtDescription.Text;
                dt.Rows[0]["remarks"] = txtRemarks.Text;
                dt.Rows[0]["Action"] = isnew ? "New" : "Edit";
                if (!new categoryBusinessLayer().checkIfExist(_ID, txtDescription.Text, isnew ? "New" : "Edit"))
                {
                    //INSERT BULKDATA textbox
                    DataTable timeEventsID = new InsertBulkData_Management().InserBulk(dt, "InsertOrUpdateCategory", "@dt");

                    string b = _ID.ToString();
                    //update kasama bs
                    int itemFound = bs.Find("categoryID", b);
                    bs.Position = itemFound;

                    CategoryID_TextChanged(null, null);
                    LoadDataBinding();
                    Actioncontrol("Save");
                }
                else
                {
                    MessageBox.Show("Description is already Exist!");
                }
            }
            else
            {
                MessageBox.Show("Description is Required");
            }
        }

        private void tsbRevert_Click_1(object sender, EventArgs e)
        {
            CategoryID_TextChanged(null, null);
            LoadDataBinding();
            Actioncontrol("Revert");
        }

        private void tsbFind_Click_1(object sender, EventArgs e)
        {
            if (!Convert.ToBoolean(rightscat.Rows[0]["FIND"].ToString()))
            {
                MessageBox.Show("Access Denied!", "Category", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FindCategory a = new FindCategory();
                a.ShowDialog();
                //get data galing sa datagrid sa ibang form
                //call ng variable galing ibang form
                string b = a.ID;
                categoryID.Text = b;
                int itemFound = bs.Find("categoryID", categoryID.Text.ToString());
                bs.Position = itemFound;
            }
        }

        private void tsbPrint_Click(object sender, EventArgs e)
        {
            if (!Convert.ToBoolean(rightscat.Rows[0]["PRINT"].ToString()))
            {
                MessageBox.Show("Access Denied!", "Category", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CRCategory asd = new CRCategory();
                DataTable dt = new warehouseBusinessLayer().printCategory();
                DataSet ds = new DataSet();
                dt.TableName = "tblCategory";
                ds.Tables.Add(dt);
                rptViewer rp = new rptViewer();
                rp.ds = ds;
                rp.CR = asd;
                rp.ShowDialog();
            }
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            if (!Convert.ToBoolean(rightscat.Rows[0]["DELETE"].ToString()))
            {
                MessageBox.Show("Access Denied!", "Category", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Guid _ID = new Guid(categoryID.Text);
                DialogResult dialogResult = MessageBox.Show("Are you sure want to delete this category?", "Delete Category", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (!new categoryBusinessLayer().checkIfUsed(_ID))
                    {
                        new categoryBusinessLayer().DeleteCategory(_ID);
                        CategoryID_TextChanged(null, null);
                        LoadDataBinding();
                    }
                    else
                    {
                        MessageBox.Show("Description is already Used!");
                    }
                }
            }
            
        }
    }
}
