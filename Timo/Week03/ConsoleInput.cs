using Microsoft.VisualBasic;
using System;
using System.Numerics;
using System.Transactions;
using Timo.Week01;

namespace Timo.Week03
{
    public class ConsoleInputs
    {
        public static void Start()
        {
            /*
            //Aufgabe1
            Console.WriteLine("Aufgabe1: String einlesen");

            Console.WriteLine("Please enter your String");
            String stringInput = Console.ReadLine();
            Console.WriteLine("The input was : " + stringInput);

            Console.WriteLine("=======================================");


            //Aufgabe2.2 Zahl einlesen
            Console.WriteLine("Aufgabe2: Zahl einlesen");

            int readNumber = ReadNumber("Please enter your number:", "Thats not a number. Please try again:");
            Console.WriteLine("Read number is: " + readNumber);

            Console.WriteLine("=======================================");
            
            //Aufgabe3+4 Ratespiel
            Console.WriteLine("Aufgabe3+4: Ratespiel");
            Guessinggame(0, 100);


            Console.WriteLine("=======================================");


            //Aufgabe5 Menü
            Console.WriteLine("Aufgabe5: Menü");
            Menue();

            Console.WriteLine("=======================================");
            */

            //Aufgabe6 Taschenrechner
            Console.WriteLine("Aufgabe6: Taschenrechner");
            Calculator();

        }

        // Read String NEU

        public static string ReadString(string msg)
        {
            string line = "";
            bool firstTry = true;
            while (line.CompareTo("") == 0)
            {
                if (!firstTry)
                {
                    Console.WriteLine("I did not understand. Please try again!");
                }
                Console.Write(msg);
                line = Console.ReadLine();
                line ??= "";
                line = line.Trim();
                firstTry = false;
            }
            return line;
        }


        //------------------------------------------------------------------------------------------------------------------------------

        //Ergänzung ReadChar 
        public static char ReadChar(String prompt)
        {
            Console.WriteLine(prompt);
            while (true)
            {
                try
                {
                    String input = Console.ReadLine();
                    char myChar = Convert.ToChar(input);
                    return myChar;
                }
                catch (FormatException exc)
                {
                    Console.Error.WriteLine("Please choose an valid character");
                }
            }
        }
        //------------------------------------------------------------------------------------------------------------------------------
        //------------------------------------------------------------------------------------------------------------------------------

        //Readnumber NEU
        public static int ReadNumber(string msg, int minValid, int maxValid)
        {
            int result = Int32.MinValue;
            while (result == Int32.MinValue)
            {
                Console.Write("{0}between {1} and {2}: ", msg, minValid, maxValid);
                string line = Console.ReadLine();
                try
                {
                    result = Convert.ToInt32(line);
                    if (result < minValid || result > maxValid)
                    {
                        Console.WriteLine("{0} is not in range of {1} and {2}", result, minValid, maxValid);
                        result = Int32.MinValue;
                    }
                }
                catch (FormatException fe)
                {
                    Console.WriteLine("\"{0}\" is not a valid number.", line);
                }
            }
            return result;
        }
        //Readfloat NEU
        public static float ReadNumberFloat(string msg, int minValid, int maxValid)
        {
            float result = Int32.MinValue;
            while (result == Int32.MinValue)
            {
                Console.Write("{0}between {1} and {2}: ", msg, minValid, maxValid);
                string line = Console.ReadLine();
                try
                {
                    result = (float)Convert.ToDouble(line);
                    if (result < minValid || result > maxValid)
                    {
                        Console.WriteLine("{0} is not in range of {1} and {2}", result, minValid, maxValid);
                        result = Int32.MinValue;
                    }
                }
                catch (FormatException fe)
                {
                    Console.WriteLine("\"{0}\" is not a valid number.", line);
                }
            }
            return result;
        }


        //------------------------------------------------------------------------------------------------------------------------------

        //Ratespiel NEU und besser
        public static void Guessinggame(int startNumber, int endNumber)
        {
            Console.WriteLine("Welcome to the game! Try to guess the correct number: enter a number between {0} and {1}", startNumber, endNumber);
            Random random = new Random();
            int count = 0;
            int number = Int32.MinValue;
            int i = random.Next(startNumber, endNumber + 1);
            while (number != i)
            {
                count++;
                number = ReadNumber("Please enter your Number ", 0, 100);
                if (number < i)
                {
                    Console.WriteLine("Your number is too small, try again");
                }
                else if (number > i)
                {
                    Console.WriteLine("Your number is too big, try again");
                }
                else
                {
                    Console.WriteLine("You have won! Number of guesses: " + count);
                }
            }
        }


