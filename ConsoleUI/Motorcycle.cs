using System;
namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public string HassideCart { get; set; }

        public override void DriveAbstract()
        {
            Console.WriteLine($"I'm driving Abstract");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine($"I override the Virual.");
        }
    }
}
