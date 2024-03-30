namespace SpendMe.Gui.GuiSettings
{
    partial class SettingsForm
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
            groupBox1 = new System.Windows.Forms.GroupBox();
            buttonSaveGeneralSettings = new System.Windows.Forms.Button();
            linkLabelImporimage = new System.Windows.Forms.LinkLabel();
            pictureBoxLogo = new System.Windows.Forms.PictureBox();
            numericUpDownDataRow = new System.Windows.Forms.NumericUpDown();
            numericUpDownNotification = new System.Windows.Forms.NumericUpDown();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            textBoxCompany = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            groupBox2 = new System.Windows.Forms.GroupBox();
            groupBox4 = new System.Windows.Forms.GroupBox();
            buttonSaveConString = new System.Windows.Forms.Button();
            radioButtonNetworkCon = new System.Windows.Forms.RadioButton();
            radioButtonLocalCon = new System.Windows.Forms.RadioButton();
            label7 = new System.Windows.Forms.Label();
            textBoxPassword = new System.Windows.Forms.TextBox();
            textBoxUserName = new System.Windows.Forms.TextBox();
            label9 = new System.Windows.Forms.Label();
            textBoxDataBase = new System.Windows.Forms.TextBox();
            label8 = new System.Windows.Forms.Label();
            numericUpDownTimeout = new System.Windows.Forms.NumericUpDown();
            label6 = new System.Windows.Forms.Label();
            textBoxServer = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            groupBox3 = new System.Windows.Forms.GroupBox();
            buttonRestore = new System.Windows.Forms.Button();
            buttonBackUp = new System.Windows.Forms.Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDataRow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNotification).BeginInit();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTimeout).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonSaveGeneralSettings);
            groupBox1.Controls.Add(linkLabelImporimage);
            groupBox1.Controls.Add(pictureBoxLogo);
            groupBox1.Controls.Add(numericUpDownDataRow);
            groupBox1.Controls.Add(numericUpDownNotification);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBoxCompany);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new System.Drawing.Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(500, 493);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Общие настройки";
            // 
            // buttonSaveGeneralSettings
            // 
            buttonSaveGeneralSettings.BackColor = System.Drawing.Color.White;
            buttonSaveGeneralSettings.Image = Properties.Resources.icons8_save_gr_22_px;
            buttonSaveGeneralSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonSaveGeneralSettings.Location = new System.Drawing.Point(0, 440);
            buttonSaveGeneralSettings.Margin = new System.Windows.Forms.Padding(5);
            buttonSaveGeneralSettings.Name = "buttonSaveGeneralSettings";
            buttonSaveGeneralSettings.Size = new System.Drawing.Size(484, 39);
            buttonSaveGeneralSettings.TabIndex = 4;
            buttonSaveGeneralSettings.Text = "Сохранять";
            buttonSaveGeneralSettings.UseVisualStyleBackColor = false;
            buttonSaveGeneralSettings.Click += buttonSaveGeneralSettings_Click;
            // 
            // linkLabelImporimage
            // 
            linkLabelImporimage.AutoSize = true;
            linkLabelImporimage.Location = new System.Drawing.Point(202, 409);
            linkLabelImporimage.Name = "linkLabelImporimage";
            linkLabelImporimage.Size = new System.Drawing.Size(69, 18);
            linkLabelImporimage.TabIndex = 3;
            linkLabelImporimage.TabStop = true;
            linkLabelImporimage.Text = "Скачать";
            linkLabelImporimage.LinkClicked += linkLabelImporimage_LinkClicked;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = Properties.Resources.images;
            pictureBoxLogo.Location = new System.Drawing.Point(94, 209);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new System.Drawing.Size(305, 165);
            pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            pictureBoxLogo.TabIndex = 4;
            pictureBoxLogo.TabStop = false;
            // 
            // numericUpDownDataRow
            // 
            numericUpDownDataRow.Location = new System.Drawing.Point(278, 130);
            numericUpDownDataRow.Name = "numericUpDownDataRow";
            numericUpDownDataRow.Size = new System.Drawing.Size(110, 29);
            numericUpDownDataRow.TabIndex = 2;
            numericUpDownDataRow.Value = new decimal(new int[] { 25, 0, 0, 0 });
            // 
            // numericUpDownNotification
            // 
            numericUpDownNotification.Location = new System.Drawing.Point(278, 87);
            numericUpDownNotification.Name = "numericUpDownNotification";
            numericUpDownNotification.Size = new System.Drawing.Size(110, 29);
            numericUpDownNotification.TabIndex = 1;
            numericUpDownNotification.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(185, 183);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(115, 16);
            label4.TabIndex = 1;
            label4.Text = "Логотип компании";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(4, 135);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(217, 16);
            label3.TabIndex = 1;
            label3.Text = "Количество отображаемых данных";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(4, 87);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(267, 16);
            label2.TabIndex = 1;
            label2.Text = "Время отображения уведомления (Секунд)";
            // 
            // textBoxCompany
            // 
            textBoxCompany.Location = new System.Drawing.Point(174, 37);
            textBoxCompany.Name = "textBoxCompany";
            textBoxCompany.Size = new System.Drawing.Size(321, 29);
            textBoxCompany.TabIndex = 0;
            textBoxCompany.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(4, 39);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(125, 16);
            label1.TabIndex = 1;
            label1.Text = "Название компании";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(groupBox4);
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Location = new System.Drawing.Point(518, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(538, 493);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Базы данных";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(buttonSaveConString);
            groupBox4.Controls.Add(radioButtonNetworkCon);
            groupBox4.Controls.Add(radioButtonLocalCon);
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(textBoxPassword);
            groupBox4.Controls.Add(textBoxUserName);
            groupBox4.Controls.Add(label9);
            groupBox4.Controls.Add(textBoxDataBase);
            groupBox4.Controls.Add(label8);
            groupBox4.Controls.Add(numericUpDownTimeout);
            groupBox4.Controls.Add(label6);
            groupBox4.Controls.Add(textBoxServer);
            groupBox4.Controls.Add(label5);
            groupBox4.Location = new System.Drawing.Point(6, 28);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new System.Drawing.Size(518, 371);
            groupBox4.TabIndex = 10;
            groupBox4.TabStop = false;
            groupBox4.Text = "Контактный текст";
            // 
            // buttonSaveConString
            // 
            buttonSaveConString.BackColor = System.Drawing.Color.White;
            buttonSaveConString.Image = Properties.Resources.icons8_save_gr_22_px;
            buttonSaveConString.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonSaveConString.Location = new System.Drawing.Point(67, 307);
            buttonSaveConString.Margin = new System.Windows.Forms.Padding(5);
            buttonSaveConString.Name = "buttonSaveConString";
            buttonSaveConString.Size = new System.Drawing.Size(443, 39);
            buttonSaveConString.TabIndex = 6;
            buttonSaveConString.Text = "     Сохранять";
            buttonSaveConString.UseVisualStyleBackColor = false;
            buttonSaveConString.Click += buttonSaveConString_Click;
            // 
            // radioButtonNetworkCon
            // 
            radioButtonNetworkCon.AutoSize = true;
            radioButtonNetworkCon.Location = new System.Drawing.Point(158, 37);
            radioButtonNetworkCon.Name = "radioButtonNetworkCon";
            radioButtonNetworkCon.Size = new System.Drawing.Size(62, 22);
            radioButtonNetworkCon.TabIndex = 0;
            radioButtonNetworkCon.Text = "Сеть";
            radioButtonNetworkCon.UseVisualStyleBackColor = true;
            radioButtonNetworkCon.CheckedChanged += radioButtonNetworkCon_CheckedChanged;
            // 
            // radioButtonLocalCon
            // 
            radioButtonLocalCon.AutoSize = true;
            radioButtonLocalCon.Checked = true;
            radioButtonLocalCon.Location = new System.Drawing.Point(16, 37);
            radioButtonLocalCon.Name = "radioButtonLocalCon";
            radioButtonLocalCon.Size = new System.Drawing.Size(136, 22);
            radioButtonLocalCon.TabIndex = 0;
            radioButtonLocalCon.TabStop = true;
            radioButtonLocalCon.Text = "Общественный";
            radioButtonLocalCon.UseVisualStyleBackColor = true;
            radioButtonLocalCon.CheckedChanged += radioButtonLocalCon_CheckedChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label7.Location = new System.Drawing.Point(6, 165);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(186, 16);
            label7.TabIndex = 1;
            label7.Text = "Время подключения (Секунд)";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new System.Drawing.Point(191, 253);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new System.Drawing.Size(321, 29);
            textBoxPassword.TabIndex = 5;
            textBoxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxUserName
            // 
            textBoxUserName.Location = new System.Drawing.Point(191, 208);
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.Size = new System.Drawing.Size(321, 29);
            textBoxUserName.TabIndex = 4;
            textBoxUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label9.Location = new System.Drawing.Point(6, 255);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(51, 16);
            label9.TabIndex = 1;
            label9.Text = "Пароль";
            // 
            // textBoxDataBase
            // 
            textBoxDataBase.Location = new System.Drawing.Point(191, 118);
            textBoxDataBase.Name = "textBoxDataBase";
            textBoxDataBase.Size = new System.Drawing.Size(321, 29);
            textBoxDataBase.TabIndex = 2;
            textBoxDataBase.Text = "SpendMeDatabase";
            textBoxDataBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label8.Location = new System.Drawing.Point(6, 210);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(115, 16);
            label8.TabIndex = 1;
            label8.Text = "имя пользователя";
            // 
            // numericUpDownTimeout
            // 
            numericUpDownTimeout.Enabled = false;
            numericUpDownTimeout.Location = new System.Drawing.Point(191, 163);
            numericUpDownTimeout.Name = "numericUpDownTimeout";
            numericUpDownTimeout.Size = new System.Drawing.Size(321, 29);
            numericUpDownTimeout.TabIndex = 3;
            numericUpDownTimeout.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(6, 120);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(85, 16);
            label6.TabIndex = 1;
            label6.Text = "База данных";
            // 
            // textBoxServer
            // 
            textBoxServer.Location = new System.Drawing.Point(191, 73);
            textBoxServer.Name = "textBoxServer";
            textBoxServer.Size = new System.Drawing.Size(321, 29);
            textBoxServer.TabIndex = 1;
            textBoxServer.Text = ".\\SQLEXPRESS";
            textBoxServer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(6, 75);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(51, 16);
            label5.TabIndex = 1;
            label5.Text = "Сервер";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(buttonRestore);
            groupBox3.Controls.Add(buttonBackUp);
            groupBox3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            groupBox3.ForeColor = System.Drawing.Color.FromArgb(255, 128, 128);
            groupBox3.Location = new System.Drawing.Point(12, 416);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(520, 72);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "Резервное копирование и назначение";
            // 
            // buttonRestore
            // 
            buttonRestore.BackColor = System.Drawing.Color.White;
            buttonRestore.ForeColor = System.Drawing.Color.Black;
            buttonRestore.Image = Properties.Resources.icons8_database_restore_25_px;
            buttonRestore.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonRestore.Location = new System.Drawing.Point(260, 25);
            buttonRestore.Margin = new System.Windows.Forms.Padding(5);
            buttonRestore.Name = "buttonRestore";
            buttonRestore.Size = new System.Drawing.Size(252, 39);
            buttonRestore.TabIndex = 8;
            buttonRestore.Text = "     Восстановить резервную копию";
            buttonRestore.UseVisualStyleBackColor = false;
            buttonRestore.Click += buttonRestore_Click;
            // 
            // buttonBackUp
            // 
            buttonBackUp.BackColor = System.Drawing.Color.White;
            buttonBackUp.ForeColor = System.Drawing.Color.Black;
            buttonBackUp.Image = Properties.Resources.icons8_data_backup_25px;
            buttonBackUp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonBackUp.Location = new System.Drawing.Point(0, 25);
            buttonBackUp.Margin = new System.Windows.Forms.Padding(5);
            buttonBackUp.Name = "buttonBackUp";
            buttonBackUp.Size = new System.Drawing.Size(252, 39);
            buttonBackUp.TabIndex = 7;
            buttonBackUp.Text = "     Резервное копирование";
            buttonBackUp.UseVisualStyleBackColor = false;
            buttonBackUp.Click += buttonBackUp_Click;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1068, 509);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Margin = new System.Windows.Forms.Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SettingsForm";
            ShowIcon = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Системные настройки";
            Activated += SettingsForm_Activated;
            FormClosing += SettingsForm_FormClosing;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDataRow).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNotification).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTimeout).EndInit();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCompany;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownDataRow;
        private System.Windows.Forms.NumericUpDown numericUpDownNotification;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLabelImporimage;
        private System.Windows.Forms.Button buttonSaveGeneralSettings;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonRestore;
        private System.Windows.Forms.Button buttonBackUp;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radioButtonNetworkCon;
        private System.Windows.Forms.RadioButton radioButtonLocalCon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxDataBase;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxServer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDownTimeout;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonSaveConString;
    }
}