using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabienne.Week07.Erbung
{
    public class WasserMain
    {
       public static void Start()
       {
            List<Water> wasser = new List<Water>();

            wasser.Add(new Water("Leitungswasser"));
            wasser.Add(new MineralWasser("Prickelnd", 1));

            foreach (Water w in wasser)
            {
              w.Print();
            }
        }    
    }
}
