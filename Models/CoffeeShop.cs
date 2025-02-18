using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileFreaks_Coding_Challenge.Models
{
    public class CoffeeShop
    {
        public string Name { get; }
        public double X { get; }
        public double Y { get; }

        public CoffeeShop(string name, double x, double y)
        {
            Name = name;
            X = x;
            Y = y;
        }
    }
}
