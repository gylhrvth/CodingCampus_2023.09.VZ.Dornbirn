using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrick.Week06.OOP.Zoo
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


        //Konstruktor
        public Food(string Name, string Unit, float Price)
        {
            _Name = Name;
            _Unit = Unit;
            _Price = Price;
        }

        public override string ToString()
        {
            return Name;
        }



    }
}
