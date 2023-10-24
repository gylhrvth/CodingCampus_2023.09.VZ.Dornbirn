using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cemal.Week05
{
    internal class String_Aufgaben
    {

        public static void Start()
        {
            String[] names = new String[] { "Jovo", "Mehmet", "Sven", "Martin", "Selina", "Niklas", "Ali", "Fabienne", "Lukas", "Sandro", "Hassan", "Berna", "Gyula", "Dimitri", "Patrick", "Kerem", "Timo", "Gheorghe", "Mohammed", "Cemal", "Simon", "Fabian", "Dario", "Michael", "Erik", "David", "Riccardo", "Eren" };

            Console.WriteLine("Bubblesort aufsteigend");
            Console.WriteLine();
            Bubblesortaufsteigend(names);
            Console.WriteLine(string.Join(", ", names));
            Console.WriteLine();

            Console.WriteLine("Bubblesort absteigend");
            Console.WriteLine();
            Bubblesortabsteigend(names);
            Console.WriteLine(string.Join(", ", names));
            Console.WriteLine();

            Console.WriteLine("Bubblesort alphabetisch aufsteigend");
            Console.WriteLine();
            BubblesortALPHAaufsteigend(names);
            Console.WriteLine(string.Join(", ", names));
            Console.WriteLine();

            Console.WriteLine("Bubblesort alphabetisch absteigend");
            Console.WriteLine();
            BubblesortALPHAabsteigend(names);
            Console.WriteLine(string.Join(", ", names));
            Console.WriteLine();




        }

        public static void Bubblesortaufsteigend(string[] names)
        {           
            for (int i = 0; i < names.Length; i++)
            {
                for (int j = 0; j < names.Length - 1 - i; j++)
                {
                    if (names[j].Length > names[j + 1].Length)
                    {
                        string temp = names[j + 1];
                        names[j + 1] = names[j];
                        names[j] = temp;
                    }
                }
            }
        }

        public static void Bubblesortabsteigend(string[] names)
        {
            for (int i = 0; i < names.Length; i++)
            {
                for (int j = 0; j < names.Length - 1 - i; j++)
                {
                    if (names[j].Length < names[j + 1].Length)
                    {
                        string temp = names[j + 1];
                        names[j + 1] = names[j];
                        names[j] = temp;
                    }
                }
            }
        }

        public static void BubblesortALPHAaufsteigend(string[] names)
        {
            for (int i = 0; i < names.Length; i++)
            {
                for (int j = 0; j < names.Length - 1 - i; j++)
                {
                    if (names[j].CompareTo(names[j + 1]) < 0)
                    {
                        string temp = names[j + 1];
                        names[j + 1] = names[j];
                        names[j] = temp;
                    }
                }
            }
        }

        public static void BubblesortALPHAabsteigend(string[] names)
        {
            for (int i = 0; i < names.Length; i++)
            {
                for (int j = 0; j < names.Length - 1 - i; j++)
                {
                    if (names[j].CompareTo(names[j + 1]) > 0)
                    {
                        string temp = names[j + 1];
                        names[j + 1] = names[j];
                        names[j] = temp;
                    }
                }
            }
        }
    }
}
