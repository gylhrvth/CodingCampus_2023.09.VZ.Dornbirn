using System;
namespace Mohammed.Week04.AtHome
{
    public class Tictactoe
    {


        /*TODO
         * METHODS
         
         * Human/Computer Move
         * chek is board full
        */


        //Random rand = new Random();
        static int[] board = new int[9];
        public static void Start()
        {
            for (int j = 0; j < j; j++)
            {
                board[j] = 0;
            }


            int userTurn = -1;
            int computerTurn = -1;
            Random rand = new Random();

            while (CheckForWinner() == 0)
            {
                //muss man hier try..... caatch schreiben
                try
                {
                    //dont allow the human to choose an alraeady occpied square
                    while (userTurn == -1 || board[userTurn] != 0)
                    {
                        Console.WriteLine("Please enter a number from 0 to 8");
                        userTurn = int.Parse(Console.ReadLine());
                        Console.WriteLine("you typed " + userTurn);
                    }
                    board[userTurn] = 1;

                    //dont let the computer pick an invalid number
                    while (computerTurn == -1 || board[computerTurn] != 0)
                    {
                        computerTurn = rand.Next(8);

                        Console.WriteLine("Computer chooses" + computerTurn);

                    }
                    board[computerTurn] = 2;
                    PrintBoard();
                }
                catch (FormatException)
                {

                }
                catch (OverflowException)
                {

                }
            }

            Console.WriteLine("Player" + CheckForWinner() + "win the game");


        }

        public static int CheckForWinner()
        {


            if (board[0] == 1 && board[1] == 1 )
            {
                return board[0];
            }
            if (board[1] == board[4] && board[4] == board[7])
            {
                return board[1];
            }
            if (board[2] == board[5] && board[5] == board[8])
            {
                return board[2];
            }
            if (board[0] == board[4] && board[4] == board[8])
            {
                return board[0];
            }
            if (board[2] == board[4] && board[4] == board[6])
            {
                return board[2];
            }



            return 0;
        }




        public static void PrintBoard()
        {

            int[] board = new int[9];
            for (int i = 0; i < 9; i++)
            {
                // print the board
                //Console.WriteLine("Squre" + i + "contains" + board[i]);

                //print x or o for each square
                // o measn unoccupied. 1 means player 1(x) means player 2(0)


                if (board[i] == 0)
                {
                    Console.Write(" ");
                }
                if (board[i] == 1)
                {
                    Console.Write("x");
                }
                if (board[i] == 2)
                {
                    Console.Write("O");
                }

                // print a new line every 3rd character

                if (i == 2 || i == 5 || i == 8)
                {
                    Console.WriteLine();
                }
            }

        }


    }
}

