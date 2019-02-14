using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asteroids
{
    class Spaceship : Object
    {
        private int _direction;
        private int _velocity;

        public int Direction { get => _direction; set => _direction = value; }
        public int Velocity { get => _velocity; set => _velocity = value; }

        public void Shoot()
        {

        }

        public void TurnLeft()
        {

        }

        public void TurnRight()
        {

        }

        public void Accelerate()
        {

        }
    }
}
