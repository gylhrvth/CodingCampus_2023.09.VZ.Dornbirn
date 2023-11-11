using Dimitri.Week03;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dimitri.Week07
{
    internal class FourInRows
    {
        public static void Main()
        {

            string[][] arr = CreateField();
            //PrintField(arr);
            PlayerAction(arr);

        }

        public static string[][] CreateField()
        {
            string[][] arr = new string[6][];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new string[7];
            }

            for (int j = 0; j < arr.Length; j++)
            {


                for (int k = 0; k < arr[j].Length; k++)
                {
                    arr[j][k] = " ";
                }
            }


            return arr;
        }

        public static void PrintField(string[][] arr)
        {
            Console.WriteLine("Four in a Row:");
            Console.WriteLine("-----------------------------");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("|");
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(" {0} |", arr[i][j]);
                }
                Console.WriteLine();
                Console.WriteLine("-----------------------------");
            }
            for (int k = 0; k <= arr.Length; k++)
            {
                Console.Write("  {0} ", k);
            }
            Console.WriteLine();

        }

        public static bool playerTurn = true;

        public static string[][] PlayerAction(string[][] arr)
        {
            PrintField(arr);
            Console.WriteLine("Where you wanna set your stone?(0-9)");
            Console.Write(">>>");
            string playerSymbol = "";
            if (!playerTurn)
            {
                playerSymbol = "0";
                playerTurn = true;
            }
            else if (playerTurn)
            {
                playerSymbol = "X";
                playerTurn = false;
            }
            string input = Console.ReadLine();
            int inputInt = int.MinValue;
            while (true)
            {
                try
                {
                    inputInt = Convert.ToInt32(input);
                }
                catch (FormatException fe)
                {
                    Console.WriteLine("Input not allowed. Type in a number between 0 and 6:");
                    Console.Write(">>>");
                    input = Console.ReadLine();
                }
                if (inputInt > 6 || inputInt < 0)
                {
                    Console.WriteLine("Input not allowed. Type in a number between 0 and 6:");
                    Console.Write(">>>");
                    input = Console.ReadLine();
                }
                else
                {
                    break;
                }
            }

            FindEmptyField(arr, inputInt, playerSymbol);

            PlayerAction(arr);

            return arr;
        }

        public static string[][] FindEmptyField(string[][] arr, int inputPlayer, string playerSymbol)
        {

            int i = arr.Length - 1;
            while (i >= 0)
            {
                if (arr[i][inputPlayer].Contains(" ") == true)
                {
                    arr[i][inputPlayer] = playerSymbol;
                    i = -1;
                }
                else if (arr[0][inputPlayer].Contains(" ") == false)
                {
                    RowFull();
                    return arr;
                }
                i--;
            }
            return arr;

        }

        public static void RowFull()
        {
            Console.WriteLine();
            Console.WriteLine("Row is full please choose a different one!");
            Console.WriteLine();
        }


    }
}
