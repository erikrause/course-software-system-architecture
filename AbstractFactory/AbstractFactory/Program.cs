using System;
using AbstractFactory.Models;
using AbstractFactory.Factory;
using AbstractFactory.Models.Abstract;
using AbstractFactory.Factory.Abstract;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            IAirTicketsFactory internalFactory = new InternalAirTicketsFactory();

            IAirFlight internalAirFlight = internalFactory.CreateAirFlight("Сургут", "Москва", "Россия", "Россия");
            ITicket internalTicket = internalFactory.CreateTicket(internalAirFlight, 1);

            Console.WriteLine($"Цена внутреннего билета: {Convert.ToString(internalTicket.Price)} {internalTicket.Currency}");

            ///////////////////////////////////////////////////////////////////////

            IAirTicketsFactory internationalFactory = new InternationalAirTicketsFactory();

            IAirFlight internationalAirFlight = internationalFactory.CreateAirFlight("Сургут", "Москва", "Россия", "Россия");
            ITicket internationalTicket = internationalFactory.CreateTicket(internationalAirFlight, 1);

            Console.WriteLine($"Цена международного билета: {Convert.ToString(internationalTicket.Price)} {internationalTicket.Currency}");

        }
    }
}
