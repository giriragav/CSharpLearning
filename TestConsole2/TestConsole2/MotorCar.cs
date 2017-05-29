using System;

namespace TestConsole2
{
    partial class Program
    {
        public class MotorCar: MotorVechicle
        {
            private readonly GPSTracker _gps;
            public string CarType { get; set; }

            public MotorCar(GPSTracker gps)
            {
                _gps = gps;
            }

            public void OpenDoor()
            {
                Console.WriteLine("Car door is open.");
            }

            public void SetDestination(string address)
            {
                _gps.GoToAPlace(address + " by car");
            }
        }
    }
}
