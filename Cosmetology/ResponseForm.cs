using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Cosmetology
{
    public partial class ResponseForm : Form
    {
        public short star = 5;
        public string[] client = clien();
        public ResponseForm()
        {
            InitializeComponent();
        }
        public static string[] clien()
        {
            string ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\настя\2 курс\БД\курсач\Cosmetology\Cosmetology\bin\x86\Debug\cosmetology center.mdb";
            OleDbConnection sqlconn = new OleDbConnection(ConnectionString);
            string query = "SELECT [Full name] FROM [Client]";
            OleDbDataAdapter oda = new OleDbDataAdapter(query, sqlconn);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            string[] x = new string[dt.Rows.Count];
            for(int i = 0; i < x.Length; i++)
            {
                x[i] = dt.Rows[i][0].ToString();
            }
            return x;
        }

        private void ResponseForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cosmetology_centerDataSet1.Response". При необходимости она может быть перемещена или удалена.
            this.responseTableAdapter.Fill(this.cosmetology_centerDataSet1.Response);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cosmetology_centerDataSet1.Procedure". При необходимости она может быть перемещена или удалена.
            this.procedureTableAdapter.Fill(this.cosmetology_centerDataSet1.Procedure);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cosmetology_centerDataSet1.Client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.cosmetology_centerDataSet1.Client);

        }

        private void button_Ok_Click(object sender, EventArgs e)
        {
            if (isClient(textBox1.Text))
            {
                if(comboBox_Procedure.SelectedValue!= null && isProcedure(comboBox_Procedure.SelectedValue.ToString()))
                {
                    string ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\настя\2 курс\БД\курсач\Cosmetology\Cosmetology\bin\x86\Debug\cosmetology center.mdb";
                    OleDbConnection sqlconn = new OleDbConnection(ConnectionString);
                    string count = "SELECT [ID client] FROM [Client] WHERE (Client.[Full name] = '" + textBox1.Text + "')";
                    string count2 = "SELECT [ID procedure] FROM [Procedure] WHERE (Procedure.[Name] = '" + comboBox_Procedure.SelectedValue.ToString() + "')";
                    OleDbCommand c = new OleDbCommand(count, sqlconn);
                    c.Connection.Open();
                    int c1 = Convert.ToInt32(c.ExecuteScalar());
                    sqlconn.Close();
                    OleDbCommand c2 = new OleDbCommand(count2, sqlconn);
                    c2.Connection.Open();
                    int c3 = Convert.ToInt32(c2.ExecuteScalar());
                    sqlconn.Close();
                    responseTableAdapter.Insert(star, c1, c3, коментарійtextBox.Text, DateTime.Now.Date);
                    Close();
                }
                else
                    MessageBox.Show("Ви ще не були ні на одній процедурі!");
            }
            else
                MessageBox.Show("Ви не є клієнтом нашого центру!");
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.star2;
            pictureBox2.Image = Properties.Resources.star1;
            pictureBox3.Image = Properties.Resources.star1;
            pictureBox4.Image = Properties.Resources.star1;
            pictureBox5.Image = Properties.Resources.star1;
            star = 1;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.star2;
            pictureBox2.Image = Properties.Resources.star2;
            pictureBox3.Image = Properties.Resources.star1;
            pictureBox4.Image = Properties.Resources.star1;
            pictureBox5.Image = Properties.Resources.star1;
            star = 2;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.star2;
            pictureBox2.Image = Properties.Resources.star2;
            pictureBox3.Image = Properties.Resources.star2;
            pictureBox4.Image = Properties.Resources.star1;
            pictureBox5.Image = Properties.Resources.star1;
            star = 3;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.star2;
            pictureBox2.Image = Properties.Resources.star2;
            pictureBox3.Image = Properties.Resources.star2;
            pictureBox4.Image = Properties.Resources.star2;
            pictureBox5.Image = Properties.Resources.star1;
            star = 4;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.star2;
            pictureBox2.Image = Properties.Resources.star2;
            pictureBox3.Image = Properties.Resources.star2;
            pictureBox4.Image = Properties.Resources.star2;
            pictureBox5.Image = Properties.Resources.star2;
            star = 5;
        }

        private void textBox1_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (textBox1.Text == "")
                errorProvider1.SetError(textBox1, "Не вказано ім'я");
            else if (!isClient(textBox1.Text))
                errorProvider1.SetError(textBox1, "Такого клієнта не існує!");
            else
                errorProvider1.Clear();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != 32)
                e.Handled = true;
        }
        private bool isClient(string x)
        {
            for(int i = 0; i < client.Length; i++)
            {
                if (x == client[i])
                    return true;
            }
            return false;
        }
        private bool isProcedure(string x)
        {
            string ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\настя\2 курс\БД\курсач\Cosmetology\Cosmetology\bin\x86\Debug\cosmetology center.mdb";
            OleDbConnection sqlconn = new OleDbConnection(ConnectionString);
            string query = "SELECT [Name] FROM [Procedure]";
            OleDbDataAdapter oda = new OleDbDataAdapter(query, sqlconn);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            string[] proc = new string[dt.Rows.Count];
            for (int i = 0; i < proc.Length; i++)
            {
                proc[i] = dt.Rows[i][0].ToString();
            }
            for (int i = 0; i < proc.Length; i++)
            {
                if (x == proc[i])
                    return true;
            }
            return false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (isClient(textBox1.Text))
            {
                string ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\настя\2 курс\БД\курсач\Cosmetology\Cosmetology\bin\x86\Debug\cosmetology center.mdb";
                OleDbConnection sqlconn = new OleDbConnection(ConnectionString);
                string query = "SELECT Distinct Procedure.[Name] FROM [Procedure], [Service], [Visiting], [Client] WHERE ((Client.[Full name] = '" + textBox1.Text + "') AND (Procedure.[ID procedure] = Service.[ID procedure]) AND (Service.[ID visiting] = Visiting.[ID visiting]) AND (Client.[ID client] = Visiting.[ID client]))";
                OleDbDataAdapter oda = new OleDbDataAdapter(query, sqlconn);
                DataTable dt = new DataTable();
                try
                {
                    oda.Fill(dt);
                    string[] x = new string[dt.Rows.Count];
                    for (int i = 0; i < x.Length; i++)
                    {
                        x[i] = dt.Rows[i][0].ToString();
                    }
                    comboBox_Procedure.DataSource = x;
                }
                catch { }
            }
            else
                comboBox_Procedure.DataSource = null;
        }
    }
}
