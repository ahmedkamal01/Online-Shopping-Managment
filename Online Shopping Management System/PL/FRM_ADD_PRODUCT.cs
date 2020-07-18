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
    public partial class FRM_ADD_PRODUCT : Form
    {
        public string state = "Add";
        BL.Product prod = new BL.Product();

        public FRM_ADD_PRODUCT()
        {
            InitializeComponent();
            comboBox_Categories.DataSource = prod.Get_Categories();
            comboBox_Categories.DisplayMember = "Name_Cat";
            comboBox_Categories.ValueMember = "ID_Cat";

        }

        private void ChooseImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog fl = new OpenFileDialog();
            fl.Filter = "Images|*.*";
            if (fl.ShowDialog() == DialogResult.OK)
            {
                pictureBox_PRD_Img.Image = Image.FromFile(fl.FileName);

            }
        }

        private void AddProduct_Click(object sender, EventArgs e)
        {

            BL.Product prd = new BL.Product();
            if (state == "Add")
            {
                string prod_id, prod_name, price;
                int qunt, ID_cat;

                prod_id = textBox_PRD_ID.Text;
                prod_name = textBox_PRD_Name.Text;
                price = textBox_PRD_Price.Text;
                qunt = int.Parse(textBox_PRD_Qunt.Text);
                ID_cat = Convert.ToInt32(comboBox_Categories.SelectedValue);

                MemoryStream ms = new MemoryStream();
                pictureBox_PRD_Img.Image.Save(ms, pictureBox_PRD_Img.Image.RawFormat);

                byte[] img = ms.ToArray();


                prd.Add_products(prod_id, prod_name, qunt, price, ID_cat, img);
                textBox_PRD_ID.Clear();
                textBox_PRD_Name.Clear();
                textBox_PRD_Price.Clear();
                textBox_PRD_Qunt.Clear();
                


                
                MessageBox.Show("Product Added Successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string prod_id, prod_name, price;
                int qunt, ID_cat;

                prod_id = textBox_PRD_ID.Text;
                prod_name = textBox_PRD_Name.Text;
                price = textBox_PRD_Price.Text;
                qunt = int.Parse(textBox_PRD_Qunt.Text);
                ID_cat = Convert.ToInt32(comboBox_Categories.SelectedValue);
                

                MemoryStream ms = new MemoryStream();
                
                

                byte[] img = ms.ToArray();

                prd.update_products(prod_id, prod_name, qunt, price, ID_cat, img);
                MessageBox.Show("Product up to date Successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Prdct_Mngmnt.main_frm.dataGridView1.DataSource = prd.Get_allprdcts();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox_PRD_ID_Validated(object sender, EventArgs e)
        {
            if (state == "Add")
            {
                if (!prod.Find_ID(textBox_PRD_ID.Text))
                {

                    MessageBox.Show("Poduct ID is already exist", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox_PRD_ID.Focus();
                    textBox_PRD_ID.SelectionStart = 0;
                    textBox_PRD_ID.SelectionLength = textBox_PRD_ID.TextLength;
                }
            }
        }

        

       
    }
}
