using System;
namespace ConsoleUI
{
    public class Car : Vehicle
    {
        public string HasTrunk { get; set; }

        public override void DriveAbstract()
        {
            Console.WriteLine($"I'm driving Abstract");
        }

        public override void DriveVirtual()
        {
            base.DriveVirtual();
        }


    }
}
