using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ressources;
using static System.Net.Mime.MediaTypeNames;


namespace Sven.Week05
{
    internal class StringUebungen
    {
        public static Random Random = new Random();
        public static void Start()
        {
            
            String[] names = new String[] { "Jovo", "Mehmet", "Sven", "Martin", "Selina",
                "Niklas", "Ali", "Fabienne", "Lukas", "Sandro", "Hassan", "Berna", "Gyula",
                "Dimitri", "Patrick", "Kerem", "Timo", "Gheorghe", "Mohammed", "Cemal",
                "Simon", "Fabian", "Dario", "Michael", "Erik", "David", "Riccardo", "Eren" };

            Console.WriteLine("Bubblesort String Ascending:");
            Console.WriteLine("{0}", string.Join(", ", AscendNames(names)));
            Console.WriteLine();

            Console.WriteLine("Bubblesort String Descending:");
            Console.WriteLine("{0}", string.Join(", ", DescendNames(names)));
            Console.WriteLine();

            Console.WriteLine("Bubblesort String Lexicographic Ascending:");
            Console.WriteLine("{0}", string.Join(", ", LexicoAscend(names)));
            Console.WriteLine();

            Console.WriteLine("Bubblesort String Lexicographic Ascending:");
            Console.WriteLine("{0}", string.Join(", ", LexicoDescend(names)));
            Console.WriteLine();

            Console.WriteLine("Bubblesort String Bool:");
            bool boolean = false;
            Console.WriteLine("{0}", string.Join(", ", SortNamesBool(names, boolean)));
            Console.WriteLine();

            Console.WriteLine("Bubblesort String Bool:");
            Console.WriteLine("{0}", string.Join(", ", SortIndex(names)));
            Console.WriteLine();

            Console.WriteLine("String Reverse:");
            ReverseString();
            Console.WriteLine();

            Console.WriteLine("String Randomize:");
            Console.WriteLine("Wilkommen zum Randomize Programm!");
            string text = Console.ReadLine();
            RandomizeString(text);
            Console.WriteLine();

            String s = StringRessources.getText();
            Console.WriteLine(s);

            int[] count = countLetters(s);
            PrintResult(count);

            Console.WriteLine();



        }
        public static string[] AscendNames(string[] arr)
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

        public static string[] DescendNames(string[] arr)
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
        public static string[] LexicoAscend(string[] arr)
        {

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (string.Compare(arr[j], arr[j + 1]) > 0)
                    {
                        string temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }

            }
            return arr;
        }
        public static string[] LexicoDescend(string[] arr)
        {

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (string.Compare(arr[j], arr[j + 1]) < 0)
                    {
                        string temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }

            }
            return arr;
        }
        public static string[] SortNamesBool(string[] arr, bool boolean)
        {
            string temp;

            if (boolean == true)
            {

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

            else if (boolean == false)
            {
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
        public static string[] SortIndex(string[] arr)
        {
            string temp;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j][2] > arr[j + 1][2])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            return arr;
        }

        public static void ReverseString()
        {

            
                Console.WriteLine("Wilkommen zum Reverse Programm!");
                string input = Console.ReadLine();
                char[] mychar = input.ToCharArray();
           


            Array.Reverse(mychar);

            Console.WriteLine(mychar);

        }

        public static void RandomizeString(string text)
        {            
            
            char[] arr = text.ToCharArray();

            for (int i = 0; i < arr.Length; i++)
            {
                int posA = Random.Next(arr.Length);
                int posB = Random.Next(arr.Length);
                char temp = arr[posA];
                arr[posA] = arr[posB];
                arr[posB] = temp;
            }
            Console.WriteLine(arr);

        }
        public static void PrintResult(int[] count)
        {
            for (int i = 0; i < count.Length; ++i)
            {
                if (count[i] > 0)
                {
                    char c = (char)i;
                    Console.WriteLine(c + " " + count[i]);
                }
            }
        }

        public static int[] countLetters(string text)
        {
            int[] count = new int[char.MaxValue];
            for (int i = 0; i < text.Length; i++)
            {
                char c = text[i];
                ++count[c];
            }

            return count;
        }
    }
}








