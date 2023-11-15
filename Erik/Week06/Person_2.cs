using System;


namespace Erik.Week06
{
    public class Person_2
    {
        private int _Height;
        private int _Age;
        private string _Name;
        private int _Weight;
        private string _BornInCity;

        public int Height { get => _Height; }
        public int Age { get => _Age; }
        public string Name { get => _Name; }
        public int Weight { get => _Weight; }
        public string BornInCity { get => _BornInCity; }


        public Person_2(int height, int age, string name, int weight, string bornInCity)
        {
            _Height = height;
            _Age = age;
            _Name = name;
            _Weight = weight;
            _BornInCity = bornInCity;
        }

        public override string ToString()
        {
            return String.Format("Name: {0}\nAge: {1}\nHeight: {2}cm\nWeight: {3}kg\nBorn in the City: {4}", _Name, _Age, _Height, _Weight, _BornInCity);
        }
    }
}