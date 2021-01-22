using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace Cosmetology
{
    public partial class AutoForm : Form
    {
        public BindingSource bs = new BindingSource();
        DateTime data = DateTime.Now.AddDays(1);
        public string ConnectionString = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = E:\настя\2 курс\БД\курсач\Cosmetology\Cosmetology\bin\x86\Debug\cosmetology center.mdb";
        public AutoForm()
        {
            InitializeComponent();

            OleDbConnection sqlconn = new OleDbConnection(ConnectionString);
            string query = "SELECT DISTINCT Client.[ID client], [Address], [Full name], [Date] FROM [Client], [Visiting], [Procedure] WHERE((Client.[ID client]=Visiting.[ID client]) AND (DAY(Visiting.[Date]) = " + data.Day + ") AND (MONTH(Visiting.[Date]) = " + data.Month + "))";
            OleDbDataAdapter oda = new OleDbDataAdapter(query, sqlconn);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            bs.DataSource = dt;
            dataGridView1.DataSource = bs;
            dataGridView1.Columns[0].HeaderText = "Номер клієнта";
            dataGridView1.Columns[1].HeaderText = "Адрес";
            dataGridView1.Columns[2].HeaderText = "ПІБ";
            dataGridView1.Columns[3].HeaderText = "Дата";
            sqlconn.Close();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void button_Ok_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                MailAddress from = new MailAddress("cosmetology.center@gmail.com", "Ваш консультант краси");
                MailAddress to = new MailAddress(Convert.ToString(dataGridView1.Rows[i].Cells[1].Value));
                using (MailMessage m = new MailMessage(from, to))
                {
                    m.Subject = "Краса";
                    var x = dataGridView1.Rows[i];
                    m.Body = Convert.ToString(x.Cells[2].Value) + "! Нагадуємо, що завтра в " + x.Cells[3].Value.ToString().Substring(11,2) + ":00 у вас запланован візит до нашого косметологічного центру!";
                    using (SmtpClient smtp = new SmtpClient())
                    {
                        smtp.Host = "smtp.gmail.com";
                        smtp.Port = 587;
                        smtp.EnableSsl = true;
                        smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                        smtp.UseDefaultCredentials = false;
                        smtp.Credentials = new NetworkCredential("chervinska777@gmail.com", "jxifeflwmoddnzdv");
                        m.Attachments.Add(new Attachment("logo_2.png"));
                        try
                        {
                        smtp.Send(m);
                        }
                        catch{

                        }
                    }
                }
            }
            MessageBox.Show("Повідомлення успішно відправлені!");
            Close();
        }

        private void назваToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns["ID client"], ListSortDirection.Ascending);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns["ID client"], ListSortDirection.Descending);
        }

        private void цінаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns["Full name"], ListSortDirection.Ascending);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns["Full name"], ListSortDirection.Descending);
        }

        private void тривалістьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns["Address"], ListSortDirection.Ascending);
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns["Address"], ListSortDirection.Descending);
        }

        private void типШкіриToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns["Date"], ListSortDirection.Ascending);
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns["Date"], ListSortDirection.Descending);
        }

        private void toolStripTextBox2_TextChanged(object sender, EventArgs e)
        {
            bs.Filter = " [Full name] Like'" + toolStripTextBox2.Text + "%'";
        }
    }
}
