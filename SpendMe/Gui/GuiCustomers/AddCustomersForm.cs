using DocumentFormat.OpenXml.Drawing.Spreadsheet;
using SpendMe.Code;
using SpendMe.Core;
using SpendMe.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpendMe.Gui.GuiCustomers
{
    public partial class AddCustomersForm : Form
    {
        // Variables
        private readonly int ID;
        private readonly CustomersUserControl customersUserControl;
        private Customers customers;
        private readonly IDataHelper<Customers> dataHelper;
        private readonly GuiLoading.LoadingForm loadingForm;
        private readonly IDataHelper<SystemRecords> dataHelperSystemRecords;


        public AddCustomersForm(int Id, CustomersUserControl customersUserControl)
        {
            InitializeComponent();
            dataHelper = (IDataHelper<Customers>)ConfigrationObjectManager.GetObject("Customers");
            dataHelperSystemRecords = (IDataHelper<SystemRecords>)ConfigrationObjectManager.GetObject("SystemRecords");
            loadingForm = new GuiLoading.LoadingForm();
            this.ID = Id;
            this.customersUserControl = customersUserControl;
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
                        this.DialogResult = DialogResult.OK;
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
                        this.DialogResult = DialogResult.OK;
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
            customers = new Customers
            {
                Name = textBoxName.Text,
                Address = textBoxAddress.Text,
                PhoneNumber = textBoxPhoneNumber.Text,
                Details = richTextBoxDetails.Text,
                AddedDate = DateTime.Now,
                Email = textBoxEmail.Text,
            };
            // sumbit
            var result = await dataHelper.AddAsync(customers);
            if (result == 1)
            {
                // Save System Records
                SystemRecords systemRecords = new SystemRecords
                {
                    Title = "Добавить клиента",
                    UserName = Properties.Settings.Default.UserName,
                    Details = "Этот Клиент добавлен" + customers.Name,
                    AddedDate = DateTime.Now
                };
                await dataHelperSystemRecords.AddAsync(systemRecords);
                customersUserControl.LoadData();
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
            customers = new Customers
            {
                Id = ID,
                Name = textBoxName.Text,
                Address = textBoxAddress.Text,
                PhoneNumber = textBoxPhoneNumber.Text,
                Details = richTextBoxDetails.Text,
                AddedDate = DateTime.Now,
                Email = textBoxEmail.Text,
            };
            // sumbit
            var result = await dataHelper.EditAsync(customers);
            if (result == 1)
            {
                // Save System Records
                SystemRecords systemRecords = new SystemRecords
                {
                    Title = "Редактировать клиента",
                    UserName = Properties.Settings.Default.UserName,
                    Details = "Этот Клиент был изменен" + customers.Name,
                    AddedDate = DateTime.Now
                };
                await dataHelperSystemRecords.AddAsync(systemRecords);
                // Toast 
                customersUserControl.LoadData();
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
            if (ID > 0)
            {
                // Set Filed
                customers = await dataHelper.FindAsync(ID);
                if (customers != null)
                {
                    textBoxName.Text = customers.Name;
                    textBoxEmail.Text = customers.Email;
                    textBoxPhoneNumber.Text = customers.PhoneNumber;
                    textBoxAddress.Text = customers.Address;
                    textBoxBalance.Text = customers.Balance.ToString();
                    richTextBoxDetails.Text = customers.Details;
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
