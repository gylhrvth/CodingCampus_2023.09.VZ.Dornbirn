using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mehmet.SelbstTest
{
    public class Person
    {
        private string _Name;
        private int _Age;
        private string _Gender;


        public string Name { get { return _Name; } }
        public int Age { get { return _Age; } }
        public string Gender { get { return _Gender; } }


        public Person(string name,int age, string gender) 
        {
            _Name = name;
            _Age = age;
            _Gender = gender;
        }

        public override string ToString()
        {
            return string.Format($"Name: {_Name}\nAge: {_Age}\nGender: {_Gender}");
        }



    }
}
