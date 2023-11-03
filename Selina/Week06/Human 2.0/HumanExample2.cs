using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selina.Week06.Human_2._0
{
    public class HumanExample2
    {

        public int _Size = 0;
        public int _Weight = 0;
        public int _Age = 0;
        private string _Name = "";
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

        public HumanExample2(string name, int age, int weigth, int size)
        {
            this._Age = age;
            this._Name = name;
            this._Size = size;
            this._Weight = weigth;
        }

        public override string ToString()
        {
            return string.Format($"\nDein Name ist: {_Name, 6}, deine Größe ist: {_Size, 6}, dein Alter ist: {_Age,6}, dein Gewicht ist: {_Weight,6}");
        }

    }
}
