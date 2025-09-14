using System;

namespace ConsoleApp
{
    public abstract class Shape
    {
        public string Name { get; set; }
        public int Side { get; set; }

        // Default constructor
        protected Shape()
        {
            Name = string.Empty;
            Side = 0;
        }

        // Parameterized constructor
        protected Shape(string name, int side)
        {
            Name = name;
            Side = side;
        }

        public virtual void Show()
        {
            Console.WriteLine($"Shape: {Name}, Side: {Side}");
        }

        public abstract void Area();
        public abstract void Perimeter();
    }
}