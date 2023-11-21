using System;
namespace David.Week07.ZooNew
{
    //Properties oder Eigenschaften
    public class Animals
    {
        private string _Name;
        private string _Genus;
        private int _Age;
        private string _Gender;
        private List<Food> _FoodList;


        //Beispiel von get für mich, auch wenn nicht in Verwendung.
        private string Name
        {
            get => _Name;
        }

        //Konstruktor
        public Animals(string name, string genus, int age, string gender)
        {
            _Name = name;
            _Genus = genus;
            _Age = age;
            _Gender = gender;
            _FoodList = new List<Food>();
        }

        public void PrintAnimals()
        {
            Console.WriteLine($"     --->{_Name}, {_Genus}, {_Age}, {_Gender}");
        }

        public void FillFoodList(Food food)
        {
            if (!_FoodList.Contains(food))
            {
                _FoodList.Add(food);
            }
        }
    }
}

