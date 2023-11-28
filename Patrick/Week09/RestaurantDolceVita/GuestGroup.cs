using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrick.Week09.RestaurantDolceVita
{
    public class GuestGroup
    {
        private string _Name;
        private int _GroupSize;
        private List<Menu> _MenuList;

        public int GroupSize
        {
            get => _GroupSize;
        }

        public GuestGroup(string name, int groupSize)
        {
            _Name = name;
            _GroupSize = groupSize;
            _MenuList = new List<Menu>();
        }

        public void AddMenuList(Menu menu)
        {
            if(!_MenuList.Contains(menu))
            {
                _MenuList.Add(menu);
            }
        }

        public double GesamtKostGuestGroup(Waiter waiter)
        {
            foreach(Menu m in _MenuList)
            {
                waiter.TotalCash += m.Price;
            }
            return waiter.TotalCash;
        }

        public override string ToString()
        {
            return _Name;
        }

        
    }
}
