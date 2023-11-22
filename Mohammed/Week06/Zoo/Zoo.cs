using System;
namespace Mohammed.Week06.Zoo
{
    public class Zoo
    {
        private string _Name;
        private int _FoundingYear;
        public List<Enclosure> _Enclosure;
        private List<ZooKeeper> _ZooKeepers;
        private int _MaxHealth;

        public string Name
        {
            get => _Name;
        }

        public int FoundingYear
        {
            get => _FoundingYear;
        }


        public List<ZooKeeper> ZooKeepers
        {
            get => _ZooKeepers;
            //set => _ZooKeepers = value;
        }

        public List<Enclosure> Enclosures
        {
            get => _Enclosure;
        }

       
        public Zoo(string name, int established)
        {
            _Name = name;
            _FoundingYear = established;
            _Enclosure = new List<Enclosure>();
            _ZooKeepers = new List<ZooKeeper>();
            //_AnimalDr = new List<AnimalDr>();
        }



        public void PrintStructure()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;

            Console.WriteLine($"├── Zoo: {_Name}, founded: {_FoundingYear}");

            foreach (ZooKeeper zookeeper in _ZooKeepers)
            {

                zookeeper.PrintZOOKeeper("  ");

            }
        }

        public void PrintZooStatistic()
        {
            Dictionary<Food, double> dic = new();

            foreach (Enclosure enclosure in _Enclosure)
            {
                enclosure.GetStatctisEnclosure(dic);
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Food requisite: ");
            Console.ResetColor();
            double cost = 0;

            foreach (Food food in dic.Keys)
            {
                Console.WriteLine($"{food.Name} : {dic[food]} {food.Unit} ");
                double amount = dic[food];
                double price = food.PreisPerUnit * amount;
                cost += price;
            }
            Console.WriteLine("Total preis for Food :" + cost);

        }

        
        public void SimulateDay(int daynum)
        {
            foreach (Enclosure enclosure in _Enclosure)
            {
                enclosure.SimulateOfDayStart();
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Simulation of day {0 } beginn.", daynum);
            foreach (ZooKeeper zooKeeper in _ZooKeepers)
            {
                zooKeeper.ZookeeperWithRespsabiliets();
            }



        }

        public void AddEnc(Enclosure enclosure)
        {
            _Enclosure.Add(enclosure);
        }
    }
}


/*
          public Enclosure SearchAndCreate(string name)
          {
              foreach(Enclosure enc in _EnclosureList)
              {
                  if( enc.Name == name)
                  {
                      return enc;
                  }

              }
              Enclosure newenc = new Enclosure(name);
              _EnclosureList.Add(newenc);
              return  newenc;

          }
          *
          */

//public void HealStart()
//{
//    List<Animal> availableAnimals = new();

//    foreach(Enclosure enclosure in _Enclosure)
//    {
//        foreach(Animal animal in enclosure.Animalliste)
//        {
//            if (!animal.IsDead) availableAnimals.Add(animal);
//        }
//    }



//}





//public void FightStart()
//{
//    List<Animal> animalsToRemove = new();

//    foreach (Enclosure enclosure in _Enclosure)
//    {
//        //enclosure.Fight(animalsToRemove);
//        foreach (Animal animal in animalsToRemove)
//        {
//            enclosure.Animalliste.Remove(animal);
//        }


//    }

//}