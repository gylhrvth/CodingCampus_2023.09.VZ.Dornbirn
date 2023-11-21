using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Dimitri.Week08._03Test
{
    internal class TestMain
    {
        public static void Main()
        {
            Child hans = new Child();

            //Child1 newHans = hans as Child1;

            hans.print();
            //newHans.print();
        }
    }
}
