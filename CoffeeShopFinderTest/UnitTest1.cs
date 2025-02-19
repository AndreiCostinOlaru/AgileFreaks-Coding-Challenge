using AgileFreaks_Coding_Challenge.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading.Tasks;

namespace CoffeeShopFinderTest
{
    [TestClass]
    public class DataFetcherTests
    {
        [TestMethod]
        public async Task FetchDataAsyncTest()
        {
            //Arrange
            var url = "https://raw.githubusercontent.com/Agilefreaks/test_oop/master/coffee_shops.csv";

            //Act
            var result = await DataFetcher.FetchDataAsync(url);

            //Assert
            Assert.IsNotNull(result.ToString());
            Assert.IsTrue(result.ToString().Length > 0);
        }   
    }
}
