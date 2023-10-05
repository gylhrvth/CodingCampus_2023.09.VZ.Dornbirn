using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Simon.Week02
{
    public class UebenPrimitiveDatentypen
    {
        public static void Start()
        {
            bool isNumber = true;
            Console.WriteLine(isNumber);

            bool isBig = false;
            Console.WriteLine(isBig);

            Console.WriteLine("!false : " + !false);
            Console.WriteLine("!true  : " + !true);

            Console.WriteLine("true and true   :" + (true && true));
            Console.WriteLine("true and false  :" + (true && false));
            Console.WriteLine("false and true  :" + (false && true));
            Console.WriteLine("false and false :" + (false && false));

            Console.WriteLine("true or true   :" + (true || true));
            Console.WriteLine("true or false  :" + (true || false));
            Console.WriteLine("false or true  :" + (false || true));
            Console.WriteLine("false or false :" + (false || false));

            int iX = 5;
            Console.WriteLine("i == 5: " + (iX == 5));
            Console.WriteLine("i != 5: " + (iX != 5));
            Console.WriteLine("i <  7: " + (iX < 7));
            Console.WriteLine("i <= 7: " + (iX <= 7));
            Console.WriteLine("i >  7: " + (iX > 7));
            Console.WriteLine("i >= 7: " + (iX >= 7));


            int size = 7;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (i == j)
                    {
                        Console.Write("X ");
                    }
                    else
                    {
                        Console.Write(". ");
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            Console.WriteLine("Aufgabe Summe");
            PrintSummeGanzzahlen(20, 25);

            Console.WriteLine("Aufgabe Faktorial");
            PrintFaktorial(1, 20);

            Console.WriteLine("Aufgabe count");
            PrintCount(0, 5);

            Console.WriteLine("\nAufgabe count v2");
            PrintCountv2(9, 10);

            Console.WriteLine("\nAufgabe Teilen und Herrschen");
            Printdevide(0, 20);
        }
        //Aufgabe Summe
        public static int PrintSummeGanzzahlen(int number1, int number2)
        {
            int summ = 0;
            for (int i = number1; i <= number2; i++)
            {
                summ = summ + i;

            }
            Console.WriteLine(summ);
            return summ;
        }
        //Aufgabe Produkt
        public static long PrintFaktor(long number2)
        {
            long summ = 1;
            for (long i = 1; i <= number2; i++)
            {
                summ = summ * i;
            }
            return summ;
        }
        //Aufgabe Faktorial
        public static long PrintFaktorial(long number1, long number2)
        {
            //int faktorial = 0;
            for (long i = number1; i <= number2; i++)
            {
                //for(int j = 0; j < i; j++) 
                //{

                //Console.Write($"{i,2} ! = {0,20}");
                Console.WriteLine("{0, 2}! = {1, 20}", i, PrintFaktor(i));
                //}
            }
            return 0;
        }
        //Aufgabe Summe
        public static long PrintFaktorv2(long number1, long number2)
        {
            long summ = 1;
            for (long i = number1; i <= number2; i++)
            {
                summ = summ * i;
                Console.WriteLine($"{i,2} ! ={summ,20}");
            }
            return summ;
        }
        //Aufgabe Von 0 bis 100 Zählen in 0.1er Schritten
        public static double PrintCount(double number1, double number2)
        {
            for (double i = number1; i <= number2; i += 0.1)
            {
                Console.WriteLine("Result 1 digit = {0:N1}", i);
                Console.WriteLine($"Result 2 digit = {i:0.00}");
            }
            return number2;
        }
        //Aufgabe Von 0 bis 100 Zählen in 0.1er Schritten v2
        public static double PrintCountv2(int number1, int number2)
        {
            int start = 0;
            for (int i = number1; i < number2 * 10; i++)
            {
                start = start + 10;
                Console.WriteLine("Result 1 digitv2 = {0:N2}", start / 100.0);
            }
            return number2;
        }
        //Aufgabe Teilen und Herrschen
        public static double Printdevide(int number1, int number2)
        {
            for (int i = number1; i <= number2; i++)
            {
                Console.Write("{0, 3} / {1:0.0} =", i, 5);
                Console.WriteLine(i / 5.0);
                Console.Write("{0, 3} / {1, -3} =", i, 5);
                Console.WriteLine(i / 5);
            }
            return 0;

        }
        //Aufgabe 
    }
}

