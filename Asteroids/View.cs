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
        private Grid _grid;

        public new int Width { get => _width; set => _width = value; }
        public new int Height { get => _height; set => _height = value; }
        public Grid Grid { get => _grid; set => _grid = value; }

        public View()
        {
            Width = 300;
            Height = 300;
            Grid = new Grid();

            Content = Grid;

            Grid.Background = new SolidColorBrush(Color.FromArgb(100, 0, 0, 0));
            
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
            
        }

        public void DrawAsteroid(Asteroid asteroid)
        {

        }

        public void PrintStartScreen()
        {
            
        }

        public static DependencyObject FindInVisualTreeDown(DependencyObject obj, Type type, String tag)
        {
            if (obj != null)
            {
                if (obj.GetType() == type && ((System.Windows.Controls.Control)obj).Tag == tag)
                {
                    return obj;
                }

                for (int i = 0; i < VisualTreeHelper.GetChildrenCount(obj); i++)
                {
                    DependencyObject childReturn = FindInVisualTreeDown(VisualTreeHelper.GetChild(obj, i), type, tag);
                    if (childReturn != null)
                    {
                        return childReturn;
                    }
                }
            }

            return null;
        }

        void button1_Click(object sender, RoutedEventArgs e)
        {

            if (VisualTreeHelper.GetChildrenCount(GetVisualChild(0)) > 0)               // If we have controls
            {                                                                           //
                DependencyObject tmp = VisualTreeHelper.GetChild(GetVisualChild(0), 0); // just give me the first...
                                                                                        //
                tmp = FindInVisualTreeDown(tmp, typeof(Label), "Test");                 // and search for the
                                                                                        // one I need.
                if (tmp != null)
                    ((Label)tmp).Content = "Ups das war es auch schon wieder";
                else
                    MessageBox.Show("Tag not found!");
            }
        }
    }
}
