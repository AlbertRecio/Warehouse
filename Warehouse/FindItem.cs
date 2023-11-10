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
    public partial class FindItem : Form
    {
        public FindItem()
        {
            InitializeComponent();
        }
        public Guid warehouseid;
        public List<Guid> ID = new List<Guid>();
        private void FindItem_Load(object sender, EventArgs e)
        {
            DataTable DtBinding = new warehouseBusinessLayer().findItem(warehouseid);
            int counter = 0;

            DtBinding.Columns[0].ReadOnly = false;
            dataGridView1.DataSource = DtBinding;


            //combobox insert value 
            //DataTable dt = new warehouseBusinessLayer().SelectDataFromReasonID();

            //cbx1.ValueMember = "CashAdvanceID";
            //cbx1.DisplayMember = "CashAdvanceReason";
            //cbx1.DataSource = dt;
        }

        private void DataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    //
            //    dataGridView1.EndEdit();
               
            //    foreach (DataGridViewRow row in dataGridView1.Rows)
            //    {
            //        if (row == null)
            //            continue;

            //        string test = row.Cells["check"].Value == null? "false" : "true" ;
            //        string test1 = row.Cells["masterwarehouseID"].Value.ToString();
            //        if (Convert.ToBoolean(test))
            //        {
            //            ID.Add(Guid.Parse(test1));
            //        }
            //    }
            //    this.Close();
            //}
        }

        private void dataGridView1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string test1 = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[masterwarehouseID.Index].Value.ToString();
                ID.Add(Guid.Parse(test1));
                this.Close();
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
                string test1 = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[masterwarehouseID.Index].Value.ToString();
                ID.Add(Guid.Parse(test1));
                this.Close();
           
        }
        
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSearch.Text))
            {
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("Description LIKE '%{0}%'", txtSearch.Text);
            }
            else
            {
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = null;
       
            }
        }
    }
}
