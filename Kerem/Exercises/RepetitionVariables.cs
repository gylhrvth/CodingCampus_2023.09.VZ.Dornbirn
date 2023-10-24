using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kerem.Exercises
{
    internal class RepetitionVariables
    {
        public static void Start()
        {
            Console.WriteLine("Count");
            int i = 0;
            while (i <= 10)
            {
                Console.WriteLine(i);
                i++;

            }

            Console.WriteLine("Count w ForLoop");
            for (int j = 0; j < 10; j++)
            {
                Console.WriteLine(j);

            }
            Console.WriteLine("Count2");
            for(int k= 0; k < 10; k++)
            {
                Console.WriteLine("Der Zähler ist "+ k);
            }
            Console.WriteLine("Count w Trick");
            for( int m = 0; m < 10; m+= 2)
            {
                if(m % 2 == 0)
                {
                    Console.WriteLine("Der Zähler ist gerade " + m);

                }
                Console.WriteLine();

            }


        }
    }
}

