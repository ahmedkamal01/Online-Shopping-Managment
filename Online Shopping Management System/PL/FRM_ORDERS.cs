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
using System.Globalization;
namespace Online_Shopping_Management_System.PL
{
    public partial class FRM_ORDERS : Form
    {
        static FRM_ORDERS StOrder;
        public int ID_DeliveryBoy;
        DataTable dt = new DataTable();
        public Dictionary<int, int> Dic_Delivery=new Dictionary<int, int>();

        void CalculateAmount ()
        {
            if (textBox_P_Quantity.Text != string.Empty && textBox_P_Price.Text != string.Empty)
            {
                double Tprice = Convert.ToDouble(textBox_P_Price.Text) * Convert.ToDouble(textBox_P_Quantity.Text);
                if (textBox_P_Discount.Text == string.Empty)
                    textBox_P_Discount.Text = "0";
                
                double rat = Convert.ToDouble(textBox_P_Discount.Text) / 100.00;
                double amo = Tprice - (rat*Tprice);
                    
                textBox_P_Amount.Text = amo.ToString();
            }
            
        }

        void setCoulmnswidth ()
        {
            dataGridView1.RowHeadersWidth = 50;
            dataGridView1.Columns[0].Width = 125;
            dataGridView1.Columns[1].Width = 125;
            dataGridView1.Columns[2].Width = 125;
            dataGridView1.Columns[3].Width = 125;
            dataGridView1.Columns[4].Width = 125;
            dataGridView1.Columns[5].Width = 96;
        }


        void setCoulmns ()
        {
            DataColumn[] dtC = new DataColumn[6];
            dtC[0] = new DataColumn("         Product ID");
            dtC[1] = new DataColumn("     Product Name");
            dtC[2] = new DataColumn("         Quantity");
            dtC[3] = new DataColumn("           Price");
            dtC[4] = new DataColumn("     Discount (%)");
            dtC[5] = new DataColumn("      Amount");
            dt.Columns.AddRange(dtC);
            dataGridView1.DataSource = dt;

        }


        static void closed_static(object sender, FormClosedEventArgs e)
        {
            StOrder = null;
        }

        public static FRM_ORDERS ORDER
        {
            get
            {
                if (StOrder == null)
                {
                    StOrder = new FRM_ORDERS();
                    StOrder.FormClosed += new FormClosedEventHandler(closed_static);
                }
                return StOrder;
            }
        }

        BL.ORDERS order = new BL.ORDERS();

        public FRM_ORDERS()
        {
            InitializeComponent();
            textBox_BellSellsName.Text = Program.salesman;
            if (StOrder == null)
                StOrder = this;
            setCoulmns();
            setCoulmnswidth();
        }


        

        private void button3_Click(object sender, EventArgs e)
        {

            dt.Rows.Clear();

            /*  dataGridView1.Refresh();

                dataGridView1.DataSource = null;
              dataGridView1.Refresh();
              setCoulmns();
              setCoulmnswidth();*/
          //  dataGridView1.Rows.Clear();
            textBox_BelliD.Text = order.Get_Last_order().Rows[0][0].ToString();
            
            btn_new.Enabled = false;
            
           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PL.FRM_CUST_VIEW cust = new PL.FRM_CUST_VIEW();
            cust.Show();
          
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            cleardata();
             btn_save.Enabled = true;
            
            FRM_VIEW_PRODCTS prdct = new FRM_VIEW_PRODCTS();
            prdct.ShowDialog();
            textBox_P_ID.Text = prdct.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox_P_Name.Text = prdct.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox_P_Price.Text = prdct.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox_P_Discount.Focus();

            
        }

