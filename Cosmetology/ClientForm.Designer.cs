namespace Cosmetology
{
    partial class ClientForm
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
            System.Windows.Forms.Label пІБLabel;
            System.Windows.Forms.Label рік_народженняLabel;
            System.Windows.Forms.Label статьLabel;
            System.Windows.Forms.Label адресаLabel;
            System.Windows.Forms.Label тип_шкіриLabel;
            System.Windows.Forms.Label ціль_приходуLabel;
            System.Windows.Forms.Label номер_телефонуLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientForm));
            this.пІБTextBox = new System.Windows.Forms.TextBox();
            this.адресаTextBox = new System.Windows.Forms.TextBox();
            this.ціль_приходуTextBox = new System.Windows.Forms.TextBox();
            this.номер_телефонуTextBox = new System.Windows.Forms.TextBox();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_Ok = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.статьComboBox = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cosmetology_centerDataSet1 = new Cosmetology.cosmetology_centerDataSet1();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableAdapter = new Cosmetology.cosmetology_centerDataSet1TableAdapters.ClientTableAdapter();
            пІБLabel = new System.Windows.Forms.Label();
            рік_народженняLabel = new System.Windows.Forms.Label();
            статьLabel = new System.Windows.Forms.Label();
            адресаLabel = new System.Windows.Forms.Label();
            тип_шкіриLabel = new System.Windows.Forms.Label();
            ціль_приходуLabel = new System.Windows.Forms.Label();
            номер_телефонуLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cosmetology_centerDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // пІБLabel
            // 
            пІБLabel.AutoSize = true;
            пІБLabel.Location = new System.Drawing.Point(64, 27);
            пІБLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            пІБLabel.Name = "пІБLabel";
            пІБLabel.Size = new System.Drawing.Size(34, 17);
            пІБLabel.TabIndex = 1;
            пІБLabel.Text = "ПІБ:";
            // 
            // рік_народженняLabel
            // 
            рік_народженняLabel.AutoSize = true;
            рік_народженняLabel.Location = new System.Drawing.Point(64, 59);
            рік_народженняLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            рік_народженняLabel.Name = "рік_народженняLabel";
            рік_народженняLabel.Size = new System.Drawing.Size(116, 17);
            рік_народженняLabel.TabIndex = 3;
            рік_народженняLabel.Text = "Рік народження:";
            // 
            // статьLabel
            // 
            статьLabel.AutoSize = true;
            статьLabel.Location = new System.Drawing.Point(64, 91);
            статьLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            статьLabel.Name = "статьLabel";
            статьLabel.Size = new System.Drawing.Size(50, 17);
            статьLabel.TabIndex = 5;
            статьLabel.Text = "Стать:";
            // 
            // адресаLabel
            // 
            адресаLabel.AutoSize = true;
            адресаLabel.Location = new System.Drawing.Point(64, 123);
            адресаLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            адресаLabel.Name = "адресаLabel";
            адресаLabel.Size = new System.Drawing.Size(60, 17);
            адресаLabel.TabIndex = 7;
            адресаLabel.Text = "Адреса:";
            // 
            // тип_шкіриLabel
            // 
            тип_шкіриLabel.AutoSize = true;
            тип_шкіриLabel.Location = new System.Drawing.Point(64, 155);
            тип_шкіриLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            тип_шкіриLabel.Name = "тип_шкіриLabel";
            тип_шкіриLabel.Size = new System.Drawing.Size(78, 17);
            тип_шкіриLabel.TabIndex = 9;
            тип_шкіриLabel.Text = "Тип шкіри:";
            // 
            // ціль_приходуLabel
            // 
            ціль_приходуLabel.AutoSize = true;
            ціль_приходуLabel.Location = new System.Drawing.Point(64, 187);
            ціль_приходуLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            ціль_приходуLabel.Name = "ціль_приходуLabel";
            ціль_приходуLabel.Size = new System.Drawing.Size(98, 17);
            ціль_приходуLabel.TabIndex = 11;
            ціль_приходуLabel.Text = "Ціль приходу:";
            // 
            // номер_телефонуLabel
            // 
            номер_телефонуLabel.AutoSize = true;
            номер_телефонуLabel.Location = new System.Drawing.Point(64, 219);
            номер_телефонуLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            номер_телефонуLabel.Name = "номер_телефонуLabel";
            номер_телефонуLabel.Size = new System.Drawing.Size(124, 17);
            номер_телефонуLabel.TabIndex = 13;
            номер_телефонуLabel.Text = "Номер телефону:";
            // 
            // пІБTextBox
            // 
            this.пІБTextBox.Location = new System.Drawing.Point(199, 23);
            this.пІБTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.пІБTextBox.Name = "пІБTextBox";
            this.пІБTextBox.Size = new System.Drawing.Size(200, 23);
            this.пІБTextBox.TabIndex = 2;
            this.пІБTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.пІБTextBox_KeyPress);
            this.пІБTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.пІБTextBox_Validating);
            // 
            // адресаTextBox
            // 
            this.адресаTextBox.Location = new System.Drawing.Point(199, 119);
            this.адресаTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.адресаTextBox.Name = "адресаTextBox";
            this.адресаTextBox.Size = new System.Drawing.Size(200, 23);
            this.адресаTextBox.TabIndex = 8;
            this.адресаTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.адресаTextBox_Validating);
            // 
            // ціль_приходуTextBox
            // 
            this.ціль_приходуTextBox.Location = new System.Drawing.Point(199, 183);
            this.ціль_приходуTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ціль_приходуTextBox.Name = "ціль_приходуTextBox";
            this.ціль_приходуTextBox.Size = new System.Drawing.Size(200, 23);
            this.ціль_приходуTextBox.TabIndex = 12;
            // 
            // номер_телефонуTextBox
            // 
            this.номер_телефонуTextBox.Location = new System.Drawing.Point(244, 213);
            this.номер_телефонуTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.номер_телефонуTextBox.Name = "номер_телефонуTextBox";
            this.номер_телефонуTextBox.Size = new System.Drawing.Size(155, 23);
            this.номер_телефонуTextBox.TabIndex = 14;
            this.номер_телефонуTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.номер_телефонуTextBox_KeyPress);
            this.номер_телефонуTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.номер_телефонуTextBox_Validating);
            // 
            // button_Cancel
            // 
            this.button_Cancel.BackColor = System.Drawing.Color.White;
            this.button_Cancel.FlatAppearance.BorderColor = System.Drawing.Color.DeepPink;
            this.button_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Cancel.Location = new System.Drawing.Point(269, 301);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(168, 35);
            this.button_Cancel.TabIndex = 19;
            this.button_Cancel.Text = "Відміна";
            this.button_Cancel.UseVisualStyleBackColor = false;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // button_Ok
            // 
            this.button_Ok.BackColor = System.Drawing.Color.White;
            this.button_Ok.FlatAppearance.BorderColor = System.Drawing.Color.DeepPink;
            this.button_Ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Ok.Location = new System.Drawing.Point(42, 301);
            this.button_Ok.Name = "button_Ok";
            this.button_Ok.Size = new System.Drawing.Size(168, 35);
            this.button_Ok.TabIndex = 18;
            this.button_Ok.Text = "Ок";
            this.button_Ok.UseVisualStyleBackColor = false;
            this.button_Ok.Click += new System.EventHandler(this.button_Ok_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.AccessibleRole = System.Windows.Forms.AccessibleRole.ListItem;
            this.numericUpDown1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.numericUpDown1.Location = new System.Drawing.Point(199, 57);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            2015,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1945,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(53, 23);
            this.numericUpDown1.TabIndex = 20;
            this.numericUpDown1.Value = new decimal(new int[] {
            1945,
            0,
            0,
            0});
            // 
            // статьComboBox
            // 
            this.статьComboBox.FormattingEnabled = true;
            this.статьComboBox.Items.AddRange(new object[] {
            "ж",
            "м"});
            this.статьComboBox.Location = new System.Drawing.Point(199, 88);
            this.статьComboBox.Name = "статьComboBox";
            this.статьComboBox.Size = new System.Drawing.Size(53, 24);
            this.статьComboBox.TabIndex = 22;
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
            this.comboBox1.Location = new System.Drawing.Point(199, 152);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 24);
            this.comboBox1.TabIndex = 23;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(199, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 22);
            this.label1.TabIndex = 24;
            this.label1.Text = "+380";
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
            this.bindingSource2.DataSource = this.clientBindingSource;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.bindingSource1;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.номер_телефонуTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.статьComboBox);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Ok);
            this.Controls.Add(пІБLabel);
            this.Controls.Add(this.пІБTextBox);
            this.Controls.Add(рік_народженняLabel);
            this.Controls.Add(статьLabel);
            this.Controls.Add(адресаLabel);
            this.Controls.Add(this.адресаTextBox);
            this.Controls.Add(тип_шкіриLabel);
            this.Controls.Add(ціль_приходуLabel);
            this.Controls.Add(this.ціль_приходуTextBox);
            this.Controls.Add(номер_телефонуLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 400);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "ClientForm";
            this.Text = "Cosmetology";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClientForm_FormClosing);
            this.Load += new System.EventHandler(this.ClientForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cosmetology_centerDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox пІБTextBox;
        private System.Windows.Forms.TextBox адресаTextBox;
        private System.Windows.Forms.TextBox ціль_приходуTextBox;
        private System.Windows.Forms.TextBox номер_телефонуTextBox;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_Ok;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ComboBox статьComboBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private cosmetology_centerDataSet1 cosmetology_centerDataSet1;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private cosmetology_centerDataSet1TableAdapters.ClientTableAdapter clientTableAdapter;
    }
}