namespace Homework3.Transports
{
    class Bus : Transport
    {
        public Bus(int transportNumber, int numberOfSeats, string destinationPoint, string departureTime) : base(transportNumber, numberOfSeats, destinationPoint, departureTime)
        { }

        public override string GetTypeOfTransport<Bus>(Bus transport)
        {
            return $"Данный вид транспорта - {transport.GetType().Name}";
        }
    }
}
