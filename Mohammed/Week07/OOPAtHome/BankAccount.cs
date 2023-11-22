using System;
namespace Mohammed.Week07.OOPAtHome
{
    public class BankAccount
    {
        private string _Number;
        private string _Owner;
        private float _Balance;


        public BankAccount(string number, string owner, float balance)
        {
            _Number = number;
            _Owner = owner;
            _Balance = balance;
        }

        public void MakeDeposit(float amount)
        {
            _Balance += amount;
        }

        public void MakeWithdrawal(float amount)
        {
            if (amount <= amount)
            {
                _Balance -= amount;

            }
            else
            {
                Console.WriteLine("Unzureichender Saldo");
            }
        }



        public void PrintBalance()
        {
            Console.WriteLine($"Kontostand von {_Owner} : {_Balance}");
        }
    }
}

