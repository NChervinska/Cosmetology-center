using Microsoft.Office.Interop.Word;
using System;
using System.ComponentModel;
using System.Data.OleDb;
using System.Windows.Forms;
using DataTable = System.Data.DataTable;
using Word = Microsoft.Office.Interop.Word;

namespace Cosmetology
{
    public partial class AdminMainForm : Form
    {
        public BindingSource bs = new BindingSource();
        public string ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\настя\2 курс\БД\курсач\Cosmetology\Cosmetology\bin\x86\Debug\cosmetology center.mdb";
        public AdminMainForm()
        {
            InitializeComponent();
        }
        public void cost()
        {
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
        public void star()
        {
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
        public void duration()
        {
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
        public void gender()
        {
            string[] x = new string[3];
            x[0] = "м";
            x[1] = "ж";
            toolStripComboBox1.ComboBox.DataSource = x;
        }
        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void редактуватиЗапитToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var qe = new QueryEdit();
            qe.Show();
        }

        private void AdminMainForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cosmetology_centerDataSet.Response". При необходимости она может быть перемещена или удалена.
            this.responseTableAdapter.Fill(this.cosmetology_centerDataSet1.Response);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cosmetology_centerDataSet.Client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.cosmetology_centerDataSet1.Client);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cosmetology_centerDataSet.Elixir". При необходимости она может быть перемещена или удалена.
            this.elixirTableAdapter.Fill(this.cosmetology_centerDataSet1.Elixir);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cosmetology_centerDataSet.Service". При необходимости она может быть перемещена или удалена.
            this.serviceTableAdapter.Fill(this.cosmetology_centerDataSet1.Service);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cosmetology_centerDataSet.Visiting". При необходимости она может быть перемещена или удалена.
            this.visitingTableAdapter.Fill(this.cosmetology_centerDataSet1.Visiting);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cosmetology_centerDataSet.Preparation". При необходимости она может быть перемещена или удалена.
            this.preparationTableAdapter.Fill(this.cosmetology_centerDataSet1.Preparation);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cosmetology_centerDataSet.Master". При необходимости она может быть перемещена или удалена.
            this.masterTableAdapter.Fill(this.cosmetology_centerDataSet1.Master);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cosmetology_centerDataSet.Procedure". При необходимости она может быть перемещена или удалена.
            this.procedureTableAdapter.Fill(this.cosmetology_centerDataSet1.Procedure);
            dataGridView1.AutoGenerateColumns = true;
            cost();
            duration();
        }

        private void майстриToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripTextBox3.Text = "";
            toolStripTextBox2.Text = "";
            toolStripTextBox1.Text = "";
            bindingNavigator1.BindingSource = masterBindingSource;
            dataGridView1.DataSource = masterBindingSource;
            label1.Text = "Майстри";
            toolStripLabel1.Text = "ПІБ:";
            toolStripLabel2.Text = "Адреса:";
            toolStripLabel3.Text = "Стать:";
            gender();
            toolStripLabel4.Visible = false;
            toolStripLabel5.Visible = false;
            toolStripComboBox2.Visible = false;
            toolStripTextBox1.Visible = false;
            назваToolStripMenuItem.Text = "ПІБ";
            цінаToolStripMenuItem.Text = "Стать";
            тривалістьToolStripMenuItem.Text = "Номер";
            типШкіриToolStripMenuItem.Text = "Телефон";
            номерПроцедуриToolStripMenuItem.Text = "Адреса";
            номерПроцедуриToolStripMenuItem.Visible = true;
            властивостіToolStripMenuItem.Visible = false;
            toolStripLabel2.Visible = true;
            типШкіриToolStripMenuItem.Visible = true;
            toolStripTextBox3.Visible = true;
            toolStrip1.Visible = true;
            menuStrip2.Visible = true;
        }

