using System;

namespace Vechiles
{
    public class MotorVechicle
    {
        private readonly GPSTracker _gps = new GPSTracker();
        private string _registrationNumber;

        public string Color { get; set; }

        public MotorVechicle(string regNumber)
        {
            _registrationNumber = regNumber;
        }

        public void StartEngine()
        {
            Console.WriteLine("Vechicle is started.");
        }

        public void StopEngine()
        {
            Console.WriteLine("Vechicle is stopped.");
        }

        protected void SetDestination(string address)
        {
            _gps.GoToAPlace(address + " " + this._registrationNumber);
        }

        public virtual void TestDrive()
        {

        }
    }
}

