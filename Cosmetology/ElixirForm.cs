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
    public partial class ElixirForm : Form
    {
        public bool edit;
        public int ID;
        public ElixirForm()
        {
            InitializeComponent();
            edit = false;
        }
        public ElixirForm(int ID, int proc, int prep)
        :this()
        {
            this.ID = ID;
            edit = true;
            номер_процедуриComboBox.SelectedValue = proc;
            номер_препаратуComboBox.SelectedValue = prep;
        }

        private void ElixirForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cosmetology_centerDataSet1.Preparation". При необходимости она может быть перемещена или удалена.
            this.preparationTableAdapter.Fill(this.cosmetology_centerDataSet1.Preparation);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cosmetology_centerDataSet1.Procedure". При необходимости она может быть перемещена или удалена.
            this.procedureTableAdapter.Fill(this.cosmetology_centerDataSet1.Procedure);

        }

        private void button_Ok_Click(object sender, EventArgs e)
        {
             if (edit)
                    elixirTableAdapter.UpdateQuery(Convert.ToInt32(номер_процедуриComboBox.SelectedValue), Convert.ToInt32(номер_препаратуComboBox.SelectedValue),ID );

                else
                {
                    elixirTableAdapter.Insert(Convert.ToInt32(номер_процедуриComboBox.SelectedValue), Convert.ToInt32(номер_препаратуComboBox.SelectedValue));
                }
                this.Close();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
