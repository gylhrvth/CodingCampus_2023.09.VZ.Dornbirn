using System.Runtime.CompilerServices;

namespace Selina.Week06.Zoo
{
    public class Zoo
    {
        private string _Name;
        private string _Locality;
        private int _FoundYear;
        private int _Capacity;
        private List<Gehege> _GehegeList;
        private List <Veterinarian> _VeterinarianList;
        public Zoo(string name, string locality, int foundYear, int capacity)
        {
            this._Name = name;
            this._Locality = locality;
            this._FoundYear = foundYear;
            this._Capacity = capacity;
            this._GehegeList = new List<Gehege>();  
            this._VeterinarianList = new List<Veterinarian>();
        }

        // Gehege und Tierarzt wird zu einer Liste in der Klasse Zoo hinzugefügt
        public void AddGehege(Gehege gehege)
        {
            if (!_GehegeList.Contains(gehege))
            {
                _GehegeList.Add(gehege);
            }
        }
        public void AddVeterinarian(Veterinarian veterinarian)
        {
            if (!_VeterinarianList.Contains(veterinarian))
            {
                _VeterinarianList.Add(veterinarian);
            }
        }

        public void FindAnimal(Animal animal)
        {
            foreach(Veterinarian vet in _VeterinarianList)
            {
                foreach (Gehege gehe in _GehegeList)
                {
                    gehe.VetHelpAnimal(animal);
                    Console.WriteLine($"Tierarzt {vet} behandelt {animal}");
                }
            }
        }

        // Food Price wird berechnet
        public Dictionary<Food, int> CalculateFoodPrice()
        {
            Dictionary<Food, int> report = new Dictionary<Food, int>();

            foreach (Gehege gehege in _GehegeList)
            {
                gehege.CalculateFoodRequest(report);
            }

            return report;
        }

        // Ausgabe für User
        public void PrintZoo()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"|-- Zoo: {_Name}, gegründet {_FoundYear} ");
            Console.ForegroundColor = ConsoleColor.White;

            foreach (Gehege gehege in _GehegeList)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"|   |-- Gehege: {gehege.Name}");
                Console.ForegroundColor = ConsoleColor.White;
                gehege.PrintZoo();
            }
        }
    }
}
