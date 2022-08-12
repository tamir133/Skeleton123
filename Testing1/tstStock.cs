using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void TestMethod1()
        {
            clsStock AStock = new clsStock();
            Assert.IsNotNull(AStock);
        }

        [TestMethod]

        public void StockIDOK()
        {
            clsStock AStock = new clsStock();
            Int32 TestData = 1;
            AStock.StockID = TestData;
            Assert.AreEqual(AStock.StockID, TestData);
        }

        [TestMethod]

        public void StockNameOK()
        {
            clsStock AStock = new clsStock();
            String TestData = "Nike";
            AStock.StockName = TestData;
            Assert.AreEqual(AStock.StockName, TestData);
        }

        [TestMethod]

        public void StockQuantityOK()
        {
            clsStock AStock = new clsStock();
            Int32 TestData = 1;
            AStock.StockQuantity = TestData;
            Assert.AreEqual(AStock.StockQuantity, TestData);
        }
        [TestMethod]

        public void StockTotalSoldOK()
        {
            clsStock AStock = new clsStock();
            Int32 TestData = 1;
            AStock.StockTotalSold = TestData;
            Assert.AreEqual(AStock.StockTotalSold, TestData);
        }

        [TestMethod]

        public void DateAddedOK()
        {
            clsStock AStock = new clsStock();
            DateTime TestData = DateTime.Now.Date;
            AStock.DateAdded = TestData;
            Assert.AreEqual(AStock.DateAdded, TestData);
        }
        [TestMethod]
        public void PriceOK()
        {
            clsStock AStock = new clsStock();
            Decimal TestData = 20;
            AStock.Price = TestData;
            Assert.AreEqual(AStock.Price, TestData);
        }

        [TestMethod]

        public void StockAvailableOK()
        {
            clsStock AStock = new clsStock();
            Boolean TestData = true;
            AStock.StockAvailable = TestData;
            Assert.AreEqual(AStock.StockAvailable, TestData);
        }
    }
}
