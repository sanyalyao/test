using Homework3.Transports;

namespace Homework3
{
    class Program
    {
        static void Main()
        {
            var transports = GetTransport();

            transports.OrderByDescending(transport => transport.NumberOfSeats).ToList().ForEach(ShowMessage); // сортировка по количеству мест
            GetDepartureTimeOrDestinationPoint(transports);
            ShowTransportsAfterTheTime(transports);
            GetTransportType(transports);
        }

        /// <summary>
        /// Вывести тип транспорта
        /// </summary>
        /// <param name="transports"></param>
        static void GetTransportType(List<Transport> transports)
        {
            transports.ForEach(transport => Console.WriteLine(TransportService.PrintTransportType(transport)));
        }

        /// <summary>
        /// Вывести на консоль список транспорта, отправляющегося после заданного времени
        /// </summary>
        /// <param name="transports"></param>
        static void ShowTransportsAfterTheTime(List<Transport> transports)
        {
            Console.WriteLine("Укажите время отправления");

            var departureTime = DateTime.ParseExact(Console.ReadLine(), "HH:mm", null);

            transports.FindAll(transport => DateTime.ParseExact(transport.DepartureTime, "HH:mm", null) > departureTime).ForEach(ShowMessage);
        }

        /// <summary>
        /// запрос у пользователя время отправления и/или пункт назначения
        /// </summary>
        static void GetDepartureTimeOrDestinationPoint(List<Transport> transports)
        {
            Console.WriteLine("Укажите время отправления, если известно");

            string departureTime = Console.ReadLine() == "" ? string.Empty : Console.ReadLine();

            Console.WriteLine("Укажите пункт назначения, если известно");

            string destinationPoint = Console.ReadLine().ToLower();

            transports.FindAll(transport => transport.DepartureTime.Equals(departureTime) || transport.DestinationPoint.ToLower() == destinationPoint).ForEach(ShowMessage);
        }

        static List<Transport> GetTransport()
        {
            var transports = new List<Transport>()
            {
                new Bus(195, 22, "First point", DateTime.Now.AddHours(8).ToString("HH:mm")),
                new Trolleybus(45, 49, "Second point", DateTime.Now.AddDays(4).ToString("HH:mm")),
                new Tramcar(1599, 30, "Third point", DateTime.Now.AddMinutes(30).ToString("HH:mm")),
            };

            return transports;
        }

        static void ShowMessage(Transport transport)
        {
            Console.WriteLine($"Пункт назначения - {transport.DestinationPoint}, Номер - {transport.TransportNumber}, Время отправления - {transport.DepartureTime}, Число мест - {transport.NumberOfSeats}, {transport.GetTypeOfTransport(transport)}");
        }
    }
}