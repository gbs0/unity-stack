using System;
using System.Collections.Generic;

namespace DesignPatterns
{
     public class Rectangle // Init basic Rectangle
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Rectangle()
        {
            
        }

        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public override string ToString()
        {
            return $"{nameof(Width)}: {Width}, {nameof(Height)}: {Height}";
        }

        public CalculateArea() 
        {

        }
    }
    public class Liskov
    {
        static public int Area(Rectangle r) => r.Width * r.Height;
        static void Main(string[] args)
        {
            var rect = new Rectangle();
            WriteLine($"{rect} has area {Area(rect)}")

        }
    }
}
