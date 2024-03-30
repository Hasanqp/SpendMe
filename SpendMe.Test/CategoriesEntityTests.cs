using Microsoft.VisualStudio.TestTools.UnitTesting;
using SpendMe.Core;
using SpendMe.Data;
using SpendMe.Data.SqlServer;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpendMe.Tests
{
    [TestClass]
    public class CategoriesEntityTests
    {
        IDataHelper<Categories> dataHelper;
        public CategoriesEntityTests() 
        {
            dataHelper = new CategoriesEntity();
        }

        [TestMethod]
        public void AddTest()
        {
            // Arrange ( Set )
            Categories categories = new Categories
            {
                Name= "Анализ",
                Details= "Классификация для анализа проекта",
                Type= "Тратить",
                Balance=1000,
                AddedDAte=DateTime.Now,
            };
            // Act and expt ( Get )

            int act = dataHelper.Add(categories);
            int expt = 1;
            // Assert ( Test )
            Assert.AreEqual(expt, act);
        }
        [TestMethod]
        public void EditTest()
        {
            // Arrange ( Set )
            Categories categories = new Categories
            {
                Id= 1,
                Name = "Разработка проекта",
                Details = "Классификация для проектирования проекта",
                Type = "Тратить",
                Balance = 2000,
                AddedDAte = DateTime.Now,
            };
            // Act and expt ( Get )

            int act = dataHelper.Edit(categories);
            int expt = 1;
            // Assert ( Test )
            Assert.AreEqual(expt, act);
        }
        [TestMethod]
        public void GetAllDataTest()
        {
            // Arrange ( Set )

            // Act and expt ( Get )

            var act = dataHelper.GetAllData();
            // Assert ( Test )
            Assert.IsNotNull(act);
        }
        [TestMethod]
        public void SearchTest()
        {
            // Arrange ( Set )
            var searchitem = "Разработка проекта";
            // Act and expt ( Get )

            var act = dataHelper.Search(searchitem);
            // Assert ( Test )
            Assert.IsNotNull(act);
        }
        [TestMethod]
        public void FindTest()
        {
            // Arrange ( Set )
            var Id = 1;
            // Act and expt ( Get )

            var act = dataHelper.Find(1);
            // Assert ( Test )
            Assert.IsNotNull(act);
        }
        [TestMethod]
        public void DeleteTest()
        {
            // Arrange ( Set )
            var Id = 1;
            // Act and expt ( Get )

            var act = dataHelper.Delete(1);
            // Assert ( Test )
            Assert.AreEqual (1, act);
        }
    }
}
