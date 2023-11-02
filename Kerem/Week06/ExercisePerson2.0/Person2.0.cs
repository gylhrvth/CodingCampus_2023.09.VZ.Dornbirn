using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kerem.Week06
{
    internal class Person2
    {
        private string _name;
        private int _height;
        private int _age;
        private int _weight;


        public Person(string name, int height, int age, int weight)
        {
            _name = name;
            _height = height;
            _age = age;
            _weight = weight;
        }
        public static List<Person> ListPerson()
        {
            var list = new List<Person>();


            return list;
        }
    }
 
}
