using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FurnitureManager.Models;

namespace FurnitureManager.UnitTest.Models
{
    [TestClass]
    public class ProductTests
    {
        [TestMethod]
        public void Test()
        {
            int ID = 0;
            string Title = "masa";
            string Description = "lemn";
            string Color = "negru";
            string Size = "20";
            int Price = 300;
            int Stock = 5;
            Product product = new Product();
        }
    }
}