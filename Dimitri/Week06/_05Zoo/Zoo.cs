using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dimitri.Week06._05Zoo
{
    public class Zoo
    {
        private string _Zoo;
        private int _Foundation;
        private List<Gehege> _Gehege;
        private List<Waerter> _Waerter;

        public List<Gehege> Gehege
        {
            get => _Gehege;
        }

        public List<Waerter> Waerter
        {
            get => _Waerter;
        }

        public Zoo(string zoo, int foundation, List<Gehege> gehege)
        {
            _Zoo = zoo;
            _Foundation = foundation;
            _Gehege = gehege;
            _Waerter = new List<Waerter>();
        }




        public static Zoo AddGehege(Zoo zoo, Gehege newGehege)
        {
            zoo.Gehege.Add(newGehege);

            return zoo;
        }

        public static Zoo AddWarter(Zoo zoo, Waerter newWaerter)
        {
            zoo.Waerter.Add(newWaerter); return zoo;
        }

        public override string ToString()
        {
            return string.Format("├── Zoo: {0}, gegründet {1}", _Zoo, _Foundation);
        }

        public void PrintZoo()
        {
            Console.WriteLine("├── Zoo: {0}, gegründet {1}", _Zoo, _Foundation);


            for (int j = 0; j < _Waerter.Count; j++)
            {
                foreach (Waerter waerter in _Waerter)
                {
                    waerter.PrintWaerter();
                }
            }

            //if (Waerter[i] == null)
            //{
            //    foreach (Gehege enclosure in _Gehege)
            //    {
            //        enclosure.PrintGehege();
            //    }
            //}



            if (_Gehege.Count == 0)
            {
                Console.WriteLine("│   ├── Kein Gehege im Zoo!");
            }
            //if (_Gehege.Count != 0)
            //{
            //    foreach (Waerter waerter in _Waerter)
            //    {
            //        waerter.PrintWaerter();
            //    }
            //} else if (string.IsNullOrEmpty(_Waerter[0].Name)
            //if (_Gehege.Count  0)
            //{
            //    foreach (Gehege enclosure in _Gehege)
            //    {
            //        enclosure.PrintGehege();
            //    }
            //}

        }

        public void GetFutterbedarf(Zoo zoo)
        {
            Dictionary<Futter, double> Futterbedarf = new();


            for (int i = 0; i < zoo.Gehege.Count; i++)
            {
                for (int j = 0; j < zoo.Gehege[i].Tiere.Count; j++)
                {
                    if (zoo.Gehege[i].Tiere[j].IsNull())
                    {
                        break;
                    }
                    else if (!Futterbedarf.ContainsKey(zoo.Gehege[i].Tiere[j].Futter))
                    {
                        Futterbedarf.Add(zoo.Gehege[i].Tiere[j].Futter, zoo.Gehege[i].Tiere[j].Menge);
                    }
                    else
                    {
                        Futterbedarf[zoo.Gehege[i].Tiere[j].Futter] += zoo.Gehege[i].Tiere[j].Menge;
                    }
                }
            }

            double gesamtKosten = 0;
            Console.WriteLine();
            Console.WriteLine("Futterbedarf im Zoo:");
            Console.WriteLine();
            foreach (KeyValuePair<Futter, double> kvp in Futterbedarf)
            {
                Console.WriteLine("Futter: {0} Menge: {1}kg Einheitspreis: {2}€ Gesamtkosten: {3:0.000}€", kvp.Key, kvp.Value, kvp.Key.EinheitsPreis, (kvp.Value * kvp.Key.EinheitsPreis));
                gesamtKosten += (kvp.Value * kvp.Key.EinheitsPreis);
            }
            Console.WriteLine("Gesamtkosten für Futter pro Tag sind: {0:0.000}€", gesamtKosten);
        }

    }
}
