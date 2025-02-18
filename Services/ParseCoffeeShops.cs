using AgileFreaks_Coding_Challenge.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileFreaks_Coding_Challenge.Services
{
    public static class ParseCoffeeShops
    {
        public static List<CoffeeShop> ParseShops(string data)
        {
            var coffeeShops = new List<CoffeeShop>();
            var reader = new StringReader(data);
            string line;

            while((line = reader.ReadLine()) != null){

                var parts = line.Split(',');
                if (parts.Length != 3 ||
                    !double.TryParse(parts[1], System.Globalization.NumberStyles.Float, CultureInfo.InvariantCulture, out double y) ||
                    !double.TryParse(parts[2], System.Globalization.NumberStyles.Float, CultureInfo.InvariantCulture, out double x))
                {
                    Console.WriteLine("Invalid data format: " + line);
                    Environment.Exit(11);
                }
                else
                {
                    coffeeShops.Add(new CoffeeShop(parts[0], x, y));
                }
            }

            return coffeeShops;
        }
    }
}
