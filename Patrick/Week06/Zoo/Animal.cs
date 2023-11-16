using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Patrick.Week06.Zoo
{
    internal class Animal
    {
        //properties
        private string _Name;
        private string _Genus;
        private string _Age;
        private float _HowManyFood;
        private Food _Food;
        private int _Health;
        private int _MaxHealth;
        private int _Bite;

        public Food Food
        {
            get => _Food;
        }


        //Konstruktor
        public Animal(string name, string genus, string age, float howManyFood, Food food, int maxHealth, int bite)
        {
            _Name = name;
            _Genus = genus;
            _Age = age;
            _HowManyFood = howManyFood;
            _Food = food;
            _Health = maxHealth;
            _MaxHealth = maxHealth;
            _Bite = bite;
        }

        public void GetAnimalStatistic(Dictionary<Food, float> dic)
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

        public void PrintAnimal()
        {
            Console.WriteLine($"│          ├── {_Name}, {_Genus}, {_Age} || mag: {_Food}");
        }


        public override string ToString()
        {
            return _Name;
        }

        public void DoBite(Animal victom)
        {
            if (this._Name == victom._Name || this._Health <= 0 || victom._Health <= 0)
            {
                // Keine bisst sich selbst !!!
                // Tote Tiere beisen nicht !!!
                return;
            }
            Console.WriteLine($"{this._Name} bisst {victom._Name} mit {this._Bite} Schaden.");
            victom._Health -= this._Bite;
            if (victom._Health <= 0)
            {
                Console.WriteLine($"R.I.P {victom._Name}");
            }
        }

    }
}
