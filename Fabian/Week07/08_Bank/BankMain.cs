
namespace Fabian.Week07._08_Bank
{
    public class BankMain
    {
        public static void Start()
        { 

            Bank bank = new("Sparkasse");

            bank.BankCounters.AddRange(new List<BankCounter>
            {
                new BankCounter(1, 20000),
                new BankCounter(2, 10000),
                new BankCounter(3, 35000),
                new BankCounter(4, 15000),
            });

            bank.Customers.AddRange(new List<Customer>
            {
                new("Frank"),
                new("Paul"),
                new("Anna"),
                new("Robert"),
                new("Peter"),
                new("Bella"),
                new("Fabian"),
                new("Olaf"),
                new("Lukas"),
            });

            bank.Simulation(4);
        }
    }
}
