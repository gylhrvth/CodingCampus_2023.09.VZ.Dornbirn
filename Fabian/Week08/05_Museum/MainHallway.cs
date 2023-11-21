namespace Fabian.Week08._05_Museum
{
    public class MainHallway : Hallway
    {
        private bool _IsOpen;

        public MainHallway(string name) : base(name)
        {
            _Name = name;
            _IsOpen = true;
        }


    }
}
