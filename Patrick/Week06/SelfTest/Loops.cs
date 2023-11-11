using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrick.Week06.SelfTest
{
    internal class Loops
    {
        public static void Start()
        {
            Aufgabe1();
            Aufgabe2();
            Aufgabe3();
        }

        public static void Aufgabe1()
        {
            Console.Write("[");
            for (int i = 10; i >= 0; i--)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("]");
        }

        public static void Aufgabe2()
        {
            Console.Write("[");
            for (int i = -30; i <= 30; i++)
            {
                if (i % 3 == 0)
                {
                   
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine("]");
        }

        public static void Aufgabe3()
        {
            int i = 0;
            while (i <= 10)
            {
                if (i > 5)
                {
                    Console.WriteLine();
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine(i);
                }
                i++;
            }
        }



    }
}
