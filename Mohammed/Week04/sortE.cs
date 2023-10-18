using System;
namespace Mohammed.Week04
{
    public class sortE
    {

        public static Random rand = new Random();

        public static void Start()
        {
            int[] arr = CreateArrayRandom(20, 0, 100);
            PrintArrayForEach(arr);


            //BubbleSort : Sortieren
            BubbleSort(arr);
            Console.WriteLine("Sorted");
            PrintArrayForEach(arr);

            //BubbleSortAsc

            //int[]array  = CreateArrayAsc(10);
            // PrintArrayForEach(array); die sind genau die gleiche mit unten vergleich..
            // PrintArrayForEach(CreateArrayAsc(10));


            Console.WriteLine("SelectionSort Example");
            SelectionSort(arr);
            PrintArrayForEach(arr);


        }






        public static void PrintArrayForEach(int[] arr)
        {
            Console.Write("[");
            bool first = true;
            foreach (int value in arr)
            {
                if (!first)
                {
                    Console.Write(", ");
                }
                Console.Write(value);
                first = false;
            }
            Console.WriteLine("]"); 
        }
       


        public static int[] CreateArrayAsc(int size)
        {
            int[] arr = new int[size];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = 1 + i;
            }
            return arr;
        }

        public static int[] CreateArrayDesc(int size)
        {
            int[] arr = new int[size];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = size - i;
            }
            return arr;
        }

        public static int[] CopyOfArray(int[] original)
        {
            int[] arr = new int[original.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = original[i];
            }
            return arr;
        }

        public static int[] CreateArrayRandom(int size)
        {
            int[] arr = new int[size];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(101);
            }
            return arr;
        }

        public static int[] CreateArrayRandom(int size, int min, int max)
        {
            int[] arr = new int[size];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(min, max);
            }
            return arr;
        }

        public static void BubbleSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++) // - i ist dafür da, dass der vergleich nicht doppelt ausgeführt wird, sondern nur durch hälfte weil er immer 2 zahlen vergleicht
                                                               // - 1 ist dafür da das man den letzten index noch mit vergleicht
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }


        public static void SelectionSort (int[] arr)
        {
            for(int i = 0; i < arr.Length - 1; ++i)
            {
                int minIndex = i;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr [minIndex])
                    {
                        minIndex = j; 
                    }
                }

                int temp = arr[i];
                arr[i] = arr[minIndex];
                arr[minIndex] = temp;
            }
        }

       

    }
}

