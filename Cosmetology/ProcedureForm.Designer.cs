namespace Cosmetology
{
    partial class ProcedureForm
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
            System.Windows.Forms.Label цінаLabel;
            System.Windows.Forms.Label тривалістьLabel;
            System.Windows.Forms.Label тип_шкіриLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProcedureForm));
            this.назваTextBox = new System.Windows.Forms.TextBox();
            this.цінаTextBox = new System.Windows.Forms.TextBox();
            this.тривалістьTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_Ok = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cosmetology_centerDataSet1 = new Cosmetology.cosmetology_centerDataSet1();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.procedureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.procedureTableAdapter = new Cosmetology.cosmetology_centerDataSet1TableAdapters.ProcedureTableAdapter();
            назваLabel = new System.Windows.Forms.Label();
            цінаLabel = new System.Windows.Forms.Label();
            тривалістьLabel = new System.Windows.Forms.Label();
            тип_шкіриLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cosmetology_centerDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.procedureBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // назваLabel
            // 
            назваLabel.AutoSize = true;
            назваLabel.Location = new System.Drawing.Point(88, 75);
            назваLabel.Name = "назваLabel";
            назваLabel.Size = new System.Drawing.Size(52, 17);
            назваLabel.TabIndex = 1;
            назваLabel.Text = "Назва:";
            // 
            // цінаLabel
            // 
            цінаLabel.AutoSize = true;
            цінаLabel.Location = new System.Drawing.Point(88, 137);
            цінаLabel.Name = "цінаLabel";
            цінаLabel.Size = new System.Drawing.Size(42, 17);
            цінаLabel.TabIndex = 7;
            цінаLabel.Text = "Ціна:";
            // 
            // тривалістьLabel
            // 
            тривалістьLabel.AutoSize = true;
            тривалістьLabel.Location = new System.Drawing.Point(88, 166);
            тривалістьLabel.Name = "тривалістьLabel";
            тривалістьLabel.Size = new System.Drawing.Size(84, 17);
            тривалістьLabel.TabIndex = 9;
            тривалістьLabel.Text = "Тривалість:";
            // 
            // тип_шкіриLabel
            // 
            тип_шкіриLabel.AutoSize = true;
            тип_шкіриLabel.Location = new System.Drawing.Point(88, 104);
            тип_шкіриLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            тип_шкіриLabel.Name = "тип_шкіриLabel";
            тип_шкіриLabel.Size = new System.Drawing.Size(78, 17);
            тип_шкіриLabel.TabIndex = 24;
            тип_шкіриLabel.Text = "Тип шкіри:";
            // 
            // назваTextBox
            // 
            this.назваTextBox.Location = new System.Drawing.Point(195, 72);
            this.назваTextBox.Name = "назваTextBox";
            this.назваTextBox.Size = new System.Drawing.Size(200, 23);
            this.назваTextBox.TabIndex = 2;
            this.назваTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.назваTextBox_KeyPress);
            this.назваTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.назваTextBox_Validating);
            // 
            // цінаTextBox
            // 
            this.цінаTextBox.Location = new System.Drawing.Point(195, 134);
            this.цінаTextBox.Name = "цінаTextBox";
            this.цінаTextBox.Size = new System.Drawing.Size(200, 23);
            this.цінаTextBox.TabIndex = 8;
            this.цінаTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.цінаTextBox_KeyPress);
            this.цінаTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.цінаTextBox_Validating);
            // 
            // тривалістьTextBox
            // 
            this.тривалістьTextBox.Location = new System.Drawing.Point(195, 163);
            this.тривалістьTextBox.Name = "тривалістьTextBox";
            this.тривалістьTextBox.Size = new System.Drawing.Size(200, 23);
            this.тривалістьTextBox.TabIndex = 10;
            this.тривалістьTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.тривалістьTextBox_KeyPress);
            this.тривалістьTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.тривалістьTextBox_Validating);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Нормальна шкіра",
            "Суха шкіра",
            "Жирна шкіра",
            "Комбінована шкіра",
            "Чутлива шкіра"});
            this.comboBox1.Location = new System.Drawing.Point(195, 101);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 24);
            this.comboBox1.TabIndex = 25;
            // 
            // button_Cancel
            // 
            this.button_Cancel.BackColor = System.Drawing.Color.White;
            this.button_Cancel.FlatAppearance.BorderColor = System.Drawing.Color.DeepPink;
            this.button_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Cancel.Location = new System.Drawing.Point(272, 253);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(168, 35);
            this.button_Cancel.TabIndex = 27;
            this.button_Cancel.Text = "Відміна";
            this.button_Cancel.UseVisualStyleBackColor = false;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // button_Ok
            // 
            this.button_Ok.BackColor = System.Drawing.Color.White;
            this.button_Ok.FlatAppearance.BorderColor = System.Drawing.Color.DeepPink;
            this.button_Ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Ok.Location = new System.Drawing.Point(45, 253);
            this.button_Ok.Name = "button_Ok";
            this.button_Ok.Size = new System.Drawing.Size(168, 35);
            this.button_Ok.TabIndex = 26;
            this.button_Ok.Text = "Ок";
            this.button_Ok.UseVisualStyleBackColor = false;
            this.button_Ok.Click += new System.EventHandler(this.button_Ok_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.cosmetology_centerDataSet1;
            this.bindingSource1.Position = 0;
            // 
            // cosmetology_centerDataSet1
            // 
            this.cosmetology_centerDataSet1.DataSetName = "cosmetology_centerDataSet1";
            this.cosmetology_centerDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSource2
            // 
            this.bindingSource2.DataSource = this.procedureBindingSource;
            // 
            // procedureBindingSource
            // 
            this.procedureBindingSource.DataMember = "Procedure";
            this.procedureBindingSource.DataSource = this.bindingSource1;
            // 
            // procedureTableAdapter
            // 
            this.procedureTableAdapter.ClearBeforeFill = true;
            // 
            // ProcedureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Ok);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(тип_шкіриLabel);
            this.Controls.Add(назваLabel);
            this.Controls.Add(this.назваTextBox);
            this.Controls.Add(цінаLabel);
            this.Controls.Add(this.цінаTextBox);
            this.Controls.Add(тривалістьLabel);
            this.Controls.Add(this.тривалістьTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 400);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "ProcedureForm";
            this.Text = "Cosmetology";
            this.Load += new System.EventHandler(this.ProcedureForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cosmetology_centerDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.procedureBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox назваTextBox;
        private System.Windows.Forms.TextBox цінаTextBox;
        private System.Windows.Forms.TextBox тривалістьTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_Ok;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private cosmetology_centerDataSet1 cosmetology_centerDataSet1;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.BindingSource procedureBindingSource;
        private cosmetology_centerDataSet1TableAdapters.ProcedureTableAdapter procedureTableAdapter;
    }
}