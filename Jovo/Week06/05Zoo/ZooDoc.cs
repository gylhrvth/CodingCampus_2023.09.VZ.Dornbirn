namespace Jovo.Week06._05Zoo
{
    internal class ZooDoc
    {
        private readonly Random rnd = new();
        private string _Name;
        private List<Animals> _animalList = new List<Animals>();


        
        public ZooDoc(string name)
        {
            _Name = name;
            _animalList = new List<Animals>();
        }

        public void AddAnimal(Animals animal)
        {

            _animalList.Add(animal);
        }
        public void Heal(Animals min)
         {
             double random = (double)rnd.Next(30, 100) / 100;
             int heal = (int)(random * min.MaxLife);
             if ((min.Life + heal) > min.MaxLife)
             {
                 Console.WriteLine($"{_Name} healed {min.Name} for {min.MaxLife - min.Life} health.");
                 min.Life = min.MaxLife;
             }
             else
             {
                 Console.WriteLine($"{_Name} healed {min.Name} for {heal} health.");
                 min.Life += heal;
             }



         }

       
    }
}
