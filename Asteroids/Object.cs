using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asteroids
{
    class Object
    {
        private int _height;
        private int _width;
        private int _id;
        private int _health;
        private int _direction;
        private int _velocity;
        private int _posX;
        private int _posY;

        public int Height
        {
            get
            {
                return _height;
            }

            set
            {
                _height = value;
            }
        }

        public int Width
        {
            get
            {
                return _width;
            }

            set
            {
                _width = value;
            }
        }

        public int Id
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }
        }

        public int Health
        {
            get
            {
                return _health;
            }

            set
            {
                _health = value;
            }
        }

        public int Direction
        {
            get
            {
                return _direction;
            }

            set
            {
                _direction = value;
            }
        }

        public int Velocity
        {
            get
            {
                return _velocity;
            }

            set
            {
                _velocity = value;
            }
        }

        public int PosX
        {
            get
            {
                return _posX;
            }

            set
            {
                _posX = value;
            }
        }

        public int PosY
        {
            get
            {
                return _posY;
            }

            set
            {
                _posY = value;
            }
        }

        public Object()
        {
            Initialise(0);
        }

        public Object(int newId)
        {
            Initialise(newId);
        }

        public void Initialise(int newId)
        {
            Height = 0;
            Width = 0;
            Health = 100;
            Id = newId;
        }
    }
}
