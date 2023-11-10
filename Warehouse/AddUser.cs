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
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }
        bool isnew = false;
        bool isedit = false;
        private void Actioncontrol(String action)
        {
            if (action == "New")
            {
                txtUsername.Clear();
                txtName.Clear();
                txtAge.Clear();
                txtUserNo.Clear();
                cbxGender.Text = "Male";
                cbxRights.Text = "User";

                dataGridView1.ReadOnly = false;
                readonlyDatacol();

                txtUsername.ReadOnly = false;
                txtName.ReadOnly = false;
                txtAge.ReadOnly = false;
                txtEmail.ReadOnly = false;
                cbxGender.Enabled = true;
                cbxRights.Enabled = true;

                isnew = true;

                bindingNavigator1.Enabled = false;

                tsbNew.Enabled = false;
                tsbSave.Enabled = true;
                tsbEdit.Enabled = false;
                tsbRevert.Enabled = true;
                tsbPrint.Enabled = false;
                tsbFind.Enabled = false;
                tsbDelete.Enabled = false;
            }
            else if (action == "Save")
            {
                txtUsername.ReadOnly = true;
                txtName.ReadOnly = true;
                txtAge.ReadOnly = true;
                txtEmail.ReadOnly = true;
                cbxGender.Enabled = false;
                cbxRights.Enabled = false;
                isedit = false;

                dataGridView1.ReadOnly = true;
                readonlyDatacol();

                bindingNavigator1.Enabled = true;

                tsbNew.Enabled = true;
                tsbSave.Enabled = false;
                tsbEdit.Enabled = true;
                tsbRevert.Enabled = false;
                tsbPrint.Enabled = true;
                tsbFind.Enabled = true;
                tsbDelete.Enabled = true;
            }
            else if (action == "Edit")
            {
                txtUsername.ReadOnly = false;
                txtName.ReadOnly = false;
                txtAge.ReadOnly = false;
                txtEmail.ReadOnly = false;
                cbxGender.Enabled = true;
                cbxRights.Enabled = true;

                dataGridView1.ReadOnly = false;

                isedit = true;
                isnew = false;
                bindingNavigator1.Enabled = false;

                tsbNew.Enabled = false;
                tsbSave.Enabled = true;
                tsbEdit.Enabled = false;
                tsbRevert.Enabled = true;
                tsbPrint.Enabled = false;
                tsbFind.Enabled = false;
                tsbDelete.Enabled = false;
            }
            else if (action == "Load")
            {
                UserID.Visible = false;

                dataGridView1.ReadOnly = true;
                txtUserNo.ReadOnly = true;
                txtUsername.ReadOnly = true;
                txtName.ReadOnly = true;
                txtAge.ReadOnly = true;
                txtEmail.ReadOnly = true;
                cbxGender.Enabled = false;
                cbxRights.Enabled = false;

                tsbSave.Enabled = false;
                tsbRevert.Enabled = false;

            }
            else if (action == "Revert")
            {
                txtUsername.ReadOnly = true;
                txtName.ReadOnly = true;
                txtAge.ReadOnly = true;
                txtEmail.ReadOnly = true;
                cbxGender.Enabled = false;
                cbxRights.Enabled = false;

                dataGridView1.ReadOnly = true;

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
        private void AddUser_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            Actioncontrol("Load");
            LoadDataBinding();
        }
        private void readonlyDatacol()
        {
            int n = Convert.ToInt32(dataGridView1.Rows.Count.ToString());
            for (int i = 0; i < n; i++)
            {
                dataGridView1.Rows[i].Cells[5].ReadOnly = true;
                dataGridView1.Rows[i].Cells[6].ReadOnly = true;
            }
        }
        private void datagrid()
        {
            DataTable data = new warehouseBusinessLayer().ShowUser(Guid.Parse(UserID.Text));
            dataGridView1.DataSource = data;

        }
        private void tsbNew_Click(object sender, EventArgs e)
        {


            DataTable data = new warehouseBusinessLayer().NewShowUser();
            dataGridView1.DataSource = data;
            data.Columns["VIEW"].ReadOnly = false;
            data.Columns["NEW"].ReadOnly = false;
            data.Columns["EDIT"].ReadOnly = false;
            data.Columns["DELETE"].ReadOnly = false;
            data.Columns["FIND"].ReadOnly = false;
            data.Columns["PRINT"].ReadOnly = false;

            //int count = 0;
            //DataTable dataTable = (DataTable)dataGridView1.DataSource;
            //if (dataGridView1.Rows.Count < 0) { dataGridView1.Rows.Clear(); }

            //foreach (DataRow item in dataTable.Rows)
            //{



            //    //DataRow dr = data.NewRow();
            //    //dr[ID.Index] = item["ID"];
            //    //dr[UseID.Index] = item["UserID"];
            //    //dr[ModuleID.Index] = item["ModuleID"];
            //    //dr[ModuleName.Index] = item["ModuleName"];
            //    //dr[VIEW.Index] = 0;
            //    //dr[NEW.Index] = 0;
            //    //dr[EDIT.Index] = 0;
            //    //dr[DELETE.Index] = 0;
            //    //dr[FIND.Index] = 0;
            //    //dr[PRINT.Index] = 0;
            //    //data.Rows.Add(dr);
            //    dataTable.Rows.Add();
            //    dataGridView1.Rows[count].Cells[ID.Index].Value = item["ID"];
            //    dataGridView1.Rows[count].Cells[UseID.Index].Value = item["UserID"];
            //    dataGridView1.Rows[count].Cells[ModuleID.Index].Value = item["ModuleID"];
            //    dataGridView1.Rows[count].Cells[ModuleName.Index].Value = item["ModuleName"];
            //    dataGridView1.Rows[count].Cells[VIEW.Index].Value = 0;
            //    dataGridView1.Rows[count].Cells[NEW.Index].Value = 0;
            //    dataGridView1.Rows[count].Cells[EDIT.Index].Value = 0;
            //    dataGridView1.Rows[count].Cells[DELETE.Index].Value = 0;
            //    dataGridView1.Rows[count].Cells[FIND.Index].Value = 0;
            //    dataGridView1.Rows[count].Cells[PRINT.Index].Value = 0;
            //    count++;
            //}
            Actioncontrol("New");
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            Actioncontrol("Edit");
        }

        private void tsbRevert_Click(object sender, EventArgs e)
        {
            UserID_TextChanged(null, null);
            LoadDataBinding();
            Actioncontrol("Revert");
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            dataGridView1.EndEdit();
            string msg = "";
            int n;
            bool isNumeric = int.TryParse(txtAge.Text, out n);

            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                msg += "Please enter Username \n";
            }
            if (string.IsNullOrEmpty(txtName.Text))
            {
                msg += "Please enter Name \n";
            }
            if (string.IsNullOrEmpty(txtAge.Text))
            {
                msg += "Please enter Age \n";
            }
            else if (!isNumeric) {
                msg += "Please enter Numeric Age \n";
            }
            
            if (msg != "")
            {
                MessageBox.Show(msg);
                return;
            }
            Guid _ID = isnew ? Guid.NewGuid() : new Guid(UserID.Text);
            DataTable dt = new DataTable();
            dt.Columns.Add("UserID");
            dt.Columns.Add("Username");
            dt.Columns.Add("Name");
            dt.Columns.Add("Age");
            dt.Columns.Add("Email");
            dt.Columns.Add("Gender");
            dt.Columns.Add("needchangepass");
            dt.Columns.Add("verifiedchangepass");
            dt.Columns.Add("Rights");
            dt.Columns.Add("Action");
            dt.Rows.Add();
            dt.Rows[0]["UserID"] = _ID;
            dt.Rows[0]["Username"] = txtUsername.Text;
            dt.Rows[0]["Name"] = txtName.Text;
            dt.Rows[0]["Age"] = txtAge.Text;
            dt.Rows[0]["Email"] = txtEmail.Text;
            dt.Rows[0]["Gender"] = cbxGender.Text;
            dt.Rows[0]["needchangepass"] = Convert.ToBoolean(false).ToString();
            dt.Rows[0]["verifiedchangepass"] = Convert.ToBoolean(false).ToString();
            dt.Rows[0]["Rights"] = cbxRights.Text;
            dt.Rows[0]["Action"] = isnew ? "New" : "Edit";

            if (!new warehouseBusinessLayer().checkIfExistUsername(_ID, txtUsername.Text, isnew ? "New" : "Edit"))
            {
                //INSERT BULKDATA textbox
                DataTable timeEventsID = new InsertBulkData_Management().InserBulkUSer(dt, "InsertOrUpdateUser", "@dt");

                DataTable DTL_DATA = getdatafromgridview(_ID);

                new InsertBulkData_Management().InserBulkWithParam(DTL_DATA, _ID, "InsertOrUpdateUserModule", "@dt", "@id");

                string b = _ID.ToString();
                //update kasama bs
                int itemFound = bs.Find("UserID", b);
                bs.Position = itemFound;

                UserID_TextChanged(null, null);
                LoadDataBinding();
                Actioncontrol("Save");
                
            }
            else
            {
                MessageBox.Show("Username is already Exist!");
                return;
            }
        }
        
        DataTable getdatafromgridview(Guid Userid)
        {
            
            DataTable dt1 = new DataTable();
            dt1.Columns.Add("ID");
            dt1.Columns.Add("UserID");
            dt1.Columns.Add("ModuleID");
            dt1.Columns.Add("VIEW");
            dt1.Columns.Add("NEW");
            dt1.Columns.Add("EDIT");
            dt1.Columns.Add("DELETE");
            dt1.Columns.Add("FIND");
            dt1.Columns.Add("PRINT");
            dt1.Columns.Add("Action");
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                if (item.Cells["ID"].Value != null)
                {
                    string x = item.Cells["ModuleName"].Value.ToString();
                    DataRow dr = dt1.NewRow();
                    dr["ID"] = isnew ? Guid.NewGuid() : new Guid(UserID.Text);
                    dr["UserID"] = Userid;
                    dr["ModuleID"] = Guid.Parse(item.Cells["ModuleID"].Value.ToString());
                    dr["VIEW"] = item.Cells["VIEW"].Value.ToString();
                    dr["NEW"] = item.Cells["NEW"].Value.ToString();
                    dr["EDIT"] = item.Cells["EDIT"].Value.ToString();
                    dr["DELETE"] = item.Cells["DELETE"].Value.ToString();
                    dr["FIND"] = item.Cells["FIND"].Value.ToString();
                    dr["PRINT"] = item.Cells["PRINT"].Value.ToString();
                    dr["Action"] = isnew ? "New" : "Edit";
                    dt1.Rows.Add(dr);

                }
            }
            return dt1;
        }
        BindingSource bs;
        private void LoadDataBinding()
        {
            bs = new BindingSource();
            DataTable DtBinding = new warehouseBusinessLayer().SelectAllUser();
            bs.DataSource = DtBinding;
            bindingNavigator1.BindingSource = bs;
            bs.Position = DtBinding.Rows.Count;
            //bindposition(UserID.Text);
            UserID.DataBindings.Clear();
            UserID.DataBindings.Add(new Binding("Text", bs, "UserID", true));
            datagrid();
        }

        private void UserID_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(UserID.Text))
            {
                DataTable dt = new warehouseBusinessLayer().SelectDataFromUserID(Guid.Parse(UserID.Text));
                foreach (DataRow row in dt.Rows)
                {
                    //textbox output
                    txtUserNo.Text = row["UserNo"].ToString();
                    txtUsername.Text = row["Username"].ToString();
                    txtName.Text = row["Name"].ToString();
                    txtAge.Text = row["Age"].ToString();
                    cbxGender.Text = row["Gender"].ToString();
                    cbxRights.Text = row["Rights"].ToString();
                    txtEmail.Text = row["Email"].ToString();
                }
            }
            datagrid();
        }

        private void tsbFind_Click(object sender, EventArgs e)
        {
            FindUser a = new FindUser();
            a.ShowDialog();
            //get data galing sa datagrid sa ibang form
            if (a.ID != null)
            {
                string b = a.ID;
                UserID.Text = b;
                //update kasama bs
                int itemFound = bs.Find("UserID", b);
                bs.Position = itemFound;
            }
        }

        private void cbxRights_TextChanged(object sender, EventArgs e)
        {
            int count = 0;
            foreach(DataGridViewRow x in dataGridView1.Rows)
            {
                if (cbxRights.Text == "Admin")
                {
                    dataGridView1.Rows[count].Cells[VIEW.Index].Value = 1;
                    dataGridView1.Rows[count].Cells[NEW.Index].Value =1;
                    dataGridView1.Rows[count].Cells[EDIT.Index].Value = 1;
                    dataGridView1.Rows[count].Cells[DELETE.Index].Value = 1;
                    dataGridView1.Rows[count].Cells[FIND.Index].Value = 1;
                    dataGridView1.Rows[count].Cells[PRINT.Index].Value = 1;
                    count++;
                }
                else
                {
                    dataGridView1.Rows[count].Cells[VIEW.Index].Value = 0;
                    dataGridView1.Rows[count].Cells[NEW.Index].Value = 0;
                    dataGridView1.Rows[count].Cells[EDIT.Index].Value = 0;
                    dataGridView1.Rows[count].Cells[DELETE.Index].Value = 0;
                    dataGridView1.Rows[count].Cells[FIND.Index].Value = 0;
                    dataGridView1.Rows[count].Cells[PRINT.Index].Value = 0;
                    count++;
                }
            }
            
        }

        private void cbxGender_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbxRights_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void tsbPrint_Click(object sender, EventArgs e)
        {
            //CRUsers asd = new CRUsers();
            //DataTable dt = new warehouseBusinessLayer().printUsers();
            //DataSet ds = new DataSet();
            //dt.TableName = "tblUsers";
            //ds.Tables.Add(dt);
            //rptViewer rp = new rptViewer();
            //rp.ds = ds;
            //rp.CR = asd;
            //rp.ShowDialog();
        }
    }
}
