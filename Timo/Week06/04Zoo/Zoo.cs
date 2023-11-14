using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timo.Week06._04Zoo
{
    public class Zoo
    {
        private string _Name;
        private int _Founded;
        private List<Gehege> _Gehege;
        private List<Tierpfleger> _Tierpfleger;
        private List<Tierarzt> _Tierarzt;
        private List<Tier> _DeadAnimal;
        private double _GesamtFutterKosten;

        public Zoo(string name, int founded)
        {
            _Name = name;
            _Founded = founded;
            _Gehege = new List<Gehege>();
            _Tierpfleger = new List<Tierpfleger>();
            _Tierarzt = new List<Tierarzt>();
            _DeadAnimal = new List<Tier>();
            _GesamtFutterKosten = 0;
        }

        public List<Tierarzt> Tierarzt
        {
            get => _Tierarzt;
        }
        public List<Gehege> Gehege
        {
            get => _Gehege;
        }
        public List<Tierpfleger> Tierpfleger
        {
            get => _Tierpfleger;
        }
        public double GesamtFutterKosten
        {
            get => _GesamtFutterKosten;
        }

        //public Gehege SearchAndCreate(string name)
        //{
        //    foreach (Gehege ag in _Gehege)
        //    {
        //        if (ag.Description == name) return ag;
        //    }
        //    Gehege g = new Gehege(name);
        //    _Gehege.Add(g);
        //    return g;
        //}
        public void PrintZoo()
        {
            Console.WriteLine("├─── Zoo: {0}, gegründet {1}", _Name, _Founded);
            for (int i = 0; i < _Gehege.Count; i++)
            {
                _Gehege[i].PrintGehege();
            }
            for (int i = 0; i < _Tierpfleger.Count; i++)
            {
                _Tierpfleger[i].PrintTierpfleger();
            }
        }

        public void TierPflegerFuettern()
        {
            for (int i = 0; i < _Tierpfleger.Count; ++i)
            {
                _Tierpfleger[i].Fuettern();
            }
        }

        public void RemoveDeadAnimal()
        {
            for (int i = 0; i < _Gehege.Count; i++)
            {
                _Gehege[i].RemoveDeadAnimal();
            }
        }

        public void PrintZooStatistic()
        {
            Dictionary<Futter, double> dic = new();
            for (int i = 0; i < _Gehege.Count; i++)
            { _Gehege[i].GetGehegeStatistic(dic); }
            Console.WriteLine("Futteranforderungen:");
            double cost = 0;
            foreach (Futter food in dic.Keys)
            {
                Console.WriteLine("{0} : {1} {2} / pro Einheit: {3}€", food.Name, dic[food], food.Unit, food.PricePerUnit);
                double amount = dic[food];
                double price = food.PricePerUnit * amount;
                cost += price;
                _GesamtFutterKosten += cost;
            }
            Console.WriteLine("Gesamtkosten für Futter pro Tag: {0:N2}€", cost);
        }

        public void Kampf()
        {
            for (int i = 0; i < _Gehege.Count; i++)
            {
                _Gehege[i].Kampf();
            }
        }

        public void ResetGefuettert()
        {
            for (int i = 0; i < _Gehege.Count; i++)
            {
                Gehege[i].Gefüttert = false;
            }
        }

        public void DeadAnimals()
        {
            for (int i = 0; i < _Gehege.Count; i++)
            {
                Gehege[i].DeadAnimal();
            }
        }

        public void Heilen()
        {
            List<Tier> alleTiere = new List<Tier>();
            for (int i = 0; i < _Gehege.Count; i++)
            {
                for (int j = 0; j < Gehege[i].Tier.Count; j++)
                {
                    if (Gehege[i].Tier[j].HpPercent > 0)
                    {
                        alleTiere.Add(Gehege[i].Tier[j]);
                    }
                }
            }
            for (int i = 0; i < _Tierarzt.Count; i++)
            {
                if (alleTiere.Count == 0)
                {
                    break;
                }
                Tier min = null;
                for (int j = 0; j < alleTiere.Count; j++)
                {
                    if (min == null || alleTiere[j].HpPercent < min.HpPercent)
                    {
                        min = alleTiere[j];
                    }
                }
                if (min != null && min.HpPercent != 100)
                {
                    _Tierarzt[i].Heilen(min);
                }
            }
        }
    }
}
