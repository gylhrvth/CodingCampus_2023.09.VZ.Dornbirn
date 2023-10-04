using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dimitri.Week02
{
    internal class PrimitiveDatentypen
    {
        public static void Main()
        {
            //Console.WriteLine(Summe(20, 50));
            //Console.WriteLine("\r\n/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\\r\n");
            //Console.WriteLine(Faktorial(10));
            //Console.WriteLine("\r\n/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\\r\n");
            //FaktorialExtended(40);
            //Console.WriteLine("\r\n/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\\r\n");
            //NullBisHundertv1(0.0, 100.0);
            //Console.WriteLine("\r\n/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\\r\n");
            TeilenUndHerrschen();


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
            if(input > 20)
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

        public static void NullBisHundertv1(double start, double end)
        {
            double solution;

            for (double i = start * 100; i <= end*100; i+=10)
            {
                solution = i / 100.0;
                Console.Write("Result 1 digit =");
                Console.WriteLine("{0,-3:0.0}", solution);
                Console.Write("Result 2 digit =");
                Console.WriteLine("{0,7:0.00}", solution);
            }
        }

        public static void TeilenUndHerrschen()
        {
            double solution;
            for (int i = 0; i <= 20; i++)
            {
                solution = i / 5;
                Console.WriteLine(i + " / 5 = " + solution);
                solution = i / 5.0;
                Console.WriteLine(i + " / 5.0 = " + solution);
            }

        }
    }
}
