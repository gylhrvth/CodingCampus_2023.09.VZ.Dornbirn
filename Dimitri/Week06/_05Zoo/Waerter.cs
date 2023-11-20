using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dimitri.Week06._05Zoo
{

    public class Waerter
    {
        private static Random random = new();
        private string _Name;
        private List<Gehege> _GehegeListe;
        private Tier _LieblingsTier;

        public string Name
        {
            get => _Name;
        }

        public List<Gehege> GehegeListe
        {
            get => _GehegeListe;
        }

        public Tier LieblingsTier
        {
            get => _LieblingsTier;
        }

        public Waerter(string name, List<Gehege> gehegelist, Tier lieblingsTier)
        {
            _Name = name;
            _GehegeListe = gehegelist;
            _LieblingsTier = lieblingsTier;
        }

        public Waerter(string name, List<Gehege> gehegelist)
        {
            _Name = name;
            _GehegeListe = gehegelist;
        }

        public Waerter(string name)
        {
            _Name = name;
            _GehegeListe = new List<Gehege>();
        }

        public override string ToString()
        {
            return string.Format("{0}", _Name);
        }

        public void PrintWaerter()
        {
            Console.WriteLine("│   ├── Waerter: {0}", _Name);
            if (_GehegeListe.Count != 0)
            {
                foreach (Gehege gehege in _GehegeListe)
                {
                    gehege.PrintGehege();
                }
            }
            else
            {
                Console.WriteLine("│       ├── Hat kein Gehege!");
            }
        }

        public static Waerter AddGehege(Waerter waerter, Gehege newGehege)
        {
            if (waerter._GehegeListe.Contains(newGehege))
            {
                return waerter;
            }
            else
            {
                waerter._GehegeListe.Add(newGehege);
            }
            return waerter;
        }

        public void AddLieblingstier(Tier Lieblingstier)
        {
            _LieblingsTier = Lieblingstier;
        }

        public void FeedGehege()
        {
            if (_GehegeListe.Count == 0)
            {
                Console.WriteLine("{0} hat keine Gehege zugeteilt.", _Name);
                return;
            }
            foreach (Gehege gehege in _GehegeListe)
            {
                if (gehege.Tiere.Count == 0)
                {
                    Console.WriteLine("{0} sieht, dass das {1} leer ist und geht weiter.", _Name, gehege);
                }
                else if (!gehege.Gefuettert)
                {
                    Console.WriteLine("{0} fuettert die Tiere im {1}.", _Name, gehege);
                    gehege.SetGehegeGefuettert(true);
                    int i = random.Next(0, gehege.Tiere.Count);
                    AddLieblingstier(gehege.Tiere[i]);
                    Console.WriteLine("{0} beobachtet {1} nach dem fuettern.", _Name, LieblingsTier.Name);
                }
                else
                {
                    Console.WriteLine("{0} sieht das bereits bearbeitet {1} und geht weiter.", _Name, gehege);
                }
            }


        }


    }
}
