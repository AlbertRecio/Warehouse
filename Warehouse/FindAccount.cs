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
    public partial class FindAccount : Form
    {
        public FindAccount()
        {
            InitializeComponent();
        }

        private void FindAccount_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable dt = new warehouseBusinessLayer().searchAccount(txtAccount.Text);
            if (!string.IsNullOrEmpty(txtAccount.Text)) {
                if (dt.Rows != null)
                {
                    //DataTable dt = new warehouseBusinessLayer().needschangepass(txtAccount.Text);
                    Guid x = Guid.Parse(dt.Rows[0][0].ToString());
                }
                else
                {
                    MessageBox.Show("Your search did not return any results. Please try again with other information", "No Search Results");
                } 
            }
            else
            {
                MessageBox.Show("Fill in at least one field to search for your account", "Please fill in at least one field");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new LoginForm();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }
    }
}
