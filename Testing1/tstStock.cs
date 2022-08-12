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
        //Find Method//

        [TestMethod]
        public void FindMethodOK()
        {
            clsStock AStock = new clsStock();
            Boolean Found = false;
            Int32 StockID = 1;
            Found = AStock.Find(StockID);
            Assert.IsTrue(Found);
        }

        [TestMethod]

        public void TestStockIDFound()
        {
            clsStock AStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StockID = 1;
            Found = AStock.Find(StockID);
            if (AStock.StockID != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void TestStockNameFound()
        {
            clsStock AStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StockID = 1;
            Found = AStock.Find(StockID);
            if (AStock.StockName != "Nike")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void TestStockQuantityFound()
        {
            clsStock AStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StockID = 1;
            Found = AStock.Find(StockID);
            if (AStock.StockQuantity != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void DateAddedFound()
        {
            clsStock AStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StockID = 1;
            Found = AStock.Find(StockID);
            if (AStock.DateAdded != Convert.ToDateTime("01/04/2022"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void TestPriceFound()
        {
            clsStock AStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StockID = 1;
            Found = AStock.Find(StockID);
            if (AStock.Price != 20)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void TestStockAvailableFound()
        {
            clsStock AStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StockID = 1;
            Found = AStock.Find(StockID);
            if (AStock.StockAvailable != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]

        public void TestTotalStockSoldFound()
        {
            clsStock AStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StockID = 1;
            Found = AStock.Find(StockID);
            if (AStock.StockTotalSold != 20)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    }
    }
