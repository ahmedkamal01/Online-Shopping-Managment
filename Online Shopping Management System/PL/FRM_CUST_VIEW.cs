using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Online_Shopping_Management_System.PL
{
    public partial class FRM_CUST_VIEW : Form
    {
        BL.Customers cust = new BL.Customers();
        public FRM_CUST_VIEW()
        {
            InitializeComponent();
            dataGridView1.DataSource = cust.Get_Customers();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[4].Visible = false;
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRM_CUST_VIEW_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {

                FRM_ORDERS.ORDER.pictureBox1.Image = null;
                FRM_ORDERS.ORDER.textBox_custID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                FRM_ORDERS.ORDER.textBox_Fname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                FRM_ORDERS.ORDER.textBoxLName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                FRM_ORDERS.ORDER.textBox_Email.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                FRM_ORDERS.ORDER.textBox_Num.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                byte[] img = (byte[])dataGridView1.CurrentRow.Cells[4].Value;
                MemoryStream ms = new MemoryStream(img);
                FRM_ORDERS.ORDER.pictureBox1.Image = Image.FromStream(ms);
                
            }
            catch
            {
                return;
            }
        }
    }
}
