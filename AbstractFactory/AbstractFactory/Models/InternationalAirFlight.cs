using AbstractFactory.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Models
{
    public class InternationalAirFlight : IAirFlight
    {
        public InternationalAirFlight(string sourceCity, string destinationCity, string sourceCountry, string destinationCountry)
        {
            SourceCity = sourceCity;
            DestinationCity = destinationCity;
            SourceCountry = sourceCountry;
            DestinationCountry = destinationCountry;

            Passengers = new List<ITicket>();
        }
        public string DestinationCountry { get; }
        public string DestinationCity { get; }
        public string SourceCity { get; }
        public string SourceCountry { get; }
        public IList<ITicket> Passengers { get; }
    }
}
