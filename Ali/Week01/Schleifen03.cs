using System;
namespace Ali.Week01
{
    public class Schleifen03
    {
        public static void Start()
        {
            Console.WriteLine("Hello World1");

            
            for (int i = 0; i < 11; ++i)
            {
                Console.WriteLine(i);
            }
            int j = 0;
            while (j < 11)
            {
                Console.WriteLine(j);
                j++;
              
            }
            for (int k = 0; k < 10; ++k)
            {
                Console.WriteLine(k);
            }
             
            for (int x = 0; x<= 10; x++)
            
                if (x % 2 == 0)
                {
                    Console.WriteLine("ist gerade " + x);
                }
                for (int b = 10; b >= -10; b--)
                {
                    Console.WriteLine("Der Zähler ist " + b);
                }
            
            
           
            
                
            

             
                   
        }
    }
}