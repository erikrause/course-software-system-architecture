using AbstractFactory.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Factory.Abstract
{
    public interface IAirTicketsFactory
    {
        /// <summary>
        /// Создать объект, для отслеживания полета.
        /// </summary>
        /// <param name="sourceCity"> Город отправления. </param>
        /// <param name="destinationCity"> Город назначения. </param>
        /// <param name="sourceCountry"> Страна отправления. </param>
        /// <param name="destinationCountry"> Страна прибытия. </param>
        /// <returns></returns>
        IAirFlight CreateAirFlight(string sourceCity, string destinationCity, string sourceCountry, string destinationCountry);

        ITicket CreateTicket(IAirFlight airFlight, int type);
    }
}
