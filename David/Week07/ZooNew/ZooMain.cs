using System;
using Microsoft.Win32.SafeHandles;

namespace David.Week07.ZooNew
{
	internal class ZooMain
	{
		public static void Start()
		{
			Zoo zoo = new Zoo("Zoo of Lustenau", 2023, "Vorarlberg");

			ZooKeeper mohammed = new ZooKeeper("Mohammed");
			ZooKeeper patrick = new ZooKeeper("Patrick");
			ZooKeeper david = new ZooKeeper("David");

			Enclosure forest = new Enclosure("Forest", "Outdoor");
			Enclosure savanna = new Enclosure("Savanna", "Outdoor");
			Enclosure seaworld = new Enclosure("Sea world", "Indoor");
			Enclosure cave = new Enclosure("Cave world", "Indoor");

			Animals deer = new Animals("Deer", "Austrian Deer", 3, "male");
			Animals wolf = new Animals("Wolf", "Gray Wolf", 4, "female");
			Animals bear = new Animals("Bear", "Big Bear", 15, "male");
			Animals lion = new Animals("Lion", "African Lion", 10, "male");
			Animals zebra = new Animals("Zebra", "Black'n'White", 6, "feamale");
			Animals onix = new Animals("Onix", "Namibian Onix", 8, "male");
			Animals whale = new Animals("Whale", "Big Whale", 82, "Male");
			Animals dolfin = new Animals("Dolfin", "Pink Dolfin", 12, "Male");
			Animals bat = new Animals("Bat", "Bat Man", 42, "Male");
			Animals spider = new Animals("Spider", "Spider Man", 40, "Male");

			zoo.FillZooKeeperList(mohammed);
			zoo.FillZooKeeperList(patrick);
			zoo.FillZooKeeperList(david);

			mohammed.FillEnclosureList(forest);
            patrick.FillEnclosureList(savanna);
            patrick.FillEnclosureList(seaworld);
            david.FillEnclosureList(cave);

			forest.FillAnimalList(deer);
			forest.FillAnimalList(wolf);
			forest.FillAnimalList(bear);
			savanna.FillAnimalList(lion);
			savanna.FillAnimalList(zebra);
			savanna.FillAnimalList(onix);
			seaworld.FillAnimalList(whale);
			seaworld.FillAnimalList(dolfin);
			cave.FillAnimalList(bat);
			cave.FillAnimalList(spider);

            zoo.PrintStructure();
		}
	}
}

