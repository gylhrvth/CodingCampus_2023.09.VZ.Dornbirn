using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Cemal.Week07.Zoo
{
    public class ZooMain
    {
        const int STD_OUTPUT_HANDLE = -11;
        const uint ENABLE_VIRTUAL_TERMINAL_PROCESSING = 4;

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern IntPtr GetStdHandle(int nStdHandle);

        [DllImport("kernel32.dll")]
        static extern bool GetConsoleMode(IntPtr hConsoleHandle, out uint lpMode);

        [DllImport("kernel32.dll")]
        static extern bool SetConsoleMode(IntPtr hConsoleHandle, uint dwMode);

        public static string UNDERLINE = "\x1B[4m";
        public static string RESET = "\x1B[0m";

        public static void Start()
        {
            var handle = GetStdHandle(STD_OUTPUT_HANDLE);
            uint mode;
            GetConsoleMode(handle, out mode);
            mode |= ENABLE_VIRTUAL_TERMINAL_PROCESSING;
            SetConsoleMode(handle, mode);

            Zoo zoo = new("Tiergarten Hohenems", 2023);

            Enclosure enc1 = new Enclosure("SBZ");
            Enclosure enc2 = new Enclosure("Tennishalle");
            Enclosure enc3 = new Enclosure("Terrarium");
            Enclosure enc4 = new Enclosure("Digital Campus");

            zoo.addEnclosure(enc1);
            zoo.addEnclosure(enc2);
            zoo.addEnclosure(enc3);
            zoo.addEnclosure(enc4);

            Food meat = new Food("Fleisch", "kg", 14);
            Food dogfood = new Food("Hundefutter", "kg", 4);
            Food banane = new Food("Banane", "kg", 6);
            


            Animal animal1 = new Animal("Affe","Ahmet", banane, 3);
            Animal animal2 = new Animal("Affe", "Yasin", banane, 4);
            Animal animal3 = new Animal("Krokodil", "Cemal", meat, 6);
            Animal animal4 = new Animal("Krokodil", "Hidoyet", meat, 7);
            Animal animal5 = new Animal("Hund", "Enes", dogfood, 1);
            Animal animal6 = new Animal("Hund", "Yunus", dogfood, 2);
            Animal animal7 = new Animal("Löwe", "Arda", meat, 5);
            Animal animal8 = new Animal("Löwe", "Abdu", meat, 6);



            Worker worker1 = new Worker("Kerem");
            Worker worker2 = new Worker("Eren");
            Worker worker3 = new Worker("Ali");
            Worker worker4 = new Worker("Fabienne");

            enc1.addAnimals(animal1); enc1.addAnimals(animal2);
            enc1.addWorker(worker1);

            enc2.addAnimals(animal3); enc2.addAnimals(animal4);
            enc2.addWorker(worker2);

            enc3.addAnimals(animal5); enc3.addAnimals(animal6);
            enc3.addWorker(worker3);

            enc4.addAnimals(animal7); enc4.addAnimals(animal8);
            enc4.addWorker(worker4);

            zoo.addFood(dogfood); 
            zoo.addFood(meat);
            zoo.addFood(banane);

            zoo.PrintStructure();
            Console.WriteLine();
            zoo.CalculateFoodReport();

        }

    }
}
