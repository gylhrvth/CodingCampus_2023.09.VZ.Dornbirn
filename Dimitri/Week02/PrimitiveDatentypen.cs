﻿using System;
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
            //NullBisHundertv2(0.0, 100.0);
            //Console.WriteLine("\r\n/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\\r\n");
            //TeilenUndHerrschen();
            //Console.WriteLine("\r\n/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\\r\n");
            //Console.WriteLine(PiLeibnizReihe(100000));
            //Console.WriteLine("\r\n/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\\r\n");
            //Console.WriteLine(PiNilakanthaReihe(100000));
            //Console.WriteLine("\r\n/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\\r\n");
            GeheimeReihe();
            //WurzelAnnäherung();
            Console.WriteLine(WurzelAnnaeherung(500));
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

            for(int i=0; i<1000;i++)
            {
                double quadr = mitte * mitte;

                if(quadr > random)
                {
                    max = mitte;
                } else if(quadr < random)
                {
                    min = mitte;
                } else
                {
                    break;
                }
                mitte = (max + min)/2;
                Console.WriteLine("Mitte: " + mitte);
            }




            return awurzel;

        }

        //public static void WurzelAnnäherung()
        //{
        //    double random = new Random().Next(10000) + 1;

        //    Console.WriteLine(random);

        //    double minimum = random / 2;

        //    for(double i = minimum; i < random; ())
        //    {
        //        minimum = random * random;
        //        if(minimum > random)
        //        {
        //            minimum
        //        }


        //    }


        //    double squareEz = Math.Sqrt(random);

        //    Console.WriteLine(squareEz);


        //}
    }
}
