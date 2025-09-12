namespace Consoleapp
{
    public class Extension : Original
    {
        private int b;

        public int B
        {
            get { return b; }
            set { b = value; }
        }

        public Extension() : base()
        {
            b = 0;
        }

        public Extension(int aValue, int bValue) : base(aValue)
        {
            b = bValue;
        }

        public override void Show()
        {
            base.Show(); // Call Original's Show method
            Console.WriteLine($"b = {b}");
        }

        public void DisplayExtension()
        {
            Console.WriteLine($"a = {A}, b = {b}");
        }
    }
}