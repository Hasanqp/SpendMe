namespace SpendMe.Gui.GuiCustomers
{
    partial class AddCustomersForm
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
            textBoxEmail = new System.Windows.Forms.TextBox();
            textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            label9 = new System.Windows.Forms.Label();
            textBoxAddress = new System.Windows.Forms.TextBox();
            label7 = new System.Windows.Forms.Label();
            richTextBoxDetails = new System.Windows.Forms.RichTextBox();
            textBoxBalance = new System.Windows.Forms.TextBox();
            textBoxName = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
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
            buttonSave.Location = new System.Drawing.Point(340, 8);
            buttonSave.Margin = new System.Windows.Forms.Padding(5);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new System.Drawing.Size(135, 39);
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
            buttonSaveAndClose.Location = new System.Drawing.Point(9, 10);
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
            groupBox1.Controls.Add(textBoxEmail);
            groupBox1.Controls.Add(textBoxPhoneNumber);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(textBoxAddress);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(richTextBoxDetails);
            groupBox1.Controls.Add(textBoxBalance);
            groupBox1.Controls.Add(textBoxName);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new System.Drawing.Point(0, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(487, 412);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Информация  Клиента";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new System.Drawing.Point(185, 194);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new System.Drawing.Size(290, 29);
            textBoxEmail.TabIndex = 3;
            textBoxEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxPhoneNumber
            // 
            textBoxPhoneNumber.Location = new System.Drawing.Point(182, 90);
            textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            textBoxPhoneNumber.Size = new System.Drawing.Size(290, 29);
            textBoxPhoneNumber.TabIndex = 1;
            textBoxPhoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(10, 198);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(147, 18);
            label9.TabIndex = 8;
            label9.Text = "Электронная почта";
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new System.Drawing.Point(183, 142);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new System.Drawing.Size(290, 29);
            textBoxAddress.TabIndex = 2;
            textBoxAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(10, 146);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(54, 18);
            label7.TabIndex = 5;
            label7.Text = "Адрес";
            // 
            // richTextBoxDetails
            // 
            richTextBoxDetails.Location = new System.Drawing.Point(185, 247);
            richTextBoxDetails.Name = "richTextBoxDetails";
            richTextBoxDetails.Size = new System.Drawing.Size(290, 60);
            richTextBoxDetails.TabIndex = 4;
            richTextBoxDetails.Text = "";
            // 
            // textBoxBalance
            // 
            textBoxBalance.Enabled = false;
            textBoxBalance.Location = new System.Drawing.Point(185, 336);
            textBoxBalance.Name = "textBoxBalance";
            textBoxBalance.Size = new System.Drawing.Size(290, 29);
            textBoxBalance.TabIndex = 5;
            textBoxBalance.Text = "0";
            textBoxBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxName
            // 
            textBoxName.Location = new System.Drawing.Point(183, 38);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new System.Drawing.Size(290, 29);
            textBoxName.TabIndex = 0;
            textBoxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(10, 339);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(61, 18);
            label4.TabIndex = 0;
            label4.Text = "Баланс";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(10, 268);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(119, 18);
            label3.TabIndex = 0;
            label3.Text = "Редактировать";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(10, 90);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(129, 18);
            label2.TabIndex = 0;
            label2.Text = "номер телефона";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = System.Drawing.Color.Red;
            label5.Location = new System.Drawing.Point(150, 43);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(14, 18);
            label5.TabIndex = 0;
            label5.Text = "*";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(10, 39);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(138, 18);
            label1.TabIndex = 0;
            label1.Text = "Название клиента";
            // 
            // AddCustomersForm
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
            Name = "AddCustomersForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Добавлять / редактировать клиента";
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSaveAndClose;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxBalance;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
    }
}