using AgileFreaks_Coding_Challenge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileFreaks_Coding_Challenge.Services
{
    public static class FindClosestCoffeeShops
    {
        public static List<(string name, double distance)> FindClosestShops(List<CoffeeShop> shops, double userX, double userY, int count = 3)
        {
            return shops
                .Select(shop => (shop.Name, distance: DistanceCalculator.Calculate(userX, userY, shop.X, shop.Y)))
                .OrderBy(shop => shop.distance)
                .Take(count)
                .ToList();
        }
    }
}
