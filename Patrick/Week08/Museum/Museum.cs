using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrick.Week08.Museum
{
    public class Museum
    {
        private string _Name;
        private List<ExhibitionRoom> _RoomList;
        private List<Hallway> _HallwayList;
        private DateTime _OpeningTime;
        private DateTime _ClosingTime;

        public Museum(string name, DateTime openingTime, DateTime closingTime)
        {
            _Name = name;
            _OpeningTime = openingTime;
            _ClosingTime = closingTime;
            _RoomList = new List<ExhibitionRoom>();
            _HallwayList = new List<Hallway>();
        }

    }

   
}
