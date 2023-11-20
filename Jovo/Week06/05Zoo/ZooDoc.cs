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
        public void Heal(Animals LowLifeAnimal)
         {
             double random = (double)rnd.Next(30, 100) / 100;
             int heal = (int)(random * LowLifeAnimal.MaxLife);
             if ((LowLifeAnimal.Life + heal) > LowLifeAnimal.MaxLife)
             {
                 Console.WriteLine($"{_Name} healed {LowLifeAnimal.Name} for {LowLifeAnimal.MaxLife - LowLifeAnimal.Life} health {LowLifeAnimal.Name} new life ist now:{LowLifeAnimal.Life}HP.");
                LowLifeAnimal.Life = LowLifeAnimal.MaxLife;
             }
             else
             {
                 Console.WriteLine($"{_Name} healed {LowLifeAnimal.Name} for {heal} health.");
                LowLifeAnimal.Life += heal;
             }



         }

       
    }
}
