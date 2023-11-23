using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Selina.Week08.Museum
{
    public class  Kunstraum : Raum
    {
        public Kunstraum(string name) : base(name)
        {
        }

        protected override void GangOfMuseum(string prefix)
        {
            Console.Write($"{prefix} Exhibition: {Name}");
        }
    }
}
