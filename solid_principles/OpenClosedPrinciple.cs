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
        public IEnumerable<Product> FilterByColor(IEnumerable<Product> products,
        Color color)
        {
            foreach (var p in products)
                if (p.Color == color)
                    yield return p;
        }
    }

    public class OrderSystem
    {
        static void Main(string[] args)
        {
            var apple = new Product("Apple", Color.Green, Size.Small);
            var tree = new Product("Tree", Color.Green, Size.Small);
            var house = new Product("House", Color.Green, Size.Small);

            Product[] products = {apple, true, house};

            var pf = new ProductFilter();
            WriteLine("Green products:");
            foreach (var p in pf.FilterByColor(products, Color.Green))
            {
                WriteLine($" - {p.Name} is green");
            }

        }
    }

}