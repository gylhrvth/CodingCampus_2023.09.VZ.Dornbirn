namespace Jovo.Week06._05Zoo
{
    internal class Pfleger
    {

        Random rand = new Random();

        private bool _isfed = false;
        private string _Name;
        private List<Enclosure> _Enclosures = new();
        private string _FavAnim;



        public List<Enclosure> Enclosures
        {
            get => _Enclosures;
            set => _Enclosures = value;
        }





        public Pfleger(string name, string favAnim, List<Enclosure> enclosures)
        {
            _Name = name;
            _Enclosures = enclosures;
            _FavAnim = favAnim;


        }

        public void PrintPfleger()
        {
            Console.WriteLine("│\t├──Pfleger:: {0}", _Name);
            foreach (var enclosure in _Enclosures)
            {
                enclosure.PrintEnclosure();
            }
        }


        public override string ToString()
        {
            return "Name: " + _Name;
        }

        public void PrintFoodSimulation()
        {
            foreach (Enclosure enclosure in Enclosures)
            {
                foreach (Animals animal in enclosure.AnimalsList)
                {
                    if (enclosure.IsFed == false)
                    {

                        Console.WriteLine($"{_Name} feeds the animal {animal.Genus} with the name {animal.Name}, in enclosure {enclosure.Description}, with the {animal.Food} ");
                        enclosure.ObserveAnimals(_FavAnim);
                        
                    }
                    
                }

                enclosure.IsFed = true;
            }
            



        }

        public void Simulate()
        {
            PrintFoodSimulation();
        }



    }


}
