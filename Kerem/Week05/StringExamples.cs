using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Kerem.Week05
{
    internal class StringExamples
    {
        public static void Start()
        {
            String[] names = new String[] { "Jovo", "Mehmet", "Sven", "Martin", "Selina", "Niklas", "Ali", "Fabienne", "Lukas", "Sandro", "Hassan", "Berna", "Gyula", "Dimitri", "Patrick", "Kerem", "Timo", "Gheorghe", "Mohammed", "Cemal", "Simon", "Fabian", "Dario", "Michael", "Erik", "David", "Riccardo", "Eren" };

            Console.WriteLine("Ascending");
            Console.WriteLine("[{0}]", string.Join(", ", SortNamesASC(names, false)));

            Console.WriteLine("\nDescending");
            Console.WriteLine("[{0}]", string.Join(", ", SortNamesDESC(names)));

            Console.WriteLine("\nLexikographischASC");
            Console.WriteLine("[{0}]", string.Join(", ", SortNamesCompareASC(names)));

            Console.WriteLine("\nLexikogrpaphischDESC");
            Console.WriteLine("[{0}]", string.Join(", ", SortNamesCompareDESC(names)));

            Console.WriteLine("\nSortCharIndex");
            Console.WriteLine("[{0}]", string.Join(", ", SortNamesbyIndex(names, 1)));

            Console.WriteLine();
            Reverse();

           

        }
        public static string[] SortNamesASC(string[] arr, bool asc)
        {
            if (asc == true)
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

            }
            else if (asc == false)
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

            }
            return arr;


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
                    if (arr[j][index].CompareTo (arr[j + 1][index]) > 0)
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
        /*public static void Randomize()
        {
            Random rnd = new Random();
            Console.WriteLine("Wilkommen zum Zufallshuffle Programm!");
            string inputText = Console.ReadLine();
            char[] myChar = inputText.ToCharArray();
            char[] myChar2 = new String(CharArray);
            Array.Reverse(myChar);

            Console.WriteLine(myChar);
        }*/




       
        }
}
