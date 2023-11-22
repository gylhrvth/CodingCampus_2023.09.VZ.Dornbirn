using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrick.Week08.LearningDay
{
    internal class Food
    {
        private string _Name;
        private string _Unit;
        private float _Price;

        public string Name
        {
            get => _Name;
        }
        public string Unit
        {
            get => _Unit;
        }

        public float Price
        {
            get => _Price;
        }


        public Food(string name, string unit, float price)
        {
            _Name = name;
            _Unit = unit;
            _Price = price;
        }

        public override string ToString()
        {
            return Name; 
        }

    }
}
