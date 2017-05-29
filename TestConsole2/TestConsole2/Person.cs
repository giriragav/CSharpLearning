using System;
using System.Collections.Generic;

namespace TestConsole2
{
    partial class Program
    {
        public class Person
        {
            private string firstName;
            private string lastName;
            private int age;
            public List<Jobs> Job;

            public string FirstName
            {
                get
                {
                    return this.firstName;
                }
                set
                {
                    this.firstName = value;
                }
            }

            public string LastName
            {
                get
                {
                    return this.lastName;
                }
                set
                {
                    this.lastName = value;
                }
            }

            public int Age
            {
                get
                {
                    return this.age;
                }
                set
                {
                    this.age = value;
                }
            }


            public Person()
            {
                //Job = new List<Jobs>();
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
