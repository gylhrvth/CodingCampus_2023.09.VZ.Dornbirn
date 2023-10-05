using System;
using Timo.Week01;

namespace Timo.Week02
{
    public class PrimitiveDatentypen
    {
        public static void Start()
        {
            /*
            Console.WriteLine("\nAufgabe1: Summe");
            int sum= Summe(20, 21);
            Console.WriteLine(sum);
            

            Console.WriteLine("\nAufgabe2: Faktorial");
            for (int i = 1; i < 20; i++)    //i < x! (x faktoriell)
            {
                long fakt = Faktorial(i);
                Console.WriteLine("{0,2} ! = {1,20}", i, fakt);
            }


            Console.WriteLine("\nAufgabe3: Von 0 bis 100 Zählen in 0.1er Schritten \nVariante1");
            Console.WriteLine("0");
            for (int j = 0; j < 100*10; j++)    //j < x * 10 (x = Ende)
            {
                double result = CountPlus01Var1(j);
                Console.WriteLine(Math.Round(result, 2));
            }
            Console.WriteLine("\nAufgabe3: Von 0 bis 100 Zählen in 0.1er Schritten \nVariante2");
            for (int j = 0; j <= 100*10; j++)   //j < x * 10 (x = Ende)
            {
                int d = CountPlus01Var2(j);
                Console.WriteLine(d / 100.0);
            }
            
            Console.WriteLine("\nAufgabe4: Von 0 bis 100 Zählen in 0.1er Schritten erweitert");
            for (int j = 0; j <= 100 * 10; j++)   //j < x * 10 (x = Ende)
            {
                double result = CountPlus01Extended(j);
                Console.WriteLine("Result 1 digit = {0:0.0}", result);
                Console.WriteLine("result 2 digit = {0,9:N2}", result);
            }
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
            //Console.WriteLine(sum);
            return sum;
        }


        //Aufgabe2: Faktorial
        public static long Faktorial(int number)
        {
            long fakt = 1;
            for (int i = 1; i <= number; i++)
            {
                fakt = fakt * i;
            }
            return fakt;
        }
        //ToDo 


        //Aufgabe3: Von 0 bis 100 Zählen in 0.1er Schritten
        //Variante 1
        public static double CountPlus01Var1(int j)
        {
            double result = 0;
            for (int i = 0; i <= j; i++)
            {
                //Console.WriteLine(Math.Round(result, 2));
                result = result + 0.1;
            }
            return result;
        }


        //Aufgabe3: Von 0 bis 100 Zählen in 0.1er Schritten
        //Variante 2
        public static int CountPlus01Var2(int j)
        {
            int d = 0;
            for (int i = 0; i < j; i++)
            {
                d = d + 10;
            }
            return d;
        }


        //Aufgabe4: Von 0 bis 100 Zählen in 0.1er Schritten erweitert
        //TODO fertigstellen!
        public static double CountPlus01Extended(int j)
        {
            double result = 0;
            int a = 0;
            for (double i = 0; i <= j; i++)
            {
                a = (a + 10);
                result = ((a -10) / 100.0);
            }
            return result;
        }


        //Aufgabe5: Teilen und Herrschen
        public static double Divide(int start, int stop)
        {
            for (int i = start; i <= stop; ++i)
            {
                int a = i / 5;
                double b = i / 5.0;
                Console.WriteLine(i + " / 5 = " + a);
                Console.WriteLine(i + " / 5.0 = " + b);
            }
            return 0;
        }
    }
}

