using System;

namespace TestConsole2
{
    partial class Program
    {
        public class MotorCar: MotorVechicle
        {
            public string CarType { get; set; }

            public void OpenDoor()
            {
                Console.WriteLine("Car door is open.");
            }
        }
    }
}
