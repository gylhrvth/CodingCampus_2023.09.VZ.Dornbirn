using System;
using System.Threading.Channels;

namespace David.Week05
{
	public class ToDoListe
	{
		public static void Start()
		{
			// Anwendung: To_do-List
			// Add, View, Delete, Quit

			string[] todoList = new string[10];
			int currentTaskCount = 0;

			string command = "";

			while (command != "quit")
			{
				Console.WriteLine("Please enter a command (add, view, delete, quit");
				command = Console.ReadLine().ToLower();

				if (command == "add")
				{
					if (currentTaskCount < todoList.Length)
					{

						Console.WriteLine("Please enter a task to add: ");
						string task = Console.ReadLine();
						todoList[currentTaskCount] = task;
						currentTaskCount++;

					}
					else
					{
						Console.WriteLine("List Full");
					}


				}else if(command == "view")
				{
					Console.WriteLine("Your current tasks are:");

					for (int i = 0; i < currentTaskCount; i++)
					{
						Console.WriteLine((i + 1) + ". " + todoList[i]);
					}
				}
				else if (command == "delete")
				{
					Console.WriteLine("Please enter the task to delete:");
					int userDelteNumber = int.Parse(Console.ReadLine()) -1;

					if (userDelteNumber < 0|| userDelteNumber >= currentTaskCount)
					{
						Console.WriteLine("Invalid task number.");
					}
					else
					{
						for (int i = userDelteNumber; i < currentTaskCount - 1; i++)
						{
							todoList[i] = todoList[i + 1];
						}
						currentTaskCount--;
						Console.WriteLine("Task removed.");
					}
				}else if(command == "quit")
				{
					Console.WriteLine("Good bye!");
				}
            }

		}
	}
}

