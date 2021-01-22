using System;
using System.Windows.Forms;

namespace Cosmetology
{
    public partial class ServiceForm : Form
    {
        public readonly int id;
        public readonly int visiting;
        public bool edit;
        public ServiceForm(int visiting)
        {
            InitializeComponent();
            edit = false;
            this.visiting = visiting;
        }
        public ServiceForm(int ID, int master, int visiting, int procedure)
            : this(visiting)
        {
            this.visiting = visiting;
            edit = true;
            id = ID;
            ___майструComboBox.SelectedValue = master;
            comboBox1.SelectedValue = procedure;
        }
        private void ServiceForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cosmetology_centerDataSet1.Service". При необходимости она может быть перемещена или удалена.
            this.serviceTableAdapter.Fill(this.cosmetology_centerDataSet1.Service);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cosmetology_centerDataSet1.Procedure". При необходимости она может быть перемещена или удалена.
            this.procedureTableAdapter.Fill(this.cosmetology_centerDataSet1.Procedure);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cosmetology_centerDataSet1.Master". При необходимости она может быть перемещена или удалена.
            this.masterTableAdapter.Fill(this.cosmetology_centerDataSet1.Master);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cosmetology_centerDataSet1.Visiting". При необходимости она может быть перемещена или удалена.
            this.visitingTableAdapter.Fill(this.cosmetology_centerDataSet1.Visiting);
        }

        private void button_Ok_Click(object sender, EventArgs e)
        {
            if (edit)
            {
                serviceTableAdapter.UpdateQuery(Convert.ToInt32(___майструComboBox.SelectedValue), visiting, Convert.ToInt32(comboBox1.SelectedValue), id);
            }
            else
            {
                serviceTableAdapter.Insert(Convert.ToInt32(___майструComboBox.SelectedValue), visiting, Convert.ToInt32(comboBox1.SelectedValue));
            }
            var f = new InterForm();
            f.Show();
            this.Close();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ServiceForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            serviceTableAdapter.Update(cosmetology_centerDataSet1);
        }
    }
}
