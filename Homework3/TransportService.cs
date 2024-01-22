using Homework3.Transports;

namespace Homework3
{
    static class TransportService
    {
        public static string PrintTransportType(Transport transport)
        {
            return transport.GetTypeOfTransport(transport);
        }
    }
}
