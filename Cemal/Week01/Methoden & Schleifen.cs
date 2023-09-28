using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Cemal.Week01
{
    public class Methoden_Schleifen
    {
        public static void Start()
        {
            PrintChars("x", 10);
        }

        public static void PrintChars(String symbol, int count)
        {

            Console.WriteLine("Aufgabe Print Characters");

            for (int i = 0; i < count; i++)
            {
                Console.Write(symbol);

            }

            Console.WriteLine("\nAufgabe Print Square");

            for (int i = 0; i < count; i++)
            {
                Console.Write(symbol);

         
            }
        }
    }
}