        //------------------------------------------------------------------------------------------------------------------------------

        //Aufgabe5 Menü
        public static void Menue()
        {
            Console.WriteLine("Welcome!");
            string exit = "n";
            while (exit != "j")
            {
                int choice = ReadNumber("What do you want to draw ? \n1) Square \n2) Pyramid \n3) Christmastree \nChoose a number ", 1, 3);

                if (choice == 1)
                {
                    MethodenUndSchleifen.PrintSquare(ReadChar("What character should be used?"), ReadNumber("Choose a size for your sqare ", 1, 99));
                }
                else if (choice == 2)
                {
                    MethodenUndSchleifen.PrintPyramid(ReadChar("What character should be used?"), ReadNumber("Choose a size for your pyramid ", 1, 99));
                }
                else if (choice == 3)
                {
                    MethodenUndSchleifen.PrintChristmasTree(ReadChar("What character should be used?"), ReadNumber("Choose a size for your christmastree ", 1, 99));
                }
                while (true)
                {
                    Console.WriteLine();
                    string answer = ReadString("Do you want to continiue? Enter 'j' or 'n': ");
                    if (answer == "j")
                    {
                        break;
                    }
                    if (answer == "n")
                    {
                        Console.WriteLine("Hope to see you soon :)");
                        exit = "j";
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid answer");
                    }
                }
            }
        }


        //------------------------------------------------------------------------------------------------------------------------------

        //Taschenrechner
        public static void Calculator()
        {
            string exit = "n";
            bool w = false;
            float result = 0;
            while (exit != "j")
            {
                float x1 = 0;
                if (w == false)
                {
                    x1 = ReadNumberFloat("Please enter your first number ", -1000000, 1000000);
                }
                else
                {
                    x1 = result;
                }
                char myOperator = ReadOperator("Please enter your operator", "Please enter a valid operator");
                float x2 = ReadNumberFloat("Please enter your second number ", -1000000, 1000000);
                if (DoMaths(x1, myOperator, x2) == float.MaxValue)
                {
                    Console.WriteLine("Division by zero error");
                    break;
                }
                else
                {
                    Console.WriteLine(DoMaths(x1, myOperator, x2));
                }
                while (true)
                {
                    Console.WriteLine();
                    string answer = ReadString("If you want to end the calculator press 'e'.\nIf you want to start a new calculation press 'n'. \nIf you want to continue with the current result enter 'c'. ");
                    if (answer == "n")
                    {
                        w = false;
                        break;
                    }
                    else if (answer == "e")
                    {
                        Console.WriteLine("Hope to see you soon :)");
                        exit = "j";
                        break;
                    }
                    else if (answer == "c")
                    {
                        w = true;
                        result = DoMaths(x1, myOperator, x2);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid answer");
                    }
                }
            }
        }


        //ReadOperator
        public static char ReadOperator(String prompt, String onError)
        {
            Console.WriteLine(prompt);
            while (true)
            {
                try
                {
                    String input = Console.ReadLine();
                    char myChar = Convert.ToChar(input);
                    if (myChar == '+' || myChar == '-' || myChar == '*' || myChar == '^' || myChar == '/')
                    {
                        return myChar;
                    }
                    else
                    {
                        Console.Error.WriteLine(onError);
                    }
                }
                catch (FormatException exc)
                {
                    Console.Error.WriteLine(onError);
                }
            }
        }
        //Rechnungen
        public static float DoMaths(float x1, char myOperator, float x2)
        {
            if (myOperator == '+')
            {
                return x1 + x2;
            }
            else if (myOperator == '-')
            {
                return x1 - x2;
            }
            else if (myOperator == '*')
            {
                return x1 * x2;
            }
            else if (myOperator == '^')
            {
                float temp = x1;
                for (int i = 0; i < x2 - 1; i++)
                {
                    temp = temp * x1;
                }
                return temp;
            }
            else if (myOperator == '/')
            {
                if (x2 != 0)
                {
                    return x1 / x2;
                }
                else
                {
                    return float.MaxValue;
                }
            }
            return 0;
        }
    }
}



