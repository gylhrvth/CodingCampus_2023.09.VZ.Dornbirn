using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Simon.Week06.Zoosim2
{
    public class ZooMain2
    {
        public static void Start()
        {
            Console.OutputEncoding = Encoding.UTF8;
            //try
            //{
            //    using (StreamReader sr = new StreamReader("C:\\Users\\BAU21982\\OneDrive - Julius Blum GmbH\\Desktop\\WikipediaListeZoos.csv"))
            //    {
            //        string line = sr.ReadLine();
            //        while (line != null)
            //        {
            //            string[] parameters = line.Split(';');
            //            //Console.WriteLine("[{0}]", string.Join(", ", parameters));

            //            line = sr.ReadLine();
            //        }
            //    }
            //}
            //catch (IOException e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            string filePath = "C:\\Users\\BAU21982\\OneDrive - Julius Blum GmbH\\Desktop\\WikipediaListeZoos.csv";
            List<Zoo> zooList = ReadZoosFromCsv(filePath);
            Console.WriteLine(zooList);

            //Zoo ZooSalzburg = new Zoo("Zoo Slazburg", 1961);
            //Zoo TiergartenSchoenbrunn = new Zoo("Tiergarten Schoenbrunn", 1752);
            //Zoo ZoodeGeneve = new Zoo("Zoo de Genève", 1935);

            string zooDatazoo = "London Zoo\r\nZoo Dublin\r\nZoo Bristol\r\nZoo Manchester\r\nNatura Artis Magistra\r\nEdinburgh Royal Zoological Gardens\r\nThiergarten Horn\r\nZoo Antwerpen\r\nZoologischer Garten Berlin\r\nDierentuin van Gent\r\nZoologischer Garten Brüssel\r\nJardin Zoologique de Marseille\r\nDiergaarde Blijdorp\r\nZoologischer Garten Frankfurt am Main\r\nZoo Lyon\r\nZoologisk Have\r\nPhiladelphia Zoo\r\nKölner Zoo\r\nZoo Dresden\r\nMelbourne Zoo\r\nDe Haagse Dierentuin\r\nZoologischer Garten Hamburg\r\nSakkarbaug Zoological Garden\r\nRagunan Zoo\r\nMoskauer Zoo\r\nCentral Park Zoo\r\nLeningrader Zoo (Ленинградский зоопарк)\r\nZoo Hannover\r\nZoologischer Garten Breslau (Ogród Zoologiczny we Wrocławiu)\r\nZoologischer Stadtgarten Karlsruhe\r\nZoo Budapest (Fovárosi Állat- és Növénykert)\r\nLincoln Park Zoo\r\nZoo Mulhouse\r\nBuffalo Zoological Gardens\r\nZoologisch-Botanischer Garten Hongkong (香港動植物公園)\r\nLahore Zoo\r\nZoologischer Garten Basel\r\nAllwetterzoo Münster\r\nZoologischer Garten Posen (Ogród Zoologiczny w Poznaniu)\r\nSaint Louis Zoological Park\r\nZoologischer Garten Warschau (Miejski Ogród Zoologiczny w. Warszawie)\r\nCincinnati Zoo and Botanical Garden\r\nKolkata Zoo\r\nMaryland Zoo\r\nZoologischer Garten Düsseldorf\r\nZoo Leipzig\r\nZoo Wuppertal\r\nCleveland Metroparks Zoo\r\nUeno-Zoo (恩賜上野動物園)\r\nAdelaide Zoo\r\nZoo Lissabon (Jardim Zoológico Lisboa)\r\nTierpark Köthen\r\nNew York Aquarium\r\nDallas Zoo\r\nZoo Sofia (Зоопарк-София)\r\nZoo Buenos Aires\r\nZoo der Vatikanischen Gärten\r\nZoo Atlanta\r\nZoo Helsinki\r\nZoo Gizeh\r\nSkansen\r\nSmithsonian National Zoological Park\r\nZoo Barcelona (Parc Zoològic de Barcelona)\r\nMilwaukee County Zoological Gardens\r\nZoo de l’Orangerie\r\nZoo Charkiw (Харьковский зоопарк)\r\nDenver Zoological Gardens\r\nKönigsberger Tiergarten (Kaliningrader Zoo, Калининградский Зоопарк)\r\nPerth Zoological Gardens\r\nBronx Zoo Wildlife Conservation Park\r\nNational Zoological Gardens of South Africa\r\nZoo Rostock\r\nToledo Zoo\r\nWoodland Park Zoo\r\n";
            string zooDatayear = "1828\r\n1831\r\n1835\r\n1837\r\n1838\r\n1840\r\n1841\r\n1843\r\n1844\r\n1851\r\n1851\r\n1854\r\n1857\r\n1858\r\n1858\r\n1859\r\n1859\r\n1860\r\n1861\r\n1862\r\n1863\r\n1863\r\n1863\r\n1864\r\n1864\r\n1864\r\n1864\r\n1865\r\n1865\r\n1865\r\n1866\r\n1868\r\n1868\r\n1870\r\n1871\r\n1872\r\n1874\r\n1874\r\n1874\r\n1874\r\n1874\r\n1875\r\n1875\r\n1876\r\n1876\r\n1878\r\n1881\r\n1882\r\n1882\r\n1882\r\n1882\r\n1884\r\n1886\r\n1888\r\n1888\r\n1888\r\n1888\r\n1889\r\n1889\r\n1891\r\n1891\r\n1891\r\n1892\r\n1892\r\n1895\r\n1895\r\n1896\r\n1896\r\n1898\r\n1898\r\n1898\r\n1899\r\n1899\r\n1899\r\n";

            List<string> zoowikilist = new List<string>(zooDatazoo.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries));
            //List<int> zoowikilist2 = new List<int>(zooDatazoo.Split(new int[] { '\r' '\n' }, StringSplitOptions.RemoveEmptyEntries));

        }

        static List<Zoo> ReadZoosFromCsv(string filePath)
        {
            List<Zoo> zooList = new List<Zoo>();

            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] parameters = line.Split(';');
                        if (parameters.Length >= 4)
                        {
                            string zooName = parameters[0];
                            if (int.TryParse(parameters[1], out int zooYear))
                            {
                                string zooLocation = parameters[2];
                                string[] enclosureNames = parameters[3].Split(',');

                                Zoo zoo = new Zoo(zooName, zooYear, zooLocation);
                                zooList.Add(zoo);
                            }
                            else
                            {
                                Console.WriteLine("Ungültiges Jahr: " + parameters[1]);
                            }
                        }
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Fehler beim Lesen der Datei: " + e.Message);
            }

            return zooList;
        }


    }
}
