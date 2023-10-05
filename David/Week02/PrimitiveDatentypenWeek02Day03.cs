using System;
namespace David.Week02
{
    public class PrimitiveDatentypenWeek02Day03
    {
        public static void Start()
        {
            berechnungPi();

        }
        public static void berechnungPi()
        {
            double pi = 0;

            for (int i = 1; i < 1000000000; i = i + 4)
            {
                pi = pi + (4.0 / i);
                pi = pi - (4.0 / (i + 2));
            }

            Console.WriteLine(pi);

        }
    }
}
