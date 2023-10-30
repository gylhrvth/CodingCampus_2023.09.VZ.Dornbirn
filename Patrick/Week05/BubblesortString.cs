using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Patrick.Week05
{
    internal class BubblesortString
    {
        public static void Start()
        {
            string[] names = { "Jovo", "Mehmet", "Sven", "Martin", "Selina", "Niklas", "Ali", "Fabienne", "Lukas", "Sandro", "Hassan", "Berna", "Gyula", "Dimitri", "Patrick", "Kerem", "Timo", "Gheorghe", "Mohammed", "Cemal", "Simon", "Fabian", "Dario", "Michael", "Erik", "David", "Riccardo", "Eren" };
            //Console.WriteLine("Bubblesort Asc: ");
            //PrintArray(BubbleSortAsc(names));

            //Console.WriteLine("Bubblesort Desc: ");
            //PrintArray(BubbleSortDesc(names));

            //Console.WriteLine("Bubblesort Lexikographisch aufsteigend: ");
            //PrintArray(BubbleSortLexAsc(names));

            //Console.WriteLine("Bubblesort Lexikographisch absteigend: ");
            //PrintArray(BubbleSortLexDesc(names));

            //Console.WriteLine("BubbleSort Up & Down:");
            //PrintArray(BubbleSortExtended(true, names));

            //Console.WriteLine("Bubblesort CharacterIndex:");
            //PrintArray(BubbleSortCharacterIndex(names, 2));

        }

        public static void PrintArray(string[] name)
        {
            Console.WriteLine("[{0}]", string.Join(", ", name));
            Console.WriteLine();
        }

        public static string[] BubbleSortAsc(string[] name)
        {
            for (int i = 0; i < name.Length; i++)
            {
                for (int j = 0; j < name.Length - i - 1; j++)
                {
                    if (name[j].Length > name[j + 1].Length)
                    {
                        string tempMemory = name[j];
                        name[j] = name[j + 1];
                        name[j + 1] = tempMemory;
                    }
                }
            }
            return name;
        }

        public static string[] BubbleSortDesc(string[] name)
        {
            for (int i = 0; i < name.Length; i++)
            {
                for (int j = 0; j < name.Length - i - 1; j++)
                {
                    if (name[j].Length < name[j + 1].Length)
                    {
                        string tempMemory = name[j];
                        name[j] = name[j + 1];
                        name[j + 1] = tempMemory;
                    }
                }
            }
            return name;
        }

        public static string[] BubbleSortExtended(bool upDown, string[] name)
        {
            if (upDown == true)
            {
                BubbleSortAsc(name);
            }
            else
            {
                BubbleSortDesc(name);
            }
            return name;
        }

        public static string[] BubbleSortLexAsc(string[] name)
        {
            for (int i = 0; i < name.Length; i++)
            {
                for (int j = 0; j < name.Length - i - 1; j++)
                {
                    if (name[j].CompareTo(name[j + 1]) > 0)
                    {
                        string tempMemory = name[j];
                        name[j] = name[j + 1];
                        name[j + 1] = tempMemory;
                    }
                }
            }
            return name;
        }

        public static string[] BubbleSortLexDesc(string[] name)
        {
            for (int i = 0; i < name.Length; i++)
            {
                for (int j = 0; j < name.Length - i - 1; j++)
                {
                    if (name[j].CompareTo(name[j + 1]) < 0)                 // < 0 oder > 0 geben die Alphabetische Sortierrichtung an
                    {
                        string tempMemory = name[j];
                        name[j] = name[j + 1];
                        name[j + 1] = tempMemory;
                    }
                }
            }
            return name;
        }

        public static string[] BubbleSortCharacterIndex(string[] name, int characterIndex)
        {
            for (int i = 0; i < name.Length; i++)
            {
                for (int j = 0; j < name.Length - i - 1; j++)
                {
                    if (name[j][characterIndex].CompareTo(name[j + 1][characterIndex]) > 0)
                    {
                        string tempMemory = name[j];
                        name[j] = name[j + 1];
                        name[j + 1] = tempMemory;
                    }
                }
            }
            return name;
        }

    }
}
