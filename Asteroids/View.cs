using System;
using System.Collections;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Asteroids
{
    class View : Window
    {
        private int _width;
        private int _height;

        public new int Width
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

        public new int Height
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

        public View()
        {

        }

        public View(int width, int height)
        {
            Width = width;
            Height = height;
        }
        public void DrawGameArea(ObjectHandler objHandler)
        {
            foreach(var i in objHandler.Spaceships)
            {
                DrawSpaceship(i.Value);
            }

            foreach(var i in objHandler.Asteroids)
            {
                DrawAsteroid(i.Value);
            }
        }

        public void DrawSpaceship(Spaceship ship)
        {
            int posX = ship.PosX;
            int posY = ship.PosY;
            int direction = ship.Direction;

            DrawObject("S", 50, 20);
        }
        public void DrawAsteroid(Asteroid asteroid)
        {
            int posX = asteroid.PosX;
            int posY = asteroid.PosY;

            DrawObject("A", 50, 21);
        }

        public void DrawObject(String symbol, int posX, int posY)
        {
            Console.SetCursorPosition(posX, posY);
            Write(symbol);
        }

        public void Write(String text)
        {
            Console.Write(text);
        }
        public void WriteLine(String text)
        {
            Console.WriteLine(text);
        }

       
        public String GetUserInput()
        {
            return Console.ReadLine();
        }

        public void PrintStartScreen()
        {
            WriteLine("Asteroids Netzwerkspiel");
            WriteLine("-----------------------");
        }

        public void Start()
        {
            Console.SetWindowSize(Width, Height);
            
            PrintStartScreen();
            
        }
    }
}
