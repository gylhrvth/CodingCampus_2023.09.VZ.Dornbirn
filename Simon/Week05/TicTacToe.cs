using Simon.Week03;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Simon.Week05
{
    internal class TicTacToe
    {
        public static Random random = new Random();
        public static void Start()
        {
            Console.WriteLine("Aufgabe: TicTacToe");
            //Print2darr(Tic());
            //Print2darr(Tac(Tic()));
            //PrintTicTacToe(Tic());
            //Tac(Tic());
            Toe(Create2darrTic());
        }
        //print TicTacToe
        public static void Toe(int[][] arr)
        {
            while (true)
            {
                PrintTicTacToe(Create2darrTic());
                Tac(Create2darrTic());
                char ask = Readuserinputchar_yn("Möchten Sie noch einmal spielen? (j/n)", "Bitte wähle nur j oder n aus für JA bzw NEIN");
                if (ask == 'n')
                {
                    return;
                }
                else if (ask != 'n' || ask != 'j') //abfrage funktioniert noch nicht ganz
                {

                }
            }


        }

        public static void PrintTicTacToe(int[][] arr)
        {
            //for (int i = 0; i < arr.Length; i++)
            {
                //for (int j = 0; j < arr[i].Length; j++)
                {

                    Console.WriteLine(" ------------- ");

                    Console.WriteLine(" | {0} | {1} | {2} | ", arr[0][0], arr[0][1], arr[0][2]);

                    Console.WriteLine(" ------------- ");

                    Console.WriteLine(" | {0} | {1} | {2} | ", arr[1][0], arr[1][1], arr[1][2]);

                    Console.WriteLine(" ------------- ");

                    Console.WriteLine(" | {0} | {1} | {2} | ", arr[2][0], arr[2][1], arr[2][2]);

                    Console.WriteLine(" ------------- ");
                }
                Console.WriteLine();
            }
        }

        public static int[][] Create2darrTic()
        {
            int[][] arr = new int[3][];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new int[3];
                for (int j = 0; j < arr[i].Length; j++)
                {
                    arr[i][j] = 0;
                }
            }
            return arr;
        }
        public static char Readuserinputchar_yn(string prompt, string error)
        {
            Console.WriteLine(prompt);
            while (true)
            {
                try
                {
                    string input = Console.ReadLine();
                    char output = Convert.ToChar(input);
                    if (output == 'n' || output == 'j')
                    {
                        return output;
                    }
                    else
                    {
                        Console.WriteLine(error);
                    }

                }
                catch
                {
                    Console.WriteLine(error);
                }
            }
        }
        
        public static int[][] Tac(int[][] arr)
        {
            int count = 0;
            int userinput1 = 1;
            int userinput2 = 2;
            int empty = 0;

            System.String warning = "Diese Feld ist schon befüllt versuche ein anderes";

            while (true)
            {
                Userinputint(arr, empty, userinput1, userinput2, count, warning);
                count++;

                if (arr[0][0] == userinput1 && arr[0][1] == userinput1 && arr[0][2] == userinput1 || arr[1][0] == userinput1 && arr[1][1] == userinput1 && arr[1][2] == userinput1 || arr[2][0] == userinput1 && arr[2][1] == userinput1 && arr[2][2] == userinput1 ||
                    arr[0][0] == userinput1 && arr[1][0] == userinput1 && arr[2][0] == userinput1 || arr[0][1] == userinput1 && arr[1][1] == userinput1 && arr[2][1] == userinput1 || arr[0][2] == userinput1 && arr[1][2] == userinput1 && arr[2][2] == userinput1 ||
                    arr[0][0] == userinput1 && arr[1][1] == userinput1 && arr[2][2] == userinput1 || arr[0][2] == userinput1 && arr[1][1] == userinput1 && arr[2][0] == userinput1)

                //if (arr[0][0] == arr[0][1] && arr[0][1] == arr[0][2] || arr[1][0] == arr[1][1] && arr[1][2] == arr[1][1] || arr[2][0] == arr[2][1] && arr[2][2] == arr[2][1] ||
                //    arr[0][0] == arr[1][0] && arr[2][0] == arr[1][0] || arr[0][1] == arr[1][1] && arr[2][1] == arr[1][1] || arr[0][2] == arr[1][2] && arr[2][2] == arr[1][2] ||
                //    arr[0][0] == arr[1][1] && arr[2][2] == arr[1][1] || arr[0][2] == arr[1][1] && arr[0][2] == arr[1][1])
                {
                    Console.WriteLine("Spieler mit der Zahl 1 hat gewonnen!!!");
                    break;
                }
                if (arr[0][0] == userinput2 && arr[0][1] == userinput2 && arr[0][2] == userinput2 || arr[1][0] == userinput2 && arr[1][1] == userinput2 && arr[1][2] == userinput2 || arr[2][0] == userinput2 && arr[2][1] == userinput2 && arr[2][2] == userinput2 ||
                    arr[0][0] == userinput2 && arr[1][0] == userinput2 && arr[2][0] == userinput2 || arr[0][1] == userinput2 && arr[1][1] == userinput2 && arr[2][1] == userinput2 || arr[0][2] == userinput2 && arr[1][2] == userinput2 && arr[2][2] == userinput2 ||
                    arr[0][0] == userinput2 && arr[1][1] == userinput2 && arr[2][2] == userinput2 || arr[0][2] == userinput2 && arr[1][1] == userinput2 && arr[2][0] == userinput2)
                {
                    Console.WriteLine("Spieler mit der Zahl 2 hat gewonnen!!!");
                    break;
                }
                if (count == 9)
                {
                    Console.WriteLine("Es ist ein Unentschieden!");
                    break;
                }
            }
            return arr;
        }

        public static void Userinputint(int[][] arr, int empty, int userinput1, int userinput2, int count, System.String warning)
        {

            int input = Console_Input.Readuserinputint("\nVerwende das Numpad um die Zahl zu plazieren. 7 entspricht hierbei links oben!", "Verwende das Numpad um die Zahl zu plazieren. 7 entspricht hierbei links oben!", 1, 9);
            input -= 1;
            if (count % 2 == 0)
            {
                if (arr[input % 3][input / 3] == empty)
                {
                    arr[input % 3][input / 3] = userinput1;
                    PrintTicTacToe(arr);
                }
                else
                {
                    Console.WriteLine(warning);
                }
            }
            else
            {
                if (arr[input % 3][input / 3] == empty)
                {
                    arr[input % 3][input / 3] = userinput2;
                    PrintTicTacToe(arr);
                }
                else
                {
                    Console.WriteLine(warning);
                }

            }
        }






    }
}
