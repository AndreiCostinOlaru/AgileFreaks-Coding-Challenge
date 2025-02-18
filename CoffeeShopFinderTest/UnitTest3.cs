using AgileFreaks_Coding_Challenge.Models;
using AgileFreaks_Coding_Challenge.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace CoffeeShopFinderTest
{
    [TestClass]
    public class FindClosestShopsTest
    {
        [TestMethod]
        public void FindClosestShops_ReturnsCorrectOrder()
        {
            //Arrange
            var userX = 0;
            var userY = 0;
            var shops = new List<CoffeeShop>
            {
                new CoffeeShop("Shop1", 1, 1),
                new CoffeeShop("Shop2", 2, 2),
                new CoffeeShop("Shop3", 3, 3),
                new CoffeeShop("Shop4", 4, 4)
            };

            //Act
            var result = FindClosestCoffeeShops.FindClosestShops(shops, userX, userY);

            //Assert
            Assert.AreEqual("Shop1", result[0].name);
            Assert.AreEqual("Shop2", result[1].name);
            Assert.AreEqual("Shop3", result[2].name);
        }
    }
}
