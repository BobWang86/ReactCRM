using Bogus;
using System;
using System.Collections.Generic;
using System.Data;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;

namespace ReactCRM.Forms
{
    public partial class Form_EmailProduct : Form
    {   //"Interactive Timetabling", "Automated Timetabling", "Attendance Monitoring", "Room Booking", "Pay Claim", "Integration", "Consultancy", "Training"
        List<string> Description = new List<string>
        {
            "Hundreds of universities and colleges worldwide choose DigitalHub to provide state of the art solutions to solve complex scheduling and attendance monitoring requirements. Why is DigitalHub the brand of choice? Over 35 years’ experience delivering bench mark software solutions and professional services to clients in more than 30 countries!",
            "Interactive timetabling - Interactive timetabling is Computer Assisted Timetabling. Harnessing the power of software, users can create complex, clash free timetables in a fraction of the time it would normally take them over manual methods.",
            "Automated Timetabling - Automated Timetabling takes the pressure out of timetabling courses and exams, by defining rules and constraints governing how and when resources can be scheduled. A modern, sophisticated automation engine then interprets the data into a timetable solution.",
            "Attendance Monitoring - Attendance monitoring is the ability to track and confirm that your students are attending the events making up their course. When fully integrated with timetabling significant time and effort is saved as registers are automatically generated based on the timetabled event. Register marking options vary from automated options using biometric and data collector devices to interactive using web clients on PC’s and mobile devices.",
            "Room Booking - Staff and students can request room slots that meet their requirements. Rooming administrators manage requests based on availability. This semi-automatic process keeps requesters informed regarding the status of requests, saving valuable time for administrators.",
            "Pay Claim - Pay Claim Management System (PCM) is a web-based portal accessible on any device, including mobile. This new standalone self-service system allows users to generate claims based on their timetable or work schedule. Managers approve claims and administrators authorise them, leading to payment.",
            "Integration - DigitalHub’s sophisticated integration tools deliver seamless connectivity between the Timetabler application suite and your existing applications. DigitalHub integration includes functions to read, write and transform data for supported applications. Purposely designed so that they can be used by timetablers or IT experts alike, Timetablers’ integration permits rapid data transfer between applications.",
            "Consultancy - DigitalHub has the technical know-how and experience to implement DigitalHub software effortlessly. DigitalHub consultants from the education sector, having a background in timetabling, are equipped to give sound advice concerning best practice and methods that get results.",
            "Training - DigitalHub training is part of our standard provision and tailored to the specific needs of clients. A wide range of topics are covered allowing staff to develop the skills needed to administer and use DigitalHub applications proficiently."
        };

        public Form_EmailProduct(DataTable selectedClient)
        {
            InitializeComponent();

            var faker = new Faker();

            tbClient.Text = selectedClient.Rows[0][1].ToString();
            tbEmail.Text = selectedClient.Rows[0][2].ToString();
            tbContent.Text = faker.Lorem.Paragraph();

            tbProduct.DropDownStyle = ComboBoxStyle.DropDownList;
            tbProduct.Items.AddRange(new string[] { "Interactive Timetabling", "Automated Timetabling", "Attendance Monitoring", "Room Booking", "Pay Claim", "Integration", "Consultancy", "Training" });
        }

        private void tbType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string product = tbProduct.Text;
            SwitchProductDescription(product);
        }

        private void SwitchProductDescription(string product)
        {
            switch (product)
            {
                case "Interactive timetabling":
                    tbContent.Text = Description[1];
                    break;
                case "Automated Timetabling":
                    tbContent.Text = Description[2];
                    break;
                case "Attendance Monitoring":
                    tbContent.Text = Description[3];
                    break;
                case "Room Booking":
                    tbContent.Text = Description[4];
                    break;
                case "Pay Claim":
                    tbContent.Text = Description[5];
                    break;
                case "Integration":
                    tbContent.Text = Description[6];
                    break;
                case "Consultancy":
                    tbContent.Text = Description[7];
                    break;
                case "Training":
                    tbContent.Text = Description[8];
                    break;
                default:
                    tbContent.Text = Description[0];
                    break;
            }
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
