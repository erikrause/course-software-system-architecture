using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.Models.Target
{
    public class AirFlight
    {
        public AirFlight()
        {

        }
        public string DestinationCountry { get; set; }
        public string DestinationCity { get; set; }
        public string SourceCity { get; set; }
        public string SourceCountry { get; set; }
    }
}
