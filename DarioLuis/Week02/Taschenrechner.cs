namespace DarioLuis.Week02
{
    class Taschenrechner
    {
        public static void Start()
        {
            bool again = true;

            while (again)
            {

                //Wilkommen
                Console.WriteLine("Hallo und Herzlich willkommen beim Taschenrechner von Dario");

                //num1
                Console.Write("Gib deine erste Zahl ein: ");
                double num1 = Convert.ToDouble(Console.ReadLine());


                //num2
                Console.Write("Gib deine zweite Zahl ein: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                //+,-,*,/
                Console.WriteLine("Was magst du mit den Zahlen machen?(+, -, *, /)?");
                char eingabe = Convert.ToChar(Console.ReadLine());



                switch (eingabe)
                {
                    //Addieren
                    case '+':
                        {
                            Console.WriteLine(num1 + " + " + num2 + " = " + (num1 + num2));
                        }
                        break;

                    //Subtrahieren
                    case '-':
                        {
                            Console.WriteLine(num1 + " - " + num2 + " = " + (num1 - num2));
                        }
                        break;

                    //Multiplizieren
                    case '*':
                        {
                            Console.WriteLine(num1 + " * " + num2 + " = " + (num1 * num2));
                        }
                        break;

                    //Dividieren
                    case '/':
                        {
                            if (num2 == 0)
                            {
                                Console.WriteLine("Du hast den Taschenrechner nicht einmal verdient wann du durch 0 dividierst");
                            }
                            else
                            {
                                Console.WriteLine(num1 + " / " + num2 + " = " + (num1 / num2));
                            }
                        }
                        break;

                    //Falsche Zeichen eingegeben
                    default:
                        {
                            Console.WriteLine("Wo warst du bitte in der Volkschule? Gib bitte nur +, -, *, / ein!!");
                        }
                        break;
                }

                Console.WriteLine("Magst du nochmal rechnen?(j/n)");
                String ans = Convert.ToString(Console.ReadLine());

                if (ans == "n")
                {
                    Console.WriteLine("Danke das du den Taschenrechner von Dario, man sieht sich sicher wieder einmal!");
                    again = false;
                }
            }
                Console.ReadKey();

            }
        }
    }
