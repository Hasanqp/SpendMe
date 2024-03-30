using SpendMe.Code;
using SpendMe.Core;
using SpendMe.Data;
using SpendMe.Gui.GuiCategries;
using SpendMe.Gui.GuiCustomers;
using SpendMe.Gui.GuiIncome;
using SpendMe.Gui.GuiOutcome;
using SpendMe.Gui.GuiProjects;
using SpendMe.Gui.GuiSuppliers;
using SpendMe.Gui.GuiUsers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SpendMe.Gui.GuiHome
{
    public partial class HomeUserControl : UserControl
    {
        private static HomeUserControl _HomeUserControl;
        private readonly IDataHelper<Projects> dataHelper;

        public int ProjectId { get; private set; }

        public HomeUserControl()
        {
            InitializeComponent();
            dataHelper = (IDataHelper<Projects>)ConfigrationObjectManager.GetObject("Projects");
            SetRoles();
            SetGeneralSettings();
            SetHello();
        }

        public static HomeUserControl Instance()
        {
            return _HomeUserControl ?? (new HomeUserControl());
        }

        private void SetRoles()
        {
            if (!UsersRolesManager.GetRole("checkBoxAccessCategory"))
            {
                buttonAddCategory.Visible = false;
            }
            if (!UsersRolesManager.GetRole("checkBoxAccessSupplier"))
            {
                buttonAddSupplier.Visible = false;
            }
            if (!UsersRolesManager.GetRole("checkBoxAccessCustomer"))
            {
                buttonAddCustomer.Visible = false;
            }
            if (!UsersRolesManager.GetRole("checkBoxAccessProject"))
            {
                buttonAddProject.Visible = false;
            }
            if (!UsersRolesManager.GetRole("checkBoxAccessOutcome"))
            {
                buttonAddOutput.Visible = false;
            }
            if (!UsersRolesManager.GetRole("checkBoxAccessIncome"))
            {
                buttonAddInput.Visible = false;
            }
            if (!UsersRolesManager.GetRole("checkBoxUsers"))
            {
                buttonAddUser.Visible = false;
            }
        }
        private void SetGeneralSettings()
        {
            labelCompanyName.Text = Properties.Settings.Default.CompanyName;

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

        private void SetHello()
        {
            labelWellcome.Text = "Еще раз здравствуйте." + Properties.Settings.Default.UserName;
        }

        private void buttonAddCategory_Click(object sender, EventArgs e)
        {
            AddCategoryForm addCategoryForm = new AddCategoryForm(0, new CategoryUserControl());
            addCategoryForm.Show();
        }

        private void buttonAddCustomer_Click(object sender, EventArgs e)
        {
            AddCustomersForm addCustomersForm = new AddCustomersForm(0, new CustomersUserControl());
            addCustomersForm.Show();
        }

        private void buttonAddSupplier_Click(object sender, EventArgs e)
        {
            AddSuppliersForm addSuppliersForm = new AddSuppliersForm(0, new SuppliersUserControl());
            addSuppliersForm.Show();
        }

        private void buttonAddProject_Click(object sender, EventArgs e)
        {
            AddProjectForm addProjectsForm = new AddProjectForm(0, new ProjectsUserControl());
            addProjectsForm.Show();
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            AddUserForm addCategoryForm = new AddUserForm(0, new UsersControl(), false);
            addCategoryForm.Show();
        }

        private async void HomeUserControl_Load(object sender, EventArgs e)
        {
            // Get List of Suppliers
            var ListProjects = await dataHelper.GetAllDataAsync();
            comboBoxProjects.DataSource = ListProjects.Select(x => x.Name).ToList(); // Fill
                                                                                     // Auto Complete
            AutoCompleteStringCollection autoCompleteString = new AutoCompleteStringCollection();
            autoCompleteString.AddRange(ListProjects.Select(x => x.Name).ToArray());
            comboBoxProjects.AutoCompleteCustomSource = autoCompleteString;

            ListProjects.Clear(); // clear
        }

        private void comboBoxProjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            var projectName = comboBoxProjects.SelectedItem.ToString();
            ProjectId = dataHelper.GetAllData().Where(X => X.Name == projectName).Select(x => x.Id).FirstOrDefault();
        }

        private void buttonAddOutput_Click(object sender, EventArgs e)
        {
            if (ProjectId > 0)
            {
                AddOutcomeForm addOutcomeForm = new AddOutcomeForm(0, ProjectId, new OutcomeUserControl(ProjectId));
                addOutcomeForm.Show();
            }
            else
            {
                MessageBox.Show("Выберите проект");
            }
        }

        private void buttonAddInput_Click(object sender, EventArgs e)
        {
            if (ProjectId > 0)
            {
                AddIncomeForm addIncomeForm = new AddIncomeForm(0, ProjectId, new IncomeUserControl(ProjectId));
                addIncomeForm.Show();
            }
            else
            {
                MessageBox.Show("Выберите проект");
            }
        }
    }
}
