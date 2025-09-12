namespace Consoleapp
{
    public class Original
    {
        private int a;

        public int A
        {
            get { return a; }
            set { a = value; }
        }

        public Original()
        {
            a = 0;
        }

        public Original(int value)
        {
            a = value;
        }

        public void Show()
        {
            Console.WriteLine($"a = {a}");
        }

        public void Display()
        {
            Console.WriteLine($"a = {a}");
        }
    }
}