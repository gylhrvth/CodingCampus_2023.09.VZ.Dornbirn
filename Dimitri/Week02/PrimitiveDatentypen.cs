using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dimitri.Week02
{
    internal class PrimitiveDatentypen
    {
        public static void Main()
        {
            Console.WriteLine(Summe(20, 50));

            Console.WriteLine(Faktorial(10));
            FaktorialExtended(1);


        }

        public static int Summe(int start, int end) //void hat keinen rückgabewert und int/bool/float hat genau einen Rückgabewert
        {
            int solution = 0;
            for (int i = start; i <= end; i++)
            {
                solution += i;
            }

            return solution;
        }

        public static long Faktorial(long input)
        {
            long solution = 1;
            for (long i = 1; i <= input; i++)
            {
                solution *= i;
            }
            return solution;

        }

        public static void FaktorialExtended(long input)
        {
            if (input <= 0 || input > 0)
            {
                input = 20;
            }
            long solution = 1;
            Console.WriteLine("Bonus Aufgabe");
            for (long i = 1; i <= input; i++)
            {
                solution *= i;
                Console.Write("{0,-20}", i + "! =");
                Console.WriteLine("{0,20}", solution);
            }
        }
    }
}
