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


        public Zoo(string name, int founded)
        {
            _Name = name;
            _Founded = founded;
            _Gehege = new List<Gehege>();
            _Tierpfleger = new List<Tierpfleger>();
        }

        public List<Gehege> Gehege
        {
            get => _Gehege;
            //set => _Gehege = value;
        }
        //public List<Tierpfleger> Tierpfleger
        //{
        //    get => _Tierpfleger;
        //    set => _Tierpfleger = value;
        //}
        //public string Name
        //{
        //    get => _Name;
        //    set => _Name = value;
        //}
        //public int Founded
        //{
        //    get => _Founded;
        //    set => _Founded = value;
        //}

        public void AddGehege(Gehege gehege)
        {
            _Gehege.Add(gehege);
        }

        public Gehege SearchAndCreate(string name)
        {
            foreach (Gehege ag in _Gehege)
            {
                if (ag.Description == name) return ag;
            }
            Gehege g = new Gehege(name);
            _Gehege.Add(g);
            return g;
        }

        public void PrintZoo()
        {
            Console.WriteLine("├─── Zoo: {0}, gegründet {1}", _Name, _Founded);
            for (int i = 0; i < _Tierpfleger.Count; i++)
            {
                _Tierpfleger[i].PrintTierpfleger();
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
            }
            Console.WriteLine("Gesamtkosten für Futter pro Tag: {0:N2}€", cost);
        }
    }
}
