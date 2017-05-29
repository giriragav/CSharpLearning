using System;

namespace Vechiles
{
    public class MotorCycle : MotorVechicle
    {
        public string CycleName { get; set; }
            
        public void PutStand()
        {
            Console.WriteLine("Cycle is on stand.");
        }

        public void StartCcycle(string address)
        {
            this.SetDestination(address + " by cycle");
        }
    }
}

