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
    public partial class Main_FRM : Form
    {
         static Main_FRM mfr;
        

         static void closed_static(object sender, FormClosedEventArgs e)
        {
            mfr = null;
        }

        public static Main_FRM main_frm
        {
            get
            {
                if(mfr==null)
                {
                    mfr = new Main_FRM();
                  //  mfr.FormClosed += new FormClosedEventHandler(closed_static);
                }
                return mfr;
            }
        }

       

        public Main_FRM()
        {
            InitializeComponent();
            if (mfr == null) mfr = this;

            this.productsToolStripMenuItem.Enabled = false;
            this.customersToolStripMenuItem.Enabled = false;
            this.usersToolStripMenuItem.Enabled = false;
            this.backupToolStripMenuItem.Enabled = false;
            this.restoreToolStripMenuItem.Enabled = false;
            FRM_LOGIN log = new FRM_LOGIN();
            log.ShowDialog();

        }

        

        private void addNewProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_ADD_PRODUCT addproduct = new FRM_ADD_PRODUCT();
            addproduct.ShowDialog();
        }

        private void productsDepartmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Prdct_Mngmnt mngmt = new Prdct_Mngmnt();
            mngmt.ShowDialog();
        }

        private void categoriesDepartmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_CAT_Mngmnt cat = new FRM_CAT_Mngmnt();
            cat.ShowDialog();
        }

        private void addNewCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.Frm_NU_Cusromer cust = new PL.Frm_NU_Cusromer();
            cust.Show(); 
        }

        private void bellsMangmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_BELLS_MNGMNT mng = new FRM_BELLS_MNGMNT();
            mng.ShowDialog();
        }

        private void customersDepartmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_NU_Cusromer cust = new Frm_NU_Cusromer();
            cust.ShowDialog();
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowDialog();
            this.WindowState = FormWindowState.Normal;
        }

        private void Settings_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.ShowDialog();
        }


        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }

        private void Main_FRM_Move(object sender, EventArgs e)
        {
            if(WindowState==FormWindowState.Minimized)
            {
                this.Hide();
                Settings.ShowBalloonTip(1000, "Online Shopping Management System", "Online Shopping Management System is working in background , Just Click me to Maxmize", ToolTipIcon.Info);
            }
        }

        private void aDDNewBellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_ORDERS order = new FRM_ORDERS();
            order.ShowDialog();
        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_ADD_USER user = new FRM_ADD_USER();
            user.ShowDialog();
        }

        private void userMangmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_USERS_MNGMNT usermngmnt = new FRM_USERS_MNGMNT();
            usermngmnt.ShowDialog();
        }

        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_BackUp backup = new FRM_BackUp();
            backup.ShowDialog();
        }

        private void restoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_Restore res = new FRM_Restore();
            res.ShowDialog();
        }

        private void setteningsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_Settings set = new FRM_Settings();
            set.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void exitToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_LOGIN login = new FRM_LOGIN();
            login.ShowDialog();
            
        }

        
    }
}
