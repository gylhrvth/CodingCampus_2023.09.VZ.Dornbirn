using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrick.Week09.RestaurantDolceVita
{
    public class DolceVitaMain
    {
        public static void Start()
        {
            Restaurant dolceVita = new Restaurant("Dolce Vita traditionelle italienische Küche,  seit ", 1975);

            EntryRoom entryRoom = new EntryRoom("Eingangsbereich", true);
            Rooms room1 = new Rooms("Raum1");
            Rooms room2 = new Rooms("Raum2");
            Rooms room3 = new Rooms("Raum3");
            Rooms room4 = new Rooms("Raum4");

            MainWaiter mainWaiter = new MainWaiter("Gyula");
            Waiter waiter1 = new Waiter("Peter");
            Waiter waiter2 = new Waiter("Sebastian");
            Waiter waiter3 = new Waiter("Susanne");
            Waiter waiter4 = new Waiter("Sabine");

            Table talbe1Room1 = new Table("2 Personen", 2);
            Table talbe2Room1 = new Table("4 Personen", 4);
            Table talbe3Room1 = new Table("4 Personen", 4);
            Table talbe4Room1 = new Table("6 Personen", 6);

            Table talbe1Room2 = new Table("2 Personen", 2);
            Table talbe2Room2 = new Table("4 Personen", 4);
            Table talbe3Room2 = new Table("4 Personen", 4);
            Table talbe4Room2 = new Table("6 Personen", 6);

            Table talbe1Room3 = new Table("2 Personen", 2);
            Table talbe2Room3 = new Table("4 Personen", 4);
            Table talbe3Room3 = new Table("4 Personen", 4);
            Table talbe4Room3 = new Table("6 Personen", 6);

            Table talbe1Room4 = new Table("2 Personen", 2);
            Table talbe2Room4 = new Table("4 Personen", 4);
            Table talbe3Room4 = new Table("4 Personen", 4);
            Table talbe4Room4 = new Table("6 Personen", 6);

            GuestGroup group1 = new GuestGroup("Familie Eberhard", 6);
            GuestGroup group2 = new GuestGroup("Freunde", 4);
            GuestGroup group3 = new GuestGroup("Familie Slabschi", 2);
            GuestGroup group4 = new GuestGroup("Schatzis", 2);
            GuestGroup group5 = new GuestGroup("Familie Maier", 6);
            GuestGroup group6 = new GuestGroup("Firma Blum", 14);
            GuestGroup group7 = new GuestGroup("Familie Hämmerle", 6);
            GuestGroup group8 = new GuestGroup("Freunde", 2);
            GuestGroup group9 = new GuestGroup("Person Herbert", 1);
            GuestGroup group10 = new GuestGroup("Familie Haubenhofer", 3);
            GuestGroup group11= new GuestGroup("Firma SIE", 10);
            GuestGroup group12= new GuestGroup("Verliebten", 2);
            GuestGroup group13= new GuestGroup("Familie Kehr", 4);
            GuestGroup group14= new GuestGroup("Familie Moosmann", 6);

            Menu pasta = new Menu("pasta", 15.45);
            Menu pizza = new Menu("pizza", 20.45);
            Menu salat = new Menu("salat", 15.45);
            Menu tiramisu = new Menu("tiramisu", 10.45);
            Menu gnocci = new Menu("gnocci", 12.45);
            Menu beer = new Menu("beer", 5.45);
            Menu limo = new Menu("limo", 3.45);
            Menu water = new Menu("water", 0.45);
            Menu orangensaft = new Menu("orangesaft", 4.99);

            group1.AddMenuList(pasta); group1.AddMenuList(beer);
            group1.AddMenuList(salat); group1.AddMenuList(beer);

            group1.AddMenuList(pasta); group1.AddMenuList(orangensaft);
            group1.AddMenuList(salat); group1.AddMenuList(limo);
            group1.AddMenuList(pasta); group1.AddMenuList(water);
            group1.AddMenuList(salat); group1.AddMenuList(water);
            group1.AddMenuList(pizza); group1.AddMenuList(gnocci);
            group1.AddMenuList(pizza); group1.AddMenuList(tiramisu);
            group1.AddMenuList(beer); group1.AddMenuList(tiramisu);
            group1.AddMenuList(salat); group1.AddMenuList(pizza);

            group2.AddMenuList(pasta); group2.AddMenuList(limo);
            group2.AddMenuList(salat); group2.AddMenuList(limo);
            group2.AddMenuList(pasta); group2.AddMenuList(orangensaft);
            group2.AddMenuList(salat); group2.AddMenuList(limo);
            group2.AddMenuList(pasta); group2.AddMenuList(water);
            group2.AddMenuList(pasta); group2.AddMenuList(limo);
            group2.AddMenuList(pasta); group2.AddMenuList(tiramisu);
            group2.AddMenuList(pasta); group2.AddMenuList(tiramisu);
            group2.AddMenuList(beer); group2.AddMenuList(water);
            group2.AddMenuList(pasta); group2.AddMenuList(water);

            group3.AddMenuList(pasta); group3.AddMenuList(water);
            group3.AddMenuList(salat); group3.AddMenuList(water);
            group3.AddMenuList(pasta); group3.AddMenuList(orangensaft);
            group3.AddMenuList(salat); group3.AddMenuList(water);
            group3.AddMenuList(pasta); group3.AddMenuList(water);
            group3.AddMenuList(salat); group3.AddMenuList(limo);
            group3.AddMenuList(salat); group3.AddMenuList(water);
            group3.AddMenuList(salat); group3.AddMenuList(water);
            group3.AddMenuList(beer); group3.AddMenuList(pasta);
            group3.AddMenuList(salat); group3.AddMenuList(pizza);

            group4.AddMenuList(pasta); group4.AddMenuList(beer);
            group4.AddMenuList(salat); group4.AddMenuList(beer);
            group4.AddMenuList(pasta); group4.AddMenuList(orangensaft);
            group4.AddMenuList(salat); group4.AddMenuList(limo);
            group4.AddMenuList(pasta); group4.AddMenuList(water);
            group4.AddMenuList(salat); group4.AddMenuList(limo);
            group4.AddMenuList(pizza); group4.AddMenuList(tiramisu);
            group4.AddMenuList(salat); group4.AddMenuList(tiramisu);
            group4.AddMenuList(beer); group4.AddMenuList(pizza);
            group4.AddMenuList(salat); group4.AddMenuList(pizza);
            group4.AddMenuList(pasta); group4.AddMenuList(beer);
            group4.AddMenuList(salat); group4.AddMenuList(beer);
            group4.AddMenuList(pasta); group4.AddMenuList(orangensaft);
            group4.AddMenuList(salat); group4.AddMenuList(limo);
            group4.AddMenuList(pasta); group4.AddMenuList(water);
            group4.AddMenuList(salat); group4.AddMenuList(limo);
            group4.AddMenuList(pizza); group4.AddMenuList(tiramisu);
            group4.AddMenuList(salat); group4.AddMenuList(tiramisu);
            group4.AddMenuList(beer); group4.AddMenuList(pizza);
            group4.AddMenuList(salat); group4.AddMenuList(pizza);

            group5.AddMenuList(pasta); group5.AddMenuList(beer);
            group5.AddMenuList(salat); group5.AddMenuList(beer);

            group6.AddMenuList(pasta); group6.AddMenuList(beer);
            group6.AddMenuList(salat); group6.AddMenuList(beer);
            group6.AddMenuList(pasta); group6.AddMenuList(orangensaft);
            group6.AddMenuList(salat); group6.AddMenuList(limo);

            group7.AddMenuList(pasta); group7.AddMenuList(beer);
            group7.AddMenuList(salat); group7.AddMenuList(beer);
            group7.AddMenuList(pasta); group7.AddMenuList(orangensaft);
            group7.AddMenuList(salat); group7.AddMenuList(limo);
            group7.AddMenuList(pasta); group7.AddMenuList(water);
            group7.AddMenuList(salat); group7.AddMenuList(limo);
            group7.AddMenuList(salat); group7.AddMenuList(tiramisu);
            group7.AddMenuList(salat); group7.AddMenuList(tiramisu);
            group7.AddMenuList(beer); group7.AddMenuList(pizza);
            group7.AddMenuList(salat); group7.AddMenuList(pizza);
            group7.AddMenuList(pasta); group7.AddMenuList(water);
            group7.AddMenuList(salat); group7.AddMenuList(limo);
            group7.AddMenuList(salat); group7.AddMenuList(tiramisu);
            group7.AddMenuList(salat); group7.AddMenuList(tiramisu);
            group7.AddMenuList(beer); group7.AddMenuList(pizza);
            group7.AddMenuList(salat); group7.AddMenuList(pizza);

            group8.AddMenuList(pasta); group8.AddMenuList(beer);
            group8.AddMenuList(salat); group8.AddMenuList(beer);
            group8.AddMenuList(pasta); group8.AddMenuList(orangensaft);
            group8.AddMenuList(salat); group8.AddMenuList(limo);
            group8.AddMenuList(pasta); group8.AddMenuList(water);
           
            group9.AddMenuList(pasta); group9.AddMenuList(beer);
            group9.AddMenuList(salat); group9.AddMenuList(beer);
            group9.AddMenuList(pasta); group9.AddMenuList(orangensaft);
            group9.AddMenuList(salat); group9.AddMenuList(limo);
            group9.AddMenuList(pasta); group9.AddMenuList(water);
            group9.AddMenuList(salat); group9.AddMenuList(limo);
            group9.AddMenuList(salat); group9.AddMenuList(tiramisu);
            group9.AddMenuList(salat); group9.AddMenuList(tiramisu);
            group9.AddMenuList(beer); group9.AddMenuList(pizza);
            group9.AddMenuList(pasta); group9.AddMenuList(beer);
            group9.AddMenuList(salat); group9.AddMenuList(beer);
            group9.AddMenuList(pasta); group9.AddMenuList(orangensaft);
            group9.AddMenuList(salat); group9.AddMenuList(limo);
            group9.AddMenuList(pasta); group9.AddMenuList(water);
            group9.AddMenuList(salat); group9.AddMenuList(limo);
            group9.AddMenuList(salat); group9.AddMenuList(tiramisu);
            group9.AddMenuList(salat); group9.AddMenuList(tiramisu);
            group9.AddMenuList(beer); group9.AddMenuList(pizza);
                        group9.AddMenuList(pasta); group9.AddMenuList(beer);
            group9.AddMenuList(salat); group9.AddMenuList(beer);
            group9.AddMenuList(pasta); group9.AddMenuList(orangensaft);
            group9.AddMenuList(salat); group9.AddMenuList(limo);
            group9.AddMenuList(pasta); group9.AddMenuList(water);
            group9.AddMenuList(salat); group9.AddMenuList(limo);
            group9.AddMenuList(salat); group9.AddMenuList(tiramisu);
            group9.AddMenuList(salat); group9.AddMenuList(tiramisu);
            group9.AddMenuList(beer); group9.AddMenuList(pizza);

            group10.AddMenuList(pasta); group10.AddMenuList(beer);
            group10.AddMenuList(salat); group10.AddMenuList(beer);
            group10.AddMenuList(pasta); group10.AddMenuList(orangensaft);
            group10.AddMenuList(salat); group10.AddMenuList(limo);
            group10.AddMenuList(pasta); group10.AddMenuList(beer);
            group10.AddMenuList(salat); group10.AddMenuList(beer);
            group10.AddMenuList(pasta); group10.AddMenuList(orangensaft);
            group10.AddMenuList(salat); group10.AddMenuList(limo);
            group10.AddMenuList(pasta); group10.AddMenuList(water);
            group10.AddMenuList(salat); group10.AddMenuList(limo);
            group10.AddMenuList(salat); group10.AddMenuList(tiramisu);
            group10.AddMenuList(salat); group10.AddMenuList(tiramisu);
            group10.AddMenuList(beer); group10.AddMenuList(pizza);
            group10.AddMenuList(salat); group10.AddMenuList(pizza);
         
            group11.AddMenuList(salat); group11.AddMenuList(tiramisu);
            group11.AddMenuList(beer); group11.AddMenuList(pizza);
            group11.AddMenuList(salat); group11.AddMenuList(pizza);

            group12.AddMenuList(pasta); group12.AddMenuList(beer);
            group12.AddMenuList(salat); group12.AddMenuList(beer);
            group12.AddMenuList(pasta); group12.AddMenuList(orangensaft);
            group12.AddMenuList(salat); group12.AddMenuList(limo);
            group12.AddMenuList(pasta); group12.AddMenuList(water);
            group12.AddMenuList(salat); group12.AddMenuList(limo);          
            group12.AddMenuList(beer); group12.AddMenuList(pizza);
            group12.AddMenuList(salat); group12.AddMenuList(pizza);

            group13.AddMenuList(pasta); group13.AddMenuList(beer);
            group13.AddMenuList(salat); group13.AddMenuList(beer);
            group13.AddMenuList(pasta); group13.AddMenuList(orangensaft);
            group13.AddMenuList(salat); group13.AddMenuList(limo);
            group13.AddMenuList(pasta); group13.AddMenuList(water);
            group13.AddMenuList(salat); group13.AddMenuList(limo);
            group13.AddMenuList(salat); group13.AddMenuList(tiramisu);
            group13.AddMenuList(salat); group13.AddMenuList(tiramisu);
            group13.AddMenuList(beer); group13.AddMenuList(pizza);
            group13.AddMenuList(salat); group13.AddMenuList(pizza);

            group14.AddMenuList(pasta); group14.AddMenuList(beer);                  
            group14.AddMenuList(salat); group14.AddMenuList(beer);
            group14.AddMenuList(pasta); group14.AddMenuList(orangensaft);
            group14.AddMenuList(salat); group14.AddMenuList(limo);
            group14.AddMenuList(pasta); group14.AddMenuList(water);
            group14.AddMenuList(salat); group14.AddMenuList(limo);
            group14.AddMenuList(salat); group14.AddMenuList(tiramisu);
            group14.AddMenuList(salat); group14.AddMenuList(tiramisu);
            group14.AddMenuList(beer); group14.AddMenuList(pizza);
            group14.AddMenuList(salat); group14.AddMenuList(pizza);
            group14.AddMenuList(salat); group14.AddMenuList(tiramisu);
            group14.AddMenuList(salat); group14.AddMenuList(tiramisu);
            group14.AddMenuList(beer); group14.AddMenuList(pizza);
            group14.AddMenuList(salat); group14.AddMenuList(pizza);



            dolceVita.AddGuestsToList(group1);
            dolceVita.AddGuestsToList(group2);
            dolceVita.AddGuestsToList(group3);
            dolceVita.AddGuestsToList(group4);
            dolceVita.AddGuestsToList(group5);
            dolceVita.AddGuestsToList(group6);
            dolceVita.AddGuestsToList(group7);
            dolceVita.AddGuestsToList(group8);
            dolceVita.AddGuestsToList(group9);
            dolceVita.AddGuestsToList(group10);
            dolceVita.AddGuestsToList(group11);
            dolceVita.AddGuestsToList(group12);
            dolceVita.AddGuestsToList(group13);
            dolceVita.AddGuestsToList(group14);

            dolceVita.AddWaiterList(waiter1);
            dolceVita.AddWaiterList(waiter2);
            dolceVita.AddWaiterList(waiter3);
            dolceVita.AddWaiterList(waiter4);

            mainWaiter.AddWaiterToList(waiter1);
            mainWaiter.AddWaiterToList(waiter2);
            mainWaiter.AddWaiterToList(waiter3);
            mainWaiter.AddWaiterToList(waiter4);

            waiter1.AddTableToList(talbe1Room1);
            waiter1.AddTableToList(talbe2Room1);
            waiter1.AddTableToList(talbe3Room1);
            waiter1.AddTableToList(talbe4Room1);
            waiter1.AddRoomsToList(room1);

            waiter2.AddTableToList(talbe1Room2);
            waiter2.AddTableToList(talbe2Room2);
            waiter2.AddTableToList(talbe3Room2);
            waiter2.AddTableToList(talbe4Room2);
            waiter2.AddRoomsToList(room2);

            waiter3.AddTableToList(talbe1Room3);
            waiter3.AddTableToList(talbe2Room3);
            waiter3.AddTableToList(talbe3Room3);
            waiter3.AddTableToList(talbe4Room3);
            waiter3.AddRoomsToList(room3);

            waiter4.AddTableToList(talbe1Room4);
            waiter4.AddTableToList(talbe2Room4);
            waiter4.AddTableToList(talbe3Room4);
            waiter4.AddTableToList(talbe4Room4);
            waiter4.AddRoomsToList(room4);

            //Print
            dolceVita.PrintStructure();
            Console.WriteLine("==============================================================");
            Console.WriteLine("==============================================================");

            for(int i = 0; i < 100; i++)
            {
                dolceVita.SimulateGuests();

            }
            
            Console.WriteLine("=================================================================");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"GästeCount von {waiter1,- 12} = " + waiter1.GuestCount);
            Console.WriteLine($"GästeCount von {waiter2, -12} = " + waiter2.GuestCount);
            Console.WriteLine($"GästeCount von {waiter3, -12} = " + waiter3.GuestCount);
            Console.WriteLine($"GästeCount von {waiter4, -12} = " + waiter4.GuestCount);
            Console.WriteLine();
            Console.WriteLine($"Es wurden insgesamt {waiter1.GuestCount+waiter2.GuestCount+waiter3.GuestCount+waiter4.GuestCount} Personen bedient");

            Console.WriteLine("==================================================");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("==================================================");

            Console.WriteLine($"Gesamtumsatz von {waiter1,-10} = " + waiter1.TotalCash + " Euro");
            Console.WriteLine($"Gesamtumsatz von {waiter2,-10} = " + waiter2.TotalCash + " Euro");
            Console.WriteLine($"Gesamtumsatz von {waiter3,-10} = " + waiter3.TotalCash + " Euro");
            Console.WriteLine($"Gesamtumsatz von {waiter4,-10} = " + waiter4.TotalCash + " Euro");
            Console.WriteLine("");
            Console.WriteLine($"Gesamtumsatz des Restaurants = {waiter1.TotalCash+waiter2.TotalCash+waiter3.TotalCash+waiter4.TotalCash} Euro");
            Console.ResetColor();

           
        }


    }
}
