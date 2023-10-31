namespace Fabian.Week06._01Person
{
    public class Person
    {
        private int _Height;
        private int _Age;
        private string _Name;
        private double _Weight;
        public int Height
        {
            get => _Height;
            set
            {
                if (Height <= 0)
                {
                    Console.WriteLine("height can't be below 1");
                }
                else
                {
                    _Height = value;
                }
            }
        }

        public int Age
        {

            get => _Age;
            set
            {
                if (Age <= 0)
                {
                    Console.WriteLine("age can't be below 1");
                }
                else
                {
                    _Age = value;
                }
            }
        }
        public string Name
        {
            get => _Name;
            set
            {
                if (Name == "")
                {
                    Console.WriteLine("name can't be empty");
                }
                else
                {
                    _Name = value;
                }
            }
        }

        public double Weight
        {
            get => _Weight;
            set
            {
                if (Weight <= 0)
                {
                    Console.WriteLine("weight can't be below 1");
                }
                else
                {
                    _Weight = value;
                }
            }
        }
        public Person(string name, int age, int height, double weight)
        {
            _Name = name;
            _Age = age;
            _Height = height;
            _Weight = weight;
        }
        
        public override string ToString()
        {
            return string.Format("Name: {0}\nAge: {1}\nHeight: {2}\nWeight: {3}", 
                _Name,
                _Age,
                _Height,
                _Weight);
        }
    }
}
