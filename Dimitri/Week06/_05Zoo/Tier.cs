using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dimitri.Week06._05Zoo
{
    public class Tier
    {
        private string _Name;
        private string _Gattung;
        private Futter _Futter;
        private double _Menge;

        public Futter Futter { get => _Futter;  }

        public double Menge { get => _Menge; } 

        public string Name { get => _Name; }

        public Tier(string name, string gattung, Futter futter, double menge)
        {
            _Name = name;
            _Gattung = gattung;
            _Futter = futter;
            _Menge = menge;

        }

        public Tier(string name, string gattung)
        {
            _Name = name;
            _Gattung = gattung;

        }

        public void PrintTier()
        {
            Console.WriteLine("│       ├── {0}, {1}", _Name, _Gattung);
            if(_Futter != null)
            {
                Console.WriteLine("│           ├── {0} {1} {2} pro Tag", _Menge, _Futter.Einheit, _Futter.Name);

            }
            else
            {
                Console.WriteLine("│           ├── {0} mag nichts essen!", _Name );
            }
        }
    } 
}
