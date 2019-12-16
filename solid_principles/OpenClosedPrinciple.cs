using System;
using System.Collections.Generic;

namespace DesignPatterns
{
    public enum Color
    {
        Red, Green, Blue        
    }

    public enum Size
    {
        Small, Medium, Large, XLarge
    }

    public class Product
    {
        public string Name;
        public Color Color;
        public Size Size;

        public Product(string name, Color color, Size size)
        {
            if (name == null)
            {
                throw new ArgumentNullException(paramName: nameof(name));
            }
            Name = name;
            Color = color;
            Size = size;
        }
    }

    public class ProductFilter
    {
        public static IEnumerable<Product> FilterBySize(IEnumerable<Product> products,
        Size size)
        {
            foreach (var p in products)
                if (p.Size == size)
                    yield return p;
        }
    }

    public class OrderSystem
    {
        static void Main(string[] args)
        {

        }
    }

}