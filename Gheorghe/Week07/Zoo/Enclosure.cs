namespace Gheorghe.Week07.Zoo
{
    internal class Enclosure
    {
        private string _Description;
        private string _Climate;
        private string _Name;
        private List<Animals> _AnimalsList;
        private List<ZooKeeper> _ZookeeperList;



        public Enclosure(string Description, string Climate, string Name)
        {
            _Description = Description;
            _Climate = Climate;
            _Name = Name;
            _AnimalsList = new List<Animals>();
            _ZookeeperList = new List<ZooKeeper>();


        }

        public void AddZookeeper(ZooKeeper zk)
        {
            _ZookeeperList.Add(zk);
        }


        public void AddAnimals(Animals animals)
        {
            if (!_AnimalsList.Contains(animals))
            {
                _AnimalsList.Add(animals);
            }
        }



        public void PrintZoo()
        {
            Console.WriteLine($"  |--- Enclosure: {_Name}, {_Description}, {_Climate}");


            foreach (Animals animals in _AnimalsList)
            {
                animals.PrintZoo();
            }
            foreach (ZooKeeper zooKeeper in _ZookeeperList)
            {
                zooKeeper.PrintZooKeeper();
            }


        }
        public void CareAnimals()
        {
            foreach (Animals animals in _AnimalsList)
            {
                if (animals.Hungry)
                {
                    animals.Hungry = false;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($" Wer hat hunger ->: {animals.Name} , gerade gefüttert");
                    Console.ResetColor();


                }


            }


        }

        public void AnimalsObserve()
        {
            // Wenn die Liste leer ist, gib nichts aus.
            if (_AnimalsList.Count == 0)
            {
                return;
            }

            // Wähle ein zufälliges Tier aus der Liste.
            int randomIndex = new Random().Next(_AnimalsList.Count);
            Animals animals = _AnimalsList[randomIndex];

            // Gib das Tier aus.
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Saw ,{animals.Name}");
            Console.ResetColor();
        }

        public void FavoritsAnimals()
        {
            if (_AnimalsList.Count == 0)
            {
                return;
            }

            int randomIndex = new Random().Next(_AnimalsList.Count);
            Animals animals = _AnimalsList[randomIndex];
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Favorit ,{animals.Name}");
            Console.ResetColor();
        }
    }

}

