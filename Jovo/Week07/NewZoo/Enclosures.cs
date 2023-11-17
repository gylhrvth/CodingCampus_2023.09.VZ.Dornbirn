using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Jovo.Week07.NewZoo
{
    internal class Enclosures
    {
        private string Name;
        private string Description;
        private string Climate;
        

        public Enclosures(string name, string description, string climate)
        {
            this.Name = name;
            this.Description = description;
            this.Climate = climate;

        }



        public void PrintZooEnclosures()
        {
            Console.WriteLine($"│   ├── {Name}, {Description}, {Climate}");
        }
    }
}
