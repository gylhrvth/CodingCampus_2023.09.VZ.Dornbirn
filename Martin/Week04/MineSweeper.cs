using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martin.Week04
{
    internal class MineSweeper
    {

        public static void StartMineSweeper()
        {

            bool GameOver = false;

            Console.WriteLine("Willkommen zum Feld errate Spiel!");
            Console.WriteLine("Wähle eine 0 und siehe was sich dahinter versteckt, du darfst keine 7 finden! ;(");

            Console.WriteLine();

 
  

            Console.WriteLine("Start game? Y/N");
            string symbol = Convert.ToString(Console.ReadLine());

            if (symbol.ToUpper() != "Y")
            {
                Console.WriteLine("Aufwiedersehen!");
                return;
            }

            Console.WriteLine("How big should the game field be?");
            int size = Convert.ToInt32(Console.ReadLine());
            int[][] gameField = CreateGameField(size);
            int EvilNumberPos = GenarateTheEvil7(1, gameField.Length, gameField); //create the evil 7!
            Console.WriteLine(gameField[EvilNumberPos][EvilNumberPos]);

            while (GameOver == false)
            {

                try
                {


                    Console.WriteLine();

                    RefreshGameField(gameField);

                    Console.WriteLine();


                    while (GameOver == false && symbol.ToUpper() == "Y" || symbol.ToUpper() == "YES")
                    {

                        try
                        {


                            Console.WriteLine("Gib die Spalte ein {0} bis {1}", 1, gameField.Length);
                            int guessrow = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Gib die Stelle der Spalte ein {0} bis {1}", 1, gameField.Length);
                            int guessCol = Convert.ToInt32(Console.ReadLine());

                            if(guessCol < 0 || guessrow < 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine("Die Zahl ist zu klein!!");
                                Console.ResetColor();
                            }
                            else if(guessCol > gameField.Length || guessrow > gameField.Length)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Die Zahl ist zu groß!!");
                                Console.ResetColor();
                            }

                            Console.Clear();

                            PlaceInput(guessrow, guessCol, gameField, EvilNumberPos); //place the number who put in the User

                            RefreshGameField(gameField); //refresh game field show current game



                        }
                        catch (FormatException ex)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Eine Zahl bitte eingeben!");
                            Console.ResetColor();
                        }
                    }


                }


                catch (FormatException fe)
                {
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("Du musst eine zahl eingeben!");

                    Console.ResetColor();
                }


            }


        }


       public static void RefreshGameField(int[][] field)
        {

            Console.WriteLine();

            for (int row = 1; row < field.Length; row++)
            {
                for (int col = 1; col < field[row].Length; col++)
                {
                    Console.Write(field[row][col] + " ");
                }
                Console.WriteLine();
            }
        }
 
       public static int[][] CreateGameField(int size)
        {
            //create GameField 2d
            int[][] arr2d = new int[size][];


            for (int row = 0; row < arr2d.Length; row++)
            {
                arr2d[row] = new int[size]; //create sizeXsize game
            }

            return arr2d;
        }

       public static void PlaceInput(int row, int col, int[][] gamefield, int EvilPos)
        {
            if (gamefield[row][col] == EvilPos)
            {
                Console.WriteLine("Verloren");
                gamefield[row][col] = 7;

                Console.ForegroundColor = ConsoleColor.Red;
            }
            else if (gamefield[row][col] == 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Du hast hier schon etwas eingefüllt.");


                Console.ResetColor();
            }

            gamefield[row][col] = 1;

        }

       public static int GenarateTheEvil7(int min, int max, int[][] gamefield)
        {
            Random rand = new Random();
            int EvilNumber = gamefield[rand.Next(min)][rand.Next(max)];


            return EvilNumber;
        }

    }
}
