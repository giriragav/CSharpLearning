using System;
using System.Collections.Generic;

namespace TestConsole2
{

    public class Person
    {
        private string firstName;
        private string lastName;
        private int id;
        public List<Jobs> Job;

        public string FirstName {get{return this.firstName;}set{this.firstName = value;}}
        public string LastName{get{return this.lastName;}set{this.lastName = value;}}
        public int ID{get{return this.id;}set{this.id = value;}}
            
        public DateTime BirthDate { get; private set; }

        public int Age
        {
            get
            {
                return (DateTime.Today - BirthDate).Days / 365;
            }
        }

        public Person()
        {
            Job = new List<Jobs>();
        }
        public Person(string fName, string lName, DateTime bDate)
            :this()
        {
            this.firstName = fName;
            this.lastName = lName;
            this.BirthDate = bDate;
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
