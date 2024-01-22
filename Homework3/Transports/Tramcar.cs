namespace Homework3.Transports
{
    class Tramcar : Transport
    {
        public Tramcar(int transportNumber, int numberOfSeats, string destinationPoint, string departureTime) : base(transportNumber, numberOfSeats, destinationPoint, departureTime)
        {}

        public override string GetTypeOfTransport<TramcarNumber>(TramcarNumber transport)
        {
            return $"Данный вид транспорта - {transport.GetType().Name}";
        }
    }
}
