using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Cosmetology
{
    public partial class QueryEdit : Form
    {
        const string ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\настя\2 курс\БД\курсач\Cosmetology\Cosmetology\cosmetology center.mdb";
        public QueryEdit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection sqlconn = new OleDbConnection(ConnectionString);
                sqlconn.Open();
                OleDbDataAdapter oda = new OleDbDataAdapter(TestInput.Text, sqlconn);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                dataGridView1.DataSource = dt;
                sqlconn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TestInput.Clear();
            TestInput.Text = "Select";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
