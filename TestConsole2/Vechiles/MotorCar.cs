using System;

namespace Vechiles
{
    public class MotorCar: MotorVechicle
    {
        public string CarType { get; set; }

        
        public MotorCar(string regNumber, INavigationSystem gps)
            :base(regNumber, gps)
        {

        }
        public void OpenDoor()
        {
            Console.WriteLine("Car door is open.");
        }

        public void StartCar(string address)
        {
            this.SetDestination(address + " by car");
        }

        public override void TestDrive()
        {
            Console.WriteLine("Test driving the car");
        }

    }
}

