using System;
namespace David.Week02
{
    public class PrimitiveDatentypenWeek02Day03
    {
        public static void Start()
        {
            berechnungPi();

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
    }
}
