﻿using System;

namespace TestConsole2
{
    partial class Program
    {
        public class MotorVechicle
        {
            private readonly GPSTracker _gps = new GPSTracker();

            public string Color { get; set; }
            
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
                _gps.GoToAPlace(address);
            }
        }
    }
}
