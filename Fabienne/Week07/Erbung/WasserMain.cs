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
            List<WasserMain> wasser = new List<WasserMain>();

            wasser.Add(new WasserMain());

            foreach (WasserMain w in wasser)
            {
              //  w.PrintMe();
            }
        }    
    }
}
