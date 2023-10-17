using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace Riccardo.Week03
{
    internal class ArraysUebung
    {
        public static Random Random = new Random();
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
            Console.WriteLine("Änderung Original");

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
            PrintArray(RandomZufall(20));

            Console.WriteLine();
            Console.Write("=====================");
            Console.WriteLine();

            Console.WriteLine("fori");
            Printfori(RandomZufall(30));

            Console.WriteLine();
            Console.Write("=====================");
            Console.WriteLine();

            Console.WriteLine("PrintArrayWert");
            PrintArrayWert(RandomZufall(100));

            Console.WriteLine();
            Console.Write("=====================");
            Console.WriteLine();



        }


        /*
        public static void PrintNumberArrayCrazy(int[] array)
        {
            int arr = new int[array];

            for (int i = 0; i < array.Length; i++)
            {

            }
        }
        */


        public static void PrintArrayWert(int[] array)
        {
            Console.WriteLine();
            Console.WriteLine("[{0}]", string.Join(", ", array[1], array[4], array[9]));                           //gib den 2. 5.und 9. Wert des Arrays aus
            Console.WriteLine("[{0}]", string.Join(", ", array[1], array[3], array[5], array[7], array[9]));      // gib jeden 2. Wert des Arrays aus
            Console.WriteLine();
            Console.WriteLine("------------------");
        }

        public static void PrintArray(int[] array)
        {
            Console.WriteLine("[{0}]", string.Join(", ", array));
        }

        public static void Printfori(int[] array)
        {
            Console.Write("[");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + ", ");

                if (i == array.Length - 1)
                {
                    Console.Write(array[i]);
                }


            }
            Console.Write("]");


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

        public static int[] RandomZufall(int size)
        {
            int[] arry = new int[size];

            for (int i = 0; i < arry.Length; i++)
            {
                arry[i] = Random.Next(-50, 50);
            }
            return arry;
        }


    }

}
