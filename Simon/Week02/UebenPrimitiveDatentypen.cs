using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
            PrintCount(0, 2);

            Console.WriteLine("\nAufgabe count v2");
            PrintCountv2(9, 10);

            Console.WriteLine("\nAufgabe Teilen und Herrschen");
            Printdevide(0, 20); //der Grund des unterschiedes ist die gegebene Formatierung in der {} klammer das mit 5.0 ist halt genauer wegen der extra stelle

            Console.WriteLine("\nBerechnung von Pi");
            double pi = CalculatePi(1, 1000000000);
            Console.WriteLine(pi);
            Console.WriteLine("PI ==");
            Console.WriteLine(Math.PI);
            Console.WriteLine("\nPI (Nilakantha Reihe)");
            double piv2 = CalculatePiv2(1000000000);
            Console.WriteLine(piv2);
            Console.WriteLine("\nPSSSSSSSSSSSSSST");
            double secret = Calculatesecret(100);
            Console.WriteLine(secret);
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
        public static long CalculatetFaktor(long number2)
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
            //faktorial = 0;
            for (long i = number1; i <= number2; i++)
            {
                //for(int j = 0; j < i; j++) 
                //{
                //Console.Write($"{i,2} ! = {0,20}");
                Console.WriteLine("{0, 2}! = {1, 20} test", i, CalculatetFaktor(i));
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
            return 0;
        }
        //Aufgabe Von 0 bis 100 Zählen in 0.1er Schritten
        public static double PrintCount(double number1, double number2)
        {
            for (double i = number1; i <= number2; i += 0.1)
            {
                Console.WriteLine("Result 1 digit = {0:N1}", i);
                Console.WriteLine($"Result 2 digit = {i:0.00}");
            }
            return 0;
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
            return start;
        }
        //Aufgabe Teilen und Herrschen
        public static double Printdevide(int number1, int number2)
        {
            double result = 0;
            for (int i = number1; i <= number2; i++)
            {
                Console.Write("{0, 3} / {1:0.0} =", i, 5);
                Console.WriteLine(i / 5.0);
                Console.Write("{0, 3} / {1, 0} =", i, 5);
                Console.WriteLine(i / 5);
            }
            return result;

        }
        //Aufgabe Berechnung von Pi(Leibniz Reihe)
        public static double CalculatePi(double devidor, double iterations)
        {
            double pi = 0;
            double piresult = 0;
            for (int i = 0; i < iterations; i++)
            {
                pi = (4 / devidor);
                devidor += 2;
                if (i % 2 == 0)
                {
                    piresult = piresult + pi;
                }
                else
                {
                    piresult = piresult - pi;
                }
            }
            return piresult;
        }
        //Aufgabe Berechnung von PI (Nilakantha Reihe)
        public static double CalculatePiv2(double iterations)
        {
            double pi = 0;
            double piresult = 3;
            double devidor = 2;
            for (int i = 0; i < iterations; i++)
            {
                pi = 4.0 / (devidor * (devidor +1) * (devidor + 2));
                if (i % 2 == 0)
                {
                    piresult = piresult + pi;
                }
                else
                {
                    piresult = piresult - pi;
                }
                devidor += 2;
            }
            return piresult;
        }
        //Aufgabe Geheime Reihe
        public static double Calculatesecret(double iterations)
        {
            double secret = 1.0;
            for (int i = 0; i < iterations; i++)
            {
                secret = (secret+i)/2+1/(secret+i);
                
            }
            return secret;
        }
    }
}