        private void procedure()
        {
            toolStripTextBox3.Text = "";
            toolStripTextBox2.Text = "";
            toolStripTextBox1.Text = "";
            bindingNavigator1.BindingSource = procedureBindingSource;
            dataGridView1.DataSource = procedureBindingSource;
            label1.Text = "Процедури";
            toolStripLabel2.Text = "Тип шкіри:";
            назваToolStripMenuItem.Text = "Назва";
            цінаToolStripMenuItem.Text = "Номер процедури";
            тривалістьToolStripMenuItem.Text = "Тип шкіри";
            типШкіриToolStripMenuItem.Text = "Ціна";
            номерПроцедуриToolStripMenuItem.Visible = true;
            номерПроцедуриToolStripMenuItem.Text = "Тривалість";
            toolStripLabel3.Text = "Ціна";
            toolStripLabel4.Text = "Тривалість";
            toolStripLabel5.Visible = false;
            toolStripTextBox1.Visible = false;
            toolStripComboBox2.Visible = true;
            toolStripLabel4.Visible = true;
            властивостіToolStripMenuItem.Visible = false;
            cost();
            duration();
            toolStripLabel2.Visible = true;
            типШкіриToolStripMenuItem.Visible = true;
            toolStripTextBox3.Visible = true;
            toolStrip1.Visible = true;
            menuStrip2.Visible = true;
        }
        private void процедуриToolStripMenuItem_Click(object sender, EventArgs e)
        {
            procedure();
        }
        public void year()
        {
            OleDbConnection sqlconn = new OleDbConnection(ConnectionString);
            string query = "SELECT Distinct [Year of birth] FROM [Client]";
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
        private void клієнтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripTextBox3.Text = "";
            toolStripTextBox2.Text = "";
            toolStripTextBox1.Text = "";
            toolStrip1.Visible = true;
            menuStrip2.Visible = true; 
            bindingNavigator1.BindingSource = clientBindingSource;
            dataGridView1.DataSource = clientBindingSource;
            label1.Text = "Клієнти"; 
            toolStripLabel1.Text = "ПІБ:";
            toolStripLabel2.Text = "Тип шкіри:";
            toolStripLabel3.Text = "Стать:";
            gender();
            year();
            toolStripLabel4.Visible = true;
            toolStripLabel4.Text = "Рік народження";
            toolStripLabel5.Visible = true;
            toolStripLabel5.Text = "Ціль приходу";
            toolStripComboBox2.Visible = true;
            toolStripTextBox1.Visible = true;
            назваToolStripMenuItem.Text = "ПІБ";
            цінаToolStripMenuItem.Text = "Рік народження";
            тривалістьToolStripMenuItem.Text = "Стать";
            типШкіриToolStripMenuItem.Text = "Адреса";
            номерПроцедуриToolStripMenuItem.Text = "Тип шкіри";
            властивостіToolStripMenuItem.Text = "Номер";
            номерПроцедуриToolStripMenuItem.Visible = true;
            властивостіToolStripMenuItem.Visible = true;
            toolStripLabel2.Visible = true;
            типШкіриToolStripMenuItem.Visible = true;
            toolStripTextBox3.Visible = true;
            toolStripTextBox1.Visible = true;
        }

