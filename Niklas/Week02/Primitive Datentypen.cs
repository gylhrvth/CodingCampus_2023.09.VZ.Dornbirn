using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Niklas.Week02
{
    public class PrimitiveDatentypen
    {
        public static void Start()
        {
            PrintSumme(20);
            Console.WriteLine();

            Console.WriteLine("\nFaktorial: ");
            PrintFaktorial(1);
            Console.WriteLine();

            Console.WriteLine("\nCount: ");
            Count(0);
            Console.WriteLine();

            Console.WriteLine("\nCount2: ");
            Count2(0, 0);
            Console.WriteLine();

            Console.WriteLine("\nTeilen und Herrschen: ");
            Teilen(0, 0);
            Console.WriteLine();


        }

        static void PrintSumme(int times)
        {
            int rows = 20;
            int times2 = 21;
            while (rows <= 50)
            {
                Console.WriteLine("Summe = " + (times + times2));
                times += times2;
                times2++;
                if (times % 2 != 0)
                {
                    Console.Write("");
                }
                else { }
                rows++;
            }
        }
        static void PrintFaktorial(long times)
        {
            long rows = 1;
            long times2 = 1;
            while (rows <= 20)
            {
                if (rows == 2 && times == 1)
                {
                    Console.Write("");
                    times++;
                }
                else
                {
                    Console.Write($"{rows,2}! = ");
                    Console.WriteLine($"{times,20}");
                    times *= times2;
                    times2++;
                    if (times % 2 != 0)
                    {
                        Console.Write("");
                    }
                    else { }
                    rows++;
                }
            }

        }
        static void Count(double times)
        {
            times = 0;
            Console.WriteLine($"number = {times / 10.0:N1} ");

            for (int i = 0; i < 1000; i++)
            {
                times = times + 10.0;
                Console.WriteLine($"number = {times / 100.0:N1} ");
            }
        }
        static void Count2(double times, double times2)
        {
            times = 0;
            Console.WriteLine($"result 1 digit = {times / 10.0:N1} ");

            times = 0;
            Console.WriteLine($"result 2 digit = {times2 / 100.0,10:N1}0");

            for (int i = 0; i < 1000; i++)
            {
                times = times + 10.0;
                Console.WriteLine($"result 1 digit = {times / 100.0:N1} ");

                times2 = times2 + 100.0;
                Console.WriteLine($"result 2 digit = {times2 / 1000.00,10:N2} ");
            }
        }

        static void Teilen(double times, double times2)
        {

            for (int rows = 0; rows <= 20; rows++)
            {
                Console.Write(rows + " / 5 = ");
                Console.WriteLine();
                Console.Write(rows + " / 5.0 = ");
                Console.WriteLine();
            }



        }



    }
}