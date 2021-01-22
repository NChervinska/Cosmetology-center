using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Cosmetology
{
    public partial class ProcedureForm : Form
    {
        public bool edit;
        public int ID;
        public ProcedureForm()
        {
            InitializeComponent();
            edit = false;
            comboBox1.SelectedIndex = 0;
        }
        public ProcedureForm(string name, int ID, string skin, int cost, int durating)
            : this()
        {
            this.ID = ID;
            edit = true;
            назваTextBox.Text = name;
            comboBox1.SelectedValue = skin;
            цінаTextBox.Text = Convert.ToString(cost);
            тривалістьTextBox.Text = Convert.ToString(durating);
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_Ok_Click(object sender, EventArgs e)
        {
            if (!(тривалістьTextBox.Text.Length < 2 || цінаTextBox.Text.Length < 2 || назваTextBox.Text.Length < 4))
            {
                string skin = "Нормальна шкіра";
                if (comboBox1.SelectedIndex == 0)
                {
                    skin = "Нормальна шкіра";
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    skin = "Суха шкіра";
                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    skin = "Жирна шкіра";
                }
                else if (comboBox1.SelectedIndex == 3)
                {
                    skin = "Комбінована шкіра";
                }
                else if (comboBox1.SelectedIndex == 4)
                {
                    skin = "Чутлива шкіра";
                }
                if (edit)
                {
                    procedureTableAdapter.UpdateQuery(назваTextBox.Text, skin, Convert.ToInt32(цінаTextBox.Text), Convert.ToInt32(тривалістьTextBox.Text), ID);
                }
                else
                {
                    procedureTableAdapter.Insert(назваTextBox.Text, skin, Convert.ToInt32(цінаTextBox.Text), Convert.ToInt32(тривалістьTextBox.Text));
                }
                this.Close();
            }
            else
                MessageBox.Show("Заповніть усі поля!");
        }

        private void назваTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != 32)
                e.Handled = true;
        }

        private void цінаTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void тривалістьTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void назваTextBox_Validating(object sender, CancelEventArgs e)
        {

            if (назваTextBox.Text == "")
                errorProvider1.SetError(назваTextBox, "Не вказана назва");
            else if (назваTextBox.Text.Length < 4)
                errorProvider1.SetError(назваTextBox, "Занадто коротке ім'я");
            else
                errorProvider1.Clear();
        }

        private void цінаTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (цінаTextBox.Text == "")
                errorProvider1.SetError(цінаTextBox, "Не вказана ціна");
            else if (цінаTextBox.Text.Length < 2)
                errorProvider1.SetError(цінаTextBox, "Занадто коротка ціна");
            else
                errorProvider1.Clear();
        }

        private void тривалістьTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (тривалістьTextBox.Text == "")
                errorProvider1.SetError(тривалістьTextBox, "Не вказана тривалість");
            else if (тривалістьTextBox.Text.Length < 2)
                errorProvider1.SetError(тривалістьTextBox, "Занадто коротка тривалість");
            else
                errorProvider1.Clear();
        }

        private void ProcedureForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cosmetology_centerDataSet1.Procedure". При необходимости она может быть перемещена или удалена.
            this.procedureTableAdapter.Fill(this.cosmetology_centerDataSet1.Procedure);

        }
    }
}
