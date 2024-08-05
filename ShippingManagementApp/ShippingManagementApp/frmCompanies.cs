using Artan.DLL.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShippingManagementApp
{
    public partial class frmCompanies : Form
    {
        public frmCompanies()
        {
            InitializeComponent();
        }
        async void ReView()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                dgvCompany.AutoGenerateColumns = false;
                dgvCompany.DataSource = await db.RepositoryCompanies.GetAllAsync();
            }
        }

        void OpenClos()
        {

            if (dgvCompany.Height == 0)
            {
                dgvCompany.Height = 635;
            }
            else
            {
                dgvCompany.Height = 0;
                tlpPanelTop.Enabled = false;
            }


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
            txtCompanyID.Text = string.Empty;
            rbActive.Checked = rbInActive.Checked = false;
            dateCollaborationDate.Value = DateTime.Now;
            cbCompanyType.SelectedIndex = 0;

        }

        private void frmCompanies_Load(object sender, EventArgs e)
        {
            dgvCompany.Height = this.Height;
            ReView();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            TextClear();
            lbTitle.Text = "Add Company";
            OpenClos();
        }

        private async void btnEdit_Click(object sender, EventArgs e)
        {
            TextClear();
            lbTitle.Text = "Edit User";
            OpenClos();
            if (dgvCompany.CurrentRow != null)
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    var company = (await db.RepositoryCompanies.GetAllAsync()).SingleOrDefault(x => x.CompanyID == (int)dgvCompany.CurrentRow.Cells[0].Value);
                    txtCompanyID.Text = company.CompanyID.ToString();
                    dateCollaborationDate.Text = company.CollaborationDate;
                    txtCompanyName.Text = company.CompanyName;
                    txtRepresentative.Text = company.Representative;
                    cbCompanyType.SelectedIndex = (company.CompanyType=="true")?0:1;
                    txtEmail.Text = company.Email;
                    txtAddress.Text = company.Address;
                    txtMobile.Text = company.Mobile;
                    txtPhone.Text = company.Phone;
                    txtFax.Text = company.Fax;
                    rbActive.Checked = (company.Status == "Male") ? true : false;
                    rbInActive.Checked = (company.Status == "Male") ? true : false;
                    picCompany.Image = ConvertBinaryToImage(company.Pic);

                }

            }

        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {

            if (dgvCompany.CurrentRow != null)
            {
                if (MessageBox.Show("Are you sure you want to delete" + dgvCompany.CurrentRow.Cells[1].Value + "company?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    using (UnitOfWork db = new UnitOfWork())
                    {
                        var id = (int)dgvCompany.CurrentRow.Cells[0].Value;

                        await db.RepositoryCompanies.DeleteAsync(id);
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

        private void btnPicOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                picCompany.ImageLocation = openFile.FileName;
            }
        }

        private void btnPicDelete_Click(object sender, EventArgs e)
        {
            picCompany.Image = picCompany.ErrorImage;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                dgvCompany.AutoGenerateColumns = false;
                //dgvCompany.DataSource = await db.RepositoryPersons.GetSearchAsync(txtSearch.Text);
            }
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
            if (rbActive.Checked == false && rbInActive.Checked == false)
            {
                panelStatus.BackColor = Color.FromArgb(183, 9, 76);
            }
            if (cbCompanyType.SelectedIndex == 0)
            {
                panelCompanyType.BackColor = Color.FromArgb(183, 9, 76);
            }
            if (dateCollaborationDate.Text == string.Empty)
            {
                panelCollaborationDate.BackColor = Color.FromArgb(183, 9, 76);
            }

            else if (txtRepresentative.Text != string.Empty & txtPhone.Text != string.Empty & txtMobile.Text != string.Empty
                & cbCompanyType.SelectedIndex != 0)
            {

                if (lbTitle.Text == "Add Company")
                {

                    using (UnitOfWork db = new UnitOfWork())
                    {
                        await db.RepositoryCompanies.InsertAsync(txtCompanyName.Text, txtRepresentative.Text, (cbCompanyType.SelectedIndex == 0) ? true : false, dateCollaborationDate.Text,
                            txtEmail.Text, txtPhone.Text, txtMobile.Text, txtFax.Text, (rbActive.Checked) ? true : false, txtAddress.Text, ConvertImageToBinary(picCompany.Image), DateTime.Now.ToString());
                    }
                }
                else
                {
                    using (UnitOfWork db = new UnitOfWork())
                    {
                        await db.RepositoryCompanies.UpdateAsync(int.Parse(txtCompanyID.Text), txtCompanyName.Text, txtRepresentative.Text, (cbCompanyType.SelectedIndex == 0) ? true : false, dateCollaborationDate.Text,
                            txtEmail.Text, txtMobile.Text, txtFax.Text, (rbActive.Checked) ? true : false, txtAddress.Text, ConvertImageToBinary(picCompany.Image), DateTime.Now.ToString());
                    }
                }
                OpenClos();
                ReView();
            }
        }

        byte[] ConvertImageToBinary(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                var i = new Bitmap(image);
                i.Save(ms, ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }
        Image ConvertBinaryToImage(byte[] image)
        {
            using (MemoryStream ms = new MemoryStream(image))
            {

                return Image.FromStream(ms);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            OpenClos();
        }

        private void cbCompanyType_MouseDown(object sender, MouseEventArgs e)
        {
            panelCompanyType.BackColor = Color.FromArgb(67, 185, 47);
        }

        private void cbCompanyType_Leave(object sender, EventArgs e)
        {
            panelCompanyType.BackColor = Color.Gainsboro;
        }

        private void dateCollaborationDate_MouseDown(object sender, MouseEventArgs e)
        {
            panelCollaborationDate.BackColor = Color.FromArgb(67, 185, 47);
        }

        private void dateCollaborationDate_Leave(object sender, EventArgs e)
        {
            panelCollaborationDate.BackColor = Color.Gainsboro;
        }

        private void rbActive_MouseDown(object sender, MouseEventArgs e)
        {
            panelStatus.BackColor = Color.FromArgb(67, 185, 47);
        }

        private void rbInActive_MouseDown(object sender, MouseEventArgs e)
        {
            panelStatus.BackColor = Color.FromArgb(67, 185, 47);
        }

        private void rbInActive_Leave(object sender, EventArgs e)
        {
            panelStatus.BackColor = Color.Gainsboro;
        }

        private void rbActive_Leave(object sender, EventArgs e)
        {
            panelStatus.BackColor = Color.Gainsboro;
        }

        private void txtCompanyName_MouseClick(object sender, MouseEventArgs e)
        {
            panelCompanyName.BackColor = Color.FromArgb(67, 185, 47);
        }

        private void txtCompanyName_Leave(object sender, EventArgs e)
        {
            panelCompanyName.BackColor = Color.Gainsboro;
        }

        private void txtRepresentative_MouseClick(object sender, MouseEventArgs e)
        {
            panelRepresentative.BackColor = Color.FromArgb(67, 185, 47);
        }

        private void txtRepresentative_Leave(object sender, EventArgs e)
        {
            panelRepresentative.BackColor = Color.Gainsboro;
        }

        private void txtPhone_MouseClick(object sender, MouseEventArgs e)
        {
            panelPhone.BackColor = Color.FromArgb(67, 185, 47);
        }

        private void txtPhone_Leave(object sender, EventArgs e)
        {
            panelPhone.BackColor = Color.Gainsboro;
        }

        private void txtMobile_MouseClick(object sender, MouseEventArgs e)
        {
            panelMobile.BackColor = Color.FromArgb(67, 185, 47);
        }

        private void txtMobile_Leave(object sender, EventArgs e)
        {
            panelMobile.BackColor = Color.Gainsboro;
        }

        private void txtFax_MouseClick(object sender, MouseEventArgs e)
        {
            panelFax.BackColor = Color.FromArgb(67, 185, 47);

        }

        private void txtFax_Leave(object sender, EventArgs e)
        {
            panelFax.BackColor = Color.Gainsboro;
        }

        private void txtEmail_MouseClick(object sender, MouseEventArgs e)
        {
            panelEmail.BackColor = Color.FromArgb(67, 185, 47);
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            panelEmail.BackColor = Color.Gainsboro;
        }
    }
}
