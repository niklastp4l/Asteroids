using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows;

namespace Asteroids
{
    class Controller
    {
        private View _view;
        private ObjectHandler _objects;

        public View View { get => _view; set => _view = value; }
        public ObjectHandler Objects{ get => _objects; set => _objects = value; }

        public Controller()
        {
            this.Initialise();
        }

        public void Initialise()
        {
            View = new View();
            
            Objects = new ObjectHandler();

            
        }

        public void Run()
        {
            View.DrawGameArea(Objects);

            (new Application()).Run(new View());
            
            
        }
    }
}
