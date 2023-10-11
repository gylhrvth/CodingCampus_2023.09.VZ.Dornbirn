using System.ComponentModel;
using System.Globalization;
using System.Net.Http.Headers;

namespace Fabienne.Week02
{
    public class Arrays
    {
        public static Random rand = new Random();
        public static void Start()
        {
            /*
            int[] original = { 1, 7, 8 , 11, 32, 4, -5};
            NumberArray();
            Console.WriteLine();
            MakeACopy(original);

            Console.WriteLine();
            RandomNumberArray();

            Console.WriteLine();
            RandomNumberArrayCrazyRange();

            Console.WriteLine();
            RandomNumberArrayZählen();

            Console.WriteLine();
            RandomNumberArrayMinMaxAvg();
            */

            /*
            int a = 10;
            int b = a;
            Console.WriteLine("{0} {1}", a, b);

            a = -99;
            Console.WriteLine("{0} {1}", a, b);
            
            int[] arr = CreateRandomArray(12);
            
            int[] arr2 = MakeACopy(arr); 

            //Console.WriteLine("[{0}]", string.Join(", ", arr));
            PrintArray(arr);
            PrintArray(arr2);
            Console.WriteLine("----------------------------------------------");

            arr2[0] = -99;
            PrintArray(arr);
            PrintArray(arr2);
            */

            int[] arr = CreateRandomArray(12);
            PrintArray(arr);

            int limit = 30;
            Console.WriteLine("Count values bigger than {0}: {1}", limit, Count(arr, limit));

        }

        public static void NumberArray()
        {
            int[] num1 = new int[10];
            int[] num2 = new int[10];

            for (int i = 1; i < num1.Length; ++i)
            {
                num1[i] = i;
                Console.WriteLine(num1[i]);
            }
            Console.WriteLine();

            for (int i = num2.Length - 1; i > 0; i--)
            {
                num2[i] = i;
                Console.WriteLine(num2[i]);
            }
        }

        public static int[] MakeACopy(int[] original)
        {
            int[] arr = new int[original.Length];
            for (int i = 0; i < arr.Length; i++) 
            {
                arr[i] = original[i];
            }
            return arr;
        }

        public static void RandomNumberArray()
        {         
            int[] arr = new int[10];

            Random rand = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(100);
                
            }

            Console.WriteLine("[{0}]", string.Join(", ", arr));
            Console.WriteLine();

            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();
            Console.WriteLine(arr[1]);
            Console.WriteLine(arr[4]);
            Console.WriteLine(arr[9]);
            Console.WriteLine();

            for(int i = 0; i < arr.Length; i += 2)
            {
                Console.WriteLine(arr[i]);
            }
        }

        public static void RandomNumberArrayCrazyRange()
        {
            int min = -50;
            int max = 50;

            int[] arr = new int[10];

            Random rand = new Random();

            foreach (int i in arr)
            {
                arr[i] = rand.Next(min, max);
                Console.WriteLine(arr[i]);
            }
        }
        
        public static void RandomNumberArrayZählen()
        {
            int[] arr = new int[10];

            Random rand = new Random();

            int summe = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(100);

                Console.WriteLine(summe += arr[i]); 
            }
            Console.WriteLine();          
        }


        public static int Count(int[] numbers, int limit)
        {
            int count = 0;
            foreach (int value in numbers)
            {
                if (value > limit)
                {
                    count++;
                }
            }
            return count;
        }

        public static int[] CreateRandomArray(int size)
        {
            int[] arr = new int[size];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(100);
            }
            return arr;
        }

        public static void PrintArray(int[] arr)
        {
            Console.Write("[");
            bool first = true;
            foreach (int value in arr) {
                if (!first)
                {
                    Console.Write(", ");
                }                
                Console.Write(value);
                first = false;
            }
            Console.WriteLine("]");
        }


        public static void RandomNumberArrayMinMaxAvg()
        {
             
        }
    }
}
