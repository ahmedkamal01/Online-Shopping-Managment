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
using System.Data;

namespace Online_Shopping_Management_System.PL
{
    public partial class FRM_BackUp : Form
    {
        private SqlConnection con = new SqlConnection(@"Data Source=BARHOMA\SQL;Initial Catalog=master;Integrated Security=True");
        SqlCommand com ;
        public FRM_BackUp()
        {
            InitializeComponent();
        }

        private void Btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Brws_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog()==DialogResult.OK)
            {
                textBox_FName.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            string fileName = textBox_FName.Text + "\\Online Shopping Management System" + DateTime.Now.ToShortDateString().Replace('/','-')
                + " - " + DateTime.Now.ToShortTimeString().Replace(':','-');
            string query = "backup database [Online Shopping Management System] to Disk = '"+fileName+".bak'";
            con.Open();
            com = new SqlCommand(query,con);
            com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Program Backup Finished Successfully","Success",MessageBoxButtons.OK);
        }

    }
}
