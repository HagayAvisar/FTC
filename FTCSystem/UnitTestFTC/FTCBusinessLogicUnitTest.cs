using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestFTC
{
    [TestClass]
    public class FTCBusinessLogicUnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var BL = new FTCBL.FTCBusinessLogic();

            FTCBL.model.Item item = new FTCBL.model.Item()
            {
                InStock = 1,
                IsItPublishOnWebPage = true,
                ItemType ="Nacklace",
                ItemCode = "Blabla",
                Material ="M1",
                Plated = "P1",
                UnitPriceUSD = 4,
                PriceOnWebPage = 100,
                ImageName ="Image1",
                Stones = "Swarovski",                

            };

            BL.InsertItemInToInventory(item);
        }
    }
}

