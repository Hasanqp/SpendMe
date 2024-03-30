using SpendMe.Code;
using SpendMe.Core;
using SpendMe.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SpendMe.Gui.GuiProjects
{
    public partial class ProjectManagmentForm : Form
    {
        private readonly int projectId;
        private readonly IDataHelper<Core.Income> dataHelperIncome;
        private readonly IDataHelper<Core.Outcome> dataHelperOutcome;
        private double TotalIncome;
        private double TotalOutcome;
        public ProjectManagmentForm(int ProjectId)
        {
            dataHelperIncome = (IDataHelper<Income>)ConfigrationObjectManager.GetObject("Income");
            dataHelperOutcome = (IDataHelper<Outcome>)ConfigrationObjectManager.GetObject("Outcome");
            InitializeComponent();
            projectId = ProjectId;
            LoadOutComeUI();
            LoadInComeUI();
        }

        private void LoadOutComeUI()
        {
            // Load Outcome UI
            GuiOutcome.OutcomeUserControl outcomeUserControl = new GuiOutcome.OutcomeUserControl(projectId);
            outcomeUserControl.Dock = DockStyle.Fill;
            panelOutcome.Controls.Add(outcomeUserControl);
        }

        private void LoadInComeUI()
        {
            // Load InCome UI
            GuiIncome.IncomeUserControl incomeUserControl = new GuiIncome.IncomeUserControl(projectId);
            incomeUserControl.Dock = DockStyle.Fill;
            panelIncome.Controls.Add(incomeUserControl);
        }

        private void ProjectManagmentForm_Activated(object sender, EventArgs e)
        {
            GetTotalData();
        }

        private void GetTotalData()
        {
            // Get Data
            try
            {
                TotalIncome = dataHelperIncome.GetAllData()
                    .Where(x => x.ProjectId == projectId).Select(x => x.Amount).ToArray().Sum();
                TotalOutcome = dataHelperOutcome.GetAllData()
                    .Where(x => x.ProjectId == projectId).Select(x => x.Amount).ToArray().Sum();
            }
            catch { }
            var Rev = TotalIncome - TotalOutcome;

            // Set Data to UI
            labelIncome.Text = "Снять:" + TotalIncome.ToString("#0.00");
            labelOutcome.Text = "Траты:" + TotalOutcome.ToString("#0.00");
            labelRev.Text = "Доходы:" + Rev.ToString("#0.00");
        }
    }
}
