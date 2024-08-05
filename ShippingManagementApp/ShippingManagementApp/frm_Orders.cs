using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShippingManagementApp
{
    public partial class frm_Orders : Form
    {
        public frm_Orders()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (panelAddPage1.Width == panelAdd.Width)
            {

                panelAddPage1.Width = 40;
                btnNext.ImageIndex = 1;
            }
            else
            {
                panelAddPage1.Width = panelAdd.Width;
                btnNext.ImageIndex = 0;
            }
        }
    }
}
