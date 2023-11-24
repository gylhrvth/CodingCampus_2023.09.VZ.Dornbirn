using System;
namespace David.Week07.ZooNew
{
	public class ZooKeeper
	{
		private string _Name;
		//private string _EnclosureToClean;
		private List<Enclosure> _EnclosureList;

		public ZooKeeper(string name ) //string enclosureToClean)
		{
			_Name = name;
			//_EnclosureToClean = enclosureToClean;
			_EnclosureList = new List<Enclosure>();
		}

		public void PrintZooKeeper()
		{
			Console.WriteLine();
			Console.WriteLine($"--->{_Name}");
			foreach (Enclosure enclosure in _EnclosureList)
			{
				enclosure.PrintEnclosure();
			}
		}

        public void FillEnclosureList(Enclosure enclosure)
        {
            if (!_EnclosureList.Contains(enclosure))
            {
                _EnclosureList.Add(enclosure);
            }
        }

		//public void EnclosureToFeedNext()
		//{
		//	foreach (var item in collection)
		//	{

		//	}
		//}
    }
}

