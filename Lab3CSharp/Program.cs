namespace Lab3CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point(3, 4, 1);
            Point point2 = new Point(-2, 5, 2);


            point1.Print();

            point1.Move(3, 4);
            point1.Print();
            Console.WriteLine(point1.DistanceToOrigin());
            

        }




    }
}
