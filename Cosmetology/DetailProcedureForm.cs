using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Cosmetology
{
    public partial class DetailProcedureForm : Form
    {
        public DetailProcedureForm()
        {
            InitializeComponent();
        }

        private void ProcedureForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cosmetology_centerDataSet1.Preparation". При необходимости она может быть перемещена или удалена.
            this.preparationTableAdapter.Fill(this.cosmetology_centerDataSet1.Preparation);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cosmetology_centerDataSet1.Elixir". При необходимости она может быть перемещена или удалена.
            this.elixirTableAdapter.Fill(this.cosmetology_centerDataSet1.Elixir);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cosmetology_centerDataSet1.Procedure". При необходимости она может быть перемещена или удалена.
            this.procedureTableAdapter.Fill(this.cosmetology_centerDataSet1.Procedure);
        }

        private void procedureBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.procedureBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cosmetology_centerDataSet1);

        }

        private void цінаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            elixirDataGridView.Sort(elixirDataGridView.Columns["Номер еліксиру"], ListSortDirection.Ascending);
        }

        private void тривалістьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            elixirDataGridView.Sort(elixirDataGridView.Columns["Номер процедури"], ListSortDirection.Ascending);
        }

        private void типШкіриToolStripMenuItem_Click(object sender, EventArgs e)
        {
            elixirDataGridView.Sort(elixirDataGridView.Columns["Номер препарату"], ListSortDirection.Ascending);
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {

        }
    }
}
