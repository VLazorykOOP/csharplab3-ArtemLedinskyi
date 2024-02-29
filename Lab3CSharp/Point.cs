using System;


namespace Lab3CSharp
{
    internal class Point
    {
        protected int x;
        protected int y;
        protected int color;

        public Point()
        {
            x = 0;
            y = 0;
            color = 0;
        }
        public Point(int x, int y, int color)
        {
            this.x = x;
            this.y = y;
            this.color = color;
        }

        public void Print()
        {
            Console.WriteLine($"Координати точки x: {this.x} , y: {this.y}"); 
        }

        public void Move(int x1, int y1)
        {
            x += x1;
            y += y1;
        }

        public double DistanceToOrigin()
        {
            return Math.Sqrt(x * x + y * y);
        }

        public int X {
            get { return x; }
            set { x = value; }
        }

        public int Y {
            get { return y; } 
            set {  y = value; }
        }

        public int Color {
            get { return color; }
        }
    }
}
