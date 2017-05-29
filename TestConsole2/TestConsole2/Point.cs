using System;
namespace TestConsole2
{
    partial class Program
    {
        public class Point
        {
            private int X;
            private int Y;
            private int F;

            public int XX { get { return this.X; } set { this.X = value; } }
            public int YY { get { return this.Y; } set { this.Y = value; } }
            public int FF { get { return this.F; } set { this.F = value; } }

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
