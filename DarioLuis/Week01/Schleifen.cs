using System;


namespace DarioLuis.Week01
{
    public class Schleifen
    {
        public static void Start()
        {
           
            for ( int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Ich bin in einer For-Schleife gefangen!" + i);
            }

            int j = 0;
            while (j < 10)
            {
                Console.WriteLine("Ich bin in einer While-Schleife gefangen!" + j);
                j++;
            }

            for (int k = 0; k <= 10; k ++)
            {
                if (k % 2 == 0)
                {
                    Console.WriteLine("Die geraden Nummern sind = " + k );
                }
            }
            
            for ( int m = 10; m >= -10; m--)
            {
                Console.WriteLine("Bin schon wieder in einer For-Schleife gefangen" + m);
            }
        }
    }
}
