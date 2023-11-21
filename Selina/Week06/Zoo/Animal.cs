namespace Selina.Week06.Zoo
{
    public class Animal
    {
        private string _Name;
        private int _Age;
        private string _Genus;
        private string _Gender;
        private Food _Food;
        private int _FoodAmount;
        private bool _Hungry;
        private int _Health;
        private int _MaxHealth;
        private double _Bite = 2.0;
        public int FoodAmount
        {
            get => _FoodAmount;
            set => _FoodAmount = value;
        }
        public bool Hungry
        {
            get => _Hungry;
            set => _Hungry = value;
        }
        public string Name
        {
            get => _Name;
        }
        public Food Food
        {
            get => _Food;
        }
        public int Health
        {
            get => _Health;
            set => _Health = value;
        }
        public int MaxHealth
        {
            get => _MaxHealth;
            set => _MaxHealth = value;
        }
        public double Bite
        {
            get => _Bite;
            set => _Bite = value;
        }

        public Animal(string name, int age, string gender, Food food, int foodAmount, bool hungry, int health, int maxHealth, double Bite)
        {
            this._Name = name;
            this._Age = age;
            this._Gender = gender;
            this._Food = food;
            this._FoodAmount = foodAmount;
            this._Hungry = hungry;
            this._Health = health;
            this._MaxHealth = maxHealth;
            this._Bite = Bite;
        }

        //Tiere beißen sich
        public void Bites(Animal animal)
        {
            if (this.Health > 0 && animal.Health > 0)
            {
                Console.WriteLine($"Tier {this.Name} beißt {animal.Name}!");
                animal.Health -= 50;

                if (animal.Health <= 0)
                {
                    Console.WriteLine($"{animal.Name} ist tot.");
                }
            }
        }

        // Animale wird ausgegeben
        public void PrintZoo()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"|           |-- {_Name}, {_Food}");
            Console.ForegroundColor = ConsoleColor.White;
        }

        //Anzahl an Essen wird ausgerechnet
        public void CalculateFoodRequest(Dictionary<Food, int> report)
        {
            if (report.ContainsKey(_Food))
            {
                report[_Food] += _FoodAmount;
            }
            else
            {
                report.Add(_Food, _FoodAmount);
            }
        }
    }
}
