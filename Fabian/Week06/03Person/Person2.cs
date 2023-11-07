namespace Fabian.Week06._03Person
{
    public class Person2
    {
        private string _Name;
        private int _Age;
        private int _Height;
        private double _Weight;

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
        public int Height
        {
            get => _Height;
            set => _Height = value;
        }
        public double Weight
        {
            get => _Weight;
            set => _Weight = value;
        }
        
        public Person2(string name, int age, int height, double weight)
        {
            _Name = name;
            _Age = age;
            _Height = height;
            _Weight = weight;
        }
        
    }
}
