
namespace Cosmetology
{
    partial class ElixirForm
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
            System.Windows.Forms.Label номер_процедуриLabel;
            System.Windows.Forms.Label номер_препаратуLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ElixirForm));
            this.cosmetology_centerDataSet1 = new Cosmetology.cosmetology_centerDataSet1();
            this.elixirBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.elixirTableAdapter = new Cosmetology.cosmetology_centerDataSet1TableAdapters.ElixirTableAdapter();
            this.tableAdapterManager = new Cosmetology.cosmetology_centerDataSet1TableAdapters.TableAdapterManager();
            this.preparationTableAdapter = new Cosmetology.cosmetology_centerDataSet1TableAdapters.PreparationTableAdapter();
            this.procedureTableAdapter = new Cosmetology.cosmetology_centerDataSet1TableAdapters.ProcedureTableAdapter();
            this.номер_процедуриComboBox = new System.Windows.Forms.ComboBox();
            this.procedureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.номер_препаратуComboBox = new System.Windows.Forms.ComboBox();
            this.preparationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_Ok = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            номер_процедуриLabel = new System.Windows.Forms.Label();
            номер_препаратуLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cosmetology_centerDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elixirBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.procedureBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preparationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // номер_процедуриLabel
            // 
            номер_процедуриLabel.AutoSize = true;
            номер_процедуриLabel.Location = new System.Drawing.Point(129, 91);
            номер_процедуриLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            номер_процедуриLabel.Name = "номер_процедуриLabel";
            номер_процедуриLabel.Size = new System.Drawing.Size(130, 17);
            номер_процедуриLabel.TabIndex = 1;
            номер_процедуриLabel.Text = "Номер процедури:";
            // 
            // номер_препаратуLabel
            // 
            номер_препаратуLabel.AutoSize = true;
            номер_препаратуLabel.Location = new System.Drawing.Point(130, 154);
            номер_препаратуLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            номер_препаратуLabel.Name = "номер_препаратуLabel";
            номер_препаратуLabel.Size = new System.Drawing.Size(129, 17);
            номер_препаратуLabel.TabIndex = 3;
            номер_препаратуLabel.Text = "Номер препарату:";
            // 
            // cosmetology_centerDataSet1
            // 
            this.cosmetology_centerDataSet1.DataSetName = "cosmetology_centerDataSet1";
            this.cosmetology_centerDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // elixirBindingSource
            // 
            this.elixirBindingSource.DataMember = "Elixir";
            this.elixirBindingSource.DataSource = this.cosmetology_centerDataSet1;
            // 
            // elixirTableAdapter
            // 
            this.elixirTableAdapter.ClearBeforeFill = true;
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
            // preparationTableAdapter
            // 
            this.preparationTableAdapter.ClearBeforeFill = true;
            // 
            // procedureTableAdapter
            // 
            this.procedureTableAdapter.ClearBeforeFill = true;
            // 
            // номер_процедуриComboBox
            // 
            this.номер_процедуриComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.elixirBindingSource, "Номер процедури", true));
            this.номер_процедуриComboBox.DataSource = this.procedureBindingSource;
            this.номер_процедуриComboBox.DisplayMember = "Назва";
            this.номер_процедуриComboBox.FormattingEnabled = true;
            this.номер_процедуриComboBox.Location = new System.Drawing.Point(270, 87);
            this.номер_процедуриComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.номер_процедуриComboBox.Name = "номер_процедуриComboBox";
            this.номер_процедуриComboBox.Size = new System.Drawing.Size(160, 24);
            this.номер_процедуриComboBox.TabIndex = 2;
            this.номер_процедуриComboBox.ValueMember = "Номер процедури";
            // 
            // procedureBindingSource
            // 
            this.procedureBindingSource.DataMember = "Procedure";
            this.procedureBindingSource.DataSource = this.cosmetology_centerDataSet1;
            // 
            // номер_препаратуComboBox
            // 
            this.номер_препаратуComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.elixirBindingSource, "Номер препарату", true));
            this.номер_препаратуComboBox.DataSource = this.preparationBindingSource;
            this.номер_препаратуComboBox.DisplayMember = "Назва";
            this.номер_препаратуComboBox.FormattingEnabled = true;
            this.номер_препаратуComboBox.Location = new System.Drawing.Point(270, 150);
            this.номер_препаратуComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.номер_препаратуComboBox.Name = "номер_препаратуComboBox";
            this.номер_препаратуComboBox.Size = new System.Drawing.Size(160, 24);
            this.номер_препаратуComboBox.TabIndex = 4;
            this.номер_препаратуComboBox.ValueMember = "Номер препарату";
            // 
            // preparationBindingSource
            // 
            this.preparationBindingSource.DataMember = "Preparation";
            this.preparationBindingSource.DataSource = this.cosmetology_centerDataSet1;
            // 
            // button_Cancel
            // 
            this.button_Cancel.BackColor = System.Drawing.Color.White;
            this.button_Cancel.FlatAppearance.BorderColor = System.Drawing.Color.DeepPink;
            this.button_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Cancel.Location = new System.Drawing.Point(284, 271);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(168, 35);
            this.button_Cancel.TabIndex = 41;
            this.button_Cancel.Text = "Відміна";
            this.button_Cancel.UseVisualStyleBackColor = false;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // button_Ok
            // 
            this.button_Ok.BackColor = System.Drawing.Color.White;
            this.button_Ok.FlatAppearance.BorderColor = System.Drawing.Color.DeepPink;
            this.button_Ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Ok.Location = new System.Drawing.Point(41, 271);
            this.button_Ok.Name = "button_Ok";
            this.button_Ok.Size = new System.Drawing.Size(168, 35);
            this.button_Ok.TabIndex = 40;
            this.button_Ok.Text = "Ок";
            this.button_Ok.UseVisualStyleBackColor = false;
            this.button_Ok.Click += new System.EventHandler(this.button_Ok_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Cosmetology.Properties.Resources._122396;
            this.pictureBox1.Location = new System.Drawing.Point(3, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // ElixirForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Ok);
            this.Controls.Add(номер_препаратуLabel);
            this.Controls.Add(this.номер_препаратуComboBox);
            this.Controls.Add(номер_процедуриLabel);
            this.Controls.Add(this.номер_процедуриComboBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 400);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "ElixirForm";
            this.Text = "Cosmetology";
            this.Load += new System.EventHandler(this.ElixirForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cosmetology_centerDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elixirBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.procedureBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preparationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private cosmetology_centerDataSet1 cosmetology_centerDataSet1;
        private System.Windows.Forms.BindingSource elixirBindingSource;
        private cosmetology_centerDataSet1TableAdapters.ElixirTableAdapter elixirTableAdapter;
        private cosmetology_centerDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox номер_процедуриComboBox;
        private System.Windows.Forms.ComboBox номер_препаратуComboBox;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_Ok;
        private System.Windows.Forms.PictureBox pictureBox1;
        private cosmetology_centerDataSet1TableAdapters.ProcedureTableAdapter procedureTableAdapter;
        private System.Windows.Forms.BindingSource procedureBindingSource;
        private cosmetology_centerDataSet1TableAdapters.PreparationTableAdapter preparationTableAdapter;
        private System.Windows.Forms.BindingSource preparationBindingSource;
    }
}