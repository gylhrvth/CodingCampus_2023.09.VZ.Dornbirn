using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Eren.Week02
{
    internal class Faktorial
    {
        public static void StartDatentypen()
        {
            // Console.WriteLine("Aufgabe Summe");
            //int sum = Summe(20, 50);
            //Console.WriteLine("Summe: " + sum);



            // Console.WriteLine("Aufgabe Faktorial");
            //for (long i = 1; i <= 20; i++)
            //{

            //    Console.WriteLine("{0,2}! = {1,20}", i, FaktorialSumme(i));

            //}


            // Console.WriteLine("Aufgabe Zählen von 0 bis 100");

            //Console.WriteLine("0.1 steps from 0 to 100");

            //for (double count = 0; count <= 100; count += 0.1)
            //{
            //    Console.WriteLine("{0:N1}", count);
            //}

            // Console.WriteLine("Aufgabe Zählen von 0 bis 100 und Formatstrings");

            //Console.WriteLine("0.1 steps from 0 to 50");
            //int digitend = 100;
            //for (double count = 0; count <= digitend; count += 0.1)
            //{
            //    Console.WriteLine("{0:N1}", count);
            //}

            for (double i = 0; i <= 10; i += 0.1)
            {

                Console.WriteLine("{0:N1}", FaktorialSumme(i));
                Console.WriteLine("{0:N2}", FaktorialSumme(i));

            }
            

            //for (double count = 0; count <= 20; count++)
            //{
            //    Console.Write(count + " / 5 = ");
            //    Console.WriteLine(count / 5);
            //    Console.Write(count + " / 5.0 = ");
            //    Console.WriteLine(count / 5.0);

            //}


        }




        public static double FaktorialSumme(double end)
        {
            double result = 0;
            for (double count = 0; count <= end; count += 0.1)
            {
                result = count;
            }


            return result;
        }
        //public static long FaktorialSumme(long end)
        //{
        //    long result = 1;
        //    for (long i = 1; i <= end; i++)
        //    {
        //        result *= i;
        //    }

        //    return result;
        //}

        ///// /// /// /// /// /// /// /// /// /// /// ///
        //public static int Summe(int first, int second)
        //{
        //    int result = 0;
        //    for (int i = first; i <= second; i++)
        //    {
        //        result += i;
        //    }
        //    return result;
        //}
        ///// /// /// /// /// /// /// /// /// /// /// ///




    }
    }

