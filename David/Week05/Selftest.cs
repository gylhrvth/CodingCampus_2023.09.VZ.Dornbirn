using System;
using System.ComponentModel.Design;
using System.Drawing;
using Ressources;
using David.Week04;
using System.Security.Cryptography.X509Certificates;
using System.ComponentModel.DataAnnotations;

namespace David.Week05
{
    public class Selftest
    {
        public static Random random = new Random(123);

        public static void Start()
        {
            Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("SCHLEIFEN");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Aufgabe1:");

            Aufgabe1(10);
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Aufgabe2:");

            Aufgabe2(30);
            Console.WriteLine();

            Console.WriteLine("Aufgabe3:");

            Aufgabe3(10);
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("METHODEN");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Aufgabe1:");

            string symbol = "X";
            int amount = 10;
            Aufgabe1M(symbol, amount);
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Aufgabe2:");

            string symbol2 = "X";
            int amount2 = 3;
            Aufgabe2M(symbol2, amount2);
            Console.WriteLine();

            Console.WriteLine("Aufgabe3:");

            string symbol3 = "X";
            int amount3 = 3;
            Aufgabe3M(symbol3, amount3);
            Console.WriteLine();

            Console.WriteLine("Aufgabe4:");

            int size = 3;
            bool backslash = true;
            Aufgabe4M("x", size, backslash);
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("INPUT");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Aufgabe1:");

            //string userInput = ReadString();
            //int rep = ReadNumber();
            //Aufgabe1In(userInput, rep);
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("ARRAYS");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Aufgabe1:");

            int[] arr = new int[] { 0, 1, 23, 5, 12, 4, 4, 2, 5, 2, 10 };
            int[] arr2 = new int[] { 123, 19471, 1, 4, 15715, 15, 1, 5, 15, 1, -10, -100 };
            int[] arr3 = new int[] { 478199, 7812973, 12387123, 12, 3, 123, 12, 3, 1, 3, 1, 3, 1, 8, 9, 15, 1, 5, 1, 5, 1, 5, 15, 1, 5, 0 };

            string print1 = Aufgabe1ARR(arr);
            Console.WriteLine(print1);

            string print2 = Aufgabe1ARR(arr2);
            Console.WriteLine(print2);

            string print3 = Aufgabe1ARR(arr3);
            Console.WriteLine(print3);
            Console.WriteLine();

            Console.WriteLine("Aufgabe2:");

            int arrMax = Aufgabe2ARRMax(10);
            PrintMyResult("Maximum ", Aufgabe2ARRMax(arrMax));

            int arrMin = Aufgabe2ARRMin(10);
            PrintMyResult("Minimum ", Aufgabe2ARRMin(arrMin));

            double arrAvg = Aufgabe2ARRAvg(10);
            PrintMyResultAVG("Durchschnitt ", arrAvg);
            Console.WriteLine();

            Console.WriteLine("Aufgabe3:");

            int[] arrdiv = Aufgabe3ARR(10);
            PrintAufgabe3ARRFor(arrdiv);
            Console.WriteLine();
            PrintAufgabe3ARRForEach(arrdiv);
            Console.WriteLine();
            PrintAufgabe3ARRStringJoin(arrdiv);
            Console.WriteLine();

            Console.WriteLine("Aufgabe4:");

            int[] ranArr = BubbleRandom(10);
            Console.WriteLine();

            int[] arrB = PrintBubbleASC(ranArr, true);
            PrintBubbleAscDesc(arrB);
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("2D ARRAYS");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();

            Console.WriteLine("Aufgabe1:");

            int[][] arr2D = Aufgabe1Arr2DCreate(10);
            int[][] arrPrint = Aufgabe1Arr2DFill(arr2D);
            Aufgabe1Arr2DPrint(arrPrint);
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("String manipulation");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();

            Console.WriteLine("Aufgabe1:");

            string Word1 = "Apfel";
            string Word2 = "Regallager";
            string Word3 = "Hanna";
            string Word4 = "Reittier";

            bool tf1 = Aufgabe1StringPalindrom(Word1);
            PrintPallindrom(Word1, tf1);
            bool tf2 = Aufgabe1StringPalindrom(Word2);
            PrintPallindrom(Word2, tf2);
            bool tf3 = Aufgabe1StringPalindrom(Word3);
            PrintPallindrom(Word3, tf3);
            bool tf4 = Aufgabe1StringPalindrom(Word4);
            PrintPallindrom(Word4, tf4);
            Console.WriteLine();

            Console.WriteLine("Aufgabe2:");
            string hesse = StringRessources.getHesse();
            string marie = StringRessources.getText();

            string longest = Aufgabe2LongestW(hesse, marie);
            PrintAufgabeLongestW(longest);
        }


