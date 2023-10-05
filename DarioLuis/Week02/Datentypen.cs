using System.Net.WebSockets;

namespace DarioLuis.Week02
{
    class Datentypen
    {


        public static void Start()
        {
            Console.WriteLine("Print Sum");
            Console.WriteLine();
            PrintSum();

            //Console.WriteLine("PrintFakt");
            //Console.WriteLine();
            //PrintFakt();

            //Console.WriteLine("Print01");
            //Console.WriteLine();
            //Print01();

            //Console.WriteLine("Print01v2");
            //Console.WriteLine();
            //Print01v2();

            //Console.WriteLine("Print01v3");
            //Console.WriteLine();
            //Print01v3();

            //Console.WriteLine("Print02");
            //Console.WriteLine();
            //Print02();

            Console.WriteLine("Pi Leibniz Reihe");
            Console.WriteLine();
            CalculatePiLeibniz();
        }
        

        public static void PrintSum()
        {
            int k = 0;
            for (int i = 20; i <= 50; i++)
            {
                k += i; //k = k + i ist das gleiche!!

                Console.WriteLine(k);
            }
        }
        public static void PrintFakt()
        {
            long fac = 1;
            for (long j = 1; j <= 20; j++)
            {
                fac *= j; // k = i * j ist das gleiche!!
                Console.WriteLine($"{j + "!",2} ={fac,20}");
            }
        }
        public static void Print01()
        {
            for (double j = 0; j <= 100; j += 0.1)
            {

                Console.WriteLine(Math.Round(j, 2));
            }
        }

        public static void Print01v2()
        {
            for (int i = 0; i <= 100 * 100; i = i + 10)
            {
                Console.WriteLine(i / 100.0);
            }
        }

        public static void Print01v3()
        {
            for (double i = 0; i <= 100; i += 0.1)
            {
                Console.WriteLine(Math.Round(i, 2));
            }
        }

        public static void Print02()
        {
            for (double i = 0; i <= 100; i += 0.1)
            {
                Console.Write($" Result  digit = ");
                Console.WriteLine(Math.Round(i, 2));
            }
        }

        public static double CalculatePiLeibniz()
        {
            double pi = 0;
            for (double i = 1; i <= 30000000; i += 4)
            {
                pi += 4 / i;
                pi *= -1;
                if((i-1) % 100000 == 0)
                {
                    Console.WriteLine($"pi = {pi}");
                }
            }
            Console.WriteLine($"pi = {pi}");
            return pi;
        }

    }

}
