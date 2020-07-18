using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Online_Shopping_Management_System.PL
{
    public partial class FRM_BELLS_MNGMNT : Form
    {
        BL.ORDERS order = new BL.ORDERS();
        public FRM_BELLS_MNGMNT()
        {
            InitializeComponent();
            dataGridView1.DataSource = order.GET_BELLS(textBox_WORD.Text);
        }

        private void textBox_CatName_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource=order.GET_BELLS(textBox_WORD.Text);
        }

        private void EXIT_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPRNT_Click(object sender, EventArgs e)
        {
            RPRT.Rprt_Orders rprt = new RPRT.Rprt_Orders();
            rprt.SetParameterValue("@id_order", int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
           // rprt.Refresh();
            RPRT.PRNT_SNGL_PRD frm = new RPRT.PRNT_SNGL_PRD();
            frm.crystalReportViewer1.ReportSource = rprt;
            frm.Show();
        }

        private void Btn_new_Click(object sender, EventArgs e)
        {
            FRM_ORDERS ord = new FRM_ORDERS();
            ord.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            order.Delete_Bell(int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
            MessageBox.Show("Belll Deleted Successfully","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
            dataGridView1.DataSource = order.GET_BELLS(textBox_WORD.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
           if(DateTime.Today.AddDays(-14) > (DateTime)dataGridView1.CurrentRow.Cells[1].Value)
            {
                MessageBox.Show("Sorry You bought this bell since more than 14 days, We cant Return any Product","Sorry",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
           else 
           {
                FRM_Turning_Refunding turn = new FRM_Turning_Refunding(int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                turn.ShowDialog();
           }
          
        }
    }
}
