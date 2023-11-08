using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Michael.ZooSimulation
{
    internal class Food
    {
        private string _Name;
        public string Name { get => _Name; }


        private string _Unit;
        public string Unit { get => _Unit; }


        private float _Price;
        public float Price { get => _Price; }


        public Food(string name, string unit, float price)
        {
            _Name = name;
            _Unit = unit;
            _Price = price;
        }


        public override string ToString()
        {
            return _Name;
        }
    }
}
