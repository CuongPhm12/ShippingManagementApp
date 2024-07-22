using Artan.BLL;
using Artan.DLL.Context;
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
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private void txtUsername_MouseClick(object sender, MouseEventArgs e)
        {
            panelUsername.BackColor = Color.FromArgb(67, 185, 47);
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            panelUsername.BackColor = Color.Gainsboro;
        }



        private void txtPassword_MouseClick(object sender, MouseEventArgs e)
        {
            panelPassword.BackColor = Color.FromArgb(67, 185, 47);
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            panelPassword.BackColor = Color.Gainsboro;
        }


        private void cbPosition_Leave(object sender, EventArgs e)
        {
            panelPosition.BackColor = Color.Gainsboro;
        }

        private void cbPosition_MouseDown(object sender, MouseEventArgs e)
        {
            panelPosition.BackColor = Color.FromArgb(67, 185, 47);
        }

        private void frm_Login_Load(object sender, EventArgs e)
        {
            cbPosition.SelectedIndex = 0;
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            foreach (var pnl in this.Controls.OfType<Panel>())
            {
                pnl.BackColor = Color.Gainsboro;
                panel1.BackColor = Color.FromArgb(183, 9, 76);
                foreach (var txt in pnl.Controls.OfType<TextBox>())
                {
                    if (txt.Text == string.Empty)
                    {
                        pnl.BackColor = Color.FromArgb(183, 9, 76);
                    }
                }
            }
            if (cbPosition.SelectedIndex == 0)
            {
                panelPosition.BackColor = Color.FromArgb(183, 9, 76);
            }
            if (txtUsername.Text != string.Empty && txtPassword.Text != string.Empty && cbPosition.SelectedIndex != 0)
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    var pass = CryptoServices.HashPass_SHA256(txtPassword.Text.Trim());
                    if (await db.RepositoryPersons.LoginAsync(txtUsername.Text.Trim(), pass, cbPosition.SelectedIndex) == true)
                    {
                        this.Hide();
                        Form1 form1 = new Form1();
                        form1.Show();
                    }
                    else
                        MessageBox.Show("Wrong Username or Password", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }



        }
    }
}
