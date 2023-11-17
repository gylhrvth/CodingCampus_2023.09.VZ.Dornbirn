using System;
namespace Mohammed.Week06.Zoo
{
    public class Enclosure
    {
        private readonly Random random = new();


        private string _Name;
        private List<Animal> _Animallist;
        private string _Temp;
        private bool _IsFaid;
        private bool _WasTheKeeperInEnclosure;
        private int _SimulateDayStart;


        public Enclosure(string name)
        {
            _Name = name;
            _Animallist = new List<Animal>();
            _IsFaid = false;
        }

        public void AddAnimal(Animal animals)
        {
            _Animallist.Add(animals);
        }

        public List<Animal> Animalliste
        {
            get => _Animallist;
        }

        public string Name
        {
            get => _Name;
        }


        public bool IsFaid
        {
            get => _IsFaid;
            set => _IsFaid = value;
        }

        public bool WasTheKeeperInEnclosure
        {
            get => _WasTheKeeperInEnclosure;
        }

        public int SimulateDayStart
        {
            get => _SimulateDayStart;
        }




        public void PrintStruacture(string praefix)
        {
            Console.WriteLine(praefix + "├── Gehege:{0}", _Name);
            foreach (Animal animal in _Animallist)
            {
                animal.PrintAnimal(praefix + "    ");
            }

        }


        public void PrintAnimals()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"│      ├── Gehege: {_Name}");
            Console.ResetColor();
            foreach (Animal animal in _Animallist)
            {
                Console.WriteLine($"│      ├── {animal.Name}, {animal.Genus}");
            }
        }


        public void PrintEnclousre(string praefix)
        {
            Console.Write(praefix);
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($"├── Enclosure: {_Name}");
            Console.ResetColor();
            foreach (Animal animal in _Animallist)
            {
                animal.PrintAnimal(praefix + "   ");
            }
        }


        public void GetStatctisEnclosure(Dictionary<Food, double> dic)
        {
            foreach (Animal animals in _Animallist)
            {
                animals.GetAnimalsStatistic(dic);
            }
        }

        public void PrintAnimalRan(string nameOfKeeper)
        {
            var random = new Random();
            int randomOfAnimal = random.Next(Animalliste.Count);
            Console.WriteLine($"The keeper{nameOfKeeper} observes the animal{Animalliste[randomOfAnimal]}");

        }


        public void SimulateOfDayStart()
        {
            _WasTheKeeperInEnclosure = false;
        }

        public void SimulateTakeCareOfEnclosure(string nameOfKeeper)
        {
            if (_WasTheKeeperInEnclosure == false)
            {
                foreach (Animal animal in Animalliste)
                {
                    Console.WriteLine($"{nameOfKeeper}feeds the animal{animal} in the enclosure with the food{animal.food}. ");
                }
                _WasTheKeeperInEnclosure = true;
                PrintAnimalRan(nameOfKeeper);
                LovleyAnimalForKeeper(nameOfKeeper);
                Console.WriteLine("==============");

            }
            else
            {
                Console.WriteLine($"The enclosure{Name} has already been cleaned{nameOfKeeper } and can continue ");
            }
            
        }

        public override string ToString()
        {
            return Name;
        }

        public void LovleyAnimalForKeeper(string nameOfKeeper)
        {
            Animal loveleyAnimal = Animalliste[0];
            Console.WriteLine($"{nameOfKeeper }admires his favorite animal {loveleyAnimal }  for a while");
        }











    }
}

