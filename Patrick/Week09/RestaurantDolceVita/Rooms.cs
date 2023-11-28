using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Patrick.Week09.RestaurantDolceVita
{
    public class Rooms
    {
        private string _RoomName;
       

        public Rooms(string roomName)
        {
            _RoomName = roomName;
          
        }


        public override string ToString()
        {
            return _RoomName;
        }


        


    }
}
