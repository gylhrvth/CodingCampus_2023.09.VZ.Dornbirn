using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martin.Week07
{
    public class Animal
    {
        private string _Name;
        private int _UnitPrice;
        private string _Unit;
        private string _Art;
        private string _lieblingsessen;
        private int _healthMax;
        private int _damage;
        private Futter _FoodClass;
        public Animal(string Name, string Art,int UnitPrice,Futter FoodClass,string lieblingsessen,int healthMax, int damage)
        {
            _Name = Name;
            _Art = Art;
            _UnitPrice = UnitPrice; //Price
            _FoodClass = FoodClass;
            _lieblingsessen = lieblingsessen;
            _healthMax = healthMax;
            _damage = damage;
        }

        public void FoodRequest(Dictionary<Futter,int> report)
        {
            if(report.ContainsKey(_FoodClass))
            {
                report[_FoodClass] += _UnitPrice;
            }
            else
            {
                report.Add(_FoodClass, _UnitPrice);
            }
        }


        public Futter FoodClass {  get { return _FoodClass; } }
        public string Name { get { return _Name; } }
        public string Art { get { return _Art; } }

        public string Unit {  get { return _Unit; } }
        public string lieblingsessen { get { return _lieblingsessen; } }
        public int UnitPrice { get { return _UnitPrice; } }

        public List<Animal> StartFight(List<Animal> animals)
        {
            List<Animal> fightingAnimals = new List<Animal>();

            foreach(Animal animal in animals)
            {
                fightingAnimals.Add(animal);
            }

            return fightingAnimals;
        }
    }
}