        public static void Aufgabe1(int max)
        {
            for (int i = max; i >= 0; i--)
            {
                Console.Write(i + " ");
            }
        }

        public static void Aufgabe2(int count)
        {
            for (int i = -count; i <= count; i++)
            {
                int teilbar = i % 3;
                if (teilbar == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static void Aufgabe3(int count)
        {
            for (int i = 0; i < count; i++)
            {
                while (i <= 5)
                {
                    Console.WriteLine(i++);
                }
                Console.WriteLine();
                Console.WriteLine(i);
            }
        }

        public static void Aufgabe1M(string symbol, int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                Console.Write(symbol + " ");
            }

        }

        public static void Aufgabe2M(string symbol, int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                if (i < amount - 1)
                {
                    Console.WriteLine(symbol);
                    Console.WriteLine();
                }
                else
                    Console.WriteLine(symbol);
            }
        }


        public static void Aufgabe3M(string symbol, int amount)
        {
            Aufgabe1M(symbol, amount);
            Aufgabe2M(symbol, amount);
        }

        public static void Aufgabe4M(string symbol, int size, bool backslash)
        {
            if (backslash)
            {
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        if (j == i)
                        {
                            Console.Write(symbol);
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        if (j == (size - 1) - i)
                        {
                            Console.Write(symbol);
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine();
                }
            }
        }

        public static string ReadString()
        {
            string userInput = "";
            while (userInput == "")
            {
                try
                {
                    Console.WriteLine("Bitte geben Sie einen Text ein:");
                    userInput = Console.ReadLine();
                }
                catch (FormatException)
                {
                    Console.WriteLine("Das hat leider nicht funktioniert. Bitte geben Sie nochmals einen Text ein:");
                }
            }
            return userInput;
        }
        public static int ReadNumber()
        {
            int userRepNum = 0;
            while (userRepNum == 0)
            {
                try
                {
                    Console.WriteLine("Wie oft soll der Text ausgegeben werden?");
                    userRepNum = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Das hat leider nicht funktioniert. Bitte geben Sie AUSSCHLIESSLICH eine Zahl ein.");
                }
            }
            return userRepNum;
        }
        public static void Aufgabe1In(string text, int rep)
        {
            for (int i = 0; i < rep; i++)
            {
                Console.WriteLine(text);
            }
        }

        public static string Aufgabe1ARR(int[] arr)
        {
            string print1 = "";
            string pos1 = "";
            string pos2 = "";

            for (int i = 0; i < arr.Length; i++)
            {
                if (i == 0)
                {
                    pos1 = Convert.ToString(arr[i]);
                }
                if (i == arr.Length - 1)
                {
                    pos2 = Convert.ToString(arr[i]);
                }
                print1 = ("First: " + pos1 + ", Second: " + pos2 + ",");
            }
            return print1;
        }

        public static int Aufgabe2ARRMax(int arrMax)
        {
            int max = 0;
            int[] arr = new int[arrMax];

            for (int i = 0; i < arr.Length; i++)
            {
                if (i > max)
                {
                    max = i + 1;
                }
            }
            return max;
        }

        public static int Aufgabe2ARRMin(int arrMin)
        {
            int min = arrMin;
            int[] arr = new int[arrMin];

            for (int i = 0; i < arr.Length; i++)
            {
                if (i < min)
                {
                    min = i;
                }
            }
            return min;
        }

        public static double Aufgabe2ARRAvg(int arrAvg)
        {
            int sum = 0;
            int count = 0;
            int[] arr = new int[arrAvg];

            for (int i = 1; i < arr.Length + 1; i++)
            {
                sum = i + sum;
                count++;
            }

            double avg = sum / count;
            return avg;
        }

        public static void PrintMyResult(string text, int value)
        {
            Console.WriteLine(text + value);
        }
        public static void PrintMyResultAVG(string text, double value) ///!!!!
        {
            Console.WriteLine(text, value);
        }

        public static int[] Aufgabe3ARR(int size)
        {
            size = size + 1;
            int[] arr = new int[size];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i;
            }
            return arr;
        }

        public static void PrintAufgabe3ARRFor(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i;
                Console.Write(arr[i] + ", ");
            }
        }
        public static void PrintAufgabe3ARRForEach(int[] arr)
        {
            foreach (int element in arr)
            {
                Console.Write(element + ", ");
            }
        }
        public static void PrintAufgabe3ARRStringJoin(int[] arr)
        {
            Console.WriteLine("{0}", string.Join(", ", arr));
        }

