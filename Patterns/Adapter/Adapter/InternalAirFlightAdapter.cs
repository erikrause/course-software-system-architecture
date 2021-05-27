using Adapter.Models.Adaptee;
using Adapter.Models.Target;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.Adapter
{
    public class InternalAirFlightAdapter : AirFlight
    {
        protected InternalAirFlight _internalAirFlight;
        public InternalAirFlightAdapter(InternalAirFlight internalAirFlight)
        {
            _internalAirFlight = internalAirFlight;
        }
        public new string DestinationCountry { get => _internalAirFlight.Country; }
        public new string SourceCountry { get => _internalAirFlight.Country; }
    }
}
