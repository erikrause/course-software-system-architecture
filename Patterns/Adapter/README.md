# Адаптер

## Пример ситуации

Компания, занимающаяся авиасообщениями расширила свой бизнес на международные авиаперелеты. Старая система использовала класс InternalAirFlight, где указывалась единственная страна - Россия. В новом классе AirFlight учитываются две страны - страна отправления и страна назначения. Адаптер InternalAirFlightAdapter адаптирует класс внутренних передетов на расширенный класс AirFlight.

## Классы

- **Target:** [AirFlight](https://github.com/erikrause/course-software-system-architecture/blob/master/Patterns/Adapter/Models/Target/AirFlight.cs) - класс для представления международного маршрута полёта.
- **Adaptee** [InternalAirFlight](https://github.com/erikrause/course-software-system-architecture/blob/master/Patterns/Adapter/Models/Adaptee/InternalAirFlight.cs) - класс для внутренних перелетов по России.
- [InternalAirFlightAdaper](https://github.com/erikrause/course-software-system-architecture/blob/master/Patterns/Adapter/Adapter/InternalAirFlightAdapter.cs) - класс для адаптации внутренних перелётов на международные.
