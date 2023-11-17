using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
        private List<TierArzt> _TierArztListe;
        public List<Gehege> Gehege
        {
            get => _Gehege;
        }

        public List<Waerter> Waerter
        {
            get => _Waerter;
        }

        public List<TierArzt> TierArztListe
        { 
            get => _TierArztListe; 
        }

        public Zoo(string zoo, DateTime foundation, List<Gehege> gehege)
        {
            _Zoo = zoo;
            _Foundation = foundation;
            _Gehege = gehege;
            _Waerter = new List<Waerter>();
            _TierArztListe = new List<TierArzt>();
        }

        public Zoo(string zoo, DateTime foundation)
        {
            _Zoo = zoo;
            _Foundation = foundation;
            _Gehege = new List<Gehege>();
            _Waerter = new List<Waerter>();
            _TierArztListe = new List<TierArzt>();
        }




        public static Zoo AddGehege(Zoo zoo, Gehege newGehege)
        {
            zoo._Gehege.Add(newGehege);

            return zoo;
        }

        public static Zoo AddWarter(Zoo zoo, Waerter newWaerter)
        {
            zoo._Waerter.Add(newWaerter); return zoo;
        }

        public void AddTierArzt(TierArzt newDoctor)
        {
            _TierArztListe.Add(newDoctor);
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
        public void Simulation0Old()
        {
            Dictionary<Gehege, bool> GehegeGefuettert = new();
            Console.WriteLine("Simulation 0.1 von {0}:", _Zoo);
            foreach (Waerter waerter in Waerter)
            {
                Console.WriteLine();
                foreach (Gehege gehege in waerter.GehegeListe)
                {
                    if (!GehegeGefuettert.ContainsKey(gehege) && gehege.Tiere.Count != 0)
                    {
                        GehegeGefuettert.Add(gehege, true);
                        Console.WriteLine("{0} fuettert die Tiere im {1}.", waerter, gehege);
                        int i = random.Next(0, gehege.Tiere.Count);
                        waerter.AddLieblingstier(gehege.Tiere[i]);
                        Console.WriteLine("{0} beobachtet {1} nach dem fuettern.", waerter, waerter.LieblingsTier.Name);
                    }
                    else if (gehege.Tiere.Count == 0)
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

        public void Simulation0()
        {
            foreach (Waerter waerter in Waerter)
            {
                waerter.FeedGehege();
                Console.WriteLine();
            }

        }

        public void Simulation1Old()
        {
            Console.WriteLine("Simulation 0.2 von {0}:", _Zoo);
            Console.WriteLine();

            while (true)
            {
                foreach (Gehege gehege in Gehege)
                {
                    foreach (Tier tier in gehege.Tiere)
                    {
                        foreach (Tier anderesTier in gehege.Tiere)
                        {
                            if (random.Next(0, 10) <= 3 && gehege.Tiere.Count >= 2 && tier != anderesTier && !anderesTier.Tot && !tier.Tot)
                            {
                                Console.WriteLine("{0} hat {1} hp.", tier.Name, tier.Gesundheit);
                                Console.WriteLine("{0} beißt {1} und {1} nimmt {2} Schaden.", anderesTier, tier, anderesTier.Biss);
                                tier.Bite(anderesTier.Biss);
                                if (tier.Tot)
                                {
                                    Console.WriteLine("{0} ist tot.", tier);
                                }
                                else
                                {
                                    Console.WriteLine("{0} hat jetzt {1} hp.", tier.Name, tier.Gesundheit);
                                }
                                Console.WriteLine();
                            }

                        }
                    }

                }

                if (random.Next(1, 7) == 6)
                {
                    break;
                }

            }

            if (GetDeadAnimal() != null)
            {
                Console.WriteLine("{0} wird von einem Waerter weggeräumt.", GetDeadAnimal());
            }



        }
        public Tier GetDeadAnimal()
        {
            Tier deadAnimal = null;

            foreach (Gehege gehege in _Gehege)
            {
                foreach (Tier tier in gehege.Tiere)
                {
                    if (tier.Tot)
                    {
                        deadAnimal = tier;
                        return deadAnimal;
                    }

                }
            }

            return deadAnimal;
        }

        public void Simulation1()
        {

            foreach (Gehege gehege in Gehege)
            {
                gehege.Fight();
            }
        }

        public void Simulation(int days)
        {
            for (int i = 0; i < days; i++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Simulation 0.2 von {0}, Tag {1}:", _Zoo, i + 1);
                Console.ResetColor();
                Console.WriteLine();
                Simulation0();
                Simulation1();
                Simulation2();
                ResetGehege();
                Console.WriteLine();
            }
        }

        public void ResetGehege()
        {
            foreach (Gehege gehege in _Gehege)
            {
                gehege.SetGehegeGefuettert(false);
            }
        }

        public void Simulation2()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Simulation 0.3");
            Console.ResetColor();
            Console.WriteLine();
            Tier lowestAnimal = null;
            foreach(Gehege gehege in _Gehege)
            {
                if (gehege.Tiere.Count >= 2 )
                {
                    Tier newAnimal = gehege.GetLowestHealth();
                    if (lowestAnimal == null || newAnimal.GetHealth()*100/(newAnimal.GetMaxHealth()*100) < (lowestAnimal.GetHealth()*100)/(lowestAnimal.GetMaxHealth()*100))
                    {
                        lowestAnimal = newAnimal;
                    }
                }
            }

            foreach(TierArzt tierArzt in _TierArztListe)
            {
                tierArzt.Heal(lowestAnimal);
            }
        }
    }
}
