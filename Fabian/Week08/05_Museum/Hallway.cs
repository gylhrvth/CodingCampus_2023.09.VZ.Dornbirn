namespace Fabian.Week08._05_Museum
{
    public class Hallway : Room
    {
        protected Random rnd = new();
        public Hallway(string name, int distanceToExit) : base(name, distanceToExit)
        {

        }

        public override Artwork GetRandomArtwork()
        {
            return null;
        }

        public override void PrintAction(Visitor v)
        {
            Console.WriteLine($"{v.Name} is going through the {_Name}");
        }

        protected override void PrintMyself(string prefix)
        {
            Console.Write($"{prefix} Hallway: {_Name}");
        }
    }
}
