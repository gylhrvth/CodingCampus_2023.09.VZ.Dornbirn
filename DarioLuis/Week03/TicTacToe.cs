namespace DarioLuis.Week03
{
    class TicTacToe
    {
        static char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static int player = 1; // Spieler 1 startet
        static int choice; // Die Wahl des Spielers

        // Überspringt die Anfangsanweisungen
        public static void Main(string[] args)
        {
            bool doExit = false;
            do
            {
                Solutions();
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
                    choice = int.Parse(Console.ReadLine());
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
                Solutions();
            }
            while (!doExit);

            Console.ReadLine();
        }

        // Board zeigt Brett Status an
        private static void Board()
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[1], arr[2], arr[3]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[4], arr[5], arr[6]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[7], arr[8], arr[9]);
            Console.WriteLine("     |     |      ");
        }
        public static void Solutions()
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
                Console.WriteLine("Jemand hat gewonnen");
            }
            else
            {
                Console.WriteLine("Es hat noch keiner gewonnen!!");
            }
        }
    }
}


