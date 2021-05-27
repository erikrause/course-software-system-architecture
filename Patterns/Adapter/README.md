# Абстрактная фабрика

## Абстракции и реализации продуктов:

- [IAirFlight](https://github.com/erikrause/course-software-system-architecture/blob/master/AbstractFactory/AbstractFactory/Models/Abstract/IAirFlight.cs) - класс для представления маршрута полёта.
  - [InternationalAirFlight](https://github.com/erikrause/course-software-system-architecture/blob/master/AbstractFactory/AbstractFactory/Models/InternationalAirFlight.cs) - класс для международных перелетов.
  - [InternalAirFlight](https://github.com/erikrause/course-software-system-architecture/blob/master/AbstractFactory/AbstractFactory/Models/InternalAirFlight.cs) - класс для внутренних перелетов (отличается тем, что SourceCountry = DestinationCountry).
- [ITicket](https://github.com/erikrause/course-software-system-architecture/blob/master/AbstractFactory/AbstractFactory/Models/Abstract/ITicket.cs) - класс для представления пассажирского билета.
  - [InternationalTicket](https://github.com/erikrause/course-software-system-architecture/blob/master/AbstractFactory/AbstractFactory/Models/InternationalTicket.cs) - класс для международных билетов (дополнительно содержит свойство для хранения данных загранпаспорта, цена билета рассчитывается в USD).
  - [InternalTicket](https://github.com/erikrause/course-software-system-architecture/blob/master/AbstractFactory/AbstractFactory/Models/InternalTicket.cs) - класс для внутренних билетов (цена билета здесь указывается в рублях).

## Фабрики

Для продуктов реализованы соответствующие [фабрики](https://github.com/erikrause/course-software-system-architecture/tree/master/AbstractFactory/AbstractFactory/Factory)
