using System;

namespace Consoleapp
{
    public class Computer
    {
        public int Cno { get; set; }
        public string Brand { get; set; }
        public string Cpu { get; set; }
        public int Ram { get; set; }
        public int Disk { get; set; }

        // Default constructor
        public Computer()
        {
        }

        // Parameterized constructor
        public Computer(int cno, string brand, string cpu, int ram, int disk)
        {
            Cno = cno;
            Brand = brand;
            Cpu = cpu;
            Ram = ram;
            Disk = disk;
        }
      

        public override string ToString()
        {
            return $"Cno: {Cno}, Brand: {Brand}, CPU: {Cpu}, RAM: {Ram}GB, Disk: {Disk}GB";
        }
     

        public void Show()
        {
            Console.WriteLine(this.ToString());
        }
    }
}