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

namespace SpendMe.Gui.GuiSuppliers
{
    public partial class AddSuppliersForm : Form
    {
        // Variables
        private readonly int ID;
        private readonly SuppliersUserControl categoryUserControl;
        private Suppliers suppliers;
        private readonly IDataHelper<Suppliers> dataHelper;
        private readonly GuiLoading.LoadingForm loadingForm;
        private readonly IDataHelper<SystemRecords> dataHelperSystemRecords;


        public AddSuppliersForm(int Id, SuppliersUserControl categoryUserControl)
        {
            InitializeComponent();
            dataHelper = (IDataHelper<Suppliers>)ConfigrationObjectManager.GetObject("Suppliers");
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
            suppliers = new Suppliers
            {
                Name = textBoxName.Text,
                Address = textBoxAddress.Text,
                PhoneNumber = textBoxPhoneNumber.Text,
                Details = richTextBoxDetails.Text,
                AddedDate = DateTime.Now,
                Email = textBoxEmail.Text,
            };
            // sumbit
            var result = await dataHelper.AddAsync(suppliers);
            if (result == 1)
            {
                // Save System Records
                SystemRecords systemRecords = new SystemRecords
                {
                    Title = "Добавить поставщика",
                    UserName = Properties.Settings.Default.UserName,
                    Details = "Этот поставщика добавлен" + suppliers.Name,
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
            suppliers = new Suppliers
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
            var result = await dataHelper.EditAsync(suppliers);
            if (result == 1)
            {
                // Save System Records
                SystemRecords systemRecords = new SystemRecords
                {
                    Title = "Редактировать поставщика",
                    UserName = Properties.Settings.Default.UserName,
                    Details = "Этот поставщик был изменен" + suppliers.Name,
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
            if (ID > 0)
            {
                // Set Filed
                suppliers = await dataHelper.FindAsync(ID);
                if (suppliers != null)
                {
                    textBoxName.Text = suppliers.Name;
                    textBoxEmail.Text = suppliers.Email;
                    textBoxPhoneNumber.Text = suppliers.PhoneNumber;
                    textBoxAddress.Text = suppliers.Address;
                    textBoxBalance.Text = suppliers.Balance.ToString();
                    richTextBoxDetails.Text = suppliers.Details;
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
