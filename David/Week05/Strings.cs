using System;
namespace David.Week05
{
    public class Strings
    {
        public static void StartDay01()
        {
            string[] names = new string[] { "Jovo", "Mehmet", "Sven", "Martin", "Selina", "Niklas", "Ali", "Fabienne",
                   "Lukas", "Sandro", "Hassan", "Berna", "Gyula", "Dimitri", "Patrick", "Kerem", "Timo", "Gheorghe", "Mohammed",
                   "Cemal", "Simon", "Fabian", "Dario", "Michael", "Erik", "David", "Riccardo", "Eren" };

            Console.WriteLine("-----by Gyula-----");
            StringArrayBubbleASCByGyula(names, true);
            Console.WriteLine(string.Join(", ", names));

            Console.WriteLine("---------");
            StringArrayBubbleASCByGyula(names, false);
            Console.WriteLine(string.Join(", ", names));

            Console.WriteLine();
            Console.WriteLine("---------by David-----");
            Console.WriteLine("-----ASC/Des, length-----");
            StringArrayBubbleDES(names, true);
            Console.WriteLine(string.Join(", ", names));

            Console.WriteLine();
            Console.WriteLine("----ASC/Des, lexikographisch-----");
            StringArrayBubbleASC(names, false);
            Console.WriteLine(string.Join(", ", names));

            Console.WriteLine();
            Console.WriteLine("----ASC/Des, 3. letter in name-----");
            StringArrayBubbleAT2(names, 1, true);
            Console.WriteLine(string.Join(", ", names));

            Console.WriteLine();
            Reverse();
        }

        public static void StringArrayBubbleASC(string[] names, bool asc)
        {
            if (asc)
            {
                for (int i = 0; i < names.Length; i++)
                {
                    for (int j = 0; j < names.Length - 1; j++)
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
            else
            {
                for (int i = 0; i < names.Length; i++)
                {
                    for (int j = 0; j < names.Length - 1; j++)
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
        }

        public static void StringArrayBubbleASCByGyula(string[] names, bool asc)
        {
            for (int i = 0; i < names.Length; i++)
            {
                for (int j = 0; j < names.Length - 1; j++)
                {
                    if (asc == (names[j].CompareTo(names[j + 1]) > 0))
                    {
                        string temp = names[j];
                        names[j] = names[j + 1];
                        names[j + 1] = temp;
                    }
                }
            }
        }

        public static void StringArrayBubbleDES(string[] names, bool asc)
        {
            if (asc)
            {
                for (int i = 0; i < names.Length; i++)
                {
                    for (int j = 0; j < names.Length - 1; j++)
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
            else
            {
                for (int i = 0; i < names.Length; i++)
                {
                    for (int j = 0; j < names.Length - 1; j++)
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
        public static void StringArrayBubbleAT2(string[] names, int pos, bool asc)
        {
            for (int i = 0; i < names.Length; i++)
            {
                for (int j = 0; j < names.Length - 1; j++)
                {
                    if (asc == (names[j][pos].CompareTo(names[j + 1][pos]) > 0))
                    // if (asc == (names[j][pos] > (names[j + 1][pos])))
                    {
                        string temp = names[j];
                        names[j] = names[j + 1];
                        names[j + 1] = temp;
                    }
                }
            }
        }




        public static void Reverse()
        {
            Console.WriteLine("Gib ein Wort ein");
            string input = Console.ReadLine();

            char[] FirstInput = input.ToCharArray();
            char[] reverse = new char[FirstInput.Length];

            for (int i = 0; i < FirstInput.Length; i++)
            {
                reverse[FirstInput.Length - 1 - i] = FirstInput[i];
            }
            string word = new string(reverse);

            Console.WriteLine(word);


        }

    }
}