//_____________________________________________________________________________________________________________________________________________________________________________________________________________________________

////ReadFloat
//public static float ReadNumberFloat(String prompt, String onError)
//{
//    Console.WriteLine(prompt);
//    while (true)
//    {
//        try
//        {
//            String input = Console.ReadLine();

//            float myNumber = (float)Convert.ToDouble(input);

//            return myNumber;
//        }
//        catch (FormatException exc)
//        {
//            Console.Error.WriteLine(onError);
//        }
//    }
//}


////Aufgabe2
//public static int ReadNumber(String prompt, String onError)
//{
//    Console.WriteLine(prompt);
//    while (true)
//    {
//        try
//        {
//            String input = Console.ReadLine();

//            int myNumber = Convert.ToInt32(input);

//            return myNumber;
//        }
//        catch (FormatException exc)
//        {
//            Console.Error.WriteLine(onError);
//        }
//    }
//}


////Aufgabe3+4 Ratespiel
//public static void Guessinggame(int startNumber, int endNumber, String exitCode)
//{
//    Console.WriteLine("Welcome to the game! Try to guess the correct number: enter a number between {0} and {1}. \nWrite '{2}' to leave the game", startNumber, endNumber, exitCode);
//    Random random = new Random();
//    int count = 1;
//    int i = random.Next(startNumber, endNumber + 1);
//    while (true)
//    {
//        try
//        {
//            String input = Console.ReadLine();
//            string exit = exitCode;
//            if (input == exit)
//            {
//                Console.WriteLine("Sad to see you going, hope to see you soon :)");
//                return;
//            }
//            int output = Convert.ToInt32(input);
//            if (output == i)
//            {
//                Console.WriteLine("You have won! Number of guesses: " + count);
//                return;
//            }
//            else if (output < i)
//            {
//                Console.WriteLine("Your number is too small, try again");
//            }
//            else if (output > i)
//            {
//                Console.WriteLine("Your number is too big, try again");
//            }
//        }
//        catch
//        {
//            Console.WriteLine("Please choose an integer ");
//        }
//        count++;
//    }
//}


//    //Aufgabe5 Menü
//    public static void Menue(string exitCode)
//{
//    Console.WriteLine("Welcome!");
//    while (true)
//    {
//        Console.WriteLine("What do you want to draw ? \n1) Square \n2) Pyramid \n3) Christmastree \nWhat do you want to choose? ");
//        string k = "Please choose an valid integer";
//        string o = "What character should be used?";
//        string l = "Please choose an valid character";
//        try
//        {
//            String input = Console.ReadLine();
//            string exit = exitCode;
//            if (input == exit)
//            {
//                Console.WriteLine("Sad to see you going, hope to see you soon :)");
//                return;
//            }
//            int output = Convert.ToInt32(input);
//            if (output == 1)
//            {
//                MethodenUndSchleifen.PrintSquare(ReadChar(o, l), ReadNumber("What should be the size of the square?", k));
//                Console.WriteLine("new?");
//                int x = 1;
//                while (x == 1)
//                {
//                    try
//                    {
//                        String answerIn = Console.ReadLine();
//                        char answer = Convert.ToChar(answerIn);
//
//                        if (answer == 'j')
//                        {
//                            Console.WriteLine("haha");
//                            x = 0;
//                        }
//                        else if (answer == 'n')
//                        {
//                            return;
//                        }
//                        else
//                        {
//                            Console.WriteLine("Please enter 'j' or 'n'");
//                        }
//                    }
//                    catch
//                    {
//                        Console.WriteLine("Please enter 'j' or 'n'");
//                    }
//                }
//            }
//            else if (output == 2)
//            {
//                MethodenUndSchleifen.PrintPyramid(ReadChar(o, l), ReadNumber("What should be the size of the pyramid?", k));
//            }
//            else if (output == 3)
//            {
//                MethodenUndSchleifen.PrintChristmasTree(ReadChar(o, l), ReadNumber("What should be the size of the christmastree?", k));
//            }
//            else
//            {
//                Console.WriteLine("Please choose an valid integer");
//            }
//        }
//        catch
//        {
//            Console.WriteLine("Please choose an valid integer");
//        }
//    }
//}
