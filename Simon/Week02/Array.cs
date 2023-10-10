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
            PrintArray(MakeACopy(CreateArray(3),3));
            Console.WriteLine("\nRandom Number foreach");
            PrintArray(CreateRandom(5));
            Console.WriteLine("\nRandom Number for");
            CreateRandom2(5);
            Console.WriteLine("\nRandom Number 2,5,10");
            PrintRandom3(5);
            Console.WriteLine("\nRandom Number print every 2. one");
            PrintRandom4(5);
            Console.WriteLine("\nRandom Number Crazy");
            PrintCrazy(5);
            Console.WriteLine("\nRandom Number Array Count");
            

            int a = 7;
            int b = a;

            Console.WriteLine("{0} {1}", a, b);
            b = 0;
            Console.WriteLine("{0} {1}", a, b);




            int[] testArr = CreateArray(5);
            int[] copyArr = MakeACopy(testArr, 5); // Hier kommt die Kopie

            Console.WriteLine("[{0}]", string.Join(", ", testArr));
            Console.WriteLine("[{0}]", string.Join(", ", copyArr));

            Console.WriteLine("===================================");

            copyArr[0] = 99;
            Console.WriteLine("[{0}]", string.Join(", ", testArr));
            Console.WriteLine("[{0}]", string.Join(", ", copyArr));
            Console.WriteLine("---------------------------------");
            

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
        //Print Array v2
        public static void PrintArrayv2(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("[{0}]", string.Join(", ", arr[i]));
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
        public static int[] MakeACopy(int[]arr, int arrlength)
        {
            int[] arra = CreateArray(arrlength);
            int[] arrb = arra;
            return arrb;
        }

        //Aufgabe Random Number Array mit foreach
        public static int[] CreateRandom(int arrlength)
        {
            int[] arr = new int[arrlength];
            foreach (int i in arr)
            {
                arr[i] = random.Next(0, 100);
            }
            return arr;
        }
        //Aufgabe Random Number Array mit for
        public static int[] CreateRandom2(int arrlength)
        {
            int[] arr4 = new int[arrlength];
            Random random = new Random();
            for (int i = 0; i < arrlength; i++)
            {
                arr4[i] = random.Next(0, 100);
            }
            Console.WriteLine("[{0}]", string.Join(", ", arr4));
            return arr4;
        }
        //Aufgabe Random Number Array mit 2,5,10
        public static int[] PrintRandom3(int arrlength)
        {
            int[] arr5 = new int[arrlength];
            Random random = new Random();
            for (int i = 0; i < arrlength; i++)
            {
                if (i == 1 || i == 4 || i == 9)
                {
                    arr5[i] = random.Next(0, 100);
                    Console.WriteLine(arr5[i]);
                }
            }
            return arr5;
        }
        //Aufgabe Random Number Array mit jedem 2. Wert
        public static int[] PrintRandom4(int arrlength)
        {
            int[] arr6 = new int[arrlength];
            Random random = new Random();
            for (int i = 0; i < arrlength; i++)
            {
                if (i % 2 == 0)
                {
                    arr6[i] = random.Next(0, 100);
                    Console.WriteLine(arr6[i]);
                }
            }
            return arr6;
        }
        //Aufgabe Random Number Array Crazy Range
        public static int[] PrintCrazy(int arrlength)
        {
            Random random = new Random();
            int[] arr7 = new int[arrlength];
            int a = 0;
            foreach (int i in arr7)
            {
                arr7[i] = random.Next(-50, 50);
                Console.WriteLine("{0}. = {1}", a + 1, arr7[i]);
                a++;
            }
            return arr7;
        }
        //Aufgabe Random Number Array Count
        public static int[] CreateArrayCount(int arrlength)
        {
            int[] arr8 = new int[arrlength];
            Random random = new Random();
            for (int i = 0; i < arrlength; i++)
            {
                arr8[i] = random.Next(0, 100);
            }
            return arr8;

            /*
        //Aufgabe Random Number Array Count
        public static int[] PrintArrayCount(int arrlength)
        {
            for (int i = 0; i < arrlength, i++)
            {
                if (CreateArrayCount > 30)
                {
                    Console.WriteLine();
                }
            }
            
        }
            */
           
        }
    }
}
