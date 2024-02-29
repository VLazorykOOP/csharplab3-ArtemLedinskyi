namespace Lab3CSharp
{
    internal class Car:TransportVehicle
    {
        public int NumOfSeats { get; set; }

        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Кількість мість: {NumOfSeats}");
        }
    }
}
