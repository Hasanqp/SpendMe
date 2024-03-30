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

namespace SpendMe.Gui.GuiCategries
{
    public partial class AddCategoryForm : Form
    {
        // Variables
        private readonly int ID;
        private readonly CategoryUserControl categoryUserControl;
        private Categories categories;
        private readonly IDataHelper<Categories> dataHelper;
        private readonly GuiLoading.LoadingForm loadingForm;
        private readonly IDataHelper<SystemRecords> dataHelperSystemRecords;


        public AddCategoryForm(int Id, CategoryUserControl categoryUserControl)
        {
            InitializeComponent();
            dataHelper = (IDataHelper<Categories>)ConfigrationObjectManager.GetObject("Categories");
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
            if (textBoxName.Text == string.Empty || comboBoxType.Text == string.Empty)
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
            categories = new Categories
            {
                Name = textBoxName.Text,
                Type = comboBoxType.SelectedItem.ToString(),
                Details = richTextBoxDetails.Text,
                AddedDAte = DateTime.Now,
            };
            // sumbit
            var result = await dataHelper.AddAsync(categories);
            if (result == 1)
            {
                // Save System Records
                SystemRecords systemRecords = new SystemRecords
                {
                    Title = "Добавить категорию",
                    UserName = Properties.Settings.Default.UserName,
                    Details = "Этот Категория добавлена" + categories.Name,
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
            categories = new Categories
            {
                Id = ID,
                Name = textBoxName.Text,
                Type = comboBoxType.SelectedItem.ToString(),
                Details = richTextBoxDetails.Text,
                AddedDAte = DateTime.Now,
            };
            // sumbit
            var result = await dataHelper.EditAsync(categories);
            if (result == 1)
            {
                // Save System Records
                SystemRecords systemRecords = new SystemRecords
                {
                    Title = "Редактировать категорию",
                    UserName = Properties.Settings.Default.UserName,
                    Details = "Этот Категория был изменен" + categories.Name,
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
                categories = await dataHelper.FindAsync(ID);
                if (categories != null)
                {
                    textBoxName.Text = categories.Name;
                    textBoxBalance.Text = categories.Balance.ToString();
                    comboBoxType.SelectedItem = categories.Type;
                    richTextBoxDetails.Text = categories.Details;
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
