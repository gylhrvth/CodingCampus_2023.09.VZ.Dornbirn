using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Net.Http.Headers;
using System.Reflection.Metadata;

namespace Fabienne.Week02
{
    public class Arrays
    {
        public static Random rand = new Random();
        public static void Start()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;

            //int[] original = { 1, 7, 8 , 11, 32, 4, -5};         
            //Console.WriteLine("[{0}]", string.Join(", ", NumberArray()));          
            //Console.WriteLine("[{0}]", string.Join(", ", NumbArrayReverse()));

            //MakeACopy(original);

            //RandomNumberArray();

            //RandomNumberArrayCrazyRange();
            //PrintRandomNumberArrayCrazyRange();

            //RandomNumberArrayZählen();

            //RandomNumberArrayMinMaxAvg();

            //int a = 10;
            //int b = a;
            //Console.WriteLine("{0} {1}", a, b);

            // a = -99;
            //Console.WriteLine("{0} {1}", a, b);

            //int[] arr = CreateRandomArray(12);

            //int[] arr2 = MakeACopy(arr); 

            //Console.WriteLine("[{0}]", string.Join(", ", arr));
            //PrintArray(arr);
            //PrintArray(arr2);
            //Console.WriteLine("----------------------------------------------");

            // arr2[0] = -99;
            // PrintArray(arr);
            //PrintArray(arr2);

            int[] arr = CreateRandomArray(12);
            //PrintArray(arr);

            //int limit = 30;
            //Console.WriteLine("Count values bigger than {0}: {1}", limit, Count(arr, limit));

            //int[] testArray = RandomNumberArray3(20);
            //PrintArray(testArray);

            //Console.WriteLine("Minimum: {0}", Minimum(testArray));
            //Console.WriteLine("Maximum: {0}", Maximum(testArray));
            //Console.WriteLine("Avarage: {0}", Average(testArray));

            //PrintArray(arr);
            //Console.WriteLine("===============================================");
            //BubblesortAscending(arr);
            //PrintArray(arr);
            //Console.WriteLine("===============================================");
            //BubblesortDescending(arr);
            //PrintArray(arr);

            ////int[] arr2 = CreateRandomArray(12);
            ////GnomeSort(arr2);

            //int[] arr3 = CreateRandomArray(12);
            //PrintArray(arr3);
            //SelectionSort(arr3);

            //int[] arr4 = CreateRandomArray(12);
            //PrintArray(arr4);
            //InsertionSort(arr4);

            int[,] arr5 = new int[7, 8];
            int[,] rand2dArray = CreateRandom2DArray();

            PrintTwoDeeArray(rand2dArray);

