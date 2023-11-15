using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarioLuis.Selbsttest.Methoden
{
    public class Methoden_Aufgabe2
    {
        public static void Start()
        {
            PrintRowTrippleX();
        }
        public static void PrintRowTrippleX()
        {
            char symbol = 'X';
            int amount = 3;

            for (int i = 0; i <= amount - 1; i++) 
            {
                Console.WriteLine(symbol);
                Console.WriteLine();

            }
        }
    }
}
