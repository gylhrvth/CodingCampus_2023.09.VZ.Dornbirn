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
            dds.Print();
            Console.WriteLine("Maximum: {0}", dds.GetMaximum());
        }
    }
}
