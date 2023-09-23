//Aufgabe Zählen mit Schleifen
Console.WriteLine("Aufgabe 1.1: zählen mit for-Schleife");

//for i Schleife mit der Länge 10 und der bedingung so lange zu zählen, wie i kleiner ist als 10 und bis i = 10
//ohne = 10, wird die Schleife nur bis Neun zählen.

for (int i = 0; i <= 10; i++)
{
    Console.WriteLine(i);
}
Console.WriteLine("_-Optional-_");

//optionale Lösung, ohne das = zu verwenden, könnte man auch einfach die 10 um eins erhöhen.

for (int i = 0; i < 11; i++)
{
    Console.WriteLine("optional: " + i);
}

Console.WriteLine("--------------------------");
Console.WriteLine("Aufgabe 1.2: zählen mit while-Schleife");

//die While Schleife benötigt als erstes eine Variable, welche wir zu beginn mit einem integer inizialisieren
//dadurch lässt sich eine Prüfung erstellen wie lange die Schleife laufen soll.
//while (solange) counter (unsere Variable startet mit 0) kleiner oder gleich genau zehn ist, läuft die Schleife

int counter = 0;
while (counter <= 10)
{
    Console.WriteLine(counter);
    counter++;
}

Console.WriteLine("--------------------------");
Console.WriteLine("Aufgabe 2: zählen exclusive 10");

//Wie bereits oben kann man dies auf zwei arten lösen, einmal die schleife bis 9 zählen, und indem man ohne das = 

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}

Console.WriteLine("--------------------------");
Console.WriteLine("Aufgabe 3: nur gerade zahlen printen");


//Modulo Opertor nur gerade Zahlen printen

for (int i = 0; i <= 10; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}

Console.WriteLine("--------------------------");
Console.WriteLine("Aufgabe 3: nur gerade zahlen printen");


//Modulo Opertor nur ungerade Zahlen printen

for (int i = 0; i <= 10; i++)
{
    if (i % 2 == 1)
    {
        Console.WriteLine(i);
    }
}


Console.WriteLine("--------------------------");
Console.WriteLine("Aufgabe 3: jede dritte zahl printen");


//Modulo Opertor nur ungerade Zahlen printen

for (int i = 0; i <= 20; i++)
{
    if (i % 3 == 0)
    {
        Console.WriteLine(i);
    }
}


Console.WriteLine("--------------------------");
Console.WriteLine("Aufgabe 4: rückwerts zählen");


//Modulo Opertor nur ungerade Zahlen printen

for (int i = 10; i >= -10; i--)
{
    Console.WriteLine(i);
}








Console.WriteLine();
Console.WriteLine("Press any Key to Exit Console ...");
Console.ReadKey();