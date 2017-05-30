using System;

namespace Vechiles
{
    public class MotorCycle : MotorVechicle
    {
        public string CycleName { get; set; }

        public MotorCycle(string regNumber, INavigationSystem gps)
            :base(regNumber, gps)
        {

        }
            
        public void PutStand()
        {
            Console.WriteLine("Cycle is on stand.");
        }

        public void StartCcycle(string address)
        {
            this.SetDestination(address + " by cycle");
        }
        public override void TestDrive()
        {
            Console.WriteLine("Test driving the cycle");
        }

    }
}

