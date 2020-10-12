using Bogus;
using System;
using System.Data;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;

namespace ReactCRM.Forms
{
    public partial class Form_EmailTicket : Form
    {
        public Form_EmailTicket(DataTable selectedTicket)
        {
            InitializeComponent();

            var faker = new Faker();

            tbClient.Text = selectedTicket.Rows[0][2].ToString();
            tbEmail.Text = selectedTicket.Rows[0][3].ToString();
            tbType.Text = selectedTicket.Rows[0][6].ToString();
            tbContent.Text = faker.Lorem.Paragraph();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient server = new SmtpClient("mail.wangh86.cucstudents.org");

                mail.From = new MailAddress("react@wangh86.cucstudents.org");
                mail.To.Add(new MailAddress(tbEmail.Text));
                mail.Subject = "To " + tbClient.Text;
                mail.Body = tbContent.Text;
                mail.BodyEncoding = UTF8Encoding.UTF8;
                mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

                server.UseDefaultCredentials = false;
                server.Credentials = new System.Net.NetworkCredential("react@wangh86.cucstudents.org", "CUCreactCRM");
                server.DeliveryMethod = SmtpDeliveryMethod.Network;
                server.EnableSsl = false;
                server.Timeout = 10000;
                server.Port = 587;

                server.Send(mail);
                MessageBox.Show("Email sent successfully!", "Send Email", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in sendEmail:" + ex.Message);
            }
        }
    }
}
