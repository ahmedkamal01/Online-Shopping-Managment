using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Online_Shopping_Management_System.PL
{
    public partial class FRM_Restore : Form
    {
        private SqlConnection con = new SqlConnection(@"Data Source=BARHOMA\SQL;Initial Catalog=master;Integrated Security=True");
        SqlCommand com;
        public FRM_Restore()
        {
            InitializeComponent();
        }

        private void btn_Brws_Click(object sender, EventArgs e)
        { 
           
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                textBox_FName.Text = openFileDialog1.FileName;
            }
        }

        private void Btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_rest_Click(object sender, EventArgs e)
        {
            string query = "alter database [Online Shopping Management System] set offline with rollback immediate ;  restore database [Online Shopping Management System] from disk = '" + textBox_FName.Text+"'";
            con.Open();
            com = new SqlCommand(query, con);
            com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Restoring Database Finished Successfully", "Success", MessageBoxButtons.OK);
        }
    }
}
