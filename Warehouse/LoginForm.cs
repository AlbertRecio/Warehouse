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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        public static bool rights = false;
        public static Guid ID;
        public static string Name;
        public static string Password;
        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DataTable dt = new warehouseBusinessLayer().GetDetails(txtUsername.Text, txtPassword.Text);

            string msg = "";
            if (string.IsNullOrEmpty(txtUsername.Text)) {
                msg += "Please enter Username \n";
            }
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                msg += "Please enter Password \n";
            }
            if (msg != "") {
                MessageBox.Show(msg);
                return;
            }
            
            if (new warehouseBusinessLayer().LogIn(txtUsername.Text, txtPassword.Text))
            {
                ID = Guid.Parse(dt.Rows[0]["UserID"].ToString());
                Name = dt.Rows[0]["Name"].ToString();
                Password = dt.Rows[0]["Password"].ToString();

                if (new warehouseBusinessLayer().CheckRights(txtUsername.Text, txtPassword.Text))
                {
                    rights = true;
                }
                else
                {
                    rights = false;
                }
                txtUsername.Clear();
                txtPassword.Clear();
                foreach (Form f in Application.OpenForms)
                {
                    if (f is MainForm)
                    {
                        f.Focus();
                        return;
                    }
                }

                MainForm c = new MainForm();
                c.ShowDialog();

            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
                txtUsername.Clear();
                txtPassword.Clear();
                return;
            }

        }

        private void lklResetPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            var form2 = new FindAccount();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
            
        }
    }
}
