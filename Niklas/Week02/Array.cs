using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Niklas.Week02
{
    internal class ArrayNumber
    {
        public static void Start()
        {
            Count();
            Console.WriteLine();

            MakeACopy();
            Console.WriteLine();

            RandomNumber();
            Console.WriteLine();
        }

        static void Count()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine(arr);

            for (int i = 0; i < arr.Length; ++i)
            {
                Console.WriteLine("{0}. = {1}", i, arr[i]);
            }

            int[] arr2 = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            Console.WriteLine(arr2);

            for (int i = 0; i < arr2.Length; ++i)
            {
                Console.WriteLine("{0}. = {1}", i, arr2[i]);
            }
        }

        static void MakeACopy()
        {
            for ( int i = 0; ; i++)
            {
                Array.Copy
                     
            }

        }

        static void RandomNumber()
        {
            int[] arr = { 1, 2, 3, };

            arr[0] = 100;
            for (int i = 0; i < arr.Length; ++i)
            {
                Console.WriteLine("{0}. = {1}", i, arr[i]);
            }

            Random rand = new Random();
            int[] arr2 = new int[10];
            for (int i = 0; i < arr2.Length; i++)
            {
                arr2[i] = rand.Next(10, 20);
            }

        }





    }
}

