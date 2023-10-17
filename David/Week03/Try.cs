using System;using System.ComponentModel.Design;

namespace David.Week03{
    public class Try
    {
        public static void StartTry()
        {
            // Schleifen -> Loops

            //int[] numbers = new int[] { 50, 200, 75 };

            // For

            //int result = 0;
            //int summe = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //	result += numbers[i];
            //}
            //Console.WriteLine(result);

            //foreach(int r in numbers)
            //{
            //	summe += r;
            //}
            //Console.WriteLine(summe);

            // 1 -10 zählen

            //for (int i = 1; i <= 10; i++)
            //{
            //	Console.WriteLine(i);

            //}

            // gerade zahlen
            //int max = 100;
            //for (int i = 2; i <= max; i+=2)
            //{
            //	Console.WriteLine(i);
            //}

            //int min = 10;

            //for (int i = min-1; i >= 1 ; i-=2)
            //{
            //	Console.WriteLine(i);
            //}

            //int[] numbers = new int[3] { 5, 10, 3 };

            //int i = 0;

            //while (i < numbers.Length)
            //{
            //	Console.WriteLine(numbers[i]);
            //	i++;
            //}

            //Random rand = new Random();

            //int secretNumber = rand.Next(1, 11);

            //int userGuess = 0;

            //do
            //{
            //	Console.Write("Rate: ");
            //	userGuess = int.Parse(Console.ReadLine());
            //}

            //while (userGuess != secretNumber);

            //Console.WriteLine("Richtig!");

            //int userGuess = 0;
            //int ergebnis = 0;

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.Write("Gib mir bitte eine Zahl!");
            //    userGuess = int.Parse(Console.ReadLine());
            //    ergebnis += userGuess;
            //}
            //Console.WriteLine("Summe ist: " + ergebnis);

            //int[] numbers = new int[5];

            //int index = 0;

            //int result = 0;

            //while (index < numbers.Length)


            //{

            //    Console.WriteLine("Bitte gib " + (index + 1) + "eine Zahl ein: ");

            //    int input = int.Parse(Console.ReadLine());

            //    numbers[index] = input;

            //    result += input;

            //    index++;
            //}
            //Console.WriteLine("Das Ergebnis ist: " + result + ".");

            //string name = "David";

            //if (name == "David")
            //{
            //    Console.WriteLine("Es ist David");
            //}


            //int age = 16;
            //int height = 140;

            //if (age >= 12 && height >= 140)
            //{
            //    Console.WriteLine("Zutritt gewährt");
            //}
            //else
            //{
            //    Console.WriteLine("Kein Zutritt gewährt");
            //}

            //int number = 11;

            //if (number > 20)
            //{
            //    Console.WriteLine("nummer größer 20"); 
            //}
            //else if (number > 15)
            //{
            //    Console.WriteLine("Nummer größer 10");
            //}
            //else if (number == 11)
            //{
            //    Console.WriteLine("11");
            //}
            //else
            //{
            //    Console.WriteLine("kleiner oder gleich 10");
            //} 


            //for (int i = 0; i<3 ; i++) {

            //    Console.WriteLine("Bitte gib eine Zahl ein");
            //    int zahl = int.Parse(Console.ReadLine());

            //    if (zahl > 0)
            //    {
            //        Console.WriteLine("Positiv");
            //    }
            //    else if (zahl == 0)
            //    {
            //        Console.WriteLine("ist Null");
            //    }
            //    else if (zahl < 0)
            //    {
            //        Console.WriteLine("Negativ");
            //    }
            //}

            //string username = "David";
            //string passwort = "1234";

            //Console.WriteLine("Benutzername bitte:");
            //string userNameInput = Console.ReadLine();

            //if (userNameInput == username)
            //{
            //    Console.WriteLine("Korrekt!");
            //    Console.WriteLine("Bitte nun das Passwort:");


            //    string userPasswort = Console.ReadLine();
            //    if (userPasswort == passwort)
            //    {
            //        Console.WriteLine("Login geglückt!");
            //    }

            //    else
            //    {
            //        Console.WriteLine("Das war leider falsch!");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Das war leider falsch!");
            //} 

            //Console.WriteLine("alter");
            //int age = int.Parse(Console.ReadLine());

            //Console.WriteLine("Student? ja / nein?");
            //string studentInput = Console.ReadLine().ToLower();

            //Console.WriteLine("Gutschein? ja / nein?");
            //string cuponInput = Console.ReadLine().ToLower();


            //bool isStudent = false;
            //bool hasCupon = false;


            //if (studentInput == "ja")
            //{
            //    isStudent = true;
            //}

            //if (cuponInput == "ja")
            //{
            //    hasCupon = true;
            //}

            //if (age >= 18 && age <= 25 && isStudent == true || hasCupon == true)
            //{
            //    Console.WriteLine("Rabatt :-)");
            //}
            //else
            //{
            //    Console.WriteLine("kein Rabatt :-)");
            //}

            int number = 6;

            if (number > 0)
            {
                Console.WriteLine("Größer 0");

                if (number > 5)
                {
                    Console.WriteLine("Größer 5");
                }
            }
            else
            {
                Console.WriteLine("Die Zahl ist exakt 0 oder kleiner");
            }



        }
    }}