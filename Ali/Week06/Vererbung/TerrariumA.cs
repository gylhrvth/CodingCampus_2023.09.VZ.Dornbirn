using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ali.Week06.Vererbung
{
    public class TerrariumA
    {
        public static void Start()
        {
            List<Art> terrarium = new List<Art>();

            terrarium.Add(new Art("Axolotl", 12));
            terrarium.Add(new Art("Frosch", 2));
            terrarium.Add(new Art("Lurch", 4));
            terrarium.Add(new Art("Schleichlurche", 3));

            foreach (Art art in terrarium)
            {
                art.PrintMe();
            }

        }


    }
}
