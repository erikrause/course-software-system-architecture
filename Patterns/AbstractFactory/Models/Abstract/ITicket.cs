using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Models.Abstract
{
    /// <summary>
    /// Тип для хранения валюты.
    /// </summary>
    public enum Currency
    {
        RUB,
        USD
    }

    /// <summary>
    /// Тип для регистрации билета.
    /// </summary>
    public interface ITicket
    {
        IAirFlight AirFlight { get; }
        /// <summary>
        /// Имя пассажира.
        /// </summary>
        string PassengerName { get; set; }

        /// <summary>
        /// Тип посадочного места (VIP, 1 класс, 2 класс...).
        /// </summary>
        int Type { get; }

        /// <summary>
        /// Цена билета.
        /// </summary>
        decimal Price { get; }

        /// <summary>
        /// Валюта.
        /// </summary>
        Currency Currency { get; }
    }
}
