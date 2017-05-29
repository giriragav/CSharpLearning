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
            UseConversions();
            UsePerson();
            UsePoints();
            UseCalculator();
        }
        static void UseCalculator()
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2));
            Console.WriteLine(calculator.Add(1, 2, 3));
            Console.WriteLine(calculator.Add(1, 2, 3, 4));
            Console.WriteLine(calculator.Add(new int[] { 1, 2, 3, 4, 5 }));
        }
        static void UseConversions()
        {
            int i = 256;
            byte b = (byte)i;

            var s = "1234";
            int j = int.Parse(s);
            float f = float.Parse(s);
        }
        static void UsePerson()
        {
            var person = new Person("Preethi", "Venkataraman", new DateTime(1983, 04, 29))
            {
                ID = 20,
                Job = new List<Jobs>()
            };
            var job = new Jobs();
            person.Job.Add(job);
            person.Introduce();
            Person.Walkout();
            Console.WriteLine(person.Age);
        }
        static void UsePoints()
        {
            try
            {
                var point = new Point(10, 10);
                point.Move(20, 20);
                Console.WriteLine("Point is at ({0},{1}) - {2}", point.XX, point.YY, point.FF);
                point.Move(point);
                Console.WriteLine("Point is at ({0},{1}) - {2}", point.XX, point.YY, point.FF);
                point.Move(new Point(20, 20));
                Console.WriteLine("Point is at ({0},{1}) - {2}", point.XX, point.YY, point.FF);
                point.Move(point);
                Console.WriteLine("Point is at ({0},{1}) - {2}", point.XX, point.YY, point.FF);
            }
            catch (Exception)
            {

                Console.WriteLine("An unexpected error occured");
            }
        }
    }
}
