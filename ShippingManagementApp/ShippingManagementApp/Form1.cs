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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void LoadForm(Form frm)
        {
            panelMain.Controls.Clear();
            AddOwnedForm(frm);
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            panelMain.Tag = frm;
            panelMain.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }
        void pnlOpen(Panel Pnl, Button Btn)
        {
            if (Pnl.Height == 45)
            {
                Pnl.Height = ((Pnl.Controls.OfType<Button>().Count() - 1) * 30) + 45;
            }
            Btn.Location = new Point(0, 2);
            Btn.BackColor = Color.FromArgb(67, 185, 47);
            //Btn.BackColor = Color.FromArgb(19, 164, 150);
        }
        void pnlClose(Button Btn)
        {
            foreach (var pnl in panelMenu.Controls.OfType<Panel>())
            {
                pnl.Height = 45;
                foreach (var btn in pnl.Controls.OfType<Button>().Where(a => a.Height == 40))
                {
                    btn.Left = -30;
                    btn.BackColor = Color.FromArgb(24, 119, 242);
                }
                foreach (var btn in pnl.Controls.OfType<Button>().Where(a => a.Height == 30))
                {
                    btn.Left = -30;
                    btn.BackColor = Color.DodgerBlue;
                }

            }
            Btn.Location = new Point(-30, 2);
            Btn.BackColor = Color.FromArgb(0, 80, 150);
        }
        void btnMini(Button Btn, Panel Pnl)
        {
            foreach (var btn in Pnl.Controls.OfType<Button>().Where(a => a.Height == 30))
            {
                btn.Left = -30;
                btn.BackColor = Color.DodgerBlue;
            }
            Btn.Left = -10;
            Btn.BackColor = Color.FromArgb(67, 185, 47);

        }
        private void btnCustomers_Click(object sender, EventArgs e)
        {
            pnlClose(btnCustomers);
            pnlOpen(panelCustomers, btnCustomers);

        }

        private void btnCompanies_Click(object sender, EventArgs e)
        {

            btnMini(btnCompanies, panelCustomers);
            LoadForm(new frmCompanies());
            //pnlOpen(panelCustomers, btnCompanies);
        }

        private void btnPersons_Click(object sender, EventArgs e)
        {
            btnMini(btnPersons, panelCustomers);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            pnlClose(btnHome);
            //btnHome.BackColor = Color.FromArgb(19, 164, 150);
            btnHome.BackColor = Color.FromArgb(67, 185, 47);
            btnHome.Location = new Point(0, 2);
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            pnlClose(btnOrders);
            //btnOrders.BackColor = Color.FromArgb(19, 164, 150);
            btnOrders.BackColor = Color.FromArgb(67, 185, 47);
            btnOrders.Location = new Point(0, 2);
        }

        private void btnAccounting_Click(object sender, EventArgs e)
        {
            pnlClose(btnAccounting);
            pnlOpen(panelAccounting, btnAccounting);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            pnlClose(btnSettings);
            pnlOpen(panelSetting, btnSettings);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pnlClose(btnHome);
        }

        private void btnReceived_Click(object sender, EventArgs e)
        {
            btnMini(btnReceived, panelAccounting);
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            btnMini(btnPayment, panelAccounting);

        }

        private void btnRights_Click(object sender, EventArgs e)
        {
            btnMini(btnRights, panelAccounting);

        }

        private void btnUsersSetting_Click(object sender, EventArgs e)
        {
            btnMini(btnUsersSetting, panelSetting);
            LoadForm(new frm_UsersSetting());

        }

        private void btnApplicationSetting_Click(object sender, EventArgs e)
        {
            btnMini(btnApplicationSetting, panelSetting);
        }
    }
}
