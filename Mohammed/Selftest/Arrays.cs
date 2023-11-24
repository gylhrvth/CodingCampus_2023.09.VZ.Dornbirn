using System;
namespace Mohammed.Selftest
{
    public class Arrays
    {
        public static void Start()
        {
            int[] arr = new int[] { 0, 1, 23, 5, 4, 4, 2, 5, 2, 10 };

            int[] arr2 = new int[] { 123, 19471, 1, 4, 15715, 15, 5, 15, 1, -10, -100 };

            int[] arr3 = new int[] { 478199, 7812973, 12387123, 12, 3, 123, 12, 3, 1, 3, 1, 3, 8, 9, 15, 1, 5, 1, 5, 15, 1, 5, 0 };

            FirstAndLast(arr);
            FirstAndLast(arr2);
            FirstAndLast(arr3);
            Console.WriteLine();

            PrintResult("Min", GetMinResult(arr));
            PrintResult("Min2", GetMinResult(arr2));
            PrintResult("Min3", GetMinResult(arr3));
            Console.WriteLine();


            PrintResult("Max", GetMaxResult(arr));
            PrintResult("Max2", GetMaxResult(arr2));
            PrintResult("Max3", GetMaxResult(arr3));
            Console.WriteLine();


            PrintResult("Avg", GetAvgResult(arr));
            PrintResult("Avg2", GetAvgResult(arr2));
            PrintResult("Avg3", GetAvgResult(arr3));
            Console.WriteLine();

            int[] arr4 = Fillarr(10);
            ArrayForEach(arr4);
            ArrayForEach(arr);
            Console.WriteLine("[{0}]", string.Join(", ", arr));
            Console.WriteLine();



        }

        //PrintMethode
        public static void PrintResult(string massage, int result)
        {
            Console.WriteLine(massage + " :" + result);
        }

        public static void PrintResultD(string massage, double result)
        {
            Console.WriteLine(massage + " :" + result);
        }

        //1 Aufgabe
        public static void FirstAndLast(int[] array)
        {
            Console.WriteLine("first{0}, last{1}", array[0], array[1]);

        }

        // 2 Aufgabe //1,2

        public static int GetMinResult(int[] arr)
        {
            int min = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
               
            }
            return min;
        }   

        //1
        public static int GetMaxResult(int[] arr)
        {
            int max = arr[0];

            for(int i = 0; i< arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }

        //2
        public static int GetAvgResult(int[] arr)
        {
            int avg = arr[0];

            for(int i =0; i< arr.Length; i++)
            {
                avg += arr[i];
            }
            avg = arr.Length;

            return avg;

        }

        //3 Aufgabe

        public static int[] Fillarr(int numbers)
        {
            int[] arr = new int[10];

           
            for (int i = 0; i < numbers; i++)
            {
                Console.WriteLine(numbers);
            }
            return arr;
        }

        public static void ArrayForEach(int[] array)
        {
            bool first = true;

            for (int i = 0; i < array.Length; i++)
            {
                if (!first)
                {
                    Console.WriteLine(" " + array[i]);
                }
                else
                {
                    Console.WriteLine(array[i]);
                }
                Console.WriteLine();
            }
        }

    }
}

