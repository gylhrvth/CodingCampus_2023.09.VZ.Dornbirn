using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dimitri.Week06._05Zoo
{
    public class Tier
    {
        private string _Name;
        private string _Gattung;

        public Tier(string name, string gattung)
        {
            _Name = name;
            _Gattung = gattung;
        }

        public void PrintTier()
        {
            Console.WriteLine("public Tier(string name, string gattung)\r\n    {\r\n\r\n    }");
        }
    }

    
}
