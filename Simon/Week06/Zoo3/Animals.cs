using Simon.Week06.Zoosim;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simon.Week06.Zoo3
{
    internal class Animals
    {
        private string _Name;
        private string _Spcies;
        private AnimalFood _AnimalFood;
        private double _Foodcount;
        

        public Animals(string name, string spcies, AnimalFood animalfood, double foodcount)
        {
            _Name = name;
            _Spcies = spcies;
            _AnimalFood = animalfood;
            _Foodcount = foodcount;
        }

        public void PrintAnimals()
        {
            Console.WriteLine("│\t\t├── {1}, {0}", _Name, _Spcies);
        }

        public void GetFoodAnimals(Dictionary<AnimalFood, double> dic)
        {
            if (dic.ContainsKey(_AnimalFood))
            {
                dic[_AnimalFood] += _Foodcount;
            }
            else
            {
                dic[_AnimalFood] = _Foodcount;
            }

        }

    }
}
