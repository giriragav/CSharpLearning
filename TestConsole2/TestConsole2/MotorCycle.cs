using System;

namespace TestConsole2
{
    partial class Program
    {
        public class MotorCycle : MotorVechicle
        {
            public string CycleName { get; set; }

            public void PutStand()
            {
                Console.WriteLine("Cycle is on stand.");
            }
        }
    }
}
