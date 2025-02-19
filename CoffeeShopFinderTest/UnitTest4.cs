using AgileFreaks_Coding_Challenge.Models;
using AgileFreaks_Coding_Challenge.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace CoffeeShopFinderTest
{
    [TestClass]
    public class ParseCoffeeShopsTests
    {
        [TestMethod]
        public void ParseShops_ReturnsList()
        {
            //Arrange
            string validData = "Starbucks,40.7128,-74.0060\nDunkin,34.0522,-118.2437";

            //Act
            List<CoffeeShop> result = ParseCoffeeShops.ParseShops(validData);

            //Assert
            Assert.AreEqual(2, result.Count);
            Assert.AreEqual("Starbucks", result[0].Name);
            Assert.AreEqual(40.7128, result[0].Y);
            Assert.AreEqual(-118.2437, result[1].X);
        }

        [TestMethod]
        public void ParseShops_EmptyInput_ShouldReturnEmptyList()
        {
            // Arrange
            string emptyData = "";

            // Act
            List<CoffeeShop> result = ParseCoffeeShops.ParseShops(emptyData);

            // Assert
            Assert.AreEqual(0, result.Count);
        }
    }
}
