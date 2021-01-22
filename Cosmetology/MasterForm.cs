using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Cosmetology
{
    public partial class MasterForm : Form
    {
        public bool edit;
        public int ID;
        public MasterForm()
        {
            InitializeComponent();
            статьComboBox.SelectedIndex = 0;
            edit = false;
        }
        public MasterForm(string name, string gender, int ID, int telephone, string address)
            : this()
        {
            this.ID = ID;
            edit = true;
            пІБTextBox.Text = name;
            статьComboBox.SelectedValue = gender;
            адресаTextBox.Text = address;
            номер_телефонуTextBox.Text = Convert.ToString(telephone);
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_Ok_Click(object sender, EventArgs e)
        {
            if (!(пІБTextBox.Text.Length < 4 || адресаTextBox.Text.Length < 6 || адресаTextBox.Text.IndexOf('@') < 0 || адресаTextBox.Text.IndexOf('.') < 0) || номер_телефонуTextBox.Text.Length < 8 || номер_телефонуTextBox.Text.Length > 10)
            {
                string gender = "ж";
                if (статьComboBox.SelectedIndex == 0)
                {
                    gender = "ж";
                }
                else if (статьComboBox.SelectedIndex == 1)
                {
                    gender = "м";
                }
                if (edit)
                {
                    masterTableAdapter.UpdateQuery(пІБTextBox.Text, gender, Convert.ToInt32(номер_телефонуTextBox.Text), адресаTextBox.Text, ID);
                }
                else
                {
                    masterTableAdapter.Insert(пІБTextBox.Text, gender, Convert.ToInt32(номер_телефонуTextBox.Text), адресаTextBox.Text);
                }
                this.Close();
            }
            else
                MessageBox.Show("Заповніть усі поля!");

        }

        private void пІБTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != 32)
                e.Handled = true;
        }

        private void номер_телефонуTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void MasterForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cosmetology_centerDataSet1.Master". При необходимости она может быть перемещена или удалена.
            this.masterTableAdapter.Fill(this.cosmetology_centerDataSet1.Master);

        }

        private void пІБTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (пІБTextBox.Text == "")
                errorProvider1.SetError(пІБTextBox, "Не вказано ім'я");
            else if (пІБTextBox.Text.Length < 4)
                errorProvider1.SetError(пІБTextBox, "Занадто коротке ім'я");
            else
                errorProvider1.Clear();
        }

        private void адресаTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (адресаTextBox.Text == "")
                errorProvider1.SetError(адресаTextBox, "Не вказана електрона адреса");
            else if (адресаTextBox.Text.Length < 6)
                errorProvider1.SetError(адресаTextBox, "Занадто коротка адреса");
            else if (адресаTextBox.Text.IndexOf('@') < 0)
                errorProvider1.SetError(адресаTextBox, "Адреса повинна місти @");
            else if (адресаTextBox.Text.IndexOf('.') < 0)
                errorProvider1.SetError(адресаTextBox, "Адреса повинна місти .");
            else
                errorProvider1.Clear();
        }

        private void номер_телефонуTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (номер_телефонуTextBox.Text == "")
                errorProvider1.SetError(номер_телефонуTextBox, "Не вказан телефон");
            else if (номер_телефонуTextBox.Text.Length < 8)
                errorProvider1.SetError(номер_телефонуTextBox, "Занадто короткий телефон");
            else if (номер_телефонуTextBox.Text.Length > 10)
                errorProvider1.SetError(номер_телефонуTextBox, "Занадто довгий телефон");
            else
                errorProvider1.Clear();
        }
    }
}
