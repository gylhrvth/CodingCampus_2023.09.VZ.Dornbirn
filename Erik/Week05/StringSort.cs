using System;
using System.Collections;

namespace Erik.Week05
{
    public class StringSort
    {
        public static void StartStringSort()
        {
            string[] names = UnsortedNames();
            SortNamesAlgoAscending(names);
            Console.WriteLine("Names ascending:\n[{0}]", string.Join(", ", names));
            Console.WriteLine();
            SortNamesAlgoDescending(names);
            Console.WriteLine("Names decending:\n[{0}]", string.Join(", ", names));
            Console.WriteLine();
            SortNamesAlphabetAscending(names);
            Console.WriteLine("Names alphabetically ascending:\n[{0}]", string.Join(", ", names));
            Console.WriteLine();
            SortNamesAlphabetDecending(names);
            Console.WriteLine("Names alphabetically decending:\n[{0}]", string.Join(", ", names));
        }

        public static String[] UnsortedNames()
        {
            String[] names = new String[] { "Jovo", "Mehmet", "Sven", "Martin", "Selina", "Niklas", "Ali", "Fabienne", "Lukas", "Sandro", "Hassan", "Berna", "Gyula", "Dimitri", "Patrick", "Kerem", "Timo", "Gheorghe", "Mohammed", "Cemal", "Simon", "Fabian", "Dario", "Michael", "Erik", "David", "Riccardo", "Eren" };
            return names;
        }

        public static void SortNamesAlgoAscending(String[] names)
        {
            int n = names.Length;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    int length1 = names[j].Length;
                    int length2 = names[j + 1].Length;

                    if (length1 > length2)
                    {
                        String tmp = names[j];
                        names[j] = names[j + 1];
                        names[j + 1] = tmp;
                    }
                }
            }
        }

        public static void SortNamesAlgoDescending(String[] names)
        {
            int n = names.Length;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    int length1 = names[j].Length;
                    int length2 = names[j + 1].Length;

                    if (length1 < length2)
                    {
                        String tmp = names[j];
                        names[j] = names[j + 1];
                        names[j + 1] = tmp;
                    }
                }
            }
        }

        public static void SortNamesAlphabetAscending(String[] names)
        {
            int n = names.Length;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {

                    if (names[j].CompareTo(names[j + 1]) > 0)
                    {
                        String tmp = names[j];
                        names[j] = names[j + 1];
                        names[j + 1] = tmp;
                    }
                }
            }
        }

        public static void SortNamesAlphabetDecending(String[] names)
        {
            int n = names.Length;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (names[j].CompareTo(names[j + 1]) < 0)
                    {
                        String tmp = names[j];
                        names[j] = names[j + 1];
                        names[j + 1] = tmp;
                    }
                }
            }
        }
    }
}
