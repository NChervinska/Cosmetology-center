using System;
using System.Windows.Forms;

namespace Cosmetology
{
    public partial class EnterForm : Form
    {
        public EnterForm()
        {
            InitializeComponent();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar))
                e.Handled = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void button_Ok_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "111")
            {
                var vf = new AdminMainForm();
                vf.Show();
                this.Close();
            }
            else
                MessageBox.Show("Невірний пароль або ім'я!");
        }
    }
}
