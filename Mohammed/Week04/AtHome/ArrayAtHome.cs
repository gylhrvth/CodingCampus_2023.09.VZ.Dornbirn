using System;
namespace Mohammed.Week04.AtHome
{
    public class ArrayAtHome
    {
        public static void Start()
        {
            int size = ReadInput2("Give me a value", 1, 2000);
            int[][] arr = CreateArray2(size);
            printArray(arr);
            MachArrayfull(arr);




        }

        public static int[][] CreateArray2(int size)
        {
            int[][] Array2D = new int[size][];

            for (int i = 0; i < size; i++)
            {
                Array2D[i] = new int[size];
            }
            return Array2D;
        }

        public static void printArray(int[][] Array)
        {
            for (int i = 0; i < Array.Length; i++)
            {
                for (int j = 0; j < Array.Length; j++)
                {
                    Console.Write($"{Array[i][j]}");
                }
                Console.WriteLine();
            }
        }

        public static int[][] MachArrayfull(int[][] Array)
        {

            for (int i = 0; i < Array.Length; i++)
            {
                for (int j = 0; j < Array.Length; j++)
                {
                    Array[i][j] = (Array.Length * i) + j + 1;
                }
            }
            return Array;
        }


        public static int ReadInput2(string msg, int min, int max)
        {
            while (true)
            {
                try
                {

                    Console.WriteLine(msg);

                    string Input = Console.ReadLine();

                    if (Input.Contains('.'))
                    {
                        Console.WriteLine("you cent enter a decimal number");
                        double Num = Convert.ToInt32(Input);
                        Console.WriteLine("your number will be round " + Math.Floor(Num));

                    }

                    int Number = Convert.ToInt32(Input);

                    if (Number < min || Number > max)
                    {
                        Console.WriteLine($"Number between {min} and {max}");

                    }
                    else
                    {
                        return Number;
                    }

                }
                catch(FormatException)
                {
                    Console.WriteLine("Enter a number please!");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("The number was tooo big");
                }
            }


        }

    }
}


