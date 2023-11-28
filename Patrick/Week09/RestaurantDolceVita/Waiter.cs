using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Patrick.Week09.RestaurantDolceVita
{
    public class Waiter
    {
        private string _Name;
        private int _GuestCount = 0;
        private double _TotalCash = 0;

        private List<Rooms> _RoomList;
        private List<Table> _TableList;


        public int GuestCount
        {
            get => _GuestCount;
        }

        public double TotalCash
        {
            get => _TotalCash; 
            set => _TotalCash = value;
        }

        public Waiter(string name)
        {
            _Name = name;
            _RoomList = new List<Rooms>();
            _TableList = new List<Table>();
        }

        public void AddTableToList(Table talbe)
        {
            if (!_TableList.Contains(talbe))
            {
                _TableList.Add(talbe);
            }
        }

        public void AddRoomsToList(Rooms room)
        {
            if (!_RoomList.Contains(room))
            {
                _RoomList.Add(room);
            }
        }

        public void PrintTable()
        {
            foreach (Table table in _TableList)
            {
                Console.WriteLine("│         ├── Tisch: " + table);
            }
        }

        public void Room()
        {
            foreach (Rooms room in _RoomList)
            {
                Console.WriteLine("│      ├── Raum: " + room);
            }
        }

        public override string ToString()
        {
            return _Name;
        }

        public void PrintWaiterGuests()
        {
            Console.WriteLine($"Der Tisch ist frei und wird nun belegt.");
            Console.WriteLine($"\"{_Name}\" bringt die Gäste zu ihrem Tisch für.");
            Console.WriteLine($"Der Kellner \"{_Name}\" verteilt die SpeiseKarten.");
            Console.WriteLine($"Nach längerer Wartezeit sammelt \"{_Name}\" die SpeiseKarten ein und nimmt die Bestellung der Gäste am Tisch auf.");
            Console.WriteLine($"Der Kellner \"{_Name}\" bringt die Getränke und das Essen.");
        }

        public bool SearchAndFillFreeTable(GuestGroup randomGroup)
        {
            Random random = new Random();
            int randomIndexTable = random.Next(_TableList.Count);
            Table randomTable = _TableList[randomIndexTable];           
            foreach(Table table in _TableList)
            {
                if (randomGroup.GroupSize <= table.TableSizePeople && table.Free == true)
                {                   
                    table.Free = false;
                    Console.WriteLine("Huraa, es gibt einen freien Tisch");
                    return true ;
                }           
            }
            //Console.WriteLine("Es gibt Leider keinen freien Tisch!");
            return false;
        }


        public int GuestCountWaiter(GuestGroup randomGroup)
        {
           return _GuestCount += randomGroup.GroupSize;
        }


    }
}
