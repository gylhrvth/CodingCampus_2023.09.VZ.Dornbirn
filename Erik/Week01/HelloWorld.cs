using System;
using System.Diagnostics;
using System.Threading;

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
            while (numberFour < 11)
            {

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

            Console.WriteLine("");
            bool online = true;
            bool loginPassword = false;
            int loginTrys = 4;

            while (loginTrys > 0)
            {

                if (online && loginPassword)
                {


                    Console.WriteLine("Login erfolgreich!");
                    break;

                }
                else if (!online)
                {
                    Console.WriteLine("Du musst online sein um dich an zu melden!");
                    break;
                }
                else
                {
                    loginTrys--;
                    Console.WriteLine("Passwort falsche versuche es erneut \n Du hast noch " + loginTrys + " Versuche übrig! \n");
                }
            }

            Console.WriteLine("");

            String rootPassword = "rootpassword";
            String userOnlineInput;
            String userPasswordInput;
            int loginTrys1 = 3;
            int windowClosingCounter = 0;


            Console.Write("Geben Sie den Online Status ein! \n Status:");
            userOnlineInput = Console.ReadLine();

            while (userOnlineInput != "Online")
            {

                Console.WriteLine("\n Du musst Online sein um fort zu fahren! \n");
                Console.Write("Geben Sie den Online Status ein! \n Status:");
                userOnlineInput = Console.ReadLine();
            }

            Console.Write(" \n Geben Sie das Passwort ein! \n Password:");
            userPasswordInput = Console.ReadLine();

            while (userPasswordInput != rootPassword)
            {
                if (loginTrys1 > 0)
                {


                    Console.Write("Falsches Passwort!\n \nDu hast noch " + loginTrys1 + " Versuche übrig!\n" + " Versuche es erneut: ");
                    loginTrys1--;
                    userPasswordInput = Console.ReadLine();
                }
                else if (loginTrys1 == 0)
                {
                    Console.WriteLine("Dein Account wurde gesperrt!");
                    break;
                }
            }

            if (userPasswordInput == rootPassword)
            {
                Console.WriteLine("\nLogin erfolgreich!");
                Console.WriteLine("\n __      ___ _ _ _                            _ \r\n \\ \\    / (_) | | |_____ _ __  _ __  ___ _ _ | |\r\n  \\ \\/\\/ /| | | | / / _ \\ '  \\| '  \\/ -_) ' \\|_|\r\n   \\_/\\_/ |_|_|_|_\\_\\___/_|_|_|_|_|_\\___|_||_(_)\r\n                                                ");
                Console.WriteLine("Das Fenster schließt sich automatisch in 3 Sekunden!\n");
                Thread.Sleep(3000);
                System.Environment.Exit(0);
                
            }
        }

	}
}

