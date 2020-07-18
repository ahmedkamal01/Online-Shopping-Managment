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
    public partial class FRM_USERS_MNGMNT : Form
    {
        BL.LOGIN log = new BL.LOGIN();
        public FRM_USERS_MNGMNT()
        {
            InitializeComponent();
            dataGridView1.DataSource = log.Search_Users("");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FRM_ADD_USER user = new FRM_ADD_USER();
            user.ShowDialog();
            dataGridView1.DataSource = log.Search_Users("");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FRM_ADD_USER user = new FRM_ADD_USER();
            user.stat = "Edit";
            user.Text = "Edit";
            user.textBox_Pass.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                user.textBox_FullNAme.Text= dataGridView1.CurrentRow.Cells[3].Value.ToString();
            user.textBox_USER_NAME.Text= dataGridView1.CurrentRow.Cells[0].Value.ToString();
            user.textBoxRePass.Text= dataGridView1.CurrentRow.Cells[1].Value.ToString();
            if (dataGridView1.CurrentRow.Cells[2].Value.ToString() == "Admin     ") 
            {
                user.comboBox_Types.SelectedIndex = 1;
            }
            else
                user.comboBox_Types.SelectedIndex = 0;

            user.ShowDialog();
            dataGridView1.DataSource = log.Search_Users("");


        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = log.Search_Users(textBox5.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BL.Manger us = new BL.Manger();

            if (MessageBox.Show("Do You Want to Remove This User ?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                us.SET_USER = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                us.Delete_User();
            }
            dataGridView1.DataSource = log.Search_Users("");


        }
    }
}
