using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DarioLuis.Museum
{
    public class Hallway : Raum
    {
        public Hallway(string name):base(name) { }

        public override void PrintMich(string prefix)
        {
            Console.Write($"{prefix} Hallway: {Name}");
        }
    }
}
