﻿namespace Fabian.Week06._04Zoo
{

    public class ZooKeeper
    {
        private readonly Random rnd = new();

        private string _Name;
        private List<Enclosure> _Enclosures = new();
        private Animal _FavouriteAnimal;
       
        public List<Enclosure> Enclosures
        {
            get => _Enclosures;
            set => _Enclosures = value;
        }
        public Animal FavouriteAnimal
        {
            get => _FavouriteAnimal;
            set => _FavouriteAnimal = value;
        }

        public ZooKeeper(string name, List<Enclosure> enclosures)
        {
            _Name = name;
            _Enclosures = enclosures;
            _FavouriteAnimal = FavouriteAnimal;
        }

        public void PrintZooKeeper()
        {
            Console.WriteLine("│\t├──Zookeeper: {0}", _Name);
            foreach (var enclosure in _Enclosures)
            {
                enclosure.PrintEnclosure();
            }
        }
        public void DailyTask()
        {           
            foreach (var enclosure in _Enclosures)
            {
                if (!enclosure.IsFed)
                {
                    Console.WriteLine($"{_Name} is feeding the {enclosure.Name} enclosure");
                    enclosure.IsFed = true;
                }
                else
                {
                    Console.WriteLine($"{_Name} tried to feed the {enclosure.Name} enclosure but it's already fed");
                }
                _FavouriteAnimal = enclosure.Animals[rnd.Next(enclosure.Animals.Count)];
                Console.WriteLine($"{_Name} is spectating his favourite animal: {_FavouriteAnimal}\n");
            }
            
        }

        public override string ToString()
        {
            return "Name: " + _Name;
        }      
    }
}
