
using System.Diagnostics.Metrics;

namespace Fabian.Week07._08_Bank
{
    public class Bank
    {
        private string _Name;
        private List<BankCounter> _BankCounters;

        public List<BankCounter> BankCounters { get => _BankCounters; set => _BankCounters = value; }
        public Bank(string name)
        {
            _Name = name;
            _BankCounters = new List<BankCounter>();
        }

        public void RefillCounter(BankCounter counter, int value)
        {
            counter.Money += value;
        }

        public void SendCustomerToCounter(Customer c, int value)
        {
            foreach(var counter in _BankCounters)
            {
                if (counter.IsFree)
                {
                    Console.WriteLine($"{c.Name} went to the counter {counter.CounterId}");
                    counter.Customers.Add(c);
                    c.UseBankCounter(counter, value);
                    counter.IsFree = false;
                    break;
                }
            }
        }
    }
}
