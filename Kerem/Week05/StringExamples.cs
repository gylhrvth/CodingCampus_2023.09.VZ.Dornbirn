using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static Kerem.Week04.ConsoleInput;


namespace Kerem.Week05
{
    internal class StringExamples
    {
        public static Random rand = new Random();
        public static void Start()
        {
            String[] names = new String[] { "Jovo", "Mehmet", "Sven", "Martin", "Selina", "Niklas", "Ali", "Fabienne", "Lukas", "Sandro", "Hassan", "Berna", "Gyula", "Dimitri", "Patrick", "Kerem", "Timo", "Gheorghe", "Mohammed", "Cemal", "Simon", "Fabian", "Dario", "Michael", "Erik", "David", "Riccardo", "Eren" };

            Console.WriteLine("Ascending");
            Console.WriteLine("[{0}]", string.Join(", ", SortNamesASC(names)));

            Console.WriteLine("\nDescending");
            Console.WriteLine("[{0}]", string.Join(", ", SortNamesDESC(names)));

            Console.WriteLine("\nBubbleSortExtended");
            int mynumber = ReadChoices("Wähle 1 für BubbleSortAscending  oder 2 für BubbleSortDescending");
            BubbleSortStringExtended(names, (mynumber == 1));
            BubbleSortStringExtended(names, true);


            Console.WriteLine("\nLexikographischASC");
            Console.WriteLine("[{0}]", string.Join(", ", SortNamesCompareASC(names)));

            Console.WriteLine("\nLexikogrpaphischDESC");
            Console.WriteLine("[{0}]", string.Join(", ", SortNamesCompareDESC(names)));

            Console.WriteLine("\nSortCharIndex");
            Console.WriteLine("[{0}]", string.Join(", ", SortNamesbyIndex(names, 1)));

            Console.WriteLine();
            Reverse();

            Console.WriteLine("Wilkommen zum Zufallshuffle Programm!");
            string text = Console.ReadLine();
            Console.WriteLine(RandomizeString(text));



        }
        public static string[] SortNamesASC(string[] arr)
        {


            string temp;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j].Length > arr[j + 1].Length)
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }

                }
            }
            return arr;



        }
        public static void BubbleSortStringExtended(string[] arr, bool asc)
        {
            if (asc)
            {
                SortNamesASC(arr);
            }
            else
            {
                SortNamesDESC(arr);
            }
        }
        public static string[] SortNamesDESC(string[] arr)
        {
            string temp;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j].Length < arr[j + 1].Length)
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }

                }
            }
            return arr;
        }
        public static string[] SortNamesCompareASC(string[] arr)
        {
            string temp;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (string.Compare(arr[j], arr[j + 1]) > 0)
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }

                }
            }
            return arr;
        }
        public static string[] SortNamesCompareDESC(string[] arr)
        {
            string temp;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (string.Compare(arr[j], arr[j + 1]) < 0)
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }

                }
            }
            return arr;
        }
        public static string[] SortNamesbyIndex(string[] arr, int index)
        {

            string temp;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j][index].CompareTo(arr[j + 1][index]) > 0)
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }

                }
            }
            return arr;

        }
        public static void Reverse()
        {
            Console.WriteLine("Willkommen zum Reverseprogramm");
            string inputText = Console.ReadLine();
            char[] myChar = inputText.ToCharArray();
            Array.Reverse(myChar);

            Console.WriteLine(myChar);

        }
        public static string RandomizeString(string text)
        {
            char[] arr = text.ToCharArray();
            
            for( int i = 0; i < arr.Length; i++ )
            {
                int posA = rand.Next(arr.Length);
                int posB = rand.Next(arr.Length);
                char temp = arr[posA];
                arr[posA] = arr[posB];
                arr[posB] = temp;
            }
            return new string(arr);
        }

    }
}
