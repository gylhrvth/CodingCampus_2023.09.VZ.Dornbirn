using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Mohammed.Week02
{
    public class Day02
    {
        public static void Day02start()
        {

            Console.WriteLine("pi rechnung Nilakantha reihe");
            piNilakantha();


            //Console.WriteLine("Pi rechnungen Leiniz Reihe");
            //PiRechnung();
            //pi Berechnung



            //Console.WriteLine("Zählen in 0.1er Schritten");
            //TeilenUndHerrschen();



            //Console.WriteLine("count2");
            //count2();



            //from 0 to 100 count in 0.1 steps.

            //Console.WriteLine("Count");
            //count();


            //ADD

            //Console.WriteLine(Add(3, 2));
            //int c = Add();
            //Console.WriteLine(c);

            //LONG// da muss aufgerufen.

            //for (int i = 1; i <= 20; i++)
            //{
            //    Console.WriteLine("{0,2}! = {1,20}", i, Factorialcalculus(i));
            //}
        }



        public static int Add()
        {
            int result = 0;

            for (int i = 20; i <= 50; i++)
            {
                result += i;
            }
            return result;

        }


        //da habe ich die methode ein Faktorial benutzt: siehe oben!
        public static long Factorialcalculus(int n)
        {
            long solution = 1;

            for (int i = 1; i <= n; i++)
            {
                solution *= i;
            }
            return solution;



        }


        //from 0 to 100 count in 0.1 steps.
        public static void count()
        {
            for (double a = 0; a < 100; a = a + 0.1)
            {
                Console.WriteLine("hallo: " + a);
            }
        }



        public static void count2()
        {

            for (int i = 0; i < 20; i++)
            {
                double result = i / 5;
                Console.WriteLine($"{i} / 5   = {result}");
                double result2 = i / 5.0;
                Console.WriteLine($"i ist ={i} / 5.0 = {result2}");
                Console.WriteLine("------");
            }




        }


        public static void TeilenUndHerrschen()
        {
            for (int a = 0; a < 100; a++)
            {
                double result = a + 0.1;
                Console.WriteLine($"{a} + 0.1 = {result}");
                Console.WriteLine("------");
            }
        }


        public static void PiRechnung()
        {
            double numberpi = 0;

            for (int i = 1; i < 100000000; i = i + 4)
            {
                numberpi = numberpi + (4.0 / i);
                numberpi = numberpi - (4.0 / (i + 2));
            }

            Console.WriteLine(numberpi);
        }




        public static void piNilakantha()
        {

            double pi = 0;

            for (double a = 2; a<1000000; a+=2)
            {
                pi -= 4.0 / a;
                pi *= -1;
            }Console.WriteLine(pi);

        }








    }
}


