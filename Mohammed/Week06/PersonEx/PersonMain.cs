using Mohammed.Week06.KursUndTrainer;
namespace Mohammed.Week06.PersonEx
{
	public class PersonMain
	{
		public static void Start() 
		{
			Person p = new Person("alsaraji", 80, 21, 188);

			

			Console.WriteLine(p);

			Console.WriteLine(p.Name);
			p.Name = "Mohammad";

			Console.WriteLine(p);
		}
	}
}

