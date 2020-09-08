using System;
namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public int Year { get; set; } = 1;
        public string Make { get; set; } = " Gen Make";
        public string Model { get; set; } = "Gen Model";

        public abstract void DriveAbstract();

        public virtual void DriveVirtual()
        {
            Console.WriteLine("I drive using Virtual Method.");
        }
      


    }
}
