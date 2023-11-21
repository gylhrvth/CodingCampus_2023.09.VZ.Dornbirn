using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jovo.Week07.Vererbung
{
    internal class Bugatti : Sportwagen
    {
        private string _MostCars;
        public string MostCars { get => _MostCars; }

        //fragen wegen kosten
        public Bugatti(string name, int year, string MostCars) : base (name, year)
        {



            _MostCars = MostCars;
        }


        public override void PrintMe()
        {
            Console.WriteLine($"nicht solange {_Name} da ist ");
        }
    }
}
