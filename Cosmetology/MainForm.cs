using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Cosmetology
{
    public partial class MainForm : Form
    {

        public BindingSource bs = new BindingSource();
        public string ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\настя\2 курс\БД\курсач\Cosmetology\Cosmetology\bin\x86\Debug\cosmetology center.mdb";
        public MainForm()
        {
            InitializeComponent();
            bindingNavigator1.BindingSource = procedureBindingSource;
            dataGridView1.DataSource = procedureBindingSource;
        }

        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            procedureTableAdapter.Update(cosmetology_centerDataSet1);
            responseTableAdapter.Update(cosmetology_centerDataSet1);
        }
        public void cost()
        {
            string ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\настя\2 курс\БД\курсач\Cosmetology\Cosmetology\bin\x86\Debug\cosmetology center.mdb";
            OleDbConnection sqlconn = new OleDbConnection(ConnectionString);
            string query = "SELECT Distinct [Cost] FROM [Procedure]";
            OleDbDataAdapter oda = new OleDbDataAdapter(query, sqlconn);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            string[] x = new string[dt.Rows.Count + 1];
            for (int i = 0; i < x.Length - 1; i++)
            {
                x[i] = dt.Rows[i][0].ToString();
            }
            toolStripComboBox1.ComboBox.DataSource = x;
        }
        public void duration()
        {
            string ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\настя\2 курс\БД\курсач\Cosmetology\Cosmetology\bin\x86\Debug\cosmetology center.mdb";
            OleDbConnection sqlconn = new OleDbConnection(ConnectionString);
            string query = "SELECT Distinct [Duration] FROM [Procedure]";
            OleDbDataAdapter oda = new OleDbDataAdapter(query, sqlconn);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            string[] x = new string[dt.Rows.Count + 1];
            for (int i = 0; i < x.Length - 1; i++)
            {
                x[i] = dt.Rows[i][0].ToString();
            }
            toolStripComboBox2.ComboBox.DataSource = x;
        }
        public void star()
        {
            string ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\настя\2 курс\БД\курсач\Cosmetology\Cosmetology\bin\x86\Debug\cosmetology center.mdb";
            OleDbConnection sqlconn = new OleDbConnection(ConnectionString);
            string query = "SELECT Distinct [Number of srarts] FROM [Response]";
            OleDbDataAdapter oda = new OleDbDataAdapter(query, sqlconn);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            string[] x = new string[dt.Rows.Count + 1];
            for (int i = 0; i < x.Length - 1; i++)
            {
                x[i] = dt.Rows[i][0].ToString();
            }
            toolStripComboBox1.ComboBox.DataSource = x;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cosmetology_centerDataSet1.Response". При необходимости она может быть перемещена или удалена.
            this.responseTableAdapter.Fill(this.cosmetology_centerDataSet1.Response);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cosmetology_centerDataSet1.Procedure". При необходимости она может быть перемещена или удалена.
            this.procedureTableAdapter.Fill(this.cosmetology_centerDataSet1.Procedure);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cosmetology_centerDataSet1.Client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.cosmetology_centerDataSet1.Client);
            bindingNavigator1.BindingSource = procedureBindingSource;
            dataGridView1.DataSource = procedureBindingSource;
            dataGridView1.AutoGenerateColumns = true;
            cost();
            duration();
        }

        private void прайсToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripTextBox3.Text = "";
            toolStripTextBox2.Text = "";
            toolStripTextBox1.Text = "";
            bindingNavigator1.BindingSource = procedureBindingSource;
            dataGridView1.DataSource = procedureBindingSource;
            label1.Text = "Процедури";
            toolStripLabel2.Text = "Тип шкіри:";
            назваToolStripMenuItem.Text = "Назва";
            цінаToolStripMenuItem.Text = "Ціна";
            тривалістьToolStripMenuItem.Text = "Тривалість";
            типШкіриToolStripMenuItem.Text = "Тип шкіри";
            номерПроцедуриToolStripMenuItem.Text = "Номер процедури";
            toolStripLabel3.Text = "Ціна:";
            cost();
            toolStripLabel4.Text = "Тривалість:";
            toolStripLabel5.Visible = false;
            toolStripTextBox1.Visible = false;
            toolStripComboBox2.Visible = true;
            toolStripLabel4.Visible = true;

        }
        void response()
        {
            toolStripTextBox3.Text = "";
            toolStripTextBox2.Text = "";
            toolStripTextBox1.Text = "";
            OleDbConnection sqlconn = new OleDbConnection(ConnectionString);
            string query = "SELECT [Number of srarts], [Comment], [Full name], [Name], [Date] FROM [Response], [Client], [Procedure] WHERE((Client.[ID client]=Response.[ID client]) AND (Procedure.[ID procedure]=Response.[ID procedure]))";
            OleDbDataAdapter oda = new OleDbDataAdapter(query, sqlconn);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            bs.DataSource = dt;
            dataGridView1.DataSource = bs;
            bindingNavigator1.BindingSource = bs;
            dataGridView1.Columns[0].HeaderText = "Оцінка";
            dataGridView1.Columns[1].HeaderText = "Коментар";
            dataGridView1.Columns[2].HeaderText = "Клієнт";
            dataGridView1.Columns[3].HeaderText = "Процедура";
            dataGridView1.Columns[4].HeaderText = "Дата";
            sqlconn.Close();
            label1.Text = "Відгуки";
            toolStripLabel2.Text = "Коментарій:";
            назваToolStripMenuItem.Text = "Кількість зірок";
            цінаToolStripMenuItem.Text = "Коментар";
            тривалістьToolStripMenuItem.Text = "Клієнт";
            типШкіриToolStripMenuItem.Text = "Процедура";
            номерПроцедуриToolStripMenuItem.Text = "Дата";
            toolStripLabel3.Text = "Оцінка:";
            toolStripLabel4.Visible = false;
            toolStripLabel5.Text = "Клієнт:";
            toolStripComboBox2.Visible = false;
            toolStripLabel5.Visible = true;
            toolStripTextBox1.Visible = true;
            star();
        }
        private void відгукиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            response();
        }

        private void деталіПроцедурToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var pf = new DetailProcedureForm();
            pf.ShowDialog();
            procedureTableAdapter.Fill(cosmetology_centerDataSet1.Procedure);
        }

        private void відгукToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var edt = new ResponseForm();
            edt.ShowDialog();
            cosmetology_centerDataSet1.AcceptChanges();
            response();
        }

        private void відвідуванняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var vf = new VisitingForm();
            vf.ShowDialog();
            cosmetology_centerDataSet1.AcceptChanges();
        }

        private void вхідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ef = new EnterForm();
            ef.ShowDialog();
            cosmetology_centerDataSet1.AcceptChanges();
        }
        private void toolStripTextBox2_TextChanged(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource == procedureBindingSource)
            {
                procedureBindingSource.Filter = $" [{dataGridView1.Columns[0].HeaderText}] Like'" + toolStripTextBox2.Text + "%'";

            }
            else if (label1.Text == "Відгуки")
            {
                bs.Filter = " [Name] Like'" + toolStripTextBox2.Text + "%'";
            }
        }

        private void toolStripTextBox3_TextChanged(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource == procedureBindingSource)
            {
                if (toolStripTextBox3.Text != "")
                    procedureBindingSource.Filter = " [Тип шкіри] Like'" + toolStripTextBox3.Text + "%'";
                else
                    procedureBindingSource.Filter = null;
            }
            else if (label1.Text == "Відгуки")
            {
                bs.Filter = " [Comment] Like'" + toolStripTextBox3.Text + "%'";
            }
        }

        private void назваToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (label1.Text == "Відгуки")
                dataGridView1.Sort(dataGridView1.Columns["Number of srarts"], ListSortDirection.Ascending);
            else
                dataGridView1.Sort(dataGridView1.Columns[назваToolStripMenuItem.Text], ListSortDirection.Ascending);
        }

        private void цінаToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (label1.Text == "Відгуки")
                dataGridView1.Sort(dataGridView1.Columns["Comment"], ListSortDirection.Ascending);
            else
                dataGridView1.Sort(dataGridView1.Columns[цінаToolStripMenuItem.Text], ListSortDirection.Ascending);
        }

        private void тривалістьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (label1.Text == "Відгуки")
                dataGridView1.Sort(dataGridView1.Columns["Full name"], ListSortDirection.Ascending);
            else
                dataGridView1.Sort(dataGridView1.Columns[тривалістьToolStripMenuItem.Text], ListSortDirection.Ascending);
        }

        private void типШкіриToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (label1.Text == "Відгуки")
                dataGridView1.Sort(dataGridView1.Columns["Name"], ListSortDirection.Ascending);
            else
                dataGridView1.Sort(dataGridView1.Columns[типШкіриToolStripMenuItem.Text], ListSortDirection.Ascending);
        }

        private void номерПроцедуриToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (label1.Text == "Відгуки")
                dataGridView1.Sort(dataGridView1.Columns["Date"], ListSortDirection.Ascending);
            else
                dataGridView1.Sort(dataGridView1.Columns[номерПроцедуриToolStripMenuItem.Text], ListSortDirection.Ascending);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (label1.Text == "Відгуки")
                dataGridView1.Sort(dataGridView1.Columns["Number of srarts"], ListSortDirection.Descending);
            else
                dataGridView1.Sort(dataGridView1.Columns[назваToolStripMenuItem.Text], ListSortDirection.Descending);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (label1.Text == "Відгуки")
                dataGridView1.Sort(dataGridView1.Columns["Comment"], ListSortDirection.Descending);
            else
                dataGridView1.Sort(dataGridView1.Columns[цінаToolStripMenuItem.Text], ListSortDirection.Descending);
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            if (label1.Text == "Відгуки")
                dataGridView1.Sort(dataGridView1.Columns["Full name"], ListSortDirection.Descending);
            else
                dataGridView1.Sort(dataGridView1.Columns[тривалістьToolStripMenuItem.Text], ListSortDirection.Descending);
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            if (label1.Text == "Відгуки")
                dataGridView1.Sort(dataGridView1.Columns["Name"], ListSortDirection.Descending);
            else
                dataGridView1.Sort(dataGridView1.Columns[типШкіриToolStripMenuItem.Text], ListSortDirection.Descending);
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            if (label1.Text == "Відгуки")
                dataGridView1.Sort(dataGridView1.Columns["Date"], ListSortDirection.Descending);
            else
                dataGridView1.Sort(dataGridView1.Columns[номерПроцедуриToolStripMenuItem.Text], ListSortDirection.Descending);
        }


        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            bs.Filter = " [Full name] Like'" + toolStripTextBox1.Text + "%'";
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (label1.Text == "Процедури")
            {
                OleDbConnection sqlconn = new OleDbConnection(ConnectionString);
                string query = $"SELECT * FROM [Procedure] WHERE([Cost] = {toolStripComboBox1.ComboBox.SelectedValue.ToString()})";
                OleDbDataAdapter oda = new OleDbDataAdapter(query, sqlconn);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                bs.DataSource = dt;
                dataGridView1.DataSource = bs;
                bindingNavigator1.BindingSource = bs;
            }
            else{
                OleDbConnection sqlconn = new OleDbConnection(ConnectionString);
                string query = $"SELECT [Number of srarts], [Comment], [Full name], [Name], [Date] FROM [Response], [Client], [Procedure] WHERE((Client.[ID client]=Response.[ID client]) AND (Procedure.[ID procedure]=Response.[ID procedure]) AND ([Number of srarts] = {toolStripComboBox1.ComboBox.SelectedValue.ToString()} ))";
                OleDbDataAdapter oda = new OleDbDataAdapter(query, sqlconn);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                bs.DataSource = dt;
                dataGridView1.DataSource = bs;
                bindingNavigator1.BindingSource = bs;
            }
                
        }

        private void toolStripComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            OleDbConnection sqlconn = new OleDbConnection(ConnectionString);
            string query = $"SELECT * FROM [Procedure] WHERE([Duration] = {toolStripComboBox2.ComboBox.SelectedValue.ToString()})";
            OleDbDataAdapter oda = new OleDbDataAdapter(query, sqlconn);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            bs.DataSource = dt;
            dataGridView1.DataSource = bs;
            bindingNavigator1.BindingSource = bs;
        }
    }
}
