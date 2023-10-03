using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erik.Week02
{
    public class MyBoolean
    {
        public static void Start()
        {
            TriangleTopLeftIf(5);
            Console.WriteLine();
            TriangleTopRightIf(5);
            Console.WriteLine();
            TriangleBottomLeftIf(5);
            Console.WriteLine();
            PrintPyramidFinal("x", 5);
            Console.WriteLine();
        }









        public static void TriangleTopRightIf(int length)
        {




            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {

                    if (j >= i)
                    {
                        Console.Write("X");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
                Console.WriteLine();
            }
        }

        public static void TriangleBottomLeftIf(int length)
        {


            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {

                    if (j <= i)
                    {
                        Console.Write("X");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
                Console.WriteLine();
            }
        }


        public static void TriangleTopLeftIf(int length)
        {


            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {

                    if (j <= i)
                    {
                        Console.Write("X");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
                Console.WriteLine();
            }
        }


        public static void PrintPyramidFinal(String letter, int length)
        {

            for (int row = 0; row < length; row++)
            {

                for (int col = 0; col < length; col++)
                {

                    if (row == col)
                    {
                        Console.Write(letter);
                        
                    }
                    
                    else
                    {

                        Console.Write(".");
                    }
                }
                Console.WriteLine();
            }


        }


    }
}















