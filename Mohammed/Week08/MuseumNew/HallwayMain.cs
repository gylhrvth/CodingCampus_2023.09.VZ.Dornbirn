using System;
namespace Mohammed.Week08.MuseumNew
{
	public class HallwayMain : Hallway
	{
        private bool _IsOpen;

        public HallwayMain(string name) : base(name)
        {
            _IsOpen = true;
        }
    }
}

