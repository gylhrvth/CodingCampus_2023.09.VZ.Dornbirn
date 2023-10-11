using System.Drawing;
using System.Security.Cryptography.X509Certificates;

namespace Niklas.Week03
{
    internal class ArrayNumber
    {
        public static Random random = new Random();
        public static void Start()
        {


            Console.WriteLine("\nAscending: ");
            int[] arr = new int[10];
            CreateArrayAsc(arr);

            Console.WriteLine("\nDescending: ");
            CreateArrayDesc(10);

            Console.WriteLine("\nCopy: ");
            int[] original = CreateArray(10);
            int[] newArray = MakeACopy(original);

            //Console.WriteLine("[{0}]", string.Join(", ", original));
            //Console.WriteLine("[{0}]", string.Join(", ", newArray));
            PrintArray(original);
            PrintArray(newArray);
            Console.WriteLine("==================================");

            Console.WriteLine("\nRandom Number: ");
            RandomNumber();
            PrintSecondFifthandTenth(arr);
            /*
            newArray[0] = -10;
            PrintArray(original);
            PrintArray(newArray);
            //Console.WriteLine("[{0}]", string.Join(", ", original));
            //Console.WriteLine("[{0}]", string.Join(", ", newArray));

              Console.WriteLine("=================================");
              Console.WriteLine("[{0}]", string.Join(", ", original));
              PrintArray(original); */

            Console.WriteLine("\nRandom Crazy Number: ");
            CrazyRandomNumber();

            Console.WriteLine("......................");
            int treshhold = 30;
            int cnt = countBiggerThen(original, treshhold);
            Console.WriteLine("Count bigger then {0}: {1}", treshhold, cnt);
        }



        public static void PrintArray(int[] array)
        {
            Console.Write("[");
            for (int i = 0; i < array.Length; i++)
            {
                if (i > 0)
                {
                    Console.Write(", ");
                }
                Console.Write(array[i]);
            }
            Console.WriteLine("]");
        }

        public static int[] CreateArrayAsc(int[] size)
        {

            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            for (int i = 0; i < arr.Length; i++)
            {
                if (i > 0)
                {
                    Console.Write(", ");
                }
                Console.Write(arr[i]);
            }
            return arr;


        }

        public static int[] CreateArrayDesc(int size)
        {
            int[] arr = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            for (int i = 0; i < arr.Length; i++)
            {
                if (i > 0)
                {
                    Console.Write(", ");
                }
                Console.Write(arr[i]);
            }
            return arr;
        }


        public static void Count()
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


        public static int[] MakeACopy(int[] arr)
        {
            int[] copy = new int[arr.Length];
            for (int i = 0; i < arr.Length; ++i)
            {
                copy[i] = arr[i];
            }
            return copy;
        }


        public static void RandomNumber()


        {
            int[] fixArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] myArray = CreateArray(10);

            foreach (int value in myArray)
            {
                Console.WriteLine("{0}", value);
            }

            Console.WriteLine("[{0}]", string.Join(", ", myArray));

            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine(arr);




        }

        public static void PrintSecondFifthandTenth(int[] arr)
        {
            int[] fixArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] myArray = CreateArray(10);

            int[] i = fixArray;

            foreach (int value in myArray)
            {
                Console.WriteLine("{0}", value);
            }

        }


        public static void CrazyRandomNumber()
        {
            int[] fixArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] myArray = CreateArray(10);

            foreach (int value in myArray)
            {
                Console.WriteLine("{0}", value - 50);
            }
        }


        public static int countBiggerThen(int[] arr, int value)
        {
            int count = 0;
            foreach (int x in arr)
            {
                if (x > value)
                {
                    ++count;
                }
            }
            return count;
        }



        public static int[] CreateArray(int size)
        {
            int[] arr = new int[size];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(100);
            }

            return arr;
        }

        public static int[] CreateArray3(int size)
        {
            int[] arr = new int[size];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(99);
            }

            return arr;
        }

    }
}
