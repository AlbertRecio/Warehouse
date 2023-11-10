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
    public partial class PromptDate_MasterFile : Form
    {
        public PromptDate_MasterFile()
        {
            InitializeComponent();
        }

        private void PromptDate_MasterFile_Load(object sender, EventArgs e)
        {
            firstLoad = true;
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker2.Value = DateTime.Today;
        }
        public event EventHandler<EventArgs> Canceled;
        DataTable dt = new warehouseBusinessLayer().GetDateTime();

        private void dateTimePicker2_ValueChanged_1(object sender, EventArgs e)
        {
            if (dt.Rows.Count > 0)
            {
                //if (Convert.ToDateTime(dt.Rows[0].ItemArray[0].ToString()) < Convert.ToDateTime(dateTimePicker2.Value.ToString()))
                //{
                //    //dateTimePicker2.Value = Convert.ToDateTime(dt.Rows[0].ItemArray[0].ToString());
                //    MessageBox.Show("End Date must not greater than System Date!");
                //}
                //else 
                if (Convert.ToDateTime(dateTimePicker2.Value.ToString()) < Convert.ToDateTime(dateTimePicker1.Value.ToString()))
                {
                    //dateTimePicker2.Value = Convert.ToDateTime(Convert.ToDateTime(dt.Rows[0].ItemArray[0].ToString()).ToShortDateString());
                    MessageBox.Show("End Date must not greater than Start Date!");
                    dateTimePicker2.Value = DateTime.Today;
                }
                //else if (Convert.ToDateTime(dateTimePicker1.Value.ToString()) > Convert.ToDateTime(dateTimePicker2.Value.ToString()))
                //{
                //    dateTimePicker2.Value = Convert.ToDateTime(dt.Rows[0].ItemArray[0].ToString());
                //    MessageBox.Show("End Date must not greater than Start Date!");
                //}
            }
        }

        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;
            DrawGroupBox(box, e.Graphics, Color.Red, Color.Blue);
        }
        private void DrawGroupBox(GroupBox box, Graphics g, Color textColor, Color borderColor)
        {
            if (box != null)
            {
                Brush textBrush = new SolidBrush(textColor);
                Brush borderBrush = new SolidBrush(borderColor);
                Pen borderPen = new Pen(borderBrush);
                SizeF strSize = g.MeasureString(box.Text, box.Font);
                Rectangle rect = new Rectangle(box.ClientRectangle.X,
                                               box.ClientRectangle.Y + (int)(strSize.Height / 2),
                                               box.ClientRectangle.Width - 1,
                                               box.ClientRectangle.Height - (int)(strSize.Height / 2) - 1);

                // Clear text and border
                g.Clear(this.BackColor);

                // Draw text
                g.DrawString(box.Text, box.Font, textBrush, box.Padding.Left, 0);

                // Drawing Border
                //Left
                g.DrawLine(borderPen, rect.Location, new Point(rect.X, rect.Y + rect.Height));
                //Right
                g.DrawLine(borderPen, new Point(rect.X + rect.Width, rect.Y), new Point(rect.X + rect.Width, rect.Y + rect.Height));
                //Bottom
                g.DrawLine(borderPen, new Point(rect.X, rect.Y + rect.Height), new Point(rect.X + rect.Width, rect.Y + rect.Height));
                //Top1
                g.DrawLine(borderPen, new Point(rect.X, rect.Y), new Point(rect.X + box.Padding.Left, rect.Y));
                //Top2
                g.DrawLine(borderPen, new Point(rect.X + box.Padding.Left + (int)(strSize.Width), rect.Y), new Point(rect.X + rect.Width, rect.Y));
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            FrmMasterfile.bol = false;
            this.Close();
        }
        bool firstLoad = false;

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (firstLoad == false)
            {
                if (dt.Rows.Count > 0)
                {
                    if (Convert.ToDateTime(dateTimePicker2.Value.ToString()) < Convert.ToDateTime(dateTimePicker1.Value.ToString()))
                    {
                        //dateTimePicker1.Value = Convert.ToDateTime(dt.Rows[0].ItemArray[0].ToString());
                        MessageBox.Show("Start Date must not greater than End Date!");
                        dateTimePicker1.Value = DateTime.Today;
                    }
                }
            }
            else
            {
                firstLoad = false;
            }
        }
        public DateTime d_start, d_end;
        public string form;
        public bool load = false;

        private void button1_Click(object sender, EventArgs e)
        {
            if (form == "client")
            {
                load = true;
                d_start = Convert.ToDateTime(dateTimePicker1.Value);
                d_end = Convert.ToDateTime(dateTimePicker2.Value);
                this.Close();
            }
            else
            {
                FrmMasterfile m = new FrmMasterfile();
                FrmMasterfile.bol = true;

                if ((dateTimePicker2.Value - dateTimePicker1.Value).TotalDays > 3)
                {
                    MessageBox.Show("Please Check your inputed Date.\n\nAllowed days for Export must be 3 Days and Below.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (Convert.ToDateTime(dateTimePicker2.Value.ToString()) < Convert.ToDateTime(dateTimePicker1.Value.ToString()))
                {
                    MessageBox.Show("End Date must not greater than Start Date!");
                }
                else
                {
                    FrmMasterfile.DateStart = Convert.ToDateTime(dateTimePicker1.Value);
                    FrmMasterfile.DateEnd = Convert.ToDateTime(dateTimePicker2.Value);
                    this.Close();
                }
            }
        }
    }
}
