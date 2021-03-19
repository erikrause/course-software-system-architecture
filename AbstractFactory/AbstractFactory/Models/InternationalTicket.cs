using AbstractFactory.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Models
{
    public class InternationalTicket : ITicket
    {
        public InternationalTicket(IAirFlight airFlight, int type)
        {
            AirFlight = airFlight;
            Type = type;
        }
        public string PassengerName { get; set; }
        public int Type { get; }
        public decimal Price { get => (10000 / 75) * (1 / Type); }
        public Currency Currency { get => Currency.USD; }
        public IAirFlight AirFlight { get; }

        /// <summary>
        /// Номер загран паспорта.
        /// </summary>
        public string InternationalPassportId { get; set; }    // только в реализации International.
    }
}
