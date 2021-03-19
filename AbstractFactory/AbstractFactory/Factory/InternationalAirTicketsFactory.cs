using AbstractFactory.Models;
using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactory.Models.Abstract;
using AbstractFactory.Factory.Abstract;

namespace AbstractFactory.Factory
{
    class InternationalAirTicketsFactory : IAirTicketsFactory
    {
        public IAirFlight CreateAirFlight(string sourceCity, string destinationCity, string sourceCountry, string destinationCountry)
        {
            return new InternationalAirFlight(sourceCity, destinationCity, sourceCountry, destinationCountry);
        }

        public ITicket CreateTicket(IAirFlight airFlight, int type)
        {
            InternationalTicket ticket = new InternationalTicket(airFlight, type);
            return ticket;
        }
    }
}
