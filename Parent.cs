namespace Consoleapp
{
    public class Parent
    {
        public string DataA { get; set; }

        // Default constructor
        public Parent()
        {
            DataA = string.Empty;
        }

        // Parameterized constructor
        public Parent(string dataA)
        {
            DataA = dataA;
        }

        // Show method
        public virtual void Show()
        {
            Console.WriteLine($"DataA: {DataA}");
        }

        // Override ToString method
        public override string ToString()
        {
            return $"DataA: {DataA}";
        }
    }
}