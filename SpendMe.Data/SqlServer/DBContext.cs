using Microsoft.EntityFrameworkCore;
using SpendMe.Core;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace SpendMe.Data.SqlServer
{
    public class DBContext:DbContext
    {
        public DBContext()
        {

        }

        // Set ConString
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

           // var sqlcon = @"Server=.\SQLEXPRESS;Database=SpendMeDatabase;Trusted_Connection=True;"; // For Test

            // optionsBuilder.UseSqlServer(sqlcon);
            optionsBuilder.UseSqlServer(SqlCon.SqlConnection);
        }
        // Tables
        public DbSet<Categories> Categories { get; set; }
        public DbSet<SystemRecords> SystemRecords { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Suppliers> Suppliers { get; set; }
        public DbSet<Projects> Projects { get; set; }
        public DbSet<Outcome> Outcome { get; set; }
        public DbSet<Income> Income { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<UsersRoles> UsersRoles { get; set; }
    }
}
