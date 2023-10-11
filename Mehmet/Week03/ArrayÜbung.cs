using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Mehmet.Week03
{
    internal class ArrayÜbung
    {
        public static void start()
        {

            Console.WriteLine("Original");
            int[] original = Array(10);
            foreach (int element in original)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
            Console.WriteLine("----------------------");



            Console.WriteLine("OriginalR");
            int[] originalR = ArrayR(10);
            foreach (int element in originalR)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
            Console.WriteLine("----------------------");



            Console.WriteLine("Copy");
            int[] copy = MakeACopy(original);
            foreach (int element in copy)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
            Console.WriteLine("----------------------");



            Console.WriteLine("OriginalVerändert");
            original[4] = 34;
            original[2] = 71;
            foreach (int element in original)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
            Console.WriteLine("============================================");
            Console.WriteLine();
            Console.WriteLine();



            Console.WriteLine("RandomNumberArray");
            int[] arr = RandomNumberArray(10);
            foreach (int element in arr)
            {
                Console.Write(element);
            }
            
         





        }

        public static int[] Array(int size)
        {
            int[] arr = new int[size];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i + 1;
            }
            return arr;
        }

        public static int[] ArrayR(int size)
        {
            int[] arr = new int[size];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = size - i;
            }
            return arr;
        }             

        public static int[] MakeACopy(int[] original)
        {
            int[] copy = new int[original.Length];
            for (int i = 0; i < original.Length; i++)
            {
                copy[i] = original[i];
            }
            return copy;
        }



        public static int[] RandomNumberArray(int size)
        {
            int[] arr = new int[size];
            for(int i = 0;i < 3; i++)
            {
                Random random = new Random();
                Console.WriteLine(random);
            }
            
            
            return arr;
        }
              
            


           
        





    }
}
