using System;

namespace Vechiles
{
    public abstract class MotorVechicle
    {
        private INavigationSystem _gps;
        private string _registrationNumber;

        public string Color { get; set; }

        public MotorVechicle(string regNumber, INavigationSystem gps)
        {
            _gps = gps;
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

        public abstract void TestDrive();
}
}

