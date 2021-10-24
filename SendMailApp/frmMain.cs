using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SendMailApp
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnMailSend_Click(object sender, EventArgs e)
        {
            try
            {
                Mailing mailing = new Mailing();
                DbHelper dbhelper = new DbHelper();
                mailing.SendMail(txtMailBody.Text, txtMailTo.Text, txtSubject.Text);
                dbhelper.MailDbAdd(Mailing.mailFrom, txtMailTo.Text, txtSubject.Text, txtMailBody.Text);
                MessageBox.Show("Email sent successfully!");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logging.LoggingText(error);
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
