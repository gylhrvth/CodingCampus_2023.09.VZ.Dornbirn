using Mehmet.ZOO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Mehmet.Zoo
{
    internal class Cage
    {
        public static Random rand = new Random();
        public static Random randBiteRate = new Random();
        public static Random randHitDMG = new Random();
        private string _Name;
        private List<Animal> _AnimalList;
        private List<Worker> _WorkerList;
        private List<Doc> _DocList;
        private bool _Look = true;
        int awa = rand.Next(1, 4);
        int count = 0;
        int death = 0;

        public Cage(string name)
        {
            _Name = name;
            _AnimalList = new List<Animal>();
            _WorkerList = new List<Worker>();
            _DocList = new List<Doc>();
        }
        
        public void AddAnimal(Animal animal)
        {
            _AnimalList.Add(animal);
        }

        public void AddWorker(Worker worker)
        {
            _WorkerList.Add(worker);
        }

        public void AddDoc(Doc doc)
        {
            _DocList.Add(doc);
        }



        public void PrintStrukture()
        {
            Console.WriteLine("   └──┬┤ Gehege: {0}",
                _Name);
            foreach (Animal animal in _AnimalList)
            {
                animal.PrintStrukture();
            }

        }

        public void SimulateDay()
        {
            Console.WriteLine("    fängt mit Gehege: {0} an", _Name);
            List<Animal> animalsToRemove = new List<Animal>();
            foreach (Animal animal in _AnimalList)
            {
                animal.SimulateDay();
                count = count + 1;

                if (awa == count && _Look == true)
                {
                    animal.LookAtAnimal();
                    _Look = false;
                }
                else if (awa == count && _Look == true)
                {
                    animal.LookAtAnimal();
                    _Look = false;
                }
                else if (awa == count && _Look == true)
                {
                    animal.LookAtAnimal();
                    _Look = false;
                }

                int biterate = randBiteRate.Next(0, 101);
                int hit = randHitDMG.Next(6, 10);

                
                if (biterate < 41)
                {
                    animal.Health = animal.Health - hit;
                    Console.Write("        "); animal.PrintAnimalName(); Console.WriteLine(" erhält {0} schaden aktuelle Lebenspunkte {1}", hit, animal.Health);
                    if (animal.Health <= 0)
                    {                       
                        Console.Write("-------------"); animal.PrintAnimalName(); Console.WriteLine("------------- ist gestorben");
                        animalsToRemove.Add(animal);
                        death--;
                        Console.WriteLine("count death "+ death);
                    }
                }    
            }

            foreach(Animal animal in animalsToRemove)
            {
                _AnimalList.Remove(animal);
            }

            awa = rand.Next(1, 4);
            _Look = true;
            count = 0;
        }


        

        public void HealAnimalinCage()
        {
            int lowestHP = int.MaxValue;
            foreach (Animal animal in _AnimalList)
            {
                if (animal.Health < lowestHP) 
                {
                    lowestHP = animal.Health;               
                }
            }
            foreach (Animal animal in _AnimalList)
            {
                if (animal.Health == lowestHP)
                {
                    animal.PrintAnimalName(); Console.WriteLine(" hat {0} Lebenspunkte", animal.Health);
                    animal.Health = 100;
                    animal.PrintAnimalName(); Console.WriteLine("'s Lebenspunkte wurden auf {0} erneuert", animal.Health);
                    break;
                }
            }
        }











        public void TheEndStory()
        {
            Console.WriteLine("\r\nIn einer nicht allzu fernen Zukunft, lebte ein ungewöhnlich intelligenter Pinguin namens Wilson in einer Welt, die von Menschen dominiert wurde. Wilson war jedoch nicht nur irgendein Pinguin; er entwickelte eine erstaunliche Fähigkeit, menschliche Sprache zu verstehen und sogar zu sprechen.\r\n\r\nAls Wilson die menschliche Welt beobachtete, erkannte er, dass die Menschheit in Konflikte verstrickt war, die durch Gier, Machtstreben und Ressourcenknappheit getrieben wurden. Wilson, der die Missstände der Menschen sorgfältig analysierte, beschloss, einzugreifen.\r\n\r\nMit seiner erstaunlichen Fähigkeit zur Kommunikation begann Wilson, Botschaften des Friedens zu verbreiten. Er sprach vor den Vereinten Nationen und sendete Botschaften über alle verfügbaren Kommunikationsmittel. Die Menschen waren zunächst erstaunt, aber Wilsons Worte berührten ihre Herzen, und es schien, als ob die Welt eine Chance auf Frieden hatte.\r\n\r\nDoch das Gleichgewicht war zerbrechlich. Die Mächte, die von Krieg und Konflikten profitierten, sahen in Wilsons Botschaften eine Bedrohung für ihre Interessen. Eine geheime Organisation von skrupellosen Machthabern entschied sich, Wilson zu eliminieren, um ihre Agenda voranzutreiben.\r\n\r\nDie Organisation startete eine Desinformationskampagne, die Wilson als Verräter darstellte, der die Menschheit manipulieren wollte. Die Welt geriet erneut in Unruhe, und die Menschen begannen, sich gegenseitig zu bekämpfen.\r\n\r\nIn einem verzweifelten Versuch, den Frieden wiederherzustellen, beschloss Wilson, sich der Organisation zu stellen. Er wurde jedoch gefangen genommen und für seine vermeintlichen Verbrechen verurteilt. Die Organisation nutzte seine Fähigkeiten und zwang ihn, falsche Botschaften des Hasses zu verbreiten.\r\n\r\nDie Welt, bereits instabil und gespalten, wurde durch diese neuen Unruhen weiter erschüttert. Die Fehlinformationen, die von Wilson unter Zwang verbreitet wurden, dienten als Funke für den Ausbruch des Dritten Weltkriegs. Atomare Waffen wurden eingesetzt, und die Zivilisation stand am Rande des Untergangs.\r\n\r\nAm Ende war Wilson nicht nur das Symbol für den Frieden, sondern auch das tragische Opfer von Machtspielen und Manipulationen, die die Welt in den Abgrund stürzten.");

            Console.Write(
                 
                "                _.-^^---....,,--                    C|                           \n" +
                "          _--                  --_                   |                           \n" +
                "         <                        >)              I\"\"N.                      \n" +
                "         |                          |            I\"\"\"\"\"\"Nn.              \n" +
                "       ||                            |         I      NNNn.                    \n" +
                "        |                            |        I\"\"\"\"\"\"\"\"\"\"NNNN        \n" +
                "       \\\\                          |          I NN NN NN NNNNn.                \n" +
                "        \\\\                           |        I NN NN NN NNNNNN                \n" +
                "         \\\\                         | |       I          NNNNNN                \n" +
                "           \\\\                      | |        I    NN NN I\"\"\"\"\"\"\"Nn.    \n" +
                "           \\._                  _./           I    NN NN I       NNNNn         \n" +
                "           ```--. . , ; .--'''                I          I       NNNNNN        \n" +
                "                 | |   |                      I       NN I NN NN NNNNNN        \n" +
                "              .-=||  | |=-.                   I       NN I NN NN NNNNNN        \n" +
                "              `-=#$%&%$#=-'                   I___       I   ____  NNNN     \\o/  \n" +
                "                 | ;  :|                      I  .|    I NN  | .|  NNNN      |  \n" +
                "         _____.,-#%&$@%#&#~,._____            I   |    I NN  |  |  NNNN     | \\   \n" + 



                "                                   ");



        }

    }
}
