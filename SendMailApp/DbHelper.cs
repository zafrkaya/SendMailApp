using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendMailApp
{
    class DbHelper
    {
        SqlConnection con = new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=SendMail;Integrated Security=True");

        public void MailDbAdd(string mailFrom, string mailTo, string mailSubject, string mailBody)
        {
            con.Open();
            SqlCommand command = new SqlCommand("INSERT INTO [SendMail].[dbo].[SentMails] (MailFrom,MailTo,MailSubject,MailBody,DateTime) VALUES (@MailFrom,@MailTo,@MailSubject,@MailBody,@DateTime)",con);
            command.Parameters.AddWithValue("@MailFrom",mailFrom);
            command.Parameters.AddWithValue("@MailTo",mailTo);
            command.Parameters.AddWithValue("@MailSubject",mailSubject);
            command.Parameters.AddWithValue("@MailBody",mailBody);
            command.Parameters.AddWithValue("@DateTime", DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss"));
            command.ExecuteNonQuery();
            con.Close();
        }
    }
}
