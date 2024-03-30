namespace SpendMe
{
    partial class StartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            pictureBox1 = new System.Windows.Forms.PictureBox();
            progressBar1 = new System.Windows.Forms.ProgressBar();
            labelState = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.Color.White;
            pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            pictureBox1.Image = Properties.Resources.spend_management_definition_and_best_practices;
            pictureBox1.Location = new System.Drawing.Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(489, 239);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // progressBar1
            // 
            progressBar1.Location = new System.Drawing.Point(31, 266);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new System.Drawing.Size(419, 23);
            progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            progressBar1.TabIndex = 1;
            // 
            // labelState
            // 
            labelState.AutoSize = true;
            labelState.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelState.Location = new System.Drawing.Point(31, 245);
            labelState.Name = "labelState";
            labelState.Size = new System.Drawing.Size(53, 17);
            labelState.TabIndex = 2;
            labelState.Text = "Начало";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.FromArgb(255, 128, 0);
            label2.Location = new System.Drawing.Point(267, 292);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(181, 17);
            label2.TabIndex = 2;
            label2.Text = "Все права защищены 2023 г.";
            // 
            // StartForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.LightSteelBlue;
            ClientSize = new System.Drawing.Size(489, 325);
            Controls.Add(label2);
            Controls.Add(labelState);
            Controls.Add(progressBar1);
            Controls.Add(pictureBox1);
            Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4);
            Name = "StartForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label labelState;
        private System.Windows.Forms.Label label2;
    }
}