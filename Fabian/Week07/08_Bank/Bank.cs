
using static Fabian.Selftest_SP.TowersOfHanoi;
namespace Fabian.Week07._08_Bank
{
    public class Bank
    {
        Random rnd = new();
        private string _Name;
        private List<Customer> _Customers;
        private List<BankCounter> _BankCounters;

        public List<BankCounter> BankCounters { get => _BankCounters; set => _BankCounters = value; }
        public List<Customer> Customers { get => _Customers; set => _Customers = value; }
        public Bank(string name)
        {
            _Name = name;
            _BankCounters = new List<BankCounter>();
            _Customers = new List<Customer>();
        }

        public static void RefillCounter(BankCounter counter, int value)
        {
            SetConsoleColor(ConsoleColor.Green, $"Counter {counter.CounterId} was empty and got refilled by {value}$");
            counter.Money += value;
        }

        public void SendCustomerToCounter(Customer c, int value)
        {
            foreach (var counter in _BankCounters)
            {
                if (counter.IsFree && !counter.Break)
                {
                    if (counter.Money < value)
                    {
                        RefillCounter(counter, 4000);
                        continue;
                    }
                    Console.WriteLine($"{c.Name} went to the counter {counter.CounterId}");
                    counter.Customers.Add(c);
                    c.UseBankCounter(counter, value);
                    counter.IsFree = false;
                    counter.TakeBreak();

                    foreach (var brokenCounter in _BankCounters)
                    {
                        if (brokenCounter.Break)
                        {
                            brokenCounter.Counter++;
                            if (brokenCounter.Counter == 4)
                            {
                                SetConsoleColor(ConsoleColor.DarkYellow, $"Counter {brokenCounter.CounterId} is not on break anymore!");
                                brokenCounter.Break = false;
                                brokenCounter.Counter = 0;
                            }
                        }
                    }
                    break;
                }
                counter.IsFree = true;           
            }
        }

        public void Simulation(int days)
        {
            for (int i = 1; i <= days; i++)
            {
                Console.WriteLine($"DAY {i}");
                foreach (var customer in _Customers)
                {
                    SendCustomerToCounter(customer, rnd.Next(-10000, 10000));
                }
                Console.WriteLine();
            }
            foreach (var counter in _BankCounters)
            {
                counter.PrintStatistik();
            }
            Console.WriteLine();
        }
    }
}
