namespace SpendMe.Gui.GuiCategries
{
    partial class AddCategoryForm
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
            richTextBoxDetails = new System.Windows.Forms.RichTextBox();
            comboBoxType = new System.Windows.Forms.ComboBox();
            textBoxBalance = new System.Windows.Forms.TextBox();
            textBoxName = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
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
            buttonSave.Location = new System.Drawing.Point(347, 10);
            buttonSave.Margin = new System.Windows.Forms.Padding(5);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new System.Drawing.Size(135, 39);
            buttonSave.TabIndex = 5;
            buttonSave.Text = "    Сохранять";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonSaveAndClose
            // 
            buttonSaveAndClose.BackColor = System.Drawing.Color.White;
            buttonSaveAndClose.Image = Properties.Resources.icons8_save_red_22_px;
            buttonSaveAndClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonSaveAndClose.Location = new System.Drawing.Point(9, 12);
            buttonSaveAndClose.Margin = new System.Windows.Forms.Padding(5);
            buttonSaveAndClose.Name = "buttonSaveAndClose";
            buttonSaveAndClose.Size = new System.Drawing.Size(172, 39);
            buttonSaveAndClose.TabIndex = 4;
            buttonSaveAndClose.Text = "     Сохрани и закрой";
            buttonSaveAndClose.UseVisualStyleBackColor = false;
            buttonSaveAndClose.Click += buttonSaveAndClose_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(richTextBoxDetails);
            groupBox1.Controls.Add(comboBoxType);
            groupBox1.Controls.Add(textBoxBalance);
            groupBox1.Controls.Add(textBoxName);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new System.Drawing.Point(0, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(487, 412);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Информация о  Категория";
            // 
            // richTextBoxDetails
            // 
            richTextBoxDetails.Location = new System.Drawing.Point(21, 217);
            richTextBoxDetails.Name = "richTextBoxDetails";
            richTextBoxDetails.Size = new System.Drawing.Size(454, 96);
            richTextBoxDetails.TabIndex = 2;
            richTextBoxDetails.Text = "";
            // 
            // comboBoxType
            // 
            comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Items.AddRange(new object[] { "Снять", "Тратить" });
            comboBoxType.Location = new System.Drawing.Point(21, 126);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new System.Drawing.Size(454, 26);
            comboBoxType.TabIndex = 1;
            comboBoxType.SelectedIndexChanged += comboBoxType_SelectedIndexChanged;
            // 
            // textBoxBalance
            // 
            textBoxBalance.Enabled = false;
            textBoxBalance.Location = new System.Drawing.Point(21, 366);
            textBoxBalance.Name = "textBoxBalance";
            textBoxBalance.Size = new System.Drawing.Size(454, 29);
            textBoxBalance.TabIndex = 3;
            textBoxBalance.Text = "0";
            textBoxBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxName
            // 
            textBoxName.Location = new System.Drawing.Point(21, 58);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new System.Drawing.Size(454, 29);
            textBoxName.TabIndex = 0;
            textBoxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(221, 342);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(61, 18);
            label4.TabIndex = 0;
            label4.Text = "Баланс";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(194, 186);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(119, 18);
            label3.TabIndex = 0;
            label3.Text = "Редактировать";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(193, 90);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(113, 18);
            label2.TabIndex = 0;
            label2.Text = "Тип  категория";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = System.Drawing.Color.Red;
            label6.Location = new System.Drawing.Point(308, 94);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(14, 18);
            label6.TabIndex = 0;
            label6.Text = "*";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = System.Drawing.Color.Red;
            label5.Location = new System.Drawing.Point(310, 35);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(14, 18);
            label5.TabIndex = 0;
            label5.Text = "*";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(163, 34);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(146, 18);
            label1.TabIndex = 0;
            label1.Text = "Название категори";
            // 
            // AddCategoryForm
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
            Name = "AddCategoryForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Добавлять / редактировать о  категория";
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
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.RichTextBox richTextBoxDetails;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSaveAndClose;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxBalance;
    }
}