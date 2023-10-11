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

            /*Console.WriteLine("\nTEST MAKE A COPY");
            int[] testArr = CreateArray(5);
            int[] copyArr = MakeACopy(testArr, 5); // Hier kommt die Kopie

            Console.WriteLine("[{0}]", string.Join(", ", CreateArray(5)));
            Console.WriteLine("[{0}]", string.Join(", ", copyArr));
            Console.WriteLine("===================================");
            testArr[0] = 99;
            Console.WriteLine("[{0}]", string.Join(", ", testArr));
            Console.WriteLine("[{0}]", string.Join(", ", copyArr));
            */

            Console.WriteLine("\nRandom Number Array:");
            int[] rnarr = CreateRArray(0, 100, 10); //Array wird erstellt der für die Ganze Aufgabe Random Number Array verwendet wird
            Console.WriteLine("[{0}]", string.Join(", ", rnarr));

            Console.WriteLine("\nRandom Number foreach");
            PrintRandomforeach(rnarr);
            Console.WriteLine("\nRandom Number for");
            PrintRandom(rnarr);
            Console.WriteLine("\n\nRandom Number 2,5,10");
            PrintRandom2(rnarr);
            Console.WriteLine("\nRandom Number print every 2. one");
            PrintRandomloop(rnarr);
            Console.WriteLine("\nRandom Number Crazy");
            int[] crazyarr = CreateRArray(-50, 50, 10);
            PrintRandomforeach(crazyarr);
            Console.WriteLine("\nRandom Number Array Zaehlen");
            int[] calcarr = CreateRArray(1, 100, 10);
            Console.WriteLine("[{0}]", string.Join(", ", calcarr));
            PrintArrayCount(calcarr);
            Console.WriteLine("\nRandom Number Array Summe");
            PrintSumm(calcarr);
            Console.WriteLine("Min:{0} Index: {3} Max: {1} Index: {4} Avg: {2}", CalcMin(calcarr), CalcMax(calcarr), CalcAvg(calcarr), IndexMin(calcarr), IndexMax(calcarr));
            


            /*
            Console.WriteLine("\nRandom Number Array Summe");
            PrintSumm(CreateArrayCount(3));
            IndexMax(CreateArrayCount(3));
            */
            /*
            Console.WriteLine("\n\n");
            int a = 7;
            int b = a;
            Console.WriteLine("{0} {1}", a, b);
            b = 0;
            Console.WriteLine("{0} {1}", a, b);
            */


        }
        //Create Random Number Array
        public static int[] CreateRArray(int lower, int upper, int length)
        {
            int[] arr = new int[length];
            for (int i = 0; i < length; i++)
            {
                arr[i] = random.Next(lower, upper);
            }
            return arr;
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
        public static void PrintRandomforeach(int[] randomarr)
        {
            Console.Write("[");
            bool first = true;
            foreach (int value in randomarr)
            {
                if (!first)// ist das gleiche wie first == false
                {
                    Console.Write(", ");
                }
                Console.Write(value);
                first = false;
            }
            Console.WriteLine("]");
        }
        
        //Aufgabe Random Number Array mit for
        public static void PrintRandom(int[] randomarrfor)
        {
            Console.Write("[");
            for (int i = 0; i < randomarrfor.Length; i++)
            {
                if (i < randomarrfor.Length - 1)
                {
                    Console.Write(randomarrfor[i]);
                    Console.Write(", ");
                }
                else
                {
                    Console.Write(randomarrfor[i]);
                }
            }
            Console.Write("]");
        }

        //Aufgabe Random Number Array mit 2,5,10
        public static void PrintRandom2(int[] arr)
        {
            Console.Write("{0}, {1}, {2}", arr[1], arr[4], arr[9]);
        }

        //Aufgabe Random Number Array mit jedem 2. Wert
        public static void PrintRandomloop(int[] arr)
        {
            Console.Write("[");
            for (int i = 0; i < arr.Length; i ++)
            {
                if (i % 2 == 1 && i < arr.Length - 2)
                {
                    if (i > 1)
                    {
                        Console.Write(" ,");
                    }
                    Console.Write(arr[i]);
                }
            }
            Console.WriteLine("]");
        }

        /*
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
        */
        //Aufgabe Random Number Array Count
        public static void PrintArrayCount(int[] arr)
        {
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

        //Aufgabe Random Number Array Max
        public static int CalcMax(int[] arr)
        {
            int max = arr[0];
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
            int min = arr[0];
            int index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                    index = i;
                }
            }
            return index;
        }
        //Aufgabe Random Number Array Max Index
        public static int IndexMax(int[] arr)
        {
            int max = arr[0];
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
