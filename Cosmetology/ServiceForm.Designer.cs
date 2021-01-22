namespace Cosmetology
{
    partial class ServiceForm
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
            System.Windows.Forms.Label ___майструLabel;
            System.Windows.Forms.Label ___процедуриLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiceForm));
            this.___майструComboBox = new System.Windows.Forms.ComboBox();
            this.masterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cosmetology_centerDataSet1 = new Cosmetology.cosmetology_centerDataSet1();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_Ok = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.procedureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.visitingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.visitingTableAdapter = new Cosmetology.cosmetology_centerDataSet1TableAdapters.VisitingTableAdapter();
            this.masterTableAdapter = new Cosmetology.cosmetology_centerDataSet1TableAdapters.MasterTableAdapter();
            this.procedureTableAdapter = new Cosmetology.cosmetology_centerDataSet1TableAdapters.ProcedureTableAdapter();
            this.serviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serviceTableAdapter = new Cosmetology.cosmetology_centerDataSet1TableAdapters.ServiceTableAdapter();
            this.tableAdapterManager1 = new Cosmetology.cosmetology_centerDataSet1TableAdapters.TableAdapterManager();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ___майструLabel = new System.Windows.Forms.Label();
            ___процедуриLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.masterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cosmetology_centerDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.procedureBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ___майструLabel
            // 
            ___майструLabel.AutoSize = true;
            ___майструLabel.Location = new System.Drawing.Point(165, 98);
            ___майструLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            ___майструLabel.Name = "___майструLabel";
            ___майструLabel.Size = new System.Drawing.Size(69, 17);
            ___майструLabel.TabIndex = 3;
            ___майструLabel.Text = "Майстер:";
            // 
            // ___процедуриLabel
            // 
            ___процедуриLabel.AutoSize = true;
            ___процедуриLabel.Location = new System.Drawing.Point(165, 156);
            ___процедуриLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            ___процедуриLabel.Name = "___процедуриLabel";
            ___процедуриLabel.Size = new System.Drawing.Size(85, 17);
            ___процедуриLabel.TabIndex = 7;
            ___процедуриLabel.Text = "Процедура:";
            // 
            // ___майструComboBox
            // 
            this.___майструComboBox.DataSource = this.masterBindingSource;
            this.___майструComboBox.DisplayMember = "ПІБ";
            this.___майструComboBox.FormattingEnabled = true;
            this.___майструComboBox.Location = new System.Drawing.Point(300, 88);
            this.___майструComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.___майструComboBox.Name = "___майструComboBox";
            this.___майструComboBox.Size = new System.Drawing.Size(156, 24);
            this.___майструComboBox.TabIndex = 4;
            this.___майструComboBox.ValueMember = "Номер майстра";
            // 
            // masterBindingSource
            // 
            this.masterBindingSource.DataMember = "Master";
            this.masterBindingSource.DataSource = this.bindingSource1;
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
            // button_Cancel
            // 
            this.button_Cancel.BackColor = System.Drawing.Color.White;
            this.button_Cancel.FlatAppearance.BorderColor = System.Drawing.Color.DeepPink;
            this.button_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Cancel.Location = new System.Drawing.Point(288, 274);
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
            this.button_Ok.Location = new System.Drawing.Point(70, 274);
            this.button_Ok.Name = "button_Ok";
            this.button_Ok.Size = new System.Drawing.Size(168, 35);
            this.button_Ok.TabIndex = 18;
            this.button_Ok.Text = "Ок";
            this.button_Ok.UseVisualStyleBackColor = false;
            this.button_Ok.Click += new System.EventHandler(this.button_Ok_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.procedureBindingSource;
            this.comboBox1.DisplayMember = "Назва";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(300, 149);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(156, 24);
            this.comboBox1.TabIndex = 20;
            this.comboBox1.ValueMember = "Номер процедури";
            // 
            // procedureBindingSource
            // 
            this.procedureBindingSource.DataMember = "Procedure";
            this.procedureBindingSource.DataSource = this.bindingSource1;
            // 
            // visitingBindingSource
            // 
            this.visitingBindingSource.DataMember = "Visiting";
            this.visitingBindingSource.DataSource = this.bindingSource1;
            // 
            // visitingTableAdapter
            // 
            this.visitingTableAdapter.ClearBeforeFill = true;
            // 
            // masterTableAdapter
            // 
            this.masterTableAdapter.ClearBeforeFill = true;
            // 
            // procedureTableAdapter
            // 
            this.procedureTableAdapter.ClearBeforeFill = true;
            // 
            // serviceBindingSource
            // 
            this.serviceBindingSource.DataMember = "Service";
            this.serviceBindingSource.DataSource = this.bindingSource1;
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
            this.tableAdapterManager1.MasterTableAdapter = this.masterTableAdapter;
            this.tableAdapterManager1.PreparationTableAdapter = null;
            this.tableAdapterManager1.ProcedureTableAdapter = this.procedureTableAdapter;
            this.tableAdapterManager1.ResponseTableAdapter = null;
            this.tableAdapterManager1.ServiceTableAdapter = this.serviceTableAdapter;
            this.tableAdapterManager1.UpdateOrder = Cosmetology.cosmetology_centerDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.VisitingTableAdapter = this.visitingTableAdapter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Cosmetology.Properties.Resources._122398;
            this.pictureBox1.Location = new System.Drawing.Point(31, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 147);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // ServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Ok);
            this.Controls.Add(___майструLabel);
            this.Controls.Add(this.___майструComboBox);
            this.Controls.Add(___процедуриLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 400);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "ServiceForm";
            this.Text = "Cosmetology";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ServiceForm_FormClosing);
            this.Load += new System.EventHandler(this.ServiceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.masterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cosmetology_centerDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.procedureBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox ___майструComboBox;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_Ok;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private cosmetology_centerDataSet1 cosmetology_centerDataSet1;
        private System.Windows.Forms.BindingSource visitingBindingSource;
        private cosmetology_centerDataSet1TableAdapters.VisitingTableAdapter visitingTableAdapter;
        private System.Windows.Forms.BindingSource masterBindingSource;
        private cosmetology_centerDataSet1TableAdapters.MasterTableAdapter masterTableAdapter;
        private System.Windows.Forms.BindingSource procedureBindingSource;
        private cosmetology_centerDataSet1TableAdapters.ProcedureTableAdapter procedureTableAdapter;
        private System.Windows.Forms.BindingSource serviceBindingSource;
        private cosmetology_centerDataSet1TableAdapters.ServiceTableAdapter serviceTableAdapter;
        private cosmetology_centerDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}