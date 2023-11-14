namespace Sven.Week07
{
    internal class Enclosure
    {

        private string _Name;
        private string _Description;
        private string _Climate;

        public Enclosure(string description, string climate, string name)
        {
            _Description = description;
            _Climate = climate;
            _Name = name;

        }
        public void PrintZoo()
        {
            Console.WriteLine($" --- Enclosure: {_Description}, {_Climate}, {_Name}");

        }
    }
}
