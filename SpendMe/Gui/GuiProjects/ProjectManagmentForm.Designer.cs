namespace SpendMe.Gui.GuiProjects
{
    partial class ProjectManagmentForm
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
            labelIncome = new System.Windows.Forms.Label();
            labelOutcome = new System.Windows.Forms.Label();
            labelRev = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            panelIncome = new System.Windows.Forms.Panel();
            panelOutcome = new System.Windows.Forms.Panel();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(labelIncome);
            panel1.Controls.Add(labelOutcome);
            panel1.Controls.Add(labelRev);
            panel1.Controls.Add(label1);
            panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel1.Location = new System.Drawing.Point(0, 597);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1064, 84);
            panel1.TabIndex = 0;
            // 
            // labelIncome
            // 
            labelIncome.BackColor = System.Drawing.Color.FromArgb(128, 128, 255);
            labelIncome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            labelIncome.Dock = System.Windows.Forms.DockStyle.Right;
            labelIncome.Location = new System.Drawing.Point(488, 0);
            labelIncome.Name = "labelIncome";
            labelIncome.Size = new System.Drawing.Size(192, 84);
            labelIncome.TabIndex = 1;
            labelIncome.Text = "Снять : 00000";
            labelIncome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelOutcome
            // 
            labelOutcome.BackColor = System.Drawing.Color.FromArgb(255, 224, 192);
            labelOutcome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            labelOutcome.Dock = System.Windows.Forms.DockStyle.Right;
            labelOutcome.Location = new System.Drawing.Point(680, 0);
            labelOutcome.Name = "labelOutcome";
            labelOutcome.Size = new System.Drawing.Size(192, 84);
            labelOutcome.TabIndex = 2;
            labelOutcome.Text = "Траты : 00000";
            labelOutcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelRev
            // 
            labelRev.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            labelRev.Dock = System.Windows.Forms.DockStyle.Right;
            labelRev.Location = new System.Drawing.Point(872, 0);
            labelRev.Name = "labelRev";
            labelRev.Size = new System.Drawing.Size(192, 84);
            labelRev.TabIndex = 3;
            labelRev.Text = "Доходы : 00000";
            labelRev.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label1.BackColor = System.Drawing.Color.FromArgb(255, 192, 128);
            label1.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(0, 1);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(441, 81);
            label1.TabIndex = 0;
            label1.Text = "Управление расходами средств по проекту";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panelIncome, 0, 0);
            tableLayoutPanel1.Controls.Add(panelOutcome, 1, 0);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new System.Drawing.Size(1064, 597);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // panelIncome
            // 
            panelIncome.Dock = System.Windows.Forms.DockStyle.Fill;
            panelIncome.Location = new System.Drawing.Point(3, 3);
            panelIncome.Name = "panelIncome";
            panelIncome.Size = new System.Drawing.Size(526, 591);
            panelIncome.TabIndex = 0;
            // 
            // panelOutcome
            // 
            panelOutcome.Dock = System.Windows.Forms.DockStyle.Fill;
            panelOutcome.Location = new System.Drawing.Point(535, 3);
            panelOutcome.Name = "panelOutcome";
            panelOutcome.Size = new System.Drawing.Size(526, 591);
            panelOutcome.TabIndex = 1;
            // 
            // ProjectManagmentForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1064, 681);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Margin = new System.Windows.Forms.Padding(4);
            Name = "ProjectManagmentForm";
            ShowIcon = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Управление проектом";
            TopMost = true;
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            Activated += ProjectManagmentForm_Activated;
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelIncome;
        private System.Windows.Forms.Panel panelOutcome;
        private System.Windows.Forms.Label labelIncome;
        private System.Windows.Forms.Label labelRev;
        private System.Windows.Forms.Label labelOutcome;
    }
}