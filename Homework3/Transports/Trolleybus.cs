namespace Homework3.Transports
{
    class Trolleybus : Transport
    {
        public Trolleybus(int transportNumber, int numberOfSeats, string destinationPoint, string departureTime) : base(transportNumber, numberOfSeats, destinationPoint, departureTime)
        {}

        public override string GetTypeOfTransport<Trolleybus>(Trolleybus transport)
        {
            return $"Данный вид транспорта - {transport.GetType().Name}";
        }
    }
}
