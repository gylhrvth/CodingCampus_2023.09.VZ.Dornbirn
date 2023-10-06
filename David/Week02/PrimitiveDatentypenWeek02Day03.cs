using System;
namespace David.Week02
{
    public class PrimitiveDatentypenWeek02Day03
    {
        public static void Start()
        {
            berechnungPi();
            Console.WriteLine("");

            teilenUndHerrschen(5);
            Console.WriteLine("");

            herrschenUndTeilen02();
            Console.WriteLine("");

            //PiNilakanthaReihe();


        }

        // Funktions with returns / Start Bsp.: von Gyula

        /*public static void Start()
        {
            Console.WriteLine(Add(3, 2));

            int c = Add(5, 4);
            Console.WriteLine(c);
        }


        public static int Add(int a, int b)
        {
            int result = a + b;

            return result;
        }
       */

        //Ende


        public static void berechnungPi()
        {
            double pi = 0;

            for (int i = 1; i < 10000000; i = i + 4)
            {
                pi = pi + (4.0 / i);
                pi = pi - (4.0 / (i + 2));
            }

            Console.WriteLine(pi);

        }


      

        // Week02 Day 04

        public static int teilenUndHerrschen(int count)
        {
            int five = 5;
            for (int x = 0; x <= count; x++)
            {
                double fived = five;

                Console.Write(x + " / " + five + " = ");
                Console.WriteLine(x / five);
                Console.Write($"{x} / {fived:0.0} = ");
                Console.WriteLine(x / fived);
            }
            return count;
        }

        public static void herrschenUndTeilen02()
        {
            int count = 5;
            for (int x=0; x<= count; x++)
            {
                Console.WriteLine(x + " / 5 = " + x / 5);
                Console.WriteLine(x + " / 5.0 = " + x / 5.0);
            }
        }

        public static void PiNilakanthaReihe()
        {
            int count = 4;
            for (int x = 3; x < 10000; x++)
            {
                Console.WriteLine();
            }
        }
    }
}
