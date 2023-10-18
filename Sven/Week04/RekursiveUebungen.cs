using System;
using System.ComponentModel.Design;

namespace Sven.Week04
{
    internal class RekursiveUebungen
    {
        public static void RekursiveExamples()
        {
            Console.WriteLine("Rekursive Summe:");
            RekursiveSumme(4);
            Console.WriteLine();

        }

        public static int RekursiveSumme(int number)
        {
            if (number == 0)
            {
                return number;
            }

            else
            {
                int sum = number + RekursiveSumme(number - 1);
            }
            return number;
        }

    }
}
