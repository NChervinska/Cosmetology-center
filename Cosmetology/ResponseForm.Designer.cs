namespace Cosmetology
{
    partial class ResponseForm
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
            System.Windows.Forms.Label кількість_зірокLabel;
            System.Windows.Forms.Label ___клієнтаLabel;
            System.Windows.Forms.Label ___процедуриLabel;
            System.Windows.Forms.Label коментарійLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResponseForm));
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cosmetology_centerDataSet1 = new Cosmetology.cosmetology_centerDataSet1();
            this.comboBox_Procedure = new System.Windows.Forms.ComboBox();
            this.procedureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_Ok = new System.Windows.Forms.Button();
            this.коментарійtextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.responseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableAdapter = new Cosmetology.cosmetology_centerDataSet1TableAdapters.ClientTableAdapter();
            this.procedureTableAdapter = new Cosmetology.cosmetology_centerDataSet1TableAdapters.ProcedureTableAdapter();
            this.responseTableAdapter = new Cosmetology.cosmetology_centerDataSet1TableAdapters.ResponseTableAdapter();
            this.tableAdapterManager1 = new Cosmetology.cosmetology_centerDataSet1TableAdapters.TableAdapterManager();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            кількість_зірокLabel = new System.Windows.Forms.Label();
            ___клієнтаLabel = new System.Windows.Forms.Label();
            ___процедуриLabel = new System.Windows.Forms.Label();
            коментарійLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cosmetology_centerDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.procedureBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.responseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // кількість_зірокLabel
            // 
            кількість_зірокLabel.AutoSize = true;
            кількість_зірокLabel.Location = new System.Drawing.Point(55, 62);
            кількість_зірокLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            кількість_зірокLabel.Name = "кількість_зірокLabel";
            кількість_зірокLabel.Size = new System.Drawing.Size(94, 17);
            кількість_зірокLabel.TabIndex = 3;
            кількість_зірокLabel.Text = "Ваша оцінка:";
            // 
            // ___клієнтаLabel
            // 
            ___клієнтаLabel.AutoSize = true;
            ___клієнтаLabel.Location = new System.Drawing.Point(55, 115);
            ___клієнтаLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            ___клієнтаLabel.Name = "___клієнтаLabel";
            ___клієнтаLabel.Size = new System.Drawing.Size(54, 17);
            ___клієнтаLabel.TabIndex = 5;
            ___клієнтаLabel.Text = "Клієнт:";
            // 
            // ___процедуриLabel
            // 
            ___процедуриLabel.AutoSize = true;
            ___процедуриLabel.Location = new System.Drawing.Point(55, 147);
            ___процедуриLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            ___процедуриLabel.Name = "___процедуриLabel";
            ___процедуриLabel.Size = new System.Drawing.Size(85, 17);
            ___процедуриLabel.TabIndex = 7;
            ___процедуриLabel.Text = "Процедура:";
            // 
            // коментарійLabel
            // 
            коментарійLabel.AutoSize = true;
            коментарійLabel.Location = new System.Drawing.Point(55, 186);
            коментарійLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            коментарійLabel.Name = "коментарійLabel";
            коментарійLabel.Size = new System.Drawing.Size(88, 17);
            коментарійLabel.TabIndex = 9;
            коментарійLabel.Text = "Коментарій:";
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.bindingSource1;
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
            // comboBox_Procedure
            // 
            this.comboBox_Procedure.FormattingEnabled = true;
            this.comboBox_Procedure.Location = new System.Drawing.Point(179, 141);
            this.comboBox_Procedure.Name = "comboBox_Procedure";
            this.comboBox_Procedure.Size = new System.Drawing.Size(265, 24);
            this.comboBox_Procedure.TabIndex = 15;
            // 
            // procedureBindingSource
            // 
            this.procedureBindingSource.DataMember = "Procedure";
            this.procedureBindingSource.DataSource = this.bindingSource1;
            // 
            // button_Cancel
            // 
            this.button_Cancel.BackColor = System.Drawing.Color.White;
            this.button_Cancel.FlatAppearance.BorderColor = System.Drawing.Color.DeepPink;
            this.button_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Cancel.Location = new System.Drawing.Point(276, 277);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(168, 35);
            this.button_Cancel.TabIndex = 17;
            this.button_Cancel.Text = "Відміна";
            this.button_Cancel.UseVisualStyleBackColor = false;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // button_Ok
            // 
            this.button_Ok.BackColor = System.Drawing.Color.White;
            this.button_Ok.FlatAppearance.BorderColor = System.Drawing.Color.DeepPink;
            this.button_Ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Ok.Location = new System.Drawing.Point(58, 277);
            this.button_Ok.Name = "button_Ok";
            this.button_Ok.Size = new System.Drawing.Size(168, 35);
            this.button_Ok.TabIndex = 16;
            this.button_Ok.Text = "Ок";
            this.button_Ok.UseVisualStyleBackColor = false;
            this.button_Ok.Click += new System.EventHandler(this.button_Ok_Click);
            // 
            // коментарійtextBox
            // 
            this.коментарійtextBox.Location = new System.Drawing.Point(179, 180);
            this.коментарійtextBox.Multiline = true;
            this.коментарійtextBox.Name = "коментарійtextBox";
            this.коментарійtextBox.Size = new System.Drawing.Size(265, 75);
            this.коментарійtextBox.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Cosmetology.Properties.Resources.star1;
            this.pictureBox1.Location = new System.Drawing.Point(198, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Cosmetology.Properties.Resources.star1;
            this.pictureBox2.Location = new System.Drawing.Point(244, 50);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = global::Cosmetology.Properties.Resources.star1;
            this.pictureBox5.Image = global::Cosmetology.Properties.Resources.star1;
            this.pictureBox5.Location = new System.Drawing.Point(382, 50);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(40, 40);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 22;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::Cosmetology.Properties.Resources.star1;
            this.pictureBox4.Image = global::Cosmetology.Properties.Resources.star1;
            this.pictureBox4.Location = new System.Drawing.Point(336, 50);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(40, 40);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 24;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Cosmetology.Properties.Resources.star1;
            this.pictureBox3.Location = new System.Drawing.Point(290, 50);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 23;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // bindingSource2
            // 
            this.bindingSource2.DataSource = this.responseBindingSource;
            // 
            // responseBindingSource
            // 
            this.responseBindingSource.DataMember = "Response";
            this.responseBindingSource.DataSource = this.bindingSource1;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // procedureTableAdapter
            // 
            this.procedureTableAdapter.ClearBeforeFill = true;
            // 
            // responseTableAdapter
            // 
            this.responseTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.ClientTableAdapter = this.clientTableAdapter;
            this.tableAdapterManager1.ElixirTableAdapter = null;
            this.tableAdapterManager1.MasterTableAdapter = null;
            this.tableAdapterManager1.PreparationTableAdapter = null;
            this.tableAdapterManager1.ProcedureTableAdapter = this.procedureTableAdapter;
            this.tableAdapterManager1.ResponseTableAdapter = this.responseTableAdapter;
            this.tableAdapterManager1.ServiceTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = Cosmetology.cosmetology_centerDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.VisitingTableAdapter = null;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(179, 109);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(265, 23);
            this.textBox1.TabIndex = 25;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.textBox1.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ResponseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.коментарійtextBox);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Ok);
            this.Controls.Add(this.comboBox_Procedure);
            this.Controls.Add(кількість_зірокLabel);
            this.Controls.Add(___клієнтаLabel);
            this.Controls.Add(___процедуриLabel);
            this.Controls.Add(коментарійLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 400);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "ResponseForm";
            this.Text = "Cosmetology";
            this.Load += new System.EventHandler(this.ResponseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cosmetology_centerDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.procedureBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.responseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox_Procedure;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_Ok;
        private System.Windows.Forms.TextBox коментарійtextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.BindingSource bindingSource1;
        private cosmetology_centerDataSet1 cosmetology_centerDataSet1;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private cosmetology_centerDataSet1TableAdapters.ClientTableAdapter clientTableAdapter;
        private System.Windows.Forms.BindingSource procedureBindingSource;
        private cosmetology_centerDataSet1TableAdapters.ProcedureTableAdapter procedureTableAdapter;
        private System.Windows.Forms.BindingSource responseBindingSource;
        private cosmetology_centerDataSet1TableAdapters.ResponseTableAdapter responseTableAdapter;
        private cosmetology_centerDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}