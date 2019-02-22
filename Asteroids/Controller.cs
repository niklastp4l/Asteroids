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
        private NetworkHandler _nwHandler;

        internal ObjectHandler Objects
        {
            get
            {
                return _objects;
            }

            set
            {
                _objects = value;
            }
        }

        internal View View
        {
            get
            {
                return _view;
            }

            set
            {
                _view = value;
            }
        }

        internal NetworkHandler NwHandler
        {
            get
            {
                return _nwHandler;
            }

            set
            {
                _nwHandler = value;
            }
        }

        public Controller()
        {
            this.Initialise();
        }

        public void Initialise()
        {
            View = new View(150, 50);
            
            Objects = new ObjectHandler();

            
        }

        public void InitialiseNetworkHandler(String mode)
        {
            if(mode == "1")
            {
                NwHandler = new NetworkHandler(1);
            }
            else
            {
                NwHandler = new NetworkHandler(2);
            }
        }

        public void Run()
        {
            String input = "";
            View.Start();

            View.WriteLine("Server (1) oder Client-Installation(2)?");
            input = View.GetUserInput();
            InitialiseNetworkHandler(input);


            
            View.DrawGameArea(Objects);
        }
    }
}
