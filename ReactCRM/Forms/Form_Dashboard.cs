using ReactCRM.dbConn;
using ReactCRM.UserControls;
using System;
using System.Windows.Forms;

namespace ReactCRM.Forms
{
    public partial class Form_Dashboard : Form
    {
        dbUser user = new dbUser();

        public Form_Dashboard()
        {
            InitializeComponent();
            UC_Home ucHome = new UC_Home();
            AddControlsToPanel(ucHome);
            lbUserEmail.Text = user.GetUserEmail();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            user.SignOutStatus();
            this.Dispose();
            Application.Restart();
        }

        private void MoveSidePanel(Control btn)
        {
            panelSide.Top = btn.Top;
            panelSide.Height = btn.Height;
        }

        private void AddControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelControls.Controls.Clear();
            panelControls.Controls.Add(c);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            MoveSidePanel(btnHome);
            UC_Home ucHome = new UC_Home();
            AddControlsToPanel(ucHome);
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            MoveSidePanel(btnClients);
            UC_ManageClients ucClient = new UC_ManageClients();
            AddControlsToPanel(ucClient);
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            MoveSidePanel(btnSales);
            UC_ManageSales ucSale = new UC_ManageSales();
            AddControlsToPanel(ucSale);
        }

        private void btnTickets_Click(object sender, EventArgs e)
        {
            MoveSidePanel(btnTickets);
            UC_ManageTickets ucTicket = new UC_ManageTickets();
            AddControlsToPanel(ucTicket);
        }

        private void btnExpenses_Click(object sender, EventArgs e)
        {
            MoveSidePanel(btnExpenses);
            UC_ManageExpenses ucExpense = new UC_ManageExpenses();
            AddControlsToPanel(ucExpense);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            MoveSidePanel(btnSettings);
        }

        private void Form_Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            user.SignOutStatus();
            Application.Exit();
        }
    }
}
