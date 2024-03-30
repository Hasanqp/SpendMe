using Microsoft.Data.SqlClient;
using SpendMe.Code;
using SpendMe.Data.SqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpendMe
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DependecyInjection.AddDependencyValues();
            SqlCon.SqlConnection = Properties.Settings.Default.SqlServerString;
            Application.Run(new StartForm());
        }
    }
}
