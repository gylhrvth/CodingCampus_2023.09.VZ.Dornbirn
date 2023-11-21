using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarioLuis.Week07
{
    public class Programmiersprachen
    {
        private string _NameDoc;
        private string _Founder;
        private string _Name;
        private int _FoundingYear;
        private int _LanguageRank;

        private string NameDoc
        {
            get => _NameDoc;
            set => _NameDoc = value;
        }

        private string Founder
        {
            get => _Founder;
            set => _Founder = value;
        }
        private string Name
        {
            get => _Name;
            set => _Name = value;
        }

        private int FoundingYear
        {
            get => _FoundingYear;
            set => _FoundingYear = value;
        }

        private int LanguageRank
        {
            get => _LanguageRank;
            set => _LanguageRank = value;
        }

        public Programmiersprachen(string Name, int FoundingYear, int LanguageRank)
        {
            Name = _Name;
            FoundingYear = _FoundingYear;
            LanguageRank = _LanguageRank;
        }


        public void PrintStructure()
        {
            Console.WriteLine($"├── Programming Languages  Info: {_NameDoc}, founded by: {_Founder}");
        }
    }
}
