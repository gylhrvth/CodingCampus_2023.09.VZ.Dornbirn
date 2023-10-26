using System;
namespace David.Week05
{
	public class ReverseProgramm
	{
		public static void StartReverseProgramm()
		{
            Reverse();
		}

        public static void Reverse()
        {
            Console.WriteLine("Gib ein Wort ein");
            string input = Console.ReadLine();

            char[] FirstInput = input.ToCharArray();
            char[] reverse = new char[FirstInput.Length];

            for (int i = 0; i < FirstInput.Length; i++)
            {
                reverse[FirstInput.Length - 1 - i] = FirstInput[i];
            }
            string word = new string(reverse);

            Console.WriteLine(word);
        }
    }
	
}
