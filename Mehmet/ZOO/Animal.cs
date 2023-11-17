using Mehmet.Zoo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Mehmet.ZOO
{
    internal class Animal
    {
        public static Random rand = new Random();
        private int _health = 100;
  

        private string _Race;
        private string _Name;
       
    
        private List<Food> _FoodList;
        private bool _Fed = false;

        public int Health
        {
            get => _health; set => _health = value;
        }


        public bool Fed
        {
            get
            {
                return _Fed;
            }
            set
            {
                //Console.WriteLine($"                Fed was changed from {Fed} to: false");
                _Fed = false;
            }
        }

        public Animal(string race, string name)
        {
            _Race = race;
            _Name = name;      
            _FoodList = new List<Food>();           
        }
        public void AddFood(Food food)
        {
            _FoodList.Add(food);
        }
        


        public void PrintAnimalName()
        {
            Console.Write(_Name);
        }

        public void PrintStrukture()
        {
            Console.WriteLine("      └──┬┤ Tier: {0}, Rasse: {1}",
                _Name,
                _Race);
            foreach (Food food in _FoodList)
            {
                food.PrintStrukture();
            }
        }

        public void SimulateDay()
        {
            if (_Fed == false)
            {
                Console.WriteLine("      Tier {0} wird gefüttert", _Name);
                _Fed = true;
            }
        }

        public void LookAtAnimal()
        {
            Console.WriteLine("        bewundert -={0}=-", _Name);
        }
        




    }
}
