using System;
namespace Mohammed.Week07.Zoo02
{
	public class Zoo
	{
        //probertis
        private string _Name;
        private int _Year;
        public string _Location;
        private List<ZooKeeper> _ZooKeeperList;
        private string _EnclosureToClean;

        //Konstructor
        public string Name
        {
            get => _Name;
        }

        public int Year
        {
            get => _Year;
        }

        public string Location
        {
            get => _Location;
        }

        public List<ZooKeeper> ZooKeeperList
        {
            get => _ZooKeeperList;
        }

        

        public Zoo(string name, int year, string location, string enclousretoclean)
        {
            _Name = name;
            _Year = year;
            _Location = location;
            _EnclosureToClean = enclousretoclean;
            _ZooKeeperList = new List<ZooKeeper>();
        }

       
        public void PrintZoo()
        {
            Console.WriteLine($"{_Name}, {_Year}, {_Location}");
        }

        public void PrintStructure()
        {
            PrintZoo();
            foreach(ZooKeeper zookeeper in _ZooKeeperList)
            {
                zookeeper.PrintZooKeeper();
            }
            
        }

        public void FillZooKeeperList(ZooKeeper zooKeeper)
        {
            if (!_ZooKeeperList.Contains(zooKeeper))
            {
                _ZooKeeperList.Add(zooKeeper);
            }
        }

        






    }
}

