// See https://aka.ms/new-console-template for more information
using Consoleapp;

Console.WriteLine("Hello, World!");
Console.WriteLine(First.Greet("John"));

Person person = new Person();
Person person1 =new Person(2,"Mary","Los Angeles");
person.Sno = 1;
person.Name = "John Doe";
person.City = "New York";
person.Show();
person1.Show();