using DocumentFormat.OpenXml.Drawing.Spreadsheet;
using DocumentFormat.OpenXml.ExtendedProperties;
using SpendMe.Code;
using SpendMe.Core;
using SpendMe.Data;
using SpendMe.Gui.GuiCategries;
using SpendMe.Gui.GuiSuppliers;
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

namespace SpendMe.Gui.GuiOutcome
{
    public partial class AddOutcomeForm : Form
    {
        // Variables
        private readonly int ID;
        private readonly OutcomeUserControl categoryUserControl;
        private Outcome outcome;
        private int CategoryId;
        private int SupplierId;
        private int ProjectId;
        private readonly IDataHelper<Outcome> dataHelper;
        private readonly IDataHelper<Suppliers> dataHelperSuppliers;
        private readonly IDataHelper<Categories> dataHelperCategories;
        private readonly GuiLoading.LoadingForm loadingForm;
        private readonly IDataHelper<SystemRecords> dataHelperSystemRecords;


        public AddOutcomeForm(int Id, int ProjectId, OutcomeUserControl categoryUserControl)
        {
            InitializeComponent();
            dataHelper = (IDataHelper<Outcome>)ConfigrationObjectManager.GetObject("Outcome");
            dataHelperSuppliers = (IDataHelper<Suppliers>)ConfigrationObjectManager.GetObject("Suppliers");
            dataHelperCategories = (IDataHelper<Categories>)ConfigrationObjectManager.GetObject("Categories");
            dataHelperSystemRecords = (IDataHelper<SystemRecords>)ConfigrationObjectManager.GetObject("SystemRecords");

            loadingForm = new GuiLoading.LoadingForm();
            this.ID = Id;
            this.categoryUserControl = categoryUserControl;
            this.ProjectId = ProjectId;
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
                var SupplierName = comboBoxsupplier.SelectedItem.ToString();
                var CategoryName = comboBoxCategory.SelectedItem.ToString();
                await Task.Run(() => SetCategoryId(CategoryName));
                await Task.Run(() => SetSupplierId(SupplierName));

                return await AddData();
            }
            // Edit
            else
            {
                var SupplierName = comboBoxsupplier.SelectedItem.ToString();
                var CategoryName = comboBoxCategory.SelectedItem.ToString();
                await Task.Run(() => SetCategoryId(CategoryName));
                await Task.Run(() => SetSupplierId(SupplierName));

                return await EditData();
            }
        }

