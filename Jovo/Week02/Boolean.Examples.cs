

namespace Jovo.Week02
{
    public class Boolean
    {
        public static void Start()
        {
            Console.WriteLine("Printing Pyramid");
            PrintPyramid("x", 5);
            Console.WriteLine();








            int number = 50;

            for (int i = 20 - 1; i <= number; i++)
            {
                if (i < number)
                {
                    Console.WriteLine(i + 1);
                }
            }
            Console.WriteLine();





        }





        public static void PrintPyramid(string symbol, int size)
        {
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    if (row + col == 5)
                    {
                        Console.Write(symbol);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();


            }









        }









    }

}
