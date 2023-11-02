using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gheorghe.Week01
{
    internal class Testen
    {
        public static void Start()
        {
           // Square("x", 10);
            Rectangle("µ^", 3, 10);




        }
        public static void Square(string symbol, int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();

            }

        }


        public static void Rectangle(string symbol, int height,int width)
        {
            for (int row = 0; row < height; row++)
            {
                for(int col = 1;col < width; col++)
                {
                    Console.Write(symbol);
                    
                }
                Console.WriteLine();
            }
            
        }


        
    }
     
}

    

