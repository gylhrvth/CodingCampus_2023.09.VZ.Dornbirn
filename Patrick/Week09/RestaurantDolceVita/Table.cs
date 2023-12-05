using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrick.Week09.RestaurantDolceVita
{
    public class Table
    {
        private string _Name;
        private int _TableSizePeople;
        private bool _Free = true;

        public bool Free
        {
            get => _Free; 
            set => _Free = value;
        }

        public int TableSizePeople
        {
            get => _TableSizePeople;
        }

        public Table(string name, int tableSizePeople)
        {
            _Name = name;
            _TableSizePeople = tableSizePeople;
        }

        public override string ToString()
        {
            return _Name;
        }

    }
}
