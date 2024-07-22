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
    public partial class frm_UsersSetting : Form
    {
        public frm_UsersSetting()
        {
            InitializeComponent();
        }
        async void ReView()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                dgvUsers.AutoGenerateColumns = false;
                dgvUsers.DataSource = await db.RepositoryPersons.GetAllAsync();
            }
        }

        void OpenClos()
        {

            if (dgvUsers.Height == 0)
            {
                dgvUsers.Height = 635;
            }
            else
            {
                dgvUsers.Height = 0;
                tlpPanelTop.Enabled = false;
            }
            if (lbTitle.Text == "Add User")
                btnPassword.Visible = btnRe_Password.Visible = panelPassword.Visible = panelRe_Password.Visible = lbPassword.Visible = lbRe_Password.Visible = true;
            else
                btnPassword.Visible = btnRe_Password.Visible = panelPassword.Visible = panelRe_Password.Visible = lbPassword.Visible = lbRe_Password.Visible = false;

        }
        void TextClear()
        {
            foreach (var pnl in panelAdd.Controls.OfType<Panel>())
            {
                pnl.BackColor = Color.Gainsboro;
                foreach (var txt in pnl.Controls.OfType<TextBox>())
                {
                    txt.Text = string.Empty;
                }
            }
            txtUsername.Text = string.Empty;
            rbFemale.Checked = rbMale.Checked = false;
            dateBirthDate.Value = DateTime.Now;
            cbPosition.SelectedIndex = 0;
            cbEducation.SelectedIndex = 0;
        }

        private void frm_UsersSetting_Load(object sender, EventArgs e)
        {
            dgvUsers.Height = this.Height;
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
                    if (txt.Text == string.Empty)
                    {
                        pnl.BackColor = Color.FromArgb(183, 9, 76);
                    }
                }
            }
            if (rbFemale.Checked == false && rbMale.Checked == false)
            {
                panelGender.BackColor = Color.FromArgb(183, 9, 76);
            }
            if (cbPosition.SelectedIndex == 0)
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
            }
            else if (txtFirstName.Text != string.Empty & txtLastName.Text != string.Empty & cbEducation.SelectedIndex != 0 & cbPosition.SelectedIndex != 0)
            {
                var pass = CryptoServices.HashPass_SHA256(txtPassword.Text.Trim());
                if (lbTitle.Text == "Add User")
                {
                    using (UnitOfWork db = new UnitOfWork())
                    {
                        await db.RepositoryPersons.InsertAsync(txtFirstName.Text, txtLastName.Text, (rbMale.Checked) ? true : false, dateBirthDate.Text
                            , cbEducation.SelectedIndex, txtEmail.Text, txtMobile.Text, true, txtAddress.Text, cbPosition.SelectedIndex,
                            txtUsername.Text, pass, DateTime.Now.ToString());
                    }
                }
                else
                {
                    using (UnitOfWork db = new UnitOfWork())
                    {
                        await db.RepositoryPersons.UpdateAsync(Convert.ToInt32(txtPersonID.Text), txtFirstName.Text, txtLastName.Text, (rbMale.Checked) ? true : false,
                            dateBirthDate.Text, cbEducation.SelectedIndex, txtEmail.Text, txtMobile.Text, true, txtAddress.Text, cbPosition.SelectedIndex,
                            txtUsername.Text, txtPassword.Text, DateTime.Now.ToString());
                    }
                }
                OpenClos();
                ReView();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            OpenClos();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TextClear();
            lbTitle.Text = "Add User";
            OpenClos();
        }

        private async void btnEdit_Click(object sender, EventArgs e)
        {
            TextClear();
            lbTitle.Text = "Edit User";
            OpenClos();
            if (dgvUsers.CurrentRow != null)
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    var person = (await db.RepositoryPersons.GetAllAsync()).SingleOrDefault(x => x.PersonID == (int)dgvUsers.CurrentRow.Cells[0].Value);
                    txtPersonID.Text = person.PersonID.ToString();
                    dateBirthDate.Text = person.BirthDate;
                    txtFirstName.Text = person.FirstName;
                    txtLastName.Text = person.LastName;
                    cbEducation.SelectedIndex = person.EducationID;
                    txtEmail.Text = person.Email;
                    txtAddress.Text = person.Address;
                    txtMobile.Text = person.Mobile;
                    rbMale.Checked = (person.Gender == "Male") ? true : false;
                    rbFemale.Checked = (person.Gender == "Male") ? true : false;
                    txtUsername.Text = person.UserName;
                    cbPosition.SelectedIndex = person.PositionID;

                }

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

        private async void txtSearch_TextChanged(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                dgvUsers.AutoGenerateColumns = false;
                dgvUsers.DataSource = await db.RepositoryPersons.GetSearchAsync(txtSearch.Text);
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {

            if (dgvUsers.CurrentRow != null)
            {
                if (MessageBox.Show("Are you sure you want to delete" + dgvUsers.CurrentRow.Cells[1].Value + "?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    using (UnitOfWork db = new UnitOfWork())
                    {
                        var id = (int)dgvUsers.CurrentRow.Cells[0].Value;

                        await db.RepositoryPersons.DeleteAsync(id);
                    }
                    ReView();
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ReView();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }
    }
}
