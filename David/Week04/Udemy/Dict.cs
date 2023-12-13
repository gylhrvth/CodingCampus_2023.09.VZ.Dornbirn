using System;
namespace David.Week04.Udemy
{
	public class Dict
	{
		public static void Start()
		{
			Dictionary<string, string> dic = new Dictionary<string, string>();
			dic.Add("Cart", "Warenkorb");
			dic.Remove("Cart");

			Dictionary<string, float> products = new Dictionary<string, float>();
			products.Add("Milch", 1.49f);
            products.Add("Brot", 2.99f);
            products.Add("Äpfel", 3.19f);

			//products["Milch"]; 


            Dictionary<int, Person> people = new Dictionary<int, Person>();
			people.Add(35, new Person());
			people.Remove(35);

			people.Clear();
		}
	}

	//Eigentlich in einer eigenen Klasse

	public class Person
	{
		// Properties

	}
}

