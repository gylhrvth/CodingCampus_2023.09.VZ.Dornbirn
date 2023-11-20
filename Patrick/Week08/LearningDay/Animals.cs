using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrick.Week08.LearnDay
{
    internal class Animals
    {
        private string _Name;
        private string _Genus;
        private int _Age;
        private string _Gender;
        private Food _Food;
        private float _HowManyFood;



        public Animals(string name, string genus, int age, string gender, float howManyFood, Food food)
        {
            _Name = name;
            _Genus = genus;
            _Age = age;
            _Gender = gender;
            _HowManyFood = howManyFood;
            _Food = food;
        }
        public void PrintAnimal()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"│          ├── \"{_Name}\" ist das Tier \"{_Genus}\", ist \"{_Age}\" Jahre alt und ist \"{_Gender}\"");           
        }

        public void GetStatistic(Dictionary<Food, float> dic)
        {
            if (dic.ContainsKey(_Food))
            {
                dic[_Food] += _HowManyFood;
            }
            else
            {
                dic[_Food] = _HowManyFood;
            }
        }

        public override string ToString()
        {
            return _Name;
        }
   
    }
}
