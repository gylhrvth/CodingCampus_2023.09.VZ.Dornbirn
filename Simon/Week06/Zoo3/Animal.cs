using Simon.Week06.Zoosim;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simon.Week06.Zoo3
{
    internal class Animal
    {
        private string _Name;
        private string _Species;
        private AnimalFood _AnimalFood;
        private double _Foodcount;
        private int _MaxHealth;
        private int _BiteDmg;
        private int _Health;
        private int _Deadsince;

        public string Name
        {
            get { return _Name; }
        }
        public bool Alive { get { return Health > 0; } }
        public int Deadsince { get { return _Deadsince; } set { _Deadsince = value; } }

        public int MaxHealth { get { return _MaxHealth; } }
        public int BiteDmg { get { return _BiteDmg; } }
        public int Health
        {
            get { return _Health; }
            set
            {
                //Console.WriteLine("Das angegriffene Tier hat nun noch: {0} leben ", value);
                _Health = value;
            }
        }


        public Animal(string name, string spcies, AnimalFood animalfood, double foodcount, int maxhealth, int bitedmg)
        {
            _Name = name;
            _Species = spcies;
            _AnimalFood = animalfood;
            _Foodcount = foodcount;
            _MaxHealth = maxhealth;
            _BiteDmg = bitedmg;
            _Health = maxhealth;
            _Deadsince = 0;
        }

        public void PrintAnimals()
        {
            Console.WriteLine("│\t\t├── {1}, {0}", _Name, _Species);
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

        public void GetsAttackedBy(Animal attacker)
        {
            Health -= attacker.BiteDmg;
        }

    }
}
