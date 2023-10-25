namespace DarioLuis.Week05
{
    internal class StringAufgaben
    {
        public static void StartStringAufgaben()
        {
            String[] names = new String[] { "Jovo", "Mehmet", "Sven", "Martin", "Selina", "Niklas", "Ali", "Fabienne", "Lukas", "Sandro", "Hassan", "Berna", "Gyula", "Dimitri", "Patrick", "Kerem", "Timo", "Gheorghe", "Mohammed", "Cemal", "Simon", "Fabian", "Dario", "Michael", "Erik", "David", "Riccardo", "Eren" };

            //BubbleSortAufsteigend(names);
            //PrintArray(names);

            //BubbleSortAbsteigend(names);
            //PrintArray(names);

            //BubbleSortNachBuchstabeAufsteigend(names);
            //PrintArray(names);

            //BubbleSortNachBuchstabeAbsteigend(names);
            //PrintArray(names);

            ReverseProgram();
        }
        public static void BubbleSortAufsteigend(string[] names)
        {
            for (int i = 0; i < names.Length; i++)
            {
                for (int j = 0; j < names.Length - 1; j++)
                {
                    if (names[j].Length > names[j + 1].Length)
                    {
                        string name = names[j];
                        names[j] = names[j + 1];
                        names[j + 1] = name;
                    }
                }
            }
        }
        public static void BubbleSortAbsteigend(string[] names)
        {
            for (int i = 0; i < names.Length; i++)
            {
                for (int j = 0; j < names.Length - 1; j++)
                {
                    if (names[j].Length < names[j + 1].Length)
                    {
                        string name = names[j];
                        names[j] = names[j + 1];
                        names[j + 1] = name;
                    }
                }
            }
        }
        public static void BubbleSortNachBuchstabeAufsteigend(string[] names)
        {

            for (int i = 0; i < names.Length; i++)
            {
                for (int j = 0; j < names.Length - 1; j++)
                {

                    if (names[j].CompareTo(names[j + 1]) > 0)
                    {
                        string name = names[j];
                        names[j] = names[j + 1];
                        names[j + 1] = name;
                    }

                }
            }
        }
        public static void BubbleSortNachBuchstabeAbsteigend(string[] names)
        {

            for (int i = 0; i < names.Length; i++)
            {
                for (int j = 0; j < names.Length - 1; j++)
                {

                    if (names[j].CompareTo(names[j + 1]) < 0)
                    {
                        string name = names[j];
                        names[j] = names[j + 1];
                        names[j + 1] = name;
                    }

                }
            }
        }

        public static void BubbleSortMitStringsExtended(string[] names)
        {
            bool befehl = false;

            if (befehl)
            {
                for (int i = 0; i < names.Length; i++)
                {
                    for (int j = 0; j < names.Length - 1; j++)
                    {
                        if (names[j].Length < names[j + 1].Length)
                        {
                            string name = names[j];
                            names[j] = names[j + 1];
                            names[j + 1] = name;
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
                            string name = names[j];
                            names[j] = names[j + 1];
                            names[j + 1] = name;
                        }
                    }
                }
            }
        }
        public static String[] PrintArray(String[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            return array;
        }

        public static void ReverseProgram()
        {
            bool again = true;

            while (again)
            {

                Console.WriteLine("Hallo und willkomen beim Reverseprogram!");
                Console.WriteLine("Was für ein Wort magst du verkehrtherum schreiben?");
                String input = Console.ReadLine();

                String Gespiegelt = "";
                String[] Zerlegt = input.Select(bs => bs.ToString()).ToArray();

                Char[] chararray = input.ToCharArray();

                //Array.Reverse(Zerlegt);

                for (int i = Zerlegt.Length - 1; i >= 0; i--)
                {
                    Gespiegelt += Zerlegt[i];
                }

                Console.WriteLine(Gespiegelt);

                //Abfrage ob man ein zweites mal scheirben möchte
                Console.WriteLine("Magst du nocheinmal schreiben?(Y/N)");
                String ans = Console.ReadLine();
                if (ans == "y")
                {

                }
                else if (ans == "Y")
                {

                }
                else if (ans == "n")
                {
                    Console.WriteLine("Danke es hat mich gefreut.");
                    again = false;
                }
                else if (ans == "N")
                {
                    Console.WriteLine("Danke es hat mich gefreut.");
                    again = false;
                }

            }

        }
    }
}