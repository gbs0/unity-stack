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
    
    public interface ISpecification<T> 
    {
        bool IsSatisfied(T t); 
    }

    public interface IFilter<T>
    {
        IEnumerable<T> Filter(IEnumerable<T> items, ISpecification<T> spec);
    }

    public class ColorSpecification : ISpecification<Product>
    {
        private Color color;

        public ColorSpecification(Color color)
        {
            this.color = color;
        }

        public IsSatisfied(Product t)
        {
            return t.Color == color;
        }
    }

    public class SizeSpecification : ISpecification<Product>
    {
        private Size size;

        public SizeSpecification(Size size)
        {
            this.size = size;
        }
        public bool IsSatisfied(Product t)
        {
            return t.Size == size;
        }
    }

    public class BetterFilter : IFilter<Product>
    {
        public IEnumerable<Product> Filter(IEnumerable<Product> items, ISpecification<Product> spec);
        {
            foreach (var i in items)
                if(spec.IsSatisfied(i))
                    yield return i;
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
            WriteLine("Green products: (old)");
            foreach (var p in pf.FilterByColor(products, Color.Green))
            {
                WriteLine($" - {p.Name} is green");
            }

            var bf = new BetterFilter();
            WriteLine("Green products: (new)");
            foreach (var p in bf.Filter(products, new ColorSpecification(Color.Green)))
            {
                WriteLine($" - {p.Name} is green");
            }

        }
    }

}