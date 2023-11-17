using System;
namespace David.Week06.OOP
{
	internal class BankAccount
	{
		public string Number { get; private set; }
		public string Owner { get; private set; }
		public float Balance { get; private set; }

		public BankAccount(string number, string owner, float initialBalance)
		{
			Number = number;
			Owner = owner;
			Balance = initialBalance;
		}

		public void MakeDeposit(float amount)
		{
			Balance += amount;
		}

		public void MakeWithdrawl(float amount)
		{
			if(amount <= Balance)
			{
				Balance -= amount;
			}else
			{
				Console.WriteLine("Unzureichender Saldo.");
			}
		}

		public void PrintBalance()
		{
			Console.WriteLine($"Kontostand von {Owner}: {Balance}");
		}
	}
}

