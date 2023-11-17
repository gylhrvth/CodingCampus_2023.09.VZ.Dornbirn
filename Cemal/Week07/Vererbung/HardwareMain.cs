using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cemal.Week07.Ubung
{
    public class HardwareMain
    {
        public static void Start()
        {
            List<Hardware> hdw = new List<Hardware>();

            hdw.Add(new Hardware("Razer Blackwidow", "Black"));
            hdw.Add(new Tastatur("Sharkoon Skiller SGK50", "White", 60));
            hdw.Add(new Hardware("Roccat Vulkan", "Black"));

            foreach (Hardware hardware in hdw)
            {
                hardware.PrintMe();
            }

        }
    }
}
