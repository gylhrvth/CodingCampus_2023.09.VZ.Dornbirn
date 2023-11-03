using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dimitri.Week06._05Zoo
{
    public class Futter
    {
        private string _Name;
        private string _Einheit;
        private double _EinheitsPreis;

        public string Name
        {
            get => _Name;
        }

        public string Einheit
        {
            get => _Einheit;
        }

        public Futter(string name, string einheit, double einheitsPreis)
        {
            _Name = name;
            _Einheit = einheit;
            _EinheitsPreis = einheitsPreis;
        }   

        public void PrintFutter() 
        {
            Console.WriteLine("│          ├── {0}", _Name);
        }
    }
}
