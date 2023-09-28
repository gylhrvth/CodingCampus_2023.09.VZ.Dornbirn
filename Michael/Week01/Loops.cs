using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Michael.Week01
{
    public class Loops
    {
        public static void Loop()
        {


            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("");

            int counter = 0;

            while (counter <= 10)
            {
                Console.WriteLine(counter);
                counter++;
            }

            Console.WriteLine("");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("");

            counter = 0;

            while (counter < 10)
            {
                Console.WriteLine(counter);
                counter++;
            }

            Console.WriteLine("");

            for (int i = 0; i<=10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("");

            for (int i=0; i<=10; i = i + 2)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("");

            for (int i=10; i>=-10; i--)
            {
                Console.WriteLine(i);
            }


        }
    }
}
