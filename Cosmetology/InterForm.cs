using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Cosmetology
{
    public partial class InterForm : Form
    {
        public int visiting;
        public BindingSource bs = new BindingSource();
        public string ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\настя\2 курс\БД\курсач\Cosmetology\Cosmetology\bin\x86\Debug\cosmetology center.mdb";
        public InterForm()
        {
            InitializeComponent();
        }

        private void serviceBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.serviceBindingSource.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.cosmetology_centerDataSet1);

        }
        void FLoad()
        {
            OleDbConnection sqlconn = new OleDbConnection(ConnectionString);
            string count = "SELECT COUNT(*) FROM [Service] WHERE([ID visiting] = (SELECT MAX([ID visiting]) FROM VISITING))";
            string query = "SELECT [ID service], Service.[ID master], [Full name], Service.[ID procedure], [Name], [Cost] FROM [Service], [Master], [Procedure] WHERE(([ID visiting] = (SELECT MAX([ID visiting]) FROM VISITING)) AND (Master.[ID master]=Service.[ID master]) AND (Procedure.[ID procedure]=Service.[ID procedure]))";
            OleDbCommand c = new OleDbCommand(count, sqlconn);
            c.Connection.Open();
            int c2 = Convert.ToInt32(c.ExecuteScalar());
            if (c2 != 0)
            {
                OleDbDataAdapter oda = new OleDbDataAdapter(query, sqlconn);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                bs.DataSource = dt;
                serviceDataGridView.DataSource = bs;
                serviceDataGridView.Columns[0].HeaderText = "№ послуги";
                serviceDataGridView.Columns[1].HeaderText = "№ майстра";
                serviceDataGridView.Columns[2].HeaderText = "Майстер";
                serviceDataGridView.Columns[3].HeaderText = "№ процедури";
                serviceDataGridView.Columns[4].HeaderText = "Процедура";
                serviceDataGridView.Columns[5].HeaderText = "Коштовність поцедури";
                menuStrip2.Visible = true;
                toolStrip1.Visible = true;
            }
            sqlconn.Close();

        }
        private void InterForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cosmetology_centerDataSet1.Service". При необходимости она может быть перемещена или удалена.
            this.serviceTableAdapter.Fill(this.cosmetology_centerDataSet1.Service);
            FLoad();
            OleDbConnection sqlconn = new OleDbConnection(ConnectionString);
            string OleDbExpression = "SELECT MAX([ID visiting]) FROM VISITING";
            OleDbCommand command = new OleDbCommand(OleDbExpression, sqlconn);
            command.Connection.Open();
            visiting = Convert.ToInt32(command.ExecuteScalar());
            sqlconn.Close();
        }

        private void додатиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sf = new ServiceForm(visiting);
            sf.Show();
            this.Close();
        }

        private void оновитиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var row = serviceDataGridView.SelectedRows[0];
            if (serviceDataGridView.SelectedRows[0].Cells[0] != null)
            {
                var edt = new ServiceForm(
                Convert.ToInt32(row.Cells[0].Value),
                Convert.ToInt32(row.Cells[1].Value),
                visiting,
                Convert.ToInt32(row.Cells[3].Value)
                );
                edt.Show();
                this.Close();
            }
        }

        private void видалитиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (serviceDataGridView.SelectedRows[0] != null)
            {
                DialogResult dr = MessageBox.Show("Ви впевнені?", "", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    serviceTableAdapter.DeleteQuery(Convert.ToInt32(serviceDataGridView.SelectedRows[0].Cells[0].Value));
                    FLoad();
                }
            }
        }

        private void button_Ok_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void InterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            serviceTableAdapter.Update(cosmetology_centerDataSet1);
        }

        private void назваToolStripMenuItem_Click(object sender, EventArgs e)
        {
            serviceDataGridView.Sort(serviceDataGridView.Columns["ID service"], ListSortDirection.Ascending);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            serviceDataGridView.Sort(serviceDataGridView.Columns["ID service"], ListSortDirection.Descending);
        }

        private void цінаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            serviceDataGridView.Sort(serviceDataGridView.Columns["ID procedure"], ListSortDirection.Ascending);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            serviceDataGridView.Sort(serviceDataGridView.Columns["ID procedure"], ListSortDirection.Descending);
        }

        private void тривалістьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            serviceDataGridView.Sort(serviceDataGridView.Columns["Name"], ListSortDirection.Ascending);
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            serviceDataGridView.Sort(serviceDataGridView.Columns["Name"], ListSortDirection.Descending);
        }

        private void типШкіриToolStripMenuItem_Click(object sender, EventArgs e)
        {
            serviceDataGridView.Sort(serviceDataGridView.Columns["ID master"], ListSortDirection.Ascending);
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            serviceDataGridView.Sort(serviceDataGridView.Columns["ID master"], ListSortDirection.Descending);
        }

        private void номерПроцедуриToolStripMenuItem_Click(object sender, EventArgs e)
        {
            serviceDataGridView.Sort(serviceDataGridView.Columns["Full name"], ListSortDirection.Ascending);
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            serviceDataGridView.Sort(serviceDataGridView.Columns["Full name"], ListSortDirection.Descending);
        }

        private void коштовністьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            serviceDataGridView.Sort(serviceDataGridView.Columns["Cost"], ListSortDirection.Ascending); 
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            serviceDataGridView.Sort(serviceDataGridView.Columns["Cost"], ListSortDirection.Descending);
        }

        private void toolStripTextBox2_TextChanged(object sender, EventArgs e)
        {
            bs.Filter = " [Name] Like'" + toolStripTextBox2.Text + "%'";
        }

        private void toolStripTextBox3_TextChanged(object sender, EventArgs e)
        {
            bs.Filter = " [Full name] Like'" + toolStripTextBox3.Text + "%'";
        }
    }
}
