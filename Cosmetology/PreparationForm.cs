using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cosmetology
{
    public partial class PreparationForm : Form
    {
        public bool edit;
        public int ID;
        public PreparationForm()
        {
            InitializeComponent();
            edit = false;
        }
        public PreparationForm(int ID, string age, int term, string appoin, string propetries, string name)
            : this()
        {
            this.ID = ID;
            edit = true;
            назваTextBox.Text = name;
            вікова_категоріяTextBox.Text = age;
            термін_придатностіNumericUpDown.Value = term;
            призначенняTextBox.Text = appoin;
            властивостіTextBox.Text = propetries;
        }

        private void вікова_категоріяTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 43)
                e.Handled = true;
        }

        private void призначенняTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != 32)
                e.Handled = true;
        }

        private void призначенняTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (призначенняTextBox.Text == "")
                errorProvider1.SetError(призначенняTextBox, "Не вказано призначення");
            else
                errorProvider1.Clear();
        }

        private void властивостіTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (властивостіTextBox.Text == "")
                errorProvider1.SetError(властивостіTextBox, "Не вказано призначення");
            else
                errorProvider1.Clear();
        }

        private void назваTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (назваTextBox.Text == "")
                errorProvider1.SetError(назваTextBox, "Не вказана назва");
            else if (назваTextBox.Text.Length < 3)
                errorProvider1.SetError(назваTextBox, "Занадто коротка назва");
            else
                errorProvider1.Clear();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_Ok_Click(object sender, EventArgs e)
        {
            if (!(назваTextBox.Text.Length < 3 || властивостіTextBox.Text.Length < 1 || призначенняTextBox.Text.Length < 1))
            {
                if (edit)
                {
                     preparationTableAdapter.UpdateQuery(вікова_категоріяTextBox.Text, Convert.ToInt32(термін_придатностіNumericUpDown.Value), призначенняTextBox.Text, властивостіTextBox.Text, назваTextBox.Text, ID);
                }
                else
                {
                    preparationTableAdapter.Insert(вікова_категоріяTextBox.Text, Convert.ToInt32(термін_придатностіNumericUpDown.Value), призначенняTextBox.Text, властивостіTextBox.Text, назваTextBox.Text);
                }
                this.Close();
            }
            else
                MessageBox.Show("Заповніть усі поля!");
        }
    }
}
