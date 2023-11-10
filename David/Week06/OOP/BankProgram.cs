using System;
namespace David.Week06.OOP
{
	public class BankProgram
	{
		public static void Main()
		{
			BankAccount account = new BankAccount(
				"1234567890",
				"David Isele",
				100
				);

			while (true)
			{

				Console.WriteLine("Bitte Aktion wählen:");
				Console.WriteLine("1. Konstostand anzeigen");
                Console.WriteLine("2. Einzahlung");
                Console.WriteLine("3. Auszahlung");
                Console.WriteLine("4. Beenden");

				string input = Console.ReadLine();

				if (input == "1")
				{
					account.PrintBalance();
				}
				else if (input == "2")
				{
					Console.WriteLine("Bite geben Sie den Einzahlungsbetrag ein:");
					float depositAmount = float.Parse(Console.ReadLine());
					account.MakeDeposit(depositAmount);
					Console.WriteLine($"Ihr neuer Kontostand beträgt: {account.Balance}");
                }
				else if (input == "3")
				{
                    Console.WriteLine("Bite geben Sie den Abhebungsbetrag ein:");
                    float withdrawlAmount = float.Parse(Console.ReadLine());
					account.MakeWithdrawl(withdrawlAmount);
                    Console.WriteLine($"Ihr neuer Kontostand beträgt: {account.Balance}");
                }
				else if (input == "4")
				{
					break;
				}
				else
				{
					Console.WriteLine("Bitte erneut versuchen.");
				}
            }
        }
	}
}

