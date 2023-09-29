using System;
namespace Niklas.Week01
{
    public class Schleifen
    {
        public static void Start()
        {
            for (int i = 0; i <= 10;)
            {
                Console.WriteLine("Diese Nachricht wird 10 mal wiederholt!", i++);
            }

            for (int j = 0; j <= 10;)
            {
                Console.WriteLine($"Diese Nachricht wiederholt sich 10 mal!{j}", j++);
            }

            for (int k = 0; k <= 10; k++)
            {
                Console.WriteLine($"k = {k}");
                k++;
            }
            for (int l = 10; l >= -10;)
            {
                Console.WriteLine($"Diese nachricht zählt bis -10 rückwarts!{l}", l--);
            }
        }
    }
}