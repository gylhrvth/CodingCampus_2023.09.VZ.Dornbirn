using System.Text.RegularExpressions;

namespace Fabian.Selftest_SP
{
    public class Input
    {
        public static void Start()
        {
            PrintText();
        }

        public static String ReadString(string msg, string pattern = "^[a-zA-Z ]*$")
        {
            while (true)
            {
                Console.Write(msg);
                string text = Console.ReadLine();
                if(text == "")
                {
                    Console.WriteLine("Please enter something!");
                }
                else if (!Regex.IsMatch(text, pattern))
                {
                    Console.WriteLine("not a valid input!");
                }
                else
                {
                    return text;
                }
            }
        }
        public static int ReadNumber(string msg)
        {
            int number = 0;
            while (number == 0)
            {
                try
                {
                    Console.Write(msg);
                    number = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Enter a valid number!");
                }
                catch(OverflowException)
                {
                    Console.WriteLine("Number was too high!");
                }
            }
            return number;
        }
        public static void PrintText()
        {
            string text = ReadString("Enter a text: ");
            int count = ReadNumber("How often do you want to output the text? ");

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(text);
            }
        }
    }
}
