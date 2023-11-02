using Riccardo.Week06.Book;
using System;
namespace Riccardo.Week06
{
    public class Person
    {

        private int _Height;
        private int _Age;
        private string _Name;
        private int _Weight;

        public string Name { get => _Name; }

        public int Age { get => _Age; }

        public Person(int height, int age, string name, int weight)
        {
            _Height = height;
            _Age = age;
            _Name = name;
            _Weight = weight;
        }
    }
}