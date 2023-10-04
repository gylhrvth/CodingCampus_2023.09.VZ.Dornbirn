using System;
using Timo.Week01;

namespace Timo.Week02
{
    public class PrimitiveDatentypen
    {
        public static void Start()
        {
            Console.WriteLine("\nAufgabe1: Summe");
            int sum= Summe(20, 21);


            Console.WriteLine("\nAufgabe2: Faktorial");
            long fakt= Faktorial(20);
            

            Console.WriteLine("\nAufgabe3: Von 0 bis 100 Zählen in 0.1er Schritten \nVariante1");
            CountPlus01Var1(100);

            Console.WriteLine("\nAufgabe3: Von 0 bis 100 Zählen in 0.1er Schritten \nVariante2");
            CountPlus01Var2(100);
            /*
            Console.WriteLine("\nAufgabe4: Von 0 bis 100 Zählen in 0.1er Schritten erweitert");
            CountPlus01Extended(5);
            */
            Console.WriteLine("\nAufgabe5: Teilen und Herrschen");
            Divide(0, 20);
        }


        //Aufgabe1: Summe
        public static int Summe(int start, int stop)
        {
            int sum = 0;
            for (int i = start; i <= stop; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine(sum);
            return sum;
        }


        //Aufgabe2: Faktorial
        public static long Faktorial(int number)
        {
            long fakt = 1;
            for (int i = 1; i <= number; i++)
            {
                fakt = fakt * i;
                Console.WriteLine($"{i,2} ! = {fakt,20}");
                
            }
            return fakt;
        }


        //Aufgabe3: Von 0 bis 100 Zählen in 0.1er Schritten
        //Variante 1
        public static float CountPlus01Var1(int stop) 
        {
            for (float i = 0; i <= stop; i = (float)(i + 0.1))
            {
                Console.WriteLine(Math.Round(i, 2));
            }
            return 0;
        }


        //Aufgabe3: Von 0 bis 100 Zählen in 0.1er Schritten
        //Variante 2
        public static double CountPlus01Var2(int stop)
        {
            int d = 0;
            Console.WriteLine(d);
            for (int i = 0; i < stop*10; i++)
            {
                d = d + 10; 
                Console.WriteLine(d / 100.0);
            }
            return d;
        }


        //Aufgabe4: Von 0 bis 100 Zählen in 0.1er Schritten erweitert
        //TODO fertigstellen!
        public static double CountPlus01Extended(int stop)
        {
            for (double i = 0; i <= stop; i = i+0.1)
            {
                Console.WriteLine($"Result 1 digit = {i:0.0}");
                Console.WriteLine($"Result 2 digit =    {i:0.00}");
            }
            return 0;
        }


        //Aufgabe5: Teilen und Herrschen
        public static double Divide(int start, int stop)
        {
            for(int i = start; i <= stop; ++i)
            {
                int a=i/5;
                double b=i/5.0;
                Console.WriteLine(i + " / 5 = " + a);
                Console.WriteLine(i + " / 5.0 = " + b);
            }
            return 0;
        }
    }
}

