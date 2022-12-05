
namespace автопрокат
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            System.Windows.Forms.Label кодLabel;
            System.Windows.Forms.Label фИОLabel;
            System.Windows.Forms.Label серия_паспортаLabel;
            System.Windows.Forms.Label номер_паспортаLabel;
            this.button4 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.автопрокатDataSet = new автопрокат.АвтопрокатDataSet();
            this.клиентBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.клиентTableAdapter = new автопрокат.АвтопрокатDataSetTableAdapters.КлиентTableAdapter();
            this.tableAdapterManager = new автопрокат.АвтопрокатDataSetTableAdapters.TableAdapterManager();
            this.клиентDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодTextBox = new System.Windows.Forms.TextBox();
            this.фИОTextBox = new System.Windows.Forms.TextBox();
            this.серия_паспортаTextBox = new System.Windows.Forms.TextBox();
            this.номер_паспортаTextBox = new System.Windows.Forms.TextBox();
            кодLabel = new System.Windows.Forms.Label();
            фИОLabel = new System.Windows.Forms.Label();
            серия_паспортаLabel = new System.Windows.Forms.Label();
            номер_паспортаLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.автопрокатDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(721, 11);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(66, 21);
            this.button4.TabIndex = 5;
            this.button4.Text = "Выход";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 100);
            this.panel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(269, 97);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // автопрокатDataSet
            // 
            this.автопрокатDataSet.DataSetName = "АвтопрокатDataSet";
            this.автопрокатDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // клиентBindingSource
            // 
            this.клиентBindingSource.DataMember = "Клиент";
            this.клиентBindingSource.DataSource = this.автопрокатDataSet;
            // 
            // клиентTableAdapter
            // 
            this.клиентTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = автопрокат.АвтопрокатDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АвтомобильTableAdapter = null;
            this.tableAdapterManager.КлиентTableAdapter = this.клиентTableAdapter;
            this.tableAdapterManager.ПрокатTableAdapter = null;
            // 
            // клиентDataGridView
            // 
            this.клиентDataGridView.AutoGenerateColumns = false;
            this.клиентDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.клиентDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.клиентDataGridView.DataSource = this.клиентBindingSource;
            this.клиентDataGridView.Location = new System.Drawing.Point(344, 104);
            this.клиентDataGridView.Name = "клиентDataGridView";
            this.клиентDataGridView.Size = new System.Drawing.Size(443, 271);
            this.клиентDataGridView.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "код";
            this.dataGridViewTextBoxColumn1.HeaderText = "код";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ФИО";
            this.dataGridViewTextBoxColumn2.HeaderText = "ФИО";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Серия_паспорта";
            this.dataGridViewTextBoxColumn3.HeaderText = "Серия_паспорта";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "номер_паспорта";
            this.dataGridViewTextBoxColumn4.HeaderText = "номер_паспорта";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // кодLabel
            // 
            кодLabel.AutoSize = true;
            кодLabel.Location = new System.Drawing.Point(109, 142);
            кодLabel.Name = "кодLabel";
            кодLabel.Size = new System.Drawing.Size(28, 13);
            кодLabel.TabIndex = 7;
            кодLabel.Text = "код:";
            кодLabel.Click += new System.EventHandler(this.кодLabel_Click);
            // 
            // кодTextBox
            // 
            this.кодTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.клиентBindingSource, "код", true));
            this.кодTextBox.Location = new System.Drawing.Point(156, 135);
            this.кодTextBox.Name = "кодTextBox";
            this.кодTextBox.Size = new System.Drawing.Size(100, 20);
            this.кодTextBox.TabIndex = 8;
            this.кодTextBox.TextChanged += new System.EventHandler(this.кодTextBox_TextChanged);
            // 
            // фИОLabel
            // 
            фИОLabel.AutoSize = true;
            фИОLabel.Location = new System.Drawing.Point(109, 173);
            фИОLabel.Name = "фИОLabel";
            фИОLabel.Size = new System.Drawing.Size(37, 13);
            фИОLabel.TabIndex = 8;
            фИОLabel.Text = "ФИО:";
            // 
            // фИОTextBox
            // 
            this.фИОTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.клиентBindingSource, "ФИО", true));
            this.фИОTextBox.Location = new System.Drawing.Point(156, 170);
            this.фИОTextBox.Name = "фИОTextBox";
            this.фИОTextBox.Size = new System.Drawing.Size(100, 20);
            this.фИОTextBox.TabIndex = 9;
            // 
            // серия_паспортаLabel
            // 
            серия_паспортаLabel.AutoSize = true;
            серия_паспортаLabel.Location = new System.Drawing.Point(59, 219);
            серия_паспортаLabel.Name = "серия_паспортаLabel";
            серия_паспортаLabel.Size = new System.Drawing.Size(91, 13);
            серия_паспортаLabel.TabIndex = 9;
            серия_паспортаLabel.Text = "Серия паспорта:";
            // 
            // серия_паспортаTextBox
            // 
            this.серия_паспортаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.клиентBindingSource, "Серия_паспорта", true));
            this.серия_паспортаTextBox.Location = new System.Drawing.Point(156, 212);
            this.серия_паспортаTextBox.Name = "серия_паспортаTextBox";
            this.серия_паспортаTextBox.Size = new System.Drawing.Size(100, 20);
            this.серия_паспортаTextBox.TabIndex = 10;
            // 
            // номер_паспортаLabel
            // 
            номер_паспортаLabel.AutoSize = true;
            номер_паспортаLabel.Location = new System.Drawing.Point(45, 257);
            номер_паспортаLabel.Name = "номер_паспортаLabel";
            номер_паспортаLabel.Size = new System.Drawing.Size(92, 13);
            номер_паспортаLabel.TabIndex = 10;
            номер_паспортаLabel.Text = "номер паспорта:";
            // 
            // номер_паспортаTextBox
            // 
            this.номер_паспортаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.клиентBindingSource, "номер_паспорта", true));
            this.номер_паспортаTextBox.Location = new System.Drawing.Point(156, 250);
            this.номер_паспортаTextBox.Name = "номер_паспортаTextBox";
            this.номер_паспортаTextBox.Size = new System.Drawing.Size(100, 20);
            this.номер_паспортаTextBox.TabIndex = 11;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(234)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(799, 450);
            this.Controls.Add(номер_паспортаLabel);
            this.Controls.Add(this.номер_паспортаTextBox);
            this.Controls.Add(серия_паспортаLabel);
            this.Controls.Add(this.серия_паспортаTextBox);
            this.Controls.Add(фИОLabel);
            this.Controls.Add(this.фИОTextBox);
            this.Controls.Add(кодLabel);
            this.Controls.Add(this.кодTextBox);
            this.Controls.Add(this.клиентDataGridView);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.автопрокатDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private АвтопрокатDataSet автопрокатDataSet;
        private System.Windows.Forms.BindingSource клиентBindingSource;
        private АвтопрокатDataSetTableAdapters.КлиентTableAdapter клиентTableAdapter;
        private АвтопрокатDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView клиентDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox кодTextBox;
        private System.Windows.Forms.TextBox фИОTextBox;
        private System.Windows.Forms.TextBox серия_паспортаTextBox;
        private System.Windows.Forms.TextBox номер_паспортаTextBox;
    }
}