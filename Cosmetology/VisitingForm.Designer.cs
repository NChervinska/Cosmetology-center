namespace Cosmetology
{
    partial class VisitingForm
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
            System.Windows.Forms.Label ___клієнтуLabel;
            System.Windows.Forms.Label датаLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisitingForm));
            this.___клієнтуComboBox = new System.Windows.Forms.ComboBox();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cosmetology_centerDataSet1 = new Cosmetology.cosmetology_centerDataSet1();
            this.датаDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_Ok = new System.Windows.Forms.Button();
            this.serviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serviceTableAdapter = new Cosmetology.cosmetology_centerDataSet1TableAdapters.ServiceTableAdapter();
            this.clientTableAdapter = new Cosmetology.cosmetology_centerDataSet1TableAdapters.ClientTableAdapter();
            this.visitingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.visitingTableAdapter = new Cosmetology.cosmetology_centerDataSet1TableAdapters.VisitingTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ___клієнтуLabel = new System.Windows.Forms.Label();
            датаLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cosmetology_centerDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ___клієнтуLabel
            // 
            ___клієнтуLabel.AutoSize = true;
            ___клієнтуLabel.Location = new System.Drawing.Point(125, 80);
            ___клієнтуLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            ___клієнтуLabel.Name = "___клієнтуLabel";
            ___клієнтуLabel.Size = new System.Drawing.Size(77, 17);
            ___клієнтуLabel.TabIndex = 1;
            ___клієнтуLabel.Text = "№ клієнту:";
            // 
            // датаLabel
            // 
            датаLabel.AutoSize = true;
            датаLabel.Location = new System.Drawing.Point(125, 161);
            датаLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            датаLabel.Name = "датаLabel";
            датаLabel.Size = new System.Drawing.Size(46, 17);
            датаLabel.TabIndex = 3;
            датаLabel.Text = "Дата:";
            // 
            // ___клієнтуComboBox
            // 
            this.___клієнтуComboBox.DataSource = this.clientBindingSource;
            this.___клієнтуComboBox.DisplayMember = "ПІБ";
            this.___клієнтуComboBox.FormattingEnabled = true;
            this.___клієнтуComboBox.Location = new System.Drawing.Point(238, 76);
            this.___клієнтуComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.___клієнтуComboBox.Name = "___клієнтуComboBox";
            this.___клієнтуComboBox.Size = new System.Drawing.Size(233, 24);
            this.___клієнтуComboBox.TabIndex = 2;
            this.___клієнтуComboBox.ValueMember = "Номер клієнту";
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.BindingSource1;
            // 
            // BindingSource1
            // 
            this.BindingSource1.DataSource = this.cosmetology_centerDataSet1;
            this.BindingSource1.Position = 0;
            // 
            // cosmetology_centerDataSet1
            // 
            this.cosmetology_centerDataSet1.DataSetName = "cosmetology_centerDataSet1";
            this.cosmetology_centerDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // датаDateTimePicker
            // 
            this.датаDateTimePicker.Location = new System.Drawing.Point(238, 155);
            this.датаDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.датаDateTimePicker.Name = "датаDateTimePicker";
            this.датаDateTimePicker.Size = new System.Drawing.Size(233, 23);
            this.датаDateTimePicker.TabIndex = 4;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(349, 104);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(122, 17);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Зареєструватися";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // button_Cancel
            // 
            this.button_Cancel.BackColor = System.Drawing.Color.White;
            this.button_Cancel.FlatAppearance.BorderColor = System.Drawing.Color.DeepPink;
            this.button_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Cancel.Location = new System.Drawing.Point(278, 271);
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
            this.button_Ok.Location = new System.Drawing.Point(46, 271);
            this.button_Ok.Name = "button_Ok";
            this.button_Ok.Size = new System.Drawing.Size(168, 35);
            this.button_Ok.TabIndex = 18;
            this.button_Ok.Text = "Ок";
            this.button_Ok.UseVisualStyleBackColor = false;
            this.button_Ok.Click += new System.EventHandler(this.button_Ok_Click);
            // 
            // serviceBindingSource
            // 
            this.serviceBindingSource.DataMember = "Service";
            this.serviceBindingSource.DataSource = this.BindingSource1;
            // 
            // serviceTableAdapter
            // 
            this.serviceTableAdapter.ClearBeforeFill = true;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // visitingBindingSource
            // 
            this.visitingBindingSource.DataMember = "Visiting";
            this.visitingBindingSource.DataSource = this.cosmetology_centerDataSet1;
            // 
            // visitingTableAdapter
            // 
            this.visitingTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Cosmetology.Properties.Resources._120701;
            this.pictureBox1.Location = new System.Drawing.Point(34, 104);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // VisitingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Ok);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(___клієнтуLabel);
            this.Controls.Add(this.___клієнтуComboBox);
            this.Controls.Add(датаLabel);
            this.Controls.Add(this.датаDateTimePicker);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 400);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "VisitingForm";
            this.Text = "Cosmetology";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VisitingForm_FormClosing);
            this.Load += new System.EventHandler(this.VisitingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cosmetology_centerDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox ___клієнтуComboBox;
        private System.Windows.Forms.DateTimePicker датаDateTimePicker;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_Ok;
        private System.Windows.Forms.BindingSource BindingSource1;
        private cosmetology_centerDataSet1 cosmetology_centerDataSet1;
        private System.Windows.Forms.BindingSource serviceBindingSource;
        private cosmetology_centerDataSet1TableAdapters.ServiceTableAdapter serviceTableAdapter;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private cosmetology_centerDataSet1TableAdapters.ClientTableAdapter clientTableAdapter;
        private System.Windows.Forms.BindingSource visitingBindingSource;
        private cosmetology_centerDataSet1TableAdapters.VisitingTableAdapter visitingTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}