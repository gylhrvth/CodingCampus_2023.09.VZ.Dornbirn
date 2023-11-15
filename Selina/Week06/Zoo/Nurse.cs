using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selina.Week06.Zoo
{
    public class Nurse
    {
        private string _Name;
        private int _Age;
        private string _Gender;
       
        public Nurse(string name, int age, string gender)
        {
            this._Name = name;
            this._Age = age;
            this._Gender = gender;
        }
        public void PrintZoo()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($"|       |-- {_Name}, {_Gender}");
            Console.ForegroundColor = ConsoleColor.White;

        }
    }
}
