using SpendMe.Data.SqlServer;
using SpendMe.Gui.GuiLoading;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpendMe.Gui.GuiSettings
{
    public partial class SettingsForm : Form
    {
        private LoadingForm loding;
        private readonly bool firstStart;

        public SettingsForm(bool FirstStart)
        {
            InitializeComponent();
            SetGeneralSettings();
            loding = new LoadingForm();
            firstStart = FirstStart;
        }

        private void buttonSaveGeneralSettings_Click(object sender, EventArgs e)
        {
            SaveGeneralSettings();
        }

        private void SaveGeneralSettings()
        {
            Properties.Settings.Default.CompanyName = textBoxCompany.Text;
            Properties.Settings.Default.HideNotificationInterval = Convert.ToInt32(numericUpDownNotification.Value);
            Properties.Settings.Default.DataGridViewRowNo = Convert.ToInt32(numericUpDownDataRow.Value);

            // Save Picture
            using (MemoryStream ma = new MemoryStream())
            {
                pictureBoxLogo.Image.Save(ma, System.Drawing.Imaging.ImageFormat.Png);
                Properties.Settings.Default.CompanyLogo = Convert.ToBase64String(ma.ToArray());
            }
            // Save Settings
            Properties.Settings.Default.Save();
            MessageBox.Show("Настройки успешно сохранены");

        }

        private void SetGeneralSettings()
        {
            textBoxCompany.Text = Properties.Settings.Default.CompanyName;
            numericUpDownNotification.Value = Convert.ToInt32(Properties.Settings.Default.HideNotificationInterval / 1000);
            numericUpDownDataRow.Value = Properties.Settings.Default.DataGridViewRowNo;

            // Set Picture
            if (Properties.Settings.Default.CompanyLogo != string.Empty) // check if first open
            {
                var ImageAsByte = Convert.FromBase64String(Properties.Settings.Default.CompanyLogo); // Convert string to byte
                using (MemoryStream ma = new MemoryStream(ImageAsByte))
                {
                    pictureBoxLogo.Image = Image.FromStream(ma);  // Set picture
                }
            }

        }

        private void buttonSaveConString_Click(object sender, EventArgs e)
        {
            var Server = textBoxServer.Text;
            var DataBase = textBoxDataBase.Text;
            var Timout = numericUpDownTimeout.Value;
            var UserName = textBoxUserName.Text;
            var Password = textBoxPassword.Text;
            if (radioButtonLocalCon.Checked == true)
            {
                // Local Con
                SetLocalCon(Server, DataBase);
            }
            else
            {
                // Network Con
                SetNetWorkCon(Server, DataBase, UserName, Password, Timout);
            }

            MessageBox.Show("Текст подключения успешно сохранен, Перезапустите программу");
            Application.Exit();
        }

        private void SetNetWorkCon(string server, string dataBase, string userName, string password, decimal timout)
        {
            var ConString = @"Server= " + server + ";Database=" + dataBase + ";User Id=" + userName + ";Password=myPassword" + password + ";Timeout=" + timout + "";
            Properties.Settings.Default.SqlServerString = ConString;
            // Save Settings
            Properties.Settings.Default.Save();
        }

        private void SetLocalCon(string server, string dataBase)
        {
            var ConString = @"Server=" + server + ";Database=" + dataBase + ";Trusted_Connection=True;";
            Properties.Settings.Default.SqlServerString = ConString;
            // Save Settings
            Properties.Settings.Default.Save();
        }

        private void SettingsForm_Activated(object sender, EventArgs e)
        {
        }

        private void radioButtonLocalCon_CheckedChanged(object sender, EventArgs e)
        {
            textBoxUserName.Enabled = false;
            textBoxPassword.Enabled = false;
            numericUpDownTimeout.Enabled = false;
        }

        private void radioButtonNetworkCon_CheckedChanged(object sender, EventArgs e)
        {
            textBoxUserName.Enabled = true;
            textBoxPassword.Enabled = true;
            numericUpDownTimeout.Enabled = true;

        }

        private void linkLabelImporimage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Выберите логотип компании";
            openFileDialog.RestoreDirectory = true;
            var result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                pictureBoxLogo.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void buttonBackUp_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.Description = "Выберите домен для сохранения резервной копии и избегайте выбора системного диска";
            var result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                BackUpRestoreHelper backUpRestoreHelper = new BackUpRestoreHelper();
                loding.Show();
                string processResult = backUpRestoreHelper.BackUp(folderBrowserDialog.SelectedPath);
                if (processResult == "1")
                {
                    loding.Hide();
                    MessageBox.Show("Операция резервного копирования была выполнена успешно");
                }
                else
                {
                    loding.Hide();
                    MessageBox.Show("Мы не смогли выполнить операцию резервного копирования из-за" + processResult);
                }
            }
        }

        private async void buttonRestore_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Выберите файл резервной копии";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.Filter = "Back File|*.bak";
            var result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                BackUpRestoreHelper backUpRestoreHelper = new BackUpRestoreHelper();
                loding.Show();
                string processResult = await Task.Run(() => backUpRestoreHelper.Restore(openFileDialog.FileName));
                if (processResult == "1")
                {
                    loding.Hide();
                    MessageBox.Show("Резервная копия была успешно восстановлена");
                }
                else
                {
                    loding.Hide();
                    MessageBox.Show("Мы не смогли восстановить резервную копии, потому что" + processResult);
                }
            }
        }

        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (firstStart == true)
            {
                Application.Exit();
            }
        }
    }
}
