using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selina.Week08.Museum
{
    public class Gang : Raum
    {
        public Gang(string name) : base(name)
        {
        }

        protected override void GangOfMuseum(string index)
        {
            Console.Write($"{index} Gang: {Name}");
        }
    }
}
