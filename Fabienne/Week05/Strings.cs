using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabienne.Week05
{
    internal class Strings
    {
        public static void Start() 
        { 
            String[] names = new String[]
            {
                "Jovo", "Mehmet", "Sven", "Martin", "Selina", "Niklas", "Ali", "Fabienne", "Lukas", "Sandro", "Hassan", "Berna", "Gyula","Dimitri", "Patrick", 
                "Kerem", "Timo", "Gheorghe", "Mohammed", "Cemal", "Simon", "Fabian", "Dario", "Michael", "Erik", "David", "Riccardo", "Eren" 
            };

            bool abc = false;


            //Console.WriteLine("[{0}]", string.Join(", ",names));
            //Console.WriteLine("===============================================================================================================================");
            //Console.WriteLine("[{0}]", string.Join(", ", BubblesortAmountOfNumbersAscending(names))););

            //Console.WriteLine("[{0}]", string.Join(", ", names));
            //Console.WriteLine("===============================================================================================================================");
            //Console.WriteLine("[{0}]", string.Join(", ", BubblesortAmountOfNumbersDescending(names)));

            //Console.WriteLine("[{0}]", string.Join(", ", names));
            //Console.WriteLine("===============================================================================================================================");
            //Console.WriteLine("[{0}]", string.Join(", ", BubblesortAlphabeticalAscending(names)));

            //Console.WriteLine("[{0}]", string.Join(", ", names));
            //Console.WriteLine("===============================================================================================================================");
            //Console.WriteLine("[{0}]", string.Join(", ", BubblesortAlphabeticalDescending(names)));

            //Console.WriteLine("[{0}]", string.Join(", ", names));
            //Console.WriteLine("===============================================================================================================================");
            //Console.WriteLine("[{0}]", string.Join(", ", BubbleSortAlgorythmAmountOfNUmbers(names, abc)));

            //Console.WriteLine("[{0}]", string.Join(", ", names));
            //Console.WriteLine("===============================================================================================================================");
            //Console.WriteLine("[{0}]", string.Join(", ", BubblesortAlgorythmAlphabetical(names, abc)));

            //Console.WriteLine("[{0}]", string.Join(", ", names));
            //Console.WriteLine("===============================================================================================================================");
            //Console.WriteLine("[{0}]", string.Join(", ", BubblesortStringCharacterIndex(names, 2)));

            Console.WriteLine(Reverse());
            
        }
        public static String[] MakeACopy(String[] arr) 
        {
            String[] copy = new String[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                copy[i] = arr[i];
            }

            return copy;
        }
        public static String[] BubblesortAmountOfNumbersAscending(String[] arr) 
        {
            String[] sorted = MakeACopy(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (sorted[j].Length > sorted[j + 1].Length)
                    {
                        String temp = sorted[j];
                        sorted[j] = sorted[j + 1];
                        sorted[j + 1] = temp;
                    }
                }
            }

            return sorted;
        }
        public static String[] BubblesortAmountOfNumbersDescending(String[] arr)
        {
            String[] sorted = MakeACopy(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (sorted[j].Length < sorted[j + 1].Length)
                    {
                        String temp = sorted[j];
                        sorted[j] = sorted[j + 1];
                        sorted[j + 1] = temp;
                    }
                }
            }

            return sorted;
        }
        public static String[] BubblesortAlphabeticalAscending(String[] arr)
        {
            String[] sorted = MakeACopy(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (sorted[j].CompareTo(sorted[j + 1]) > 0)
                    {
                        String temp = sorted[j];
                        sorted[j] = sorted[j + 1];
                        sorted[j + 1] = temp;
                    }
                }
            }

            return sorted;
        }
        public static String[] BubblesortAlphabeticalDescending(String[] arr)
        {
            String[] sorted = MakeACopy(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (sorted[j].CompareTo(sorted[j + 1]) < 0)
                    {
                        String temp = sorted[j];
                        sorted[j] = sorted[j + 1];
                        sorted[j + 1] = temp;
                    }
                }
            }

            return sorted;
        }
        public static String[] BubbleSortAlgorythmAmountOfNUmbers(String[] arr, bool abc)
        {
            String[] sorted = MakeACopy(arr);
            
            if (abc)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = 0; j < arr.Length - i - 1; j++)
                    {
                        if (sorted[j].Length > sorted[j + 1].Length)
                        {
                            String temp = sorted[j];
                            sorted[j] = sorted[j + 1];
                            sorted[j + 1] = temp;
                        }
                    }
                }
            }

            else
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = 0; j < arr.Length - i - 1; j++)
                    {
                        if (sorted[j].Length < sorted[j + 1].Length)
                        {
                            String temp = sorted[j];
                            sorted[j] = sorted[j + 1];
                            sorted[j + 1] = temp;
                        }
                    }
                }
            }

            return sorted;
        }
        public static String[] BubblesortAlgorythmAlphabetical(String[] arr, bool abc)
        {
            String[] sorted = MakeACopy(arr);

            if (abc)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = 0; j < arr.Length - i - 1; j++)
                    {
                        if (sorted[j].CompareTo(sorted[j + 1]) > 0)
                        {
                            String temp = sorted[j];
                            sorted[j] = sorted[j + 1];
                            sorted[j + 1] = temp;
                        }
                    }
                }
            }

            else
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = 0; j < arr.Length - i - 1; j++)
                    {
                        if (sorted[j].CompareTo(sorted[j + 1]) < 0)
                        {
                            String temp = sorted[j];
                            sorted[j] = sorted[j + 1];
                            sorted[j + 1] = temp;
                        }
                    }
                }
            }

            return sorted;
        }
        public static String[] BubblesortStringCharacterIndex(String[] arr, int index)
        {
            String[] sorted = MakeACopy(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (sorted[j][index].CompareTo(sorted[j + 1][index]) > 0)
                    {
                        String temp = sorted[j];
                        sorted[j] = sorted[j + 1];
                        sorted[j + 1] = temp;
                    }
                }
            }

            return sorted;
        }
        public static string Reverse()
        {
            Console.WriteLine("Welcome in the reverseprogram!");
            Console.WriteLine("Please type in a word: ");

            string word = Console.ReadLine();
            char[] chars = word.ToCharArray();
            char[] arr = new char[chars.Length];

            for (int i = 0; i < word.Length; i++)
            {
                arr[i] = chars[word.Length - i - 1];
            }
            string abc = new string(arr);

            return abc;
        }
        public static string Random()
        {
            Random rand = new Random();

            Console.WriteLine("Welcome to the radnomizer!");
            Console.WriteLine("Please type in a word: ");

            string word = Console.ReadLine();
            char[] chars = word.ToCharArray();
            char[] arr = new char[chars.Length];

            for (int i = 0; i < word.Length; i++)
            {
                arr[i] = chars[word.Length - i - 1];
            }
            string abc = new string(arr);

            return abc;
        }     
    }
}
