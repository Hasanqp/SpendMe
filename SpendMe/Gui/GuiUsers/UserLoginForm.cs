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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpendMe.Gui.GuiUsers
{
    public partial class UserLoginForm : Form
    {
        // Variables
        private readonly int ID;
        private readonly UsersControl categoryUserControl;
        private Users users;
        private readonly IDataHelper<Users> dataHelper;
        private readonly IDataHelper<UsersRoles> dataHelperUsersRoles;
        private readonly GuiLoading.LoadingForm loadingForm;
        private readonly IDataHelper<SystemRecords> dataHelperSystemRecords;
        private Dictionary<string, bool> ListOfRoles = new Dictionary<string, bool>();



        public UserLoginForm()
        {
            InitializeComponent();
            dataHelper = (IDataHelper<Users>)ConfigrationObjectManager.GetObject("Users");
            dataHelperUsersRoles = (IDataHelper<UsersRoles>)ConfigrationObjectManager.GetObject("UsersRoles");
            dataHelperSystemRecords = (IDataHelper<SystemRecords>)ConfigrationObjectManager.GetObject("SystemRecords");
            loadingForm = new GuiLoading.LoadingForm();

        }

        #region Events

        private async void buttonSave_Click(object sender, EventArgs e)
        {
            // Check fileds empty
            if (IsFiledsEmpty())
            {
                MessageCollections.ShowFiledsRquired();
            }
            else
            {
                var userName = textBoxUserName.Text;
                var password = textBoxPassword.Text;
                loadingForm.Show();
                var UserLoginResult = await Task.Run(() => Login(userName, password));
                if (UserLoginResult == 1)
                {
                    Main main = new Main();
                    main.Show();
                    Hide();
                }
                else if (UserLoginResult == 2)
                {
                    MessageCollections.ShowErrorServer();
                }
                else
                {
                    MessageBox.Show("Ошибка в данных для входа");
                }
                loadingForm.Hide();
            }
        }

        private void AddCategoryForm_Load(object sender, EventArgs e)
        {
        }
        #endregion

        #region Methods

        private bool IsFiledsEmpty()
        {
            if (
                   textBoxUserName.Text == string.Empty
                || textBoxPassword.Text == string.Empty
                )
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private int Login(string UserName, string Password)
        {
            try
            {
                // check
                Users user = dataHelper.GetAllData().Where(x => x.UserName == UserName && x.Password == Password).FirstOrDefault();
                if (user != null)
                {
                    Properties.Settings.Default.UserName = user.FullName;
                    Properties.Settings.Default.Save();
                    // Get Roles
                    var ListRoles = dataHelperUsersRoles.GetAllData().Where(x => x.UserId == user.Id);
                    // Loop into List of Roles
                    UsersRolesManager.ClearRoles();
                    foreach (var item in ListRoles)
                    {
                        UsersRolesManager.Register(item.Key, item.Value);
                    }

                    // Save System Records
                    SystemRecords systemRecords = new SystemRecords
                    {
                        Title = "Авторизоваться",
                        UserName = Properties.Settings.Default.UserName,
                        Details = "Пользователь вошел в систему" + user.UserName,
                        AddedDate = DateTime.Now
                    };
                    dataHelperSystemRecords.Add(systemRecords);
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            catch
            {
                return 2;
            }
        }

        #endregion

        private void UserLoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
