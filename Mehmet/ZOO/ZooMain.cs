using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mehmet.Zoo
{
    internal class ZooMain
    {
        public static void Start()
        {
            Zoo z = new Zoo ("BzBahnhof",1951);

            Console.WriteLine(z);
        }
    }
}
