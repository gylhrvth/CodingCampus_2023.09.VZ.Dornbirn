using System;
namespace Michael.Week01
{
	public class HelloWorld
	{
		public static void Start()
		{
			Console.WriteLine("Hello World!");
            Console.WriteLine(" ___    ___");
            Console.WriteLine("|   \\  /   |");
            Console.WriteLine("| |\\ \\/ /| |");
            Console.WriteLine("| | \\__/ | |");
            Console.WriteLine("| |      | |");
            Console.WriteLine("| |      | |");
            Console.WriteLine("|_|      |_|");

            Console.WriteLine("    ")
            Console.WriteLine("     |-|	");
            Console.WriteLine("     | |	");
            Console.WriteLine("     | |	");
            Console.WriteLine("     | |	");
            Console.WriteLine("     | |	");
            Console.WriteLine("     |_|	");

            Console.WriteLine("   -------\n  |  _____|\n  | |\n  | |\n  | |_____\n  |_______|");

            Console.WriteLine(@"     /--\
    / /\ \
   / /  \ \
  / /    \ \
 /  ======  \
/_/        \_\");

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            int counter = 0;

            while (counter <= 10)
            {
                Console.WriteLine(counter);
                counter++;
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            counter = 0;

            while (counter < 10)
            {
                Console.WriteLine(counter);
                counter++;
            }




        }
}
}
