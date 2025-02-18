using AgileFreaks_Coding_Challenge.Models;
using AgileFreaks_Coding_Challenge.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileFreaks_Coding_Challenge
{
    class Program
    {
        static async Task Main(string[] args)
        {
            if(args.Length != 3)
            {
                foreach(var arg in args) { Console.WriteLine(arg); }
                Console.WriteLine("Arguments should be: < user x coordinate > < user y coordinate > < shop data url >");
                return;
            }

            if(!double.TryParse(args[0], out double userX) || !double.TryParse(args[1], out double userY))
            {
                Console.WriteLine("Invalid user coordinates");
                return;
            }

            string url = args[2];
            List<CoffeeShop> coffeeShops;

            try
            {
                string data = await DataFetcher.FetchDataAsync(url);
                coffeeShops = ParseCoffeeShops.ParseShops(data);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error fetching coffee shop data: "+ ex.Message);
                return;
            }

            var closestShops = FindClosestCoffeeShops.FindClosestShops(coffeeShops, userX, userY);

            foreach(var shop in closestShops)
            {
                Console.WriteLine($"{shop.name},{shop.distance:F4}");
            }

        }
    }
}
