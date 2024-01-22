namespace Homework3.Transports
{
    class Transport
    {
        public int TransportNumber { get; set; } = 0;
        public int NumberOfSeats { get; set; } = 0;
        public string DestinationPoint { get; set; } = "";
        public string DepartureTime { get; set; } = DateTime.Now.ToString("HH:mm");

        protected Transport(int transportNumber, int numberOfSeats, string destinationPoint, string departureTime) 
        {
            TransportNumber = transportNumber;
            NumberOfSeats = numberOfSeats;
            DestinationPoint = destinationPoint;
            DepartureTime = departureTime;
        }

        public virtual string GetTypeOfTransport<T>(T transport)
        {
            return transport.GetType().Name;
        }

        /// <summary>
        /// Нельзя переоределить
        /// </summary>
        public void DoNotChangeThisMethod()
        {

        }
    }
}
