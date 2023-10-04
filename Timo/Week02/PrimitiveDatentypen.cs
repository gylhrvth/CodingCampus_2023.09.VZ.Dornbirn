using System;
using Timo.Week01;

namespace Timo.Week02
{
    public class PrimitiveDatentypen
    {
        public static void Start()
        {
            Console.WriteLine("\nAufgabe1: Summe");
            Summe(20, 21);


            Console.WriteLine("\nAufgabe2: Faktorial");
            Faktorial(20);

            Console.WriteLine("\nAufgabe3: Von 0 bis 100 Zählen in 0.1er Schritten \nVariante1");
            CountPlus01Var1(10);

            Console.WriteLine("\nAufgabe3: Von 0 bis 100 Zählen in 0.1er Schritten \nVariante2");
            CountPlus01Var2(10);


            CountPlus01Extended(5);
        }


        //Aufgabe1: Summe
        public static void Summe(int start, int stop)
        {
            int sum = 0;
            for (int i = start; i <= stop; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine(sum);
        }


        //Aufgabe2: Faktorial
        public static void Faktorial(int number)
        {
            long fakt = 1;
            for (int i = 1; i <= number; i++)
            {
                fakt = fakt * i;
                Console.WriteLine($"{i,-2} ! = {fakt,20}");
            }
        }


        //Aufgabe3: Von 0 bis 100 Zählen in 0.1er Schritten
        //Variante 1
        public static void CountPlus01Var1(int stop) 
        {
            for (float i = 0; i <= stop; i = (float)(i + 0.1))
            {
                Console.WriteLine(Math.Round(i, 2));
            }
        }


        //Aufgabe3: Von 0 bis 100 Zählen in 0.1er Schritten
        //Variante 2
        public static void CountPlus01Var2(int stop)
        {
            double i = 0;
            while (i < stop)
            {
                Console.WriteLine(Math.Round(i, 2));
                i =i+0.1;
            }
        }



        public static void CountPlus01Extended(int stop)
        {
            for (float i = 0; i <= stop; i = (float)(i + 0.1))
            {
                Console.WriteLine(i);
            }
        }
    }
}

