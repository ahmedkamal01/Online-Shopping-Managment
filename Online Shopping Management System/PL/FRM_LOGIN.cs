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
    public partial class FRM_LOGIN : Form
    {
        BL.LOGIN log = new BL.LOGIN();
        public FRM_LOGIN()
        {
            InitializeComponent();
           
        }


        private void button1_Click(object sender, EventArgs e)
        {
            DataTable Dt = log.authentication_login(textBox_ID.Text, textBox_Password.Text);

            if (Dt.Rows.Count > 0)
            {
                if(Dt.Rows[0][2].ToString()== "Admin     ")
                {
                    Program.salesman = Dt.Rows[0][3].ToString();
                    Main_FRM.main_frm.productsToolStripMenuItem.Enabled = true;
                    Main_FRM.main_frm.customersToolStripMenuItem.Enabled = true;
                    Main_FRM.main_frm.usersToolStripMenuItem.Enabled = true;
                    Main_FRM.main_frm.backupToolStripMenuItem.Enabled = true;
                    Main_FRM.main_frm.restoreToolStripMenuItem.Enabled = true;
                    Main_FRM.main_frm.usersToolStripMenuItem.Visible = true;

                    this.Close();
                    Main_FRM.main_frm.Settings.ShowBalloonTip(1000,"Welcome","Welcome "+Program.salesman, ToolTipIcon.None);
                }
                else
                {
                    
                    Program.salesman = Dt.Rows[0][3].ToString();
                    Main_FRM.main_frm.productsToolStripMenuItem.Enabled = true;
                    Main_FRM.main_frm.customersToolStripMenuItem.Enabled = true;
                    Main_FRM.main_frm.usersToolStripMenuItem.Enabled = true;
                    Main_FRM.main_frm.backupToolStripMenuItem.Enabled = true;
                    Main_FRM.main_frm.restoreToolStripMenuItem.Enabled = true;
                    Main_FRM.main_frm.usersToolStripMenuItem.Visible = false;

                    this.Close();
                    Main_FRM.main_frm.Settings.ShowBalloonTip(1000, "Welcome", "Welcome " + Program.salesman, ToolTipIcon.None);

                }

            }
            else
                MessageBox.Show("Failed to Login ", "login state");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
