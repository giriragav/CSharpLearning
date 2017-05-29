using System;
namespace TestConsole2
{
    partial class Program
    {
        public class Point
        {
            public int X;
            public int Y;
            public int F;

            public Point(int x, int y)
            {
                this.X = x;
                this.Y = y;
            }

            public void Move(Point p)
            {
                if (p == null)
                    throw new ArgumentNullException("p") ;

                Move(p.X + 100, p.Y + 100);
                p.F+=1;
            }

            public void Move(int x, int y)
            {
                this.X = x;
                this.Y = y;
            }
        }
    }
}
