using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Gheorghe.Week07.Zoo
{
    internal class Animals
    {
        private string _Name;
        private int _Age;
        private string _Genus;
        private string _Gender;
        private Food _Food;
        private double _FoodAmount;



        public Animals(string name , int age, string genus, string gender, Food food, double foodAmount ) 
        {
            _Name = name;
            _Age = age;
            _Genus = genus;
            _Gender = gender;
            _Food = food;
            _FoodAmount = foodAmount;

          
        }

        public void PrintZoo ()
        {
            Console.WriteLine($"    |--- {_Name}, {_Age}, {_Gender},{_Genus}, eats: {_FoodAmount}, {_Food}");
        }
    }
}
