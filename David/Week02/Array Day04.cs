using System;
namespace David.Week02
{
    public class Array_Day04
    {
        public static void StartArray_Day04()
        {
            ArrayListe1();
            
            ArrayListe2();

            int[] arr = CreateArrayListe3(9);
            PrintArray(arr);

            int[] arr4 = CreateArrayListe4(10);
            PrintArray(arr4);

            int[] arr5 = CreateArrayListe5(11);
            PrintArray(arr5, true);

            int[] arr6 = CreateArrayListe6(12);
            PrintArray(arr6, true);
        }




        public static void ArrayListe1()
        {
            // von 0 - 10
            Console.WriteLine("Array 1");

            int[] arr = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine(arr);
            for (int i = 0; i < arr.Length - 1; i++)
            {
                Console.WriteLine("{0}. = {1}", i, arr[i]);
            }
            Console.WriteLine();




            // von 10 - 0
            Console.WriteLine("Array 2");

            int[] arr2 = { 13, 12, 11, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };

            Console.WriteLine(arr2);
            for (int i2 = 0; i2 < arr2.Length - 1; i2++)
            {
                Console.WriteLine("{0}. = {1}", i2, arr2[i2]);
            }
            Console.WriteLine();
        }



        // von 0 - 10 mit int Benutzerangabe

        public static void ArrayListe2()
        {
            Console.WriteLine("Array 3");

            int[] numbers = new int[18];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i + 1;

                Console.WriteLine("{0}. = {1}", i, numbers[i]);
            }

        }


        public static int[] CreateArrayListe3(int size)
        {
            Console.WriteLine();
            Console.WriteLine("Array 4");
            int[] numbers = new int[size];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i + 1;
            }

            return numbers;
        }
        public static void PrintArray(int[] zahl)
        {
            for (int i = 0; i < zahl.Length; i++)
            {
                Console.WriteLine("{0}. = {1}", i, zahl[i]);
            }
            Console.WriteLine();

        }

        public static int[] CreateArrayListe4(int size)
        {
            Console.WriteLine("Array 5");
            int[] numbers = new int[size];

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                numbers[i] = i + 1;
            }

            return numbers;
        }

        public static int[] CreateArrayListe5(int size)
        {
            Console.WriteLine("Array 7");
            int[] numbers = new int[size];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i + 1;
            }

            return numbers;
        }

        public static int[] CreateArrayListe6(int size)
        {
            Console.WriteLine();
            Console.WriteLine("Array 8");
            int[] numbers = new int[size];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i + 1;
            }

            return numbers;
        }

        public static void PrintArray(int[] zahl, bool reverse)
        {
            if (reverse)
            {
                for (int i = zahl.Length - 1; i >= 0; i--)
                {
                    Console.WriteLine("{0}. = {1}", i, zahl[i]);
                }
            }
            else Console.WriteLine("...");

        }
    }
}
