using System;

namespace Sven.Week01
{
    public class Variablen
    {
        public static void MyVariablen()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Ich bin gefangen in einer For-Schleife: " + i) ;
            }
            
            int j = 0;
            while (j < 10) 
            {
                Console.WriteLine("Ich bin gefangen in einer While-Schleife: " + j);
                j++;
            }
            
            for (int k = 0; k <= 10; k++) 
            { 
                if (k % 2 == 0)
                {
                    Console.WriteLine("Die geraden Nummern sind: " + k);
                }
            }

            for (int m = 10 ; m >= -10; m--) 
            {
                Console.WriteLine("Bin schon wieder in einer For-Schleife gefangen: " + m );
            }
            
        } 
    }
}
