using System;
namespace Gyula.Week04
{
	public class UserInputExample
	{
		public static void Start()
		{
            //string name = ReadString("Bitte geben Sie ihre Vorname ein: ");
            //int age = ReadNumber("Bitte geben Sie ihre Alter ein: ", 0, 110);
            //Console.WriteLine("Hello {0}! Ich gratuliere Ihnen zum {1}. Geburtstag", name, age);

            string text = ReadString("Type a char to print: ");
            int width = ReadNumber("What shall use as width? ", 1, 30);
            int height = ReadNumber("What shall we use as height? ", 1, 8);

            PrintRect(text + " ", width, height);


		}


        public static void PrintRect(String t, int width, int height)
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write(t);
                }
                Console.WriteLine();
            }
        }

        public static int ReadNumber(string msg, int minValid, int maxValid)
        {
            int result = Int32.MinValue;
            while (result == Int32.MinValue)
            {
                Console.Write("{0}zwischen {1} und {2}: ", msg, minValid, maxValid);
                string line = Console.ReadLine();

                try
                {
                    result = Convert.ToInt32(line);
                    if (result < minValid || result > maxValid)
                    {
                        Console.WriteLine("{0} ist nicht im Bereich zwischen {1} und {2}", result, minValid, maxValid);
                        result = Int32.MinValue;
                    }
                }
                catch (FormatException fe)
                {
                    Console.WriteLine("\"{0}\" ist keine gültige Zahl.", line);
                }
            }

            return result;
        }


        public static int ReadNumberAlmostGood3(string msg)
        {
            int result = 0;
            while (result == 0)
            {
                Console.Write(msg);
                string line = Console.ReadLine();

                try
                {
                    result = Convert.ToInt32(line);
                }
                catch (FormatException fe)
                {
                    Console.WriteLine("\"{0}\" ist keine gültige Zahl.", line);
                }
            }

            return result;
        }

        public static int ReadNumberAlmostGood2(string msg)
        {
            Console.Write(msg);
            string line = Console.ReadLine();

            int result = 0;
            try { 
                result = Convert.ToInt32(line);
            } catch (FormatException fe)
            {
                Console.WriteLine("\"{0}\" ist keine gültige Zahl.", line);
            }

            return result;
        }


        public static int ReadNumberAlmostGood(string msg)
        {
            Console.Write(msg);
            string line = Console.ReadLine();

            return Convert.ToInt32(line);
        }


        public static string ReadStringAlmostGood(string msg)
        {
            Console.Write(msg);
            string line = Console.ReadLine();
            return line;
        }

        public static string ReadStringAlmostGood2(string msg)
		{
			string line = "";
			while (line.CompareTo("") ==	 0)
			{
                Console.Write(msg);
                line = Console.ReadLine();
                line ??= "";
                line = line.Trim();
            }
			return line;
		}

        public static string ReadString(string msg)
        {
            string line = "";
            bool firstTry = true;
            while (line.CompareTo("") == 0)
            {
                if (!firstTry)
                {
                    Console.WriteLine("Ich habe es nicht verstanden. Können Sie bitte wiederholen?");
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

