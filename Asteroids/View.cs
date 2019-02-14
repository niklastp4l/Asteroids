using System;

namespace Asteroids
{
    class View
    {
        private int _width;
        private int _height;

        public int Width { get => _width; set => _width = value; }
        public int Height { get => _height; set => _height = value; }

        public View()
        {
            this.Width = 70;
            this.Height = 30;
            Console.SetWindowSize(100, 100);
        }

        public void Write(String text)
        {
            Console.Write("View ist funktional");
        }

        public void DrawGameArea()
        {
            Console.WriteLine("Drawed Game Area");
        }

        public void PrintStartScreen()
        {
            Console.WriteLine("Asteroids Projekt");
            Console.WriteLine("Autor: Niklas Kaulfuß");
            Console.WriteLine("Datum: 14.02.2019");
            Console.WriteLine("Version: 0.0.1");
            System.Threading.Thread.Sleep(3000);
            Console.Clear();
        }

        public void UpdateGameArea()
        {

        }
    }
}
