using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Patrick.Week09.RestaurantDolceVita
{
    public class Restaurant
    {
        private string _Name;
        private int _FoudningYear;
        private List<Waiter> _WaiterList;
        private List<GuestGroup> _GuestGroupList;

        public Restaurant(string name, int foudningYear)
        {
            _Name = name;
            _FoudningYear = foudningYear;
            _WaiterList = new List<Waiter>();
            _GuestGroupList = new List<GuestGroup>();
        }


        public void AddWaiterList(Waiter waiter)
        {
            if (!_WaiterList.Contains(waiter))
            {
                _WaiterList.Add(waiter);
            }

        }

        public void AddGuestsToList(GuestGroup guest)
        {
            if (!_GuestGroupList.Contains(guest))
            {
                _GuestGroupList.Add(guest);
            }

        }

        public void PrintStructure()
        {
            Console.WriteLine("│├──" + _Name + _FoudningYear);
            EntryRoom.PrintEntryRoom();
            MainWaiter.PrintMainWaiter();
            foreach (Waiter waiter in _WaiterList)
            {
                Console.WriteLine("│      ├──" + waiter);
                waiter.Room();
                waiter.PrintTable();
            }
        }

        public void SimulateGuests()
        {
            Random random = new Random();
            int randomIndexGroup = random.Next(_GuestGroupList.Count);
            GuestGroup randomGroup = _GuestGroupList[randomIndexGroup];

            Console.WriteLine($"Der Kellner \"Gyula\" empfängt die \"{randomGroup}({randomGroup.GroupSize} Personen)\".");

            int i = 0;
            while (true)
            {                          
                Waiter randomWaiter = _WaiterList[i];

                Console.WriteLine("Gyula klärt ab ob noch freie Tische da sind...");

                if (randomWaiter.SearchAndFillFreeTable(randomGroup) == true)
                {
                    Console.WriteLine($"Der Kellner \"Gyula\" übergiebt die \"{randomGroup}\" dem Kellner \"{randomWaiter}\".");
                    randomWaiter.PrintWaiterGuests();
                    randomWaiter.GuestCountWaiter(randomGroup);
                    Console.WriteLine($"\"{randomGroup}\" holt den Kellner \"{randomWaiter}\" und fragt nach der Rechnung.");
                    Console.WriteLine("Der Kellner bringt die Rechnung");
                    Console.WriteLine($"Die {randomGroup} bezahlt und verlässt das Restaurant. ");
                    randomGroup.GesamtKostGuestGroup(randomWaiter);
              
                    break;
                }
                else if(i == _WaiterList.Count - 1)
                {
                    Console.WriteLine($"\"{randomGroup}\" verlässt enttäuscht das Restaurant!");
                    break;
                }
                else
                {
                    
                    Console.WriteLine($"Der {randomWaiter} hat keinen Platz mehr, es wird ein anderer gefragt... ");
                    i++;
                }
            }
            
        }



    }
}
