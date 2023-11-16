using System.Reflection.Metadata.Ecma335;

namespace Gheorghe.Week07.Zoo
{
    internal class Zoo
    {
        private string _Name;
        private string _Locality;
        private int _FoundingYear;        
        private List<Enclosure> _EnclosureList;
        private List<ZooKeeper> _ZooKeeperList;
        public readonly string _FavoritSpecies;



        public Zoo(string Name, string Locality, int FoundingYear)
        {
            _Name = Name;
            _Locality = Locality;
            _FoundingYear = FoundingYear;            
            _EnclosureList = new List<Enclosure>();
            _ZooKeeperList = new List<ZooKeeper>();
        }





        public void AddZooKeeper(ZooKeeper zooKeeper)
        {
            if (!_ZooKeeperList.Contains(zooKeeper))
            {
                _ZooKeeperList.Add(zooKeeper);
            }
        }


        public void AdddEnclosure(Enclosure enclosure)
        {
            if (!_EnclosureList.Contains(enclosure))
            {
                _EnclosureList.Add(enclosure);
            }
        }




        public void PrintZoo()
        {
            Console.WriteLine($"|--Zoo: {_Name}, Locality {_Locality},  Year: {_FoundingYear}");
            foreach (Enclosure enclosure in _EnclosureList)
            {
                enclosure.PrintZoo();
            }
        }


        public void Simulation(int dayNr)
        {
            Console.WriteLine($"Start Day {dayNr}:");
            foreach (ZooKeeper zk in _ZooKeeperList)
            {
                zk.SimulationWork();
            }
        }
    }
}
