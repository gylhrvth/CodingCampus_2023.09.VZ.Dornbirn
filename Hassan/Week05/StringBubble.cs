using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ressources;


namespace Hassan.Week05
{
    public class StringBubble
    {
        public static void Start()
        {
            Console.WriteLine(StringRessources.getText());

            string[] names = new string[]
                
            {"Jovo", "Mehmet", "Sven", "Martin", "Selina", "Niklas", "Ali", "Fabienne", "Lukas", "Sandro", "Hassan", "Berna", "Gyula", "Dimitri", "Patrick", "Kerem", "Timo", "Gheorghe", "Mohammed", "Cemal", "Simon", "Fabian", "Dario", "Michael", "Erik", "David", "Riccardo", "Eren" };
            
            // Sortiere die Namen nach Länge aufsteigend (Ascending)
            BubbleSort(names);
            Console.WriteLine("Sortiert nach Länge aufsteigend:");
            PrintArray(names);

            // Sortiere die Namen nach Länge absteigend (Descending)
            BubbleSortDescending(names);
            Console.WriteLine("\nSortiert nach Länge absteigend:");
            PrintArray(names);

            // Sortiere die Namen lexikographisch aufsteigend (Ascending)
            BubbleSortLexiAscending(names);
            Console.WriteLine("\nSortiert lexikographisch aufsteigend:");
            PrintArray(names);

            // Sortiere die Namen lexikographisch absteigend (Descending)
            BubbleSortLexiDescending(names);
            Console.WriteLine("\nSortiert lexikographisch absteigend:");
            PrintArray(names);

        }



        static void BubbleSort(string[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j].Length > arr[j + 1].Length)
                    {
                        string temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        static void BubbleSortDescending(string[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j].Length < arr[j + 1].Length)
                    {
                        string temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        static void BubbleSortLexiAscending(string[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (string.Compare(arr[j], arr[j + 1]) > 0)
                    {
                        string temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        static void BubbleSortLexiDescending(string[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (string.Compare(arr[j], arr[j + 1], CultureInfo.CurrentCulture, CompareOptions.IgnoreNonSpace) < 0)

                    {
                        string temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        static void PrintArray(string[] arr)
        {
            foreach (string s in arr)
            {
                Console.WriteLine(s);
            }
        }





        static void BubbleSort(string[] arr, CultureInfo culture, bool ascending)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    int comparisonResult = string.Compare(arr[j], arr[j + 1], culture, CompareOptions.IgnoreNonSpace);

                    if ((ascending && comparisonResult > 0) || (!ascending && comparisonResult < 0))
                    {
                        string temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }





    }
}
