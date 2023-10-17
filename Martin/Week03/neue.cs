using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martin.Week03
{
    public class neue
    {
        public static void StartArray()
        {
          
            Console.WriteLine("Orginal");
            int[] orginal = Array(10);

            foreach (int element in orginal)
            {
                Console.Write(element + " ");
            }

            Console.WriteLine();
            Console.WriteLine("=========");
            Console.WriteLine("Copy");
            int[] copy = MakeACopy(orginal);
            foreach (int element in copy)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
            Console.WriteLine("=============");
            Console.WriteLine("Änderung orginal");
            orginal[3] = 200;
            foreach (int element in orginal)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Änderung Copy");

            foreach (int element in copy)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();

        }
        public static int[] Array(int size)
        {
            int[] array = new int[size];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i + 1;
            }

            return array;
        }

        public static int[] MakeACopy(int[] orginal)
        {
            int[] copy = new int[orginal.Length];

            for(int i = 0;i < orginal.Length;i++)
            {
                copy[i] = orginal[i];
            }    

            return copy;

        }
    }
}
