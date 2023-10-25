namespace DarioLuis.Week05
{


    class CarGame
    {
        static int playfieldWidth = 30;
        static int roadWidth = 10;
        static int roadLeftBoundary = (playfieldWidth - roadWidth) / 2;
        static int carPosition = roadLeftBoundary + roadWidth / 2;
        static int score = 0;
        static bool isGameOver = false;
        static List<int> obstacles = new List<int>();
        static Random random = new Random();

        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WindowWidth = playfieldWidth;
            Console.BufferWidth = playfieldWidth;
            Console.WindowHeight = 20;

            while (!isGameOver)
            {
                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey(intercept: true).Key;

                    switch (key)
                    {
                        case ConsoleKey.LeftArrow:
                            if (carPosition > roadLeftBoundary)
                            {
                                carPosition--;
                            }
                            break;

                        case ConsoleKey.RightArrow:
                            if (carPosition < roadLeftBoundary + roadWidth - 1)
                            {
                                carPosition++;
                            }
                            break;

                        case ConsoleKey.Q:
                            isGameOver = true;
                            break;
                    }
                }

                Console.Clear();
                DrawPlayfield();
                UpdateGame();
                Thread.Sleep(100);
            }

            Console.Clear();
            Console.SetCursorPosition(playfieldWidth / 2 - 5, Console.WindowHeight / 2);
            Console.WriteLine("Game Over");
            Console.SetCursorPosition(playfieldWidth / 2 - 7, Console.WindowHeight / 2 + 1);
            Console.WriteLine("Score: " + score);
        }

        static void DrawPlayfield()
        {
            for (int row = 0; row < Console.WindowHeight; row++)
            {
                for (int col = 0; col < playfieldWidth; col++)
                {
                    if (col >= roadLeftBoundary && col < roadLeftBoundary + roadWidth)
                    {
                        Console.SetCursorPosition(col, row);
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.SetCursorPosition(col, row);
                        Console.Write("█");
                    }
                }
            }

            Console.SetCursorPosition(carPosition, Console.WindowHeight - 1);
            Console.Write("█");

            foreach (var obstacle in obstacles)
            {
                Console.SetCursorPosition(obstacle, 0);
                Console.Write("█");
            }

            Console.SetCursorPosition(0, Console.WindowHeight - 1);
            Console.Write("█");
            Console.SetCursorPosition(playfieldWidth - 1, Console.WindowHeight - 1);
            Console.Write("█");
        }

        static void UpdateGame()
        {
            if (score % 10 == 0)
            {
                // Increase game speed periodically
                MoveObstacles();
                GenerateObstacle();
            }

            score++;
        }

        static void MoveObstacles()
        {
            for (int i = 0; i < obstacles.Count; i++)
            {
                obstacles[i]++;
                if (obstacles[i] >= Console.WindowHeight - 1)
                {
                    obstacles.RemoveAt(i);
                    i--;
                }
            }
        }

        static void GenerateObstacle()
        {
            if (random.Next(0, 100) < 10)
            {
                int obstaclePosition = random.Next(roadLeftBoundary, roadLeftBoundary + roadWidth);
                obstacles.Add(obstaclePosition);
            }
        }
    }
}