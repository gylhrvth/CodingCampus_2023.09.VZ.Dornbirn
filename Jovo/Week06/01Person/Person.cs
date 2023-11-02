using System;

namespace Jovo.Week06
{
    public class Person
    {
        private string _Name;
        private int _Age;
        private int _Height;
        private int _weight;



        public string Name
        {
            get => _Name;

            set
            {
                Console.WriteLine("New Name is:" + value);
                _Name = value;
            }
        }

        public int Age
        {
            get => _Age;

            set
            {
                Console.WriteLine("New Age:" + value);
                _Age = value;
            }
        }


        public int Height
        {

            get => _Height;

            set
            {
                Console.WriteLine("New Height:" + value);
                _Height = value;
            }
        }


        public int Weight
        {
            get => _weight;

            set
            {
                Console.WriteLine("New weight:" + value);
                _weight = value;
            }

        }

        
        public Person(string name, int age, int size, int weight)
        {
            _Name = name;
            _Age = age;
            _Height = size;
            _weight = weight;
            

        }

        public override string ToString()
        {
            return string.Format("Name: {0}\nAge: {1}\nsize: {2}\nweight: {3}",
                _Name,
                _Age,
                _Height,
                _weight);

        }
    }
}
