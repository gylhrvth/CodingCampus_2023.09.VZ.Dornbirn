using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrick.Week09.RestaurantDolceVita
{
    public class MainWaiter
    {
        private static string _Name;
        private List<Waiter> _WaiterList;

        public string Name
        {
            get => _Name;
        }

        public MainWaiter(string name)
        {
            _Name = name;
            _WaiterList = new List<Waiter>();
        }

        public void AddWaiterToList(Waiter waiter)
        {
            if (!_WaiterList.Contains(waiter))
            {
                _WaiterList.Add(waiter);
            }
        }

        public static void PrintMainWaiter()
        {
            Console.WriteLine("│   ├── " + _Name);
        }

        public override string ToString()
        {
            return Name;
        }

       
        
    }

}
