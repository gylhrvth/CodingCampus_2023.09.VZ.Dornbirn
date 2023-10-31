using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabienne.Week06
{
    public class ObjektOrientiert
    {
        private string _Name;
        public ObjektOrientiert(string Name) 
        { 
            _Name = Name;
        }
        public static void Start()
        {
            Console.WriteLine("Hello World");
            StartPrivate();
        }
        private static void StartPrivate()
        {
            Console.WriteLine("This is private");
        }
        public string GetHello()
        {
            return "Hello " + _Name + "!!! ";
        }
    }
}
