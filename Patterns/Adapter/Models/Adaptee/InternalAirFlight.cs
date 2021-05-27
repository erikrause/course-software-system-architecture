using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.Models.Adaptee
{
    /// <summary>
    /// Класс для хранения данных о самолете в метрической системе (CИ).
    /// </summary>
    public class InternalAirFlight
    {
        public InternalAirFlight()
        {
            Country = "Russia";
        }
        //public string DestinationCountry { get; } / - это поле появляется в классе InternationalAirFlight.
        public string DestinationCity { get; set; }
        public string SourceCity { get; set; }
        public string Country { get; set; }
    }
}
