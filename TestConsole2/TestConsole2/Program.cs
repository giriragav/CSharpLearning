using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole2
{
    partial class Program
    {
        static void Main(string[] args)
        {
            int i = 256;
            byte b = (byte)i;

            var s = "1234";
            int j = int.Parse(s);
            float f = float.Parse(s);

            var person = new Person() { age = 20 };
            person.firstName = "Arjun";
            person.lastName = "Giridharan";
            person.Introduce();
            Person.Walkout();
            Makeold(person);
            Console.WriteLine(person.age);
        }
        public static void Makeold(Person p)
        {
            p.age += 20;
        }
    }
}
