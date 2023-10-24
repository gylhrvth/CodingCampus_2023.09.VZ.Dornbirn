namespace Selina.Week05
{
    internal class Bubblesort_mit_Strings
    {
        public static void Start()
        {

            String[] names = new String[] { "Jovo", "Mehmet", "Sven", "Martin", "Selina", "Niklas", "Ali", "Fabienne", "Lukas", "Sandro", "Hassan", "Berna", "Gyula", "Dimitri", "Patrick", "Kerem", "Timo",
                "Gheorghe", "Mohammed", "Cemal", "Simon", "Fabian", "Dario", "Michael", "Erik", "David", "Riccardo", "Eren" };

            int index = 4;

            //Aufagbe 1:

            AscendingLength(names);     //Sotiert die Länge der Namen aufsteigend
            Output("\nSortiert nach Länge aufsteigend:\n", ConsoleColor.Cyan);
            PrintArray(names);          //gibt Ergebnis aus
            Console.Write("\n-------------------------------------");

            DescendingLength(names);    //Sotiert die Länge der Namen absteigend
            Output("\nSortiert nach Länge absteigend:\n", ConsoleColor.Magenta);
            PrintArray(names);          //gibt Ergebnis aus
            Console.Write("\n-------------------------------------");

            AscendingName(names);       //Sotiert lexikographisch aufsteigend
            Output("\nSortiert lexikographisch aufsteigend:\n", ConsoleColor.DarkCyan);
            PrintArray(names);          //gib Ergebnis aus
            Console.Write("\n-------------------------------------");

            AscendingName(names);       //Sortiert lexikographisch absteigend
            Output("\nSortiert lexikographisch absteigend:\n", ConsoleColor.DarkMagenta);
            PrintArray(names);          // gibt Ergebnis aus
            Console.Write("\n-------------------------------------");

            //Aufagbe 2:

            BubblesortMitStringsExtended(names, true);      //Sortiert wenn true/ wenn false...
            Output("\nBubblesort mit Strings Extended\n", ConsoleColor.DarkMagenta);
            PrintArray(names);                              // gibt Ergebnis aus
            Console.Write("\n-------------------------------------");


            //Aufagbe 3:

            BubblesortMitStringsUndCharacterIndex(names, index);    //Sortiert nach Index
            Output("\nBubblesort mit Strings und Character Index\n", ConsoleColor.Blue);
            PrintArray(names);                                      // gibt Ergebnis aus
            Console.Write("\n-------------------------------------");

        }

        public static void AscendingLength(String[] names)
        {
            for (int i = 0; i < names.Length - 1; i++)
            {
                for (int j = 0; j < names.Length - i - 1; j++)
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
        public static void DescendingLength(String[] names)
        {
            for (int i = 0; i < names.Length - 1; i++)
            {
                for (int j = 0; j < names.Length - i - 1; j++)
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
        public static void DescendingName(String[] names)
        {
            for (int i = 0; i < names.Length - 1; i++)
            {
                for (int j = 0; j < names.Length - i - 1; j++)
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
        public static void AscendingName(String[] names)
        {
            for (int i = 0; i < names.Length - 1; i++)
            {
                for (int j = 0; j < names.Length - i - 1; j++)
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
        public static void BubblesortMitStringsExtended(String[] names, bool ascOrDesc)
        {
            if (ascOrDesc)
            {
                for (int i = 0; i < names.Length - 1; i++)
                {
                    for (int j = 0; j < names.Length - i - 1; j++)
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
            else if (!ascOrDesc)
            {
                for (int i = 0; i < names.Length - 1; i++)
                {
                    for (int j = 0; j < names.Length - i - 1; j++)
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

        public static void BubblesortMitStringsExtendedByGyula(String[] names, bool ascending)
        {
            for (int i = 0; i < names.Length - 1; i++)
            {
                for (int j = 0; j < names.Length - i - 1; j++)
                {
                    if (ascending == (names[j].Length > names[j + 1].Length))
                    {
                        string temp = names[j];
                        names[j] = names[j + 1];
                        names[j + 1] = temp;
                    }
                }
            }
        }

        public static void BubblesortMitStringsUndCharacterIndex(String[] names, int index)
        {
            for (int i = 0; i < names.Length - 1; i++)
            {
                for (int j = 0; j < names.Length - 1 - i; j++)
                {
                    if (names[j + 1].Length <= index || (names[j].Length > index && names[j][index] > names[j + 1][index]))
                    {
                        string temp = names[j];
                        names[j] = names[j + 1];
                        names[j + 1] = temp;
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
        }
        public static void Output(string output, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine($"\n\nAufgabe: {output}");
            Console.ResetColor();
        }

    }
}
