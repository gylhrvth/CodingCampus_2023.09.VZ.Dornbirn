using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Niklas.Week07.Selbsttest
{
    internal class Schleifen

    {
        static public void Start()
        {
            CountUp();
            Console.WriteLine();
            Count2();
            Console.WriteLine();
            Count3();

        }
        public static void CountUp()
        {
            for (int i = 10; i >= 0; i--)
            {
                Console.Write(i + " ");
            }
        }
        public static void Count2()
        {
            for (int i = -30; i <= 30; i++)
            {
                if (i % 3 == 0)
                {

                    Console.Write(i + " ");
                }
            }
        }
        public static void Count3()
        {
            int i = 0;
            while (i <= 10)
            {
                Console.Write(i + " ");
                if (i > 5)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                }
                i++;
            }
        }
    }
}
