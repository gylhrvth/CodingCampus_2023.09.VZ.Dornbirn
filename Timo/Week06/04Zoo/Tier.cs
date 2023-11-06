using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timo.Week06._04Zoo
{
    public class Tier
    {
        private string _Name;
        private string _Species;
        private Futter _Food;
        private int _FoodCount;
        private List<Futter> _FoodList = new();

        public Tier(string name, string species, Futter food, int foodCount)
        {
            _Name = name;
            _Species = species;
            _Food = food;
            _FoodCount = foodCount;
            _FoodList = new List<Futter>();
        }

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public string Species
        {
            get { return _Species; }
            set { _Species = value; }
        }
        public Futter Food
        {
            get { return _Food; }
            set { _Food = value; }
        }
        public int Foodcount
        {
            get { return _FoodCount; }
            set { _FoodCount = value; }
        }
        public List<Futter> FoodList
        {
            get { return _FoodList; }
            set { _FoodList = value; }
        }

        public void PrintTier()
        {
            Console.WriteLine("│\t\t├── {0}, {1}", _Name, _Species);
            for (int i = 0; i < _FoodList.Count; i++)
            {
                _FoodList[i].PrintFood(_FoodCount);
            }
        }
    }
}
