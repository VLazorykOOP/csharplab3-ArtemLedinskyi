namespace Lab3CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Оберіть завдання (1 або 2):");
            int choice = int.Parse(Console.ReadLine());

            switch (choice) {
                case 1:
                    Point point1 = new Point(3, 4, 1);

                    point1.Print();

                    point1.Move(3, 4);
                    point1.Print();
                    Console.WriteLine(point1.DistanceToOrigin());
                    break;
                case 2:
                    List<TransportVehicle> vehicles = new List<TransportVehicle>();

                    // Наповнення масиву різними об’єктами похідних класів
                    vehicles.Add(new Car { Name = "Toyota", MaxSpeed = 180, NumOfSeats = 5 });
                    vehicles.Add(new Train { Name = "InterCity", MaxSpeed = 200, NumOfWagons = 10 });
                    vehicles.Add(new Express { Name = "HighSpeed", MaxSpeed = 300, Destination = "Kyiv" });

                    // Виведення масиву впорядкованого за максимальною швидкістю
                    vehicles.Sort((x, y) => x.MaxSpeed.CompareTo(y.MaxSpeed));

                    Console.WriteLine("Впорядкований масив за максимальною швидкістю:");
                    foreach (var vehicle in vehicles)
                    {
                        vehicle.Show();
                        Console.WriteLine();
                    }
                    break;
            }

        }




    }
}
