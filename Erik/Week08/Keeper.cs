using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erik.Week08
{
    public class Keeper
    {
        private string _KeeperName;

        public Keeper(string keeperName)
        {
            _KeeperName = keeperName;
        }

        public void PrintKeeper()
        {
            Console.WriteLine(_KeeperName);
        }
    }
}
