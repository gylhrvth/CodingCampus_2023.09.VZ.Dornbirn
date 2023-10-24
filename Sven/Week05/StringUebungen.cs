using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sven.Week05
{
    internal class StringUebungen
    {

        public static void Start()
        {

            String[] names = new String[] { "Jovo", "Mehmet", "Sven", "Martin", "Selina",
                "Niklas", "Ali", "Fabienne", "Lukas", "Sandro", "Hassan", "Berna", "Gyula",
                "Dimitri", "Patrick", "Kerem", "Timo", "Gheorghe", "Mohammed", "Cemal",
                "Simon", "Fabian", "Dario", "Michael", "Erik", "David", "Riccardo", "Eren" };

            Console.WriteLine("Bubblesort String Ascending:");
            Console.WriteLine("{0}", string.Join(", ", AscendNames(names)));
            Console.WriteLine();

            Console.WriteLine("Bubblesort String Descending:");
            Console.WriteLine("{0}", string.Join(", ", DescendNames(names)));
            Console.WriteLine();

            Console.WriteLine("Bubblesort String Lexicographic Ascending:");
            Console.WriteLine("{0}", string.Join(", ", LexicoAscend(names)));
            Console.WriteLine();

            

        }
        public static string[] AscendNames(string[] arr)
        {
            string temp;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j].Length > arr[j + 1].Length)
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            return arr;
        }

        public static string[] DescendNames(string[] arr)
        {
            string temp;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j].Length < arr[j + 1].Length)
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            return arr;
        }
        public static string[] LexicoAscend(string[] arr)
        { 
            
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (string.Compare(arr[j], arr[j + 1]) > 0)
                    {
                        string temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
      
                
            }
            return arr;
        }


    }
}







