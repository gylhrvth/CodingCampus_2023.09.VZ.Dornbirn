using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simon.Week02
{
    public class Array
    {
        public static Random random = new Random();
        public static void Start()
        {

            Console.WriteLine("\nNumber Array");
            PrintArray(CreateArray(3));
            Console.WriteLine("\nNumber Array reverse");
            PrintArray(CreateArrayreverse(3));
            Console.WriteLine("\nMake a Copy");
            PrintArray(MakeACopy(CreateArray(3), 3));
            Console.WriteLine("\nRandom Number foreach");
            CreateRandomforeach(5);
            Console.WriteLine("\nRandom Number for");
            CreateRandom(5);
            Console.WriteLine("\nRandom Number 2,5,10");
            PrintRandom2(10);
            Console.WriteLine("\nRandom Number print every 2. one");
            PrintArrayevery2(CreateRandom3(5));
            Console.WriteLine("\nRandom Number Crazy");
            PrintCrazy(5);
            Console.WriteLine("\nRandom Number Array Count");
            PrintArrayCount(CreateArrayCount(20));
            Console.WriteLine("\nRandom Number Array Summe");
            PrintSumm(CreateArrayCount(3));


            Console.WriteLine("\n\n");
            int a = 7;
            int b = a;

            Console.WriteLine("{0} {1}", a, b);
            b = 0;
            Console.WriteLine("{0} {1}", a, b);


            Console.WriteLine();
            Console.WriteLine("TEST MAKE A COPY");
            int[] testArr = CreateArray(5);
            int[] copyArr = MakeACopy(testArr, 5); // Hier kommt die Kopie

            Console.WriteLine("[{0}]", string.Join(", ", CreateArray(5)));
            Console.WriteLine("[{0}]", string.Join(", ", copyArr));

            Console.WriteLine("===================================");

            testArr[0] = 99;
            Console.WriteLine("[{0}]", string.Join(", ", testArr));
            Console.WriteLine("[{0}]", string.Join(", ", copyArr));
        }
        //Aufgabe Number Array
        public static int[] CreateArray(int arrlength)
        {
            int[] arr = new int[arrlength];
            for (int i = 0; i < arrlength; i++)
            {
                arr[i] = i + 1;
            }
            return arr;
        }

        //Print Array
        public static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("{0}. = {1}", i + 1, arr[i]);
            }
        }

        //Aufgabe Number Array 2
        public static int[] CreateArrayreverse(int arrlength)
        {
            int[] arr = new int[arrlength];
            int a = arr.Length;
            for (int i = 0; i < arrlength; i++)
            {
                arr[i] = a;
                a--;
            }
            return arr;
        }

        //Aufgabe Kopie
        public static int[] MakeACopy(int[] arr, int arrlength)
        {
            int[] arra = CreateArray(arrlength);
            int[] arrb = arra;
            return arrb;
        }

        //Aufgabe Random Number Array mit foreach
        public static int[] CreateRandomforeach(int arrlength)
        {
            int[] arr = new int[arrlength];
            int a = 0;
            foreach (int i in arr)
            {
                arr[i] = random.Next(0, 100);
                Console.WriteLine("{0}. = {1}", a + 1, arr[i]);
                a++;
            }
            return arr;
        }
        //Aufgabe Random Number Array mit for
        public static int[] CreateRandom(int arrlength)
        {
            int[] arr = new int[arrlength];
            for (int i = 0; i < arrlength; i++)
            {
                arr[i] = random.Next(0, 100);
            }
            Console.WriteLine("[{0}]", string.Join(", ", arr));
            return arr;
        }
        //Aufgabe Random Number Array mit 2,5,10
        public static int[] PrintRandom2(int arrlength)
        {
            int[] arr = new int[arrlength];
            for (int i = 0; i < arrlength; i++)
            {
                if (i == 1 || i == 4 || i == 9)
                {
                    arr[i] = random.Next(0, 100);
                    Console.WriteLine(arr[i]);
                }
            }
            return arr;
        }
        //Aufgabe Random Number Array mit jedem 2. Wert
        public static int[] CreateRandom3(int arrlength)
        {
            int[] arr = new int[arrlength];
            Random random = new Random();
            for (int i = 0; i < arrlength; i ++)
            {
                if (i % 2 == 0)
                {
                    arr[i] = random.Next(0, 100);
                    //Console.WriteLine(arr[i]);
                }
            }
            return arr;
        }
        //Print Array
        public static void PrintArrayevery2(int[] arr)
        {
            for (int i = 0; i < arr.Length; i +=2)
            {
                Console.WriteLine("{0}. = {1}", i + 1, arr[i]);
            }
        }
        //Aufgabe Random Number Array Crazy Range
        public static int[] PrintCrazy(int arrlength)
        {
            int[] arr = new int[arrlength];
            int a = 0;
            foreach (int i in arr)
            {
                arr[i] = random.Next(-50, 50);
                Console.WriteLine("{0}. = {1}", a + 1, arr[i]);
                a++;
            }
            return arr;
        }
        //Aufgabe Random Number Array Count
        public static int[] CreateArrayCount(int arrlength)
        {
            int[] arr = new int[arrlength];
            for (int i = 0; i < arrlength; i++)
            {
                arr[i] = random.Next(1, 100);
            }
            return arr;
        }

        //Aufgabe Random Number Array Count
        public static void PrintArrayCount(int[]arr)
        {
            PrintArray(arr);
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 30)
                {
                    count++;
                }
            }
            Console.WriteLine("Over 30 ammount: {0}", count);
        }
        //Aufgabe Random Number Array Summ
        public static void PrintSumm(int[] arr)
        {
            PrintArray(arr);
            int a = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                a = a + arr[i];
            }
            Console.WriteLine("Summe: {0}", a);
        }
        //Aufgabe Random Number Array Min
        public static int CalcMin(int[] arr)
        {
            int min = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            return min;
        }
        //Aufgabe Random Number Array Max
        public static int CalcMax(int[] arr)
        {
            int max = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }
        //Aufgabe Random Number Array Avg
        public static int CalcAvg(int[] arr)
        {
            int avg = 0;
            int a = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                a = a + arr[i];
            }
            avg = a / arr.Length;
            return avg;
        }
        //Aufgabe Random Number Array Min Index
        public static int IndexMin(int[] arr)
        {
            int min = 0;
            int index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                    index = i;
                }
            }
            Console.WriteLine(index);
            return index;
        }
        //Aufgabe Random Number Array Max Index
        public static int IndexMax(int[] arr)
        {
            int max = 0;
            int index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                    index = i;
                }
            }
            return max;
        }


    }
}
