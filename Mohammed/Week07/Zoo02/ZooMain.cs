using System;
namespace Mohammed.Week07.Zoo02
{
	public class ZooMain
	{
		public static void Start()
		{
			Zoo zoo = new Zoo("Zoo of Goetzis ", 2024, "Goetzis", " ");

			Enclosure cava = new Enclosure("Cava", "Indoor");
			Enclosure savanna = new Enclosure("Savanna", "Outdoor");
			Enclosure seaword = new Enclosure("seaword", "Indoor");
			Enclosure underwater = new Enclosure("underwater", "Indoor");


			Animals lion = new Animals("lo", "Snowlion", 3, "female");
			Animals fish = new Animals("cheche", "Amsee", 1, "female");
			Animals bear = new Animals("bearle", "snowbear", 5, "male");
			Animals horse = new Animals("horseli", "reistsprt", 9, "female");
			Animals Cow = new Animals("yellowcow", "cow", 8, "male");
			Animals spiderman = new Animals("newyourker", "man", 14, "male");
			
			ZooKeeper keeper1 = new ZooKeeper("David");
			ZooKeeper keeper2 = new ZooKeeper("Patrick");
			ZooKeeper keeper3 = new ZooKeeper("Diemitri");
			ZooKeeper keeper4 = new ZooKeeper("Ali");

			zoo.FillZooKeeperList(keeper1);
			zoo.FillZooKeeperList(keeper2);
			zoo.FillZooKeeperList(keeper3);
			zoo.FillZooKeeperList(keeper4);



			cava.FillAnimalList(lion);
			savanna.FillAnimalList(fish);
			seaword.FillAnimalList(bear);
			underwater.FillAnimalList(horse);
			cava.FillAnimalList(Cow);
			savanna.FillAnimalList(spiderman);


			keeper1.AddEnclosure(cava);
			keeper2.AddEnclosure(savanna);
			keeper3.AddEnclosure(seaword);
			keeper4.AddEnclosure(underwater);

			zoo.ZooKeeperList.Add(keeper1);
			zoo.ZooKeeperList.Add(keeper2);
			zoo.ZooKeeperList.Add(keeper3);
			zoo.ZooKeeperList.Add(keeper4);



			zoo.PrintStructure();
			Console.WriteLine();
			
			
		}


	}
}

