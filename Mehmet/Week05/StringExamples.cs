using Mehmet.Week04;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static Mehmet.Week04.Input;


namespace Mehmet.Week05
{
    internal class StringExamples
    {

        public static String[] namesarr = new String[] { "Jovo", "Mehmet", "Sven", "Martin", "Selina", "Niklas", "Ali", "Fabienne", "Lukas", "Sandro", "Hassan", "Berna", "Gyula", "Dimitri", "Patrick", "Kerem", "Timo", "Gheorghe", "Mohammed", "Cemal", "Simon", "Fabian", "Dario", "Michael", "Erik", "David", "Riccardo", "Eren" };


        public static void Start()
        {
            //Console.WriteLine();
            //Console.WriteLine("BubbleSortNamesAscending");
            //Console.WriteLine("------------------------------------");
            //BubbleSortNamesAscending(namesarr);
            //Console.WriteLine();
            //Console.WriteLine("====================================");
            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("BubbleSortNamesDescending");
            //Console.WriteLine("------------------------------------");
            //BubbleSortNamesDescending(namesarr);
            //Console.WriteLine();
            //Console.WriteLine("====================================");
            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("BubbleSortNamesAscendingLexikographisch");
            //Console.WriteLine("------------------------------------");
            //BubbleSortNamesAscendingLexikographisch(namesarr);
            //Console.WriteLine();
            //Console.WriteLine("====================================");
            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("BubbleSortNamesDescendingLexikographisch");
            //Console.WriteLine("------------------------------------");
            //BubbleSortNamesDescendingLexikographisch(namesarr);
            //Console.WriteLine();
            //Console.WriteLine("====================================");
            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("BubbleSortNamesLexikographisch");
            //Console.WriteLine("------------------------------------");
            //BubbleSortNamesLexikographisch(namesarr, true);
            //Console.WriteLine();
            //Console.WriteLine("====================================");
            //Console.WriteLine();
            //Console.WriteLine();

            Console.WriteLine("BubbleSortNamesIndex");
            Console.WriteLine("------------------------------------\n");
            BubbleSortNamesIndex(namesarr,2,true);
            Console.WriteLine();
            Console.WriteLine("====================================");
            Console.WriteLine();
            Console.WriteLine();





        }


        public static void BubbleSortNamesAscending(string[] namesarr)
        {
            for (int i = 0; i < namesarr.Length - 1; i++)
            {
                for (int j = 0; j < namesarr.Length - 1; j++)
                {
                    string name1 = namesarr[j];
                    string name2 = namesarr[j + 1];

                    if (name1.Length > name2.Length)
                    {
                        namesarr[j] = name2;
                        namesarr[j + 1] = name1;
                    }
                }
            }
            Console.WriteLine("{0}", string.Join(" < ", namesarr));
        }
        public static void BubbleSortNamesDescending(string[] namesarr)
        {
            for (int i = 0; i < namesarr.Length - 1; i++)
            {
                for (int j = 0; j < namesarr.Length - 1; j++)
                {
                    string name1 = namesarr[j];
                    string name2 = namesarr[j + 1];

                    if (name1.Length < name2.Length)
                    {
                        namesarr[j] = name2;
                        namesarr[j + 1] = name1;
                    }
                }
            }
            Console.WriteLine("{0}", string.Join(" > ", namesarr));
        }
        public static void BubbleSortNamesAscendingLexikographisch(string[] namesarr)
        {
            for (int i = 0; i < namesarr.Length - 1; i++)
            {
                for (int j = 0; j < namesarr.Length - 1; j++)
                {
                    string name1 = namesarr[j];
                    string name2 = namesarr[j + 1];
                    if (string.Compare(name1, name2) > 0)
                    {
                        namesarr[j] = name2;
                        namesarr[j + 1] = name1;
                    }
                }
            }
            Console.WriteLine("{0}", string.Join(" , ", namesarr));
        }
        public static void BubbleSortNamesDescendingLexikographisch(string[] namesarr)
        {
            for (int i = 0; i < namesarr.Length - 1; i++)
            {
                for (int j = 0; j < namesarr.Length - 1; j++)
                {
                    string name1 = namesarr[j];
                    string name2 = namesarr[j + 1];
                    if (string.Compare(name1, name2) < 0)
                    {
                        namesarr[j] = name2;
                        namesarr[j + 1] = name1;
                    }
                }
            }
            Console.WriteLine("{0}", string.Join(" , ",  namesarr));
        }
        public static void BubbleSortNamesLexikographisch(string[] namesarr, bool a)
        {
            int mynumber = ReadNumber("Type 1 for Ascending Lexikographisch | Type 2 for Descending Lexikographisch:  ");
            a = true;
            while (a)
            {
                if (mynumber == 1)
                {
                    BubbleSortNamesAscendingLexikographisch(namesarr);
                    a = false;
                }
                else if (mynumber == 2)
                {
                    BubbleSortNamesDescendingLexikographisch(namesarr);
                    a = false;
                }
            }
        }
        public static void BubbleSortNamesIndex(string[] namesarr, int index ,bool a) 
        {
            Console.WriteLine($"Sortieren nach Buchstabe stelle:  {index+1}");    
            Console.WriteLine();
            a = true;
            while (a)
            {
                int mynumber = ReadNumber("Type 1 for Ascending Lexikographisch | Type 2 for Descending Lexikographisch:  ");
                for (int i = 0; i < namesarr.Length - 1; i++)
                {
                    for (int j = 0; j < namesarr.Length - 1; j++)
                    {
                        char name1 = namesarr[j][index];
                        char name2 = namesarr[j + 1][index];
                        int comparsion = string.Compare(name1.ToString(), name2.ToString());
                        if (mynumber == 1)
                        {
                            if (comparsion > 0)
                            {
                                string temp = namesarr[j];
                                namesarr[j] = namesarr[j + 1];
                                namesarr[j + 1] = temp;
                                a = false;
                            }
                        }
                        else if (mynumber == 2)
                        {
                            if (comparsion < 0)
                            {
                                string temp = namesarr[j];
                                namesarr[j] = namesarr[j + 1];
                                namesarr[j + 1] = temp;
                                a = false;
                            }
                        }
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("{0}", string.Join(", ", namesarr));
        }



    }
}
