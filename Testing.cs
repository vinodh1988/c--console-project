namespace Consoleapp
{
    public class Testing : IProcess
    {
        public void Execute()
        {
            // Implementation of the Execute method
            System.Console.WriteLine("Testing.Execute() called.");
        }

        public void RunTests()
        {
            // Implementation of the RunTests method
            System.Console.WriteLine("Running tests...");
        }
    }
}