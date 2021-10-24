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
        public static string mailFrom { get; set; }
        
        public void SendMail(string messageBody, string mailTo, string subject)
        {

            MailMessage message = new MailMessage();
            SmtpClient smtp = new SmtpClient();

            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Port = 587;
            smtp.Host = "smtp.live.com"; //for gmail host 
            smtp.Credentials = new System.Net.NetworkCredential("testdenemehesap001@hotmail.com", "02125585aA.");


            message.From = new MailAddress("testdenemehesap001@hotmail.com");
            mailFrom = message.From.ToString();
            message.To.Add(new MailAddress(mailTo));
            message.Subject = subject;
            message.IsBodyHtml = true; //to make message body as html  
            message.Body = messageBody;
            smtp.Send(message);
        }


    }
}
