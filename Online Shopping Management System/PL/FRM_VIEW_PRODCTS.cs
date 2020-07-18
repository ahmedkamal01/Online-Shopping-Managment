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
    public partial class FRM_VIEW_PRODCTS : Form
    {
        BL.Product prd = new BL.Product();

        public FRM_VIEW_PRODCTS()
        {
            InitializeComponent();
            dataGridView1.DataSource = prd.Get_allprdcts();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
