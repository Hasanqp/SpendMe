namespace SpendMe.Gui.GuiOutcome
{
    partial class AddOutcomeForm
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
            linkLabelNewSupplier = new System.Windows.Forms.LinkLabel();
            linkLabelNewCategoryWither = new System.Windows.Forms.LinkLabel();
            comboBoxsupplier = new System.Windows.Forms.ComboBox();
            comboBoxCategory = new System.Windows.Forms.ComboBox();
            textBoxAmount = new System.Windows.Forms.TextBox();
            textBoxRecNo = new System.Windows.Forms.TextBox();
            dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            label6 = new System.Windows.Forms.Label();
            richTextBoxDetails = new System.Windows.Forms.RichTextBox();
            label8 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonSave);
            panel1.Controls.Add(buttonSaveAndClose);
            panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel1.Location = new System.Drawing.Point(0, 414);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(487, 58);
            panel1.TabIndex = 0;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = System.Drawing.Color.White;
            buttonSave.Image = Properties.Resources.icons8_save_gr_22_px;
            buttonSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonSave.Location = new System.Drawing.Point(360, 8);
            buttonSave.Margin = new System.Windows.Forms.Padding(5);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new System.Drawing.Size(122, 39);
            buttonSave.TabIndex = 7;
            buttonSave.Text = "     Сохранять";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonSaveAndClose
            // 
            buttonSaveAndClose.BackColor = System.Drawing.Color.White;
            buttonSaveAndClose.Image = Properties.Resources.icons8_save_red_22_px;
            buttonSaveAndClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonSaveAndClose.Location = new System.Drawing.Point(5, 9);
            buttonSaveAndClose.Margin = new System.Windows.Forms.Padding(5);
            buttonSaveAndClose.Name = "buttonSaveAndClose";
            buttonSaveAndClose.Size = new System.Drawing.Size(172, 39);
            buttonSaveAndClose.TabIndex = 6;
            buttonSaveAndClose.Text = "     Сохрани и закрой";
            buttonSaveAndClose.UseVisualStyleBackColor = false;
            buttonSaveAndClose.Click += buttonSaveAndClose_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(linkLabelNewSupplier);
            groupBox1.Controls.Add(linkLabelNewCategoryWither);
            groupBox1.Controls.Add(comboBoxsupplier);
            groupBox1.Controls.Add(comboBoxCategory);
            groupBox1.Controls.Add(textBoxAmount);
            groupBox1.Controls.Add(textBoxRecNo);
            groupBox1.Controls.Add(dateTimePickerDate);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(richTextBoxDetails);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new System.Drawing.Point(0, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(487, 412);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Информация о тратах";
            // 
            // linkLabelNewSupplier
            // 
            linkLabelNewSupplier.AutoSize = true;
            linkLabelNewSupplier.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            linkLabelNewSupplier.LinkColor = System.Drawing.Color.Teal;
            linkLabelNewSupplier.Location = new System.Drawing.Point(135, 96);
            linkLabelNewSupplier.Name = "linkLabelNewSupplier";
            linkLabelNewSupplier.Size = new System.Drawing.Size(42, 16);
            linkLabelNewSupplier.TabIndex = 12;
            linkLabelNewSupplier.TabStop = true;
            linkLabelNewSupplier.Text = "новое";
            linkLabelNewSupplier.LinkClicked += linkLabelNewSupplier_LinkClicked;
            // 
            // linkLabelNewCategoryWither
            // 
            linkLabelNewCategoryWither.AutoSize = true;
            linkLabelNewCategoryWither.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            linkLabelNewCategoryWither.LinkColor = System.Drawing.Color.Teal;
            linkLabelNewCategoryWither.Location = new System.Drawing.Point(135, 43);
            linkLabelNewCategoryWither.Name = "linkLabelNewCategoryWither";
            linkLabelNewCategoryWither.Size = new System.Drawing.Size(42, 16);
            linkLabelNewCategoryWither.TabIndex = 12;
            linkLabelNewCategoryWither.TabStop = true;
            linkLabelNewCategoryWither.Text = "новое";
            linkLabelNewCategoryWither.LinkClicked += linkLabelNewCategoryWither_LinkClicked;
            // 
            // comboBoxsupplier
            // 
            comboBoxsupplier.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            comboBoxsupplier.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            comboBoxsupplier.FormattingEnabled = true;
            comboBoxsupplier.ItemHeight = 18;
            comboBoxsupplier.Location = new System.Drawing.Point(182, 90);
            comboBoxsupplier.Name = "comboBoxsupplier";
            comboBoxsupplier.Size = new System.Drawing.Size(290, 26);
            comboBoxsupplier.TabIndex = 1;
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            comboBoxCategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.ItemHeight = 18;
            comboBoxCategory.Location = new System.Drawing.Point(183, 38);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new System.Drawing.Size(290, 26);
            comboBoxCategory.TabIndex = 0;
            // 
            // textBoxAmount
            // 
            textBoxAmount.Location = new System.Drawing.Point(183, 246);
            textBoxAmount.Name = "textBoxAmount";
            textBoxAmount.Size = new System.Drawing.Size(290, 29);
            textBoxAmount.TabIndex = 4;
            textBoxAmount.Text = "0";
            textBoxAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxRecNo
            // 
            textBoxRecNo.Location = new System.Drawing.Point(185, 194);
            textBoxRecNo.Name = "textBoxRecNo";
            textBoxRecNo.Size = new System.Drawing.Size(290, 29);
            textBoxRecNo.TabIndex = 3;
            textBoxRecNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dateTimePickerDate
            // 
            dateTimePickerDate.Location = new System.Drawing.Point(183, 142);
            dateTimePickerDate.Name = "dateTimePickerDate";
            dateTimePickerDate.Size = new System.Drawing.Size(292, 29);
            dateTimePickerDate.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(6, 140);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(106, 18);
            label6.TabIndex = 11;
            label6.Text = "История трат";
            // 
            // richTextBoxDetails
            // 
            richTextBoxDetails.Location = new System.Drawing.Point(182, 298);
            richTextBoxDetails.Name = "richTextBoxDetails";
            richTextBoxDetails.Size = new System.Drawing.Size(292, 60);
            richTextBoxDetails.TabIndex = 5;
            richTextBoxDetails.Text = "";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(6, 247);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(58, 18);
            label8.TabIndex = 0;
            label8.Text = "Сумма";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(6, 192);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(132, 18);
            label7.TabIndex = 0;
            label7.Text = "Серийный номер";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(6, 317);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(59, 18);
            label3.TabIndex = 0;
            label3.Text = "Детали";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(5, 92);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(87, 18);
            label2.TabIndex = 0;
            label2.Text = "Поставщик";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = System.Drawing.Color.Red;
            label10.Location = new System.Drawing.Point(61, 250);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(14, 18);
            label10.TabIndex = 0;
            label10.Text = "*";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = System.Drawing.Color.Red;
            label9.Location = new System.Drawing.Point(118, 142);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(14, 18);
            label9.TabIndex = 0;
            label9.Text = "*";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = System.Drawing.Color.Red;
            label4.Location = new System.Drawing.Point(98, 94);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(14, 18);
            label4.TabIndex = 0;
            label4.Text = "*";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = System.Drawing.Color.Red;
            label5.Location = new System.Drawing.Point(86, 45);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(14, 18);
            label5.TabIndex = 0;
            label5.Text = "*";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(6, 41);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(83, 18);
            label1.TabIndex = 0;
            label1.Text = "Категория";
            // 
            // AddOutcomeForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(487, 472);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Margin = new System.Windows.Forms.Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddOutcomeForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Добавлять / редактировать траты";
            TopMost = true;
            Load += AddCategoryForm_Load;
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBoxDetails;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSaveAndClose;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.TextBox textBoxRecNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.ComboBox comboBoxsupplier;
        private System.Windows.Forms.LinkLabel linkLabelNewSupplier;
        private System.Windows.Forms.LinkLabel linkLabelNewCategoryWither;
    }
}