        private void textBox_P_Quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar)&& e.KeyChar!=8)
            {
                e.Handled = true;
            }
        }

        private void textBox_P_Quantity_KeyUp(object sender, KeyEventArgs e)
        {
            CalculateAmount();
        }

        private void textBox_P_Quantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && textBox_P_Quantity.Text != string.Empty)
            {
                if (!order.Check_Quantity(textBox_P_ID.Text, Convert.ToInt32(textBox_P_Quantity.Text)))
                {
                    MessageBox.Show("This Product's Quantity is less than yo want", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;

                }
                for (int i=0;i<dataGridView1.Rows.Count;i++)
                {
                    if(dataGridView1.Rows[i].Cells[0].Value.ToString()==textBox_P_ID.Text.ToString())
                    {
                        MessageBox.Show("This Product is Already in the list","Attention",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                        return;
                    }
                    
                }


                DataRow dr = dt.NewRow();

                dr[0] = textBox_P_ID.Text;
                dr[1] = textBox_P_Name.Text;
                dr[2] = textBox_P_Quantity.Text;
                dr[3] = textBox_P_Price.Text;
                dr[4] = textBox_P_Discount.Text;
                dr[5] = textBox_P_Amount.Text;

                dt.Rows.Add(dr);

                dataGridView1.DataSource = dt;
                cleardata();
                btnChoose.Focus();

                textBox_sum.Text = (from DataGridViewRow rw in dataGridView1.Rows
                                    where rw.Cells[5].FormattedValue.ToString() != string.Empty
                                    select Convert.ToDouble(rw.Cells[5].FormattedValue)).Sum().ToString();
            }
            else if (e.KeyCode == Keys.Enter)
            {

                for (int i = 0; i < dataGridView1.Rows.Count ; i++)
                {
                    if (dataGridView1.Rows[i].Cells[0].Value.ToString() == textBox_P_ID.Text.ToString())
                    {
                        MessageBox.Show("This Product is Already in the list", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }

                DataRow dr = dt.NewRow();

                textBox_P_Quantity.Text = "1";
                dr[0] = textBox_P_ID.Text;
                dr[1] = textBox_P_Name.Text;
                dr[2] = textBox_P_Quantity.Text;
                dr[3] = textBox_P_Price.Text;
                dr[4] = textBox_P_Discount.Text;
                dr[5] = textBox_P_Amount.Text;

                dt.Rows.Add(dr);

                dataGridView1.DataSource = dt;
                cleardata();
                btnChoose.Focus();

                textBox_sum.Text = (from DataGridViewRow rw in dataGridView1.Rows
                                    where rw.Cells[5].FormattedValue.ToString() != string.Empty
                                    select Convert.ToDouble(rw.Cells[5].FormattedValue)).Sum().ToString();
            }
        }

        private void textBox_P_Quantity_TextChanged(object sender, EventArgs e)
        {
            CalculateAmount();
        }

        private void textBox_P_Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar!=Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator))
            {
                e.Handled = true;
            }
        }

        private void textBox_P_Discount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator))
            {
                e.Handled = true;
            }
            CalculateAmount();
        }

        private void textBox_P_Price_TextChanged(object sender, EventArgs e)
        {
            CalculateAmount();
        }

        private void textBox_P_Discount_TextChanged(object sender, EventArgs e)
        {
            CalculateAmount();
        }

        private void textBox_P_Discount_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                textBox_P_Price.Focus();

            }
        }

        void cleardata ()
        {
            textBox_P_ID.Clear();
            textBox_P_Name.Clear();
            textBox_P_Quantity.Clear();
            textBox_P_Price.Clear();
            textBox_P_Discount.Clear();
            textBox_P_Amount.Clear();
            
        }

        private void textBox_P_Price_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                textBox_P_Quantity.Focus();
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            textBox_P_ID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox_P_Name.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox_P_Price.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox_P_Quantity.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox_P_Discount.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox_P_Amount.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();

            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            textBox_P_Discount.Focus();
        }

       

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            textBox_sum.Text = (from DataGridViewRow rw in dataGridView1.Rows
                                where rw.Cells[5].FormattedValue.ToString() != string.Empty
                                select Convert.ToDouble(rw.Cells[5].FormattedValue)).Sum().ToString();
        }

       

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1_DoubleClick(sender, e);
        }

        private void deleteThisProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete this product ? ","Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                MessageBox.Show("Product Successfully Deleted", "INFO", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Deleting Canceled");
            }
        }

        private void deleteAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dt.Clear();
            dataGridView1.Refresh();

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (textBox_BellDesc.Text==string.Empty||textBox_custID.Text==string.Empty||dataGridView1.Rows.Count<1)
            {
                MessageBox.Show("Please Fill All Fields");
                return;
            }
            
            order.Add_Order(Convert.ToInt32(textBox_BelliD.Text), DTP.Value, Convert.ToInt32(textBox_custID.Text), textBox_BellDesc.Text, textBox_BellSellsName.Text, ID_DeliveryBoy, textBox_sum.Text);
            for(int i=0;i<dataGridView1.Rows.Count;i++)
            {   
                
                order.Add_products_order(dataGridView1.Rows[i].Cells[0].Value.ToString(), Convert.ToInt32(textBox_BelliD.Text), dataGridView1.Rows[i].Cells[2].Value.ToString(), dataGridView1.Rows[i].Cells[3].Value.ToString(), Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value.ToString()), dataGridView1.Rows[i].Cells[5].Value.ToString());
            }
            MessageBox.Show("Order Saved Successfully","INFO",MessageBoxButtons.OK,MessageBoxIcon.Information);
            btn_new.Enabled = true;
            btn_save.Enabled = false;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FRM_Delivery_Boy del = new FRM_Delivery_Boy();
            del.ShowDialog();
        }
    }
}
