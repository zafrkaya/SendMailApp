using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SendMailApp
{
    public partial class frmEmails : Form
    {
        public frmEmails()
        {
            InitializeComponent();
        }


        SqlConnection con = new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=SendMail;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            string dateTimeValue = dateTimePicker1.Value.ToString("dd.MM.yyyy");
            SqlDataAdapter da = new SqlDataAdapter(@"SELECT * FROM [SendMail].[dbo].[SentMails] WHERE DateTime like '%" + dateTimeValue + "%'  ", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
