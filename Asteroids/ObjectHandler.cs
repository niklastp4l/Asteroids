using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asteroids
{
    class ObjectHandler
    {
        private Dictionary<int, Asteroid> _asteroids = new Dictionary<int, Asteroid>();
        private Dictionary<int, Spaceship> _spaceships = new Dictionary<int, Spaceship>();
        private int _nextIdToAssign;

        public Dictionary<int, Spaceship> Spaceships
        {
            get {return this._spaceships;}
            set {this._spaceships = value;}
        }

        public Dictionary<int, Asteroid> Asteroids
        {
            get {return this._asteroids;}
            set {this._asteroids = value;}
        }

        public int NextIdToAssign 
        {
            get
            {
                _nextIdToAssign++;
                return _nextIdToAssign;
            }

            set
            {
                _nextIdToAssign = value;
            }
        }

        public ObjectHandler()
        {
            this.Initialise(1, 1);
        }

        public void Initialise(int numberOfSpaceships, int numberOfAsteroids)
        {
            this.NextIdToAssign = 0;
            
            for (int i = 0; i < numberOfAsteroids; i++)
            {
                int id = NextIdToAssign;
                Asteroids.Add(id, new Asteroid(id));
            }

            for (int i = 0; i < numberOfSpaceships;i++)
            {
                int id = NextIdToAssign;
                Spaceships.Add(id, new Spaceship(id));
            }
        }

        public Object GetObjectById(int id)
        {
            Object returnObject;

            if(Spaceships.ContainsKey(id))
            {
                returnObject = Spaceships[id];
            }
            else if(Asteroids.ContainsKey(id))
            {
                returnObject = Asteroids[id];
            }
            else
            {
                returnObject = new Object();
            }

            return returnObject;
        }

        public void UpdateSpaceship(Spaceship updatedSpaceship)
        {
            int id = updatedSpaceship.Id;

            if(Spaceships.ContainsKey(id))
            {
                Spaceships[id] = updatedSpaceship;
            }
        }

        public void UpdateAsteroid(Asteroid updatedAsteroid)
        {
            int id = updatedAsteroid.Id;

            if(Asteroids.ContainsKey(id))
            {
                Asteroids[id] = updatedAsteroid;
            }
        }
    }
}
