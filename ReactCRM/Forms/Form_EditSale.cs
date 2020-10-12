using ReactCRM.dbConn;
using System;
using System.Data;
using System.Windows.Forms;

namespace ReactCRM.Forms
{
    public partial class Form_EditSale : Form
    {
        string SaleID;

        dbSale sales = new dbSale();

        public Form_EditSale(DataTable selectedSale)
        {
            InitializeComponent();

            SaleID = selectedSale.Rows[0][0].ToString();
            tbClient.Text = selectedSale.Rows[0][1].ToString();
            tbProduct.Text = selectedSale.Rows[0][2].ToString();
            tbPrice.Text = selectedSale.Rows[0][3].ToString();
            tbDate.Text = selectedSale.Rows[0][4].ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            sales.Connect();
            if (sales.ConnOpen() == true && FormValidate())
            {
                sales.UpdateSale(SaleID, tbClient.Text, tbProduct.Text, tbPrice.Value, tbDate.Value.ToString("yyyy-MM-dd"));

                MessageBox.Show("Sale Info Updated!", "Edit Sale", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please fill in all the fields!", "Edit Sale", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            sales.ConnClose();
        }

        private bool FormValidate()
        {
            if (tbProduct.Text.Length == 0)
            {
                return false;
            }

            if (tbPrice.Text.Length == 0)
            {
                return false;
            }

            if (tbDate.Text.Length == 0)
            {
                return false;
            }

            return true;
        }
    }
}
