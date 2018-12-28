using System.Collections.Generic;
using Listable.Models;

namespace Listable.Providers
{
    public interface IWeatherProvider
    {
        List<WeatherForecast> GetForecasts();
    }
}
