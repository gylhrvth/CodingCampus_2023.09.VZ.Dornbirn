namespace Kerem
{
    public class Person
    {
        private string _Name;
        private int _Age;
        private float _Height;
        private float _Weight;

        public string Name
        {
            get => _Name;
            set
            {
                if (value != "")
                {
                    _Name = value;
                }
                else
                {
                    Console.WriteLine("Name cannot be empty");
                }
            }

        }
        public int Age  { 
            get => _Age;
            set
            {
                Console.WriteLine("Age changed to :" + value);
                _Age = value;

            }

        }



        public Person(string name, int age, int height, float weight)
        {
            _Name = name;
            _Age = age;
            _Height = height;
            _Weight = weight;
        }

        public override string ToString()
        {
            return string.Format("Name: {0}\nAge: {1}\nHeight {2}\nWeight: {3}", _Name, _Age, _Height, _Weight);
        }
    }
}
