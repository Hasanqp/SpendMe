namespace SpendMe.Gui.GuiHome
{
    partial class HomeUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new System.Windows.Forms.Panel();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            groupBox1 = new System.Windows.Forms.GroupBox();
            buttonAddInput = new System.Windows.Forms.Button();
            buttonAddOutput = new System.Windows.Forms.Button();
            buttonAddUser = new System.Windows.Forms.Button();
            buttonAddProject = new System.Windows.Forms.Button();
            buttonAddSupplier = new System.Windows.Forms.Button();
            buttonAddCustomer = new System.Windows.Forms.Button();
            buttonAddCategory = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            pictureBoxLogo = new System.Windows.Forms.PictureBox();
            labelCompanyName = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            labelWellcome = new System.Windows.Forms.Label();
            panel3 = new System.Windows.Forms.Panel();
            comboBoxProjects = new System.Windows.Forms.ComboBox();
            label2 = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.SteelBlue;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel1.Location = new System.Drawing.Point(0, 323);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1048, 177);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.SpendMeLogo1;
            pictureBox1.Location = new System.Drawing.Point(340, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(100, 50);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            groupBox1.Controls.Add(buttonAddInput);
            groupBox1.Controls.Add(buttonAddOutput);
            groupBox1.Controls.Add(buttonAddUser);
            groupBox1.Controls.Add(buttonAddProject);
            groupBox1.Controls.Add(buttonAddSupplier);
            groupBox1.Controls.Add(buttonAddCustomer);
            groupBox1.Controls.Add(buttonAddCategory);
            groupBox1.Location = new System.Drawing.Point(3, 45);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(1042, 101);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Добавить";
            // 
            // buttonAddInput
            // 
            buttonAddInput.BackColor = System.Drawing.Color.White;
            buttonAddInput.Image = Properties.Resources.icons8_return_purchase_32_px;
            buttonAddInput.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonAddInput.Location = new System.Drawing.Point(885, 30);
            buttonAddInput.Margin = new System.Windows.Forms.Padding(5);
            buttonAddInput.Name = "buttonAddInput";
            buttonAddInput.Size = new System.Drawing.Size(146, 63);
            buttonAddInput.TabIndex = 1;
            buttonAddInput.Text = "    Снять";
            buttonAddInput.UseVisualStyleBackColor = false;
            buttonAddInput.Click += buttonAddInput_Click;
            // 
            // buttonAddOutput
            // 
            buttonAddOutput.BackColor = System.Drawing.Color.White;
            buttonAddOutput.Image = Properties.Resources.icons8_receive_32_px;
            buttonAddOutput.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonAddOutput.Location = new System.Drawing.Point(739, 30);
            buttonAddOutput.Margin = new System.Windows.Forms.Padding(5);
            buttonAddOutput.Name = "buttonAddOutput";
            buttonAddOutput.Size = new System.Drawing.Size(146, 63);
            buttonAddOutput.TabIndex = 1;
            buttonAddOutput.Text = "    Тратить";
            buttonAddOutput.UseVisualStyleBackColor = false;
            buttonAddOutput.Click += buttonAddOutput_Click;
            // 
            // buttonAddUser
            // 
            buttonAddUser.BackColor = System.Drawing.Color.White;
            buttonAddUser.Image = Properties.Resources.icons8_users_32_px;
            buttonAddUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonAddUser.Location = new System.Drawing.Point(590, 30);
            buttonAddUser.Margin = new System.Windows.Forms.Padding(5);
            buttonAddUser.Name = "buttonAddUser";
            buttonAddUser.Size = new System.Drawing.Size(149, 63);
            buttonAddUser.TabIndex = 1;
            buttonAddUser.Text = "       Пользователь";
            buttonAddUser.UseVisualStyleBackColor = false;
            buttonAddUser.Click += buttonAddUser_Click;
            // 
            // buttonAddProject
            // 
            buttonAddProject.BackColor = System.Drawing.Color.White;
            buttonAddProject.Image = Properties.Resources.icons8_projects_32_px;
            buttonAddProject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonAddProject.Location = new System.Drawing.Point(444, 30);
            buttonAddProject.Margin = new System.Windows.Forms.Padding(5);
            buttonAddProject.Name = "buttonAddProject";
            buttonAddProject.Size = new System.Drawing.Size(146, 63);
            buttonAddProject.TabIndex = 1;
            buttonAddProject.Text = "    Проект";
            buttonAddProject.UseVisualStyleBackColor = false;
            buttonAddProject.Click += buttonAddProject_Click;
            // 
            // buttonAddSupplier
            // 
            buttonAddSupplier.BackColor = System.Drawing.Color.White;
            buttonAddSupplier.Image = Properties.Resources.icons8_customers_32_px;
            buttonAddSupplier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonAddSupplier.Location = new System.Drawing.Point(298, 30);
            buttonAddSupplier.Margin = new System.Windows.Forms.Padding(5);
            buttonAddSupplier.Name = "buttonAddSupplier";
            buttonAddSupplier.Size = new System.Drawing.Size(146, 63);
            buttonAddSupplier.TabIndex = 1;
            buttonAddSupplier.Text = "    Поставщик";
            buttonAddSupplier.UseVisualStyleBackColor = false;
            buttonAddSupplier.Click += buttonAddSupplier_Click;
            // 
            // buttonAddCustomer
            // 
            buttonAddCustomer.BackColor = System.Drawing.Color.White;
            buttonAddCustomer.Image = Properties.Resources.icons8_customers_32_px__1_;
            buttonAddCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonAddCustomer.Location = new System.Drawing.Point(151, 31);
            buttonAddCustomer.Margin = new System.Windows.Forms.Padding(5);
            buttonAddCustomer.Name = "buttonAddCustomer";
            buttonAddCustomer.Size = new System.Drawing.Size(146, 63);
            buttonAddCustomer.TabIndex = 1;
            buttonAddCustomer.Text = "    Клиент   ";
            buttonAddCustomer.UseVisualStyleBackColor = false;
            buttonAddCustomer.Click += buttonAddCustomer_Click;
            // 
            // buttonAddCategory
            // 
            buttonAddCategory.BackColor = System.Drawing.Color.White;
            buttonAddCategory.Image = Properties.Resources.icons8_categorize_32_px;
            buttonAddCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonAddCategory.Location = new System.Drawing.Point(6, 30);
            buttonAddCategory.Margin = new System.Windows.Forms.Padding(5);
            buttonAddCategory.Name = "buttonAddCategory";
            buttonAddCategory.Size = new System.Drawing.Size(146, 63);
            buttonAddCategory.TabIndex = 1;
            buttonAddCategory.Text = "      Категория";
            buttonAddCategory.UseVisualStyleBackColor = false;
            buttonAddCategory.Click += buttonAddCategory_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.Black;
            label1.Location = new System.Drawing.Point(612, 10);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(216, 29);
            label1.TabIndex = 0;
            label1.Text = "Быстрый доступ";
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBoxLogo);
            panel2.Controls.Add(labelCompanyName);
            panel2.Location = new System.Drawing.Point(560, 39);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(487, 114);
            panel2.TabIndex = 1;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Dock = System.Windows.Forms.DockStyle.Left;
            pictureBoxLogo.Image = Properties.Resources.SpendMeLogo1;
            pictureBoxLogo.Location = new System.Drawing.Point(0, 0);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new System.Drawing.Size(100, 114);
            pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 1;
            pictureBoxLogo.TabStop = false;
            // 
            // labelCompanyName
            // 
            labelCompanyName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelCompanyName.ForeColor = System.Drawing.Color.Black;
            labelCompanyName.Location = new System.Drawing.Point(106, 0);
            labelCompanyName.Name = "labelCompanyName";
            labelCompanyName.Size = new System.Drawing.Size(381, 114);
            labelCompanyName.TabIndex = 0;
            labelCompanyName.Text = "qp компания контакт";
            labelCompanyName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.ForeColor = System.Drawing.Color.Black;
            label3.Location = new System.Drawing.Point(45, 39);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(381, 114);
            label3.TabIndex = 0;
            label3.Text = "University account";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelWellcome
            // 
            labelWellcome.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelWellcome.ForeColor = System.Drawing.Color.Black;
            labelWellcome.Location = new System.Drawing.Point(28, 39);
            labelWellcome.Name = "labelWellcome";
            labelWellcome.Size = new System.Drawing.Size(419, 114);
            labelWellcome.TabIndex = 0;
            labelWellcome.Text = "Еще раз здравствуйте. ";
            labelWellcome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            panel3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            panel3.Controls.Add(comboBoxProjects);
            panel3.Controls.Add(label2);
            panel3.Location = new System.Drawing.Point(337, 239);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(374, 82);
            panel3.TabIndex = 2;
            // 
            // comboBoxProjects
            // 
            comboBoxProjects.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            comboBoxProjects.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            comboBoxProjects.FormattingEnabled = true;
            comboBoxProjects.Location = new System.Drawing.Point(3, 49);
            comboBoxProjects.Name = "comboBoxProjects";
            comboBoxProjects.Size = new System.Drawing.Size(371, 26);
            comboBoxProjects.TabIndex = 16;
            comboBoxProjects.SelectedIndexChanged += comboBoxProjects_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.Black;
            label2.Location = new System.Drawing.Point(3, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(371, 35);
            label2.TabIndex = 0;
            label2.Text = "Проекты";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HomeUserControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(labelWellcome);
            Controls.Add(label3);
            Controls.Add(panel1);
            Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Margin = new System.Windows.Forms.Padding(4);
            Name = "HomeUserControl";
            Size = new System.Drawing.Size(1048, 500);
            Load += HomeUserControl_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAddCategory;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonAddCustomer;
        private System.Windows.Forms.Button buttonAddProject;
        private System.Windows.Forms.Button buttonAddSupplier;
        private System.Windows.Forms.Button buttonAddInput;
        private System.Windows.Forms.Button buttonAddOutput;
        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelCompanyName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelWellcome;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxProjects;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
    }
}
