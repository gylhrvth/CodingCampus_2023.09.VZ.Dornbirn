using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DarioLuis.Museum
{
    public class Gang:Raum
    {
        public string _Name;

        public Gang(string name):base(name) { }

        public override void AufenthaltsOrt(string index)
        {
            Console.WriteLine(index);
        }
    }
}
