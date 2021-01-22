using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Cosmetology
{
    public partial class VisitingForm : Form
    {
        public VisitingForm()
        {
            InitializeComponent();
        }

        private void VisitingForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cosmetology_centerDataSet1.Visiting". При необходимости она может быть перемещена или удалена.
            this.visitingTableAdapter.Fill(this.cosmetology_centerDataSet1.Visiting);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cosmetology_centerDataSet1.Client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.cosmetology_centerDataSet1.Client);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cosmetology_centerDataSet1.Service". При необходимости она может быть перемещена или удалена.
            this.serviceTableAdapter.Fill(this.cosmetology_centerDataSet1.Service);

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var cf = new ClientForm();
            cf.ShowDialog();
            clientTableAdapter.Fill(cosmetology_centerDataSet1.Client);
            cosmetology_centerDataSet1.AcceptChanges();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_Ok_Click(object sender, EventArgs e)
        {
            string ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\настя\2 курс\БД\курсач\Cosmetology\Cosmetology\bin\x86\Debug\cosmetology center.mdb";
            OleDbConnection sqlconn = new OleDbConnection(ConnectionString);
            DateTime date = датаDateTimePicker.Value.Date;
            string query = "SELECT Count(*) FROM [Visiting] WHERE (Day([Date]) = " + date.Day + " AND MONTH([Date]) = " + date.Month + " )";
            OleDbCommand c = new OleDbCommand(query, sqlconn);
            c.Connection.Open();
            int c1 = Convert.ToInt32(c.ExecuteScalar());
            sqlconn.Close();
            int x = c1 % 6;
            date = date.AddHours(9 + x * 2);
            MessageBox.Show("Мі вас чекаемо " + date + " ");
            visitingTableAdapter.Insert(Convert.ToInt32(___клієнтуComboBox.SelectedValue), date);
            var f = new InterForm();
            f.ShowDialog();
            serviceTableAdapter.Fill(cosmetology_centerDataSet1.Service);
            cosmetology_centerDataSet1.AcceptChanges();
            Close();
        }

        private void VisitingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            visitingTableAdapter.Update(cosmetology_centerDataSet1);
        }
    }
}
