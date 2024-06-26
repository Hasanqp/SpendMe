﻿using SpendMe.Code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpendMe.Gui;
using System.Diagnostics;
namespace SpendMe
{
    public partial class Main : Form
    {
        private readonly PageManager pageManager;
        public Main()
        {
            InitializeComponent();
            pageManager = new PageManager(this);
            SetRoles();
            // Load Home Page
            pageManager.LoadPage(Gui.GuiHome.HomeUserControl.Instance());

        }

        #region #region Events

        private void buttonHome_Click(object sender, EventArgs e)
        {
            // Load HomeUserControl
            pageManager.LoadPage(Gui.GuiHome.HomeUserControl.Instance());
        }

        private void buttonCategory_Click(object sender, EventArgs e)
        {
            // Load Categories Page
            pageManager.LoadPage(Gui.GuiCategries.CategoryUserControl.Instance());
        }

        private void buttonCustomers_Click(object sender, EventArgs e)
        {
            // Load Customers Page
            pageManager.LoadPage(Gui.GuiCustomers.CustomersUserControl.Instance());
        }

        private void buttonSuppliers_Click(object sender, EventArgs e)
        {
            // Load Supliers Page
            pageManager.LoadPage(Gui.GuiSuppliers.SuppliersUserControl.Instance());
        }

        private void buttonProjects_Click(object sender, EventArgs e)
        {
            // Load Projects Page
            pageManager.LoadPage(Gui.GuiProjects.ProjectsUserControl.Instance());
        }

        private void buttonUsers_Click(object sender, EventArgs e)
        {
            // Load Buttons Page 
            pageManager.LoadPage(Gui.GuiUsers.UsersControl.Instance());
        }

        private void SetRoles()
        {
            if (!UsersRolesManager.GetRole("checkBoxHome"))
            {
                buttonHome.Visible = false;
            }
            if (!UsersRolesManager.GetRole("checkBoxCategory"))
            {
                buttonCategory.Visible = false;
            }
            if (!UsersRolesManager.GetRole("checkBoxSupplier"))
            {
                buttonSuppliers.Visible = false;
            }
            if (!UsersRolesManager.GetRole("checkBoxCustomer"))
            {
                buttonCustomers.Visible = false;
            }
            if (!UsersRolesManager.GetRole("checkBoxProjects"))
            {
                buttonProjects.Visible = false;
            }
            if (!UsersRolesManager.GetRole("checkBoxUsers"))
            {
                buttonUsers.Visible = false;
            }
            if (!UsersRolesManager.GetRole("checkBoxSettings"))
            {
                buttonSettings.Visible = false;
            }
            if (!UsersRolesManager.GetRole("checkBoxSystemRecord"))
            {
                buttonSystemRecords.Visible = false;
            }
        }
        #endregion

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            Gui.GuiSettings.SettingsForm settingsForm = new Gui.GuiSettings.SettingsForm(false);
            settingsForm.Show();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Gui.GuiUsers.UserLoginForm loginForm = new Gui.GuiUsers.UserLoginForm();
            loginForm.Show();
            Hide();
        }

        private void buttonSystemRecords_Click(object sender, EventArgs e)
        {
            // Load SystemRecords Page
            pageManager.LoadPage(Gui.GuiSystemRecords.RecordsUserControl.Instance());
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            Gui.GuiAbout.About about = new Gui.GuiAbout.About();
            about.Show();
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            var url = "https://www.youtube.com/";
            Process.Start(new ProcessStartInfo { FileName = url, UseShellExecute = true});
        }
    }
}
