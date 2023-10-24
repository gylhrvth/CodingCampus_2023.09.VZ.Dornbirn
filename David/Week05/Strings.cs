using System;
namespace David.Week05
{
    public class Strings
    {
        public static void StartDay01()
        {
            StringArrayBubbleASC();
            Console.WriteLine("---------");
            StringArrayBubbleDES();
        }

        public static void StringArrayBubbleASC()
        {

            string[] names = new string[] { "Jovo", "Mehmet", "Sven", "Martin", "Selina", "Niklas", "Ali", "Fabienne",
                   "Lukas", "Sandro", "Hassan", "Berna", "Gyula", "Dimitri", "Patrick", "Kerem", "Timo", "Gheorghe", "Mohammed",
                   "Cemal", "Simon", "Fabian", "Dario", "Michael", "Erik", "David", "Riccardo", "Eren" };

            for (int i = 0; i < names.Length; i++)
            {
                for (int j = 0; j < names.Length -1; j++)
                {
                    if (names[j].Length > names[j + 1].Length)
                    {
                        string temp = names[j];
                        names[j] = names[j + 1];
                        names[j + 1] = temp;
                    }
                }

            }

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            

        }
        public static void StringArrayBubbleDES()
        {

            string[] names = new string[] { "Jovo", "Mehmet", "Sven", "Martin", "Selina", "Niklas", "Ali", "Fabienne",
                   "Lukas", "Sandro", "Hassan", "Berna", "Gyula", "Dimitri", "Patrick", "Kerem", "Timo", "Gheorghe", "Mohammed",
                   "Cemal", "Simon", "Fabian", "Dario", "Michael", "Erik", "David", "Riccardo", "Eren" };

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

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }


        }

    }
}

