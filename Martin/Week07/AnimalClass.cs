using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martin.Week07
{
    public class AnimalClass
    {
        private string _Name;
        private int _Unit;
        private string _Art;
        private Futter _FoodClass;
        public AnimalClass(string Name, string Art,int Unit,Futter FoodClass)
        {
            _Name = Name;
            _Art = Art;
            _Unit = Unit; //Einheit
            _FoodClass = FoodClass;
            
        }

        public void FoodRequest(Dictionary<Futter,int> report)
        {
            if(report.ContainsKey(_FoodClass))
            {
                report[_FoodClass] += _Unit;
            }
            else
            {
                report.Add(_FoodClass, _Unit);
            }
        }


        public Futter FoodClass {  get { return _FoodClass; } }
        public string Name { get { return _Name; } }
        public string Art { get { return _Art; } }


        public int Unit { get { return _Unit; } }


    }
}
