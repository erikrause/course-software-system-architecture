using AbstractFactory.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Models
{
    public class InternalTicket : ITicket
    {
        public InternalTicket(IAirFlight airFlight, int type)
        {
            AirFlight = airFlight;
            Type = type;
        }
        public string PassengerName { get; set; }
        public int Type { get; }
        public decimal Price { get => 10000 * (1 / Type); }
        public Currency Currency { get => Currency.RUB; }
        public IAirFlight AirFlight { get; }
    }
}
