using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sven.Week07.Zoo.Zoo
{
    internal class Food
    {

        private string _Name;
        private string _Unit;
        private double _PricePerUnit;


        public Food(string name, double pricePerUnit, string unit)
        {
            _Name = name;
            _Unit = unit;
            _PricePerUnit = pricePerUnit;

        }


        public string Name
        {
            get => _Name;
            set => _Name = value;
        }


        public string Unit
        {
            get => _Unit;
            set => _Unit = value;
        }

        public double PricePerUnit
        {
            get => _PricePerUnit;
            set => _PricePerUnit = value;
        }



        public void PrintFood(int foodCount)
        {
            Console.WriteLine($"{_Name} {foodCount} {_Unit}");
        }

        public override string ToString()
        {
            return "│\n             ├──  Food: " + _Name + ", Unit: " + _Unit + ", Price: " + _PricePerUnit; ;
        }
    }

}
