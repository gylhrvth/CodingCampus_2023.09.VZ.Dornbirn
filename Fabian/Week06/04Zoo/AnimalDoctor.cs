namespace Fabian.Week06._04Zoo
{
    public class AnimalDoctor
    {
        private readonly Random rnd = new();
        private string _Name;

        public AnimalDoctor(string name)
        {
            _Name = name;
        }

        public void Heal(Animal min)
        {
            double random = (double)rnd.Next(30, 100) / 100;
            int heal = (int)(random * min.MaxHealth);
            if ((min.Health + heal) > min.MaxHealth)
            {
                Console.WriteLine($"{_Name} healed {min.Name} for {min.MaxHealth - min.Health} health.");
                min.Health = min.MaxHealth;                
            }
            else
            {
                Console.WriteLine($"{_Name} healed {min.Name} for {heal} health.");
                min.Health += heal;               
            }
            
           
        }

    }
}
