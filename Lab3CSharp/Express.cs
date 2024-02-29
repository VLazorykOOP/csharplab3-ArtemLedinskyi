namespace Lab3CSharp
{
    internal class Express : TransportVehicle
    {
        public string Destination { get; set; }

        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Пункт призначення: {Destination}");
        }
    }
}
