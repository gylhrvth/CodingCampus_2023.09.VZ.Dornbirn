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

        public int CounterId { get => _CounterId; }
        public bool IsFree { get => _IsFree; set => _IsFree = value; }
        public int Money { get => _Money; set => _Money = value; }
        public List<Customer> Customers { get => _Customers; set => _Customers = value; }
        public List<double> Actions { get => _Actions; set => _Actions = value; }
        public BankCounter(int CounterId, int money)
        {
            _CounterId = CounterId;
            _IsFree = true;
            _Money = money;
            _Break = false;
            _Customers = new();
            _Actions = new();
        }

        public void TakeBreak()
        {
            _Break = rnd.NextDouble() <= 0.2;
        }

        public void PrintStatistik()
        {
            for (int i = 0; i < _Customers.Count; i++)
            {
                Console.WriteLine($"{_Customers[i].Name} was at the BankCounter {_CounterId} and changed a balance of {_Actions[i]}");
            }
        }
    }
}
