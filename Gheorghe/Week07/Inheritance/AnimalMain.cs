namespace Gheorghe.Week07.Inheritance
{
    internal class AnimalMain
    {
        public AnimalMain()
        {

            Animal animal = new Animal { _Name = "Animal" };
            animal.Eat();

            Dog dog = new Dog { _Name = "Max" };
            dog.Eat(); // Inherited method from Animal
            dog.Bark(); // Unique method to Dog

            Cat cat = new Cat { _Name = "Kitty" };
            cat.Eat(); // Inherited method from Animal
            cat.Meow(); // Unique method to Cat

        }



    }
}
