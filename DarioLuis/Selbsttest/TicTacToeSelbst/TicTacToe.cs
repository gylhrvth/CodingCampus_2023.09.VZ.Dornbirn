using System.ComponentModel.Design;

namespace DarioLuis.Selbsttest.TicTacToeSelbst
{
    public class TicTacToeSelbst
    {
        public static int ReadNumber(string msg)
        {
            int result = 0;
            Console.WriteLine(msg);
            string line = Console.ReadLine();
            result = int.Parse(line);
            return result;
        }

        static char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static char[] arr2 = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static int player = 1;
        static int player2 = 1;
        static int choice;
        public static void Start()
        {
            String input = "";
            bool isGameOver = false;
            do
            {
                while (!isGameOver)
                {
                    Hello();
                    Console.Clear();
                    Console.WriteLine("Spieler 1 = X und Spieler 2 = O");
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
                    PrintBoard();
                    Solutions();

                    //Überprüft welcher Spieler gewonnen hat
                    if (player % 2 == 0)
                    {
                        choice = ReadNumb("Spieler 2 wähle bitte ein Feld!(1-9)");
                        if (arr[choice] != 'X' && arr[choice] != 'O')
                        {
                            arr[choice] = 'O';
                            player++;
                        }
                        else
                        {
                            Console.WriteLine("Leider ist das Feld {0} schon mit einem {1} belegt.", choice, arr[choice]);
                            Console.WriteLine("\n");
                        }
                    }
                    else
                    {
                        int choice = ReadNumb("Spieler 1 wähle bitte ein Feld!(1-9)");
                        if (arr[choice] != 'X' && arr[choice] != 'O')
                        {
                            arr[choice] = 'X';
                            player++;
                        }
                        else
                        {
                            Console.WriteLine("Leider ist das Feld {0} schon mit einem {1} belegt.", choice, arr[choice]);
                            Console.WriteLine("\n");
                        }
                    }
                    PrintBoard();
                    isGameOver = Solutions();
                }
                Console.WriteLine("Magst du nochmal spielen?(Y/Yes|N/No)");
                input = Convert.ToString(Console.ReadLine().ToUpper());
                if (input == "Y")
                {
                    isGameOver = false;
                    arr = MakeACopyAlt(arr2);
                    player = player2;
                    PrintBoard();
                }

            }
            while (input == "Y");

        }

        public static void Hello()
        {
            Console.WriteLine("Hallo, das ist TicTacToe für 2 Spieler.");
            Console.WriteLine("Regeln:");
            Console.WriteLine("Ihr seid immer abwechselnd dran.");
            Console.WriteLine("Der Spieler der als erstens 3 in einer Reihe hat gewinnt.(Diagonal, Horizontal, Vertikal)");
            Console.WriteLine();
        }
        public static bool Solutions()
        {
            if (
                    ((arr[7] == arr[4]) && (arr[4] == arr[1]))      //Vertikal 7 - 1
                ||  ((arr[8] == arr[5]) && (arr[5] == arr[2]))      //Vertikal 8 - 2
                ||  ((arr[9] == arr[6]) && (arr[6] == arr[3]))      //Vertikal 9 - 3
                ||  ((arr[7] == arr[8]) && (arr[8] == arr[9]))      //Horizontal 7 - 9
                ||  ((arr[4] == arr[5]) && (arr[5] == arr[6]))      //Horizontal 4 - 6
                ||  ((arr[1] == arr[2]) && (arr[2] == arr[3]))      //Horizontal 1 - 3
                ||  ((arr[7] == arr[5]) && (arr[5] == arr[3]))      //Diagonal 7 - 3
                ||  ((arr[1] == arr[5]) && (arr[5] == (arr[9])))    //Diagonal 1 - 9
               )
            {
                if (player % 2 == 0)
                {
                    Console.WriteLine("Spieler 2 hat gewonnen.");
                }
                else
                {
                    Console.WriteLine("Spieler 1 hat gewonnen.");
                }return true;
            }
            else
            {
                Console.WriteLine("Es hat noch keiner gewonnen!!");
                return false;
            }
        }
        

        public static void PrintBoard()
        {

            

            Console.WriteLine(" _________________");
            Console.WriteLine("|     |     |     |");
            Console.WriteLine("|  {0}  |  {1}  |  {2}  |", arr[7], arr[8], arr[9]);
            Console.WriteLine("|_____|_____|_____|");
            Console.WriteLine("|     |     |     |");
            Console.WriteLine("|  {0}  |  {1}  |  {2}  |", arr[4], arr[5], arr[6]);
            Console.WriteLine("|_____|_____|_____|");
            Console.WriteLine("|     |     |     |");
            Console.WriteLine("|  {0}  |  {1}  |  {2}  |", arr[1], arr[2], arr[3]);
            Console.WriteLine("|_____|_____|_____|");


        }
        static int ReadNumb(String Message)
        {
            while (true)
            {
                Console.WriteLine(Message);
                try
                {
                    String input = Console.ReadLine();
                    int ourNumb = Convert.ToInt32(input);
                    if (ourNumb >= 1 && ourNumb <= 9)
                    {
                        return ourNumb;
                    }
                    else
                    {
                        Console.WriteLine("Gib bitte eine Gültige Zahl zwischen 1-9 ein.");
                    }
                }
                catch (FormatException fe)
                {
                    Console.WriteLine("Gib bitte eine Gültige Zahl zwischen 1-9 ein.");
                }
                catch (OverflowException ofe)
                {
                    Console.WriteLine("Gib bitte eine Gültige Zahl zwischen 1-9 ein.");
                }
            }
        }
        public static int OutOfRange(string msg)
        {
            int res = 0;
            Console.WriteLine(msg);
            string line = Console.ReadLine();
            try
            {
                res = int.Parse(line);
            }
            catch (IndexOutOfRangeException iof)
            {
                Console.WriteLine("Gib bitte eine Gültige Zahl zwischen 1-9 ein.");
            }
            return res;
        }
        public static char[] MakeACopyAlt(char[] original)
        {
            char[] myArray = new char[original.Length];

            for (int i = 0; i < original.Length; i++)
            {
                myArray[i] = original[i];
            }
            return myArray;
        }
    }
}