        public static int[] BubbleRandom(int size)
        {
            int[] ranArr = new int[size];

            for (int i = 0; i < ranArr.Length; i++)
            {
                ranArr[i] = random.Next(1, 101);
                Console.Write(ranArr[i] + ", ");
            }
            return ranArr;
        }

        public static int[] PrintBubbleASC(int[] array, bool AscDesc)
        {
            if (AscDesc == false)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    for (int i = 0; i < array.Length - j - 1; i++)// Gewusst was zu tun ist, aber -j-1 nicht gemacht.
                    {
                        if (array[i] > array[i + 1])
                        {
                            int temp = array[i]; // Zwischenspeicher immer über for-Schleife gemacht.
                            array[i] = array[i + 1];
                            array[i + 1] = temp;
                        }
                    }
                }
                Console.WriteLine("Sorted Ascending:");
            }
            else
            {
                for (int j = 0; j < array.Length; j++)
                {
                    for (int i = 0; i < array.Length - j - 1; i++)
                    {
                        if (array[i] < array[i + 1])
                        {
                            int temp = array[i];
                            array[i] = array[i + 1];
                            array[i + 1] = temp;
                        }
                    }
                }
                Console.WriteLine("Sorted Descending:");
            }
            return array;
        }
        public static void PrintBubbleAscDesc(int[] arr)
        {
            for (int i = 0; i < 1; i++)
            {
                Console.Write("{0}", string.Join(", ", arr));
            }
            Console.WriteLine();
        }

        public static int[][] Aufgabe1Arr2DCreate(int size)
        {
            int[][] arr2 = new int[size][];

            for (int i = 0; i < arr2.Length; i++)
            {
                arr2[i] = new int[size];
            }
            return arr2;
        }

        public static int[][] Aufgabe1Arr2DFill(int[][] arr2)
        {
            for (int i = 0; i < arr2.Length; i++)
            {
                for (int j = 0; j < arr2.Length; j++)
                {
                    arr2[i][j] = j + (i * arr2.Length); //Probleme mit Fill gehabt. (i=i++;)
                }
            }
            return arr2;
        }

        public static void Aufgabe1Arr2DPrint(int[][] arr2D)
        {
            for (int i = 0; i < arr2D.Length; i++)
            {
                for (int j = 0; j < arr2D.Length; j++)
                {
                    Console.Write("{0,4}", arr2D[i][j]); // Formatierung nachgeschaut!!!
                }
                Console.WriteLine();
            }
        }

        public static bool Aufgabe1StringPalindrom(string W1)
        {
            W1 = W1.ToLower();
            for (int i = 0; i < W1.Length / 2; i++)
            {
                if (W1[i] != W1[W1.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
        public static void PrintPallindrom(string W, bool tf)
        {
            Console.WriteLine(W + " = " + tf);
        }

        //MEIN ANSATZ:

        //public static void Aufgabe1StringPalindrom(string W1)
        //{
        //    char[] CW1 = W1.ToCharArray();
        //    char[] ArrCW1 = new char[W1.Length];

        //    bool W1P = true;

        //    for (int i = 0; i < W1.Length; i++)
        //    {
        //        for (int j = W1.Length; j > 0; j--)
        //        {
        //            if (ArrCW1[i-1] != ArrCW1[j+1])
        //            {
        //                W1P = false;
        //                break;
        //            }
        //        }
        //    }
        //    Console.WriteLine(W1 + " " + W1P);
        //}


        //Nur mit viel Research geschafft!
        public static string Aufgabe2LongestW(string hesseText, string marieText)
        { 
            string text = hesseText + " " + marieText;

            text = text.Replace("@"+"["+","+"."+"!"+"?"+":"+";"+"("+")"+"'"+"/"+"+"+"]"+"" + "\n", "");

            string longestWord = "";
            string[] words = text.Split(" ");

            int maxLen = 0;

            foreach (string word in words)
            {
                if (word.Length > maxLen)
                {
                    maxLen = word.Length;
                    longestWord = word;
                }
            }
            return longestWord;
        }

        public static void PrintAufgabeLongestW(string longest)
        {
            Console.WriteLine("The longest Word is: " + longest);
        }
    }
}

