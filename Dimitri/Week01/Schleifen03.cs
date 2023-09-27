using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dimitri.Week01
{
    internal class Schleifen03
    {
        public static void Start()
        {
            for (int i = 0; i <= 10; i = i + 2)
            {
 //               if (i % 2 == 0)
 //               {
                    Console.WriteLine("i: " + i);
 //               }
            }

            int j = 0;
            while(j % 2 == 0 & j <= 10)
            {
                Console.WriteLine($"j: {j}");
                j = j + 2;
            }
        }
    }
}
