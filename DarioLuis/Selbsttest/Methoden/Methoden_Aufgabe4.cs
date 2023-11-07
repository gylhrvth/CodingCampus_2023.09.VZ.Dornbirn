using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DarioLuis.Selbsttest.Methoden
{
    public class Methoden_Aufgabe4
    {
        public static void Start()
        {
            Printslash();
        }
        public static void Printslash()
        {
            bool slash = true;
            string character = "x";

            if (slash)
            {
                for (int i = 0; i < 1 ; i++)
                {
                    Console.WriteLine(character);
                    Console.WriteLine(" " + character);
                    Console.WriteLine("  " + character);
                    
                }
            }
            if (slash == false)
            {
                Console.WriteLine("  " + character);
                Console.WriteLine(" " + character);
                Console.WriteLine(character);
            }
        }
    }
}
