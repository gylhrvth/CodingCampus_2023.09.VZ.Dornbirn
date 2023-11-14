using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dimitri.Week06._05Zoo
{
    public class Zoo
    {
        private string _Zoo;
        private DateTime _Foundation;
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

        public Zoo(string zoo, DateTime foundation, List<Gehege> gehege)
        {
            _Zoo = zoo;
            _Foundation = foundation;
            _Gehege = gehege;
            _Waerter = new List<Waerter>();
        }

        public Zoo(string zoo, DateTime foundation)
        {
            _Zoo = zoo;
            _Foundation = foundation;
            _Gehege = new List<Gehege>();
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
            Console.WriteLine("├── Zoo: {0}, gegründet {1}", _Zoo, _Foundation.ToString("d", new CultureInfo("de-AT")));

            foreach (Gehege enclosure in _Gehege)
            {
                enclosure.PrintGehege();
            }

            Console.WriteLine();
            Console.WriteLine("----------------------------------");
            Console.WriteLine();
            Console.WriteLine("Liste der Waerter:");

            foreach (Waerter waerter in _Waerter)
            {
                waerter.PrintWaerter();
            }






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

        public void GetFutterbedarf()
        {
            Dictionary<Futter, double> Futterbedarf = new();


            for (int i = 0; i < Gehege.Count; i++)
            {
                for (int j = 0; j < Gehege[i].Tiere.Count; j++)
                {
                    if (Gehege[i].Tiere[j].IsNull())
                    {
                        break;
                    }
                    else if (!Futterbedarf.ContainsKey(Gehege[i].Tiere[j].Futter))
                    {
                        Futterbedarf.Add(Gehege[i].Tiere[j].Futter, Gehege[i].Tiere[j].Menge);
                    }
                    else
                    {
                        Futterbedarf[Gehege[i].Tiere[j].Futter] += Gehege[i].Tiere[j].Menge;
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

        private static Random random = new Random();
        public void Simulation()
        {
            Dictionary<Gehege, bool> GehegeGefuettert = new();
            Console.WriteLine("Simulation von {0}:", _Zoo);
            foreach (Waerter waerter in Waerter)
            {
                Console.WriteLine();
                foreach (Gehege gehege in waerter.GehegeListe)
                {
                    Console.WriteLine();
                    if (!GehegeGefuettert.ContainsKey(gehege) && gehege.Tiere.Count != 0)
                    {
                        GehegeGefuettert.Add(gehege, true);
                        Console.WriteLine("{0} fuettert die Tiere im {1}.", waerter, gehege);
                        int i = random.Next(0, gehege.Tiere.Count);
                        waerter.AddLieblingstier(waerter, gehege.Tiere[i]);
                        Console.WriteLine("{0} beobachtet {1} nach dem fuettern.", waerter, waerter.LieblingsTier.Name);
                    } else if (gehege.Tiere.Count == 0)
                    {
                        Console.WriteLine("{0} sieht, dass das {1} leer ist und geht weiter.", waerter, gehege);
                    }
                    else
                    {
                        Console.WriteLine("{0} sieht das bereits bearbeitet {1} und geht weiter.", waerter, gehege);
                    }

                }
            }
        }

    }
}
