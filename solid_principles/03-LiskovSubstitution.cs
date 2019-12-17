using System;
using System.Collections.Generic;

namespace DesignPatterns
{
     public class Rectangle // Init basic Rectangle
    {
        public virtual int Width { get; set; }
        public virtual int Height { get; set; }

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

    public class Square : Rectangle
    {
        public override int Width
        {
            set { base.Width = base.Height = value; }
        }

        public override int Height
        {
            set { base.Width = base.Height = value; }
        }
    }
    public class LiskovSubstitution
    {
        static public int Area(Rectangle r) => r.Width * r.Height;
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(2,3);
            WriteLine($"{rect} has area {Area(rect)}");

            Rectangle square = new Square();
            square.Width = 4;
            WriteLine($"{square} has area {Area(square)}");
        }
    }
}
