using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Michael.Week05
{
    internal class Selbsttest
    {
        public static void Start()
        {
            ZweiVier('x', 8, false);
        }


        public static void EinsEins()
        {
            for (int i = 10; i >= 0; i--)
            {
                Console.Write(i + " ");
            }
        }


        public static void EinsZwei()
        {
            for (int i = -30; i <= 30; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }


        public static void EinsDrei()
        {
            int i = 0;
            while (i <= 10)
            {
                Console.WriteLine(i);

                if (i > 5)
                {
                    Console.WriteLine();
                }

                i++;
            }
        }


        public static void ZweiEins(string symbol, int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                Console.Write(symbol + " ");
            }
        }


        public static void ZweiZwei(string symbol, int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                Console.WriteLine(symbol + "\n");
            }
        }


        public static void ZweiDrei(string symbol, int amount)
        {
            ZweiEins(symbol, amount);
            ZweiZwei(symbol, amount);
        }


        public static void ZweiVier(char symbol, int length, bool backslash = false)
        {
            for (int y = 0; y < length; y++)
            {
                for (int x = 0; x < length; x++)
                {
                    if (backslash && x - y == 0)
                    {
                        Console.Write(symbol);
                        break;
                    }
                    else if (!backslash && x + y == length - 1)
                    {
                        Console.Write(symbol);
                        break;
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }


        public static void DreiEins()
        {
            string userString = "";
            int userInt = 0;

            while (userString == null || userString == "")
            {
                Console.WriteLine("please enter a string that shall be repeated");
                userString = Console.ReadLine().Trim();
            }

            while (true)
            {
                try
                {
                    Console.WriteLine("and how often shall we repeat it?");
                    userInt = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("invalid input, sorry");
                }
            }

            for (int i = 0; i < userInt; i++)
            {
                Console.WriteLine(userString);
            }
        }


        public static string VierEins(int[] array = null)
        {
            if (array == null) array = new int[] { 0, 1, 23, 5, 12, 4, 4, 2, 5, 2, 10 };

            if (array.Length < 2)
            {
                Console.WriteLine("sorry, the array does not have enough (2) elements");
                return "sorry, the array does not have enough (2) elements";
            }

            string returnString = $"First: {array[0]}, Last: {array[array.Length]}";
            return returnString;
        }


        public static int VierZweiMin(int[] array)
        {
            if (array.Length < 1)
            {
                Console.WriteLine("sorry, the array does not have enough (1) elements");
                return -1;
            }

            int min = array[0];

            foreach(int element in array)
            {
                if (element < min) min = element;
            }

            return min;
        }


        public static int VierZweiMax(int[] array)
        {
            if (array.Length < 1)
            {
                Console.WriteLine("sorry, the array does not have enough (1) elements");
                return -1;
            }

            int max = array[0];

            foreach (int element in array)
            {
                if (element > max) max = element;
            }

            return max;
        }


        public static int VierZweiAverage(int[] array)
        {
            if (array.Length < 1)
            {
                Console.WriteLine("sorry, the array does not have enough (1) elements");
                return -1;
            }

            int sum = 0;

            foreach (int element in array)
            {
                sum += element;
            }

            return sum / array.Length;
        }


        public static void VierZweiPrint(string title, int result)
        {
            Console.WriteLine(title + ": " + result);
        }


        public static int[] VierDreiCreate(int length)
        {
            int[] resultArray = new int[length + 1];

            for (int i = 0; i <= length; i++)
            {
                resultArray[i] = i;
            }

            return resultArray;
        }


        public static void VierDreiPrint(int[] array)
        {
            Console.Write("[");
            for(int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + ", ");
            }
            Console.WriteLine("]");

            Console.WriteLine("----------------------------");

            Console.Write("[");
            foreach (int element in array)
            {
                Console.Write(element + ", ");
            }
            Console.WriteLine("]");

            Console.WriteLine("----------------------------");

            Console.WriteLine($"[{string.Join(",", array)}]");
        }


        public static void VierVier(int[] array, bool descending)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (descending)
                    {
                        if (array[j] < array[j + 1])
                        {
                            int temp = array[j];
                            array[j] = array[j + 1];
                            array[j + 1] = temp;
                        }
                    }
                    else
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
        }


        public static int[][] FünfEinsCreate(int width, int length)
        {
            int[][] returnArray = new int[length][];

            for (int i = 0; i < length; i++)
            {
                returnArray[i] = new int[width];
            }

            return returnArray;
        }

        
        public static void FünfEinsFill(int[][] array)
        {
            int counter = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    array[i][j] = counter;
                    counter++;
                }
            }
        }


        public static void PrintX(int length, char character)
        {
            for (int row = 0; row < length; row++)
            {
                for (int col = 0; col < length; col++)
                {
                    if (row == col || row + col == length)
                    {
                        Console.Write(character + " ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
        }


        public static void FünfEinsPrint(int[][] array)
        {
            double amountOfEntries = (double) array[array.Length - 1][array[array.Length - 1].Length - 1];
            int digits = (int) Math.Floor(Math.Log10(amountOfEntries));

            foreach (int[] row in array)
            {
                foreach(int number in row)
                {
                    Console.Write(("" + number).PadRight(digits));
                }
            }
        }
    }
}
