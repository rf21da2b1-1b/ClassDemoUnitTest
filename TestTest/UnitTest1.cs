using System;
using ClassDemoUnitTest.model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow(0)]
        [DataRow(5)]
        [DataRow(10000)]
        public void TestIdOK(int value)
        {
            //Arrange
            Item i = new Item();
            int expectedId = value;

            //Act
            i.Id = value;

            //Asset
            Assert.AreEqual(expectedId, i.Id);
        }

        [TestMethod]
        [DataRow(-1)]
        [DataRow(10001)]
        public void TestIdNotOK(int value)
        {
            //Arrange
            Item i = new Item();
            

            //Act - se assert
            

            //Asset
            Assert.ThrowsException<ArgumentException>(() => i.Id = value);
        }

        [TestMethod]
        [DataRow(0)]
        [DataRow(5)]
        [DataRow(1000000)]
        public void TestPriceOK(double value)
        {
            //Arrange
            Item i = new Item();
            double expectedPrice = value;
            double delta = 0.00001; // tolerence til double for at der er ens

            //Act
            i.Price = value;

            //Asset
            Assert.AreEqual(expectedPrice, i.Price, delta);
        }

        [TestMethod]
        [DataRow(-0.000001)]
        [DataRow(1000000.0001)]
        public void TestPriceNotOK(double value)
        {
            //Arrange
            Item i = new Item();


            //Act - se assert


            //Asset
            Assert.ThrowsException<ArgumentException>(() => i.Price = value);
        }

        [TestMethod]
        [DataRow("123")]
        [DataRow("Peter")]
        [DataRow("en meget lang sætning som bare bliver ved og ved ................")]
        public void TestNameOK(string name)
        {
            //Arrange
            Item i = new Item();
            string expectedName = name;
            
            //Act
            i.Name = name;

            //Asset
            Assert.AreEqual(expectedName, i.Name);
        }

        [TestMethod]
        [DataRow(null)]
        [DataRow("")]
        [DataRow("       ")]
        public void TestNameNotOK1(string name)
        {
            //Arrange
            Item i = new Item();


            //Act - se assert


            //Asset
            Assert.ThrowsException<ArgumentNullException>(() => i.Name = name);
        }

        [TestMethod]
        [DataRow("1")]
        [DataRow("12")]
        public void TestNameNotOK(string name)
        {
            //Arrange
            Item i = new Item();


            //Act - se assert


            //Asset
            Assert.ThrowsException<ArgumentException>(() => i.Name = name);
        }

    }
}
