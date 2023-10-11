using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Michael.Week02
{
    internal class StringExercises
    {

        public static String[] names = new String[] {"baa","bac", "Joachim", "Mert", "Eric", "Marie Christine", "Benjamin", "Sandro", "Aygün", "Hassan", "Svitlana", "Lukas", "Gyula" };

        public static void Start()
        {

            Console.WriteLine("unordered:\n{0}\n", string.Join(", ", names));
            Console.WriteLine("length ascending:\n{0}\n", string.Join(", ", sortNames(names, false, false)));
            Console.WriteLine("length descending:\n{0}\n", string.Join(", ", sortNames(names, false, true)));
            Console.WriteLine("lexi ascending:\n{0}\n", string.Join(", ", sortNames(names, true, false)));
            Console.WriteLine("lexi descending:\n{0}\n", string.Join(", ", sortNames(names, true, true)));

            Console.WriteLine();

            Console.WriteLine(string.Join(", ", sortLexiAscending(names, 10)));

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


        /*
        public static void reverseUserString()
        {
            string userInput = "";

            while (true)
            {
                Console.WriteLine("what string do you want reversed?");
                try
                {
                    string userInput = Console.ReadLine();

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

            int[] userInputArray = userInput.ToArray();
        }
        */ 

    }
}
