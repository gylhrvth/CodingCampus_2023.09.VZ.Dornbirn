namespace Selina.Week06.Trainer
{
    public class KursTrainer
    {
        public static void Start()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Trainer name = new Trainer("Gyula", 40, 70, 180);
            
            TrainerInformation trainer = new TrainerInformation("Software Entwickler", 8.30f, 7, 7000, name.Name);
            Console.WriteLine(trainer);
            Console.WriteLine(name);

        }
    }
}
