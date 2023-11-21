using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Patrick.Week06.OOP.SomeTrys
{
    internal class BankAccountMain
    {
        public static void Start()
        {
            Console.WriteLine("Bitte geben Sie Ihren Namen ein:");
            Console.Write(">>>>>");
            string name = Console.ReadLine();

            Console.WriteLine("Bitte geben Sie Ihre Kontonummer ein:");
            Console.Write(">>>>>");
            string number = Console.ReadLine();

            Console.WriteLine("Bitte geben Sie Ihren Kontostand ein:");
            Console.Write(">>>>>");
            float balance = float.Parse(Console.ReadLine());

            BankAccount account = new BankAccount(
                name,
                number,
                balance
                );

            while (true)
            {
                Console.WriteLine("Bitte wählen Sie eine Aktion aus:");
                Console.WriteLine("1. Kontostand anzeigen");
                Console.WriteLine("2. Einzahlung machen");
                Console.WriteLine("3. Auszahlung machen");
                Console.WriteLine("4. Beenden");

                string input = Console.ReadLine();

                if (input == "1")
                {
                    account.PrintBalance();
                }
                else if (input == "2")
                {
                    Console.WriteLine("Geben Sie den Betrag für die gewünschte Einzahlung ein.");
                    Console.Write(">>>>>");
                    float inputAmount = account.ReadNumber();
                    account.MakeDeposit(inputAmount);
                    Console.WriteLine($"Dein Aktuelles Guthaben beträgt: {account._Balance}");
                }
                else if (input == "3")
                {
                    Console.WriteLine("Geben Sie den gewünschten Betrag für die Auszahlung an.");
                    Console.Write(">>>>>");
                    float inputWithdrawal = account.ReadNumber();
                    account.MakeWithDrawal(inputWithdrawal);
                }
                else if (input == "4")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Ungültige Eingabe, Bitte versuchen Sie es erneut!");
                }
            }

        }
    }
}
