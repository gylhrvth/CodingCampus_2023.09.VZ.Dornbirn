using System.Data;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace DarioLuis.Week03
{
    class TicTacToe
    {

        public static int ReadNumber(string msg)
        {
            int result = 0;
            Console.WriteLine(msg);
            string line = Console.ReadLine();
            result = int.Parse(line);
            return result;
        }
        public static int OutofRange(string msg)
        {
            int res = 0;
            Console.WriteLine(msg);
            string line = Console.ReadLine();
            try
            {
                res = int.Parse(line);
            }catch (IndexOutOfRangeException iof)
            {
                Console.WriteLine("Bitte eine Zahl eingeben zwischen 1-9!!");
            }

            return res;
        }

        public static char[] makeACopyAlt(char[] original)
        {
            char[] myArray = new char[original.Length];

            for (int i = 0; i < original.Length; i++)
            {
                myArray[i] = original[i];
            }

            return myArray;

        }

        static char[] arr2 = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static int player = 1; // Spieler 1 startet
        static int player2 = 1;
        static int choice; // Die Wahl des Spielers

        // Überspringt die Anfangsanweisungen
        public static void Start()
        {
            String input = "";
            bool isGameOver = false;
            do
            {
                while (!isGameOver)
                {
                    Console.Clear();
                    Console.WriteLine("Spieler 1: X und Spieler 2: O");
                    Console.WriteLine("\n");
                    if (player % 2 == 0)
                    {
                        Console.WriteLine("Spieler 2 ist an der Reihe");
                    }
                    else
                    {
                        Console.WriteLine("Spieler 1 ist an der Reihe");
                    }
                    Console.WriteLine("\n");
                    Board();
                    Solutions();

                    // Überprüfung, welcher Spieler gewonnen hat
                    if (player % 2 == 0)
                    {
                        choice = int.Parse(Console.ReadLine());
                        if (arr[choice] != 'X' && arr[choice] != 'O')
                        {
                            
                            arr[choice] = 'O';
                            player++;
                            
                        }
                        else
                        {
                            Console.WriteLine("Leider ist die Zeile {0} bereits mit einem {1} belegt.", choice, arr[choice]);
                            Console.WriteLine("\n");
                        }
                    }
                    else
                    {
                        int choice = Convert.ToInt32(Console.ReadLine());
                        if (arr[choice] != 'X' && arr[choice] != 'O')
                        {
                            
                            arr[choice] = 'X';
                            player++;
                        }
                        else
                        {
                            Console.WriteLine("Leider ist die Zeile {0} bereits mit einem {1} belegt.", choice, arr[choice]);
                            Console.WriteLine("\n");
                        }

                    }
                    Board();
                    isGameOver = Solutions();
                }
                Console.WriteLine("Magst du nochmal spielen? (Y/Yes),(N/No");
                input = Convert.ToString(Console.ReadLine().ToUpper());
                if (input == "Y")
                {
                    isGameOver = false;
                    arr = makeACopyAlt(arr2);
                    player = player2; // Spieler 1 startet
                    Board();

                }
            }
            while (input == "Y");
            
        }

        // Board zeigt Brett Status an
        private static void Board()
        {

            Console.WriteLine("     |     |      ");
            if (arr[1] == 'X')
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            if (arr[1] == 'O')
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            Console.Write("  {0}", arr[1]);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("  |  ");
            if (arr[2] == 'X')
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            if (arr[2] == 'O')
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            Console.Write("{0}", arr[2]);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("  |  ");
            if (arr[3] == 'X')
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            if (arr[3] == 'O')
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            Console.WriteLine("{0}", arr[3]);
            Console.ForegroundColor= ConsoleColor.White;
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            if (arr[4] == 'X')
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            if (arr[4] == 'O')
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            Console.Write("  {0}  ", arr[4]);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("| ");
            if (arr[5] == 'X')
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            if (arr[5] == 'O')
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            Console.Write(" {0} ", arr[5]);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" | ");
            if (arr[6] == 'X')
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            if (arr[6] == 'O')
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }

            Console.WriteLine(" {0} ", arr[6]);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("_____|_____|_____ ");

            Console.WriteLine("     |     |      ");
            if (arr[7] == 'X')
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            if (arr[7] == 'O')
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            Console.Write("  {0}", arr[7]);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("  | ");
            if (arr[8] == 'X')
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            if (arr[8] == 'O')
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            Console.Write(" {0}", arr[8]);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("  |");
            if (arr[9] == 'X')
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            if (arr[9] == 'O')
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            Console.WriteLine("  {0}", arr[9]);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("     |     |      ");
        }

        

    public static bool Solutions()
        {
            
            if (((arr[1] == arr[5]) && (arr[5] == arr[9]))    //Diagonale 1 bis 9
            || ((arr[3] == arr[5]) && (arr[5] == arr[7]))     //Diagonale 3 bis 7
            || ((arr[1] == arr[4]) && (arr[4] == arr[7]))     //Abwärts 1 bis 7
            || ((arr[2] == arr[5]) && (arr[5] == arr[8]))     //Abwärts 2 bis 8
            || ((arr[3] == arr[6]) && (arr[6] == arr[9]))     //Abwärts 3 bis 9
            || ((arr[1] == arr[2]) && (arr[2] == arr[3]))     //Horizontal von 1 bis 3
            || ((arr[4] == arr[5]) && (arr[5] == arr[6]))     //Horizontal von 4 bis 6
            || ((arr[7] == arr[8]) && (arr[8] == arr[9])))   //Horizontal von 7 bis 9
            {
                if (player % 2 == 0)
                {
                    Console.WriteLine("Spieler 2 hat gewonnen");
                }
                else
                {
                    Console.WriteLine("Spieler 1 hat gewonnen");
                }
                return true;
            }
            else
            {
                Console.WriteLine("Es hat noch keiner gewonnen!!");
                return false;
            }
        }
    }
}


