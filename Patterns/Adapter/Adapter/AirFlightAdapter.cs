using Adapter.Models.Adaptee;
using Adapter.Models.Target;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.Adapter
{
    public class AirFlightAdapter : AirFlight
    {
        protected InternalAirFlight _internalAirFlight;
        public AirFlightAdapter(InternalAirFlight internalAirFlight)
        {
            _internalAirFlight = internalAirFlight;
        }
        public new string DestinationCountry { get => _internalAirFlight.Country; } // переопределяем методы доступа для свойства.
    }
}
