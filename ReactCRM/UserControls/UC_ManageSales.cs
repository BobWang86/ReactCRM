using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReactCRM.dbConn;
using ReactCRM.Forms;

namespace ReactCRM.UserControls
{
    public partial class UC_ManageSales : UserControl
    {
        string SaleID;

        dbSale sales = new dbSale();

        public DataTable selectedSale = new DataTable();

        public UC_ManageSales()
        {
            InitializeComponent();

            sales.connect();
            if (sales.connOpen() == true)
            {
                dgvSales.DataSource = sales.Query($"SELECT * FROM `tbSale`").Tables[0];
            }
            sales.connClose();

            foreach (DataGridViewColumn column in dgvSales.Columns)
            {
                selectedSale.Columns.Add(column.Name, typeof(string));
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (Form_AddSale form = new Form_AddSale())
            {
                form.ShowDialog();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            using (Form_EditSale form = new Form_EditSale(selectedSale))
            {
                form.ShowDialog();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure you want to delete this entry?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                if (sales.connOpen() == true)
                {
                    sales.deleteSale(SaleID);
                    dgvSales.DataSource = sales.Query($"SELECT * FROM `tbClient`").Tables[0];
                }
                sales.connClose();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            sales.connect();
            if (sales.connOpen() == true)
            {
                dgvSales.DataSource = sales.Query($"SELECT * FROM `tbSale`").Tables[0];
            }
            sales.connClose();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void dgvSales_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSales.SelectedRows.Count > 0)
            {
                for (int i = 0; i < dgvSales.SelectedRows.Count; i++)
                {
                    selectedSale.Rows.Add();
                    for (int j = 0; j < dgvSales.Columns.Count; j++)
                    {
                        selectedSale.Rows[i][j] = dgvSales.SelectedRows[i].Cells[j].Value;
                    }
                }

                SaleID = dgvSales.SelectedRows[0].Cells[0].Value.ToString();
            }
        }
    }
}
