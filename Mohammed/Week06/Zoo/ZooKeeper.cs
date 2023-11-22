using System;
namespace Mohammed.Week06.Zoo
{
    public class ZooKeeper
    {
        private readonly Random random = new Random();

        private string _Name;
        private List<Enclosure> _Enclosures;
        private Animal _FavoriteAnimal;

        public string Name
        {
            get => _Name;
        }

        public List<Enclosure> Enclosures
        {
            get => _Enclosures;
        }

        public Animal FavoriteAnimal
        {
            get => _FavoriteAnimal;
        }


        public ZooKeeper(string name, Animal favoriteAnimal)
        {
            _Name = name;
            _Enclosures = new List<Enclosure>();
            _FavoriteAnimal = favoriteAnimal;
        }

        public void AddEnclosure(Enclosure enclosure)
        {
            _Enclosures.Add(enclosure);
        }


        public void PrintZOOKeeper(string praefix)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(praefix+"├──Zookeeper: {0}", _Name);
            Console.ResetColor();

            foreach (Enclosure enclosure in _Enclosures)
            {
                enclosure.PrintEnclousre(praefix+"    ");
            }
        }


        public void Feed()
        {
            foreach (Enclosure enclosure in _Enclosures)
            {
                if (!enclosure.IsFaid)
                {
                    Console.WriteLine($"{_Name} is feeding the {enclosure.Name} enclosure");
                    enclosure.IsFaid = true;
                }
                else
                {
                    Console.WriteLine($"{_Name} tried to feed the {enclosure.Name} enclosure but it's already fed");

                }

                Console.WriteLine($"{_Name} is spectating his favourite animal: {_FavoriteAnimal}");
            }
        }


        public void ZookeeperWithRespsabiliets()
        {
            foreach(Enclosure enclousre in _Enclosures)
            {
                enclousre.SimulateTakeCareOfEnclosure(Name);
            }
        }


        public override string ToString()
        {
            return "Name: " + _Name;
        }







    }
}

