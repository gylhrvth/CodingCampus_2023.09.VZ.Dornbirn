using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erik.Week06
{
    public class DynamicDatastructureByGyulaMain
    {
        public static void Start()
        {
            DynamicDatastructureByGyula dds = new DynamicDatastructureByGyula(0, 100, -100);
            DynamicDatastructureByGyula dds2 = new DynamicDatastructureByGyula(20, 0, 10);
            dds.Print();
            Console.WriteLine("Maximum: {0}", dds2.GetMaximum());
        }
    }
}
