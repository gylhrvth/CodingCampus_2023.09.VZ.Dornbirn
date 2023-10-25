using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Riccardo.Week05
{
    internal class Strings
    {
        public static void Start()
        {
            string[] names = new string[] { "Jovo", "Mehmet", "Sven", "Martin", "Selina", "Niklas", "Ali",
                "Fabienne", "Lukas", "Sandro", "Hassan", "Berna", "Gyula", "Dimitri", "Patrick", "Kerem",
                "Timo", "Gheorghe", "Mohammed", "Cemal", "Simon", "Fabian", "Dario", "Michael", "Erik",
                "David", "Riccardo", "Eren" };

            //Die Namen aufsteigend sortiert
            Bubblesortaufsteigend(names);
            Console.WriteLine("Namen nach Länge aufsteigend sortieren");
            PrintArray(names);

            //Die Namen absteigend sortierten
            Bubblesortabsteigend(names);
            Console.WriteLine("Namen nach Länge absteigend sortieren");
            PrintArray(names);
            /*
            //Die Namen lexikographisch aufsteigend sortieren
            Bubblesortlexigraphischauf(names);
            Console.WriteLine("Namen nach lexikographisch aufsteigend");
            PrintArray(names);
            
            //Die Namen lexikographisch absteigend sortieren
            Bubblesortlexikab("Namen nach lexikographisch absteigend");
            Console.WriteLine(names);
            */

        }

        static void Bubblesortaufsteigend(string[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    if (arr[j].Length > arr[j + 1].Length)
                    {
                        string temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        static void Bubblesortabsteigend(string[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    if (arr[j].Length < arr[j + 1].Length)
                    {
                        string temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
        /*
        static void Bubblesortlexigraphischauf(string[] arr)
        {

        }
        */

        static void PrintArray(string[] arr)
        {
            foreach (string s in arr)
            {
                Console.WriteLine(s);
            }
        }
    }

}
