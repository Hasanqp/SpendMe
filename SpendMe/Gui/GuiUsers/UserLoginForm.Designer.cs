namespace SpendMe.Gui.GuiUsers
{
    partial class UserLoginForm
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
            buttonLogin = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            textBoxUserName = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            textBoxPassword = new System.Windows.Forms.TextBox();
            groupBox1 = new System.Windows.Forms.GroupBox();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label8 = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonLogin);
            panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel1.Location = new System.Drawing.Point(0, 446);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(442, 48);
            panel1.TabIndex = 0;
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = System.Drawing.Color.White;
            buttonLogin.Image = Properties.Resources.icons8_login_24;
            buttonLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            buttonLogin.Location = new System.Drawing.Point(5, 5);
            buttonLogin.Margin = new System.Windows.Forms.Padding(5);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new System.Drawing.Size(424, 39);
            buttonLogin.TabIndex = 5;
            buttonLogin.Text = "     Войти";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonSave_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 320);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(144, 18);
            label2.TabIndex = 0;
            label2.Text = "Имя пользователя";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(12, 372);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(63, 18);
            label4.TabIndex = 0;
            label4.Text = "Пароль";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = System.Drawing.Color.Red;
            label3.Location = new System.Drawing.Point(152, 320);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(14, 18);
            label3.TabIndex = 0;
            label3.Text = "*";
            // 
            // textBoxUserName
            // 
            textBoxUserName.Location = new System.Drawing.Point(181, 318);
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.Size = new System.Drawing.Size(248, 29);
            textBoxUserName.TabIndex = 1;
            textBoxUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = System.Drawing.Color.Red;
            label6.Location = new System.Drawing.Point(77, 373);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(14, 18);
            label6.TabIndex = 0;
            label6.Text = "*";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new System.Drawing.Point(181, 371);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new System.Drawing.Size(248, 29);
            textBoxPassword.TabIndex = 2;
            textBoxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(textBoxPassword);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(textBoxUserName);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label8);
            groupBox1.Location = new System.Drawing.Point(0, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(439, 440);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Информация о пользователе";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.Color.White;
            pictureBox1.Image = Properties.Resources.lockunlock_conv_200px_150px;
            pictureBox1.Location = new System.Drawing.Point(147, 35);
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
            label8.Location = new System.Drawing.Point(107, 196);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(223, 22);
            label8.TabIndex = 0;
            label8.Text = "Еще раз здравствуйте";
            // 
            // UserLoginForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(442, 494);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Margin = new System.Windows.Forms.Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "UserLoginForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Войдите с SpendMe";
            FormClosed += UserLoginForm_FormClosed;
            Load += AddCategoryForm_Load;
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
    }
}