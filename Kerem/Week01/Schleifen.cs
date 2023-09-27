using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kerem.Week01
{
    internal class Schleifen
    {

        public static void Start()
        {

            for (int i = 0; i <= 10; ++i)
            {
                Console.WriteLine(i);
            }
            int x = 0;
            while(x < 10)
            {
                Console.WriteLine(x);
                x = x + 1;
            }

            for (int k = 0; k < 10; ++k)
            {
                Console.WriteLine("Der Zähler ist:" + k);
            }

            for (int j = 0; j <= 10; j++)
            {
                if (j % 2 == 0)
                {
                    Console.WriteLine( j + " ist gerade ");
                }    
            }
            for (int a = 10; a >= -10; --a)
            {
                Console.WriteLine("Der Zähler ist " + a);
              
            }


        }
    }
}




