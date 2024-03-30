namespace SpendMe.Gui.GuiProjects
{
    partial class AddProjectForm
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
            panel1 = new System.Windows.Forms.Panel();
            buttonSave = new System.Windows.Forms.Button();
            buttonSaveAndClose = new System.Windows.Forms.Button();
            groupBox1 = new System.Windows.Forms.GroupBox();
            dateTimePickerFinish = new System.Windows.Forms.DateTimePicker();
            dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            comboBoxCustomer = new System.Windows.Forms.ComboBox();
            label8 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            textBoxCompany = new System.Windows.Forms.TextBox();
            label9 = new System.Windows.Forms.Label();
            textBoxAddress = new System.Windows.Forms.TextBox();
            label7 = new System.Windows.Forms.Label();
            richTextBoxDetails = new System.Windows.Forms.RichTextBox();
            textBoxName = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            groupBox2 = new System.Windows.Forms.GroupBox();
            textBoxRevenue = new System.Windows.Forms.TextBox();
            textBoxOutcome = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            textBoxIncome = new System.Windows.Forms.TextBox();
            label14 = new System.Windows.Forms.Label();
            label16 = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonSave);
            panel1.Controls.Add(buttonSaveAndClose);
            panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel1.Location = new System.Drawing.Point(0, 420);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(816, 49);
            panel1.TabIndex = 0;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = System.Drawing.Color.White;
            buttonSave.Image = Properties.Resources.icons8_save_gr_22_px;
            buttonSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonSave.Location = new System.Drawing.Point(676, 5);
            buttonSave.Margin = new System.Windows.Forms.Padding(5);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new System.Drawing.Size(135, 39);
            buttonSave.TabIndex = 11;
            buttonSave.Text = "     Сохранять";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonSaveAndClose
            // 
            buttonSaveAndClose.BackColor = System.Drawing.Color.White;
            buttonSaveAndClose.Image = Properties.Resources.icons8_save_red_22_px;
            buttonSaveAndClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonSaveAndClose.Location = new System.Drawing.Point(10, 5);
            buttonSaveAndClose.Margin = new System.Windows.Forms.Padding(5);
            buttonSaveAndClose.Name = "buttonSaveAndClose";
            buttonSaveAndClose.Size = new System.Drawing.Size(172, 39);
            buttonSaveAndClose.TabIndex = 10;
            buttonSaveAndClose.Text = "     Сохрани и закрой";
            buttonSaveAndClose.UseVisualStyleBackColor = false;
            buttonSaveAndClose.Click += buttonSaveAndClose_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dateTimePickerFinish);
            groupBox1.Controls.Add(dateTimePickerStart);
            groupBox1.Controls.Add(comboBoxCustomer);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(textBoxCompany);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(textBoxAddress);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(richTextBoxDetails);
            groupBox1.Controls.Add(textBoxName);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new System.Drawing.Point(0, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(488, 412);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Информация о  проект";
            // 
            // dateTimePickerFinish
            // 
            dateTimePickerFinish.Location = new System.Drawing.Point(190, 290);
            dateTimePickerFinish.Name = "dateTimePickerFinish";
            dateTimePickerFinish.Size = new System.Drawing.Size(292, 29);
            dateTimePickerFinish.TabIndex = 5;
            // 
            // dateTimePickerStart
            // 
            dateTimePickerStart.Location = new System.Drawing.Point(190, 251);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.Size = new System.Drawing.Size(292, 29);
            dateTimePickerStart.TabIndex = 4;
            // 
            // comboBoxCustomer
            // 
            comboBoxCustomer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            comboBoxCustomer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            comboBoxCustomer.FormattingEnabled = true;
            comboBoxCustomer.Location = new System.Drawing.Point(190, 93);
            comboBoxCustomer.Name = "comboBoxCustomer";
            comboBoxCustomer.Size = new System.Drawing.Size(292, 26);
            comboBoxCustomer.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(11, 290);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(114, 18);
            label8.TabIndex = 13;
            label8.Text = "Конец проекта";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(11, 247);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(124, 18);
            label6.TabIndex = 11;
            label6.Text = "Начало проекта";
            // 
            // textBoxCompany
            // 
            textBoxCompany.Location = new System.Drawing.Point(190, 198);
            textBoxCompany.Name = "textBoxCompany";
            textBoxCompany.Size = new System.Drawing.Size(292, 29);
            textBoxCompany.TabIndex = 3;
            textBoxCompany.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(11, 200);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(177, 18);
            label9.TabIndex = 8;
            label9.Text = "Компания реализовала";
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new System.Drawing.Point(190, 143);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new System.Drawing.Size(292, 29);
            textBoxAddress.TabIndex = 2;
            textBoxAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(11, 146);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(54, 18);
            label7.TabIndex = 5;
            label7.Text = "Адрес";
            // 
            // richTextBoxDetails
            // 
            richTextBoxDetails.Location = new System.Drawing.Point(190, 338);
            richTextBoxDetails.Name = "richTextBoxDetails";
            richTextBoxDetails.Size = new System.Drawing.Size(292, 60);
            richTextBoxDetails.TabIndex = 6;
            richTextBoxDetails.Text = "";
            // 
            // textBoxName
            // 
            textBoxName.Location = new System.Drawing.Point(190, 39);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new System.Drawing.Size(292, 29);
            textBoxName.TabIndex = 0;
            textBoxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(11, 359);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(59, 18);
            label3.TabIndex = 0;
            label3.Text = "Детали";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(11, 90);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(57, 18);
            label2.TabIndex = 0;
            label2.Text = "Клиент";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = System.Drawing.Color.Red;
            label5.Location = new System.Drawing.Point(152, 45);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(14, 18);
            label5.TabIndex = 0;
            label5.Text = "*";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(11, 41);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(131, 18);
            label1.TabIndex = 0;
            label1.Text = "Название проект";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBoxRevenue);
            groupBox2.Controls.Add(textBoxOutcome);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(textBoxIncome);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(label16);
            groupBox2.Location = new System.Drawing.Point(494, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(319, 240);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Сводная информация о средствах";
            // 
            // textBoxRevenue
            // 
            textBoxRevenue.Enabled = false;
            textBoxRevenue.Location = new System.Drawing.Point(17, 190);
            textBoxRevenue.Name = "textBoxRevenue";
            textBoxRevenue.Size = new System.Drawing.Size(290, 29);
            textBoxRevenue.TabIndex = 9;
            textBoxRevenue.Text = "0";
            textBoxRevenue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxOutcome
            // 
            textBoxOutcome.Enabled = false;
            textBoxOutcome.Location = new System.Drawing.Point(17, 119);
            textBoxOutcome.Name = "textBoxOutcome";
            textBoxOutcome.Size = new System.Drawing.Size(290, 29);
            textBoxOutcome.TabIndex = 8;
            textBoxOutcome.Text = "0";
            textBoxOutcome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(130, 166);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(65, 18);
            label4.TabIndex = 0;
            label4.Text = "Доходы";
            // 
            // textBoxIncome
            // 
            textBoxIncome.Enabled = false;
            textBoxIncome.Location = new System.Drawing.Point(17, 48);
            textBoxIncome.Name = "textBoxIncome";
            textBoxIncome.Size = new System.Drawing.Size(290, 29);
            textBoxIncome.TabIndex = 7;
            textBoxIncome.Text = "0";
            textBoxIncome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new System.Drawing.Point(130, 95);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(53, 18);
            label14.TabIndex = 0;
            label14.Text = "Траты";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new System.Drawing.Point(130, 24);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(53, 18);
            label16.TabIndex = 0;
            label16.Text = "Снять";
            // 
            // AddProjectForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(816, 469);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Margin = new System.Windows.Forms.Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddProjectForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Добавлять / редактировать о  проект";
            TopMost = true;
            Load += AddCategoryForm_Load;
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.RichTextBox richTextBoxDetails;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSaveAndClose;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxCompany;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBoxIncome;
        private System.Windows.Forms.DateTimePicker dateTimePickerFinish;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.ComboBox comboBoxCustomer;
        private System.Windows.Forms.TextBox textBoxRevenue;
        private System.Windows.Forms.TextBox textBoxOutcome;
        private System.Windows.Forms.Label label4;
    }
}