namespace Lab3CSharp
{
    internal class TransportVehicle
    {
        public string Name { get; set; }
        public int MaxSpeed { get; set; }   

        public virtual void Show()
        {
            Console.WriteLine($"Транспортний засіб: {Name} , максимальна швидкість: {MaxSpeed}");
        }

    }
}
