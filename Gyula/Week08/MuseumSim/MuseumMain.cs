using System;
namespace Gyula.Week08.MuseumSim
{
	public class MuseumMain
	{
		public static void Start()
		{

			Hallway mainEntry = new Hallway("Entry");
			Museum neuePinakothek = new Museum("Neue Pinakothek", mainEntry);

			ExhibitionRoom room1 = new ExhibitionRoom("Raum 1");
			mainEntry.addNeighour(room1);

			ExhibitionRoom room2 = new ExhibitionRoom("Raum 2");
			room1.addNeighour(room2);

			neuePinakothek.PrintStructure("");

			Guest g = new Guest("Gustav");
			neuePinakothek.AddGuest(g);


			for (int i = 0; i < 10; i++)
			{
				neuePinakothek.Tick();
			}
		}
	}
}

