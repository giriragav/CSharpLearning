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

            var person = new Person("Arjun", "Giridharan") {
                age = 20,
                Job = new List<Jobs>()
            };
            var job = new Jobs();
            person.Job.Add(job);
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
