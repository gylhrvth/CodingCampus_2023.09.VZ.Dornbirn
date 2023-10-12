using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Riccardo.Week03
{
    internal class ArraysUebung
    {
        public static void Start()
        {
            Console.Write("Aufgabe 1 Zahlen Aufwärts:");
            Console.WriteLine();
            int[] original = CreateArray(10);

            foreach (int element in original)
            {
                Console.Write(element + " ");
            }

            Console.WriteLine();
            Console.Write("=====================");
            Console.WriteLine();

            //--------------------------------------------

            Console.Write("Aufgabe 2 Zahlen Abwärts:");
            Console.WriteLine();
            int[] originalA = CreateArray2(10);

            foreach (int element in originalA)
            {
                Console.Write(element + " ");
            }

            Console.WriteLine();
            Console.Write("=====================");
            Console.WriteLine();

            //--------------------------------------------

            Console.Write("Aufgabe 3 Copy:");
            Console.WriteLine();
            int[] originalC = MakeCopy(original);

            foreach (int element in originalC)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
            Console.Write("=====================");
            Console.WriteLine();

            //---------------------------------------------
            Console.WriteLine("Änderung Orginal");

            original[0] = 20;
            original[8] = 40;

            foreach (int element in original)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
            Console.Write("=====================");
            Console.WriteLine();

            //---------------------------------------------
            Console.WriteLine("Kopie danach");
            foreach (int element in originalC)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
            Console.Write("=====================");
            Console.WriteLine();

            //---------------------------------------------
            Console.WriteLine("Random");



        }


        public static int[] CreateArray(int size)
        {
            int[] arr = new int[size];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i + 1;
            }
            return arr;

        }

        public static int[] CreateArray2(int size)
        {
            int[] arr = new int[size];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = size - i;
            }
            return arr;
        }

        public static int[] MakeCopy(int[] original)
        {
            int[] copy = new int[original.Length];

            for (int i = 0; i < copy.Length; i++)
            {
                copy[i] = original[i];
            }
            return copy;
        }


    }

}
