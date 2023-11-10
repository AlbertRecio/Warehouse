using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace Warehouse
{
    public partial class rptViewer : Form
    {
        public rptViewer()
        {
            InitializeComponent();
        }
        public string formname;
        public ReportDocument CR;
        public DataSet ds;
        private void rptViewer_Load(object sender, EventArgs e)
        {
            CRViewer.AllowedExportFormats = (int)(ViewerExportFormats.ExcelFormat | ViewerExportFormats.PdfFormat | ViewerExportFormats.WordFormat);
            for (int i = 0; i < ds.Tables.Count; i++)
            {
                string tablename = ds.Tables[i].TableName;
                CR.Database.Tables[tablename].SetDataSource(ds.Tables[tablename]);
            }
            CRViewer.ReportSource = CR;
            CRViewer.Refresh();
            CRViewer.Zoom(100);
        }
    }
}
