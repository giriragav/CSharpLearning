using System;
using System.Collections.Generic;

namespace TestConsole2
{
    partial class Program
    {
        public class Person
        {
            public string firstName;
            public string lastName;
            public int age;
            public List<Jobs> Job;

            public Person()
            {
                Job = new List<Jobs>();
            }
            public Person(string fName, string lName)
                :this()
            {
                this.firstName = fName;
                this.lastName = lName;
            }
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
