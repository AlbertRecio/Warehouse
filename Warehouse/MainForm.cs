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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        DataTable DtBinding = new warehouseBusinessLayer().RightsView(LoginForm.ID);
        private void CategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataRow row in DtBinding.Rows)
            {
                if (!Convert.ToBoolean(row["VIEW"].ToString()))
                {
                    if (row["ModuleName"].ToString() == "Master File")
                    {
                        MessageBox.Show("Access Denied!", "Main Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                }
            }

            foreach (Form f in Application.OpenForms)
                {
                    if (f is Form1)
                    {
                        f.Focus();
                        return;
                    }
                }

            Form1 c = new Form1();
                c.Show();

            //FrmMasterfile form = FrmMasterfile.GetInstance();
            //if (!form.Visible)
            //{
            //    form.Show();
            //}
            //else
            //{
            //    form.BringToFront();
            //}

        }

        private void MasterFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void CategoryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (DataRow row in DtBinding.Rows)
            {
                if (!Convert.ToBoolean(row["VIEW"].ToString()))
                {
                    if (row["ModuleName"].ToString() == "Category")
                    {
                        MessageBox.Show("Access Denied!", "Main Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            foreach (Form f in Application.OpenForms)
            {
                if (f is Category)
                {
                    f.Focus();
                    return;
                }
            }
            new Category().Show();
        }

        private void WarehouseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataRow row in DtBinding.Rows)
            {
                if (!Convert.ToBoolean(row["VIEW"].ToString()))
                {
                    if (row["ModuleName"].ToString() == "Warehouse")
                    {
                        MessageBox.Show("Access Denied!", "Main Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            //open new form
            foreach (Form f in Application.OpenForms)
            {
                if (f is Warehouse)
                {
                    f.Focus();
                    return;
                }
            }

            new Warehouse().Show();
            //Warehouse c = new Warehouse();
            //c.Show();

        }

        private void StockInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataRow row in DtBinding.Rows)
            {
                if (!Convert.ToBoolean(row["VIEW"].ToString()))
                {
                    if (row["ModuleName"].ToString() == "Stock In")
                    {
                        MessageBox.Show("Access Denied!", "Main Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            //open new form
            foreach (Form f in Application.OpenForms)
            {
                if (f is StockIn)
                {
                    f.Focus();
                    return;
                }
            }

            new StockIn().Show();
            //Warehouse c = new Warehouse();
            //c.Show();
        }

        private void StockOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataRow row in DtBinding.Rows)
            {
                if (!Convert.ToBoolean(row["VIEW"].ToString()))
                {
                    if (row["ModuleName"].ToString() == "Stock Out")
                    {
                        MessageBox.Show("Access Denied!", "Main Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            //open new form
            foreach (Form f in Application.OpenForms)
            {
                if (f is StockOut)
                {
                    f.Focus();
                    return;
                }
            }

            new StockOut().Show();
            //Warehouse c = new Warehouse();
            //c.Show();
        }

        private void stockAdjustmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataRow row in DtBinding.Rows)
            {
                if (!Convert.ToBoolean(row["VIEW"].ToString()))
                {
                    if (row["ModuleName"].ToString() == "Stock Adjustment")
                    {
                        MessageBox.Show("Access Denied!", "Main Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            //open new form
            foreach (Form f in Application.OpenForms)
            {
                if (f is StockAdjustment)
                {
                    f.Focus();
                    return;
                }
            }

            new StockAdjustment().Show();
            //Warehouse c = new Warehouse();
            //c.Show();
        }

        private void stockTransferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataRow row in DtBinding.Rows)
            {
                if (!Convert.ToBoolean(row["VIEW"].ToString()))
                {
                    if (row["ModuleName"].ToString() == "Stock Transfer")
                    {
                        MessageBox.Show("Access Denied!", "Main Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            foreach (Form f in Application.OpenForms)
            {
                if (f is StockTransfer)
                {
                    f.Focus();
                    return;
                }
            }

            new StockTransfer().Show();
            //Warehouse c = new Warehouse();
            //c.Show();
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!LoginForm.rights)
            {
                MessageBox.Show("Access Denied!", "Main Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //open new form
                foreach (Form f in Application.OpenForms)
                {
                    if (f is AddUser)
                    {
                        f.Focus();
                        return;
                    }
                }

                new AddUser().Show();
            }
            
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            label1.Text = "WELCOME" + LoginForm.Name;
        }

        private void modulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!LoginForm.rights)
            {
                MessageBox.Show("Access Denied!", "Main Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                foreach (Form f in Application.OpenForms)
                {
                    if (f is Module)
                    {
                        f.Focus();
                        return;
                    }
                }

                new Module().Show();
            }
        }

        private void changePassswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f is ChangePassword)
                {
                    f.Focus();
                    return;
                }
            }

            new ChangePassword().Show();
        }

        private void accountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f is AccountVerify)
                {
                    f.Focus();
                    return;
                }
            }

            new AccountVerify().Show();
        }

        private void stringBuilderToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f is Form1)
                {
                    f.Focus();
                    return;
                }
            }

            new AccountVerify().Show();
        }
    }
}
