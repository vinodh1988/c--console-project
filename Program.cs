// See https://aka.ms/new-console-template for more information
using Consoleapp;

Computer[] computers = new Computer[5];
computers[0] = new Computer(1, "Dell", "Inspiron", 8, 512);
computers[1] = new Computer(2, "HP", "Pavilion", 16, 1024);
computers[2] = new Computer(3, "Apple", "MacBook Pro", 16, 512);
computers[3] = new Computer(4, "Lenovo", "ThinkPad", 8, 256);
computers[4] = new Computer(5, "Asus", "ZenBook", 12, 512);

foreach (Computer comp in computers)
{
    //comp.Show();
    Console.WriteLine(comp);
}

computers[0].setField("Acer", "I7");
computers[2].setField(32, 2048);
computers[4].setField("Microsoft");

foreach (Computer comp in computers)
{
    //comp.Show();
    Console.WriteLine(comp);
}
/*
Console.WriteLine("Hello, World!");
Console.WriteLine(First.Greet("John"));

Person person = new Person();
Person person1 =new Person(2,"Mary","Los Angeles");
person.Sno = 1;
person.Name = "John Doe";
person.City = "New York";
person.Show();
person1.Show();
*/