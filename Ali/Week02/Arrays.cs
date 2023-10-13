using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ali.Week02
{
    internal class Arrays
    {
        public static Random rand = new Random();
        public static void Start()
        {
            Console.WriteLine("Aufgabe 1: Number Array");
            int[] arr = CreateArray(5);
            PrintAnArray(arr);

            int[] arr2 = CreateArray2(5);
            PrintAnArray(arr2);
            Console.WriteLine("");

            Console.WriteLine("Aufgabe 2: Copy Array");
            int[] orginal = OriginalArray(5);
            Console.WriteLine("Original");
            Console.WriteLine("[{0}]", string.Join(", ", OriginalArray(5)));

            Console.WriteLine("Copy");
            Console.WriteLine("[{0}]", string.Join(", ", MakeACopy(orginal)));
            Console.WriteLine("");

            Console.WriteLine("Aufgabe 3: Random Numer Array");
            int[] random1 = ArrayRandom(10);
            Console.WriteLine("[{0}]", string.Join(", ", random1));

            Console.WriteLine(" ");
            Console.WriteLine("Random Array foreach");
            foreach (int element in random1)
            {
                Console.Write(element + " ");
            }

            Console.WriteLine(" ");
            Console.WriteLine("Zweiter Wert: " + random1[1]);
            Console.WriteLine("Fünfter Wert: " + random1[4]);
            Console.WriteLine("Zehnter Wert: " + random1[9]);


            //Console.WriteLine("[{0}]", string.Join(", ", random1));
            //Console.WriteLine("2 Wert: " + random1[1]);
            //Console.WriteLine("4 Wert: " + random1[3]);
            //Console.WriteLine("6 Wert: " + random1[5]);
            //Console.WriteLine("8 Wert: " + random1[7]);
            //Console.WriteLine("10 Wert: " +random1[9]);

            //
            //Console.WriteLine("[{0}]", string.Join(", ", ArrayRandom1(10)));

            Console.WriteLine("");
            Console.WriteLine("Aufgabe 4: Random Number Array Crazy Range");
            int[] crazy = CrazyArray(10);

            foreach (int element in crazy)
            {
                Console.Write(element + " ");

            }

            Console.WriteLine();

            Console.WriteLine("Aufgabe: Random Number Array Zählen");
            int count = ArrayCount(crazy);
            Console.WriteLine("Es sind/ist " + count + " Zahl/en über 30!");
            Console.WriteLine();

            Console.Write("Aufgabe: Random Number Array Summe");
            int sum = ArraySum(random1);
            Console.WriteLine();
            Console.WriteLine("Die Summe ist:" + sum);
            Console.WriteLine();

            Console.WriteLine("Aufgabe: Random Number Array Min/Max/Avg");
            int min = ArrayMin(random1);
            Console.WriteLine();
            Console.WriteLine("Der Minimum ist:" + min);
            

            int max = ArrayMax(random1);
            Console.WriteLine();
            Console.WriteLine("Der Maximum ist:" + max);

            double avg = ArrayAvg(random1);
            Console.WriteLine();
            Console.WriteLine("Der Average ist:" + avg);
            Console.WriteLine();

            Console.WriteLine("Aufgabe: Bubblesort mit Zahlen");
            Console.WriteLine();
            Console.WriteLine("[{0}]", string.Join(", ", BubbleArray(random1)));




        }


        public static void PrintAnArray(int[] arr)
        {

            Console.WriteLine("[{0}]", string.Join(", ", arr));



            /*
                      for (int i = 0; i < arr.Length; ++i)
                       {
                           Console.WriteLine("{0}. = {1}", i, arr[i]);
                       }
            */
        }

        public static int[] CreateArray(int size)
        {
            int[] arr = new int[size];
            for (int i = 0; i < arr.Length; ++i)
            {
                arr[i] = 1 + i;
            }

            return arr;
        }
        public static int[] CreateArray2(int size)
        {
            int[] arr2 = new int[size];
            for (int i = 0; i < arr2.Length; ++i)
            {
                arr2[i] = arr2.Length - i;
            }
            return arr2;
        }



        /*      public static void prtintStartArray()
              {
                  int[] arr = {1, 2, 3, 4, 5, 6, 7, 8, 9};





                  int[] arr2 = { 9, 8, 7, 6, 5, 4, 3, 2, 1 };

                  Console.WriteLine(arr2);

                  for (int j = 0;j < arr2.Length; ++j)
                  {
                      Console.WriteLine("{0}.= {1}", j, arr2[j]);


                  }
        */
        //public static int[] makeAcopy(int[] original)
        //{
        //    PrintAnArray(original);

        //    return original;

        //}

        public static int[] OriginalArray(int size)
        {
            int[] orginal = new int[size];

            for (int i = 0; i < orginal.Length; i++)
            {
                orginal[i] = i + 1;
            }
            return orginal;

        }

        public static int[] MakeACopy(int[] orginal)
        {
            int[] copy = new int[orginal.Length];

            for (int i = 0; i < orginal.Length; i++)
            {
                copy[i] = orginal[i];
            }
            return copy;

        }








        public static int[] ArrayRandom(int size)

        {

            int[] random1 = new int[size];
            for (int i = 0; i < random1.Length; i++)
            {
                random1[i] = rand.Next(0, 101);
            }
            Console.WriteLine();
            for (int i = 0; i < random1.Length; i += 2)

            {
                Console.WriteLine($"{i}= {random1[i]}");

            }
            return random1;


        }
        public static int[] CrazyArray(int size)
        {
            int[] crazy = new int[size];
            for (int i = 0; i < crazy.Length; i++)
            {
                crazy[i] = rand.Next(-50, 50);
            }
            return crazy;
        }
        public static int ArrayCount(int[] arr)
        {
            int count = 0;
            foreach (int i in arr)
            {
                if (i > 30)
                {
                    count++;
                }
            }
            return count;
        }
        public static int ArraySum(int[] random1)
        {
            int sum = 0;
            foreach (int value in random1)
            {
                sum += value;
            }
            return sum;
        }
        public static int ArrayMin(int[] random1)
        {
            int min = Int32.MaxValue;
            foreach (int value in random1)
            {
                if (value < min)
                {
                    min = value;
                }
            }
            return min;
        }
        public static int ArrayMax(int[] random1)
        {
            int max = Int32.MinValue;
            foreach (int value in random1)
            {
                if (value > max)
                {
                    max = value;
                }

            }
            return max;
        }
        public static double ArrayAvg(int[] random1)
        {
            
            if (random1.Length == 0)
            {
                return 0;
            }
            return ArraySum(random1)/ (double)random1.Length;
        }
        public static int[] BubbleArray(int[] random1)
        {
            int a = random1.Length;
            bool sorted = false;
            while (!sorted)
            {
                sorted = true;
                for(int i = 0; i < a-1; i++)
                {
                    if (random1[i] < random1[i + 1])
                    {
                        int t = random1[i];
                        random1[i] = random1[i + 1];
                        random1[i +1] = t;
                        sorted = false;
                    }
                }
            }
            return random1;
        }





    }
}











