using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kerem.Exercises
{
    internal class IfStatement
    {
        static int highscore = 300;
        static string highscorePlayer = "Kerem";
        public static void Start()
        {
            CheckHighscore(250, "Lisa");
            CheckHighscore(315, "Ben");
            CheckHighscore(350, "Tim");
        }

        public static void CheckHighscore(int score, string playerName)
        {
            if(score > highscore)
            {
                highscore = score;
                highscorePlayer = playerName;

                Console.WriteLine("New highscore is " + score);
                Console.WriteLine("It is now held by " + playerName);
            }
            else
            {
                Console.WriteLine("The old highscore could not be broken. It is still " + highscore + " and held by " + highscorePlayer);
            }
        }
    }
}
