using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Patrick.Week09.RestaurantDolceVita
{
    public class EntryRoom 
    {
        private static string _Name;
        private bool _Open;

        public bool Open
        {
            get => _Open;
        }

        public EntryRoom(string name, bool open)
        {
            _Name = name;
            _Open = open;
        }

        public static void PrintEntryRoom()
        {
            Console.WriteLine("│   ├── " + _Name);
        }
    }
}
