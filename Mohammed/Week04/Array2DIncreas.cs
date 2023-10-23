using System;
namespace Mohammed.Week04
{
    public class Array2DIncreas
    {
        public static void Start()
        {

            int size = ReadInput("Gib mir eine Größe!!",1,20);
            int[][] arr = Created2Array(size);
            FillArray(arr);
            PrintArray(arr);
        }

        public static int[][] Created2Array(int size)
        {
            int[][] Array2D = new int[size][];

            for (int i = 0; i < size; i++)
            {
                Array2D[i] = new int[size];
            }
            return Array2D;

        }

        public static void PrintArray(int[][] array)
        {   //da fragen ich nach lange!!length

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    
                    Console.Write($"{array[i][j],6}");
                }
                Console.WriteLine();
            }
        }

        public static int[][] FillArray(int[][] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    array[i][j] = (array.Length * i) + j+ 1;
                    
                   
                }

            }
            return array;
        }

        public static int ReadInput(string msg,int min, int max)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine(msg);

                    string Input = Console.ReadLine();
                    

                    if(Input.Contains('.'))
                    {
                        Console.WriteLine("You cant enter a decimal number");
                        double Num = Convert.ToDouble(Input);
                        Console.WriteLine("Your number will be round " + Math.Floor(Num));
                    }

                    int Number = Convert.ToInt32(Input);


                    if(Number < min || Number > max)
                    {
                        Console.WriteLine($"Number between {min} and {max}");
                    }
                    else
                    {
                        return Number;
                    }
                 
                }

                catch (FormatException)
                {
                    Console.WriteLine("Enter a number please!");
                    
                }
                catch(OverflowException)
                {
                    Console.WriteLine("The number was too big");
                }
            }
         
        }



    }


}

