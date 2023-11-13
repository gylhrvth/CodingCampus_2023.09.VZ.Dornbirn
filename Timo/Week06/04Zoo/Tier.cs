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
        private int _MaxHp;
        private double _Hp;
        private double _HpPercent;
        private int _Attack;
        private bool _Alive;

        public Tier(string name, string species, Futter food, int foodCount, int maxHp, int attack)
        {
            _Name = name;
            _Species = species;
            _Food = food;
            _FoodCount = foodCount;
            _FoodList = new List<Futter>();
            _MaxHp = maxHp;
            _Hp = maxHp;
            _HpPercent = 100;
            _Attack = attack;
            _Alive = true;
        }

        public double HpPercent
        {
            get => _HpPercent;
            set => _HpPercent = value; 
        }
        public int MaxHp
        {
            get => _MaxHp;
        }
        public string Name
        {
            get => _Name;
        }
        public bool Alive
        {
            get => _Alive;
            set => _Alive = value;
        }
        public double Hp
        {
            get => _Hp;
            set => _Hp = value;
        }
        public int Attack
        {
            get => _Attack;
        }
        public string Species
        {
            get => _Species;
        }

        public void PrintTier()
        {
            Console.Write("│\t\t├── {0}, {1}, ", _Name, _Species);
            if (_HpPercent < 50)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed; 
                Console.WriteLine("{0 :N1}%", _HpPercent);
                Console.ResetColor();
            }
            else if (_HpPercent < 80)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("{0 :N1}%", _HpPercent);
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("{0 :N1}%", _HpPercent);
                Console.ResetColor();
            }
        }

        public void GetTierStatistic(Dictionary<Futter, double> dic)
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
    }
}
