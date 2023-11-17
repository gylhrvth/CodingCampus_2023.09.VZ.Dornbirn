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
        private int _Gesundheit;
        private int _MaxGesundheit;
        private int _Biss;
        private bool _Tot;

        public Futter Futter { get => _Futter;  }

        public double Menge { get => _Menge; } 

        public string Name { get => _Name; }

        public int Gesundheit { get => _Gesundheit;  }

        public int MaxGesundheit { get => _MaxGesundheit; }

        public int Biss { get => _Biss; }

        public bool Tot { get => _Tot; }

        public Tier(string name, string gattung, Futter futter, double menge, int gesundheit, int maxGesundheit, int biss)
        {
            _Name = name;
            _Gattung = gattung;
            _Futter = futter;
            _Menge = menge;
            _Gesundheit = gesundheit;
            _MaxGesundheit = maxGesundheit;
            _Biss = biss;
            _Tot = false;
        }

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
            Console.WriteLine("│           ├── {0}, {1}", _Name, _Gattung);
            if(_Futter != null)
            {
                Console.WriteLine("│               ├── {0} {1} {2} pro Tag", _Menge, _Futter.Einheit, _Futter.Name);

            }
            else
            {
                Console.WriteLine("│                ├── {0} mag nichts essen!", _Name );
            }
        }

        public override string ToString()
        {
            return string.Format("{0}", _Name);
        }

        public bool IsNull()
        {
            bool isNullorEmpty = false;
            if (_Futter is null) { isNullorEmpty = true; } else { isNullorEmpty = false; }
            return isNullorEmpty;
        }

        public void Bite(int damage)
        {
            _Gesundheit -= damage;
            if(_Gesundheit <= 0) 
            {
                _Gesundheit = 0;
                _Tot = true;
            }
        }




    } 
}
