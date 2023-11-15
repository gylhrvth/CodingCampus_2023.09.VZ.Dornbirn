using System;
namespace Mohammed.Selftest
{
    public class Input
    {
        public static void Start()
        {
            string text;
            int count;





            do
            {
                Console.WriteLine("Bitte geben Sie einen Text ein: ");
                text = Console.ReadLine();

            } while (text.Length == 0);




            do
            {
                Console.WriteLine("Wie oft soll der Text ausgegeben werden: ");
                count = Convert.ToInt32(Console.ReadLine());
            } while (count <= 0);

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(text);
            }

        }


        public static string ReadString()
        {
            string text;

            do
            {
                text = Console.ReadLine();

            } while (text.Length == 0);

            return text;
        }


        public static int ReadNumber()
        {
            int number;

            do
            {
                number = Convert.ToInt32(Console.ReadLine());

            } while (number <= 0);

            return number;
        }


    }
}

