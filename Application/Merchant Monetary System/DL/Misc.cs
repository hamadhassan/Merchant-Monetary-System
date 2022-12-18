using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net.Mail;
using System.Net;
using System.Windows.Forms;

namespace Merchant_Monetary_System.DL
{
    public static class Misc
    {
        private static List<string> cities = new List<string>();

        public static List<string> Cities { get => cities; set => cities = value; }

        public static void LoadCitiesOfPunjabFromFile(string path)
        {
            StreamReader file  = new StreamReader(path);
            string record;
            while((record = file.ReadLine())!= null)
            {
                addIntoList(record);
            }
            file.Close();
        }

        public static void addIntoList(string city)
        {
            cities.Add(city);
        }

        public static void sendEmail(string To, string subject, string body, string From)
        {
            string fromMail = "syedhashir1001@gmail.com";
            string fromPassword = "ovzqzevxjyocsedg";
            MailMessage message = new MailMessage();
            message.From = new MailAddress(fromMail);
            message.Subject = "From " + From + ": " + subject;
            message.To.Add(new MailAddress(To));
            message.Body = "<html><body>" + "From " + From + "<br>" + body + "</body></html>";
            message.IsBodyHtml = true;

            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(fromMail, fromPassword),
                EnableSsl = true

            };
            try
            {
                smtpClient.Send(message);
                MessageBox.Show("Email Sent Successfully", "Sending...");
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
    }
}
