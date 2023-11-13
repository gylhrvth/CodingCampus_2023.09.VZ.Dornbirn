using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarioLuis.Zoo
{
    public class Animal
    {
        private string _Name;
        private string _Species;
        private Food _Food;
        private int _FoodCount;
        private List<Food> _FoodList = new();
        private int _MaxHealth;
        private int _Health;
        private int _Damage;
        private bool _IsDead;

        public string Name
        {
            get => _Name;
            set => _Name = value;
        }
        public string Species
        {
            get => _Species;
            set => _Species = value;
        }
        public List<Food> FoodList
        {
            get => _FoodList;
            set => _FoodList = value;
        }
        public Food Food
        {
            get => _Food;
            set => _Food = value;
        }
        public int FoodCount
        {
            get => _FoodCount;
            set => _FoodCount = value;
        }
        public int MaxHealth
        {
            get => _MaxHealth;
            set => _MaxHealth = value;
        }
        public int Health
        {
            get => _Health;
            set => _Health = value;
        }
        public int Damage
        {
            get => _Damage;
            set => _Damage = value;
        }
        public bool IsDead
        {
            get => _IsDead;
            set => _IsDead = value;
        }
        public Animal(string name, string species, Food food, int foodCount, int maxHealth, int damage)
        {
            _Name = name;
            _Species = species;
            _Food = food;
            _FoodCount = foodCount;
            _MaxHealth = maxHealth;
            _Damage = damage;
            _Health = MaxHealth;
            _IsDead = false;
            _FoodList = new List<Food>();
        }

        public void PrintAnimal()
        {
            Console.WriteLine($"│\t\t\t├── {_Name}, {_Species}");
            foreach (var food in _FoodList)
            {
                food.PrintFood(_FoodCount);
            }
        }
        public void GetAnimalStatistic(Dictionary<Food, double> dic)
        {
            if (dic.ContainsKey(_Food))
            {
                dic[_Food] += _FoodCount;
            }
            else
            {
                dic[_Food] = _FoodCount;
            }
        }
        public override string ToString()
        {
            return _Name + ", " + _Species;
        }
    }
}
