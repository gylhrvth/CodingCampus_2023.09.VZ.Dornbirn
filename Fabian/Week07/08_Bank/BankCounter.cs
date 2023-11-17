namespace Fabian.Week07._08_Bank
{
    public class BankCounter
    {
        private string _CounterId;
        private bool _IsFree;

        public string CounterId { get => _CounterId; }
        public BankCounter(string CounterId)
        {
            _CounterId = CounterId;
            _IsFree = true;
        }
    }
}