        private void відгукиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bs.Filter = null;
            toolStripTextBox3.Text = "";
            toolStripTextBox2.Text = "";
            toolStripTextBox1.Text = "";
            toolStrip1.Visible = true;
            menuStrip2.Visible = true; 
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
            toolStripLabel1.Text = "Назва";
            toolStripLabel2.Text = "Коментарій:";
            назваToolStripMenuItem.Text = "Кількість зірок";
            цінаToolStripMenuItem.Text = "Коментар";
            тривалістьToolStripMenuItem.Text = "Клієнт";
            типШкіриToolStripMenuItem.Text = "Процедура";
            номерПроцедуриToolStripMenuItem.Text = "Дата";
            toolStripLabel3.Text = "Оцінка";
            toolStripLabel4.Visible = false;
            toolStripLabel5.Text = "Клієнт";
            toolStripComboBox2.Visible = false;
            toolStripLabel5.Visible = true;
            номерПроцедуриToolStripMenuItem.Visible = true;
            toolStripTextBox1.Visible = true;
            star();
            властивостіToolStripMenuItem.Visible = false;
            toolStripLabel2.Visible = true;
            типШкіриToolStripMenuItem.Visible = true;
            toolStripTextBox3.Visible = true;
            toolStripTextBox1.Visible = true;
        }
        private void toolStripTextBox2_TextChanged(object sender, EventArgs e)
        {
            if (toolStripTextBox2.Text == "")
            {
                procedureBindingSource.Filter = null;
                bs.Filter = null;
                masterBindingSource.Filter = null;
                preparationBindingSource.Filter = null;
                clientBindingSource.Filter = null;
            }
            else if (label1.Text == "Процедури")
            {
                procedureBindingSource.Filter = " [Назва] Like'" + toolStripTextBox2.Text + "%'";
            }
            else if (label1.Text == "Відгуки")
            {
                bs.Filter = " [Name] Like'" + toolStripTextBox2.Text + "%'";
            }
            else if (label1.Text == "Майстри")
            {
                masterBindingSource.Filter = " [ПІБ] Like'" + toolStripTextBox2.Text + "%'";
            }
            else if (label1.Text == "Препарати")
            {
                preparationBindingSource.Filter = " [Назва] Like'" + toolStripTextBox2.Text + "%'";
            }
            else if (label1.Text == "Клієнти")
            {
                clientBindingSource.Filter = " [ПІБ] Like'" + toolStripTextBox2.Text + "%'";
            }
            else if (label1.Text == "Еліксири")
            {
                bs.Filter = " Procedure.[Name] Like'" + toolStripTextBox2.Text + "%'";
            }
            else if (label1.Text == "Послуги" || label1.Text == "Відвідування")
            {
                bs.Filter = " [Full name] Like'" + toolStripTextBox2.Text + "%'";
            }
        }

        private void toolStripTextBox3_TextChanged(object sender, EventArgs e)
        {
            if (toolStripTextBox3.Text == "")
            {
                procedureBindingSource.Filter = null;
                bs.Filter = null;
                masterBindingSource.Filter = null;
                preparationBindingSource.Filter = null;
                clientBindingSource.Filter = null;
            }
            else if (label1.Text == "Процедури")
            {
                procedureBindingSource.Filter = " [Тип шкіри] Like'" + toolStripTextBox3.Text + "%'";
            }
            else if (label1.Text == "Відгуки")
            {
                bs.Filter = " [Comment] Like'" + toolStripTextBox3.Text + "%'";
            }
            else if (label1.Text == "Майстри")
            {
                masterBindingSource.Filter = " [Адреса] Like'" + toolStripTextBox3.Text + "%'";
            }
            else if (label1.Text == "Препарати")
            {
                preparationBindingSource.Filter = " [Призначення] Like'" + toolStripTextBox3.Text + "%'";
            }
            else if (label1.Text == "Клієнти")
            {
                clientBindingSource.Filter = " [Тип шкіри] Like'" + toolStripTextBox3.Text + "%'";
            }
            else if (label1.Text == "Еліксири")
            {
                bs.Filter = " Preparation.[Name] Like'" + toolStripTextBox3.Text + "%'";
            }
            else if (label1.Text == "Послуги")
            {
                bs.Filter = " [Name] Like'" + toolStripTextBox3.Text + "%'";
            }
        }

        private void повідомленняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var af = new AutoForm();
            af.Show();
        }

        private void додатиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var mf = new MasterForm();
            mf.ShowDialog();
            masterTableAdapter.Fill(cosmetology_centerDataSet1.Master);
            cosmetology_centerDataSet1.AcceptChanges();
        }

        private void оновитиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var row = dataGridView1.SelectedRows[0];
            if (dataGridView1.DataSource == masterBindingSource && row.Cells[0] != null)
            {
                var mf = new MasterForm(
                    row.Cells[0].Value.ToString(),
                    row.Cells[1].Value.ToString(),
                    Convert.ToInt32(row.Cells[2].Value),
                    Convert.ToInt32(row.Cells[3].Value),
                    row.Cells[4].Value.ToString()
                    );
                mf.ShowDialog();
                masterTableAdapter.Fill(cosmetology_centerDataSet1.Master);
                cosmetology_centerDataSet1.AcceptChanges();
            }
        }

        private void видалитиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource == masterBindingSource && dataGridView1.SelectedRows[0].Cells[0] != null)
            {
                DialogResult dr = MessageBox.Show("Ви впевнені?", "", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    masterTableAdapter.DeleteQuery(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[2].Value));
                }
            }
            masterTableAdapter.Fill(cosmetology_centerDataSet1.Master);
            cosmetology_centerDataSet1.AcceptChanges();
        }

        private void додатиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var pf = new ProcedureForm();
            pf.ShowDialog();
            procedureTableAdapter.Fill(cosmetology_centerDataSet1.Procedure);
            cosmetology_centerDataSet1.AcceptChanges();
        }

        private void оновитиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var row = dataGridView1.SelectedRows[0];
            if (dataGridView1.DataSource == procedureBindingSource && row.Cells[0] != null)
            {
                var pf = new ProcedureForm(
                    row.Cells[0].Value.ToString(),
                    Convert.ToInt32(row.Cells[1].Value),
                    row.Cells[2].Value.ToString(),
                    Convert.ToInt32(row.Cells[3].Value),
                    Convert.ToInt32(row.Cells[4].Value)
                    );
                pf.ShowDialog();
                procedureTableAdapter.Fill(cosmetology_centerDataSet1.Procedure);
                cosmetology_centerDataSet1.AcceptChanges();
            }
        }

        private void видалитиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource == procedureBindingSource && dataGridView1.SelectedRows[0].Cells[0] != null)
            {
                DialogResult dr = MessageBox.Show("Ви впевнені?", "", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    procedureTableAdapter.DeleteQuery(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[1].Value));
                }
            }
            procedureTableAdapter.Fill(cosmetology_centerDataSet1.Procedure);
            cosmetology_centerDataSet1.AcceptChanges();
        }

        private void актуальнийПрайсToolStripMenuItem_Click(object sender, EventArgs e)
        {
            procedure();
            doc(1);
        }
        void doc(int x)
        {
            Word.Application winword = new Word.Application();
            object missing = System.Reflection.Missing.Value;
            Document document = winword.Documents.Add(ref missing, ref missing, ref missing, ref missing);
            Paragraph par = document.Paragraphs.Last;
            par.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
            par.Range.Font.Size = 14;
            par.Range.Font.Name = "Times New Roman";
            if (x == 0)
            {
                par.Range.Text = "Звіт";
                par.Range.Text += "«Кількість відвідувань одним клієнтом за місяць»";
            }
            else
            {
                par.Range.Text = "Прайс";
            }
            par.Range.InsertParagraphAfter();
            Table firstTable = document.Tables.Add(par.Range, dataGridView1.Rows.Count, dataGridView1.Columns.Count, ref missing, ref missing);
            firstTable.Borders.Enable = 1;
            foreach (Row row in firstTable.Rows)
            {
                foreach (Cell cell in row.Cells)
                {
                    if (cell.RowIndex == 1)
                    {
                        cell.Range.Text = dataGridView1.Columns[cell.ColumnIndex - 1].HeaderText;
                        cell.Range.Font.Bold = 1;
                        cell.Range.Font.Name = "verdana";
                        cell.Range.Font.Size = 13;
                        cell.Shading.BackgroundPatternColor = WdColor.wdColorRose;
                        cell.VerticalAlignment = WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                        cell.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                    }
                    else
                    {
                        cell.Range.Text = dataGridView1.Rows[cell.RowIndex - 2].Cells[cell.ColumnIndex - 1].Value.ToString();
                    }
                }
            }
            Paragraph par2 = document.Paragraphs.Last;
            par2.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
            par2.Range.Font.Size = 14;
            par2.Range.Font.Name = "Times New Roman";
            par2.Range.Text += "  ";
            par2.Range.Text += "Дата: " + DateTime.Now.ToString();
            winword.Visible = true;
        }

        private void відвідуанняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            client();
            doc(0);

            /* на кт 2
            Word.Application wordApp = new Word.Application();
            Word.Document wordDoc = wordApp.Documents.Add();
            Word.Paragraph par = wordDoc.Paragraphs.Last;
            par.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            par.Range.Font.Size = 14;
            par.Range.Font.Name = "Times New Roman";
            par.Range.Text = "Звіт";
            par.Range.Text += "«Кількість відвідувань одним клієнтом»";
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                string x = "";
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {

                    x += dataGridView1.Rows[i].Cells[j].Value.ToString() + "  ";
                }
                par.Range.Text += x;
            }
            par.Range.Text += DateTime.Now.ToString();
            wordApp.Visible = true;*/


        }
        private void client()
        {
            toolStripTextBox3.Text = "";
            toolStripTextBox2.Text = "";
            toolStripTextBox1.Text = "";
            toolStrip1.Visible = false;
            label1.Text = "Статистика відвідувань за один місяц";
            OleDbConnection sqlconn = new OleDbConnection(ConnectionString);
            DateTime date = DateTime.Now.AddDays(1);
            string query = "SELECT [Full name], [phone number], Count([ID visiting]) FROM [Visiting], [Client] WHERE((Client.[ID client]=Visiting.[ID client]) AND (Day([Date]) < " + date.Day + " AND MONTH([Date]) = " + date.Month + " ) OR  (Day([Date]) > " + date.Day + " AND MONTH([Date]) = " + date.AddMonths(-1).Month + " )) GROUP BY [Full name], [phone number]";
            OleDbDataAdapter oda = new OleDbDataAdapter(query, sqlconn);
            DataTable dt = new DataTable();
            bs.DataSource = dt;
            oda.Fill(dt);
            dataGridView1.DataSource = bs;
            bindingNavigator1.BindingSource = bs;
            dataGridView1.Columns[0].HeaderText = "Клієнт";
            dataGridView1.Columns[1].HeaderText = "Номер телефону";
            dataGridView1.Columns[2].HeaderText = "Кількість відвідувань";
            sqlconn.Close();
            toolStrip1.Visible = false;
            menuStrip2.Visible = false;
        }
        private void клієнтиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            client();
        }

        private void процедуриToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            toolStripTextBox3.Text = "";
            toolStripTextBox2.Text = "";
            toolStripTextBox1.Text = "";
            toolStrip1.Visible = false;
            label1.Text = "Статистика відгуків";
            OleDbConnection sqlconn = new OleDbConnection(ConnectionString);
            string query = "SELECT Procedure.[Name], [Cost], Count([ID service]) FROM [Service], [Procedure] WHERE(Procedure.[ID procedure]=Service.[ID procedure]) GROUP BY [Name], Cost";
            OleDbDataAdapter oda = new OleDbDataAdapter(query, sqlconn);
            DataTable dt = new DataTable();
            bs.DataSource = dt;
            oda.Fill(dt);
            dataGridView1.DataSource = bs;
            bindingNavigator1.BindingSource = bs;
            dataGridView1.Columns[0].HeaderText = "Процедура";
            dataGridView1.Columns[1].HeaderText = "Ціна";
            dataGridView1.Columns[2].HeaderText = "Кількість її проведення";
            sqlconn.Close();
            toolStrip1.Visible = false;
            menuStrip2.Visible = false;
        }
        private void майстриToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            bs.Filter = null;
            toolStripTextBox3.Text = "";
            toolStripTextBox2.Text = "";
            toolStripTextBox1.Text = "";
            toolStrip1.Visible = false;
            label1.Text = "Статистика проведених процедур майстрами";
            OleDbConnection sqlconn = new OleDbConnection(ConnectionString);
            string query = "SELECT [Full name], [phone number], Count([ID service]) FROM [Service], [Master] WHERE(Master.[ID master]=Service.[ID master]) GROUP BY [Full name], [phone number]";
            OleDbDataAdapter oda = new OleDbDataAdapter(query, sqlconn);
            DataTable dt = new DataTable();
            bs.DataSource = dt;
            oda.Fill(dt);
            dataGridView1.DataSource = bs;
            bindingNavigator1.BindingSource = bs;
            dataGridView1.Columns[0].HeaderText = "Майстер";
            dataGridView1.Columns[1].HeaderText = "Телефон";
            dataGridView1.Columns[2].HeaderText = "Кількість проведених процедур";
            sqlconn.Close();
            toolStrip1.Visible = false;
            menuStrip2.Visible = false;
        }

        private void препаратиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            bs.Filter = null;
            toolStripTextBox3.Text = "";
            toolStripTextBox2.Text = "";
            toolStripTextBox1.Text = "";
            toolStrip1.Visible = false;
            label1.Text = "Статистика відгуків за один місяць";
            OleDbConnection sqlconn = new OleDbConnection(ConnectionString);
            DateTime date = DateTime.Now.AddDays(1);
            string query = "SELECT [number of srarts], Count([ID response]) FROM [Response] WHERE (Day([Date]) < " + date.Day + " AND MONTH([Date]) = " + date.Month + " ) OR  (Day([Date]) > " + date.Day + " AND MONTH([Date]) = " + date.AddMonths(-1).Month + " ) GROUP BY [number of srarts]";
            OleDbDataAdapter oda = new OleDbDataAdapter(query, sqlconn);
            DataTable dt = new DataTable();
            bs.DataSource = dt;
            oda.Fill(dt);
            dataGridView1.DataSource = bs;
            bindingNavigator1.BindingSource = bs;
            dataGridView1.Columns[0].HeaderText = "Оцінка";
            dataGridView1.Columns[1].HeaderText = "Кількість";
            sqlconn.Close();
            toolStrip1.Visible = false;
            menuStrip2.Visible = false;
        }

        private void AdminMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            procedureTableAdapter.Update(cosmetology_centerDataSet1);
            responseTableAdapter.Update(cosmetology_centerDataSet1);
            visitingTableAdapter.Update(cosmetology_centerDataSet1);
            serviceTableAdapter.Update(cosmetology_centerDataSet1);
            preparationTableAdapter.Update(cosmetology_centerDataSet1);
            clientTableAdapter.Update(cosmetology_centerDataSet1);
            masterTableAdapter.Update(cosmetology_centerDataSet1);
            elixirTableAdapter.Update(cosmetology_centerDataSet1);
        }
        public void age()
        {
            OleDbConnection sqlconn = new OleDbConnection(ConnectionString);
            string query = "SELECT Distinct [Age category] FROM [Preparation]";
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
        public void term()
        {
            OleDbConnection sqlconn = new OleDbConnection(ConnectionString);
            string query = "SELECT Distinct [Term of vavidaty] FROM [Preparation]";
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
        private void еліксирToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bs.Filter = null;
            toolStripTextBox3.Text = "";
            toolStripTextBox2.Text = "";
            toolStripTextBox1.Text = "";
            bindingNavigator1.BindingSource = preparationBindingSource;
            dataGridView1.DataSource = preparationBindingSource;
            label1.Text = "Препарати";
            toolStripLabel1.Text = "Назва:";
            toolStripLabel2.Text = "Призначення:";
            toolStripLabel3.Text = "Вікова категорія:";
            toolStripLabel4.Text = "Термін придатності:";
            toolStripLabel5.Text = "Властивості:";
            age();
            term();
            toolStripLabel4.Visible = true;
            toolStripLabel5.Visible = true;
            toolStripComboBox2.Visible = true;
            toolStripTextBox1.Visible = true;
            назваToolStripMenuItem.Text = "Назва";
            цінаToolStripMenuItem.Text = "Номер";
            тривалістьToolStripMenuItem.Text = "Вікова категорія";
            типШкіриToolStripMenuItem.Text = "Термін придатності";
            номерПроцедуриToolStripMenuItem.Visible = true;
            номерПроцедуриToolStripMenuItem.Text = "Призначення";
            властивостіToolStripMenuItem.Text = "Властивості";
            властивостіToolStripMenuItem.Visible = true;
            toolStripLabel2.Visible = true;
            типШкіриToolStripMenuItem.Visible = true;
            toolStripTextBox3.Visible = true;
            toolStrip1.Visible = true;
            menuStrip2.Visible = true;
        }
        public void visit()
        {
            OleDbConnection sqlconn = new OleDbConnection(ConnectionString);
            string query = "SELECT Distinct [ID visiting] FROM [Service]";
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
        private void послугиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bs.Filter = null;
            toolStripTextBox3.Text = "";
            toolStripTextBox2.Text = "";
            toolStripTextBox1.Text = "";
            toolStrip1.Visible = true;
            menuStrip2.Visible = true; 
            OleDbConnection sqlconn = new OleDbConnection(ConnectionString);
            string query = "SELECT [ID service], Master.[Full name], [ID visiting], Procedure.[Name] FROM [Service], [Master], [Procedure] WHERE((Master.[ID master]=Service.[ID master]) AND (Procedure.[ID procedure]=Service.[ID procedure]))";
            OleDbDataAdapter oda = new OleDbDataAdapter(query, sqlconn);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            bs.DataSource = dt;
            dataGridView1.DataSource = bs;
            bindingNavigator1.BindingSource = bs;
            dataGridView1.Columns[0].HeaderText = "Номер послуги";
            dataGridView1.Columns[1].HeaderText = "Мастер";
            dataGridView1.Columns[2].HeaderText = "Номер відвідування";
            dataGridView1.Columns[3].HeaderText = "Назва процедури";
            sqlconn.Close();
            label1.Text = "Послуги";
            toolStripLabel1.Text = "Мастер:";
            toolStripLabel2.Text = "Процедура:";
            toolStripLabel3.Text = "Відвідування:";
            visit();
            toolStripLabel4.Visible = false;
            toolStripLabel5.Visible = false;
            toolStripComboBox2.Visible = false;
            назваToolStripMenuItem.Text = "Номер відвідування";
            цінаToolStripMenuItem.Text = "Номер послуги";
            тривалістьToolStripMenuItem.Text = "Майстер";
            типШкіриToolStripMenuItem.Text = "Процедури";
            номерПроцедуриToolStripMenuItem.Visible = false;
            властивостіToolStripMenuItem.Visible = false;
            toolStripLabel2.Visible = true;
            типШкіриToolStripMenuItem.Visible = true;
            toolStripTextBox3.Visible = true;
            toolStripTextBox1.Visible = false;
        }
        public void data()
        {
            OleDbConnection sqlconn = new OleDbConnection(ConnectionString);
            string query = "SELECT Distinct Month([Date]) FROM [Visiting]";
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
        private void відвідуванняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripTextBox3.Text = "";
            toolStripTextBox2.Text = "";
            toolStripTextBox1.Text = "";
            toolStrip1.Visible = true;
            menuStrip2.Visible = true; 
            OleDbConnection sqlconn = new OleDbConnection(ConnectionString);
            string query = "SELECT [ID visiting], Client.[Full name], [Date] FROM [Visiting], [Client] WHERE(Client.[ID client]=Visiting.[ID client])";
            OleDbDataAdapter oda = new OleDbDataAdapter(query, sqlconn);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            bs.DataSource = dt;
            label1.Text = "Відвідування";
            dataGridView1.DataSource = bs;
            bindingNavigator1.BindingSource = bs;
            dataGridView1.Columns[0].HeaderText = "Номер відвідування";
            dataGridView1.Columns[1].HeaderText = "Клієнт";
            dataGridView1.Columns[2].HeaderText = "Дата";
            sqlconn.Close();
            toolStripLabel1.Text = "Клієнт:";
            toolStripLabel3.Text = "Дата:";
            data();
            toolStripLabel4.Visible = false;
            toolStripLabel5.Visible = false;
            toolStripComboBox2.Visible = false;
            назваToolStripMenuItem.Text = "Номер відвідування";
            цінаToolStripMenuItem.Text = "Клієнт";
            тривалістьToolStripMenuItem.Text = "Дата";
            номерПроцедуриToolStripMenuItem.Visible = false;
            властивостіToolStripMenuItem.Visible = false;
            toolStripLabel2.Visible = false;
            типШкіриToolStripMenuItem.Visible = false;
            toolStripTextBox3.Visible = false;
            toolStripTextBox1.Visible = false;
        }

        private void додатиToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var pf = new PreparationForm();
            pf.ShowDialog();
            preparationTableAdapter.Fill(cosmetology_centerDataSet1.Preparation);
            cosmetology_centerDataSet1.AcceptChanges();
        }
        public void IDProc()
        {
            OleDbConnection sqlconn = new OleDbConnection(ConnectionString);
            string query = "SELECT Distinct [ID procedure] FROM [Elixir]";
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
        public void IDPrep()
        {
            OleDbConnection sqlconn = new OleDbConnection(ConnectionString);
            string query = "SELECT Distinct [ID preparation] FROM [Elixir]";
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
        public void elixir()
        {
            toolStripTextBox3.Text = "";
            toolStripTextBox2.Text = "";
            toolStripTextBox1.Text = "";
            OleDbConnection sqlconn = new OleDbConnection(ConnectionString);
            string query = "SELECT [ID elixir], Elixir.[ID procedure], Procedure.[Name], Elixir.[ID preparation], Preparation.[Name] FROM [Elixir], [Preparation], [Procedure] WHERE((Preparation.[ID preparation]=Elixir.[ID preparation]) AND (Procedure.[ID procedure]=Elixir.[ID procedure]))";
            OleDbDataAdapter oda = new OleDbDataAdapter(query, sqlconn);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            bs.DataSource = dt;
            dataGridView1.DataSource = bs;
            bindingNavigator1.BindingSource = bs;
            dataGridView1.Columns[0].HeaderText = "Номер еліксиру";
            dataGridView1.Columns[1].HeaderText = "Номер процедури";
            dataGridView1.Columns[2].HeaderText = "Назва процедури";
            dataGridView1.Columns[3].HeaderText = "Номер препарату";
            dataGridView1.Columns[4].HeaderText = "Назва препарату";
            sqlconn.Close();
            label1.Text = "Еліксири"; 
            toolStripLabel1.Text = "Назва процедури:";
            toolStripLabel2.Text = "Назва препарату:";
            toolStripLabel3.Text = "№ процедури:";
            toolStripLabel4.Text = "№ препарату:";
            IDPrep();
            IDProc();
            toolStripLabel4.Visible = true;
            toolStripLabel5.Visible = false;
            toolStripComboBox2.Visible = true;
            toolStripTextBox1.Visible = false;
            назваToolStripMenuItem.Text = "Номер еліксиру";
            цінаToolStripMenuItem.Text = "Номер процедури";
            тривалістьToolStripMenuItem.Text = "Назва процедури";
            типШкіриToolStripMenuItem.Text = "Номер препарату";
            номерПроцедуриToolStripMenuItem.Visible = true;
            номерПроцедуриToolStripMenuItem.Text = "Назва препарату";
            властивостіToolStripMenuItem.Visible = false;
            toolStripLabel2.Visible = true;
            типШкіриToolStripMenuItem.Visible = true;
            toolStripTextBox3.Visible = true;
            toolStrip1.Visible = true;
            menuStrip2.Visible = true;
        }
        private void еліксириToolStripMenuItem_Click(object sender, EventArgs e)
        {
            elixir();
        }

        private void оновитиToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var row = dataGridView1.SelectedRows[0];
            if (dataGridView1.DataSource == preparationBindingSource && row.Cells[0] != null)
            {
                var pf = new PreparationForm(
                    Convert.ToInt32(row.Cells[0].Value),
                    row.Cells[1].Value.ToString(),
                    Convert.ToInt32(row.Cells[2].Value),
                    row.Cells[3].Value.ToString(),
                    row.Cells[4].Value.ToString(),
                    row.Cells[5].Value.ToString()
                    );
                pf.ShowDialog();
                preparationTableAdapter.Fill(cosmetology_centerDataSet1.Preparation);
                cosmetology_centerDataSet1.AcceptChanges();
            }
        }

        private void видалитиToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource == preparationBindingSource && dataGridView1.SelectedRows[0].Cells[0] != null)
            {
                DialogResult dr = MessageBox.Show("Ви впевнені?", "", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    preparationTableAdapter.DeleteQuery(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
                }
            }
            preparationTableAdapter.Fill(cosmetology_centerDataSet1.Preparation);
            cosmetology_centerDataSet1.AcceptChanges();
        }

        private void додатиToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            var ef = new ElixirForm();
            ef.ShowDialog();
            elixirTableAdapter.Fill(cosmetology_centerDataSet1.Elixir);
            cosmetology_centerDataSet1.AcceptChanges();
            elixir();
        }

        private void оновитиToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            var row = dataGridView1.SelectedRows[0];
            if (label1.Text == "Еліксири" && row.Cells[0] != null)
            {
                var ef = new ElixirForm(
                    Convert.ToInt32(row.Cells[0].Value),
                    Convert.ToInt32(row.Cells[1].Value),
                    Convert.ToInt32(row.Cells[3].Value)
                    );
                ef.ShowDialog();
                preparationTableAdapter.Fill(cosmetology_centerDataSet1.Preparation);
                cosmetology_centerDataSet1.AcceptChanges();
                elixir();
            }
        }

        private void видалитиToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (label1.Text == "Еліксири" && dataGridView1.SelectedRows[0].Cells[0] != null)
            {
                DialogResult dr = MessageBox.Show("Ви впевнені?", "", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    elixirTableAdapter.DeleteQuery(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
                }
            }
            elixirTableAdapter.Fill(cosmetology_centerDataSet1.Elixir);
            cosmetology_centerDataSet1.AcceptChanges();
            elixir();
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (toolStripTextBox1.Text == "")
            {
                bs.Filter = null;
                preparationBindingSource.Filter = null;
                clientBindingSource.Filter = null;
            }
            else if (label1.Text == "Відгуки")
            {
                bs.Filter = " [Full name] Like'" + toolStripTextBox1.Text + "%'";
            }
            else if (label1.Text == "Препарати")
            {
                preparationBindingSource.Filter = " [Властивості] Like'" + toolStripTextBox1.Text + "%'";
            }
            else if (label1.Text == "Клієнти")
            {
                clientBindingSource.Filter = " [Ціль приходу] Like'" + toolStripTextBox1.Text + "%'";
            }
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
            else if (label1.Text == "Відгуки")
            {
                OleDbConnection sqlconn = new OleDbConnection(ConnectionString);
                string query = $"SELECT [Number of srarts], [Comment], [Full name], [Name], [Date] FROM [Response], [Client], [Procedure] WHERE((Client.[ID client]=Response.[ID client]) AND (Procedure.[ID procedure]=Response.[ID procedure]) AND ([Number of srarts] = {toolStripComboBox1.ComboBox.SelectedValue.ToString()} ))";
                OleDbDataAdapter oda = new OleDbDataAdapter(query, sqlconn);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                bs.DataSource = dt;
                dataGridView1.DataSource = bs;
                bindingNavigator1.BindingSource = bs;
            }
            else if (label1.Text == "Відвідування")
            {
                OleDbConnection sqlconn = new OleDbConnection(ConnectionString);
                string query = $"SELECT [ID visiting], Client.[Full name], [Date] FROM [Visiting], [Client] WHERE((Client.[ID client]=Visiting.[ID client]) AND (Month([Date]) = {toolStripComboBox1.ComboBox.SelectedValue.ToString()}))";
                OleDbDataAdapter oda = new OleDbDataAdapter(query, sqlconn);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                bs.DataSource = dt;
                dataGridView1.DataSource = bs;
                bindingNavigator1.BindingSource = bs;
            }
            else if (label1.Text == "Майстри")
            {
                masterBindingSource.Filter = " [Стать] Like'" + toolStripComboBox1.ComboBox.SelectedValue.ToString() + "%'";
            }
            else if (label1.Text == "Препарати")
            {
                OleDbConnection sqlconn = new OleDbConnection(ConnectionString);
                string query = $"SELECT * FROM [Preparation] WHERE [Age category] = '{toolStripComboBox1.ComboBox.SelectedValue.ToString()}'";
                OleDbDataAdapter oda = new OleDbDataAdapter(query, sqlconn);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                bs.DataSource = dt;
                dataGridView1.DataSource = bs;
                bindingNavigator1.BindingSource = bs;
            }
            else if (label1.Text == "Клієнти")
            {
                clientBindingSource.Filter = " [Стать] Like'" + toolStripComboBox1.ComboBox.SelectedValue.ToString() + "%'";
            }
            else if (label1.Text == "Еліксири")
            {
                OleDbConnection sqlconn = new OleDbConnection(ConnectionString);
                string query = $"SELECT [ID elixir], Elixir.[ID procedure], Procedure.[Name], Elixir.[ID preparation], Preparation.[Name] FROM [Elixir], [Preparation], [Procedure] WHERE((Preparation.[ID preparation]=Elixir.[ID preparation]) AND (Procedure.[ID procedure]=Elixir.[ID procedure]) AND (Elixir.[ID procedure] = {toolStripComboBox1.ComboBox.SelectedValue.ToString()}))";
                OleDbDataAdapter oda = new OleDbDataAdapter(query, sqlconn);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                bs.DataSource = dt;
                dataGridView1.DataSource = bs;
                bindingNavigator1.BindingSource = bs;
            }
            else if (label1.Text == "Послуги")
            {
                OleDbConnection sqlconn = new OleDbConnection(ConnectionString);
                string query = $"SELECT [ID service], Master.[Full name], [ID visiting], Procedure.[Name] FROM [Service], [Master], [Procedure] WHERE((Master.[ID master]=Service.[ID master]) AND (Procedure.[ID procedure]=Service.[ID procedure]) AND ([ID visiting] = {toolStripComboBox1.ComboBox.SelectedValue.ToString()}))";
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
            if (label1.Text == "Процедури")
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
            else if (label1.Text == "Препарати")
            {
                OleDbConnection sqlconn = new OleDbConnection(ConnectionString);
                string query = $"SELECT * FROM [Preparation] WHERE [Term of vavidaty] = {toolStripComboBox2.ComboBox.SelectedValue.ToString()}";
                OleDbDataAdapter oda = new OleDbDataAdapter(query, sqlconn);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                bs.DataSource = dt;
                dataGridView1.DataSource = bs;
                bindingNavigator1.BindingSource = bs;
            }
            else if (label1.Text == "Клієнти")
            {
                OleDbConnection sqlconn = new OleDbConnection(ConnectionString);
                string query = $"SELECT * FROM [Client] WHERE [Year of birth] = {toolStripComboBox2.ComboBox.SelectedValue.ToString()}";
                OleDbDataAdapter oda = new OleDbDataAdapter(query, sqlconn);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                bs.DataSource = dt;
                dataGridView1.DataSource = bs;
                bindingNavigator1.BindingSource = bs;
            }
            else if (label1.Text == "Еліксири")
            {
                OleDbConnection sqlconn = new OleDbConnection(ConnectionString);
                string query = $"SELECT [ID elixir], Elixir.[ID procedure], Procedure.[Name], Elixir.[ID preparation], Preparation.[Name] FROM [Elixir], [Preparation], [Procedure] WHERE((Preparation.[ID preparation]=Elixir.[ID preparation]) AND (Procedure.[ID procedure]=Elixir.[ID procedure]) AND (Elixir.[ID preparation] = {toolStripComboBox2.ComboBox.SelectedValue.ToString()}))";
                OleDbDataAdapter oda = new OleDbDataAdapter(query, sqlconn);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                bs.DataSource = dt;
                dataGridView1.DataSource = bs;
                bindingNavigator1.BindingSource = bs;
            }
        }

        private void назваToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Descending);
        }

        private void цінаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns[1], ListSortDirection.Ascending);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns[1], ListSortDirection.Descending);
        }

        private void тривалістьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns[2], ListSortDirection.Ascending);
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns[2], ListSortDirection.Descending);
        }

        private void типШкіриToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns[3], ListSortDirection.Ascending);
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns[3], ListSortDirection.Descending);
        }

        private void номерПроцедуриToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns[4], ListSortDirection.Ascending);
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns[4], ListSortDirection.Descending);
        }

        private void властивостіToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(label1.Text == "Клієнти")
                dataGridView1.Sort(dataGridView1.Columns[7], ListSortDirection.Ascending);
            else
                dataGridView1.Sort(dataGridView1.Columns[5], ListSortDirection.Ascending);
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            if (label1.Text == "Клієнти")
                dataGridView1.Sort(dataGridView1.Columns[7], ListSortDirection.Descending);
            else
                dataGridView1.Sort(dataGridView1.Columns[5], ListSortDirection.Descending);
        }
    }
}
