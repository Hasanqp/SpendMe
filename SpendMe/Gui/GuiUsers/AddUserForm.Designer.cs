namespace SpendMe.Gui.GuiUsers
{
    partial class AddUserForm
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
            label1 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            textBoxName = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            textBoxUserName = new System.Windows.Forms.TextBox();
            label9 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            textBoxPassword = new System.Windows.Forms.TextBox();
            textBoxEmail = new System.Windows.Forms.TextBox();
            textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            groupBox1 = new System.Windows.Forms.GroupBox();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label8 = new System.Windows.Forms.Label();
            groupBox2 = new System.Windows.Forms.GroupBox();
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            checkBoxHome = new System.Windows.Forms.CheckBox();
            checkBoxCategory = new System.Windows.Forms.CheckBox();
            checkBoxSupplier = new System.Windows.Forms.CheckBox();
            checkBoxCustomer = new System.Windows.Forms.CheckBox();
            checkBoxProjects = new System.Windows.Forms.CheckBox();
            checkBoxUsers = new System.Windows.Forms.CheckBox();
            checkBoxSettings = new System.Windows.Forms.CheckBox();
            checkBoxSystemRecord = new System.Windows.Forms.CheckBox();
            groupBox3 = new System.Windows.Forms.GroupBox();
            flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            checkBoxAccessCategory = new System.Windows.Forms.CheckBox();
            checkBoxAccessSupplier = new System.Windows.Forms.CheckBox();
            checkBoxAccessCustomer = new System.Windows.Forms.CheckBox();
            checkBoxAccessProject = new System.Windows.Forms.CheckBox();
            checkBoxAccessUsers = new System.Windows.Forms.CheckBox();
            checkBoxAccessOutcome = new System.Windows.Forms.CheckBox();
            checkBoxAccessIncome = new System.Windows.Forms.CheckBox();
            groupBox4 = new System.Windows.Forms.GroupBox();
            flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            checkBoxAdd = new System.Windows.Forms.CheckBox();
            checkBoxDelete = new System.Windows.Forms.CheckBox();
            checkBoxEdit = new System.Windows.Forms.CheckBox();
            checkBoxExport = new System.Windows.Forms.CheckBox();
            checkBoxSearch = new System.Windows.Forms.CheckBox();
            checkBoxExplor = new System.Windows.Forms.CheckBox();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            groupBox3.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            groupBox4.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonSave);
            panel1.Controls.Add(buttonSaveAndClose);
            panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel1.Location = new System.Drawing.Point(0, 446);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(955, 48);
            panel1.TabIndex = 1;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = System.Drawing.Color.White;
            buttonSave.Image = Properties.Resources.icons8_save_gr_22_px;
            buttonSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonSave.Location = new System.Drawing.Point(814, 4);
            buttonSave.Margin = new System.Windows.Forms.Padding(5);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new System.Drawing.Size(135, 39);
            buttonSave.TabIndex = 0;
            buttonSave.Text = "    Сохранять";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonSaveAndClose
            // 
            buttonSaveAndClose.BackColor = System.Drawing.Color.White;
            buttonSaveAndClose.Image = Properties.Resources.icons8_save_red_22_px;
            buttonSaveAndClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonSaveAndClose.Location = new System.Drawing.Point(5, 4);
            buttonSaveAndClose.Margin = new System.Windows.Forms.Padding(5);
            buttonSaveAndClose.Name = "buttonSaveAndClose";
            buttonSaveAndClose.Size = new System.Drawing.Size(172, 39);
            buttonSaveAndClose.TabIndex = 0;
            buttonSaveAndClose.Text = "     Сохрани и закрой";
            buttonSaveAndClose.UseVisualStyleBackColor = false;
            buttonSaveAndClose.Click += buttonSaveAndClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(18, 200);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(94, 18);
            label1.TabIndex = 0;
            label1.Text = "Полное имя";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = System.Drawing.Color.Red;
            label5.Location = new System.Drawing.Point(111, 200);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(14, 18);
            label5.TabIndex = 0;
            label5.Text = "*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(18, 249);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(144, 18);
            label2.TabIndex = 0;
            label2.Text = "Имя пользователя";
            // 
            // textBoxName
            // 
            textBoxName.Location = new System.Drawing.Point(185, 194);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new System.Drawing.Size(297, 29);
            textBoxName.TabIndex = 0;
            textBoxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(18, 301);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(63, 18);
            label4.TabIndex = 0;
            label4.Text = "Пароль";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = System.Drawing.Color.Red;
            label3.Location = new System.Drawing.Point(158, 249);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(14, 18);
            label3.TabIndex = 0;
            label3.Text = "*";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(18, 356);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(147, 18);
            label7.TabIndex = 0;
            label7.Text = "Электронная почта";
            // 
            // textBoxUserName
            // 
            textBoxUserName.Location = new System.Drawing.Point(185, 247);
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.Size = new System.Drawing.Size(297, 29);
            textBoxUserName.TabIndex = 1;
            textBoxUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(18, 410);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(132, 18);
            label9.TabIndex = 0;
            label9.Text = "Номер телефона";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = System.Drawing.Color.Red;
            label6.Location = new System.Drawing.Point(83, 302);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(14, 18);
            label6.TabIndex = 0;
            label6.Text = "*";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new System.Drawing.Point(185, 300);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new System.Drawing.Size(297, 29);
            textBoxPassword.TabIndex = 2;
            textBoxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new System.Drawing.Point(185, 353);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new System.Drawing.Size(297, 29);
            textBoxEmail.TabIndex = 3;
            textBoxEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxPhoneNumber
            // 
            textBoxPhoneNumber.Location = new System.Drawing.Point(185, 406);
            textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            textBoxPhoneNumber.Size = new System.Drawing.Size(297, 29);
            textBoxPhoneNumber.TabIndex = 4;
            textBoxPhoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(textBoxPhoneNumber);
            groupBox1.Controls.Add(textBoxEmail);
            groupBox1.Controls.Add(textBoxPassword);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(textBoxUserName);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBoxName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new System.Drawing.Point(0, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(495, 440);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Информация о пользователе";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.Color.White;
            pictureBox1.Image = Properties.Resources.icons8_employee_128_px;
            pictureBox1.Location = new System.Drawing.Point(17, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(142, 144);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label8.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            label8.Location = new System.Drawing.Point(161, 95);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(339, 22);
            label8.TabIndex = 0;
            label8.Text = "Добавление нового пользователя";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(flowLayoutPanel1);
            groupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            groupBox2.Location = new System.Drawing.Point(501, 13);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(450, 123);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Разрешения/вкладки";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(checkBoxHome);
            flowLayoutPanel1.Controls.Add(checkBoxCategory);
            flowLayoutPanel1.Controls.Add(checkBoxSupplier);
            flowLayoutPanel1.Controls.Add(checkBoxCustomer);
            flowLayoutPanel1.Controls.Add(checkBoxProjects);
            flowLayoutPanel1.Controls.Add(checkBoxUsers);
            flowLayoutPanel1.Controls.Add(checkBoxSettings);
            flowLayoutPanel1.Controls.Add(checkBoxSystemRecord);
            flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            flowLayoutPanel1.Location = new System.Drawing.Point(3, 21);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new System.Drawing.Size(444, 99);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // checkBoxHome
            // 
            checkBoxHome.AutoSize = true;
            checkBoxHome.Checked = true;
            checkBoxHome.CheckState = System.Windows.Forms.CheckState.Checked;
            checkBoxHome.Location = new System.Drawing.Point(3, 3);
            checkBoxHome.Name = "checkBoxHome";
            checkBoxHome.Size = new System.Drawing.Size(51, 20);
            checkBoxHome.TabIndex = 7;
            checkBoxHome.Text = "Дом";
            checkBoxHome.UseVisualStyleBackColor = true;
            // 
            // checkBoxCategory
            // 
            checkBoxCategory.AutoSize = true;
            checkBoxCategory.Location = new System.Drawing.Point(60, 3);
            checkBoxCategory.Name = "checkBoxCategory";
            checkBoxCategory.Size = new System.Drawing.Size(86, 20);
            checkBoxCategory.TabIndex = 8;
            checkBoxCategory.Text = "Категории";
            checkBoxCategory.UseVisualStyleBackColor = true;
            // 
            // checkBoxSupplier
            // 
            checkBoxSupplier.AutoSize = true;
            checkBoxSupplier.Location = new System.Drawing.Point(152, 3);
            checkBoxSupplier.Name = "checkBoxSupplier";
            checkBoxSupplier.Size = new System.Drawing.Size(76, 20);
            checkBoxSupplier.TabIndex = 9;
            checkBoxSupplier.Text = "Клиенты";
            checkBoxSupplier.UseVisualStyleBackColor = true;
            // 
            // checkBoxCustomer
            // 
            checkBoxCustomer.AutoSize = true;
            checkBoxCustomer.Location = new System.Drawing.Point(234, 3);
            checkBoxCustomer.Name = "checkBoxCustomer";
            checkBoxCustomer.Size = new System.Drawing.Size(100, 20);
            checkBoxCustomer.TabIndex = 10;
            checkBoxCustomer.Text = "Поставщики";
            checkBoxCustomer.UseVisualStyleBackColor = true;
            // 
            // checkBoxProjects
            // 
            checkBoxProjects.AutoSize = true;
            checkBoxProjects.Location = new System.Drawing.Point(340, 3);
            checkBoxProjects.Name = "checkBoxProjects";
            checkBoxProjects.Size = new System.Drawing.Size(76, 20);
            checkBoxProjects.TabIndex = 11;
            checkBoxProjects.Text = "Проекты";
            checkBoxProjects.UseVisualStyleBackColor = true;
            // 
            // checkBoxUsers
            // 
            checkBoxUsers.AutoSize = true;
            checkBoxUsers.Location = new System.Drawing.Point(3, 29);
            checkBoxUsers.Name = "checkBoxUsers";
            checkBoxUsers.Size = new System.Drawing.Size(109, 20);
            checkBoxUsers.TabIndex = 12;
            checkBoxUsers.Text = "Пользователи";
            checkBoxUsers.UseVisualStyleBackColor = true;
            // 
            // checkBoxSettings
            // 
            checkBoxSettings.AutoSize = true;
            checkBoxSettings.Location = new System.Drawing.Point(118, 29);
            checkBoxSettings.Name = "checkBoxSettings";
            checkBoxSettings.Size = new System.Drawing.Size(88, 20);
            checkBoxSettings.TabIndex = 13;
            checkBoxSettings.Text = "Настройки";
            checkBoxSettings.UseVisualStyleBackColor = true;
            // 
            // checkBoxSystemRecord
            // 
            checkBoxSystemRecord.AutoSize = true;
            checkBoxSystemRecord.Location = new System.Drawing.Point(212, 29);
            checkBoxSystemRecord.Name = "checkBoxSystemRecord";
            checkBoxSystemRecord.Size = new System.Drawing.Size(137, 20);
            checkBoxSystemRecord.TabIndex = 14;
            checkBoxSystemRecord.Text = "Системный реестр";
            checkBoxSystemRecord.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(flowLayoutPanel2);
            groupBox3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            groupBox3.Location = new System.Drawing.Point(501, 142);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(450, 123);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Разрешения/Быстрый доступ";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(checkBoxAccessCategory);
            flowLayoutPanel2.Controls.Add(checkBoxAccessSupplier);
            flowLayoutPanel2.Controls.Add(checkBoxAccessCustomer);
            flowLayoutPanel2.Controls.Add(checkBoxAccessProject);
            flowLayoutPanel2.Controls.Add(checkBoxAccessUsers);
            flowLayoutPanel2.Controls.Add(checkBoxAccessOutcome);
            flowLayoutPanel2.Controls.Add(checkBoxAccessIncome);
            flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            flowLayoutPanel2.Location = new System.Drawing.Point(3, 21);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new System.Drawing.Size(444, 99);
            flowLayoutPanel2.TabIndex = 3;
            // 
            // checkBoxAccessCategory
            // 
            checkBoxAccessCategory.AutoSize = true;
            checkBoxAccessCategory.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            checkBoxAccessCategory.Location = new System.Drawing.Point(3, 3);
            checkBoxAccessCategory.Name = "checkBoxAccessCategory";
            checkBoxAccessCategory.Size = new System.Drawing.Size(86, 20);
            checkBoxAccessCategory.TabIndex = 0;
            checkBoxAccessCategory.Text = "Категория";
            checkBoxAccessCategory.UseVisualStyleBackColor = true;
            // 
            // checkBoxAccessSupplier
            // 
            checkBoxAccessSupplier.AutoSize = true;
            checkBoxAccessSupplier.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            checkBoxAccessSupplier.Location = new System.Drawing.Point(95, 3);
            checkBoxAccessSupplier.Name = "checkBoxAccessSupplier";
            checkBoxAccessSupplier.Size = new System.Drawing.Size(67, 20);
            checkBoxAccessSupplier.TabIndex = 0;
            checkBoxAccessSupplier.Text = "Клиент";
            checkBoxAccessSupplier.UseVisualStyleBackColor = true;
            // 
            // checkBoxAccessCustomer
            // 
            checkBoxAccessCustomer.AutoSize = true;
            checkBoxAccessCustomer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            checkBoxAccessCustomer.Location = new System.Drawing.Point(168, 3);
            checkBoxAccessCustomer.Name = "checkBoxAccessCustomer";
            checkBoxAccessCustomer.Size = new System.Drawing.Size(93, 20);
            checkBoxAccessCustomer.TabIndex = 0;
            checkBoxAccessCustomer.Text = "Поставщик";
            checkBoxAccessCustomer.UseVisualStyleBackColor = true;
            // 
            // checkBoxAccessProject
            // 
            checkBoxAccessProject.AutoSize = true;
            checkBoxAccessProject.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            checkBoxAccessProject.Location = new System.Drawing.Point(267, 3);
            checkBoxAccessProject.Name = "checkBoxAccessProject";
            checkBoxAccessProject.Size = new System.Drawing.Size(67, 20);
            checkBoxAccessProject.TabIndex = 0;
            checkBoxAccessProject.Text = "Проект";
            checkBoxAccessProject.UseVisualStyleBackColor = true;
            // 
            // checkBoxAccessUsers
            // 
            checkBoxAccessUsers.AutoSize = true;
            checkBoxAccessUsers.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            checkBoxAccessUsers.Location = new System.Drawing.Point(3, 29);
            checkBoxAccessUsers.Name = "checkBoxAccessUsers";
            checkBoxAccessUsers.Size = new System.Drawing.Size(109, 20);
            checkBoxAccessUsers.TabIndex = 1;
            checkBoxAccessUsers.Text = "Пользователь";
            checkBoxAccessUsers.UseVisualStyleBackColor = true;
            // 
            // checkBoxAccessOutcome
            // 
            checkBoxAccessOutcome.AutoSize = true;
            checkBoxAccessOutcome.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            checkBoxAccessOutcome.Location = new System.Drawing.Point(118, 29);
            checkBoxAccessOutcome.Name = "checkBoxAccessOutcome";
            checkBoxAccessOutcome.Size = new System.Drawing.Size(70, 20);
            checkBoxAccessOutcome.TabIndex = 2;
            checkBoxAccessOutcome.Text = "Тратить";
            checkBoxAccessOutcome.UseVisualStyleBackColor = true;
            // 
            // checkBoxAccessIncome
            // 
            checkBoxAccessIncome.AutoSize = true;
            checkBoxAccessIncome.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            checkBoxAccessIncome.Location = new System.Drawing.Point(194, 29);
            checkBoxAccessIncome.Name = "checkBoxAccessIncome";
            checkBoxAccessIncome.Size = new System.Drawing.Size(61, 20);
            checkBoxAccessIncome.TabIndex = 3;
            checkBoxAccessIncome.Text = "Снять";
            checkBoxAccessIncome.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(flowLayoutPanel3);
            groupBox4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            groupBox4.Location = new System.Drawing.Point(501, 271);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new System.Drawing.Size(450, 123);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            groupBox4.Text = "Разрешения/Стандартные операции";
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(checkBoxAdd);
            flowLayoutPanel3.Controls.Add(checkBoxDelete);
            flowLayoutPanel3.Controls.Add(checkBoxEdit);
            flowLayoutPanel3.Controls.Add(checkBoxExport);
            flowLayoutPanel3.Controls.Add(checkBoxSearch);
            flowLayoutPanel3.Controls.Add(checkBoxExplor);
            flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            flowLayoutPanel3.Location = new System.Drawing.Point(3, 21);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new System.Drawing.Size(444, 99);
            flowLayoutPanel3.TabIndex = 4;
            // 
            // checkBoxAdd
            // 
            checkBoxAdd.AutoSize = true;
            checkBoxAdd.Location = new System.Drawing.Point(3, 3);
            checkBoxAdd.Name = "checkBoxAdd";
            checkBoxAdd.Size = new System.Drawing.Size(89, 20);
            checkBoxAdd.TabIndex = 0;
            checkBoxAdd.Text = "Добавлять";
            checkBoxAdd.UseVisualStyleBackColor = true;
            // 
            // checkBoxDelete
            // 
            checkBoxDelete.AutoSize = true;
            checkBoxDelete.Location = new System.Drawing.Point(98, 3);
            checkBoxDelete.Name = "checkBoxDelete";
            checkBoxDelete.Size = new System.Drawing.Size(74, 20);
            checkBoxDelete.TabIndex = 0;
            checkBoxDelete.Text = "Удалить";
            checkBoxDelete.UseVisualStyleBackColor = true;
            // 
            // checkBoxEdit
            // 
            checkBoxEdit.AutoSize = true;
            checkBoxEdit.Location = new System.Drawing.Point(178, 3);
            checkBoxEdit.Name = "checkBoxEdit";
            checkBoxEdit.Size = new System.Drawing.Size(114, 20);
            checkBoxEdit.TabIndex = 0;
            checkBoxEdit.Text = "Редактировать";
            checkBoxEdit.UseVisualStyleBackColor = true;
            // 
            // checkBoxExport
            // 
            checkBoxExport.AutoSize = true;
            checkBoxExport.Location = new System.Drawing.Point(298, 3);
            checkBoxExport.Name = "checkBoxExport";
            checkBoxExport.Size = new System.Drawing.Size(74, 20);
            checkBoxExport.TabIndex = 1;
            checkBoxExport.Text = "Экспорт";
            checkBoxExport.UseVisualStyleBackColor = true;
            // 
            // checkBoxSearch
            // 
            checkBoxSearch.AutoSize = true;
            checkBoxSearch.Location = new System.Drawing.Point(378, 3);
            checkBoxSearch.Name = "checkBoxSearch";
            checkBoxSearch.Size = new System.Drawing.Size(62, 20);
            checkBoxSearch.TabIndex = 0;
            checkBoxSearch.Text = "Поиск";
            checkBoxSearch.UseVisualStyleBackColor = true;
            // 
            // checkBoxExplor
            // 
            checkBoxExplor.AutoSize = true;
            checkBoxExplor.Location = new System.Drawing.Point(3, 29);
            checkBoxExplor.Name = "checkBoxExplor";
            checkBoxExplor.Size = new System.Drawing.Size(125, 20);
            checkBoxExplor.TabIndex = 2;
            checkBoxExplor.Text = "Открыть проекта";
            checkBoxExplor.UseVisualStyleBackColor = true;
            // 
            // AddUserForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(955, 494);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Margin = new System.Windows.Forms.Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddUserForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Добавлять / редактировать  категорию";
            TopMost = true;
            FormClosed += AddUserForm_FormClosed;
            Load += AddCategoryForm_Load;
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            groupBox3.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            groupBox4.ResumeLayout(false);
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonSaveAndClose;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.CheckBox checkBoxSupplier;
        private System.Windows.Forms.CheckBox checkBoxCustomer;
        private System.Windows.Forms.CheckBox checkBoxHome;
        private System.Windows.Forms.CheckBox checkBoxCategory;
        private System.Windows.Forms.CheckBox checkBoxProjects;
        private System.Windows.Forms.CheckBox checkBoxUsers;
        private System.Windows.Forms.CheckBox checkBoxSettings;
        private System.Windows.Forms.CheckBox checkBoxSystemRecord;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.CheckBox checkBoxAccessCategory;
        private System.Windows.Forms.CheckBox checkBoxAccessSupplier;
        private System.Windows.Forms.CheckBox checkBoxAccessCustomer;
        private System.Windows.Forms.CheckBox checkBoxAccessProject;
        private System.Windows.Forms.CheckBox checkBoxAccessUsers;
        private System.Windows.Forms.CheckBox checkBoxAccessOutcome;
        private System.Windows.Forms.CheckBox checkBoxAccessIncome;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.CheckBox checkBoxAdd;
        private System.Windows.Forms.CheckBox checkBoxEdit;
        private System.Windows.Forms.CheckBox checkBoxDelete;
        private System.Windows.Forms.CheckBox checkBoxSearch;
        private System.Windows.Forms.CheckBox checkBoxExport;
        private System.Windows.Forms.CheckBox checkBoxExplor;
        private System.Windows.Forms.Label label8;
    }
}