using System;
namespace ConsoleUI
{
	public abstract class Vehicle
	{
        public int Year { get; set; } = 1;
        public string Make { get; set; } = "Default Make";
        public string Model { get; set; } = "Default Model";

        public abstract void DriveAbstract(); // stubed out method. (no implementation)

        public virtual void DriveVirtual() // Has implementation (scope / stuff it will do)
        {
            Console.WriteLine($"This {GetType().Name} is virtually in drive.");

        }
    }
}

 