﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Patrick.Week03
{
    internal class Arraytry
    {
        public static void start()
        {
            //try1();
            //Console.WriteLine("-----------------");
            //counterUp();
            //Console.WriteLine("-----------------");
            //addition();
            //Console.WriteLine("-----------------");
            //forEachSchleifeInteger();
            //Console.WriteLine("-----------------");
            //forEachSchleifeString();
            //Console.WriteLine("-----------------");
            //forSchleife();
            //Console.WriteLine("-----------------");
            //WhileSchleife(18);
            //Console.WriteLine("-----------------");
            //additionUdemy();
            //Console.WriteLine("-----------------");
            //WhileqQuiz();
            //Console.WriteLine("-----------------");
            //additionSelfTry(5);
            //Console.WriteLine("-----------------");
            //tryIfElse(5);
            //Console.WriteLine("-----------------");
            //tryIfElseString();
        }


        public static int[] try1()
        {

            int[] numbers = new int[6];

            numbers[0] = 300;
            numbers[1] = 200;
            numbers[2] = 900;
            numbers[3] = 10;
            numbers[4] = 5;
            numbers[5] = 700;


            //foreach(int i in numbers)
            //{
            //    Console.Write(i +" ");
            //}

            Array.Sort(numbers);    // sortiert den Array nach der Zahlengröße

            foreach (int i in numbers)
            {
                Console.Write(i + " ");
            }


            Console.WriteLine();
            for (int x = 0; x < numbers.Length; x++)
            {
                Console.WriteLine("{0}. = {1}", x, numbers[x]);
            }
            return numbers;
        }

        public static int[] counterUp()
        {

            int[] counter = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

            for (int x = 0; x < counter.Length; x++)
            {
                Console.WriteLine("dies ist mein counter: {0}  dies ist meine Zahl: {1} ", x, counter[x]);
            }
            return counter;
        }

        public static int[] addition()
        {
            int[] numbers = { 10, 6, 30, 78 };

            int summe = numbers[0] + numbers[1] + numbers[2] + numbers[3];

            Console.WriteLine(summe);

            return numbers;
        }


        public static void forEachSchleifeInteger()
        {

            int[] numbers = new int[] { 50, 200, 75 };

            int result = 0;

            numbers[0] = 100;
            foreach (int n in numbers)
            {

                result += n;

            }
            Console.Write("Die SUMME davon ist: " + result);

        }

        public static void forEachSchleifeString()
        {
            string[] names = new string[5] { "Jannik", "Simon", "Herbert", "Hubert", "Daniel" };

            foreach (string name in names)
            {

                Console.WriteLine(name);
            }
        }

        public static void forSchleife()
        {
            int maxnumber = 10;

            ////Schleife steigend
            for (int x = 0; x <= maxnumber; x += 2)
            {
                Console.WriteLine(x);

            }

            ////Schleife fallend
            for (int x = maxnumber; x >= 0; x -= 2)
            {
                Console.WriteLine(x);

            }
        }

        public static void WhileSchleife(int size)
        {

            //whileSchleife mit Array
            int[] numbers = { 3, 10, -3, 5, 6, 88 };
            int[] num2 = new int[size];
            for (int i = 0; i < num2.Length; i++)
            {
                num2[i] = i + 1;
            }
            Console.WriteLine("[{0}]", string.Join(", ", num2));



            int y = 0;

            while (y < numbers.Length)
            {
                Console.WriteLine(numbers[y]);
                y++;

            }
        }

        public static void additionSelf()
        {
            int[] numbers = new int[5];

            int index = 0;

            int result = 0;

            while (index < numbers.Length)
            {
                Console.WriteLine("Bitte gib die " + (index + 1) + ". Zahl ein: ");

                int input = int.Parse(Console.ReadLine());

                numbers[index] = input;

                result += input;

                index++;
            }

            Console.WriteLine("Dein Ergebnis:" + result);
        }


        public static void WhileqQuiz()
        {
            Random randomNumber = new Random();                         // eine Variable von einer zufälligen Zahl erstellen

            int secretNumber = randomNumber.Next(1, 11);                 // eine Range der Zahl zwischen 1 und 10 definieren 

            int userGuess = 0;

            while (userGuess != secretNumber)
            {
                Console.Write("Geben Sie eine Zahl zwischen 1 und 10 ein und gewinne: ");
                userGuess = int.Parse(Console.ReadLine());              // erstellt eine Variable die vom Benutzer durch Eingabe in der Console erstellt wird

                if (userGuess != secretNumber)
                {
                    Console.WriteLine("Das war leider falsch, versuche es doch nocheinmal");
                }
                else
                {
                    Console.WriteLine("GRATULATION!!!!!! Das war richtig");
                }

            }
        }


        public static int[] additionSelfTry(int counter)
        {

            int[] summand = new int[counter];

            int result = 0;

            for (int x = 0; x < summand.Length; x++)
            {
                Console.WriteLine("Geben Sie die " + (x + 1) + ". Zahl ein:");
                int input = int.Parse(Console.ReadLine());
                summand[x] = input;
                result += input;
            }
            Console.Write("Dein Ergebnis ist: " + result);

            return summand;

        }

        public static void tryIfElse(int count)
        {

            for (int x = 0; x < count; x++)
            {
                int input = int.Parse(Console.ReadLine());

                if (input == 0)
                {
                    Console.WriteLine("Du hast die Zahl " + input + " eingegeben");
                }
                else if (input <= 0)
                {
                    Console.WriteLine("Du hast die negative Zahl" + input + " eingegeben");
                }
                else
                {
                    Console.WriteLine("Du hast die positive Zahl" + input + " eingegeben");

                }
            }
        }

        public static string tryIfElseString()
        {
            string userName = "Patrick Mair";
            string password = "AsDfGh";

            Console.Write("geben Sie den Benutzername ein: ");
            string inputUsername = Console.ReadLine();
            Console.WriteLine("geben Sie nun das Passwort ein");
            string inputPassword = Console.ReadLine();

            if (inputUsername == userName && inputPassword == password)
            {
                Console.WriteLine("Sie sind nun eingeloggt");
            }
            else if (inputPassword != password)
            {
                Console.WriteLine("Das Passwort stimmt nicht");
            }
            else
            {
                Console.WriteLine("Der Benutzername stimmt nicht");
            }

            return userName;
        }

    }
}