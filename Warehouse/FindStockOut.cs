﻿using System;
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
    public partial class FindStockOut : Form
    {
        DataTable dt = new DataTable();
        public string ID;
        public FindStockOut()
        {
            InitializeComponent();
        }

        private void FindStockOut_Load(object sender, EventArgs e)
        {
            dt = new warehouseBusinessLayer().findStockOut();
            dataGridView2.DataSource = dt;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSearch.Text))
            {
                (dataGridView2.DataSource as DataTable).DefaultView.RowFilter = string.Format(cbxFilter.Text.ToLower() + " LIKE '%{0}%'", txtSearch.Text);
            }
            else
            {
                (dataGridView2.DataSource as DataTable).DefaultView.RowFilter = null;
                dataGridView2.DataSource = dt;
            }
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int num = dataGridView2.CurrentCell.RowIndex;
            ID = dataGridView2.Rows[num].Cells["releasingID"].Value.ToString();
            this.Close();
        }

        private void cbxFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
