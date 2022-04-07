using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassDemoUnitTest.model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestTest
{
    [TestClass]
    public class UnitTestItemKatalog
    {
        
        [TestMethod]
        [DataRow(40, 0)]
        [DataRow(35,1)]
        [DataRow(10, 5)]
        public void TestGetPricesOK(double price, int expectedNumber)
        {
            //Arrange
            ItemKatalog kat = new ItemKatalog();


            //Act
            List<Item> liste = kat.GetItemsOverPrice(price);

            //Asset
            Assert.AreEqual(expectedNumber, liste.Count);
        }


        [TestMethod]
        [DataRow(-0.001)]
        public void TestGetPricesNotOK(double price)
        {
            //Arrange
            ItemKatalog kat = new ItemKatalog();


            //Act
           

            //Asset
            Assert.ThrowsException<ArgumentException>(() => kat.GetItemsOverPrice(price));
        }
    }
}
