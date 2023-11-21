using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrick.Week08.Vehicle
{
    interface IVehicle                          //Interface erstellt, damit musst du JEDEM Vehicle eine Methode Move geben!
    {
        public void Move();
    }
}
