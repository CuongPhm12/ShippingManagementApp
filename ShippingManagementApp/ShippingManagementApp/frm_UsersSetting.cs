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
    public partial class frm_UsersSetting : Form
    {
        public frm_UsersSetting()
        {
            InitializeComponent();
        }
        async void ReView()
        {
            using(UnitOfWork db = new UnitOfWork())
            {
                dgvUsers.AutoGenerateColumns = false;
                dgvUsers.DataSource = await db.RepositoryPersons.GetAllAsync();
            }
        }
        void TextClear()
        {
            foreach(var pnl in panelAdd.Controls.OfType<Panel>())
            {
                pnl.BackColor = Color.Gainsboro;
                foreach(var txt in pnl.Controls.OfType<TextBox>())
                {
                    txt.Text = string.Empty;
                }
            }
            rbFemale.Checked = rbMale.Checked = false;
            dateBirthDate.Value = DateTime.Now;
            cbPosition.SelectedIndex = 0;
        }

        private void frm_UsersSetting_Load(object sender, EventArgs e)
        {
            dgvUsers.Height = 635;
            //dgvUsers.Rows.Add(new object[] { "100", "James", "Adam", "09/20/1980", "Male", "11111111", "a@gmail.com", "------------" });
            //dgvUsers.Rows.Add(new object[] { "101", "Mary", "Baker", "02/20/1974", "Female", "22222222", "b@gmail.com", "------------" });
            //dgvUsers.Rows.Add(new object[] { "102", "John", "Snyder", "04/21/1983", "Male", "333333333", "c@gmail.com", "------------" });
            //dgvUsers.Rows.Add(new object[] { "103", "Patricia", "Young", "12/30/1990", "Male", "444444444", "d@gmail.com", "------------" });
            //dgvUsers.Rows.Add(new object[] { "104", "Robert", "Miller", "10/11/1982", "Male", "55555555", "e@gmail.com", "------------" });
            //dgvUsers.Rows.Add(new object[] { "105", "Jennifer", "Campbell", "05/03/1986", "Female", "666666666", "g@gmail.com", "------------" });
            ReView();
        }

        private void txtFirstName_MouseClick(object sender, MouseEventArgs e)
        {
            panelFirstName.BackColor = Color.FromArgb(67, 185, 47);
        }

        private void txtFirstName_Leave(object sender, EventArgs e)
        {
            panelFirstName.BackColor = Color.Gainsboro;
        }

        private void txtLastName_MouseClick(object sender, MouseEventArgs e)
        {
            panelLastName.BackColor = Color.FromArgb(67, 185, 47);
        }

        private void txtLastName_Leave(object sender, EventArgs e)
        {
            panelLastName.BackColor = Color.Gainsboro;
        }

        private void txtMobile_MouseClick(object sender, MouseEventArgs e)
        {
            panelMobile.BackColor = Color.FromArgb(67, 185, 47);
        }

        private void txtMobile_Leave(object sender, EventArgs e)
        {
            panelMobile.BackColor = Color.Gainsboro;
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            panelEmail.BackColor = Color.Gainsboro;
        }

        private void txtEmail_MouseClick(object sender, MouseEventArgs e)
        {
            panelEmail.BackColor = Color.FromArgb(67, 185, 47);
        }

        private void txtAddress_MouseClick(object sender, MouseEventArgs e)
        {
            panelAddress.BackColor = Color.FromArgb(67, 185, 47);
        }

        private void txtAddress_Leave(object sender, EventArgs e)
        {
            panelAddress.BackColor = Color.Gainsboro;
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

        private void txtRe_Password_MouseClick(object sender, MouseEventArgs e)
        {
            panelRe_Password.BackColor = Color.FromArgb(67, 185, 47);
        }

        private void txtRe_Password_Leave(object sender, EventArgs e)
        {
            panelRe_Password.BackColor = Color.Gainsboro;
        }

        private void dateBirthDate_MouseDown(object sender, MouseEventArgs e)
        {
            panelBirthDate.BackColor = Color.FromArgb(67, 185, 47);

        }

        private void dateBirthDate_Leave(object sender, EventArgs e)
        {
            panelBirthDate.BackColor = Color.Gainsboro;
        }

        private void cbEducation_MouseDown(object sender, MouseEventArgs e)
        {
            panelPosition.BackColor = Color.FromArgb(67, 185, 47);
        }

        private void cbEducation_Leave(object sender, EventArgs e)
        {
            panelEducation.BackColor = Color.Gainsboro;
        }
        private void cbPosition_MouseDown(object sender, MouseEventArgs e)
        {
            panelEducation.BackColor = Color.FromArgb(67, 185, 47);
        }

        private void cbPosition_Leave(object sender, EventArgs e)
        {
            panelPosition.BackColor = Color.Gainsboro;
        }

        private void rbMale_MouseDown(object sender, MouseEventArgs e)
        {
            panelGender.BackColor = Color.FromArgb(67, 185, 47);
        }

        private void rbMale_Leave(object sender, EventArgs e)
        {
            panelGender.BackColor = Color.Gainsboro;
        }

        private void rbFemale_MouseDown(object sender, MouseEventArgs e)
        {
            panelGender.BackColor = Color.FromArgb(67, 185, 47);
        }

        private void rbFemale_Leave(object sender, EventArgs e)
        {
            panelGender.BackColor = Color.Gainsboro;

        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            foreach (var pnl in panelAdd.Controls.OfType<Panel>())
            {
                pnl.BackColor = Color.Gainsboro;
                foreach (var txt in pnl.Controls.OfType<TextBox>())
                {
                    if(txt.Text == string.Empty)
                    {
                        pnl.BackColor = Color.FromArgb(183,9,76);
                    }
                }
            }
            if(rbFemale.Checked == false && rbMale.Checked == false)
            {
                panelGender.BackColor = Color.FromArgb(183, 9, 76);
            }
            if (cbPosition.SelectedIndex ==0)
            {
                panelPosition.BackColor = Color.FromArgb(183, 9, 76);
            }
            if (dateBirthDate.Text == string.Empty)
            {
                panelBirthDate.BackColor = Color.FromArgb(183, 9, 76);
            }
            if (txtPassword.Text != txtRe_Password.Text)
            {
                panelPassword.BackColor = panelRe_Password.BackColor = Color.FromArgb(183, 9, 76);
            }else if (txtFirstName.Text != string.Empty & txtLastName.Text != string.Empty &cbEducation.SelectedIndex !=0 & cbPosition.SelectedIndex != 0)
            {
                if(lbTitle.Text == "Add User")
                {
                    using(UnitOfWork db = new UnitOfWork())
                    {
                        await db.RepositoryPersons.InsertAsync(txtFirstName.Text,txtLastName.Text,(rbMale.Checked)?true:false,;
                    }
                }
                else
                {
                    using (UnitOfWork db = new UnitOfWork())
                    {
                        await db.RepositoryPersons.UpdateAsync();
                    }
                }
                ReView();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnPassword.Visible = btnRe_Password.Visible =
            panelPassword.Visible = panelRe_Password.Visible =
            lbPassword.Visible = lbRe_Password.Visible = true;
            dgvUsers.Height = 635;
            tlpPanelTop.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TextClear();
            lbTitle.Text = "Add User";
            dgvUsers.Height = 0;
            tlpPanelTop.Enabled = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            TextClear();
            btnPassword.Visible = btnRe_Password.Visible =
            panelPassword.Visible = panelRe_Password.Visible =
            lbPassword.Visible = lbRe_Password.Visible = false;
            lbTitle.Text = "Edit User";
            dgvUsers.Height = 0;
            tlpPanelTop.Enabled = false;
            if(dgvUsers.CurrentRow != null)
            {
                txtFirstName.Text = dgvUsers.Rows[0].Cells[1].Value.ToString();
                txtLastName.Text = dgvUsers.Rows[0].Cells[2].Value.ToString();
                txtEmail.Text = dgvUsers.Rows[0].Cells[6].Value.ToString();
                txtAddress.Text = dgvUsers.Rows[0].Cells[7].Value.ToString();
                txtMobile.Text = dgvUsers.Rows[0].Cells[5].Value.ToString();

            }

        }

        private void btnRe_Password_Click(object sender, EventArgs e)
        {
            if (btnRe_Password.ImageIndex == 0)
            {
                btnRe_Password.ImageIndex = 1;
                txtRe_Password.UseSystemPasswordChar = true;
            }
            else
            {
                btnRe_Password.ImageIndex = 0;
                txtRe_Password.UseSystemPasswordChar = false;
            }
        }

        private void btnPassword_Click(object sender, EventArgs e)
        {
            if (btnPassword.ImageIndex == 0)
            {
                btnPassword.ImageIndex = 1;
                txtPassword.UseSystemPasswordChar = true;
            }
            else
            {
                btnPassword.ImageIndex = 0;
                txtPassword.UseSystemPasswordChar = false;
            }
        }

    }
}
