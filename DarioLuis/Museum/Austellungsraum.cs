using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarioLuis.Museum
{
    public  class Austellungsraum:Raum
    {
        public Austellungsraum(string name, ConsoleColor cc):base (name, cc) 
        {
            
        }

        public override void PrintMich(string prefix)
        {
            Console.Write($"{prefix} Ausstellungsraum: {Name}");

        }
    }

}
