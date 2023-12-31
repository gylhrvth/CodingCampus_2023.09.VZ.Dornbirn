﻿using System;
using System.Diagnostics.CodeAnalysis;
using System.Net.Mail;
using System.Reflection;

namespace Sven.Week02
{
    public class DatentypenUebungen
    {

        public static void StartDatentypenUebungen()
        {
            Console.WriteLine("Result Summe: ");
            Console.WriteLine(AddN());
            Console.WriteLine();

            Console.WriteLine("Result Faktiorial: ");
            for (int i = 1; i <= 20; i++)
            {
                //Console.WriteLine(i + "! = " + Faktorial(i));
                //Console.WriteLine("{0}! = {1}", i, Faktorial(i));
                Console.WriteLine("{0, 2}! = {1, 20}", i, Faktorial(i));
            }
            Console.WriteLine();

            Console.WriteLine("Result Zählen:");
            Zaehlen();
            Console.WriteLine();

            Console.WriteLine("Result Zählen2:");
            Zaehlen2();
            Console.WriteLine();

            Console.WriteLine("Result Teilen:");
            Teilen(1) ;
            Console.WriteLine();

            Console.WriteLine("Result PiLeibnitz:");
            PiLeibnitz(1);
            Console.WriteLine();


        }


        public static int AddN()
        {
            int result = 0;
            for (int i = 20; i <= 50; i++)
            {
                result = result + i;
            }
            return result;

        }


        public static long Faktorial(int n)
        {
            long result = 1;

            for (int i = 1; i <= n; i++)
            {
                result = result * i;
            }
            return result;
        }

        public static void Zaehlen()
        {
            for (int i = 0; i <= 1000; i++)
            {
                Console.WriteLine($"{i / 10.0:N1}");
            }
        }

        public static void Zaehlen2()
        {
            double result = 0;

            for (int i = 0; i <= 1000; i++)
            {
                Console.WriteLine($"Result 1 digit: {result,3: 0.0}");
                Console.WriteLine($"Result 2 digit: {result,10: 0.00}");
                result = result + 0.1;

            }
        }

        public static double Teilen (double count)
        {
            count = 0;
            for (int i = 0; i <= 20; i++)
            {
                Console.WriteLine(i + $" / 5 = {count / 5: 0}");
                Console.WriteLine(i + $" / 5.0 = {count / 5:0.0}");
                count++;

            }
            return count;
        }

        public static double PiLeibnitz(double count)
        {





            return count;
        }
        

    }
}
