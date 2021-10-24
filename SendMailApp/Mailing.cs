using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SendMailApp
{
    class Mailing
    {
        public void SendMail(string messageBody, string mailTo, string subject)
        {

            try
            {
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Port = 587;
                smtp.Host = "smtp.live.com"; //for gmail host 
                smtp.Credentials = new System.Net.NetworkCredential("testdenemehesap001@hotmail.com", "02125585aA.");
                message.From = new MailAddress("zafrkaya28@hotmail.com.tr");
                message.To.Add(new MailAddress(mailTo));
                message.Subject = subject;
                message.IsBodyHtml = true; //to make message body as html  
                message.Body = messageBody;
                smtp.Send(message);
                MessageBox.Show("Email sent successfully!");
                
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message,"Error Message",MessageBoxButtons.OK,MessageBoxIcon.Error);                
                Logging.LoggingText(error);
            }

        


        }


    }
}
