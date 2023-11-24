using System;
namespace Mohammed.Week07.Zoo02
{
    public class Animals
    {
        private string _Name;
        private string _Genus;
        private int _Age;
        private string _Gender;
        private List<Food> _FoodList;


        private string Name
        {
            get => _Name;
        }

        private string Genus
        {
            get => _Genus;
        }

        private int Age
        {
            get => _Age;
        }

        private string Gender
        {
            get => _Gender;
        }

        public Animals(string name, string genus, int age, string gender)
        {
            _Name = name;
            _Genus = genus;
            _Age = age;
            _Gender = gender;
        }

        public void PrintAnimals()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"    ├──{_Name}, {_Genus}, {_Age}, {_Gender}");
            
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

