using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DarioLuis.Museum
{
    public class Hallway:Raum
    {
        public Hallway(string name):base(name) { }

        protected override void PrintMyself(string prefix)
        {
            Console.WriteLine($"{prefix} Hallway: {_Name}");
        }
    }
}
