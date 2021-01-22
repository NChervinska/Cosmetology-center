namespace Cosmetology
{
    partial class MasterForm
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
            System.Windows.Forms.Label статьLabel;
            System.Windows.Forms.Label адресаLabel;
            System.Windows.Forms.Label номер_телефонуLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MasterForm));
            this.номер_телефонуTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.статьComboBox = new System.Windows.Forms.ComboBox();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_Ok = new System.Windows.Forms.Button();
            this.пІБTextBox = new System.Windows.Forms.TextBox();
            this.адресаTextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cosmetology_centerDataSet1 = new Cosmetology.cosmetology_centerDataSet1();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.masterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.masterTableAdapter = new Cosmetology.cosmetology_centerDataSet1TableAdapters.MasterTableAdapter();
            пІБLabel = new System.Windows.Forms.Label();
            статьLabel = new System.Windows.Forms.Label();
            адресаLabel = new System.Windows.Forms.Label();
            номер_телефонуLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cosmetology_centerDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // пІБLabel
            // 
            пІБLabel.AutoSize = true;
            пІБLabel.Location = new System.Drawing.Point(64, 68);
            пІБLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            пІБLabel.Name = "пІБLabel";
            пІБLabel.Size = new System.Drawing.Size(34, 17);
            пІБLabel.TabIndex = 25;
            пІБLabel.Text = "ПІБ:";
            // 
            // статьLabel
            // 
            статьLabel.AutoSize = true;
            статьLabel.Location = new System.Drawing.Point(64, 99);
            статьLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            статьLabel.Name = "статьLabel";
            статьLabel.Size = new System.Drawing.Size(50, 17);
            статьLabel.TabIndex = 28;
            статьLabel.Text = "Стать:";
            // 
            // адресаLabel
            // 
            адресаLabel.AutoSize = true;
            адресаLabel.Location = new System.Drawing.Point(64, 131);
            адресаLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            адресаLabel.Name = "адресаLabel";
            адресаLabel.Size = new System.Drawing.Size(60, 17);
            адресаLabel.TabIndex = 29;
            адресаLabel.Text = "Адреса:";
            // 
            // номер_телефонуLabel
            // 
            номер_телефонуLabel.AutoSize = true;
            номер_телефонуLabel.Location = new System.Drawing.Point(63, 167);
            номер_телефонуLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            номер_телефонуLabel.Name = "номер_телефонуLabel";
            номер_телефонуLabel.Size = new System.Drawing.Size(124, 17);
            номер_телефонуLabel.TabIndex = 34;
            номер_телефонуLabel.Text = "Номер телефону:";
            // 
            // номер_телефонуTextBox
            // 
            this.номер_телефонуTextBox.Location = new System.Drawing.Point(243, 161);
            this.номер_телефонуTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.номер_телефонуTextBox.Name = "номер_телефонуTextBox";
            this.номер_телефонуTextBox.Size = new System.Drawing.Size(156, 23);
            this.номер_телефонуTextBox.TabIndex = 35;
            this.номер_телефонуTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.номер_телефонуTextBox_KeyPress);
            this.номер_телефонуTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.номер_телефонуTextBox_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(198, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 22);
            this.label1.TabIndex = 41;
            this.label1.Text = "+380";
            // 
            // статьComboBox
            // 
            this.статьComboBox.FormattingEnabled = true;
            this.статьComboBox.Items.AddRange(new object[] {
            "ж",
            "м"});
            this.статьComboBox.Location = new System.Drawing.Point(199, 96);
            this.статьComboBox.Name = "статьComboBox";
            this.статьComboBox.Size = new System.Drawing.Size(53, 24);
            this.статьComboBox.TabIndex = 39;
            // 
            // button_Cancel
            // 
            this.button_Cancel.BackColor = System.Drawing.Color.White;
            this.button_Cancel.FlatAppearance.BorderColor = System.Drawing.Color.DeepPink;
            this.button_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Cancel.Location = new System.Drawing.Point(268, 249);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(168, 35);
            this.button_Cancel.TabIndex = 37;
            this.button_Cancel.Text = "Відміна";
            this.button_Cancel.UseVisualStyleBackColor = false;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // button_Ok
            // 
            this.button_Ok.BackColor = System.Drawing.Color.White;
            this.button_Ok.FlatAppearance.BorderColor = System.Drawing.Color.DeepPink;
            this.button_Ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Ok.Location = new System.Drawing.Point(41, 249);
            this.button_Ok.Name = "button_Ok";
            this.button_Ok.Size = new System.Drawing.Size(168, 35);
            this.button_Ok.TabIndex = 36;
            this.button_Ok.Text = "Ок";
            this.button_Ok.UseVisualStyleBackColor = false;
            this.button_Ok.Click += new System.EventHandler(this.button_Ok_Click);
            // 
            // пІБTextBox
            // 
            this.пІБTextBox.Location = new System.Drawing.Point(199, 64);
            this.пІБTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.пІБTextBox.Name = "пІБTextBox";
            this.пІБTextBox.Size = new System.Drawing.Size(200, 23);
            this.пІБTextBox.TabIndex = 26;
            this.пІБTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.пІБTextBox_KeyPress);
            this.пІБTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.пІБTextBox_Validating);
            // 
            // адресаTextBox
            // 
            this.адресаTextBox.Location = new System.Drawing.Point(199, 127);
            this.адресаTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.адресаTextBox.Name = "адресаTextBox";
            this.адресаTextBox.Size = new System.Drawing.Size(200, 23);
            this.адресаTextBox.TabIndex = 30;
            this.адресаTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.адресаTextBox_Validating);
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
            this.bindingSource2.DataSource = this.masterBindingSource;
            // 
            // masterBindingSource
            // 
            this.masterBindingSource.DataMember = "Master";
            this.masterBindingSource.DataSource = this.bindingSource1;
            // 
            // masterTableAdapter
            // 
            this.masterTableAdapter.ClearBeforeFill = true;
            // 
            // MasterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.номер_телефонуTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.статьComboBox);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Ok);
            this.Controls.Add(пІБLabel);
            this.Controls.Add(this.пІБTextBox);
            this.Controls.Add(статьLabel);
            this.Controls.Add(адресаLabel);
            this.Controls.Add(this.адресаTextBox);
            this.Controls.Add(номер_телефонуLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 400);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "MasterForm";
            this.Text = "Cosmetology";
            this.Load += new System.EventHandler(this.MasterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cosmetology_centerDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox номер_телефонуTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox статьComboBox;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_Ok;
        private System.Windows.Forms.TextBox пІБTextBox;
        private System.Windows.Forms.TextBox адресаTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private cosmetology_centerDataSet1 cosmetology_centerDataSet1;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.BindingSource masterBindingSource;
        private cosmetology_centerDataSet1TableAdapters.MasterTableAdapter masterTableAdapter;
    }
}