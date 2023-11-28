using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simon.OOP_Selbsttest.OOP_Houses
{
    public class Person
    {
        public enum EnumGender
        {
            female,
            male,
            diverse
        }

        private string _Name;
        private int _Age;
        private EnumGender _Gender;
        private int _Maxleangthname;

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public int Age
        {
            get { return _Age; }
            set { _Age = value; }
        }
        public EnumGender Gender
        {
            get { return _Gender; }
            set { _Gender = value; }
        }

        public Person(string name, int age, EnumGender gender)
        {
            _Name = name;
            _Age = age;
            _Gender = gender;
            _Maxleangthname = name.Length;
        }

        public override string ToString()
        {
            return string.Format("Name: {0,-7} Age: {1,2} Gender: {2,3}", _Name, _Age, _Gender);
        }


    }
}
