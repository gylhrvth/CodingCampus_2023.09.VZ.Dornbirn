using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martin.Week06
{
    public class OOP
    {
        private string _Name;
        public OOP(string Name) {
            _Name = Name;
        }
        public static void Start()
        {
            Console.WriteLine("Hello World");
            StartPrivate();
        }

        private static void StartPrivate()
        {
            Console.WriteLine("This is a private function");
        }

        public string GetHello()
        {
            return "Hello " + _Name + " !!!";
        }
    }
}
