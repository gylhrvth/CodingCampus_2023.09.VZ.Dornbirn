using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Gheorghe.Week01
{
    internal class Exercitii
    {
        public static void Start()
        {
            // PrintExercitii("x", 10);
            //  PrintQuadrat("$", 10);
            PrintRect("€", 10, 3);
        }

         public static void PrintExercitii(string symbol, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.Write(symbol);
            }
         }

        public static void PrintQuadrat(string symbol, int count)
        {
            for (int linie = 0; linie < count; linie++)

            {
                for (int col = 0; col < count; col++)
                {
                    Console.Write(symbol);
                }
                    Console.WriteLine();
            }

        }

        public static void PrintRect(String symbol,int height,int width)
        {
            for (int i = 0;i < height;i++)
            {
                for (int j = 0;j < width;j++)
                {
                    Console.Write(symbol,i);
                   

                }
                   Console.WriteLine();
            }
        }
    }
        
}

