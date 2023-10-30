using Dimitri.Week01;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Dimitri.Week05
{
    internal class SelfTest
    {
        public static Random rnd = new Random();
        public static void Main()
        {
            //CountBackwards(10, 0);

            //CountDivisebleBy3(-30, 30);

            //CountAndAdd2Newline(0, 10);

            //PrintLineStipple("X", 3);

            //PrintRowStipple("Y", 3); 

            //PrintStipple("Z", 3);

            //PrintSlash("X", 5, true);

            //PrintUserStringNTimes();

            int[] arr = new int[] { 0, 1, 23, 5, 12, 4, 4, 2, 5, 2, 10 };

            int[] arr2 = new int[] { 123, 19471, 1, 4, 15715, 15, 1, 5, 15, 1, -10, -100 };

            int[] arr3 = new int[] { 478199, 7812973, 12387123, 12, 3, 123, 12, 3, 1, 3, 1, 3, 1, 8, 9, 15, 1, 5, 1, 5, 1, 5, 15, 1, 5, 0 };

            //PrintFirstAndLast(arr);

            //PrintFirstAndLast(arr2);

            //PrintFirstAndLast(arr3);

            //PrintMyResult("Minimum", GetMin(arr));

            //PrintMyResult("Minimum", GetMin(arr2));

            //PrintMyResult("Minimum", GetMin(arr3));

            //PrintMyResult("Maximum", GetMax(arr));

            //PrintMyResult("Maximum", GetMax(arr2));

            //PrintMyResult("Maximum", GetMax(arr3));

            //PrintMyResult("Avg", GetAvg(arr));

            //PrintMyResult("Avg", GetAvg(arr2));

            //PrintMyResult("Avg", GetAvg(arr3));

            //fillArr(10);

            //int[] arr4 = RandomArray(10);

            //PrintArrayForI(arr4);

            //PrintArrayForI(BubbleSort(arr4, true));

            //PrintArray(FillArray(CreateArray()));

            //string Word1 = "apfel";
            //string Word2 = "regallager";
            //string Word3 = "hanna";
            //string Word4 = "reittier";

            //Console.WriteLine(WordIsPalindrom(Word1));
            //Console.WriteLine(WordIsPalindrom(Word2));
            //Console.WriteLine(WordIsPalindrom(Word3));
            //Console.WriteLine(WordIsPalindrom(Word4));

            string text = Ressources.StringRessources.getHesse();

            Console.WriteLine(LongestWord(text));

            //PrintToday();

            //string culture = "";

            //string[] cultureInfo = new string[] { "de-DE", "fr-FR", "it-IT", "tr-TR", "hu-HU", "en-US" };

            //for(int i = 0; i < cultureInfo.Length; i++)
            //{
            //    culture = cultureInfo[i];
            //    PrintCultureToday(culture);
            //}

        }

        public static void CountBackwards(int start, int end)
        {
            if (start < end)
            {
                int temp = start;
                start = end;
                end = temp;
            }

            for (int i = start; i >= end; --i)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
        }

        public static void CountDivisebleBy3(int start, int end)
        {
            for (int i = start; i <= end; ++i)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static void CountAndAdd2Newline(int start, int end)
        {
            int result = 0;
            while (result <= end)
            {
                if (result <= 5)
                {
                    Console.WriteLine(result);
                    result++;
                }
                else
                {
                    Console.WriteLine("{0}\n", result);
                    result++;
                }
            }
        }

        public static void PrintLineStipple(string symbol, int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                if (i == 0)
                {
                    Console.Write("{0}", symbol);
                }
                else
                { Console.Write(" {0}", symbol); }
            }
            Console.WriteLine();
        }

        public static void PrintRowStipple(string symbol, int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                if (i == amount - 1)
                {
                    Console.Write("{0}", symbol);
                }
                else
                {
                    Console.WriteLine("{0}", symbol);
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
        }

        public static void PrintStipple(string symbol, int amount)
        {
            PrintLineStipple(symbol, amount);
            PrintRowStipple(symbol, amount);
        }

        public static void PrintSlash(string symbol, int amount, bool backslash)
        {
            for (int i = 0; i < amount; i++)
            {
                if (backslash)
                {
                    for (int j = 0; j < i; j++)
                    {
                        Console.Write(" ");
                    }

                    Console.WriteLine(symbol);

                }
                else
                {
                    for (int j = amount - 1; j > i; j--)
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine(symbol);
                }
            }
        }

        //Input

        public static void PrintUserStringNTimes()
        {
            string input = ReadString("Bitte geben Sie einen Text ein:", "Ihre Eingabe enthält keinen Text.");

            int amount = ReadNumber("Wie oft soll der Text ausgegeben werden?", "Die Eingabe ist ungültig, bitte geben Sie eine ganze Zahl ein.");

            for (int i = 0; i < amount; i++)
            {
                Console.WriteLine(input);
            }
        }

        public static string ReadString(string prompt, string onError)
        {
            string input = "";


            while (input.CompareTo("") == 0)
            {
                Console.WriteLine(prompt);
                input = Console.ReadLine();
                if (input.CompareTo("") == 0)
                {
                    Console.WriteLine(onError);
                }
            }

            return input;

        }

        public static int ReadNumber(string prompt, string onError)
        {
            int input = 0;

            string inputString = "";

            while (true)
            {
                try
                {
                    Console.WriteLine(prompt);
                    inputString = Console.ReadLine();
                    input = Convert.ToInt32(inputString);
                    break;
                }
                catch (FormatException fe)
                {
                    Console.WriteLine(onError);
                }
            }


            return input;
        }

        // Arrays

        public static void PrintFirstAndLast(int[] arr)
        {
            Console.WriteLine("First: {0}, Last: {1}", arr[0], arr[arr.Length - 1]);
        }

        public static void PrintMyResult(string solutionType, int result)
        {
            Console.WriteLine("{0}: {1}", solutionType, result);

        }

        public static void PrintMyResult(string solutionType, float result)
        {
            Console.WriteLine("{0}: {1}", solutionType, result);

        }

        public static int GetMin(int[] arr)
        {
            int solution = int.MaxValue;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < solution)
                {
                    solution = arr[i];
                }
            }


            return solution;
        }

        public static int GetMax(int[] arr)
        {
            int solution = int.MinValue;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > solution)
                {
                    solution = arr[i];
                }
            }


            return solution;
        }

        public static float GetAvg(int[] arr)
        {
            //int solution = 0;
            int tmp = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                tmp += arr[i];
            }

            return (float)tmp / arr.Length;
        }

        public static void fillArr(int number)
        {
            int[] arr = new int[number + 1];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i;
                if (i == 0)
                {
                    Console.Write("{0}", arr[i]);
                }
                else
                {
                    Console.Write(" {0}", arr[i]);
                }
            }
            Console.WriteLine();

        }

        public static int[] BubbleSort(int[] arr, bool asc)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (asc)
                    {
                        if (arr[j] < arr[i])
                        {
                            int tmp = arr[i];
                            arr[i] = arr[j];
                            arr[j] = tmp;
                        }
                    }
                    else
                    {
                        if (arr[j] > arr[i])
                        {
                            int tmp = arr[i];
                            arr[i] = arr[j];
                            arr[j] = tmp;
                        }
                    }
                }
            }

            return arr;
        }


        public static void PrintArrayForI(int[] arr)
        {
            Console.Write("[ ");
            for (int i = 0; i < arr.Length; i++)
            {
                if (i == arr.Length - 1)
                {
                    Console.Write("{0} ", arr[i]);
                }
                else
                {
                    Console.Write("{0}, ", arr[i]);
                }
            }
            Console.Write("]");
            Console.WriteLine();
        }

        public static int[] RandomArray(int size)
        {
            int[] arr = new int[size];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(0, 100);
            }

            return arr;
        }


        //2DArrays

        public static int[][] CreateArray()
        {
            int[][] arr = new int[10][];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new int[10];
            }

            return arr;
        }

        public static int[][] FillArray(int[][] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    arr[i][j] = count;
                    count++;
                }
            }

            return arr;
        }

        public static void PrintArray(int[][] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    if (j == 0)
                    {
                        Console.Write("{0}", arr[i][j]);
                    }
                    else if (i == 0 && j == 0)
                    {
                        Console.Write("{0}     ", arr[i][j]);
                    }
                    else if (i == 0)
                    {
                        Console.Write("      {0}", arr[i][j]);
                    }
                    else
                    {
                        Console.Write("     {0}", arr[i][j]);
                    }
                }
                Console.WriteLine();
            }
        }

        // String manipulation

        public static bool WordIsPalindrom(string word)
        {
            bool isPalindrom = false;

            for (int i = 0; i < word.Length / 2; i++)
            {
                if (word[i].CompareTo(word[word.Length - i - 1]) == 0)
                {
                    isPalindrom = true;
                }
                else
                {
                    isPalindrom = false;
                }
            }
            return isPalindrom;
        }

        public static string LongestWord(string text)
        {
            string word = "";

            text = Regex.Replace(text, "[.,!?()\r\"\';„“]", "");

            char[] delimiters = new char[] { ' ', '\n'};

            string[] textArr = text.Split(delimiters);

            for (int i = 0; i < textArr.Length; i++)
            {
                if (textArr[i].Length > word.Length)
                {
                    word = textArr[i];
                }
            }

            return word;
        }

        public static void PrintStringArr(string[] arr)
        {
            Console.Write("[ ");
            for (int i = 0; i < arr.Length; i++)
            {
                if (i == 0)
                {
                    Console.Write("{0}", arr[i]);
                }
                else
                {
                    Console.Write(", {0}", arr[i]);
                }
            }
            Console.Write(" ]");
            Console.WriteLine();
        }

        //Calendar

        public static void PrintToday()
        {
            DateTime today = DateTime.Now;

            CultureInfo currentCulture = new CultureInfo("de-AT");

            Console.WriteLine(today.ToString("ddd dd.MM.yyyy", currentCulture));
        }

        public static void PrintCultureToday(string culture)
        {
            DateTime today = DateTime.Now;

            CultureInfo currentCulture = new CultureInfo(culture);

            Console.WriteLine(today.ToString("dddd", currentCulture));

        }

        //Regex Bonus


    }
}





