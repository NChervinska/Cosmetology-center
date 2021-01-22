namespace Cosmetology
{
    partial class InterForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InterForm));
            this.serviceDataGridView = new System.Windows.Forms.DataGridView();
            this.button_Ok = new System.Windows.Forms.Button();
            this.cosmetology_centerDataSet1 = new Cosmetology.cosmetology_centerDataSet1();
            this.serviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serviceTableAdapter = new Cosmetology.cosmetology_centerDataSet1TableAdapters.ServiceTableAdapter();
            this.tableAdapterManager1 = new Cosmetology.cosmetology_centerDataSet1TableAdapters.TableAdapterManager();
            this.послугаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.додатиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оновитиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видалитиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.назваToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.цінаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.тривалістьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.типШкіриToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.номерПроцедуриToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBox3 = new System.Windows.Forms.ToolStripTextBox();
            this.коштовністьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.serviceDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cosmetology_centerDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // serviceDataGridView
            // 
            this.serviceDataGridView.AllowUserToAddRows = false;
            this.serviceDataGridView.AllowUserToDeleteRows = false;
            this.serviceDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.serviceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.serviceDataGridView.GridColor = System.Drawing.Color.MistyRose;
            this.serviceDataGridView.Location = new System.Drawing.Point(13, 46);
            this.serviceDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.serviceDataGridView.MultiSelect = false;
            this.serviceDataGridView.Name = "serviceDataGridView";
            this.serviceDataGridView.ReadOnly = true;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.serviceDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.serviceDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.serviceDataGridView.Size = new System.Drawing.Size(341, 240);
            this.serviceDataGridView.TabIndex = 1;
            // 
            // button_Ok
            // 
            this.button_Ok.BackColor = System.Drawing.Color.White;
            this.button_Ok.FlatAppearance.BorderColor = System.Drawing.Color.DeepPink;
            this.button_Ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Ok.Location = new System.Drawing.Point(187, 303);
            this.button_Ok.Name = "button_Ok";
            this.button_Ok.Size = new System.Drawing.Size(168, 35);
            this.button_Ok.TabIndex = 20;
            this.button_Ok.Text = "Ок";
            this.button_Ok.UseVisualStyleBackColor = false;
            this.button_Ok.Click += new System.EventHandler(this.button_Ok_Click);
            // 
            // cosmetology_centerDataSet1
            // 
            this.cosmetology_centerDataSet1.DataSetName = "cosmetology_centerDataSet1";
            this.cosmetology_centerDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // serviceBindingSource
            // 
            this.serviceBindingSource.DataMember = "Service";
            this.serviceBindingSource.DataSource = this.cosmetology_centerDataSet1;
            // 
            // serviceTableAdapter
            // 
            this.serviceTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.ClientTableAdapter = null;
            this.tableAdapterManager1.ElixirTableAdapter = null;
            this.tableAdapterManager1.MasterTableAdapter = null;
            this.tableAdapterManager1.PreparationTableAdapter = null;
            this.tableAdapterManager1.ProcedureTableAdapter = null;
            this.tableAdapterManager1.ResponseTableAdapter = null;
            this.tableAdapterManager1.ServiceTableAdapter = this.serviceTableAdapter;
            this.tableAdapterManager1.UpdateOrder = Cosmetology.cosmetology_centerDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.VisitingTableAdapter = null;
            // 
            // послугаToolStripMenuItem
            // 
            this.послугаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.додатиToolStripMenuItem,
            this.оновитиToolStripMenuItem,
            this.видалитиToolStripMenuItem});
            this.послугаToolStripMenuItem.Name = "послугаToolStripMenuItem";
            this.послугаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.послугаToolStripMenuItem.Text = "Послуга";
            // 
            // додатиToolStripMenuItem
            // 
            this.додатиToolStripMenuItem.Name = "додатиToolStripMenuItem";
            this.додатиToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.додатиToolStripMenuItem.Text = "Додати";
            this.додатиToolStripMenuItem.Click += new System.EventHandler(this.додатиToolStripMenuItem_Click);
            // 
            // оновитиToolStripMenuItem
            // 
            this.оновитиToolStripMenuItem.Name = "оновитиToolStripMenuItem";
            this.оновитиToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.оновитиToolStripMenuItem.Text = "Оновити";
            this.оновитиToolStripMenuItem.Click += new System.EventHandler(this.оновитиToolStripMenuItem_Click);
            // 
            // видалитиToolStripMenuItem
            // 
            this.видалитиToolStripMenuItem.Name = "видалитиToolStripMenuItem";
            this.видалитиToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.видалитиToolStripMenuItem.Text = "Видалити";
            this.видалитиToolStripMenuItem.Click += new System.EventHandler(this.видалитиToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.MistyRose;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.послугаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(484, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.MistyRose;
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.Right;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.назваToolStripMenuItem,
            this.цінаToolStripMenuItem,
            this.тривалістьToolStripMenuItem,
            this.типШкіриToolStripMenuItem,
            this.номерПроцедуриToolStripMenuItem,
            this.коштовністьToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(358, 24);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(126, 337);
            this.menuStrip2.TabIndex = 21;
            this.menuStrip2.Text = "menuStrip2";
            this.menuStrip2.Visible = false;
            // 
            // назваToolStripMenuItem
            // 
            this.назваToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.назваToolStripMenuItem.Name = "назваToolStripMenuItem";
            this.назваToolStripMenuItem.Size = new System.Drawing.Size(113, 19);
            this.назваToolStripMenuItem.Text = "Номер послуги";
            this.назваToolStripMenuItem.Click += new System.EventHandler(this.назваToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem2.Text = "↓";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // цінаToolStripMenuItem
            // 
            this.цінаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3});
            this.цінаToolStripMenuItem.Name = "цінаToolStripMenuItem";
            this.цінаToolStripMenuItem.Size = new System.Drawing.Size(113, 19);
            this.цінаToolStripMenuItem.Text = "Номер процедури";
            this.цінаToolStripMenuItem.Click += new System.EventHandler(this.цінаToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem3.Text = "↓";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // тривалістьToolStripMenuItem
            // 
            this.тривалістьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem4});
            this.тривалістьToolStripMenuItem.Name = "тривалістьToolStripMenuItem";
            this.тривалістьToolStripMenuItem.Size = new System.Drawing.Size(113, 19);
            this.тривалістьToolStripMenuItem.Text = "Назва процедури";
            this.тривалістьToolStripMenuItem.Click += new System.EventHandler(this.тривалістьToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem4.Text = "↓";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // типШкіриToolStripMenuItem
            // 
            this.типШкіриToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem5});
            this.типШкіриToolStripMenuItem.Name = "типШкіриToolStripMenuItem";
            this.типШкіриToolStripMenuItem.Size = new System.Drawing.Size(113, 19);
            this.типШкіриToolStripMenuItem.Text = "Номер майстра";
            this.типШкіриToolStripMenuItem.Click += new System.EventHandler(this.типШкіриToolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem5.Text = "↓";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // номерПроцедуриToolStripMenuItem
            // 
            this.номерПроцедуриToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem6});
            this.номерПроцедуриToolStripMenuItem.Name = "номерПроцедуриToolStripMenuItem";
            this.номерПроцедуриToolStripMenuItem.Size = new System.Drawing.Size(113, 19);
            this.номерПроцедуриToolStripMenuItem.Text = "ПІБ майстра";
            this.номерПроцедуриToolStripMenuItem.Click += new System.EventHandler(this.номерПроцедуриToolStripMenuItem_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem6.Text = "↓";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.MistyRose;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripTextBox2,
            this.toolStripLabel2,
            this.toolStripTextBox3});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(484, 19);
            this.toolStrip1.TabIndex = 22;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.Visible = false;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(42, 15);
            this.toolStripLabel1.Text = "Назва:";
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.toolStripTextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(80, 16);
            this.toolStripTextBox2.TextChanged += new System.EventHandler(this.toolStripTextBox2_TextChanged);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(58, 15);
            this.toolStripLabel2.Text = "Майстер:";
            // 
            // toolStripTextBox3
            // 
            this.toolStripTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.toolStripTextBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox3.Name = "toolStripTextBox3";
            this.toolStripTextBox3.Size = new System.Drawing.Size(80, 16);
            this.toolStripTextBox3.TextChanged += new System.EventHandler(this.toolStripTextBox3_TextChanged);
            // 
            // коштовністьToolStripMenuItem
            // 
            this.коштовністьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem7});
            this.коштовністьToolStripMenuItem.Name = "коштовністьToolStripMenuItem";
            this.коштовністьToolStripMenuItem.Size = new System.Drawing.Size(113, 19);
            this.коштовністьToolStripMenuItem.Text = "Коштовність";
            this.коштовністьToolStripMenuItem.Click += new System.EventHandler(this.коштовністьToolStripMenuItem_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem7.Text = "↓";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.toolStripMenuItem7_Click);
            // 
            // InterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.button_Ok);
            this.Controls.Add(this.serviceDataGridView);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 400);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "InterForm";
            this.Text = "Cosmeyology";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InterForm_FormClosing);
            this.Load += new System.EventHandler(this.InterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.serviceDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cosmetology_centerDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView serviceDataGridView;
        private System.Windows.Forms.Button button_Ok;
        private cosmetology_centerDataSet1 cosmetology_centerDataSet1;
        private System.Windows.Forms.BindingSource serviceBindingSource;
        private cosmetology_centerDataSet1TableAdapters.ServiceTableAdapter serviceTableAdapter;
        private cosmetology_centerDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.ToolStripMenuItem послугаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem додатиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оновитиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видалитиToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem назваToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem цінаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem тривалістьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem типШкіриToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem номерПроцедуриToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox3;
        private System.Windows.Forms.ToolStripMenuItem коштовністьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
    }
}