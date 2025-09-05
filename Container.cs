using System;

namespace Consoleapp
{
    public class Container
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int localCount = 0;

        private static int Count = 0;
        public Container()
        {
            Count++;
            localCount++;
            Id = Count;
            Name = "Container" + Id;
        }

        public override string ToString()
        {
            return $"Container ID: {Id}, Name: {Name} (Local Count: {localCount})";
        }

        public void Show()
        {

            Console.WriteLine(this.ToString());
        }

        public static void DisplayCount()
        {
            Console.WriteLine($"Total Containers: {Count}");
           
        }

        public void DisplayLocalCount()
        {
            Console.WriteLine($"Local Count for {Name}: {localCount}");
            Console.WriteLine($"Total Containers: {Count}");
        }
    }
}