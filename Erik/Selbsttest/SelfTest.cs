using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erik.Selbsttest
{
    public class SelfTest
    {
        public static void Start()
        {
            StLoops();
        }

        public static void StLoops()
        {
            Console.WriteLine("Exercise 1\n");
            for (int i = 10; i >= 0; i--)
            {
                Console.Write(i);
            }
            Console.WriteLine("\n");
            Console.WriteLine("Exercise 2\n");
            
            for (int i = -30; i <= 30; i++)
            {
                Console.Write(i);
            }
        }
    }
}
