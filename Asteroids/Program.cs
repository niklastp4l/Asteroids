using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Asteroids
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Controller controller = new Controller();

            controller.Run();

            Console.ReadKey();
        }
    }
}
