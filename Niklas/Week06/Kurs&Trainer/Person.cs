using System;
namespace Niklas.Week06.Person
{
    public class Person2
    {
        private int _Size;
        public int Size
        {
            get => _Size;

            set
            {
                Console.WriteLine("Size is: " + value);
                _Size = value;
            }
        }


        private int _Age;
        public int Age
        {
            get => _Age;

            set
            {
                Console.WriteLine("Age is: " + value);
                _Age = value;
            }
        }

        private string _Name;
        public string Name
        {
            get => _Name;

            set
            {
                Console.WriteLine("Name is: " + value);
                _Name = value;
            }
        }

        private int _Weight;
        public int Weight
        {
            get => _Weight;

            set
            {
                Console.WriteLine("Weight is: " + value);
                _Weight = value;
            }
        }
        public Person2(int size, int age, string name, int weight)
        {
            _Size = size;
            _Age = age;
            _Name = name;
            _Weight = weight;
        }


        public override string ToString()
        {
            return string.Format("Person: {0}({1})", _Name, _Age);
        }



    }
}
