using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarioLuis.Week06
{
    public  class OOPExamples
    {
        private string _Name;
        public OOPExamples(string name) 
        {
            _Name = name;
        }
        public static void Start()
        {
            Console.WriteLine("Hello World!");
            StartPrivate();
            
        }
        private static void StartPrivate()
        {
            Console.WriteLine("This is a private function.");
        }

    }
}
