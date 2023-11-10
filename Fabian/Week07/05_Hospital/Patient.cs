
namespace Fabian.Week07._05_Hospital
{
    public class Patient
    {
        private string _Name;
        private int _Age;
        private string _Illness;
        private Room _Room;

        public Room Room
        {
            get => _Room;
            set => _Room = value;
        }

        public string Name { get => _Name; }
        public string Illness { get => _Illness; }
        public Patient(string name, int age, string illness)
        {
            _Name = name;
            _Age = age;
            _Illness = illness;

        }

        public void PrintPatients()
        {
            Console.WriteLine($"│\t\t\t├── {_Name}({_Age}): {_Illness}");
        }
    }
}