        private bool IsFiledsEmpty()
        {
            if (comboBoxCategory.SelectedItem == null ||
                comboBoxsupplier.SelectedItem == null ||
                textBoxAmount.Text == string.Empty
                )
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
            outcome = new Outcome
            {
                CategoryName = comboBoxCategory.SelectedItem.ToString(),
                SupplierName = comboBoxsupplier.SelectedItem.ToString(),
                RecNo = textBoxRecNo.Text,
                Details = richTextBoxDetails.Text,
                Amount = Convert.ToDouble(textBoxAmount.Text),
                OutcomeDate = dateTimePickerDate.Value,
                CategoryId = CategoryId,
                SupplierId = SupplierId,
                ProjectId = ProjectId
            };
            // sumbit
            var result = await dataHelper.AddAsync(outcome);
            if (result == 1)
            {
                // Save System Records
                SystemRecords systemRecords = new SystemRecords
                {
                    Title = "Добавлены траты",
                    UserName = Properties.Settings.Default.UserName,
                    Details = "Эти траты были добавлены" + outcome.CategoryName,
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
            outcome = new Outcome
            {
                Id = ID,
                CategoryName = comboBoxCategory.SelectedItem.ToString(),
                SupplierName = comboBoxsupplier.SelectedItem.ToString(),
                RecNo = textBoxRecNo.Text,
                Details = richTextBoxDetails.Text,
                Amount = Convert.ToDouble(textBoxAmount.Text),
                OutcomeDate = dateTimePickerDate.Value,
                CategoryId = CategoryId,
                SupplierId = SupplierId,
                ProjectId = ProjectId
            };
            // sumbit
            var result = await dataHelper.EditAsync(outcome);
            if (result == 1)
            {
                // Save System Records
                SystemRecords systemRecords = new SystemRecords
                {
                    Title = "Редактировать траты",
                    UserName = Properties.Settings.Default.UserName,
                    Details = "Эти траты были изменени" + outcome.CategoryName,
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

        private void textBoxBalance_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SetCategoryId(string CategoryName)
        {
            CategoryId = dataHelperCategories.GetAllData().Where(x => x.Name == CategoryName)
                .Select(x => x.Id).First();
        }

        private void SetSupplierId(string SupplierName)
        {
            SupplierId = dataHelperSuppliers.GetAllData().Where(x => x.Name == SupplierName)
                .Select(x => x.Id).First();
        }

        private async void SetFiledData()
        {
            // Get List of Suppliers
            var ListSuppliers = await dataHelperSuppliers.GetAllDataAsync();
            comboBoxsupplier.DataSource = ListSuppliers.Select(x => x.Name).ToList(); // Fill
                                                                                      // Auto Complete
            AutoCompleteStringCollection autoCompleteString = new AutoCompleteStringCollection();
            autoCompleteString.AddRange(ListSuppliers.Select(x => x.Name).ToArray());
            comboBoxsupplier.AutoCompleteCustomSource = autoCompleteString;

            ListSuppliers.Clear(); // clear

            // Get List of Categories
            var ListCategories = await dataHelperCategories.GetAllDataAsync();
            comboBoxCategory.DataSource = ListCategories.Select(x => x.Name).ToList(); // Fill
                                                                                       // Auto Complete
            AutoCompleteStringCollection autoCompleteStringCategories = new AutoCompleteStringCollection();
            autoCompleteStringCategories.AddRange(ListCategories.Select(x => x.Name).ToArray());
            comboBoxsupplier.AutoCompleteCustomSource = autoCompleteStringCategories;

            ListCategories.Clear(); // clear

            if (ID > 0)
            {
                // Set Filed
                outcome = await dataHelper.FindAsync(ID);
                if (outcome != null)
                {
                    comboBoxCategory.SelectedItem = outcome.CategoryName;
                    comboBoxsupplier.SelectedItem = outcome.SupplierName;
                    textBoxRecNo.Text = outcome.RecNo;
                    richTextBoxDetails.Text = outcome.Details;
                    textBoxAmount.Text = outcome.Amount.ToString();
                    dateTimePickerDate.Value = outcome.OutcomeDate;
                    CategoryId = outcome.CategoryId;
                    SupplierId = outcome.SupplierId;
                    ProjectId = outcome.ProjectId;
                }
                else
                {
                    MessageCollections.ShowErrorServer();
                }

            }
        }

        private async void linkLabelNewCategoryWither_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddCategoryForm addCategoryForm = new AddCategoryForm(0, new CategoryUserControl());
            var result = addCategoryForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                // Get List of Categories
                var ListCategories = await dataHelperCategories.GetAllDataAsync();
                comboBoxCategory.DataSource = ListCategories.Select(x => x.Name).ToList(); // Fill
                                                                                           // Auto Complete
                AutoCompleteStringCollection autoCompleteStringCategories = new AutoCompleteStringCollection();
                autoCompleteStringCategories.AddRange(ListCategories.Select(x => x.Name).ToArray());
                comboBoxsupplier.AutoCompleteCustomSource = autoCompleteStringCategories;

                ListCategories.Clear(); // clear
            }

        }

        private async void linkLabelNewSupplier_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddSuppliersForm addSuppliersForm = new AddSuppliersForm(0, new SuppliersUserControl());
            var result = addSuppliersForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                // Get List of Suppliers
                var ListSuppliers = await dataHelperSuppliers.GetAllDataAsync();
                comboBoxsupplier.DataSource = ListSuppliers.Select(x => x.Name).ToList(); // Fill
                                                                                          // Auto Complete
                AutoCompleteStringCollection autoCompleteString = new AutoCompleteStringCollection();
                autoCompleteString.AddRange(ListSuppliers.Select(x => x.Name).ToArray());
                comboBoxsupplier.AutoCompleteCustomSource = autoCompleteString;

                ListSuppliers.Clear(); // clear
            }
        }
    }
}
#endregion