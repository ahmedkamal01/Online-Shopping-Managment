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
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports;
using CrystalDecisions.CrystalReports.Engine;

namespace Online_Shopping_Management_System.PL
{
    public partial class FRM_CAT_Mngmnt : Form
    {
        SqlConnection conn = new SqlConnection(@"server=.\SQL; Database=Online Shopping Management System ; Integrated Security = true");
        SqlDataAdapter da;
        DataTable dt= new DataTable ();
        BindingManagerBase bm;
        CurrencyManager cm;
        SqlCommandBuilder Cb;
        public FRM_CAT_Mngmnt()
        {
            InitializeComponent();
            da = new SqlDataAdapter("select ID_Cat,Name_Cat from Categories", conn);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            textBox_CatID.DataBindings.Add("text", dt, "ID_Cat");
            textBox_CatName.DataBindings.Add("text", dt, "Name_Cat");
            bm = this.BindingContext[dt];
            label3.Text = (bm.Position+1) + "/" + bm.Count;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_first_Click(object sender, EventArgs e)
        {
            bm.Position = 0;
            label3.Text = (bm.Position + 1) + "/" + bm.Count;
        }

        private void btn_last_Click(object sender, EventArgs e)
        {
            bm.Position = bm.Count;
            label3.Text = (bm.Position + 1) + "/" + bm.Count;
        }

        private void btn_previous_Click(object sender, EventArgs e)
        {
            bm.Position -=1 ;
            label3.Text = (bm.Position + 1) + "/" + bm.Count;
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            bm.Position += 1;
            label3.Text = (bm.Position + 1) + "/" + bm.Count;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            bm.AddNew();
            btnNew.Enabled = false;
            add.Enabled = true;
            textBox_CatID.Text = (bm.Count).ToString();
            textBox_CatName.Focus();
        }

        private void add_Click_1(object sender, EventArgs e)
        {
            if (textBox_CatName.Text.Length == 0)
            {
                MessageBox.Show("Empty Text", "Invalid Category Name");
                textBox_CatName.Focus();
            }
            else
            {
                bm.EndCurrentEdit();
                Cb = new SqlCommandBuilder(da);
                da.Update(dt);
                label3.Text = (bm.Position + 1) + "/" + bm.Count;
                MessageBox.Show("Added Successfuly", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnNew.Enabled = true;
                add.Enabled = false;
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are You Sure to Delete " +textBox_CatName.Text+" category ?", "Deleting", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                bm.RemoveAt(bm.Position);
                bm.EndCurrentEdit();
                Cb = new SqlCommandBuilder(da);
                da.Update(dt);
                label3.Text = (bm.Position + 1) + "/" + bm.Count;

                MessageBox.Show("Deleted Successfuly", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
                MessageBox.Show("Deletion Canceled");
            
           
        }

        private void edit_Click(object sender, EventArgs e)
        {
            
            bm.EndCurrentEdit();
            Cb = new SqlCommandBuilder(da);
            da.Update(dt);
            label3.Text = (bm.Position + 1) + "/" + bm.Count;

            MessageBox.Show("Edited Successfuly", "Edit", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void prnt_all_Click(object sender, EventArgs e)
        {
            RPRT.CrystalReport_All_CAT cats = new RPRT.CrystalReport_All_CAT();
            RPRT.PRNT_SNGL_PRD frm = new RPRT.PRNT_SNGL_PRD();
            cats.Refresh();
            frm.crystalReportViewer1.ReportSource = cats;
            frm.Text = "Print All Categories";
            frm.Show();
        }

        private void prnt_Curr_Click(object sender, EventArgs e)
        {
            RPRT.CrystalReport_Sngle_Cat SNcat = new RPRT.CrystalReport_Sngle_Cat();
            RPRT.PRNT_SNGL_PRD frm = new RPRT.PRNT_SNGL_PRD();
            SNcat.Refresh();
            SNcat.SetParameterValue("@ID", int.Parse(textBox_CatID.Text));
            frm.crystalReportViewer1.ReportSource = SNcat;
            frm.Text = "Print Current Category";
            frm.Show();
            
        }

        private void sveCatWprd_Click(object sender, EventArgs e)
        {
            RPRT.CrystalReport_Sngle_Cat cat = new RPRT.CrystalReport_Sngle_Cat();
            cat.SetParameterValue("@ID", int.Parse(textBox_CatID.Text));
            ExportOptions export = new ExportOptions();
            DiskFileDestinationOptions Dist = new DiskFileDestinationOptions();
            PdfFormatOptions pdf = new PdfFormatOptions() ;

            Dist.DiskFileName = @"C: \Users\hima\Desktop\\PDF_Cat.pdf";

            export = cat.ExportOptions;
            export.ExportDestinationType = ExportDestinationType.DiskFile;
            export.ExportFormatType = ExportFormatType.PortableDocFormat;
            export.ExportFormatOptions = pdf;
            export.ExportDestinationOptions = Dist;
            cat.Refresh();
            cat.SetParameterValue("@ID", int.Parse(textBox_CatID.Text));
            cat.Export();

            MessageBox.Show("File Exported on Desktop Successfully", "INFO", MessageBoxButtons.OK);
        }

        private void sveAllCats_Click(object sender, EventArgs e)
        {
            RPRT.CrystalReport_All_CAT cat = new RPRT.CrystalReport_All_CAT();
            ExportOptions export = new ExportOptions();
            DiskFileDestinationOptions Dist = new DiskFileDestinationOptions();
            PdfFormatOptions pdf = new PdfFormatOptions();

            Dist.DiskFileName = @"C: \Users\hima\Desktop\\PDF_All_Cat.pdf";
            
            export = cat.ExportOptions;
            export.ExportDestinationType = ExportDestinationType.DiskFile;
            export.ExportFormatType = ExportFormatType.PortableDocFormat;
            export.ExportFormatOptions = pdf;
            export.ExportDestinationOptions = Dist;
            cat.Refresh();
            cat.Export();

            MessageBox.Show("File Exported on Desktop Successfully", "INFO", MessageBoxButtons.OK);
        }
    }

}
