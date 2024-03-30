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
using System.Windows.Forms;

namespace SpendMe.Gui.GuiIncome
{
    public partial class IncomeUserControl : UserControl
    {
        // Variables
        private readonly IDataHelper<Income> dataHelper;
        private readonly IDataHelper<SystemRecords> dataHelperSystemRecords;
        private static IncomeUserControl _IncomeUserControl;
        private int RowId;
        private readonly GuiLoading.LoadingForm loadingForm;
        private List<int> IdList = new List<int>();
        private string SearchItem;
        private int ProjectId;

        // Constructors
        public IncomeUserControl(int ProjectId)
        {
            InitializeComponent();
            this.ProjectId = ProjectId;
            dataHelper = (IDataHelper<Income>)ConfigrationObjectManager.GetObject("Income");
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
            AddIncomeForm addIncomeForm = new AddIncomeForm(0, ProjectId, this);
            addIncomeForm.Show();
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
                                    Details = "Процесс снятия номера было удалено" + RowId.ToString(),
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

        private void buttonOpen_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Methods

        
        public async void LoadData()
        {
            loadingForm.Show();
            var data = await dataHelper.GetAllDataAsync();
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
            dataGridView1.Columns[1].HeaderText = "Категория";
            dataGridView1.Columns[2].HeaderText = "Клиент";
            dataGridView1.Columns[3].HeaderText = "История снята";
            dataGridView1.Columns[4].HeaderText = "Серийный номер";
            dataGridView1.Columns[5].HeaderText = "Сумма";
            dataGridView1.Columns[6].HeaderText = "Детали";

            // Hide
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[11].Visible = false;
            dataGridView1.Columns[12].Visible = false;

        }

        private void Edit()
        {
            if (dataGridView1.RowCount > 0)
            {
                // Get Id
                RowId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                AddIncomeForm addIncomeForm = new AddIncomeForm(0, ProjectId, this);
                addIncomeForm.Show();
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
            dataTable.Columns["CategoryName"].SetOrdinal(1);
            dataTable.Columns["CategoryName"].ColumnName = "Категория";
            dataTable.Columns["SupplierName"].SetOrdinal(2);
            dataTable.Columns["SupplierName"].ColumnName = "Клиент";
            dataTable.Columns["IncomeDate"].SetOrdinal(3);
            dataTable.Columns["IncomeDate"].ColumnName = "История";
            dataTable.Columns["RecNo"].SetOrdinal(4);
            dataTable.Columns["RecNo"].ColumnName = "Серийный номер";
            dataTable.Columns["Amount"].SetOrdinal(5);
            dataTable.Columns["Amount"].ColumnName = "Сумма";
            dataTable.Columns["Details"].SetOrdinal(6);
            dataTable.Columns["Details"].ColumnName = "Детали";
            dataTable.Columns["CategoryId"].SetOrdinal(7);
            dataTable.Columns["CategoryId"].ColumnName = "CategoryId";
            dataTable.Columns["SupplierId"].SetOrdinal(8);
            dataTable.Columns["SupplierId"].ColumnName = "SupplierId";
            dataTable.Columns["ProjectId"].SetOrdinal(9);
            dataTable.Columns["ProjectId"].ColumnName = "ProjectId";

            // hide
            dataTable.Columns.Remove("CategoryId");
            dataTable.Columns.Remove("SupplierId");
            dataTable.Columns.Remove("ProjectId");
            dataTable.AcceptChanges();
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
        #endregion
    }
}
