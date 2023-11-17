namespace Selina.Week06.Zoo
{
    public class Gehege
    {
        private string _Description;
        private string _Climate;
        private string _Name;
        private List<Animal> _AnimalsList;
        private List<Nurse> _Nurse;
        public string favoriteAnimal;

        public string Name
        {
            get => _Name;
            set => _Name = value;
        }

        public Gehege(string name, string climate, string description)
        {
            this._Description = description;
            this._Climate = climate;
            this._Name = name;
            this._AnimalsList = new List<Animal>();
            this._Nurse = new List<Nurse>();
        }
        // Listen werden erstellt
        public void AddAnimals(Animal animals)
        {
            if (!_AnimalsList.Contains(animals))
            {
                _AnimalsList.Add(animals);
            }
        }
        public void AddNurse(Nurse nurse)
        {
            if (!_Nurse.Contains(nurse))
            {
                _Nurse.Add(nurse);
            }
        }

        //Ausgabe für User
        public void PrintZoo()
        {
            foreach (Nurse nurse in _Nurse)
            {
                nurse.PrintZoo();
            }
            foreach (Animal animals in _AnimalsList)
            {
                animals.PrintZoo();
            }
        }

        //Essen wird berechnet
        public void CalculateFoodRequest(Dictionary<Food, int> report)
        {
            foreach (Animal ani in _AnimalsList)
            {
                ani.CalculateFoodRequest(report);
            }
        }

        //Tiere werden gefüttert und Pfleger beobachten Tier
        public void FeedAnimal()
        {
            foreach (Nurse pfleger in _Nurse)
            {
                Console.WriteLine($"\nPfleger/in {pfleger.Name,-14} geht los: ");
                foreach (Animal ani in _AnimalsList)
                {
                    if (ani.Hungry == false)
                    {
                        Console.WriteLine($"-Tier wurden bereits gefüttert!");
                        continue;
                    }
                    Console.WriteLine($"-Tier {ani.Name} wird gefüttert.");

                    ani.Hungry = false;
                }
                RandomAnimal();
                Console.WriteLine($"\t => Beobachtet Lieblingsteier: {pfleger.FavoriteAnimal}");
            }

        }

        // Random Animal wird beobachtet
        public void RandomAnimal()
        {
            Random random = new Random();
            int randomIndex = random.Next(_AnimalsList.Count);
            var randomAnimal = _AnimalsList[randomIndex];
            Console.WriteLine($"\t=> Beobachtet {randomAnimal.Name} im Gehege {Name}.");
        }

        // Tag wird simuliert
        public void SimulateDay(Animal animal)
        {
            Random random = new Random();
            foreach (Animal ani in _AnimalsList)
            {
                if (random.Next(100) < 40 && animal != ani)
                {
                    Animal anotherAnimal = animal; //Get random animal other than ani
                    ani.Bites(anotherAnimal);
                }
                if (ani.Health <= 0)
                {
                    RemoveAnimale(ani);
                }
            }
        }

        //Tiere beißen sich 
        public void BiteAnimal()
        {
            foreach (Animal ani in _AnimalsList)
            {
                SimulateDay(ani);
            }
        }

        //Tote Tiere werden removet
        public void RemoveAnimale(Animal animal)
        {
            _AnimalsList.Remove(animal);
        }

        public void VetHelpAnimal(Animal animal)
        {
            foreach (Animal ani in _AnimalsList)
            {
               
            }
        }
    }
}
