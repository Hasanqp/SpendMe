using DocumentFormat.OpenXml.Drawing.Spreadsheet;
using DocumentFormat.OpenXml.ExtendedProperties;
using SpendMe.Code;
using SpendMe.Core;
using SpendMe.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SpendMe.Gui.GuiProjects
{
    public partial class AddProjectForm : Form
    {
        // Variables
        private readonly int ID;
        private readonly ProjectsUserControl categoryUserControl;
        private Projects projects;
        private readonly IDataHelper<Projects> dataHelper;
        private readonly IDataHelper<Customers> dataHelperCustmers;
        private readonly GuiLoading.LoadingForm loadingForm;
        private readonly IDataHelper<SystemRecords> dataHelperSystemRecords;


        public AddProjectForm(int Id, ProjectsUserControl categoryUserControl)
        {
            InitializeComponent();
            dataHelper = (IDataHelper<Projects>)ConfigrationObjectManager.GetObject("Projects");
            dataHelperCustmers = (IDataHelper<Customers>)ConfigrationObjectManager.GetObject("Customers");
            dataHelperSystemRecords = (IDataHelper<SystemRecords>)ConfigrationObjectManager.GetObject("SystemRecords");
            loadingForm = new GuiLoading.LoadingForm();
            this.ID = Id;
            this.categoryUserControl = categoryUserControl;

        }

        #region Events
        private async void buttonSaveAndClose_Click(object sender, EventArgs e)
        {
            // Check fileds empty
            if (IsFiledsEmpty())
            {
                MessageCollections.ShowFiledsRquired();
            }
            else
            {
                loadingForm.Show();
                if (await SaveData())
                {
                    if (ID == 0)
                    {
                        MessageCollections.ShowAddNotification();
                    }
                    else
                    {
                        MessageCollections.ShowUpdateNotification();
                    }
                    Close();
                }
                else
                {
                    MessageCollections.ShowErrorServer();
                }
                loadingForm.Hide();
            }
        }

        private async void buttonSave_Click(object sender, EventArgs e)
        {
            // Check fileds empty
            if (IsFiledsEmpty())
            {
                MessageCollections.ShowFiledsRquired();
            }
            else
            {
                loadingForm.Show();
                if (await SaveData())
                {
                    if (ID == 0)
                    {
                        MessageCollections.ShowAddNotification();
                    }
                    else
                    {
                        MessageCollections.ShowUpdateNotification();
                    }
                }
                else
                {
                    MessageCollections.ShowErrorServer();
                }
                loadingForm.Hide();
            }
        }

        private void AddCategoryForm_Load(object sender, EventArgs e)
        {
            loadingForm.Show();
            SetFiledData();
            loadingForm.Hide();
        }
        #endregion

        #region Methods

        private async Task<bool> SaveData()
        {
            // Add
            if (ID == 0)
            {
                return await AddData();
            }
            // Edit
            else
            {
                return await EditData();
            }
        }

        private bool IsFiledsEmpty()
        {
            if (textBoxName.Text == string.Empty)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private async Task<bool> AddData()
        {
            // Set Data
            projects = new Projects
            {
                Name = textBoxName.Text,
                Customer = comboBoxCustomer.Text,
                Company = textBoxCompany.Text,
                Address = textBoxAddress.Text,
                StartDate = dateTimePickerStart.Value,
                FinishDate = dateTimePickerFinish.Value,
                Details = richTextBoxDetails.Text,
                Income = Convert.ToDouble(textBoxIncome.Text),
                Outcome = Convert.ToDouble(textBoxOutcome.Text),
                Revenue = Convert.ToDouble(textBoxRevenue.Text),
                AddedDate = DateTime.Now,
            };
            // sumbit
            var result = await dataHelper.AddAsync(projects);
            if (result == 1)
            {
                // Save System Records
                SystemRecords systemRecords = new SystemRecords
                {
                    Title = "Добавить проект",
                    UserName = Properties.Settings.Default.UserName,
                    Details = "Этот проект был добавлен" + projects.Name,
                    AddedDate = DateTime.Now
                };
                await dataHelperSystemRecords.AddAsync(systemRecords);
                categoryUserControl.LoadData();
                // Toast
                return true;
            }
            else
            {
                return false;
            }
        }

        private async Task<bool> EditData()
        {
            // Set Data
            projects = new Projects
            {
                Id = ID,
                Name = textBoxName.Text,
                Customer = comboBoxCustomer.Text,
                Company = textBoxCompany.Text,
                Address = textBoxAddress.Text,
                StartDate = dateTimePickerStart.Value,
                FinishDate = dateTimePickerFinish.Value,
                Details = richTextBoxDetails.Text,
                Income = Convert.ToDouble(textBoxIncome.Text),
                Outcome = Convert.ToDouble(textBoxOutcome.Text),
                Revenue = Convert.ToDouble(textBoxRevenue.Text),
                AddedDate = DateTime.Now,
            };
            // sumbit
            var result = await dataHelper.EditAsync(projects);
            if (result == 1)
            {
                // Save System Records
                SystemRecords systemRecords = new SystemRecords
                {
                    Title = "Редактировать проект",
                    UserName = Properties.Settings.Default.UserName,
                    Details = "Этот проект был изменен" + projects.Name,
                    AddedDate = DateTime.Now
                };
                await dataHelperSystemRecords.AddAsync(systemRecords);
                // Toast 
                categoryUserControl.LoadData();
                return true;

            }
            else
            {
                return false;
            }
        }
        #endregion
        private async void SetFiledData()
        {
            // Get List of Customers
            var ListCustomers = await dataHelperCustmers.GetAllDataAsync();
            comboBoxCustomer.DataSource = ListCustomers.Select(x => x.Name).ToList(); // Fill
                                                                                      // Auto Complete
            AutoCompleteStringCollection autoCompleteString = new AutoCompleteStringCollection();
            autoCompleteString.AddRange(ListCustomers.Select(x => x.Name).ToArray());
            comboBoxCustomer.AutoCompleteCustomSource = autoCompleteString;

            ListCustomers.Clear(); // clear

            if (ID > 0)
            {
                // Set Fileds
                projects = await dataHelper.FindAsync(ID);
                if (projects != null)
                {
                    textBoxName.Text = projects.Name;
                    comboBoxCustomer.Text = projects.Customer;
                    textBoxCompany.Text = projects.Company;
                    dateTimePickerStart.Value = projects.StartDate;
                    dateTimePickerFinish.Value = projects.FinishDate;
                    textBoxAddress.Text = projects.Address;
                    richTextBoxDetails.Text = projects.Details;
                    textBoxIncome.Text = projects.Income.ToString();
                    textBoxOutcome.Text = projects.Outcome.ToString();
                    textBoxRevenue.Text = projects.Revenue.ToString();
                }
                else
                {
                    MessageCollections.ShowErrorServer();
                }

            }
        }

        private void textBoxBalance_TextChanged(object sender, EventArgs e)
        {

        }
        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
