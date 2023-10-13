using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Michael.Week02
{
    internal class StringExercises
    {

        public static Random rnd = new Random();


        public static String[] names = new String[] {"baa","bac", "Joachim", "Mert", "Eric", "Marie Christine", "Benjamin", "Sandro", "Aygün", "Hassan", "Svitlana", "Lukas", "Gyula" };


        public static void Start()
        {

            EmailMatching("asdf@microsoft.c");

        }


        public static char[] makeACopyAltChar(char[] original)
        {
            char[] myArray = new char[original.Length];

            for (int i = 0; i < original.Length; i++)
            {
                myArray[i] = original[i];
            }
            return myArray;
        }


        public static void printCharArray(char[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
            }
            Console.WriteLine();
        }


        public static string[] sortNames(string[] toSort, bool lexi = false, bool descending = false) 
        {
            if (lexi)
            {
                if (descending)
                {
                    return sortLexiDescending(toSort);
                }
                else
                {
                    return sortLexiAscending(toSort);
                }
            }
            else
            {
                if (descending)
                {
                    return sortLengthDescending(toSort);
                }
                else
                {
                    return sortLengthAscending(toSort);
                }
            }
        }


        public static string[] sortLengthAscending(string[] toSort)
        {
            string[] sortedArray = new string[toSort.Length];

            sortedArray = toSort;
            bool hadToSwap = true;
            string first = " ";

            while (hadToSwap)
            {
                hadToSwap = false;

                for (int i = 0; i < toSort.Length - 1; i++)
                {
                    if (sortedArray[i].Length > sortedArray[i + 1].Length)
                    {
                        first = sortedArray[i];
                        sortedArray[i] = sortedArray[i + 1];
                        sortedArray[i + 1] = first;
                        hadToSwap = true;
                    }
                }
            }
            return sortedArray;
        }


        public static string[] sortLengthDescending(string[] toSort)
        {
            string[] sortedArray = new string[toSort.Length];

            sortedArray = toSort;
            bool hadToSwap = true;
            string first = " ";

            while (hadToSwap)
            {
                hadToSwap = false;

                for (int i = 0; i < toSort.Length - 1; i++)
                {
                    if (sortedArray[i].Length < sortedArray[i + 1].Length)
                    {
                        first = sortedArray[i];
                        sortedArray[i] = sortedArray[i + 1];
                        sortedArray[i + 1] = first;
                        hadToSwap = true;
                    }
                }
            }
            return sortedArray;
        }


        public static string[] sortLexiAscending(string[] toSort, int index = 0)
        {
            string[] sortedArray = new string[toSort.Length];

            sortedArray = toSort;
            bool hadToSwap = true;
            string first = " ";

            while (hadToSwap)
            {
                hadToSwap = false;

                for (int i = 0; i < toSort.Length - 1; i++)
                {
                    if (i > index)
                    {
                        Console.WriteLine("not all names are long enough for this index, sorry");
                        return sortedArray;
                    }
                    try
                    {
                        if (sortedArray[i][index].CompareTo(sortedArray[i + 1][index]) > 0)
                        {
                            first = sortedArray[i];
                            sortedArray[i] = sortedArray[i + 1];
                            sortedArray[i + 1] = first;
                            hadToSwap = true;
                        }
                    }
                    catch 
                    {
                        Console.WriteLine("not all names are long enough for this index, sorry. we won't continue sorting.");
                        return sortedArray;
                    }

                }
            }
            return sortedArray;
        }


        public static string[] sortLexiDescending(string[] toSort)
        {
            string[] sortedArray = new string[toSort.Length];

            sortedArray = toSort;
            bool hadToSwap = true;
            string first = " ";

            while (hadToSwap)
            {
                hadToSwap = false;

                for (int i = 0; i < toSort.Length - 1; i++)
                {
                    if (sortedArray[i].CompareTo(sortedArray[i + 1]) < 0)
                    {
                        first = sortedArray[i];
                        sortedArray[i] = sortedArray[i + 1];
                        sortedArray[i + 1] = first;
                        hadToSwap = true;
                    }
                }
            }
            return sortedArray;
        }


        public static void switchChar(char[] array, int index1, int index2)
        {
            char temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;
        }

        
        public static void reverseUserString()
        {
            string userInput = "";

            while (true)
            {
                Console.WriteLine("what string do you want reversed?");
                try
                {
                    userInput = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(userInput))
                    {
                        Console.WriteLine("please actually enter something");
                    }
                    else
                    {
                        Console.WriteLine("ty for your input");
                        break;
                    }
                }
                catch
                {
                    Console.WriteLine("weird input, let's try again");
                }
            }

            char[] userInputArray = userInput.ToArray();
            char[] userInputArrayTemp = makeACopyAltChar(userInputArray);

            for (int i = 0; i < userInputArray.Length; i++)
            {
                userInputArray[i] = userInputArrayTemp[userInputArray.Length - i - 1];
            }

            printCharArray(userInputArray);

        }


        public static void randomizeUserString()
        {
            string userInput = "";

            while (true)
            {
                Console.WriteLine("what string do you want shuffled?");
                try
                {
                    userInput = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(userInput))
                    {
                        Console.WriteLine("please actually enter something");
                    }
                    else
                    {
                        Console.WriteLine("ty for your input");
                        break;
                    }
                }
                catch
                {
                    Console.WriteLine("weird input, let's try again");
                }
            }

            char[] userInputArray = userInput.ToArray();

            for (int i = 0; i < userInputArray.Length; i++)
            {
                switchChar(userInputArray, i, rnd.Next(i, userInputArray.Length));
            }

            printCharArray(userInputArray);

        }


        public static void CountLetters()
        {
            int[] lettersAmount = new int[400];
            Console.WriteLine("enter a string");
            char[] stringArray = Console.ReadLine().ToArray();


            for (int i = 0; i < lettersAmount.Length; i++)
            {
                lettersAmount[i] = 0;
            }


            foreach (char c in stringArray)
            {
                lettersAmount[c]++;
            }


            for (int i = 0; i < lettersAmount.Length; i++)
            {
                if (lettersAmount[i] != 0)
                {
                    Console.WriteLine((char)i + ":  " + lettersAmount[i]);
                }

            }
        }


        public static void DataTable()
        {
            String[] firstName = { "Alfonso", "Beatrix-Eleonor", "Cecil", "Daniel", "Elmar" };
            String[] lastName = { "Klein", "Kinderdorfer", "Al Elmenar", "Schmidt", "Simma" };
            int[] age = { 40, 78, 5, 18, 81 };
            String[] place = { "Wien", "Schwarzach", "Wiener Neudorf", "Sankt Pölten", "Sankt Pölten" };
            float[] distanceFromCapital = { 0f, 654.4f, 12.457634366f, 120.0f, 119.9999f };
        }


        public static void EmailMatching(string email)
        {
            string regex = @"^[\w\.-]+@[\w\.-]+\.\w+$";

            System.Text.RegularExpressions.Match m = System.Text.RegularExpressions.Regex.Match(email, regex);

            Console.WriteLine(m.Success);
        }
    }
}
