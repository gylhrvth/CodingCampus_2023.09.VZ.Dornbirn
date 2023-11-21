using System;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using David.Week06.ZOO;

namespace David.Week07.ZooNew
{
	public class Zoo
	{
		private string _Name;
		private int _Year;
        private string _Location;
        private List<ZooKeeper> _ZooKeeperList;

        public Zoo(string name, int year, string location)
		{
			_Name = name;
			_Year = year;
			_Location = location;
            _ZooKeeperList = new List<ZooKeeper>();
        }

        public void PrintZoo()
        {
            Console.WriteLine($"{_Name}, {_Year}, {_Location}");
            Console.WriteLine();
        }

        public void PrintStructure()
        {
            PrintZoo();
            foreach (ZooKeeper zooKeeper in _ZooKeeperList)
            {
                zooKeeper.PrintZooKeeper();
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



