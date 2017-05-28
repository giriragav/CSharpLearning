using System;

namespace TestConsole2
{
    partial class Program
    {
        public class Person
        {
            public string firstName;
            public string lastName;
            public int age;

            public void Introduce()
            {
                Console.WriteLine("Hello! my name is " + firstName + " " + lastName);
            }
            public static void Walkout()
            {
                Console.WriteLine("Tata bye bye");
            }
        }
    }
}
