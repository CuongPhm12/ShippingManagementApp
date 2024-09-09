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
    public partial class frm_Orders : Form
    {
        public frm_Orders()
        {
            InitializeComponent();
        }

        async void ReView()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                dgvOrder.AutoGenerateColumns = false;
                dgvOrder.DataSource = await db.RepositoryOrder.GetAllAsync();
            }
        }

        void OpenClos()
        {
            if (dgvOrder.Height == 0)
            {
                dgvOrder.Height = 645;
                tlpPanelTop.Enabled = true;
            }
            else
            {
                dgvOrder.Height = 0;
                tlpPanelTop.Enabled = false;
            }
        }
        async void TextClear()
        {
            foreach (var pnl in panelAdd.Controls.OfType<Panel>())
            {
                pnl.BackColor = Color.Gainsboro;
                foreach (var txt in pnl.Controls.OfType<TextBox>())
                {
                    txt.Text = string.Empty;
                }
            }
            foreach (var pnl in panelAddPage2.Controls.OfType<Panel>())
            {
                pnl.BackColor = Color.Gainsboro;
                foreach (var txt in pnl.Controls.OfType<TextBox>())
                {
                    txt.Text = string.Empty;
                }
            }
            foreach (var pnl in panelAddPage1.Controls.OfType<Panel>())
            {
                pnl.BackColor = Color.Gainsboro;
                foreach (var txt in pnl.Controls.OfType<TextBox>())
                {
                    txt.Text = string.Empty;
                }
            }
            txtOrderID.Text = string.Empty;
            rbOrigin.Checked = rbDestination.Checked = rbPaid.Checked = rbUnpaid.Checked = false;
            dateOrderDate.Value = DateTime.Now;
            using (UnitOfWork db = new UnitOfWork())
            {
                List<vw_Companies> list = new List<vw_Companies>();
                list.Add(new vw_Companies() { CompanyID = 0, NameCo = "--Selected--" });
                list.AddRange(await db.RepositoryCompanies.GetAllAsync());
                cbSenderID.ValueMember = "CompanyID";
                cbSenderID.DisplayMember = "NameCo";
                cbSenderID.DataSource = list;


                List<vw_Companies> list2 = new List<vw_Companies>();
                list2.Add(new vw_Companies() { CompanyID = 0, NameCo = "--Selected--" });
                list2.AddRange(await db.RepositoryCompanies.GetAllAsync());
                cbReceiverID.ValueMember = "CompanyID";
                cbReceiverID.DisplayMember = "NameCo";
                cbReceiverID.DataSource = list2;

                List<tbl_Post> listPost = new List<tbl_Post>();
                listPost.Add(new tbl_Post() { PostID = 0, PostTitle = "--Selected--" });
                listPost.AddRange(await db.RepositoryPost.GetAllAsync());
                cbPostType.ValueMember = "PostID";
                cbPostType.DisplayMember = "PostTitle";
                cbPostType.DataSource = listPost;

                List<tbl_Package> listPackage = new List<tbl_Package>();
                listPackage.Add(new tbl_Package() { PackageID = 0, PackageTitle = "--Selected--" });
                listPackage.AddRange(await db.RepositoryPackage.GetAllAsync());
                cbPackageType.ValueMember = "PackageID";
                cbPackageType.DisplayMember = "PackageTitle";
                cbPackageType.DataSource = listPackage;

                List<tbl_Condition> listCondition = new List<tbl_Condition>();
                listCondition.Add(new tbl_Condition() { ConditionID = 0, ConditionTitle = "--Selected--" });
                listCondition.AddRange(await db.RepositoryCondition.GetAllAsync());
                cbCondition.ValueMember = "ConditionID";
                cbCondition.DisplayMember = "ConditionTitle";
                cbCondition.DataSource = listCondition;

            }
            cbCondition.SelectedIndex = cbPackageType.SelectedIndex = cbPostType.SelectedIndex
                = cbReceiverID.SelectedIndex = cbSenderID.SelectedIndex = 0;

        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (panelAddPage2.Width == panelAdd.Width)
            {

                panelAddPage2.Width = 0;
                btnNext.ImageIndex = 1;
            }
            else
            {
                panelAddPage2.Width = panelAdd.Width;
                btnNext.ImageIndex = 0;
            }
        }

        private void frm_Orders_Load(object sender, EventArgs e)
        {
            dgvOrder.Height = 650;
            panelAddPage2.Width = 0;

        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            TextClear();
            using (UnitOfWork db = new UnitOfWork())
            {

                lbTitle.Text = "Add Order";
                if (dgvOrder.CurrentRow != null)
                    txtOrderID.Text = ((await db.RepositoryOrder.GetAllAsync()).Max().OrderID + 1).ToString();
                else
                    txtOrderID.Text = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + 1;
            }
            OpenClos();

        }

        private async void btnEdit_Click(object sender, EventArgs e)
        {
            TextClear();
            lbTitle.Text = "Edit User";
            OpenClos();
            if (dgvOrder.CurrentRow != null)
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    var order = (await db.RepositoryOrder.GetAllAsync()).SingleOrDefault(x => x.OrderID == (int)dgvOrder.CurrentRow.Cells[0].Value);
                    txtOrderID.Text = order.OrderID.ToString();
                    dateOrderDate.Text = order.OrderDate;
                    cbCondition.SelectedValue = order.ConditionTitle;
                    rbPaid.Checked = (order.PaymentStatus == "Paid") ? true : false;
                    rbUnpaid.Checked = (order.PaymentStatus == "Paid") ? false : true;
                    cbSenderID.SelectedValue = order.SenderID;
                    txtSender.Text = order.Sender;
                    txtSenderName.Text = order.SenderName;
                    txtMobileSender.Text = order.SenderMobile;
                    txtSenderAddress.Text = order.SenderAddress;
                    cbReceiverID.SelectedValue = order.ReceiverID;
                    txtReceiver.Text = order.Receiver;
                    txtReceiverName.Text = order.ReceiverName;
                    txtMobileReceiver.Text = order.ReceiverMobile;
                    txtReceiverAddress.Text = order.ReceiverAddress;
                    cbPostType.SelectedValue = order.PostTitle;
                    cbPackageType.SelectedValue = order.PackageTitle;
                    rbOrigin.Checked = (order.PaymentType == "Origin") ? true : false;
                    rbDestination.Checked = (order.PaymentType == "Origin") ? false : true;
                    txtWeight.Text = order.Weight;
                    numUDNumber.Text = order.Number;
                    txtTotalCost.Text = order.TotalCost;
                    txtAdministrativeCosts.Text = order.AdminstrativeCosts;
                    //txtServiceCosts.Text = order.ServiceCosts;
                    txtShippingCosts.Text = order.ShippingCosts;
                    txtDiscount.Text = order.Discount;
                    txtDescription.Text = order.Description;



                }

            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvOrder.CurrentRow != null)
            {
                if (MessageBox.Show("Are you sure you want to delete" + dgvOrder.CurrentRow.Cells[1].Value + "Order?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    using (UnitOfWork db = new UnitOfWork())
                    {
                        var id = (int)dgvOrder.CurrentRow.Cells[0].Value;

                        await db.RepositoryOrder.DeleteAsync(id);
                    }
                    ReView();
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ReView();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            foreach (var gb in panelAddPage1.Controls.OfType<GroupBox>())
            {

                foreach (var pnl in gb.Controls.OfType<Panel>())
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
            }
            foreach (var gb in panelAddPage2.Controls.OfType<GroupBox>())
            {

                foreach (var pnl in gb.Controls.OfType<Panel>())
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
            }
            if (rbPaid.Checked == false && rbUnpaid.Checked == false)
            {
                panelPaymentStatus.BackColor = Color.FromArgb(183, 9, 76);
            }
            if (cbCondition.SelectedIndex == 0)
            {
                panelCondition.BackColor = Color.FromArgb(183, 9, 76);
            }
            if (dateOrderDate.Text == string.Empty)
            {
                panelOrderDate.BackColor = Color.FromArgb(183, 9, 76);
            }
            if (cbPackageType.SelectedIndex == 0)
            {
                panelPackageType.BackColor = Color.FromArgb(183, 9, 76);
            }
            if (cbPostType.SelectedIndex == 0)
            {
                panelPostType.BackColor = Color.FromArgb(183, 9, 76);
            }
            if (rbOrigin.Checked == false && rbDestination.Checked == false)
            {
                panelPaymentType.BackColor = Color.FromArgb(183, 9, 76);
            }
            if (txtDescription.Text == String.Empty)
            {
                panelDescription.BackColor = Color.FromArgb(183, 9, 76);
            }
            else if (txtSenderName.Text != string.Empty & txtReceiverName.Text != string.Empty & txtWeight.Text != string.Empty
                & numUDNumber.Text != string.Empty & cbPackageType.SelectedIndex != 0 & cbPostType.SelectedIndex != 0)
            {

                if (lbTitle.Text == "Add Order")
                {

                    using (UnitOfWork db = new UnitOfWork())
                    {
                        await db.RepositoryOrder.InsertAsync(Convert.ToInt32(txtOrderID.Text), dateOrderDate.Text, (rbPaid.Checked) ? true : false, cbCondition.SelectedIndex, cbSenderID.SelectedIndex,
                            txtSender.Text, txtSenderName.Text, txtMobileSender.Text, txtSenderAddress.Text, cbReceiverID.SelectedIndex, txtReceiver.Text,
                            txtReceiverName.Text, txtMobileReceiver.Text, txtReceiverAddress.Text, cbPostType.SelectedIndex, cbPackageType.SelectedIndex,
                            (rbOrigin.Checked) ? true : false, txtWeight.Text, numUDNumber.Text, txtShippingCosts.Text,
                            //txtServiceCosts.Text,
                            txtAdministrativeCosts.Text, txtDiscount.Text, txtTotalCost.Text, txtDescription.Text,
                            DateTime.Now.ToString());
                    }
                }
                else
                {
                    using (UnitOfWork db = new UnitOfWork())
                    {
                        await db.RepositoryOrder.UpdateAsync(Convert.ToInt32(txtOrderID.Text), dateOrderDate.Text, (rbPaid.Checked) ? true : false, cbCondition.SelectedIndex, cbSenderID.SelectedIndex,
                            txtSender.Text, txtSenderName.Text, txtMobileSender.Text, txtSenderAddress.Text, cbReceiverID.SelectedIndex, txtReceiver.Text,
                            txtReceiverName.Text, txtMobileReceiver.Text, txtReceiverAddress.Text, cbPostType.SelectedIndex, cbPackageType.SelectedIndex,
                            (rbOrigin.Checked) ? true : false, txtWeight.Text, numUDNumber.Text, txtShippingCosts.Text,
                            //txtServiceCosts.Text,
                            txtAdministrativeCosts.Text, txtDiscount.Text, txtTotalCost.Text, txtDescription.Text);
                    }
                }
                OpenClos();
                TextClear();
                ReView();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            OpenClos();
        }

        private async void txtSearch_TextChanged(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                dgvOrder.AutoGenerateColumns = false;
                dgvOrder.DataSource = await db.RepositoryOrder.GetSearchAsync(txtSearch.Text);
            }
        }

        private void rbPaid_MouseDown(object sender, MouseEventArgs e)
        {
            panelPaymentStatus.BackColor = Color.FromArgb(67, 185, 47);
        }
        private void rbPaid_Leave(object sender, EventArgs e)
        {
            panelPaymentStatus.BackColor = Color.Gainsboro;
        }

        //private void rbUnpaid_MouseDown(object sender, MouseEventArgs e)
        //{

        //}

        private void cbCondition_MouseDown(object sender, MouseEventArgs e)
        {
            panelCondition.BackColor = Color.FromArgb(67, 185, 47);
        }

        private void cbSenderID_MouseDown(object sender, MouseEventArgs e)
        {
            panelSenderID.BackColor = Color.FromArgb(67, 185, 47);
        }



        private void txtMobileSender_MouseClick(object sender, MouseEventArgs e)
        {
            panelMobileSender.BackColor = Color.FromArgb(67, 185, 47);
        }


        private void txtSender_MouseClick(object sender, MouseEventArgs e)
        {
            panelSender.BackColor = Color.FromArgb(67, 185, 47);
        }

        private void txtSender_Leave(object sender, EventArgs e)
        {
            panelSender.BackColor = Color.Gainsboro;
        }

        private void txtSenderName_MouseClick(object sender, MouseEventArgs e)
        {
            panelSenderName.BackColor = Color.FromArgb(67, 185, 47);
        }

        private void txtSenderName_Leave(object sender, EventArgs e)
        {
            panelSenderName.BackColor = Color.Gainsboro;
        }

        private void txtSenderAddress_MouseClick(object sender, MouseEventArgs e)
        {
            panelSenderAddress.BackColor = Color.FromArgb(67, 185, 47);
        }

        private void txtSenderAddress_Leave(object sender, EventArgs e)
        {
            panelSenderAddress.BackColor = Color.Gainsboro;
        }

        private void cbReceiverID_MouseDown(object sender, MouseEventArgs e)
        {
            panelReceiverID.BackColor = Color.FromArgb(67, 185, 47);
        }

        private void cbReceiverID_Leave(object sender, EventArgs e)
        {
            panelReceiverID.BackColor = Color.Gainsboro;
        }

        private void txtMobileReceiver_MouseClick(object sender, MouseEventArgs e)
        {
            panelMobileReceiver.BackColor = Color.FromArgb(67, 185, 47);
        }



        private void txtMobileReceiver_Leave(object sender, EventArgs e)
        {
            panelMobileReceiver.BackColor = Color.Gainsboro;
        }
        private void txtReceiver_MouseClick(object sender, MouseEventArgs e)
        {
            panelReceiver.BackColor = Color.FromArgb(67, 185, 47);
        }

        private void txtReceiver_Leave(object sender, EventArgs e)
        {
            panelReceiver.BackColor = Color.Gainsboro;
        }

        private void txtReceiverName_MouseClick(object sender, MouseEventArgs e)
        {
            panelReceiverName.BackColor = Color.FromArgb(67, 185, 47);
        }

        private void txtReceiverAddress_MouseClick(object sender, MouseEventArgs e)
        {
            panelReceiverAddress.BackColor = Color.FromArgb(67, 185, 47);

        }

        private void txtReceiverAddress_Leave(object sender, EventArgs e)
        {
            panelReceiverAddress.BackColor = Color.Gainsboro;
        }

        private void cbPostType_MouseDown(object sender, MouseEventArgs e)
        {
            panelPostType.BackColor = Color.FromArgb(67, 185, 47);
        }

        private void cbPostType_Leave(object sender, EventArgs e)
        {
            panelPostType.BackColor = Color.Gainsboro;
        }

        private void cbPackageType_MouseDown(object sender, MouseEventArgs e)
        {
            panelPackageType.BackColor = Color.FromArgb(67, 185, 47);
        }

        private void cbPackageType_Leave(object sender, EventArgs e)
        {
            panelPackageType.BackColor = Color.Gainsboro;
        }

        private void txtWeight_MouseClick(object sender, MouseEventArgs e)
        {
            panelWeight.BackColor = Color.FromArgb(67, 185, 47);
        }

        private void txtWeight_Leave(object sender, EventArgs e)
        {
            panelWeight.BackColor = Color.Gainsboro;
        }

        private void numUDNumber_MouseDown(object sender, MouseEventArgs e)
        {
            panelNumber.BackColor = Color.FromArgb(67, 185, 47);
        }

        private void numUDNumber_Leave(object sender, EventArgs e)
        {
            panelNumber.BackColor = Color.Gainsboro;
        }

        private void rbOrigin_MouseDown(object sender, MouseEventArgs e)
        {
            panelPaymentType.BackColor = Color.FromArgb(67, 185, 47);
        }

        private void rbOrigin_Leave(object sender, EventArgs e)
        {
            panelPaymentType.BackColor = Color.Gainsboro;

        }

        private void txtShippingCosts_Leave(object sender, EventArgs e)
        {
            panelShippingCosts.BackColor = Color.Gainsboro;
        }

        private void txtShippingCosts_MouseClick(object sender, MouseEventArgs e)
        {
            panelShippingCosts.BackColor = Color.FromArgb(67, 185, 47);
        }

        private void txtServiceCosts_MouseClick(object sender, MouseEventArgs e)
        {
            panelServiceCosts.BackColor = Color.FromArgb(67, 185, 47);
        }

        private void txtServiceCosts_Leave(object sender, EventArgs e)
        {
            panelServiceCosts.BackColor = Color.Gainsboro;
        }

        private void txtAdministrativeCosts_MouseClick(object sender, MouseEventArgs e)
        {
            panelAdministrativeCosts.BackColor = Color.FromArgb(67, 185, 47);
        }

        private void txtAdministrativeCosts_Leave(object sender, EventArgs e)
        {
            panelAdministrativeCosts.BackColor = Color.Gainsboro;
        }

        private void txtDiscount_MouseClick(object sender, MouseEventArgs e)
        {
            panelDiscount.BackColor = Color.FromArgb(67, 185, 47);
        }

        private void txtDiscount_Leave(object sender, EventArgs e)
        {
            panelDiscount.BackColor = Color.Gainsboro;
        }

        private void txtDescription_MouseClick(object sender, MouseEventArgs e)
        {
            panelDescription.BackColor = Color.FromArgb(67, 185, 47);
        }

        private void txtDescription_Leave(object sender, EventArgs e)
        {
            panelDescription.BackColor = Color.Gainsboro;
        }

        private void cbCondition_Leave(object sender, EventArgs e)
        {
            panelCondition.BackColor = Color.Gainsboro;
        }

        private void cbSenderID_Leave(object sender, EventArgs e)
        {
            panelSenderID.BackColor = Color.Gainsboro;
        }

        private void txtMobileSender_Leave(object sender, EventArgs e)
        {
            panelMobileSender.BackColor = Color.Gainsboro;
        }

        private void txtReceiverName_Leave(object sender, EventArgs e)
        {
            panelReceiverName.BackColor = Color.Gainsboro;
        }

        private async void cbSenderID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSenderID.SelectedIndex != 0)
            {

                using (UnitOfWork db = new UnitOfWork())
                {
                    var sender1 = (await db.RepositoryCompanies.GetAllAsync()).SingleOrDefault(x => x.CompanyID == cbSenderID.SelectedIndex);
                    txtSender.Text = sender1.Representative;
                    txtSenderName.Text = sender1.CompanyName;
                    txtMobileSender.Text = sender1.Mobile;
                    txtSenderAddress.Text = sender1.Address;
                }
            }
            else
            {
                txtSender.Text = "";
                txtSenderName.Text = "";
                txtMobileSender.Text = "";
                txtSenderAddress.Text = "";
            }
        }

        private async void cbReceiverID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbReceiverID.SelectedIndex != 0)
            {

                using (UnitOfWork db = new UnitOfWork())
                {
                    var sender1 = (await db.RepositoryCompanies.GetAllAsync()).SingleOrDefault(x => x.CompanyID == cbReceiverID.SelectedIndex);
                    txtReceiver.Text = sender1.Representative;
                    txtReceiverName.Text = sender1.CompanyName;
                    txtMobileReceiver.Text = sender1.Mobile;
                    txtReceiverAddress.Text = sender1.Address;
                }
            }
            else
            {
                txtReceiver.Text = "";
                txtReceiverName.Text = "";
                txtMobileReceiver.Text = "";
                txtReceiverAddress.Text = "";
            }
        }
    }
}
