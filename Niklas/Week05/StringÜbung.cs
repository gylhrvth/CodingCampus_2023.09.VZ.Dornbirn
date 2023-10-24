using System.Data.SqlTypes;

namespace Niklas.Week05
{
    internal class StringÜbung
    {
        public static void Start()
        {
            String[] names = new String[] { "Jovo", "Mehmet", "Sven", "Martin", "Selina", "Niklas", "Ali", "Fabienne", "Lukas", "Sandro", "Hassan", "Berna", "Gyula", "Dimitri", "Patrick", "Kerem", "Timo", "Gheorghe", "Mohammed", "Cemal", "Simon", "Fabian", "Dario", "Michael", "Erik", "David", "Riccardo", "Eren" };
            BubblesortAsc(names);
            PrintArray(names);
            BubblesortDesc(names);
            PrintArray(names);
            BubblesortAlphabetAsc(names);
            PrintArray(names);
            BubblesortAlphabetDesc(names);
            PrintArray(names);
            BubblesortBoolean(names, false);
            PrintArray(names);
        }
        public static void BubblesortAsc(String[] names)
        {
            int i = 0;

            for (i = 0; i < names.Length - 1; i++)
            {
                for (int j = 0; j < names.Length - 1 - i; j++)
                {
                    if (names[j].Length > names[j + 1].Length)
                    {
                        string temp = names[j];
                        names[j] = names[j + 1];
                        names[j + 1] = temp;
                    }
                }
            }
        }
        public static void BubblesortDesc(String[] names)
        {
            int i = 0;

            for (i = 0; i < names.Length - 1; i++)
            {
                for (int j = 0; j < names.Length - 1 - i; j++)
                {
                    if (names[j].Length < names[j + 1].Length)
                    {
                        string temp = names[j];
                        names[j] = names[j + 1];
                        names[j + 1] = temp;
                    }
                }
            }
        }
        public static void BubblesortAlphabetAsc(String[] names)
        {
            int i = 0;

            for (i = 0; i < names.Length - 1; i++)
            {
                for (int j = 0; j < names.Length - 1 - i; j++)
                {
                    if (names[j].CompareTo(names[j + 1]) > 0)
                    {
                        string temp = names[j];
                        names[j] = names[j + 1];
                        names[j + 1] = temp;
                    }
                }
            }
        }
        public static void BubblesortAlphabetDesc(String[] names)
        {
            int i = 0;

            for (i = 0; i < names.Length - 1; i++)
            {
                for (int j = 0; j < names.Length - 1 - i; j++)
                {
                    if (names[j].CompareTo(names[j + 1]) < 0)
                    {
                        string temp = names[j];
                        names[j] = names[j + 1];
                        names[j + 1] = temp;
                    }
                }
            }
        }
        public static void BubblesortBoolean(String[] names, bool cases)
        {
            int i = 0;

            if (cases == true)
            {
                for (i = 0; i < names.Length - 1; i++)
                {
                    for (int j = 0; j < names.Length - 1 - i; j++)
                    {
                        if (names[j].Length > names[j + 1].Length)
                        {
                            string temp = names[j];
                            names[j] = names[j + 1];
                            names[j + 1] = temp;
                        }
                    }
                }
            }
            else if (cases == false)
            {
                for (i = 0; i < names.Length - 1; i++)
                {
                    for (int j = 0; j < names.Length - 1 - i; j++)
                    {
                        if (names[j].Length < names[j + 1].Length)
                        {
                            string temp = names[j];
                            names[j] = names[j + 1];
                            names[j + 1] = temp;
                        }
                    }
                }
            }
        }
        public static void PrintArray(String[] names)
        {
            foreach (string item in names)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
    }
}