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

        public int Height { get => _height; set => _height = value; }
        public int Width { get => _width; set => _width = value; }
        public int Id { get => _id; set => _id = value; }
        public int Health { get => _health; set => _health = value; }
    }
}
