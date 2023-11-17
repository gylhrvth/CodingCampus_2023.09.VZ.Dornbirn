
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
    }
}
