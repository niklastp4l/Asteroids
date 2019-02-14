using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asteroids
{
    class Controller
    {
        private View _view;
        private List<Object> _objects;

        internal View View { get => _view; set => _view = value; }
        internal List<Object> Objects { get => _objects; set => _objects = value; }

        public Controller()
        {
            this.Initialise();
        }


        public void Initialise()
        {
            Console.WriteLine("Controller Initialisieren...");

            View = new View();
            Objects = new List<Object>();

            InitObjects();

            Console.WriteLine("Controller Initialisieren abgeschlossen.");
        }

        public void InitObjects()
        {
            Objects.Add(new Spaceship() { });

            for(int i = 0; i < 20; i++)
            {
                Objects.Add(new Asteroid() { });
            }


        }

        public void Run()
        {
            View.PrintStartScreen();
            View.DrawGameArea();

        }
    }
}
