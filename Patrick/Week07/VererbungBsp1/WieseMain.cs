using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrick.Week07.VererbungBsp1
{
    internal class WieseMain
    {
        public static void Start()
        {
            List<Rind> rinds = new List<Rind>();

            rinds.Add(new Rind("Helmut", 10));
            rinds.Add(new Milchkuh("Sabine", 5, 85.8f));
            rinds.Add(new Rind("Sandra", 1));
            rinds.Add(new Rind("Tobias", 3));

            rinds.Add(new Kalb("Johanna", 1, 200f, "Kinder besuchen das Kalb"));

            foreach (Rind rind in rinds)
            {
                rind.PrintMe();
            }
        }

    }
}
