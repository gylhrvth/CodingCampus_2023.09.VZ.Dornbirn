using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandro.Week06.ZooTycoon
{
    internal class Food
    {
        private string name;
        private string unit;
        private double price;

    
        public Food(string name, string unit, double price)
        {
            this.name = name;
            this.unit = unit;
            this.price = price;
        }

        public override string ToString()
        {
            return $"{name}";
        }
    }
}
