﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asteroids
{
    class Program
    {
        static void Main(string[] args)
        {
            Controller controller = new Controller();

            controller.Run();

            Console.ReadKey();
        }
    }
}
