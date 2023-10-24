using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using System.Threading.Channels;

namespace Niklas.Week05
{
    internal class StringÜbung
    {
        public static void Start()
        {
            //String text = "Hello World!";
            //Console.WriteLine(text[8]);


            String[] names = new String[] { "Jovo", "Mehmet", "Sven", "Martin", "Selina", "Niklas", "Ali", "Fabienne", "Lukas", "Sandro", "Hassan", "Berna", "Gyula", "Dimitri", "Patrick", "Kerem", "Timo", "Gheorghe", "Mohammed", "Cemal", "Simon", "Fabian", "Dario", "Michael", "Erik", "David", "Riccardo", "Eren" };

            //BubblesortAsc(names);
            //PrintArray(names);
            //BubblesortDesc(names);
            //PrintArray(names);
            //BubblesortAlphabetAsc(names);
            //PrintArray(names);
            //BubblesortAlphabetDesc(names);
            //PrintArray(names);
            //BubblesortBoolean(names, false);
            //PrintArray(names);
            //BubblesortIndex(names);
            //PrintArray(names);



            Reverse();
        }
        public static void BubblesortAsc(String[] names)
        {
            int i = 0;

            for (i = 0; i < names.Length - 1; i++)
            {
                for (int j = 0; j < names.Length - 1 - i; j++)
                {
                    if (names[j].Length > names[j + 1].Length)
                    {
                        string temp = names[j];
                        names[j] = names[j + 1];
                        names[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("Ascend:");
        }
        public static void BubblesortDesc(String[] names)
        {
            int i = 0;

            for (i = 0; i < names.Length - 1; i++)
            {
                for (int j = 0; j < names.Length - 1 - i; j++)
                {
                    if (names[j].Length < names[j + 1].Length)
                    {
                        string temp = names[j];
                        names[j] = names[j + 1];
                        names[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("Descend:");
        }
        public static void BubblesortAlphabetAsc(String[] names)
        {
            int i = 0;

            for (i = 0; i < names.Length - 1; i++)
            {
                for (int j = 0; j < names.Length - 1 - i; j++)
                {
                    if (names[j].CompareTo(names[j + 1]) > 0)
                    {
                        string temp = names[j];
                        names[j] = names[j + 1];
                        names[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("Ascend by Alphabet:");
        }
        public static void BubblesortAlphabetDesc(String[] names)
        {
            int i = 0;

            for (i = 0; i < names.Length - 1; i++)
            {
                for (int j = 0; j < names.Length - 1 - i; j++)
                {
                    if (names[j].CompareTo(names[j + 1]) < 0)
                    {
                        string temp = names[j];
                        names[j] = names[j + 1];
                        names[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("Descend by Alphabet:");
        }
        public static void BubblesortBoolean(String[] names, bool cases)
        {
            int i = 0;

            if (cases == true)
            {
                for (i = 0; i < names.Length - 1; i++)
                {
                    for (int j = 0; j < names.Length - 1 - i; j++)
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
            else if (!cases)
            {
                for (i = 0; i < names.Length - 1; i++)
                {
                    for (int j = 0; j < names.Length - 1 - i; j++)
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
            Console.WriteLine("Ascend or Descend:");
        }
        public static void BubblesortIndex(String[] names)
        {
            for (int i = 0; i < names.Length - 1; i++)
            {
                for (int j = 0; j < names.Length - 1 - i; j++)
                {
                    if (names[j][2].CompareTo(names[j + 1][2]) > 0)
                    {
                        string temp = names[j];
                        names[j] = names[j + 1];
                        names[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("Sort by 3rd character:");
        }

        public static void Reverse()
        {
            Console.Write("Enter something you want to be reversed: ");
            String input = Console.ReadLine();
            input.ToCharArray();

            String first = Convert.ToString(input[0]);
            String last = Convert.ToString(input[input.Length-1]);


            Console.WriteLine(first + last);

            String[] input2 = input;

            String charArray = input;

            for (int i = 0; i < input.Length - 1; i++)
            {
                for (int j = 0; j < input.Length - 1 - i; j++)
                {
                    if (input[j].CompareTo(input[j + 1]) < 0)
                    {
                        string temp = input2[j];
                        input2[j] = input2[j + 1];
                        input2[j + 1] = temp;
                    }
                }
            }


            new String(charArray);

            
            Console.WriteLine("Reversed input: " + charArray);
        }
        public static void PrintArray(String[] names)
        {
            foreach (string item in names)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
    }
}