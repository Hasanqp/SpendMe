using ClosedXML.Excel;
using DocumentFormat.OpenXml.Drawing.Diagrams;
using DocumentFormat.OpenXml.Spreadsheet;
using SpendMe.Code;
using SpendMe.Core;
using SpendMe.Data;
using SpendMe.Gui.GuiHome;
using SpendMe.Gui.GuiLoading;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpendMe.Gui.GuiSuppliers
{
    public partial class SuppliersUserControl : UserControl
    {
        // Variables
        private readonly IDataHelper<Suppliers> dataHelper;
        private IDataHelper<Outcome> dataHelperOutcome;
        private readonly IDataHelper<SystemRecords> dataHelperSystemRecords;
        private static SuppliersUserControl _SuppliersUserControl;
        private int RowId;
        private readonly GuiLoading.LoadingForm loadingForm;
        private List<int> IdList = new List<int>();
        private string SearchItem;
        private double OutcomeAmount;

        // Constructors
        public SuppliersUserControl()
        {
            InitializeComponent();
            dataHelper = (IDataHelper<Suppliers>)ConfigrationObjectManager.GetObject("Suppliers");
            dataHelperOutcome = (IDataHelper<Outcome>)ConfigrationObjectManager.GetObject("Outcome");
            dataHelperSystemRecords = (IDataHelper<SystemRecords>)ConfigrationObjectManager.GetObject("SystemRecords");
            loadingForm = new GuiLoading.LoadingForm();
            LoadData();
        }
        #region Events
        private async void comboBoxPageNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadingForm.Show();
            var data = await dataHelper.GetAllDataAsync();
            var dataId = data.Select(x => x.Id).ToArray();
            int index = comboBoxPageNo.SelectedIndex;
            int IndexNoOfRow = index * Properties.Settings.Default.DataGridViewRowNo;

            dataGridView1.DataSource = data.Where(x => x.Id >= dataId[IndexNoOfRow]).Take(Properties.Settings.Default.DataGridViewRowNo).ToList();
            if (dataGridView1.DataSource == null)
            {
                MessageCollections.ShowErrorServer();
            }
            else
            {
                SetColumnsTitle();
            }
            loadingForm.Hide();
            data.Clear();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddSuppliersForm addSuppliersForm = new AddSuppliersForm(0, this);
            addSuppliersForm.Show();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            Edit();
        }

        private async void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0)
            {
                var Deleteresult = MessageCollections.ShowDeleteDialog();
                if (Deleteresult)
                {
                    IdList.Clear();
                    SetIdRowForDelete();
                    loadingForm.Show();
                    if (IdList.Count > 0)
                    {
                        for (int i = 0; i < IdList.Count; i++)
                        {
                            RowId = IdList[i];
                            var result = await dataHelper.DeleteAsync(RowId);
                            if (result == 1)
                            {
                                // Save System Records
                                SystemRecords systemRecords = new SystemRecords
                                {
                                    Title = "Удаление операции",
                                    UserName = Properties.Settings.Default.UserName,
                                    Details = "поставщик с идентификационным номером был удален №" + RowId.ToString(),
                                    AddedDate = DateTime.Now
                                };
                                await dataHelperSystemRecords.AddAsync(systemRecords);

                                //
                                MessageCollections.ShowDeleteNotification();
                            }
                            else
                            {
                                MessageCollections.ShowErrorServer();
                            }
                        }
                        LoadData();
                    }
                    else
                    {
                        MessageCollections.ShowRquiredDeleteRow();
                    }
                }
                loadingForm.Hide();
            }
            else
            {
                MessageCollections.ShowEmptyDataMessage();
            }

        }

        private async void buttonExport_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            // Convert List of Data to DataTable
            loadingForm.Show();
            var data = await dataHelper.GetAllDataAsync();
            using (var reader = FastMember.ObjectReader.Create(data))
            {
                dataTable.Load(reader);
            }
            loadingForm.Hide();
            // Re-Set Columns
            DataTable dataTableArranged = SetDataTableColumns(dataTable);
            // Export Data to as sheet Excel
            ExportAsXlsxFile(dataTableArranged);
        }


        private void buttonSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Edit();
        }

        #endregion

        #region Methods
        public static SuppliersUserControl Instance()
        {
            return _SuppliersUserControl ?? (new SuppliersUserControl());
        }

        public async void LoadData()
        {
            loadingForm.Show();
            var data = await dataHelper.GetAllDataAsync();
            var LIstOfSuppliersId = data.Select(x => x.Id).ToList();
            await Task.Run(() => UpdateData(LIstOfSuppliersId));
            dataGridView1.DataSource = data.Take(Properties.Settings.Default.DataGridViewRowNo).ToList();

            // Add No of page into combo box
            comboBoxPageNo.Items.Clear();
            double value = (Convert.ToDouble(data.Count) / Convert.ToDouble(Properties.Settings.Default.DataGridViewRowNo));
            int NoOfPage = (int)Math.Round(value, MidpointRounding.AwayFromZero);

            for (int i = 0; i < NoOfPage; i++)
            {
                comboBoxPageNo.Items.Add(i);
            }
            //

            if (dataGridView1.DataSource == null)
            {
                MessageCollections.ShowErrorServer();
            }
            else
            {
                SetColumnsTitle();
            }
            loadingForm.Hide();
            data.Clear();
        }

        private void SetColumnsTitle()
        {
            dataGridView1.Columns[0].HeaderText = "Id";
            dataGridView1.Columns[1].HeaderText = "Имя";
            dataGridView1.Columns[2].HeaderText = "Номер телефона";
            dataGridView1.Columns[3].HeaderText = "Адрес";
            dataGridView1.Columns[4].HeaderText = "Электронная почта";
            dataGridView1.Columns[5].HeaderText = "детали";
            dataGridView1.Columns[6].HeaderText = "Баланс";
            dataGridView1.Columns[7].HeaderText = "Время добавления";
        }

        private void Edit()
        {
            if (dataGridView1.RowCount > 0)
            {
                // Get Id
                RowId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                AddSuppliersForm addSuppliersForm = new AddSuppliersForm(RowId, this);
                addSuppliersForm.Show();
            }
            else
            {
                MessageCollections.ShowEmptyDataMessage();
            }
        }

        private void SetIdRowForDelete()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Selected)
                {
                    IdList.Add(Convert.ToInt32(row.Cells[0].Value));
                }
            }

        }

        public async void Search()
        {
            loadingForm.Show();
            SearchItem = textBoxSearch.Text;
            dataGridView1.DataSource = await dataHelper.SearchAsync(SearchItem);
            if (dataGridView1.DataSource == null)
            {
                MessageCollections.ShowErrorServer();
            }
            else
            {
                SetColumnsTitle();
            }
            loadingForm.Hide();
        }

        private DataTable SetDataTableColumns(DataTable dataTable)
        {
            dataTable.Columns["Id"].SetOrdinal(0);
            dataTable.Columns["Id"].ColumnName = "Id";
            dataTable.Columns["Name"].SetOrdinal(1);
            dataTable.Columns["Name"].ColumnName = "Имя";
            dataTable.Columns["PhoneNumber"].SetOrdinal(2);
            dataTable.Columns["PhoneNumber"].ColumnName = "Номер телефона";
            dataTable.Columns["Address"].SetOrdinal(3);
            dataTable.Columns["Address"].ColumnName = "Адрес";
            dataTable.Columns["Email"].SetOrdinal(4);
            dataTable.Columns["Email"].ColumnName = "Электронная почта";
            dataTable.Columns["Details"].SetOrdinal(5);
            dataTable.Columns["Details"].ColumnName = "детали";
            dataTable.Columns["Balance"].SetOrdinal(6);
            dataTable.Columns["Balance"].ColumnName = "Баланс";
            dataTable.Columns["AddedDate"].SetOrdinal(7);
            dataTable.Columns["AddedDate"].ColumnName = "Время добавления";
            return dataTable;
        }

        private void ExportAsXlsxFile(DataTable dataTableArranged)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Экспортируйте файл в формате Excel";
            saveFileDialog.DefaultExt = "xlsx";
            saveFileDialog.AddExtension = true;
            saveFileDialog.Filter = "Excel File (.xlsx)|*.xlsx";
            saveFileDialog.RestoreDirectory = true;
            var result = saveFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    using (XLWorkbook xLWorkbook = new XLWorkbook()) // Creat Excel File
                    {
                        xLWorkbook.AddWorksheet(dataTableArranged, "Data"); // Add Sheet
                        using (MemoryStream ma = new MemoryStream())
                        {
                            xLWorkbook.SaveAs(ma);
                            File.WriteAllBytes(saveFileDialog.FileName, ma.ToArray());
                        }
                    }
                    System.Diagnostics.Process.Start(saveFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void UpdateData(List<int> LIstOfSuppliersId)
        {
            // Get Data

            // Loop into CategoriesId for Income тратиты
            for (int i = 0; i < LIstOfSuppliersId.Count; i++)
            {
                var SupplierId = LIstOfSuppliersId[i];
                try
                {
                    OutcomeAmount = dataHelperOutcome.GetAllData()
                    .Where(x => x.SupplierId == SupplierId)
                    .Select(x => x.Amount).ToArray().Sum();
                }
                catch { }
                // Set Data for both
                Suppliers suppliers = dataHelper.GetAllData()
                    .Where(x => x.Id == SupplierId).First();
                suppliers.Balance = OutcomeAmount;

                dataHelper.Edit(suppliers);
            }
        }
        #endregion
    }
}
