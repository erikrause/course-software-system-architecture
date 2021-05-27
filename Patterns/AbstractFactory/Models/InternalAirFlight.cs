using AbstractFactory.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Models
{
    public class InternalAirFlight : IAirFlight
    {
        public InternalAirFlight(string sourceCity, string destinationCity, string sourceCountry)
        {
            SourceCity = sourceCity;
            DestinationCity = destinationCity;
            SourceCountry = sourceCountry;

            Passengers = new List<ITicket>();
        }

        public string DestinationCountry { get => SourceCountry; }      // Страна назначения такая же, как и страна отправления.
        public string DestinationCity { get; }
        public string SourceCity { get; }
        public string SourceCountry { get; }
        public IList<ITicket> Passengers { get; }
    }
}
