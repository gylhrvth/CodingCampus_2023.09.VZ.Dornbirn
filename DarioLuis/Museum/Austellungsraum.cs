﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarioLuis.Museum
{
    public  class Austellungsraum:Raum
    {
        public Austellungsraum(string name):base (name) 
        {
            
        }

        public override void PrintMich(string prefix)
        {
            Console.Write($"{prefix} Ausstellungsraum: {Name}");

        }
    }

}