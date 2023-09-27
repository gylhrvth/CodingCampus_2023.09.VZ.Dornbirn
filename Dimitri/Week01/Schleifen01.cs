using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dimitri.Week01
{
    internal class Schleifen01
    {
        public static void Start()
        {
            for(int i = 0; i <= 10; i++)
            {
                Console.WriteLine("i: " + i);
            }

            int j = 0;
            while (j <= 10)
            {
                Console.WriteLine("j: " + j);
                j++;
            }
        }
    }
}
