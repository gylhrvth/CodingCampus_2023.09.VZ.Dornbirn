using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timo.Week06._04Zoo
{
    public class Gehege
    {
        private string _Description;
        private List<Tier> _Tier;
        private bool _Gefüttert;
        private List<Tier> _DeadAnimal;

        public Gehege(string description)
        {
            _Description = description;
            _Tier = new List<Tier>();
            _Gefüttert = false;
            _DeadAnimal = new List<Tier>();
        }

        public List<Tier> Tier
        {
            get => _Tier;
            //set => _Tier = value;
        }
        public string Description
        {
            get => _Description;
            //set => _Description = value;
        }
        public bool Gefüttert
        {
            get => _Gefüttert;
            set => _Gefüttert = value;
        }

        //public void AddTier(Tier tier)
        //{
        //    _Tier.Add(tier);
        //}

        public void PrintGehege()
        {
            Console.WriteLine("│\t├── Gehege: {0}", _Description);

            for (int i = 0; i < _Tier.Count; i++)
            {
                if (_Tier[i].Alive == true)
                {
                    _Tier[i].PrintTier();
                }
                else
                {
                    _Tier.Remove(_Tier[i]);
                }
            }
        }

        public void RemoveDeadAnimal()
        {
            for (int i = 0; i < _Tier.Count; i++)
            {
                if (_Tier[i].HpPercent <= 0)
                {
                    _Tier[i].Alive = false;
                    _DeadAnimal.Add(Tier[i]);
                    _Tier.Remove(_Tier[i]);
                }
            }
        }

        public void DeadAnimal()
        {
            for (int i = 1; i < _DeadAnimal.Count; i++)
            {
                Console.WriteLine("\t" + _DeadAnimal[i].Name + ", " + _DeadAnimal[i].Species);
            }
        }

        public void GetGehegeStatistic(Dictionary<Futter, double> dic)
        {
            for (int i = 0; i < _Tier.Count; i++)
            {
                _Tier[i].GetTierStatistic(dic);
            }
        }

        public void Kampf()
        {
            Random random = new Random();
            for (int i = 0; i < _Tier.Count; i++)
            {
                int toBeBiten = random.Next(_Tier.Count);
                if (toBeBiten != i)
                {
                    if (random.Next(101) <= 40 && _Tier[i].Alive == true)
                    {
                        _Tier[toBeBiten].Hp = _Tier[toBeBiten].Hp - _Tier[i].Attack;
                        _Tier[toBeBiten].HpPercent = (_Tier[toBeBiten].Hp * 1.00) / _Tier[toBeBiten].MaxHp * 100;
                        if (_Tier[toBeBiten].HpPercent > 0)
                        {
                            Console.WriteLine("{0} wurde von {1} gebissen. Gesundheit auf {2 :N1}% reduziert",
                                _Tier[toBeBiten].Name,
                                _Tier[i].Name,
                                _Tier[toBeBiten].HpPercent);
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("{0} wurde von {1} getötet",
                                _Tier[toBeBiten].Name,
                                _Tier[i].Name);
                            Console.ResetColor();
                        }
                    }
                }
            }
        }
    }
}
