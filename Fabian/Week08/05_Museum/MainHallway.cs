namespace Fabian.Week08._05_Museum
{
    public class MainHallway : Hallway
    {
        
        private bool _IsOpen;
        public List<Visitor> Visitors {  get; set; }
        public MainHallway(string name) : base(name)
        {
            _IsOpen = true;
            Visitors = new List<Visitor>();
        }

        public void SendVistorsToRooms()
        {
            foreach (var visitor in Visitors)
            {
                int randomRoom = rnd.Next(Neighbours.Count);
                Console.WriteLine($"{visitor.Name} went to {Neighbours[randomRoom].Name}");
                visitor.Room = Neighbours[randomRoom];
                visitor.WatchArtwork();
            }
        }

    }
}
