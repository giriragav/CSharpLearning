using System;

namespace Vechiles
{
    public class GPSTracker:INavigationSystem
    {
        public void GoToAPlace(string address)
        {
            Console.WriteLine("Going to {0} with GPS", address);
        }
    }
}

