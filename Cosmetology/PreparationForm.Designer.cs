
namespace Cosmetology
{
    partial class PreparationForm
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
            System.Windows.Forms.Label вікова_категоріяLabel;
            System.Windows.Forms.Label термін_придатностіLabel;
            System.Windows.Forms.Label призначенняLabel;
            System.Windows.Forms.Label властивостіLabel;
            System.Windows.Forms.Label назваLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreparationForm));
            this.cosmetology_centerDataSet1 = new Cosmetology.cosmetology_centerDataSet1();
            this.preparationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.preparationTableAdapter = new Cosmetology.cosmetology_centerDataSet1TableAdapters.PreparationTableAdapter();
            this.tableAdapterManager = new Cosmetology.cosmetology_centerDataSet1TableAdapters.TableAdapterManager();
            this.вікова_категоріяTextBox = new System.Windows.Forms.TextBox();
            this.термін_придатностіNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.призначенняTextBox = new System.Windows.Forms.TextBox();
            this.властивостіTextBox = new System.Windows.Forms.TextBox();
            this.назваTextBox = new System.Windows.Forms.TextBox();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_Ok = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            вікова_категоріяLabel = new System.Windows.Forms.Label();
            термін_придатностіLabel = new System.Windows.Forms.Label();
            призначенняLabel = new System.Windows.Forms.Label();
            властивостіLabel = new System.Windows.Forms.Label();
            назваLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cosmetology_centerDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preparationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.термін_придатностіNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // вікова_категоріяLabel
            // 
            вікова_категоріяLabel.AutoSize = true;
            вікова_категоріяLabel.Location = new System.Drawing.Point(148, 52);
            вікова_категоріяLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            вікова_категоріяLabel.Name = "вікова_категоріяLabel";
            вікова_категоріяLabel.Size = new System.Drawing.Size(120, 17);
            вікова_категоріяLabel.TabIndex = 3;
            вікова_категоріяLabel.Text = "Вікова категорія:";
            // 
            // термін_придатностіLabel
            // 
            термін_придатностіLabel.AutoSize = true;
            термін_придатностіLabel.Location = new System.Drawing.Point(148, 80);
            термін_придатностіLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            термін_придатностіLabel.Name = "термін_придатностіLabel";
            термін_придатностіLabel.Size = new System.Drawing.Size(141, 17);
            термін_придатностіLabel.TabIndex = 5;
            термін_придатностіLabel.Text = "Термін придатності:";
            // 
            // призначенняLabel
            // 
            призначенняLabel.AutoSize = true;
            призначенняLabel.Location = new System.Drawing.Point(148, 116);
            призначенняLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            призначенняLabel.Name = "призначенняLabel";
            призначенняLabel.Size = new System.Drawing.Size(101, 17);
            призначенняLabel.TabIndex = 7;
            призначенняLabel.Text = "Призначення:";
            // 
            // властивостіLabel
            // 
            властивостіLabel.AutoSize = true;
            властивостіLabel.Location = new System.Drawing.Point(148, 148);
            властивостіLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            властивостіLabel.Name = "властивостіLabel";
            властивостіLabel.Size = new System.Drawing.Size(91, 17);
            властивостіLabel.TabIndex = 9;
            властивостіLabel.Text = "Властивості:";
            // 
            // назваLabel
            // 
            назваLabel.AutoSize = true;
            назваLabel.Location = new System.Drawing.Point(148, 180);
            назваLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            назваLabel.Name = "назваLabel";
            назваLabel.Size = new System.Drawing.Size(52, 17);
            назваLabel.TabIndex = 11;
            назваLabel.Text = "Назва:";
            // 
            // cosmetology_centerDataSet1
            // 
            this.cosmetology_centerDataSet1.DataSetName = "cosmetology_centerDataSet1";
            this.cosmetology_centerDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // preparationBindingSource
            // 
            this.preparationBindingSource.DataMember = "Preparation";
            this.preparationBindingSource.DataSource = this.cosmetology_centerDataSet1;
            // 
            // preparationTableAdapter
            // 
            this.preparationTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientTableAdapter = null;
            this.tableAdapterManager.ElixirTableAdapter = null;
            this.tableAdapterManager.MasterTableAdapter = null;
            this.tableAdapterManager.PreparationTableAdapter = this.preparationTableAdapter;
            this.tableAdapterManager.ProcedureTableAdapter = null;
            this.tableAdapterManager.ResponseTableAdapter = null;
            this.tableAdapterManager.ServiceTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Cosmetology.cosmetology_centerDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VisitingTableAdapter = null;
            // 
            // вікова_категоріяTextBox
            // 
            this.вікова_категоріяTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.preparationBindingSource, "Вікова категорія", true));
            this.вікова_категоріяTextBox.Location = new System.Drawing.Point(300, 48);
            this.вікова_категоріяTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.вікова_категоріяTextBox.Name = "вікова_категоріяTextBox";
            this.вікова_категоріяTextBox.Size = new System.Drawing.Size(159, 23);
            this.вікова_категоріяTextBox.TabIndex = 4;
            this.вікова_категоріяTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.вікова_категоріяTextBox_KeyPress);
            // 
            // термін_придатностіNumericUpDown
            // 
            this.термін_придатностіNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.preparationBindingSource, "Термін придатності", true));
            this.термін_придатностіNumericUpDown.Location = new System.Drawing.Point(300, 80);
            this.термін_придатностіNumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.термін_придатностіNumericUpDown.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.термін_придатностіNumericUpDown.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.термін_придатностіNumericUpDown.Name = "термін_придатностіNumericUpDown";
            this.термін_придатностіNumericUpDown.Size = new System.Drawing.Size(160, 23);
            this.термін_придатностіNumericUpDown.TabIndex = 6;
            this.термін_придатностіNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // призначенняTextBox
            // 
            this.призначенняTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.preparationBindingSource, "Призначення", true));
            this.призначенняTextBox.Location = new System.Drawing.Point(300, 112);
            this.призначенняTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.призначенняTextBox.Name = "призначенняTextBox";
            this.призначенняTextBox.Size = new System.Drawing.Size(159, 23);
            this.призначенняTextBox.TabIndex = 8;
            this.призначенняTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.призначенняTextBox_KeyPress);
            this.призначенняTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.призначенняTextBox_Validating);
            // 
            // властивостіTextBox
            // 
            this.властивостіTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.preparationBindingSource, "Властивості", true));
            this.властивостіTextBox.Location = new System.Drawing.Point(300, 144);
            this.властивостіTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.властивостіTextBox.Name = "властивостіTextBox";
            this.властивостіTextBox.Size = new System.Drawing.Size(159, 23);
            this.властивостіTextBox.TabIndex = 10;
            this.властивостіTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.призначенняTextBox_KeyPress);
            this.властивостіTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.властивостіTextBox_Validating);
            // 
            // назваTextBox
            // 
            this.назваTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.preparationBindingSource, "Назва", true));
            this.назваTextBox.Location = new System.Drawing.Point(300, 176);
            this.назваTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.назваTextBox.Name = "назваTextBox";
            this.назваTextBox.Size = new System.Drawing.Size(159, 23);
            this.назваTextBox.TabIndex = 12;
            this.назваTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.призначенняTextBox_KeyPress);
            this.назваTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.назваTextBox_Validating);
            // 
            // button_Cancel
            // 
            this.button_Cancel.BackColor = System.Drawing.Color.White;
            this.button_Cancel.FlatAppearance.BorderColor = System.Drawing.Color.DeepPink;
            this.button_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Cancel.Location = new System.Drawing.Point(276, 256);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(168, 35);
            this.button_Cancel.TabIndex = 39;
            this.button_Cancel.Text = "Відміна";
            this.button_Cancel.UseVisualStyleBackColor = false;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // button_Ok
            // 
            this.button_Ok.BackColor = System.Drawing.Color.White;
            this.button_Ok.FlatAppearance.BorderColor = System.Drawing.Color.DeepPink;
            this.button_Ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Ok.Location = new System.Drawing.Point(33, 256);
            this.button_Ok.Name = "button_Ok";
            this.button_Ok.Size = new System.Drawing.Size(168, 35);
            this.button_Ok.TabIndex = 38;
            this.button_Ok.Text = "Ок";
            this.button_Ok.UseVisualStyleBackColor = false;
            this.button_Ok.Click += new System.EventHandler(this.button_Ok_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Cosmetology.Properties.Resources._122402;
            this.pictureBox1.Location = new System.Drawing.Point(-7, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // PreparationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Ok);
            this.Controls.Add(вікова_категоріяLabel);
            this.Controls.Add(this.вікова_категоріяTextBox);
            this.Controls.Add(термін_придатностіLabel);
            this.Controls.Add(this.термін_придатностіNumericUpDown);
            this.Controls.Add(призначенняLabel);
            this.Controls.Add(this.призначенняTextBox);
            this.Controls.Add(властивостіLabel);
            this.Controls.Add(this.властивостіTextBox);
            this.Controls.Add(назваLabel);
            this.Controls.Add(this.назваTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 400);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "PreparationForm";
            this.Text = "Cosmetology";
            ((System.ComponentModel.ISupportInitialize)(this.cosmetology_centerDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preparationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.термін_придатностіNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private cosmetology_centerDataSet1 cosmetology_centerDataSet1;
        private System.Windows.Forms.BindingSource preparationBindingSource;
        private cosmetology_centerDataSet1TableAdapters.PreparationTableAdapter preparationTableAdapter;
        private cosmetology_centerDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox вікова_категоріяTextBox;
        private System.Windows.Forms.NumericUpDown термін_придатностіNumericUpDown;
        private System.Windows.Forms.TextBox призначенняTextBox;
        private System.Windows.Forms.TextBox властивостіTextBox;
        private System.Windows.Forms.TextBox назваTextBox;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_Ok;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}