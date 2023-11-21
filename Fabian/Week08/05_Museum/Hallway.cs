namespace Fabian.Week08._05_Museum
{
    public class Hallway : IRoom
    {
        protected Random rnd = new();
        public List<IRoom> Neighbours { get; set; }
        public string Name { get; set; }


        public Hallway(string name)
        {
            Name = name;
            Neighbours = new List<IRoom>();
        }


    }
}
