using System;
namespace Lukas.Week02
{
    public class Day03
    {
        public Day03()
        {
        }

        public static void Start()
        {
            double a = 1.999999999999;
            Console.WriteLine(a);

            int b = (int)a;
            Console.WriteLine(b);

            int c = (int)Math.Ceiling(a);
            Console.WriteLine(c);

            Recursion(100000);
            Console.WriteLine("Fertig");
        }

        public static void Recursion(int repeat)
        {
            if (repeat <= 0)
            {
                return;
            }
            Recursion(repeat -1);

        }
    }
}

