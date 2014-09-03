using System;
namespace Service.Controllers
{
    public class Weather
    {
        public Weather(string zipCode)
        {
            Service.ServiceReferenceWeather.WeatherSoapClient client = new Service.ServiceReferenceWeather.WeatherSoapClient("WeatherSoap");
            Service.ServiceReferenceWeather.WeatherReturn weatherCity = client.GetCityWeatherByZIP(zipCode);
            this.city = weatherCity.City;
            this.temperature = Convert.ToString((Convert.ToInt32(weatherCity.Temperature) - 32) * 5 / 9, 10);
            this.pressure = weatherCity.Pressure;
            this.relativeHumidity = weatherCity.RelativeHumidity;
        }
        public string city { get; set; }
        public string temperature { get; set; }
        public string pressure { get; set; }
        public string relativeHumidity { get; set; }
    }
}
