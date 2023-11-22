using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Niklas.Week07.Vererbung
{
    public class Specialise : Fish
    {
        private string _Species;

        public Specialise(string name, bool eatable, string species) : base(name, eatable)
        {
            _Species = species;
        }

        public override void PrintMe()
        {
            Console.WriteLine($"Its a {_Name} and its special");
        }
    }
}
