using AgileFreaks_Coding_Challenge.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CoffeeShopFinderTest
{
    [TestClass]
    public class DistanceCalculatorTest
    {
        [TestMethod]
        public void TestDistanceCalculator()
        {
            //Arrange
            double x1 = 0, y1 = 0, x2 = 3, y2 = 4;

            //Act
            double result = DistanceCalculator.Calculate(x1, y1, x2, y2);

            //Assert
            Assert.AreEqual(5, result, 0.0001);
        }
    }
}
