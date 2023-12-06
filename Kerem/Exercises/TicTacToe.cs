using Kerem.Selbsttest;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kerem.Exercises
{
    internal class TicTacToe
    {
        //the playfield
        static char[,] playField =
        {
            {'1','2','3'},    //Row 0
            {'4','5','6'},    //Row 1
            {'7','8','9'}     //Row 2
        };
    
        static int turns = 0;
        public static void Start()
        {
            int player = 2; //Player 1 starts
            int input = 0;
            bool inputCorrect = true;

            //Run code as long as the program runs
            do
            {
                if (player == 2)
                {
                    player = 1;
                    EnterXorO('X', input);
                }
                else if (player == 1)
                {
                    player = 2;
                    EnterXorO('O', input);
                }

                SetField();
              

            } while (true);
        }
        public static void ResetField()
        {
            char[,] playFieldInital =
            {
            {'1','2','3'},    //Row 0
            {'4','5','6'},    //Row 1
            {'7','8','9'}     //Row 2
            };
            playField = playFieldInital;
            SetField();
            turns = 0;
        }
        public static void SetField()
        {
            Console.Clear();
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", playField[0, 0], playField[0, 1], playField[0, 2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |    ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", playField[1, 0], playField[1, 1], playField[1, 2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", playField[2, 0], playField[2, 1], playField[2, 2]);
            Console.WriteLine("     |     |     ");
            turns++;

        }
        public static void EnterXorO(char playerSign, int input)
        {
  

            switch (input)
            {
                case 1: playField[0, 0] = playerSign; break;
                case 2: playField[0, 1] = playerSign; break;
                case 3: playField[0, 2] = playerSign; break;
                case 4: playField[1, 0] = playerSign; break;
                case 5: playField[1, 1] = playerSign; break;
                case 6: playField[1, 2] = playerSign; break;
                case 7: playField[2, 0] = playerSign; break;
                case 8: playField[2, 1] = playerSign; break;
                case 9: playField[2, 2] = playerSign; break;


            }
        }
    }
}
