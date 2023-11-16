using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Jovo.Week06._05Zoo
{
    internal class Animals
    {
        private bool _isFed;
        private string _Name;
        private int _Age;
        private string _Genus;
        private string _Gender;
        private Food _Food;
        private int _FoodCount;
        private List<Food> _FoodList = new();
        private int _Bite;
        private int _Life;
        private int _MaxLife;
        private bool _IsDead;

        public Animals(string name, int age, string genus, string gender, Food food, int foodCount, int bite, int life, int maxLife)
        {
            _Name = name;
            _Age = age;
            _Genus = genus;
            _Gender = gender;
            _Food = food;
            _FoodCount = foodCount;
            _isFed = false;
            _Bite = bite;
            _Life = life;
            _MaxLife = maxLife;
        }

        public bool IsFed
        {
            get => _isFed;
            set => _isFed = value;
        }

        public string Name
        {
            get => _Name;
            set => _Name = value;
        }
        public string Genus
        {
            get => _Genus;
            set => _Genus = value;
        }

        public int Bite
        {
            get => _Bite;
            set => _Bite = value;
        }

        public Food Food
        {
            get => _Food;
        }
        public int Life
        {
            get => _Life;
            set => _Life = value;
        }

        public bool IsDead
        {
            get => _IsDead;
            set => _IsDead = value;
        }

        public int MaxLife
        {
            get => _MaxLife;            
        }

        public void PrintZoo()
        {
            Console.WriteLine($"│   │   ├── {_Name}, {_Age}, {_Gender}, {_Genus}, eats : {_Food.Name}");
        }

        public void PrintAnimal()
        {
            Console.WriteLine($"│\t\t\t├── {_Name}, {_Genus}");
            foreach (var food in _FoodList)
            {
                food.PrintFood(_FoodCount);
            }
        }
        public void GetAnimalStatistic(Dictionary<Food, float> dic)
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


      

        //Angriff lebens abzug, attacke und dann im gehege einbauen
        public void Attack(Animals opfer)
        {
            if (opfer._Life <= 0)
            {
               opfer._Life = _Life;
               Console.WriteLine("Tier ist tot");
            }
           
        }
    }

}
