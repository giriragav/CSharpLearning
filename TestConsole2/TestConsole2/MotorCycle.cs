using System;

namespace TestConsole2
{
    partial class Program
    {
        public class MotorCycle : MotorVechicle
        {
            private readonly GPSTracker _gps;

            public string CycleName { get; set; }

            public MotorCycle(GPSTracker gps)
            {
                _gps = gps;
            }

            public void PutStand()
            {
                Console.WriteLine("Cycle is on stand.");
            }

            public void SetDestination(string address)
            {
                _gps.GoToAPlace(address + " by cycle");
            }
        }
    }
}
