namespace Timo.Week08._053Museum
{
    public class Hallway : Room
    {
        protected Random rnd = new();

        public Hallway(string name) : base(name)
        {

        }

        protected override void PrintMyself(string prefix)
        {
            Console.Write($"{prefix} Hallway: {_Name}");
        }
    }
}
