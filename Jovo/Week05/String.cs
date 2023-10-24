using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Jovo.Week05
{
    internal class String
    {
        public static void Start()
        {


            
            string[] names = new string[] { "Jovo", "Mehmet", "Sven", "Martin", "Selina", "Niklas", "Öli", "Fabienne", "Lukas", "Sandro", "Hassan", "Berna", "Gyula", "Dimitri", "Patrick", "Kerem", "Timo", "Gheorghe", "Mohammed", "Cemal", "Simon", "Fabian", "Dario", "Michael", "Erik", "David", "Riccardo", "Eren" };

            BubbleSortAscending(names);
            Console.WriteLine("Ascending");
            Console.WriteLine("===============================");
            PrintArray(names);

            Console.WriteLine("===============================");
            Console.WriteLine("===============================");

            BubbleSortDescending(names);
            Console.WriteLine("Descending");
            Console.WriteLine("===============================");
            PrintArray(names);

            Console.WriteLine("===============================");

            BubbleSortLexikographishA(names);
            Console.WriteLine("Lexiographisch Ascending");
            Console.WriteLine("===============================");
            PrintArray(names);

            Console.WriteLine("==============================");

            BubbleSortLexikographishD(names);
            Console.WriteLine("Lexiographisch Descending");
            Console.WriteLine("==============================");
            PrintArray(names);



        }


       public static void BubbleSortAscending(string[] arr)
       {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
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



        public static void PrintArray(string[] arr)
        {
            foreach ( string s in arr)
            {
                Console.WriteLine(s);
            }
        }


        public static void BubbleSortDescending(string[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
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


        public static void BubbleSortLexikographishA(string[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (string.Compare(arr[j], arr[j + 1]) > 0)
                    {
                        string temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

        }

        public static void BubbleSortLexikographishD(string[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (string.Compare(arr[j], arr[j + 1]) < 0)
                    {
                        string temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

        }




    }
}
