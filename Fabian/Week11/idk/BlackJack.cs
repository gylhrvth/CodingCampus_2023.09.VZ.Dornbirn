namespace Fabian.Week11.idk
{
    internal class BlackJack
    {
        const double initialMoney = 100.00;

        private readonly static Random rnd = new();
        static string skillLevel, name, nickName;
        static string role = "Player";
        static int age, totalGamesPlayed;
        static int playerTotalCardScore = 0;
        static int dealerTotalCardScore = 0;
        static double money = initialMoney;
        static double bettingAmount;


        public static void Start()
        {
            Console.Title = "Blackjack";
            GetUserInfo();
            BlackJackGame();
        }

        private static void BlackJackGame()
        {
            PrintMenuInfo();
            Console.WriteLine("\nPlease type in menu option: ");
            string menuOption = Console.ReadLine();

            switch (menuOption)
            {
                case "1":
                    dealerTotalCardScore = 0;
                    playerTotalCardScore = 0;

                    GetPlayerBet();

                    Console.WriteLine("Shuffling the deck..");
                    Console.WriteLine("Done shuffling the deck.");
                    Console.WriteLine("Serving the cards.\n");


                    HitCard();
                    HitCard();
                    HitCard("Dealer");
                    HitCard("Dealer");

                    Console.WriteLine($"\nYour total score is: {playerTotalCardScore}. Would you like to get served another card?\n1. Yes\n2. No");
                    string shouldDeal = Console.ReadLine();
                    if (shouldDeal == "1")
                    {
                        HitCard();
                    }

                    SetConsoleColor(ConsoleColor.Cyan, $"Your total score is {playerTotalCardScore}.");

                    if (playerTotalCardScore > 21)
                    {
                        SetConsoleColor(ConsoleColor.Red, $"Your score is above 21. You lost!!! you lost {bettingAmount}$");
                        money -= bettingAmount;
                        Restart();
                    }

                    HitCard("Dealer");
                    SetConsoleColor(ConsoleColor.Yellow, $"Dealer's total score is {dealerTotalCardScore}\n");

                    if (playerTotalCardScore <= dealerTotalCardScore)
                    {
                        SetConsoleColor(ConsoleColor.Red, $"You lost!!! you lost {bettingAmount}$");
                        money -= bettingAmount;
                        Restart();
                    }
                    SetConsoleColor(ConsoleColor.Green, $"Congratulations!!!! You won {bettingAmount}$ :)");
                    Restart();
                    break;

                case "2":
                    Console.WriteLine("Are you sure you want to reset your stats?\n1. Yes\n2. No");
                    string answer = Console.ReadLine();
                    if (answer == "1")
                    {
                        ResetStats();

                    }
                    Restart();
                    break;

                case "3":
                    AddBalance();
                    Restart();
                    break;
                case "4":
                    Console.WriteLine("Bye! :)");
                    return;
            }
        }

        private static void AddBalance()
        {
            try
            {
                Console.Write("How much money would you like to add? ");
                money += int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("only numbers!!!");
                AddBalance();
            }
            catch (OverflowException)
            {
                Console.WriteLine("number is too high!!!");
                AddBalance();
            }


        }

        private static void GetPlayerBet()
        {
            SetConsoleColor(ConsoleColor.Cyan, $"How much money do u want to bet?");
            SetConsoleColor(ConsoleColor.Green, $"(current money: {money}$): ");
            try
            {
                bettingAmount = int.Parse(Console.ReadLine());

                if (bettingAmount > money)
                {
                    SetConsoleColor(ConsoleColor.Red, "You dont have that much money!!!");
                    GetPlayerBet();
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("only enter numbers!!!");
                GetPlayerBet();

            }
            catch (OverflowException)
            {
                Console.WriteLine("number is too high!!!");
                GetPlayerBet();
            }
        }

        private static void HitCard(string role = "Player")
        {
            int cardScore = rnd.Next(1, 10);

            if (role == "Player")
            {
                playerTotalCardScore += cardScore;
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write($"{role} is drawing a card.. ");

            }
            else
            {
                if (dealerTotalCardScore + cardScore > 21)
                {
                    cardScore = 21 - dealerTotalCardScore;
                }
                dealerTotalCardScore += cardScore;
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write($"{role} is drawing a card.. ");
            }
            Thread.Sleep(1000);
            Console.WriteLine($"Card score is {cardScore}");
            Console.ResetColor();
        }

        private static void ResetStats()
        {
            totalGamesPlayed = 0;
            money = initialMoney;
            skillLevel = "Beginner";

            Console.WriteLine("Stats were reset!");
        }

        private static void GetUserInfo()
        {
            Console.Write("Please enter your name: ");
            name = Console.ReadLine();
            Console.Write("Please enter your age: ");
            age = int.Parse(Console.ReadLine());
            Console.Write("Please enter a nickname: ");
            nickName = Console.ReadLine();
            Console.Write("Enter how many games you have played so far: ");
            totalGamesPlayed = int.Parse(Console.ReadLine());

            if (totalGamesPlayed < 50)
                skillLevel = "Beginner";
            else if (totalGamesPlayed < 100)
                skillLevel = "Intermediate";
            else if (totalGamesPlayed < 150)
                skillLevel = "Advanced";
            else
                skillLevel = "Expert";
        }

        private static void PrintMenuInfo()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("  .-----------. ");
            Console.WriteLine(" /------------/|");
            Console.WriteLine("/.-----------/||");
            Console.WriteLine("| ♥       ♥  |||");
            Console.WriteLine("| Blackjack  |||");
            Console.WriteLine("|            |||");
            Console.WriteLine("|     ♥      |||");
            Console.WriteLine("|            |||");
            Console.WriteLine("|            |||");
            Console.WriteLine("| ♥       ♥  ||/");
            Console.WriteLine("\\-----------./  ");
            Console.WriteLine();
            Console.ResetColor();
            Console.WriteLine("--------------------------------------------------------------------------------------");
            Console.WriteLine($"| {skillLevel} | {role} | {name} {age} |  {nickName} |");
            Console.WriteLine("--------------------------------------------------------------------------------------");
            Console.WriteLine($"Hello {name}");
            Console.WriteLine($"{name}, your money count is: {money}$");
            Console.WriteLine("1. New game");
            Console.WriteLine("2. Reset stats");
            Console.WriteLine("3. Add money to balance");
            Console.WriteLine("4. Exit");
        }

        private static void SetConsoleColor(ConsoleColor color, string text)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();
        }

        private static void Restart()
        {
            SetConsoleColor(ConsoleColor.Magenta, "\nPress any key to continue");
            Console.ReadKey();
            BlackJackGame();
        }
    }
}
