namespace Consoleapp
{
    public class A
    {
        public virtual void Show()
        {
            Console.WriteLine("This is a sealed method in First class.");
        } // the method is overridable

        public void Display()
        {
            Console.WriteLine("This is a non-virtual method in First class.");
        }
        public virtual void Print()
        {
            Console.WriteLine("This is a non-virtual method in First class.");
        }
    }

    class B : A
    {
        public override void Show()
        {
            Console.WriteLine("This is an overridden method in Second class.");
        }

        // This will cause a compile-time error because Display is not virtual
        public new void Display()
        {
            Console.WriteLine("This is an attempt to override a non-virtual method in Second class.");
        }// not overiding, method hiding

        public override void Print()
        {
            Console.WriteLine("This is an overridden method in Second class.");
        }
    }

    class C : B
    {
        // This will cause a compile-time error because Show is sealed in class B
        public override void Show()
         {
            Console.WriteLine("This is an attempt to override a sealed method in Third class.");
         }

        public new void Display()
        {
            Console.WriteLine("This is an attempt to override a non-virtual method in Third class.");
        }// not overiding, method hiding

        public override void Print()
        {
            Console.WriteLine("This is an overridden method in Third class.");
        }
    } 
        
}