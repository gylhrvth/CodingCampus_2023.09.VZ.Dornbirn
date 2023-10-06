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
            //FaktorialExtended(21);
            //Console.WriteLine("\r\n/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\\r\n");
            //NullBisHundertv2(0.0, 100.0);
            //NullBisHundertv1(0.0, 100.0);
            //Console.WriteLine("\r\n/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\\r\n");
            //TeilenUndHerrschen();
            //Console.WriteLine("\r\n/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\\r\n");
            //Console.WriteLine(PiLeibnizReihe(100000));
            //Console.WriteLine("\r\n/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\\r\n");
            //Console.WriteLine(PiNilakanthaReihe(100000));
            //Console.WriteLine("\r\n/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\\r\n");
            //GeheimeReihe();
            //Console.WriteLine(WurzelAnnaeherung(500));
            Console.WriteLine(WurzelAnnaeherungBonus(1297419));
            //IstPrimzahl(31);
            //PrintAllePrimzahlen(31);
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
            if (input > 20)
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

            for (double i = start * 100; i <= end * 100; i += 10)
            {
                solution = i / 100.0;
                Console.Write("Result 1 digit = ");
                Console.WriteLine("{0,-3:0.0}", solution);
                Console.Write("Result 2 digit = ");
                Console.WriteLine("{0,7:0.00}", solution);
            }
        }

        public static void NullBisHundertv2(double start, double end)
        {
            double solution;
            double i = start * 100;

            while (i <= end * 100)
            {
                solution = i / 100.0;
                Console.Write("Result 1 digit =");
                Console.WriteLine("{0,-3:0.0}", solution);
                Console.Write("Result 2 digit =");
                Console.WriteLine("{0,7:0.00}", solution);
                i += 10;
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

        public static double PiLeibnizReihe(int precision)
        {
            double positiveSum = 0;
            double negativeSum = 0;
            for (double i = 1; i < precision; i = i + 4)
            {
                positiveSum += 4 / i;
            }

            for (double i = 3; i < precision; i = i + 4)
            {
                negativeSum -= 4 / i;
            }

            double pi = positiveSum + negativeSum;

            return pi;
        }

        public static double PiNilakanthaReihe(int precision)
        {
            double positiveSum = 0;
            double negativeSum = 0;
            for (double i = 2; i < precision; i = i + 4)
            {
                positiveSum += 4 / (i * (i + 1) * (i + 2));
            }

            for (double i = 4; i < precision; i = i + 4)
            {
                negativeSum -= 4 / (i * (i + 1) * (i + 2));
            }

            double pi = 3 + positiveSum + negativeSum;

            return pi;
        }

        public static void GeheimeReihe()
        {
            double result = 1;
            for (int i = 0; i < 10; i++)
            {
                result = result / 2 + 1 / result;
                Console.WriteLine(result);
            }
            //return result;
        }

        public static double WurzelAnnaeherung(double random)
        {
            double awurzel = random;
            double mitte = awurzel / 2;
            double min = 0;
            double max = random;

            for (int i = 0; i < 1000; i++)
            {
                double quadr = mitte * mitte;

                if (quadr > random)
                {
                    max = mitte;
                }
                else if (quadr < random)
                {
                    min = mitte;
                }
                else
                {
                    break;
                }
                mitte = (max + min) / 2;
                Console.WriteLine("Mitte: " + mitte);
            }




            return awurzel;

        }

        public static double WurzelAnnaeherungBonus(double random)
        {
            double awurzel = random;
            double mitte = awurzel / 2;
            double min = 0;
            double max = random;
            int count = 0;

            for (int i = 0; i < 1000; i++)
            {
                double quadr = mitte * mitte;

                if (quadr > random)
                {
                    max = mitte;
                }
                else if (quadr < random)
                {
                    min = mitte;
                }
                else
                {
                    break;
                }
                mitte = (max + min) / 2;

                Console.WriteLine();

                Console.WriteLine("Mitte: " + mitte);

                double differenz = Math.Abs(mitte - Math.Sqrt(random));

                double fehlerInProzent = differenz / Math.Sqrt(random);

                Console.WriteLine(fehlerInProzent + "%");

                if (fehlerInProzent >= 0.1)
                {
                    count++;
                }
            }


            Console.WriteLine(count);



            return awurzel;

        }

        public static void IstPrimzahl(long x)
        {
            bool istPrim = false;
            for (int i = 2; i < x; i++)
            {
                if (x % i == 0)
                {
                    istPrim = false;
                    break;
                }
                else
                {
                    istPrim = true;
                }
            }

            if (istPrim)
            {
                Console.WriteLine(x + " ist eine Primzahl");
            }
            else
            {
                Console.WriteLine(x + " ist keine Primzahl");
            }
        }

        public static void PrintAllePrimzahlen(int x)
        {
            bool istPrim = false;
            int count = 0;
            for (int i = 1; i <= x; i++)
            {

                for (int j = 1; j <= i; j++)
                {
                    if (i == 2)
                    {
                        istPrim = true;
                        break;
                    }
                    else if (i % j == 0 && j != 1 && j != i)
                    {
                        istPrim = false;
                        break;

                    }
                    else if (i % j != 0)
                    {
                        istPrim = true;
                        break;
                    }
                }

                if (istPrim) { count++; }

                if (count == 2)
                {
                    Console.WriteLine((i - 1) + " und " + i + " sind Primzwillinge.");

                    count = 0;
                }

            }


        }

    }
}