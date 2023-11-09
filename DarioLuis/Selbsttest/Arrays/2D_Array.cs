using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarioLuis.Selbsttest.Arrays
{
    public class _2D_Array
    {
        public static void PrintArray()
        {
            CreateArray();
        }
        public static void CreateArray()
        {
            for (int i = 0; i <=90; i++) 
            {
                if (i % 10 == 0)
                {
                    Console.Write($"{i, -5}");      //0
                    Console.Write($"{i + 1, -5}");  //1
                    Console.Write($"{i + 2, -5}");  //2
                    Console.Write($"{i + 3, -5}");  //3
                    Console.Write($"{i + 4,-5}");   //4
                    Console.Write($"{i + 5,-5}");   //5
                    Console.Write($"{i + 6,-5}");   //6
                    Console.Write($"{i + 7,-5}");   //7 
                    Console.Write($"{i + 8,-5}");   //8
                    Console.Write($"{i + 9,-5}");   //9
                    Console.WriteLine();
                }
            }
        }
        
    }
}
