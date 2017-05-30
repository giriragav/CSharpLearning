using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vechiles;
using WorkflowEngine;
namespace TestConsole2
{
    partial class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StopWatch timer = new StopWatch();
                timer.StartClock();
                //UseConversions();
                //UsePerson();
                //UsePoints();
                //UseCalculator();
                //UseHttpCookie();
                //UsePost();
                //UseMotor();
                UseAutoService();
                //UseStack();
                //UseDBConnection();
                //UseWorkflowEngine();
                timer.StopClock();
                Console.WriteLine("Total execution time: {0}", timer.TickedTime());
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
           
        }
        static void UseWorkflowEngine()
        {
            var wrkflwEngine = new WorkflowEngine.WorkflowEngine();
            var wrkflow = new Workflow();
            wrkflow.SetActivities(new Acitivity1());
            wrkflow.SetActivities(new Acitivity2());

            wrkflwEngine.ExecuteTasks(wrkflow);

        }
        static void UseDBConnection()
        {
            try
            {
                var sqlConn = new SQLConnection("SQLConnectionString");
                var oracleConn = new OracleConnection("OracleConnectionString");

                sqlConn.OpenConnection();
                oracleConn.OpenConnection();

                sqlConn.CloseConnection();
                oracleConn.CloseConnection();

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            
        }
        static void UseStack()
        {
            var stack = new Stack();
            for(int i= 1;i < 5;i++)
                stack.Push(i);
            
            while(true)
            {
                try
                {
                    Console.WriteLine(stack.Pop());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    break;
                }
            }
        }
        static void UseMotor()
        {
            List<MotorVechicle> vechiles = new List<MotorVechicle>();

            var car = new MotorCar("EZL 7593", new GPSTracker());
            car.Color = "Black";
            car.CarType = "Sedan";
            car.OpenDoor();
            car.StartCar("Las Vegas");

            vechiles.Add(car);

            var cycle = new MotorCycle("EPP 1234", new MobileGoogleMapApp());
            cycle.StartCcycle("Florida");

            vechiles.Add(cycle);

            var demo = new ShowRoom();
            demo.TryVechiles(vechiles);

           
        }
        static void UseAutoService()
        {
            var car = new MotorCar("EZL 7593", new GPSTracker());
            var service = new AutoService();
            //service.DoService(car);
            var repair = new AutoRepair();
            var wash = new AutoWash();

            Action<MotorCar> servicehandler = repair.OilChange;
            servicehandler += repair.TyreChange;
            //servicehandler += wash.ScartchRemoval;
            servicehandler += wash.WaterSpray;
            servicehandler += wash.ApplySoap;
            servicehandler += wash.WaterSpray;

            service.DoService(car, servicehandler);
        }
        static void UsePost()
        {
            var post = new Post("Exercise", "Design a class called Post. This class models a StackOverflow post. It should have properties for title, description and the date / time it was created.We should be able to up - vote or down - vote a post.We should also be able to see the current vote value.In the main method, create a post, up - vote and down - vote it a few times and then display the the current vote value. ");
            post.Vote(true);
            post.Vote(true);
            post.Vote(false);
            Console.WriteLine("Post title: {0}; Crated Date: {1}; Up Vote:{2}; Down Vote {3}", post.Title, post.CreatedTime, post.UpVote, post.DownVote);
        }
        static void UseHttpCookie()
        {
            HttpCookie cookie = new HttpCookie();
            cookie["name"] = "Giridharan Venkatesan";
            cookie["Age"] = "10";
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
