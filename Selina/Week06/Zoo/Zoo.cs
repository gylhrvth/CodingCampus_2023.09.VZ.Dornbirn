namespace Selina.Week06.Zoo
{
    public class Zoo
    {
        private string _Name;
        private string _Locality;
        private int _FoundYear;
        private int _Capacity;
        private List<Gehege> _GehegeList;
        public List<Animals> _AnimalsList { get; set; }   

        public Zoo(string name, string locality, int foundYear, int capacity)
        {
            this._Name = name;
            this._Locality = locality;
            this._FoundYear = foundYear;
            this._Capacity = capacity;
            this._GehegeList = new List<Gehege>();
            this._AnimalsList = new List<Animals>();    
        }

        public void AddGehege(Gehege gehege)
        {
            if (!_GehegeList.Contains(gehege))
            {
                _GehegeList.Add(gehege);
            }
        }
        public double CalculateFoodPrice()
        {
            double totalPrice = 0;

            foreach (var animal in _AnimalsList)
            {
                foreach (var foodAmount in animal._FoodAmountOfAnimal)
                {
                    totalPrice += foodAmount.Key * foodAmount.Value;
                }
            }

            return totalPrice;
        }
        public void PrintZoo()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"|-- Zoo: {_Name}, gegründet {_FoundYear} ");
            Console.ForegroundColor = ConsoleColor.White;

            foreach (Gehege gehege in _GehegeList)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"|   |-- Gehege: {gehege.Name}");
                Console.ForegroundColor = ConsoleColor.White;
                gehege.PrintZoo();
            }
        }
    }
}
