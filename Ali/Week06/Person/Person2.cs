using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ali.Week06.Person
{
    public class Person2
    {
        private string _name;
        private int _Countweight;
        private int _Countage;
        private int _Countheight;

        public string Name
        {
            get => _name;
            set
            {
                Console.WriteLine("The Name of the Person is: "+ value);
                _name = value;
            }
        }
        public int Countweight
        {
            get => _Countweight;
            set
            {
                Console.WriteLine("The weight of the Person is: " + value);
                _Countweight = value;
            }

        }
        public int CountAge
        {
            get => _Countage;
            set
            {
                Console.WriteLine("The age of the Person is: " + value);
                _Countage = value;
            }
        }
        public int CountHeight
        {
            get => _Countheight;
            set
            {
                Console.WriteLine("The height of the Person is:" + value );
                _Countheight = value;
            }
        }
        

        public Person2(string name, int Countweight, int Countage, int Countheight)
        {
           _name = name;
           _Countweight = Countweight;
           _Countage = Countage;
           _Countheight = Countheight;
        }
        public override string ToString()
        {
            return string.Format("Name: {0}\nCount Weight: {1}\nCount Age: {2}\nCount Height: {3}",
            _name,
            _Countweight,
            _Countage,
            _Countheight);


        }
    }
}
