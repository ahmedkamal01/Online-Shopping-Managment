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
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.CrystalReports;
using CrystalDecisions.Shared;
namespace Online_Shopping_Management_System.PL
{
    public partial class Prdct_Mngmnt : Form
    {
        public static Prdct_Mngmnt mfr;

        static void closed_static(object sender, FormClosedEventArgs e)
        {
            mfr = null;
        }

        public static Prdct_Mngmnt main_frm
        {
            get
            {
                if (mfr == null)
                {
                    mfr = new Prdct_Mngmnt();
                    mfr.FormClosed += new FormClosedEventHandler(closed_static);
                }
                return mfr;
            }
        }

        byte[] image;
         
        BL.Product prd = new BL.Product();
        
        public Prdct_Mngmnt()
        {
            InitializeComponent();
            if (mfr == null) mfr = this;
            dataGridView1.DataSource = prd.Get_allprdcts();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable Dt = new DataTable();
            Dt=prd.Search(textBox1.Text);
            dataGridView1.DataSource = Dt;
        }

        private void Add_New_prdct_Click(object sender, EventArgs e)
        {
            FRM_ADD_PRODUCT add = new FRM_ADD_PRODUCT();
            add.Show();
            
        }

        private void Add_New_prdct_Leave(object sender, EventArgs e)
        {
            dataGridView1.DataSource = prd.Get_allprdcts();
        }

        private void Delete_prdct_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do You Want to Continue deleting the product ?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)==DialogResult.OK)
            {
                prd.Delete(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                dataGridView1.DataSource = prd.Get_allprdcts();
                MessageBox.Show("Item Successfull Deleted", "Success", MessageBoxButtons.OK);
                
            } 
            else
            {
                MessageBox.Show("Action Canceled", "Abort", MessageBoxButtons.OK);

            }
            
        }

        private void Edit_Prdct_Click(object sender, EventArgs e)
        {
            FRM_ADD_PRODUCT edit = new FRM_ADD_PRODUCT();
            edit.textBox_PRD_ID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            edit.textBox_PRD_Name.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            edit.textBox_PRD_Qunt.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            edit.textBox_PRD_Price.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            edit.comboBox_Categories.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            edit.Text = "Updating product  " +"\" "+ dataGridView1.CurrentRow.Cells[1].Value.ToString()+ " \"";
            edit.AddProduct.Text = "Update";
            edit.state = "Update";
            edit.textBox_PRD_ID.ReadOnly = true;

            //-----------------------------------------------------------------------------------

            //throw exception Read Time out - Write Time Out
           image  = (byte[])prd.get_image(dataGridView1.CurrentRow.Cells[0].Value.ToString()).Rows[0][0];
            MemoryStream ms = new MemoryStream(image);
            edit.pictureBox_PRD_Img.Image = Image.FromStream(ms);
            
            edit.Show();

            

        }

        private void Show_img_Click(object sender, EventArgs e)
        {
            SHOW_PIC pic = new SHOW_PIC();
            image = (byte[])prd.get_image(dataGridView1.CurrentRow.Cells[0].Value.ToString()).Rows[0][0];
            MemoryStream ms = new MemoryStream(image);
            pic.pictureBox1.Image = Image.FromStream(ms);
            pic.Show();
        }

        private void Print_selctd_Click(object sender, EventArgs e)
        {
            RPRT.PRNT_SNGL_PRD rprt = new RPRT.PRNT_SNGL_PRD();
            RPRT.CrystalReport_SNGL_PRDCT prd = new RPRT.CrystalReport_SNGL_PRDCT();
            prd.SetParameterValue("@ID", dataGridView1.CurrentRow.Cells[0].Value.ToString());
            rprt.crystalReportViewer1.ReportSource = prd ;
            rprt.Show(); 
        }

        private void Print_All_Click(object sender, EventArgs e)
        {
            RPRT.CrystalReport_ALL_PRDCTS crs = new RPRT.CrystalReport_ALL_PRDCTS();
            RPRT.PRNT_SNGL_PRD prd = new RPRT.PRNT_SNGL_PRD();
            prd.crystalReportViewer1.ReportSource = crs;
            prd.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sve_excel_Click(object sender, EventArgs e)
        {
            RPRT.CrystalReport_ALL_PRDCTS prd = new RPRT.CrystalReport_ALL_PRDCTS();

            ExportOptions ex = new ExportOptions();

            DiskFileDestinationOptions dist = new DiskFileDestinationOptions();

            ExcelFormatOptions excel = new ExcelFormatOptions();

            dist.DiskFileName = @"C:\Users\hima\Desktop\\Excel_Sheet.xls";

            ex = prd.ExportOptions;

            ex.ExportDestinationType = ExportDestinationType.DiskFile;

            ex.ExportFormatType = ExportFormatType.Excel;

            ex.ExportFormatOptions = excel;

            ex.ExportDestinationOptions = dist;

            prd.Export();

            MessageBox.Show("File Exported on Desktop Successfully","INFO",MessageBoxButtons.OK);
        }
    }
}
