using System;
namespace Mohammed.Week06.PersonEx
{
    public class PersonXXX
    {
        private string _Name;
        private float _Weight;
        private int _Year;
        private float _Height;


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


        public PersonXXX(string Name, float Weight, int Year, float Height)
        {
            _Name = Name;
            _Height = Height;
            _Year = Year;
            _Weight = Weight;
        }

        public override string ToString()
        {
            return string.Format("Name: {0}\nWeight: {1}\nYear: {2}\nHeight: {3}", _Name, _Weight, _Year, _Height);

        }


    }
}





