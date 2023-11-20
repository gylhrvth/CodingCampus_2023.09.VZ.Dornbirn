namespace Fabian.Week07._08_Bank
{
    public class Customer
    {
        private string _Name;

        public string Name { get => _Name; }
        public Customer(string name)
        {
            _Name = name;
        }

        public void UseBankCounter(BankCounter b, int value)
        {
            b.Money += value;
            Console.WriteLine($"{_Name} changed value: {value}");
            b.Actions.Add(value);
            b.TakeBreak();
        }
    }
}
