namespace Jovo.Week06._05Zoo
{
    internal class Pfleger
    {

        Random rand = new Random();

        private bool _isfed = false;
        private string _Name;
        private List<Enclosure> _Enclosures = new();
        private string _FavAnim;



        public Pfleger(string name, string favAnim, List<Enclosure> enclosures)
        {
            _Name = name;
            _Enclosures = enclosures;
            _FavAnim = favAnim;


        }

        public List<Enclosure> Enclosures
        {
            get => _Enclosures;
            set => _Enclosures = value;
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

                        Console.WriteLine($"{animal.Genus} is HUNGRY!! {_Name} feeds {animal.Genus} with the name {animal.Name}, with the {animal.Food}\n{animal.Genus} is now satisfied: {animal.Sound}");
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
