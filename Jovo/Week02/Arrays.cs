using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Jovo.Week02
{
    internal class Arrays
    {
        public static void Start()
        {
            Console.WriteLine("Aufgabe Number Array");
            NumberArray();
            Console.WriteLine("===================");


            int[] Main = { 1, 2, 3, 4 };
            MakeACopy(Main);



        }




        public static void NumberArray()
        {
            int[] num1 = new int[10];
            int[] num2 = new int[10];

            for (int i = 0; i < num1.Length; i++)
            {
                num1[i] = i;
                Console.WriteLine(i);
            }
            Console.WriteLine();
            for(int i = 9; i < num2.Length; i--)
            {
                num2[i] = i;
                Console.WriteLine(i);

            }




        }

        public static int[] MakeACopy(int[] Main)
        {
            int[] copy = new int[Main.Length];

            for (int i=0;i< copy.Length; i++)
            {
                copy[i] = Main[i];
                Console.WriteLine(i);

            }
            return copy;


        }
        


    }
}
