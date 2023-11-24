using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erik.Week08
{
    public class Keeper
    {
        private List<Enclosure> _EnclosureList;
        private string _KeeperName;
        public string keeperName { get => _KeeperName; }
        public Keeper(string keeperName)
        {
            _KeeperName = keeperName;
            _EnclosureList = new List<Enclosure>();
        }

        public void addEclosure(Enclosure enclosure)
        {
            _EnclosureList.Add(enclosure);
        }


        public void FeedEnclosures()
        {
            foreach (Enclosure enclosure in _EnclosureList)
            {
                if (enclosure.IsHungry())
                {
                    enclosure.GetsFed(this);
                }
                else
                {
                    Console.WriteLine($"Enclosure {enclosure.EnclosureName} already fed!");
                }
            }
        }

        public override String ToString()
        {
            return _KeeperName;
        }

    }
}
