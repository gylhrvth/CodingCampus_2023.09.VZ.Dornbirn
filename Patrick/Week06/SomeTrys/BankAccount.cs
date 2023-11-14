using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Patrick.Week06.SomeTrys
{
    internal class BankAccount
    {
        public string _Number { get; private set; }
        public string _Owner { get; private set; }
        public float _Balance { get; private set; }


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

        public void MakeWithDrawal(float amount)
        {
            if (amount <= _Balance)
            {
                _Balance -= amount;
            }
            else
            {
                Console.WriteLine("Unzureichender Saldo!");
            }
        }

        public void PrintBalance()
        {
            Console.WriteLine($"Kontostand von {_Owner}: {_Balance}");
        }

        public int ReadNumber()
        {
            while (true)
            {
                string input = Console.ReadLine();

                try
                {
                    return Convert.ToInt32(input);
                }
                catch(FormatException)
                {
                    Console.WriteLine($"{input} ist kein gültiger Betrag, bitte wiederholen!");
                }
            }
        }
    }
}
