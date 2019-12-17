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

    }
    public class Liskov
    {
        static void Main(string[] args)
    }
}
