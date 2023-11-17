
namespace Fabian.Week07._08_Bank
{
    public class BankMain
    {
        public static void Start()
        {
            Bank bank = new("Sparkasse");

            bank.BankCounters.AddRange(new List<BankCounter>
            {
                new BankCounter("01"),
                new BankCounter("02"),
                new BankCounter("03"),
                new BankCounter("04"),
            });


        }
    }
}
