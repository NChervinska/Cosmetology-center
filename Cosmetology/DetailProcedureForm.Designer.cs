namespace Cosmetology
{
    partial class DetailProcedureForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label назваLabel;
            System.Windows.Forms.Label номер_процедуриLabel;
            System.Windows.Forms.Label тип_шкіриLabel;
            System.Windows.Forms.Label цінаLabel;
            System.Windows.Forms.Label тривалістьLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailProcedureForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cosmetology_centerDataSet1 = new Cosmetology.cosmetology_centerDataSet1();
            this.procedureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.procedureTableAdapter = new Cosmetology.cosmetology_centerDataSet1TableAdapters.ProcedureTableAdapter();
            this.tableAdapterManager = new Cosmetology.cosmetology_centerDataSet1TableAdapters.TableAdapterManager();
            this.elixirTableAdapter = new Cosmetology.cosmetology_centerDataSet1TableAdapters.ElixirTableAdapter();
            this.preparationTableAdapter = new Cosmetology.cosmetology_centerDataSet1TableAdapters.PreparationTableAdapter();
            this.procedureBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.procedureBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.назваTextBox = new System.Windows.Forms.TextBox();
            this.номер_процедуриTextBox = new System.Windows.Forms.TextBox();
            this.тип_шкіриTextBox = new System.Windows.Forms.TextBox();
            this.цінаTextBox = new System.Windows.Forms.TextBox();
            this.тривалістьTextBox = new System.Windows.Forms.TextBox();
            this.elixirDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elixirBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.preparationDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preparationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            назваLabel = new System.Windows.Forms.Label();
            номер_процедуриLabel = new System.Windows.Forms.Label();
            тип_шкіриLabel = new System.Windows.Forms.Label();
            цінаLabel = new System.Windows.Forms.Label();
            тривалістьLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cosmetology_centerDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.procedureBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.procedureBindingNavigator)).BeginInit();
            this.procedureBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.elixirDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elixirBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preparationDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preparationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // назваLabel
            // 
            назваLabel.AutoSize = true;
            назваLabel.Location = new System.Drawing.Point(31, 85);
            назваLabel.Name = "назваLabel";
            назваLabel.Size = new System.Drawing.Size(52, 17);
            назваLabel.TabIndex = 1;
            назваLabel.Text = "Назва:";
            // 
            // номер_процедуриLabel
            // 
            номер_процедуриLabel.AutoSize = true;
            номер_процедуриLabel.Location = new System.Drawing.Point(31, 114);
            номер_процедуриLabel.Name = "номер_процедуриLabel";
            номер_процедуриLabel.Size = new System.Drawing.Size(130, 17);
            номер_процедуриLabel.TabIndex = 3;
            номер_процедуриLabel.Text = "Номер процедури:";
            // 
            // тип_шкіриLabel
            // 
            тип_шкіриLabel.AutoSize = true;
            тип_шкіриLabel.Location = new System.Drawing.Point(31, 143);
            тип_шкіриLabel.Name = "тип_шкіриLabel";
            тип_шкіриLabel.Size = new System.Drawing.Size(78, 17);
            тип_шкіриLabel.TabIndex = 5;
            тип_шкіриLabel.Text = "Тип шкіри:";
            // 
            // цінаLabel
            // 
            цінаLabel.AutoSize = true;
            цінаLabel.Location = new System.Drawing.Point(31, 172);
            цінаLabel.Name = "цінаLabel";
            цінаLabel.Size = new System.Drawing.Size(42, 17);
            цінаLabel.TabIndex = 7;
            цінаLabel.Text = "Ціна:";
            // 
            // тривалістьLabel
            // 
            тривалістьLabel.AutoSize = true;
            тривалістьLabel.Location = new System.Drawing.Point(31, 201);
            тривалістьLabel.Name = "тривалістьLabel";
            тривалістьLabel.Size = new System.Drawing.Size(84, 17);
            тривалістьLabel.TabIndex = 9;
            тривалістьLabel.Text = "Тривалість:";
            // 
            // cosmetology_centerDataSet1
            // 
            this.cosmetology_centerDataSet1.DataSetName = "cosmetology_centerDataSet1";
            this.cosmetology_centerDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // procedureBindingSource
            // 
            this.procedureBindingSource.DataMember = "Procedure";
            this.procedureBindingSource.DataSource = this.cosmetology_centerDataSet1;
            // 
            // procedureTableAdapter
            // 
            this.procedureTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientTableAdapter = null;
            this.tableAdapterManager.ElixirTableAdapter = this.elixirTableAdapter;
            this.tableAdapterManager.MasterTableAdapter = null;
            this.tableAdapterManager.PreparationTableAdapter = this.preparationTableAdapter;
            this.tableAdapterManager.ProcedureTableAdapter = this.procedureTableAdapter;
            this.tableAdapterManager.ResponseTableAdapter = null;
            this.tableAdapterManager.ServiceTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Cosmetology.cosmetology_centerDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VisitingTableAdapter = null;
            // 
            // elixirTableAdapter
            // 
            this.elixirTableAdapter.ClearBeforeFill = true;
            // 
            // preparationTableAdapter
            // 
            this.preparationTableAdapter.ClearBeforeFill = true;
            // 
            // procedureBindingNavigator
            // 
            this.procedureBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.procedureBindingNavigator.BackColor = System.Drawing.Color.White;
            this.procedureBindingNavigator.BindingSource = this.procedureBindingSource;
            this.procedureBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.procedureBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.procedureBindingNavigator.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.procedureBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.procedureBindingNavigatorSaveItem});
            this.procedureBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.procedureBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.procedureBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.procedureBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.procedureBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.procedureBindingNavigator.Name = "procedureBindingNavigator";
            this.procedureBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.procedureBindingNavigator.Size = new System.Drawing.Size(734, 25);
            this.procedureBindingNavigator.TabIndex = 0;
            this.procedureBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(51, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // procedureBindingNavigatorSaveItem
            // 
            this.procedureBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.procedureBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("procedureBindingNavigatorSaveItem.Image")));
            this.procedureBindingNavigatorSaveItem.Name = "procedureBindingNavigatorSaveItem";
            this.procedureBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.procedureBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.procedureBindingNavigatorSaveItem.Click += new System.EventHandler(this.procedureBindingNavigatorSaveItem_Click);
            // 
            // назваTextBox
            // 
            this.назваTextBox.BackColor = System.Drawing.Color.Pink;
            this.назваTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.назваTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.procedureBindingSource, "Назва", true));
            this.назваTextBox.Location = new System.Drawing.Point(174, 85);
            this.назваTextBox.Name = "назваTextBox";
            this.назваTextBox.ReadOnly = true;
            this.назваTextBox.Size = new System.Drawing.Size(171, 16);
            this.назваTextBox.TabIndex = 2;
            // 
            // номер_процедуриTextBox
            // 
            this.номер_процедуриTextBox.BackColor = System.Drawing.Color.Pink;
            this.номер_процедуриTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.номер_процедуриTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.procedureBindingSource, "Номер процедури", true));
            this.номер_процедуриTextBox.Location = new System.Drawing.Point(174, 114);
            this.номер_процедуриTextBox.Name = "номер_процедуриTextBox";
            this.номер_процедуриTextBox.ReadOnly = true;
            this.номер_процедуриTextBox.Size = new System.Drawing.Size(171, 16);
            this.номер_процедуриTextBox.TabIndex = 4;
            // 
            // тип_шкіриTextBox
            // 
            this.тип_шкіриTextBox.BackColor = System.Drawing.Color.Pink;
            this.тип_шкіриTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.тип_шкіриTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.procedureBindingSource, "Тип шкіри", true));
            this.тип_шкіриTextBox.Location = new System.Drawing.Point(174, 143);
            this.тип_шкіриTextBox.Name = "тип_шкіриTextBox";
            this.тип_шкіриTextBox.ReadOnly = true;
            this.тип_шкіриTextBox.Size = new System.Drawing.Size(171, 16);
            this.тип_шкіриTextBox.TabIndex = 6;
            // 
            // цінаTextBox
            // 
            this.цінаTextBox.BackColor = System.Drawing.Color.Pink;
            this.цінаTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.цінаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.procedureBindingSource, "Ціна", true));
            this.цінаTextBox.Location = new System.Drawing.Point(174, 172);
            this.цінаTextBox.Name = "цінаTextBox";
            this.цінаTextBox.ReadOnly = true;
            this.цінаTextBox.Size = new System.Drawing.Size(171, 16);
            this.цінаTextBox.TabIndex = 8;
            // 
            // тривалістьTextBox
            // 
            this.тривалістьTextBox.BackColor = System.Drawing.Color.Pink;
            this.тривалістьTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.тривалістьTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.procedureBindingSource, "Тривалість", true));
            this.тривалістьTextBox.Location = new System.Drawing.Point(174, 201);
            this.тривалістьTextBox.Name = "тривалістьTextBox";
            this.тривалістьTextBox.ReadOnly = true;
            this.тривалістьTextBox.Size = new System.Drawing.Size(171, 16);
            this.тривалістьTextBox.TabIndex = 10;
            // 
            // elixirDataGridView
            // 
            this.elixirDataGridView.AllowUserToAddRows = false;
            this.elixirDataGridView.AllowUserToDeleteRows = false;
            this.elixirDataGridView.AutoGenerateColumns = false;
            this.elixirDataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle31.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle31.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.elixirDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle31;
            this.elixirDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.elixirDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.elixirDataGridView.DataSource = this.elixirBindingSource;
            this.elixirDataGridView.GridColor = System.Drawing.Color.MistyRose;
            this.elixirDataGridView.Location = new System.Drawing.Point(351, 66);
            this.elixirDataGridView.MultiSelect = false;
            this.elixirDataGridView.Name = "elixirDataGridView";
            this.elixirDataGridView.ReadOnly = true;
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle32.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle32.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.elixirDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle32;
            dataGridViewCellStyle33.SelectionBackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle33.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.elixirDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle33;
            this.elixirDataGridView.Size = new System.Drawing.Size(344, 177);
            this.elixirDataGridView.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Номер еліксиру";
            this.dataGridViewTextBoxColumn7.HeaderText = "Номер еліксиру";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Номер процедури";
            this.dataGridViewTextBoxColumn8.HeaderText = "Номер процедури";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Номер препарату";
            this.dataGridViewTextBoxColumn9.HeaderText = "Номер препарату";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // elixirBindingSource
            // 
            this.elixirBindingSource.DataMember = "Procedure_Elixir";
            this.elixirBindingSource.DataSource = this.procedureBindingSource;
            // 
            // preparationDataGridView
            // 
            this.preparationDataGridView.AllowUserToAddRows = false;
            this.preparationDataGridView.AllowUserToDeleteRows = false;
            this.preparationDataGridView.AutoGenerateColumns = false;
            this.preparationDataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle34.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle34.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle34.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle34.SelectionBackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle34.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle34.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.preparationDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle34;
            this.preparationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.preparationDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15});
            this.preparationDataGridView.DataSource = this.preparationBindingSource;
            this.preparationDataGridView.GridColor = System.Drawing.Color.MistyRose;
            this.preparationDataGridView.Location = new System.Drawing.Point(49, 286);
            this.preparationDataGridView.MultiSelect = false;
            this.preparationDataGridView.Name = "preparationDataGridView";
            this.preparationDataGridView.ReadOnly = true;
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle35.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle35.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle35.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle35.SelectionBackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle35.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle35.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.preparationDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle35;
            dataGridViewCellStyle36.SelectionBackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle36.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.preparationDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle36;
            this.preparationDataGridView.Size = new System.Drawing.Size(643, 132);
            this.preparationDataGridView.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Номер препарату";
            this.dataGridViewTextBoxColumn10.HeaderText = "Номер препарату";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Вікова категорія";
            this.dataGridViewTextBoxColumn11.HeaderText = "Вікова категорія";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Термін придатності";
            this.dataGridViewTextBoxColumn12.HeaderText = "Термін придатності";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Призначення";
            this.dataGridViewTextBoxColumn13.HeaderText = "Призначення";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Властивості";
            this.dataGridViewTextBoxColumn14.HeaderText = "Властивості";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Назва";
            this.dataGridViewTextBoxColumn15.HeaderText = "Назва";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            // 
            // preparationBindingSource
            // 
            this.preparationBindingSource.DataMember = "Elixir_Preparation";
            this.preparationBindingSource.DataSource = this.elixirBindingSource;
            // 
            // DetailProcedureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.preparationDataGridView);
            this.Controls.Add(this.elixirDataGridView);
            this.Controls.Add(назваLabel);
            this.Controls.Add(this.назваTextBox);
            this.Controls.Add(номер_процедуриLabel);
            this.Controls.Add(this.номер_процедуриTextBox);
            this.Controls.Add(тип_шкіриLabel);
            this.Controls.Add(this.тип_шкіриTextBox);
            this.Controls.Add(цінаLabel);
            this.Controls.Add(this.цінаTextBox);
            this.Controls.Add(тривалістьLabel);
            this.Controls.Add(this.тривалістьTextBox);
            this.Controls.Add(this.procedureBindingNavigator);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(750, 500);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(750, 500);
            this.Name = "DetailProcedureForm";
            this.Text = "Cosmetology";
            this.Load += new System.EventHandler(this.ProcedureForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cosmetology_centerDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.procedureBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.procedureBindingNavigator)).EndInit();
            this.procedureBindingNavigator.ResumeLayout(false);
            this.procedureBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.elixirDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elixirBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preparationDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preparationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private cosmetology_centerDataSet1 cosmetology_centerDataSet1;
        private System.Windows.Forms.BindingSource procedureBindingSource;
        private cosmetology_centerDataSet1TableAdapters.ProcedureTableAdapter procedureTableAdapter;
        private cosmetology_centerDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator procedureBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton procedureBindingNavigatorSaveItem;
        private cosmetology_centerDataSet1TableAdapters.ElixirTableAdapter elixirTableAdapter;
        private System.Windows.Forms.TextBox назваTextBox;
        private System.Windows.Forms.TextBox номер_процедуриTextBox;
        private System.Windows.Forms.TextBox тип_шкіриTextBox;
        private System.Windows.Forms.TextBox цінаTextBox;
        private System.Windows.Forms.TextBox тривалістьTextBox;
        private System.Windows.Forms.BindingSource elixirBindingSource;
        private cosmetology_centerDataSet1TableAdapters.PreparationTableAdapter preparationTableAdapter;
        private System.Windows.Forms.DataGridView elixirDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.BindingSource preparationBindingSource;
        private System.Windows.Forms.DataGridView preparationDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
    }
}