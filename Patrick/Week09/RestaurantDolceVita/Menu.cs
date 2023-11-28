using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrick.Week09.RestaurantDolceVita
{
    public class Menu
    {
        private string _Name;
        private double _Price;
        
        public double Price
        {
            get => _Price;
        }

        public string Name
        {
            get => _Name;
        }

        public Menu(string name, double price)
        {
            _Name = name;
            _Price = price;
        }
    }
}
