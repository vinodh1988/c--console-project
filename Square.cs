using System;

namespace ConsoleApp
{
    public class Square : Shape
    {
        // Default constructor
        public Square() : base()
        {
            Name = "Square";
        }

        // Parameterized constructor
        public Square(string name, int side) : base(name, 4)
        {
        }

        // Override Show method
        public override void Show()
        {
            base.Show();
            Console.WriteLine($" Side: {Side}");
        }

        // Implement Area method
        public override void Area()
        {
            int area = Side * Side;
            Console.WriteLine($"Area of {Name}: {area}");
        }

        // Implement Perimeter method
        public override void Perimeter()
        {
            int perimeter = 4 * Side;
            Console.WriteLine($"Perimeter of {Name}: {perimeter}");
        }
    }
}