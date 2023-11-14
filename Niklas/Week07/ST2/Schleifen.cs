using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Niklas.Week07.ST2
{
    internal class Schleifen
    {
        public static void Start()
        {
            Aufgabe1();
            Console.WriteLine();
            Aufgabe2();
            Console.WriteLine();
            Aufgabe3();
        }

        public static void Aufgabe1()
        {
            for (int i = 10;  i > 0; i--)
            {
                Console.Write(i + " ");
            }
        }
        public static void Aufgabe2()
        {
            for (int i = -30;  i< 30; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i + " ");
                }
            }
        }
        public static void Aufgabe3()
        {
            for (int i = 0; i < 10; i++)
            {
                if (i > 6)
                {
                    Console.WriteLine();
                }
                Console.WriteLine(i + " ");
            }
        }
    }
}
