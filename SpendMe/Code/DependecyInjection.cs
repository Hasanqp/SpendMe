using SpendMe.Data.SqlServer;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace SpendMe.Code
{
    public static class DependecyInjection
    {
        public static void AddDependencyValues()
        {
            ConfigrationObjectManager.Register("Categories", new CategoriesEntity());
            ConfigrationObjectManager.Register("SystemRecords", new SystemRecordsEntity());
            ConfigrationObjectManager.Register("Customers", new CustomersEntity());
            ConfigrationObjectManager.Register("Suppliers", new SuppliersEntity());
            ConfigrationObjectManager.Register("Projects", new ProjectsEntity());
            ConfigrationObjectManager.Register("Outcome", new OutcomeEntity());
            ConfigrationObjectManager.Register("Income", new IncomeEntity());
            ConfigrationObjectManager.Register("Users", new UsersEntity());
            ConfigrationObjectManager.Register("UsersRoles", new UsersRolesRolesEntity());
        }
    }
}
