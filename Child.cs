namespace Consoleapp
{
    public class Child : Parent
    {
        public string DataB { get; set; }

        // Default constructor
        public Child() : base()
        {
            DataB = string.Empty;
        }

        // Parameterized constructor
        public Child(string dataA, string dataB) : base(dataA)
        {
            DataB = dataB;
        }

        // Show method (overrides Parent's Show)
        public override void Show()
        {
            base.Show(); // Call Parent's Show method
            Console.WriteLine(ToString());
        }

        // Display method
        public void Display()
        {
            Console.WriteLine($"DataB: {DataB}, ");
        }

        // Override ToString method
        public override string ToString()
        {
            return $"DataB: {DataB}";
        }
    }
}