namespace Lab3CSharp
{
    internal class Train:TransportVehicle
    {
        public int NumOfWagons { get; set; }

        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Кількість вагонів: {NumOfWagons}");
        }
    }
}
