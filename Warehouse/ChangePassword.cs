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
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtOld.Text == LoginForm.Password)
            {
                if (txtPassword.Text == txtConfirmPassword.Text)
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to change your password?", "Change Password", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        DataTable dt = new warehouseBusinessLayer().ChangePassword(txtPassword.Text, LoginForm.ID);
                           

                        foreach (Form f in Application.OpenForms)
                        {
                            if (f is LoginForm)
                            {
                                f.Focus();
                                return;
                            }
                        }
                        new LoginForm().Show();
                        MessageBox.Show("You have successfully change your password!");
                        
                    }

                }
                else
                {
                    MessageBox.Show("Password does not match", "Change Password",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Invalid Old Password", "Change Password",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
