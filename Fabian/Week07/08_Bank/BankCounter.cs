using static Fabian.Selftest_SP.TowersOfHanoi;
namespace Fabian.Week07._08_Bank
{
    public class BankCounter
    {
        private readonly Random rnd = new();

        private int _CounterId;
        private bool _IsFree;
        private int _Money;
        private bool _Break;
        private List<Customer> _Customers;
        private List<double> _Actions;
        private int _Counter;

        public int CounterId { get => _CounterId; }
        public bool IsFree { get => _IsFree; set => _IsFree = value; }
        public int Money { get => _Money; set => _Money = value; }
        public List<Customer> Customers { get => _Customers; set => _Customers = value; }
        public List<double> Actions { get => _Actions; set => _Actions = value; }
        public bool Break { get => _Break; set => _Break = value; }
        public int Counter { get => _Counter; set => _Counter = value; }
        public BankCounter(int CounterId, int money)
        {
            _CounterId = CounterId;
            _IsFree = true;
            _Money = money;
            _Break = false;
            _Customers = new();
            _Actions = new();
            _Counter = 0;
        }

        public void TakeBreak()
        {
            _Break = rnd.NextDouble() <= 0.2;         
            if (_Break) SetConsoleColor(ConsoleColor.Red, $"Counter {_CounterId} is on a break!");
        }

        public void PrintStatistik()
        {
            SetConsoleColor(ConsoleColor.Magenta, $"Bankcounter Statistik of Counter {_CounterId}: ");
            for (int i = 0; i < _Customers.Count; i++)
            {
                string action = (_Actions[i] >= 0) ? "deposit:" : "payout:";
                Console.WriteLine($"{_Customers[i].Name}, {action} {Math.Abs(_Actions[i])}$");
            }
        }
    }
}
