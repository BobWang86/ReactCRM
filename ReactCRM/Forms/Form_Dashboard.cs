using ReactCRM.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReactCRM.Forms
{
    public partial class Form_Dashboard : Form
    {
        public Form_Dashboard()
        {
            InitializeComponent();
            UC_Home ucHome = new UC_Home();
            AddControlsToPanel(ucHome);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void moveSidePanel(Control btn)
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
            moveSidePanel(btnHome);
            UC_Home ucHome = new UC_Home();
            AddControlsToPanel(ucHome);
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnClients);
            UC_ManageClients ucClient = new UC_ManageClients();
            AddControlsToPanel(ucClient);
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnSales);
            UC_ManageSales ucSale = new UC_ManageSales();
            AddControlsToPanel(ucSale);
        }

        private void btnTickets_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnTickets);
            UC_ManageTickets ucTicket = new UC_ManageTickets();
            AddControlsToPanel(ucTicket);
        }

        private void btnExpenses_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnExpenses);
            UC_ManageExpenses ucExpense = new UC_ManageExpenses();
            AddControlsToPanel(ucExpense);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnSettings);
        }
    }
}
