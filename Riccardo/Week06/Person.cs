using System;
using System.Xml.Linq;
namespace Riccardo.Week06;

public class Person
{

    private int _Height;
    private int _Age;
    private string _Name;
    private int _Weight;

    public string Name { get => _Name; }

    public int Age { 
        get => _Age;
        set 
        { 
            if (value >= _Age && value < 130)
            {
                _Age = value;
            }
            else
            {
                Console.WriteLine("Age {0} is not allowed for {1}", value, _Name);
            }
        }
    }

    public Person(int height, int age, string name, int weight)
    {
        _Height = height;
        _Age = age;
        _Name = name;
        _Weight = weight;
    }

    public override string ToString()
    {
        return String.Format("Name: {0}\nAge; {1}\nHeight: {2}\nWeight: {3}", _Name, _Age, _Height, _Weight);
    }
}