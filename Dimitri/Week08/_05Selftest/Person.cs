using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dimitri.Week08._05Selftest
{
    public class Person
    {
        public static Random rnd = new Random();
        public enum Genderenum
        {
            female,
            male,
            divers
        }
        private string _Name;
        private int _Age;
        private Genderenum _Gender;

        public Person(string name, int age, Genderenum gender)
        {
            _Name = name;
            _Age = age;
            _Gender = gender;
        }

        public string Name
        {
            get => _Name;
            set => _Name = value;
        }

        public int Age
        {
            get => _Age;
            set => _Age = value;
        }

        public Genderenum Gender
        {
            get => _Gender;
            set => _Gender = value;
        }

        public string ToString()
        {
            return string.Format("Name: {0} Age: {1} Gender: {2}", _Name, _Age, _Gender);
        }

        public static Genderenum FindRandomGender()
        {
            int i = rnd.Next(0, 3);

            if (i == 0)
            {
                return Genderenum.female;
            }
            else if (i == 1)
            {
                return Genderenum.male;
            }
            else
            {
                return Genderenum.divers;
            }

        }
    }
}
