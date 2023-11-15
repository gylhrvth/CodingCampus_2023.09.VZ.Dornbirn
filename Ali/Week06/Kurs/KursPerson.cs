using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ali.Week06.Kurs
{
    public class KursPerson
    {
        private string _Name;
        private int _Age;
        private int _Height;
        private int _Weight;

        public string Name
        {
            get => "\"" + _Name + "\"";
        }
        public KursPerson(string name, int age, int height, int weigth)
        {
            _Name = name;
            _Age = age;
            _Height = height;
            _Weight = weigth;
        }

        public override string ToString()
        {
            return string.Format("Person: {0}, age: {1}", _Name, _Age);
        }
    }
}
