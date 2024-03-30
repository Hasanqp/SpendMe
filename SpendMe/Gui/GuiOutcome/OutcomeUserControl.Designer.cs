namespace SpendMe.Gui.GuiOutcome
{
    partial class OutcomeUserControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            buttonAdd = new System.Windows.Forms.Button();
            buttonEdit = new System.Windows.Forms.Button();
            buttonDelete = new System.Windows.Forms.Button();
            buttonUpdate = new System.Windows.Forms.Button();
            buttonExport = new System.Windows.Forms.Button();
            panel1 = new System.Windows.Forms.Panel();
            textBoxSearch = new System.Windows.Forms.TextBox();
            buttonSearch = new System.Windows.Forms.Button();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            comboBoxPageNo = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            flowLayoutPanel1.Controls.Add(buttonAdd);
            flowLayoutPanel1.Controls.Add(buttonEdit);
            flowLayoutPanel1.Controls.Add(buttonDelete);
            flowLayoutPanel1.Controls.Add(buttonUpdate);
            flowLayoutPanel1.Controls.Add(buttonExport);
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new System.Drawing.Size(846, 65);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = System.Drawing.Color.White;
            buttonAdd.Image = Properties.Resources.icons8_add2_32_px;
            buttonAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            buttonAdd.Location = new System.Drawing.Point(2, 2);
            buttonAdd.Margin = new System.Windows.Forms.Padding(2);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new System.Drawing.Size(103, 58);
            buttonAdd.TabIndex = 0;
            buttonAdd.Text = "   Добавлять";
            buttonAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.BackColor = System.Drawing.Color.White;
            buttonEdit.Image = Properties.Resources.icons8_edit_32_px;
            buttonEdit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            buttonEdit.Location = new System.Drawing.Point(109, 2);
            buttonEdit.Margin = new System.Windows.Forms.Padding(2);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new System.Drawing.Size(131, 58);
            buttonEdit.TabIndex = 1;
            buttonEdit.Text = "      Редактировать";
            buttonEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            buttonEdit.UseVisualStyleBackColor = false;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = System.Drawing.Color.White;
            buttonDelete.Image = Properties.Resources.icons8_delete_32_px;
            buttonDelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            buttonDelete.Location = new System.Drawing.Point(244, 2);
            buttonDelete.Margin = new System.Windows.Forms.Padding(2);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new System.Drawing.Size(88, 58);
            buttonDelete.TabIndex = 2;
            buttonDelete.Text = "Удалить";
            buttonDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackColor = System.Drawing.Color.White;
            buttonUpdate.Image = Properties.Resources.icons8_update_CUC_32_px;
            buttonUpdate.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            buttonUpdate.Location = new System.Drawing.Point(336, 2);
            buttonUpdate.Margin = new System.Windows.Forms.Padding(2);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new System.Drawing.Size(107, 58);
            buttonUpdate.TabIndex = 3;
            buttonUpdate.Text = "       Обновлять";
            buttonUpdate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonExport
            // 
            buttonExport.BackColor = System.Drawing.Color.White;
            buttonExport.Image = Properties.Resources.icons8_xls_export_32_px;
            buttonExport.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            buttonExport.Location = new System.Drawing.Point(447, 2);
            buttonExport.Margin = new System.Windows.Forms.Padding(2);
            buttonExport.Name = "buttonExport";
            buttonExport.Size = new System.Drawing.Size(94, 58);
            buttonExport.TabIndex = 4;
            buttonExport.Text = " Экспорт";
            buttonExport.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            buttonExport.UseVisualStyleBackColor = false;
            buttonExport.Click += buttonExport_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel1.Controls.Add(textBoxSearch);
            panel1.Controls.Add(buttonSearch);
            panel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            panel1.Location = new System.Drawing.Point(548, 6);
            panel1.Margin = new System.Windows.Forms.Padding(5, 6, 3, 3);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(292, 45);
            panel1.TabIndex = 5;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            textBoxSearch.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBoxSearch.Location = new System.Drawing.Point(40, 0);
            textBoxSearch.Margin = new System.Windows.Forms.Padding(0);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new System.Drawing.Size(250, 43);
            textBoxSearch.TabIndex = 7;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = System.Drawing.Color.CadetBlue;
            buttonSearch.Dock = System.Windows.Forms.DockStyle.Left;
            buttonSearch.FlatAppearance.BorderSize = 0;
            buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonSearch.ForeColor = System.Drawing.Color.White;
            buttonSearch.Image = Properties.Resources.icons8_search_32_px;
            buttonSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonSearch.Location = new System.Drawing.Point(0, 0);
            buttonSearch.Margin = new System.Windows.Forms.Padding(5);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new System.Drawing.Size(40, 43);
            buttonSearch.TabIndex = 6;
            buttonSearch.Text = "      Поиск";
            buttonSearch.UseVisualStyleBackColor = false;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridView1.Location = new System.Drawing.Point(0, 65);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new System.Drawing.Size(846, 549);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // comboBoxPageNo
            // 
            comboBoxPageNo.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            comboBoxPageNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxPageNo.FormattingEnabled = true;
            comboBoxPageNo.Location = new System.Drawing.Point(757, 583);
            comboBoxPageNo.Name = "comboBoxPageNo";
            comboBoxPageNo.Size = new System.Drawing.Size(87, 26);
            comboBoxPageNo.TabIndex = 3;
            comboBoxPageNo.SelectedIndexChanged += comboBoxPageNo_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.BackColor = System.Drawing.Color.FromArgb(255, 192, 128);
            label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(1, 584);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(102, 29);
            label1.TabIndex = 5;
            label1.Text = "Тратить";
            // 
            // OutcomeUserControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            Controls.Add(label1);
            Controls.Add(comboBoxPageNo);
            Controls.Add(dataGridView1);
            Controls.Add(flowLayoutPanel1);
            Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Margin = new System.Windows.Forms.Padding(4);
            Name = "OutcomeUserControl";
            Size = new System.Drawing.Size(846, 614);
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.ComboBox comboBoxPageNo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label label1;
    }
}
