using System;

namespace ConsoleApp
{
    public class Rectangle : Shape
    {
        public int Length { get; set; }
        public int Breadth { get; set; }

        // Default constructor
        public Rectangle() : base()
        {
            Length = 0;
            Breadth = 0;
        }

        // Parameterized constructor
        public Rectangle(string name,int length, int breadth) : base(name, 4)
        {
            Length = length;
            Breadth = breadth;
        }

        // Override Show method
        public override void Show()
        {
            base.Show();
            Console.WriteLine($" Length: {Length}, Breadth: {Breadth}");
        }

        // Implement Area method

        public override void Area()
        {
            int area = Length * Breadth;
            Console.WriteLine($"Area: {area}");
        }
        // Implement Perimeter method
        public override void Perimeter()
        {
            int perimeter = 2 * (Length + Breadth);
            Console.WriteLine($"Perimeter: {perimeter}");
        }
    }
}