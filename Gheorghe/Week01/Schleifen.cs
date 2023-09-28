using System;


namespace Gheorghe.Week01
{
    public class Schleifen
    {
        public static void Start()
        {
            for (int i = 0; i <= 10; i++)
			{
		        Console.WriteLine("i = " + i);
                i++;
			}

            int j = 0;
            while(j <= 10)
            {
                Console.WriteLine("j = " + j);
                j++;
            }
            for (int k = 0; k < 10; k++)
            {
                Console.WriteLine("k " + k);
               
            }

            for (int m = 0; m <= 10; m++)
            {


                if (m % 2 == 0)
                {
                    Console.WriteLine("m =" + m);
                }
               
            }
            for (int n =10; n >= -10; n--)
            {
                Console.WriteLine(" n = " + n);
            }
        }
    }
          
}

