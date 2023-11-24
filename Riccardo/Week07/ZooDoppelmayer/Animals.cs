using System;

namespace Riccardo.Week07.ZooDoppelmayer
{
    internal class Animals
    {

        private string _Name;
        private int _Age;
        private string _Genus;
        private string _Gender;
        private Food _Food;
        private int _FoodAmount;

        public Animals(string name, int age, string genus, string gender, Food food, int foodAmount)
        {
            _Name = name;
            _Age = age;
            _Genus = genus;
            _Gender = gender;
            _Food = food;
            _FoodAmount = foodAmount;
        }


        public void PrintZoo()
        {
            Console.WriteLine($" --- --- {_Name},{_Age},{_Gender},{_Genus}, eats : {_FoodAmount} {_Food}");
        }

        /*
        private string _Name;
        private string _Genus;
        private string _Enclosure;
       
        public Animals(string Name, string Genus)
        {
            _Name = Name;
            _Genus = Genus;
            _EnclosureList = new List<Enclosure()>;

        }

        public void PrintStructure()
        {
            Console.WriteLine("├── {0}, {1}",
                _Name,
                _Genus);
            foreach (Enclosure enc in _EnclosureList)
            {
                enc.PrintStructure();
            }
        }
        */
    }
}
