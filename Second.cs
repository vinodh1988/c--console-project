namespace Consoleapp
{
    public class Person
    {
        // Fields
        private int sno;
        private string name;
        private string city;

        // Non-parameterized constructor
        public Person()
        {
            sno = 0;
            name = string.Empty;
            city = string.Empty;
        }

        // Parameterized constructor
        public Person(int sno, string name, string city)
        {
            this.sno = sno;
            this.name = name;
            this.city = city;
        }
        // Properties
        public int Sno
        {
            get { return sno; }
            set { sno = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        // Method to show the fields
        public void Show()
        {
            Console.WriteLine($"Sno: {sno}, Name: {name}, City: {city}");
        }
    }
}