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
    public partial class FindMasterfile : Form
    {
        public FindMasterfile()
        {
            InitializeComponent();
        }
        public string ID;
        DataTable dt = new DataTable();
        private void FindMasterfile_Load(object sender, EventArgs e)
        {
            dt = new warehouseBusinessLayer().findMaster();
            dataGridView1.DataSource = dt;
        }

        private void cbxFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
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

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int num = dataGridView1.CurrentCell.RowIndex;
            ID = dataGridView1.Rows[num].Cells["masterID"].Value.ToString();
            this.Close();
        }
    }
}
