using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrick.Week06.Zoo
{
    internal class Food
    {
        public string _Name;
        public string _Unit;
        public float _Price;


        //Konstruktor
        public Food(string Name, string Unit, float Price)
        {
            _Name = Name;
            _Unit = Unit;
            _Price = Price;
        }

        public string Name
        {
            get => _Name;
        }

        public override string ToString()
        {
            return Name;
        }



    }
}
