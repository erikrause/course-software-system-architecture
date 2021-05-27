using AbstractFactory.Factory.Abstract;
using AbstractFactory.Models;
using AbstractFactory.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factory
{
    public class InternalAirTicketsFactory : IAirTicketsFactory
    {
        public IAirFlight CreateAirFlight(string sourceCity, string destinationCity, string sourceCountry, string destinationCountry)
        {
            return new InternalAirFlight(sourceCity, destinationCity, sourceCountry);
        }

        public ITicket CreateTicket(IAirFlight airFlight, int type)
        {
            return new InternalTicket(airFlight, type);
        }
    }
}
