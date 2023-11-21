
using Fabian.Week06._04Zoo;

namespace Fabian.Week07._08_Bank
{
    public class BankMain
    {
        public static void Start()
        {
            Random rnd = new();

            Bank bank = new("Sparkasse");

            bank.BankCounters.AddRange(new List<BankCounter>
            {
                new BankCounter(1, 20000),
                new BankCounter(2, 10000),
                new BankCounter(3, 35000),
                new BankCounter(4, 5000),
            });

            List<Customer> customerList = new() {
                new("Frank"),
                new("Paul"),
                new("Anna"),
                new("Robert"),
                new("Peter"),
                new("Bella"),
                new("Fabian"),
                new("Olaf"),
                new("Lukas"),
            };

            foreach(var customer in customerList)
            {
                bank.SendCustomerToCounter(customer, rnd.Next(-5000, 10000));
            }

        }
    }
}
