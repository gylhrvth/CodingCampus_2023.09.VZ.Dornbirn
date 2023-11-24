namespace Gheorghe.Week07.Inheritance
{
    internal class Animal
    {
        public Animal()
        {

            Console.WriteLine(_Name);

        }
        public string _Name { get; set; }

        public void Eat()
        {
            Console.WriteLine("The animal is eating.");
        }
    }

}





