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
    public partial class FRM_Delivery_Boy : Form
    { 
        //===================================================
       

        BindingManagerBase BM;
        SqlDataAdapter DA;
        DataTable Dt= new DataTable();
        SqlConnection MyCon = new SqlConnection(@"server=.\SQL; Database=Online Shopping Management System ; Integrated Security = true");
        SqlCommandBuilder SQL_CB;
        //===================================================

        public FRM_Delivery_Boy()
        {
            InitializeComponent();
            DA = new SqlDataAdapter("select * from [Delivery Mens]", MyCon);
            DA.Fill(Dt);
            dataGridView1.DataSource = Dt;
            textBox_ID.DataBindings.Add("text", Dt, "DeliveryMan_ID");
            textBox_name.DataBindings.Add("text",Dt, "DelieveryMAn_Name");
            textBox_phone.DataBindings.Add("text", Dt, "phone");
            BM = this.BindingContext[Dt];
        }

        

        private void btn_new_Click(object sender, EventArgs e)
        {
            BM.AddNew();
            textBox_ID.Text = BM.Count.ToString();
            textBox_phone.ReadOnly = false;
            textBox_name.ReadOnly = false;
        }

       

        private void btn_edit_Click(object sender, EventArgs e)
        {
            textBox_name.ReadOnly = false;
            textBox_phone.ReadOnly = false;
           
        }

        private void textBox_name_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox_name.Text == string.Empty && textBox_phone.Text == string.Empty)
                {
                    MessageBox.Show("Empty Text");
                    textBox_name.Focus();
                }
                else
                {
                    BM.EndCurrentEdit();
                    SQL_CB = new SqlCommandBuilder(DA);
                    DA.Update(Dt);
                    MessageBox.Show("Delivery Boy Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox_ID.ReadOnly = true;
                    textBox_phone.ReadOnly = true;
                    textBox_name.ReadOnly = true;

                }
               
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            BM.EndCurrentEdit();
            SQL_CB = new SqlCommandBuilder(DA);
            DA.Update(Dt);
            MessageBox.Show("Delivery Boy Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure to Delete " + textBox_name.Text + " category ?", "Deleting", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                BM.RemoveAt(BM.Position);
                BM.EndCurrentEdit();
                SQL_CB = new SqlCommandBuilder(DA);
                DA.Update(Dt);
                
                MessageBox.Show("Deleted Successfuly", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
                MessageBox.Show("Deletion Canceled");
        }

      

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRM_Delivery_Boy_FormClosing(object sender, FormClosingEventArgs e)
        {
           
            if (FRM_ORDERS.ORDER.Dic_Delivery.ContainsKey(Convert.ToInt32(textBox_ID.Text)))
                FRM_ORDERS.ORDER.Dic_Delivery[Convert.ToInt32(textBox_ID.Text)]++;
            else
                FRM_ORDERS.ORDER.Dic_Delivery.Add(Convert.ToInt32(textBox_ID.Text),1);
            if (FRM_ORDERS.ORDER.Dic_Delivery[Convert.ToInt32(textBox_ID.Text)] > 2)
            {
                MessageBox.Show("This Delivery Man IS Busy now , please select Anothor one");
                return;
            }
            FRM_ORDERS.ORDER.textBox_Del_Name.Text = textBox_name.Text;
            FRM_ORDERS.ORDER.ID_DeliveryBoy = Convert.ToInt32(textBox_ID.Text);
            
        }
    }
}
