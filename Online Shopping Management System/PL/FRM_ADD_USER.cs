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
    public partial class FRM_ADD_USER : Form
    {
        private BL.Manger user = new BL.Manger();
        private BL.LOGIN log = new BL.LOGIN();

        public string stat = "ADD";

        public FRM_ADD_USER()
        {
            InitializeComponent();
            comboBox_Types.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                if (textBox_USER_NAME.Text == string.Empty || textBox_FullNAme.Text == string.Empty || textBoxRePass.Text == string.Empty || textBox_Pass.Text == string.Empty)
                {
                    MessageBox.Show("Some Fields Is Empty Please Fill All Fields", "Warning Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


            if (stat == "ADD")
            {
                if(log.authentication_login(textBox_USER_NAME.Text, textBoxRePass.Text).Rows.Count>0)
                {
                    MessageBox.Show("This User Is Already Exist", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                user.SET_USER = textBox_USER_NAME.Text;

                 string [] name = textBox_FullNAme.Text.Split(' ');
                user.SET_FIRST_LAST(name[0], name[1]);
                user.SET_STATE = comboBox_Types.Text;
                user.SET_PASSWORD =textBoxRePass.Text;
                user.Add_User();

                MessageBox.Show("User Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                textBox_USER_NAME.Clear();
                textBox_FullNAme.Clear();
                textBoxRePass.Clear();
                textBox_Pass.Clear();
            }
            else
            {
                user.SET_USER = textBox_USER_NAME.Text;
                string[] name = textBox_FullNAme.Text.Split(' ');
                user.SET_FIRST_LAST(name[0], name[1]);
                user.SET_STATE = comboBox_Types.Text;
                user.SET_PASSWORD = textBoxRePass.Text;
                user.Edit_User();
                MessageBox.Show("User Edited Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                stat = "ADD";
            }

            
        }

        private void textBoxRePass_Validated(object sender, EventArgs e)
        {
            if (textBox_Pass.Text != textBoxRePass.Text)
            {
                MessageBox.Show("Password didn't match please write password again", "Password Didn't Match", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                textBoxRePass.Clear();
                textBox_Pass.Clear();
                textBox_Pass.Focus();
                return;
            }
        }
    }
}
