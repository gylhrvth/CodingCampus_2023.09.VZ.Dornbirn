using Kerem.ZOO;

namespace Kerem.Zoo
{
    internal class Zoo
    {
        private string _Name;
        private int _Founded;
        private List<Cage> _CageList;
        private List<Worker> _WorkerList;
        private List<Doc> _DocList;
        
        public Zoo(string name, int founded)
        {
            _Name = name;
            _Founded = founded;
            _CageList = new List<Cage>();
           _WorkerList = new List<Worker>();
        }

        public void AddCage(Cage cage)
        {
            _CageList.Add(cage);
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
            Console.WriteLine("├──┬┤ Zoo: Tiergarten {0}, gegründet {1}",
                _Name,
                _Founded);
            foreach (Worker worker in _WorkerList)
            {
                worker.PrintStrukture();
            }          
            foreach (Cage cage in _CageList)
            {
                cage.PrintStrukture();               
            }
        }

        public void SimulateDay(int dayNr)
        {
            Console.WriteLine("\n\n\nTag {0}", dayNr);
            foreach (Worker worker in _WorkerList)
            {
                worker.SimulateDay();
            }
        }
    }
}
