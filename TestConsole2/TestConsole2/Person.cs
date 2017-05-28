using System;

namespace TestConsole2
{
    partial class Program
    {
        public class Person
        {
            public string firstName;
            public string lastName;

            public void Introduce()
            {
                Console.WriteLine("Hello! my name is " + firstName + " " + lastName);
            }
        }
    }
}
