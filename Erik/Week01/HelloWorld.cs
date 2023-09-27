using System;
namespace Erik.Week01
{
	public class HelloWorld


	{


		public static void Start()
		{

			
		
			Console.WriteLine("Hello World! \n \n      /--\\ \n     / /\\ \\ \n    / /  \\ \\ \n   / /    \\ \\ \n  /  ======  \\ \n /_/        \\_\\");
			Console.WriteLine("\n \n");
			Console.WriteLine("||=====  ||===||   ||   ||  //");
            Console.WriteLine("||       ||   ||   ||   || //");
            Console.WriteLine("||       ||===||   ||   ||//");
            Console.WriteLine("||====   ||\\\\      ||   ||\\\\");
            Console.WriteLine("||       || \\\\     ||   || \\\\");
            Console.WriteLine("||       ||  \\\\    ||   ||  \\\\");
            Console.WriteLine("||=====  ||   \\\\   ||   ||   \\\\");

			for (int numberOne = 0; numberOne < 11; numberOne++)
			{
				Console.WriteLine(numberOne);
			}


            Console.WriteLine("");


            int numberTwo = 0;
            while (numberTwo < 11)
			{
                Console.WriteLine(numberTwo);
				numberTwo++;
            }


            Console.WriteLine("");


			for (int numberThree = 0; numberThree < 10; numberThree++)
			{
                Console.WriteLine(numberThree);
            }

            Console.WriteLine("");



            int numberFour = 1;
			while (numberFour < 11) {

				if (numberFour % 2 == 0) 
				{
                    Console.WriteLine(numberFour);

                }

                numberFour++;
            }

            Console.WriteLine("");


            for (int numberFive = 10; numberFive > -11; numberFive--)
			{

                Console.WriteLine(numberFive);

            }






        }

	}
}

