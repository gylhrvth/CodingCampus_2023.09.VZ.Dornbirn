using System;
namespace David.Week04
{
	public class UserInput
	{
		public static void Start()
		{
            string name = ReadString("Bitte geben Sie Ihren Vornamen ein: ");
            Console.WriteLine(name);
        }

        public static string ReadString(string msg)
        {
            string line = "";
            bool firstTry = true;
            while (line.CompareTo("") == 0) 
            {
                if (!firstTry)
                {
                    Console.WriteLine("Bitte wiederholen!");
                }
                Console.Write(msg);
                line = Console.ReadLine();
		        line ??= "";
                line = line.Trim();
                firstTry = false;

            }
            return line;
        }


    }
}