            int[,] arr6 = PascalDreieck();
            PrintTwoDeeArray(arr6);
        }
        public static int[] NumberArray()
        {
            int[] num1 = new int[10];

            for (int i = 0; i < num1.Length; ++i)
            {
                num1[i] = i + 1;
            }

            return num1;
        }
        public static int[] NumbArrayReverse()
        {
            int[] num2 = new int[10];

            for (int i = 0; i < num2.Length; i++)
            {
                num2[i] = num2.Length - i;
            }

            return num2;
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
        public static int[] RandomNumberArray() //help
        {
            int[] arr = new int[10];

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

            for (int i = 0; i < arr.Length; i += 2)
            {
                Console.WriteLine(arr[i]);
            }

            return arr;
        }
        public static int[] RandomNumberArray2()
        {
            Random rand = new Random();

            for (int i = 0; i < RandomNumberArray().Length; i++)
            {
                RandomNumberArray()[i] = rand.Next(100);
            }

            //Console.WriteLine("[{0}]", string.Join(", ", arr));
            Console.WriteLine();

            foreach (int i in RandomNumberArray())
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();
            Console.WriteLine(RandomNumberArray()[1]);
            Console.WriteLine(RandomNumberArray()[4]);
            Console.WriteLine(RandomNumberArray()[9]);
            Console.WriteLine();

            for (int i = 0; i < RandomNumberArray().Length; i += 2)
            {
                Console.WriteLine(RandomNumberArray()[i]);
            }

            return RandomNumberArray();
        }
        public static int[] RandomNumberArray3(int size)
        {
            int[] arr = new int[size];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(1, 101);
            }
            return arr;
        }
        public static int[] RandomNumberArrayCrazyRange()
        {
            int min = -50;
            int max = 50;

            int[] arr = new int[10];

            Random rand = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(min, max);
            }
            return arr;
        }
        public static void PrintRandomNumberArrayCrazyRange() //passt so braucht void
        {
            foreach (int i in RandomNumberArrayCrazyRange())
            {
                Console.WriteLine(i);
            }
        }
        public static int RandomNumberArrayZählen()
        {
            int[] arr = new int[10];

            Random rand = new Random();

            int summe = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(100);

                Console.WriteLine(summe += arr[i]);
            }
            return summe;
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
        public static int[] PrintArray(int[] arr) //idk yet
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

            return arr;
        }
        public static int Minimum(int[] arr)
        {
            int min = Int32.MaxValue;

            for (int i = 0; i < arr.Length; ++i)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            return min;
        }
        public static int Maximum(int[] arr)
        {
            int max = Int32.MinValue;

            for (int i = 0; i < arr.Length; ++i)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }
        public static double Average(int[] arr)
        {
            return arr.Average();
        }
        public static void BubblesortAscending(int[] arr) //blub blub blub
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
        public static void BubblesortDescending(int[] arr) //blub blub blub
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] < arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
        public static void GnomeSort(int[] arr) //careful: bites ankles
        {
            int i = 2;

            while (i < arr.Length)
            {
                if (arr[i] >= arr[i - 1])
                {
                    i = i + 1;
                }
                else
                {
                    (arr[i], arr[i - 1]) = (arr[i - 1], arr[i]);

                    if (i >= 2)
                    {
                        i--;
                    }
                }
            }
            Console.WriteLine("[{0}]", string.Join(", ", arr));
        }
        public static void SelectionSort(int[] arr)
        {
            int min;

            for (int i = 0; i < arr.Length; i++)
            {
                min = i;

                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[j] > arr[min])
                    {
                        min = j;

                        (arr[i], arr[min]) = (arr[min], arr[i]);
                    }
                }
            }
            Console.WriteLine("[{0}]", string.Join(", ", arr));
        }
        public static void InsertionSort(int[] arr)
        {
            int j;
            for (int i = 0; i < arr.Length; i++)
            {
                j = i;
                while (j > 0 && arr[j - 1] > arr[j])
                {
                    (arr[j], arr[j - 1]) = (arr[j - 1], arr[j]);
                    j--;
                }
            }
            Console.WriteLine("[{0}]", string.Join(", ", arr));
        }
        public static int[,] CreateRandom2DArray(int height = 0, int width = 0)
        {
            while (height < 1 || width < 1)
            {
                try
                {
                    Console.WriteLine("Hello dear traveler, thou shall now enter a number, which shall be the number of an array thou will get to see, thank you for your service, ser or lady. For when thou refuse, may god be on your side, for that shall be then end of your reign: ");
                    height = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Thank thy dear traveler, thou shall now enter a number for the amount of columns for said array. If thou dont, the antique gods of the seven kingdoms shall punish you for your crimes - uwu: ");
                    width = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("That is it! May the gods strike you down and may your family be cursed for eternity you buffoon!");
                    Console.WriteLine();
                }
            }
            int[,] arr = new int[height, width];

            for (int row = 0; row < arr.GetLength(0); row++)
            {
                for (int col = 0; col < arr.GetLength(1); col++)
                {
                    arr[row, col] = rand.Next(0, 101);
                }
            }
            return arr;
        }
        public static void PrintTwoDeeArray(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");

                    if (arr[i, j] > 90)
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                    }
                    else if (arr[i, j] > 80)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                    }
                    else if (arr[i, j] > 70)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                    }
                    else if (arr[i, j] > 60)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                    }
                    else if (arr[i, j] > 50)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                    }
                    else if (arr[i, j] > 40)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    }
                    else if (arr[i, j] > 30)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else if (arr[i, j] > 20)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                }
                Console.WriteLine();
            }
        }
        public static int[,] PascalDreieck(int size = 0)
        {
            int[,] arr = new int[size, size];           
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (i == 0 || j == 0)
                    {
                        arr[0, j] = 1;
                    }
                    else
                    {
                        int sum = arr[i, j - 1] + arr[i - 1, j];
                        arr[i, j] = sum;
                    }
                }
            }
            return arr;
        }
    }
}

