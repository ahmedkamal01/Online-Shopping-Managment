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
    public partial class FRM_Settings : Form
    {
        public FRM_Settings()
        {
            InitializeComponent();
            textBox_database.Text = Properties.Settings.Default.Database;
            textBox_server.Text = Properties.Settings.Default.Server;
            if(Properties.Settings.Default.Mode=="SQL")
            {
                RDBTN_Windows.Checked = true;
                textBox_Pass.Text = Properties.Settings.Default.Password;
                textBox_UserName.Text = Properties.Settings.Default.UserName;
            }
            else
            {
                RDBTN_SQL.Checked = true;
                textBox_Pass.Clear();
                textBox_UserName.Clear();
                textBox_UserName.ReadOnly = true;
                textBox_Pass.ReadOnly = true;
            }
            
        }

        private void btn_SVE_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Password = textBox_Pass.Text;
            Properties.Settings.Default.Mode = RDBTN_SQL.Checked == true ? "SQL" : "Windows";
            Properties.Settings.Default.UserName = textBox_UserName.Text;
            Properties.Settings.Default.Server = textBox_server.Text;
            Properties.Settings.Default.Database = textBox_database.Text;
            Properties.Settings.Default.Save();
        }

        private void RDBTN_SQL_CheckedChanged(object sender, EventArgs e)
        {
            textBox_Pass.ReadOnly = false;
            textBox_UserName.ReadOnly=false;
        }

        private void RDBTN_Windows_CheckedChanged(object sender, EventArgs e)
        {
            textBox_Pass.ReadOnly = true;
            textBox_UserName.ReadOnly = true;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
