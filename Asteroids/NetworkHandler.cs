using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asteroids
{
    class NetworkHandler
    {
        public NetworkHandler(int mode)
        {
            if(mode == 1)
            {
                Console.WriteLine("NWHandler: Mode 1");
            }
            if(mode == 2)
            {
                Console.WriteLine("NWHandler: Mode 2");
            }

        }
    }
}
