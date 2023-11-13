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
        private string _Name;
        private List<Gehege> _GehegeListe;

        public string Name
        {
            get => _Name;
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
        }

        public static Waerter AddGehege(Waerter waerter, Gehege newGehege)
        {
            waerter._GehegeListe.Add(newGehege);

            return waerter;
        }

    }
}
