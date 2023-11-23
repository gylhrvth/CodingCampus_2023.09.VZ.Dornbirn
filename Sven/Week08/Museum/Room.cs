namespace Sven.Week08.Museum
{
    public abstract class Room
    {
        private string _Name;
        private List<Room> _RoomNeighbours = new();
        private List<Human> _HumansList = new();

        public string name { get => _Name; }

        public Room(string name)
        {
            _Name = name;
        }

        public void AddRoom(Room room)
        {
            _RoomNeighbours.Add(room);
        }

        public void AddHuman(Human human)
        {
            _HumansList.Add(human);
        }

        public void RemoveHuman(Human human)
        {
            _HumansList.Remove(human);
        }

        public List<Room> GetRoomNeighbours()
        {
            return _RoomNeighbours;
        }


        public virtual void RemoveArtwork(Artwork artwork)
        {

        }


        public void CheckHumanList()
        {

            for (int i = _HumansList.Count - 1; i >= 0; i--)
            {
                Human human = _HumansList[i];
                //human.RandomNextRoom();
                if (!Museum._CheckedHumans.Contains(human))
                {
                    if (human.HumanAction())
                    {
                    }
                    else
                    {
                        human.RandomNextRoom();
                    }
                    Museum._CheckedHumans.Add(human);
                }
            }


        }
        public abstract Artwork GetRandomArtwork();


        public int CountGuards()
        {
            int count = 0;

            foreach (Human hum in _HumansList)
            {
                if (hum.GetType() == typeof(Guard)) count++;
            }

            return count;
        }


        public int CountPeople()
        {
            return _HumansList.Count();
        }
    }



}
