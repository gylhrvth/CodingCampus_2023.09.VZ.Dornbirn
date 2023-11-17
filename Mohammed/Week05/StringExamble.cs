using System;
namespace Mohammed.Week05
{
    public class StringExamble
    {
        public static void Start()
        {
            string[] names = new string[] { "Jovo", "Mehmet", "Sven", "Martin", "Selina", "Niklas", "Ali", "Fabienne",
                "Lukas", "Sandro", "Hassan", "Berna", "Gyula", "Dimitri", "Patrick",
                "Kerem", "Timo", "Gheorghe", "Mohammed", "Cemal", "Simon", "Fabian", "Dario",
                "Michael", "Erik", "David", "Riccardo", "Eren" };


            //Console.WriteLine("========= Unsorted =======");
            //PrintArray(names);

            //Console.WriteLine();
            //Console.WriteLine("===========Sorted========");
            //BubbleSort(names);
            //PrintArray(names);

            //Console.WriteLine();

            //Console.WriteLine("=========BOOL 007 =============");
            //BubbleSortBool(names, true);
            //PrintArray(names);


            //Console.WriteLine("=========BOOL 002 =============");
            //BubbleSortBool(names, false);
            //PrintArray(names);

            //Console.WriteLine();

            //Console.WriteLine("============Index============");
            //BubbleSortindex(names, 0, true);
            //PrintArray(names);

            //Console.WriteLine();

            Console.WriteLine("==============ReverseSTR============");
            string word = Reverse("Nicht");
            Console.WriteLine(word);



        }


        public static void PrintArray(string[] arr)
        {
            foreach (string value in arr)
            {
                Console.WriteLine(value);

            }

        }



        public static void BubbleSort(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++) // - i ist dafür da, dass der vergleich nicht doppelt ausgeführt wird, sondern nur durch hälfte weil er immer 2 zahlen vergleicht
                                                               // - 1 ist dafür da das man den letzten index noch mit vergleicht
                {
                    if (array[j].Length > array[j + 1].Length)
                    {
                        string temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }







        public static void BubbleSort2(string[] names)
        {
            for (int i = 0; i < names.Length - 1; i++)
            {
                for (int j = 0; j < names.Length - i - 1; j++)
                {
                    if (names[j][0] < names[j + 1][0])
                    {
                        string temp = names[j];
                        names[j] = names[j + 1];
                        names[j + 1] = temp;

                    }
                }
            }
        }


        //da wird es in anderes geschrieben mit Compare
        /*public static void BubbleSortHassan(string[] names)
        {
            for (int i = 0; i < names.Length - 1; i++)
            {
                for (int j = 0; j < names.Length - i - 1; j++)
                {
                    if (string.Compare(names[j], names[j + 1]) > 0)
                    {
                        string temp = names[j];
                        names[j] = names[j + 1];
                        names[j + 1] = temp;

                    }
                }
            }
        }*/


        // Die zweite Aufgabe mit Bool


        public static void BubbleSortBool(string[] names, bool aufsteigend)
        {

            for (int i = 0; i < names.Length - 1; i++)
            {
                for (int j = 0; j < names.Length - i - 1; j++)
                {
                    if (aufsteigend == (string.Compare(names[j], names[j + 1]) > 0)) // ??????????????aufsteigend
                    {
                        string temp = names[j];
                        names[j] = names[j + 1];
                        names[j + 1] = temp;

                    }
                }
            }

        }



        //Drite Aufgabe Bubblesort mit Strings und Character Index
        public static void BubbleSortindex(string[] names, int index, bool asc)
        {
            for (int i = 0; i < names.Length - 1; i++)
            {
                for (int j = 0; j < names.Length - i - 1; j++)
                {
                    if (asc == (names[j][index].CompareTo(names[j + 1][index]) > 0))
                    {
                        string temp = names[j];
                        names[j] = names[j + 1];
                        names[j + 1] = temp;

                    }
                }
            }
        }



        public static string Reverse(string str)
        {
            char[] charArr = str.ToCharArray();
            int j = 0;

            for (int i = charArr.Length - 1; i >= charArr.Length / 2; i--)
            {
                char tmp = charArr[i];
                charArr[i] = charArr[j];
                charArr[j] = tmp;
                j++;
            }

            return new string(charArr);
        }


    }
}