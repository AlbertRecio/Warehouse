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
    public partial class FindCategory : Form
    {
        public FindCategory()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable();
        private void FindCategory_Load(object sender, EventArgs e)
        {
            dt = new categoryBusinessLayer().findCategory();
            dataGridView1.DataSource = dt;
        }
    
        public string ID;
        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int num = dataGridView1.CurrentCell.RowIndex;
            ID = dataGridView1.Rows[num].Cells["categoryID"].Value.ToString();
            this.Close();
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSearch.Text))
            {
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format(cbxFilter.Text.ToLower() + " LIKE '%{0}%'", txtSearch.Text);
            }
            else
            {
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = null;
                dataGridView1.DataSource = dt;
            }
        }

        private void cbxFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
