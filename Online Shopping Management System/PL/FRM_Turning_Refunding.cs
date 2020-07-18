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
    public partial class FRM_Turning_Refunding : Form
    {
        BL.ORDERS order = new BL.ORDERS();

        public FRM_Turning_Refunding(int id_order)
        {
            InitializeComponent();
            DataTable dt = new DataTable();
            dt = order.GET_Details_return(id_order);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            order.Return_Quantity(dataGridView1.CurrentRow.Cells[0].Value.ToString(), int.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString()),int.Parse(dataGridView1.CurrentRow.Cells[1].Value.ToString()));
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            MessageBox.Show("Product Returned Back And you Will Be Refunded Soon", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }
    }

}
