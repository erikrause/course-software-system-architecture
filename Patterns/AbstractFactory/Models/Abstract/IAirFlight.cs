using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Models.Abstract
{
    public interface IAirFlight
    {
        public IList<ITicket> Passengers { get; }
        //public bool IsNonstop;
        /// <summary>
        /// Страна назначения.
        /// </summary>
        public string DestinationCountry { get; }

        /// <summary>
        /// Город назначения.
        /// </summary>
        public string DestinationCity { get; }

        /// <summary>
        /// Город отправления.
        /// </summary>
        public string SourceCity { get; }

        /// <summary>
        /// Страна отправления.
        /// </summary>
        public string SourceCountry { get; }
    }
}
