namespace Selina.Week06.Trainer
{
    public class Trainer
    {
        public int _Size;
        public int _Weight;
        public int _Age;
        private string _Name;
        public int Size
        {
            get => _Size;
            set
            {
                Console.WriteLine("Die Größe ist: " + value);
                _Size = value;
            }
        }
        public int Weigth
        {
            get => _Weight;

            set
            {
                Console.WriteLine("Das Gewicht ist: " + value);
                _Weight = value;
            }
        }
        public int Age
        {
            get => _Age;
            set
            {
                if (value < 0 || value > 130)
                {
                    Console.WriteLine("Das Alter ist unglaubswürdig: " + value);
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
        }

        public Trainer(string name, int age, int weigth, int size)
        {
            _Age = age;
            _Name = name;
            _Size = size;
            _Weight = weigth;
        }
    }
}
