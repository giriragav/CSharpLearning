using System;

namespace Vechiles
{
    public class MobileGoogleMapApp : INavigationSystem
    {
        public void GoToAPlace(string address)
        {
            Console.WriteLine("Going to {0} with Google Map in Mobile", address);
        }
    }
}

