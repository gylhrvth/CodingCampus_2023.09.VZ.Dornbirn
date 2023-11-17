using Hassan.Week06;

Person p = new Person("Hassan", 21, 188, 80);
Console.WriteLine(p.Name);

p.Name = "";
p.Name = "Paul";
Console.WriteLine(p.Name);

Console.WriteLine(p);