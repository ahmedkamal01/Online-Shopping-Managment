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
    public partial class Frm_NU_Cusromer : Form
    {
       

        BL.Customers cust = new BL.Customers();
       
        int index=0;
        public Frm_NU_Cusromer()
        {
            InitializeComponent();

            

            dataGridView1.DataSource = cust.Get_Customers();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            pictureBox1.Image = null;
            Navigate(0);
            if (dataGridView1.Rows.Count>0)
            dataGridView1.Rows[0].Selected = true;
            label5.Text = "1 / " + dataGridView1.Rows.Count.ToString();

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
           byte[] image;
            DataTable dt=new DataTable();
          
                    try
                    {

                        if (pictureBox1.Image == null)
                        {
                            image = new byte[0];
                            cust.SET_FIRST_LAST(textBox_Fname.Text, textBox_Lname.Text);
                           
                            cust.SET_Values(textBox_Num.Text, textBox_email.Text, image, "NO");
                            cust.New_Cust();
                            MessageBox.Show("Customrer Successfully Added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            MemoryStream ms = new MemoryStream();
                            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                            image = ms.ToArray();
                    cust.SET_FIRST_LAST(textBox_Fname.Text, textBox_Lname.Text);
                    cust.SET_Values( textBox_Num.Text, textBox_email.Text, image, "YES");
                            cust.New_Cust();
                            MessageBox.Show("Customrer Successfully Added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        dataGridView1.DataSource = cust.Get_Customers();


                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Error Occured During Adding the Customer\n" + ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }


            //}
           // label5.Text = "1 / " + dataGridView1.Rows.Count.ToString();

            btn_add.Enabled = false;
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            label7.Text = "";
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Images|*.*";

            if(open.ShowDialog()==DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(open.FileName);
            }
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            textBox_email.Clear();
            textBox_Fname.Clear();
            textBox_Lname.Clear();
            textBox_Num.Clear();
            pictureBox1.Image = null;
            label7.Text = "Press Here To Add Image";
            textBox_Fname.Focus();
            btn_add.Enabled = true;
            

        }

        private void textBox_Fname_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            textBox_Lname.Focus();
        }

        private void textBox_Lname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                textBox_Num.Focus();
        }

        private void textBox_Num_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                textBox_email.Focus();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.Image = null;
                textBox_email.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                textBox_Fname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox_Lname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBox_Num.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();

               
                    
                    string f =dataGridView1.CurrentRow.Cells[4].Value.ToString();

                    if(f== "System.Byte[]") {
                    label7.Text = "";
                    byte[] img = (byte[])dataGridView1.CurrentRow.Cells[4].Value;
                        MemoryStream ms = new MemoryStream(img);

                        pictureBox1.Image = Image.FromStream(ms);
                    }
                   
                    
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] image;
                if (pictureBox1.Image == null)
                {
                    image = new byte[0];
                    cust.SET_FIRST_LAST(textBox_Fname.Text, textBox_Lname.Text);
                    cust.SET_Values( textBox_Num.Text, textBox_email.Text, image, "NO");
                    cust.SET_ID(int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                    cust.edit_Cust();
                    MessageBox.Show("Customrer Successfully Edited", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MemoryStream ms = new MemoryStream();
                    pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                    image = ms.ToArray();
                    cust.SET_FIRST_LAST(textBox_Fname.Text, textBox_Lname.Text);
                    cust.SET_Values( textBox_Num.Text, textBox_email.Text, image, "YES");
                    cust.SET_ID(int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                    cust.edit_Cust();
                    MessageBox.Show("Customrer Successfully Edited", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                dataGridView1.DataSource = cust.Get_Customers();


            }
            catch (Exception ex)
            {

                MessageBox.Show("Error Occured During Editing the Customer\n" + ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you want to delete this Customer ?","Confirm",MessageBoxButtons.OKCancel,MessageBoxIcon.Question)==DialogResult.OK)
            {
                cust.SET_ID(int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                cust.delete_Cust();
                MessageBox.Show("Customer Successfully Deleted");
                dataGridView1.DataSource = cust.Get_Customers();
                textBox_email.Clear();
                textBox_Fname.Clear();
                textBox_Lname.Clear();
                textBox_Num.Clear();
                pictureBox1.Image = null;
                label7.Text = "Press Here To Add Image";
            }
            else
            {
                MessageBox.Show("Action Canceled");
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource=cust.Search_Customers(textBox5.Text);
        }

        void Navigate (int ind)
        {
            try
            {
                DataRowCollection Drc = cust.Get_Customers().Rows;
                textBox_email.Text = Drc[ind][5].ToString();
                textBox_Lname.Text = Drc[ind][2].ToString();
                textBox_Fname.Text = Drc[ind][1].ToString();
                textBox_Num.Text = Drc[ind][3].ToString();
                label7.Text = "";
                byte[] image;
                image = (byte [])Drc[ind][4];
                MemoryStream ms = new MemoryStream(image);
                pictureBox1.Image = Image.FromStream(ms);

            }
            catch
            {
                return;
            }
            
            

        }

        private void btn_first_Click(object sender, EventArgs e)
        {
            Navigate(0);
            dataGridView1.Rows[0].Selected = true;
            label5.Text = "1 / "+ cust.Get_Customers().Rows.Count.ToString();
        }

        private void btn_last_Click(object sender, EventArgs e)
        {
            index = cust.Get_Customers().Rows.Count - 1;
            Navigate(index);
            dataGridView1.Rows[cust.Get_Customers().Rows.Count - 1].Selected = true;
            label5.Text = cust.Get_Customers().Rows.Count.ToString() +" / " + cust.Get_Customers().Rows.Count.ToString();
        }

        private void btn_previous_Click(object sender, EventArgs e)
        {
            if(index==0)
            {
                MessageBox.Show("This is first Cusomer");
                return;
            }
            index -= 1;
            Navigate(index);
            dataGridView1.Rows[index].Selected = true;
            label5.Text = (index + 1).ToString() + " / " + cust.Get_Customers().Rows.Count.ToString();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (index == cust.Get_Customers().Rows.Count - 1)
            {
                MessageBox.Show("This is Last Cusomer");
                return;
            }
            index += 1;
            Navigate(index);
            dataGridView1.Rows[index].Selected = true;
            label5.Text = (index + 1).ToString() + " / " + cust.Get_Customers().Rows.Count.ToString();
        }
    }
}
