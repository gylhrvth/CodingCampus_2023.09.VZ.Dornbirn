using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cemal.Week02
{
    internal class Datentypen
    {
        public static void StartDatentypen()
        {
            Console.WriteLine("Aufgabe Summe");
            int sum = Summe(20, 50);
            Console.WriteLine("Summe: " + sum);
            Console.WriteLine();


            Console.WriteLine("Aufgabe Faktorial");
            for (int i = 1; i < 20; i++)
            {
                Console.WriteLine("{0, 2}! = {1, 20}", i, Faktorial(i));
            }
            Console.WriteLine();


            Console.WriteLine("Aufgabe Zähler");
            Zähler();
            Console.WriteLine();

            Console.WriteLine("Aufgabe Zähler1");
            double dif2 = Zähler1(100);
            Console.WriteLine();

            Console.WriteLine("Aufgabe Teilen und Herrschen");
            TeilenHerrschen();
            Console.WriteLine();

            Console.WriteLine("Alt version");
            Alt();
            Console.WriteLine();

            Console.WriteLine("Leibniz PI");
            LeibnizPI();
            Console.WriteLine();
        }

        public static int Summe(int first, int second)
        {
            int result = 0;
            for (int i = first; i <= second; i++)
            {
                result += i;
            }
            return result;
        }

        public static long Faktorial(long second)
        {
            long result = 1;
            for (long i = 1; i <= second; i++)
            {
                result *= i;
            }
            return result;
        }

        public static void Zähler()
        {
            double first = 0;
            double second = 10;
            double step = 0.1;

            for (double i = first; i <= second; i += step)
            {
                Console.WriteLine(Math.Round(i, 2));
            }

            Console.WriteLine();
        }

        public static double Zähler1(double dif)
        {
            double first = 0;
            double second = 10;
            double step = 0.1;

            for (double i = first; i <= second; i += step)
            {
                Console.WriteLine(Math.Round(i, 2));
            }
            return dif;
        }

        public static void Alt()
        {
            double result = 0;
            string eins = "Result 1 digit = ";
            string zwei = "Result 2 digit = ";

            for (int i = 0; i <= 100; i++)
            {
                result += 0.1;
                Console.WriteLine($"{eins}{result:0.0}");
                Console.WriteLine("{1,0}{0,7:N2}", result, zwei);
            }
        }


        public static void TeilenHerrschen()
        {
            for (int i = 0; i <= 20; i++)
            {
                string erste = " = ";
                string zweite = " = ";

                Console.WriteLine("{0,2} / 5 {1,5}" + i / 5, i, erste);
                Console.WriteLine("{0,2} / 5.0{1,4}" + i / 5.0, i, zweite);
                Console.WriteLine("---------------");


            }
        }

        public static void LeibnizPI()
        {
            double result = 0;

            for (int i = 1; i <= 20; i += 2)
            {
                if (i % 4 == 1)
                {
                    result += 4.0 / i;
                }
                else if (i % 4 == 3)
                {
                    result -= 4.0 / i;
                }

                Console.WriteLine(result);
            }
        }

    }
}
